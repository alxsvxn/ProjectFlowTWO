Option Explicit On
Option Strict On
Option Compare Text
Imports System.Diagnostics.Contracts
Imports System.IO

Module ProgramFlowTWO

    Sub Main()
        Dim num1 As Integer
        Dim getOutOfHere As Boolean = False
        Dim userInput As String

        Do
            Console.WriteLine("WELCOME, please enter a number.")
            Console.WriteLine("Or enter Q to quit.")
            userInput = Console.ReadLine()
            Console.WriteLine($"You entered {userInput}.")

            Try
                num1 = CInt(userInput)
                Console.WriteLine($"{userInput} is a great number!")
                Console.WriteLine()
            Catch ex As Exception
                Console.WriteLine($"{userInput} is not a number... :(")
                Console.WriteLine()
            End Try


        Loop While userInput <> "Q"

        Console.WriteLine("Goodbye")

        'Do

        '    Console.WriteLine("In the first loop. Loop While num1 <= 3")
        '    num1 += 1
        '    Console.WriteLine($"First number is {num1}.")
        '    Console.WriteLine()

        'Loop While num1 <= 3

        'Console.WriteLine()

        'Do

        '    Console.WriteLine("In the second loop. Loop While num1 <=")
        '    num1 += 1
        '    Console.WriteLine($"First number is {num1}.")
        '    Console.WriteLine()

        'Loop While num1 <= 3

        'Console.WriteLine()

        'Do Until num1 >= 3

        '    Console.WriteLine("In the third loop. Loop Until num1 >=")
        '    num1 += 1
        '    Console.WriteLine($"First number is {num1}.")
        '    Console.WriteLine()
        'Loop

        'Do While num1 >= 3

        '    Console.WriteLine("In the fourth loop. Loop Until num1 >=")
        '    num1 -= 1
        '    Console.WriteLine($"First number is {num1}.")
        '    Console.WriteLine()
        'Loop

        'Console.WriteLine()


    End Sub

End Module
