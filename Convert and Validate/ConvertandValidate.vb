'Malachi Marlow
'Spring 2025
'RCET2265
'Convert and Validate
'https://github.com/MalachiMarlow/Convert-and-Validate.git

Option Compare Text
Option Explicit On
Option Strict On

Module ConvertandValidate

    Sub Main()
        'for testing the function add this to your Sub Main()

        Dim aValidNumber As Integer
        Dim usernResponse As String

        Do

            Console.WriteLine($"Enter a number:")

            usernResponse = Console.ReadLine()

            If ConversionValid(usernResponse, aValidNumber) = True Then

                Console.WriteLine($"{usernResponse} converted successfully to {aValidNumber}!")

            Else

                Console.WriteLine($"Oops, {usernResponse} does not seem to be a number")

            End If

        Loop

    End Sub

    'make this work


    Function ConversionValid(convertThisString As String, ByRef toThisInteger As Integer) As Boolean
        Dim status As Boolean

        Try
            toThisInteger = CInt(convertThisString)
            status = True
        Catch ex As Exception

        End Try

        Return status

    End Function


End Module
