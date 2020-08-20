Imports System
Imports System.IO
Imports System.Security.Cryptography
Imports System.Text
Imports System.Runtime.CompilerServices

Namespace Utilities
    Module PortableCryptography
        Private ReadOnly defaultSalt As Byte() = Encoding.ASCII.GetBytes("SharePointComparer")

        <Extension()>
        Function HashSHA512(ByVal value As String) As String
            Dim strBuilder As StringBuilder = New StringBuilder(value)
            strBuilder.Append(defaultSalt)

            Using sha = SHA512.Create()
                Return Convert.ToBase64String(sha.ComputeHash(Encoding.UTF8.GetBytes(strBuilder.ToString())))
            End Using
        End Function

        Private Function CreateKey(ByVal password As String, ByVal Optional keyBytes As Integer = 32) As Byte()
            Dim salt As Byte() = New Byte() {80, 70, 60, 50, 40, 30, 20, 10}
            Dim iterations As Integer = 300
            Dim keyGenerator = New Rfc2898DeriveBytes(password, salt, iterations)
            Return keyGenerator.GetBytes(keyBytes)
        End Function

        <Extension()>
        Function Encrypt(ByVal clearValue As String, ByVal encryptionKey As String) As String
            Using aes As Aes = Aes.Create()
                aes.Key = CreateKey(encryptionKey)
                Dim encrypted As Byte() = AesEncryptStringToBytes(clearValue, aes.Key, aes.IV)
                Return Convert.ToBase64String(encrypted) & ";" & Convert.ToBase64String(aes.IV)
            End Using
        End Function

        Private Function AesEncryptStringToBytes(ByVal plainText As String, ByVal key As Byte(), ByVal iv As Byte()) As Byte()
            If plainText Is Nothing OrElse plainText.Length <= 0 Then Throw New ArgumentNullException($"{NameOf(plainText)}")
            If key Is Nothing OrElse key.Length <= 0 Then Throw New ArgumentNullException($"{NameOf(key)}")
            If iv Is Nothing OrElse iv.Length <= 0 Then Throw New ArgumentNullException($"{NameOf(iv)}")
            Dim encrypted As Byte()

            Using aes As Aes = Aes.Create()
                aes.Key = key
                aes.IV = iv

                Using memoryStream As MemoryStream = New MemoryStream()

                    Using encryptor As ICryptoTransform = aes.CreateEncryptor()

                        Using cryptoStream As CryptoStream = New CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write)

                            Using streamWriter As StreamWriter = New StreamWriter(cryptoStream)
                                streamWriter.Write(plainText)
                            End Using
                        End Using
                    End Using

                    encrypted = memoryStream.ToArray()
                End Using
            End Using

            Return encrypted
        End Function

        <Extension()>
        Function Decrypt(ByVal encryptedValue As String, ByVal encryptionKey As String) As String
            '
            If Not (encryptedValue.Contains(";")) Then
                Return String.Empty
            End If

            If String.IsNullOrEmpty(encryptedValue) Then
                Return String.Empty
            End If

            Dim iv As String = encryptedValue.Substring(encryptedValue.IndexOf(";"c) + 1, encryptedValue.Length - encryptedValue.IndexOf(";"c) - 1)
            encryptedValue = encryptedValue.Substring(0, encryptedValue.IndexOf(";"c))
            Return AesDecryptStringFromBytes(Convert.FromBase64String(encryptedValue), CreateKey(encryptionKey), Convert.FromBase64String(iv))
        End Function

        Private Function AesDecryptStringFromBytes(ByVal cipherText As Byte(), ByVal key As Byte(), ByVal iv As Byte()) As String
            If cipherText Is Nothing OrElse cipherText.Length <= 0 Then Throw New ArgumentNullException($"{NameOf(cipherText)}")
            If key Is Nothing OrElse key.Length <= 0 Then Throw New ArgumentNullException($"{NameOf(key)}")
            If iv Is Nothing OrElse iv.Length <= 0 Then Throw New ArgumentNullException($"{NameOf(iv)}")
            Dim plaintext As String = Nothing

            Using aes As Aes = Aes.Create()
                aes.Key = key
                aes.IV = iv

                Using memoryStream As MemoryStream = New MemoryStream(cipherText)

                    Using decryptor As ICryptoTransform = aes.CreateDecryptor()

                        Using cryptoStream As CryptoStream = New CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read)

                            Using streamReader As StreamReader = New StreamReader(cryptoStream)
                                plaintext = streamReader.ReadToEnd()
                            End Using
                        End Using
                    End Using
                End Using
            End Using

            Return plaintext
        End Function
    End Module
End Namespace
