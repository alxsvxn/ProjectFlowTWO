Option Explicit On
Option Strict On
Option Compare Text
Imports System.Diagnostics.Contracts
Imports System.IO
Imports System.Linq.Expressions

Module ProgramFlowTWO

    Sub Main()
        Dim num1 As Integer
        Dim getOutOfHere As Boolean = False
        Dim userInput As String
        Dim userInput2 As String
        Dim num2 As Integer
        Do
            Do
                Console.WriteLine("WELCOME, please enter a number.")
                Console.WriteLine("Or enter Q to quit.")
                userInput = Console.ReadLine()
                Console.WriteLine($"You entered {userInput}.")

                Try
                    num1 = CInt(userInput)
                    getOutOfHere = True

                    Console.WriteLine($"{userInput} is a great number!")
                    Console.WriteLine()

                Catch ex As Exception

                    If userInput <> "Q" Then
                        Console.WriteLine($"{userInput} is not a number :/")
                    Else
                        getOutOfHere = True
                    End If
                End Try

            Loop Until getOutOfHere = True

            getOutOfHere = False

            Do While userInput <> "Q" And getOutOfHere = False

                Console.WriteLine("Please enter another number.")
                Console.WriteLine("Or enter Q to quit.")
                userInput2 = Console.ReadLine()
                Console.WriteLine($"You entered {userInput2}.")

                Try
                    num2 = CInt(userInput2)
                    getOutOfHere = True
                    Console.WriteLine($"{userInput2} is a great number!")
                    Console.WriteLine()
                Catch ex As Exception
                    If userInput2 <> "Q" Then
                        Console.WriteLine($"{userInput2} is not a number :/")
                    Else
                        getOutOfHere = True
                    End If
                End Try
            Loop

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
