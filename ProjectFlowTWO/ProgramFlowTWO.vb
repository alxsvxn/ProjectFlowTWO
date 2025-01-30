Option Explicit On
Option Strict On
Option Compare Text

Module ProgramFlowTWO

    Sub Main()
        Dim num1 As Integer

        Do

            Console.WriteLine("In the first loop. Loop While num1 <= 3")
            num1 += 1
            Console.WriteLine($"First number is {num1}.")
            Console.WriteLine()

        Loop While num1 <= 3

        Console.WriteLine()

        Do

            Console.WriteLine("In the second loop. Loop While num1 <=")
            num1 += 1
            Console.WriteLine($"First number is {num1}.")
            Console.WriteLine()

        Loop While num1 <= 3

        Console.WriteLine()

        Do Until num1 >= 3

            Console.WriteLine("In the third loop. Loop Until num1 >=")
            num1 += 1
            Console.WriteLine($"First number is {num1}.")
            Console.WriteLine()
        Loop

        Do While num1 >= 3

            Console.WriteLine("In the fourth loop. Loop Until num1 >=")
            num1 -= 1
            Console.WriteLine($"First number is {num1}.")
            Console.WriteLine()
        Loop

        Console.WriteLine()
    End Sub

End Module
