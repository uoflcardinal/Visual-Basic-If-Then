Module Module1

    Sub Main()

        ' Declaration of variables for user input
        Dim number1, number2 As Integer

        ' Read first number from user input
        Console.WriteLine("Please enter first integer: ")
        number1 = Console.ReadLine()

        ' Read second number from user input
        Console.WriteLine("Please enter second integer: ")
        number2 = Console.ReadLine()

        ' Check for comparison with relational operators

        If number1 = number2 Then
            Console.WriteLine("{0} is equal to {1}", number1, number2)
        End If

        If number1 <> number2 Then
            Console.WriteLine("{0} is not equal to {1}", number1, number2)
        End If

        If number1 > number2 Then
            Console.WriteLine("{0} is greater than {1}", number1, number2)
        End If

        If number1 < number2 Then
            Console.WriteLine("{0} is less than {1}", number1, number2)
        End If

        If number1 >= number2 Then
            Console.WriteLine("{0} is greater than or equal to {1}", number1, number2)
        End If

        If number1 <= number2 Then
            Console.WriteLine("{0} is less than or equal to {1}", number1, number2)
        End If

        If number1 = 0 Then
            Console.WriteLine("{0} number one is equal to zero", number1)
        End If

    End Sub

End Module
