﻿Option Compare Text
Option Explicit On

Imports System.Text
Imports System.Security.Cryptography





Namespace CHCEngines.Encryption



    Public Class HashSHA


        Public Shared Function generateSHA256(ByVal inputString) As String

            Dim sha256 As SHA256 = SHA256Managed.Create()
            Dim bytes As Byte() = Encoding.UTF8.GetBytes(inputString)
            Dim hash As Byte() = sha256.ComputeHash(bytes)
            Dim stringBuilder As New StringBuilder()

            For i As Integer = 0 To hash.Length - 1
                stringBuilder.Append(hash(i).ToString("X2"))
            Next

            Return stringBuilder.ToString()

        End Function

        Public Shared Function generateSHA512(ByVal inputString) As String

            Dim sha512 As SHA512 = SHA512Managed.Create()
            Dim bytes As Byte() = Encoding.UTF8.GetBytes(inputString)
            Dim hash As Byte() = sha512.ComputeHash(bytes)
            Dim stringBuilder As New StringBuilder()

            For i As Integer = 0 To hash.Length - 1
                stringBuilder.Append(hash(i).ToString("X2"))
            Next

            Return stringBuilder.ToString()

        End Function

    End Class

End Namespace