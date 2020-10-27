'Calvin Coxen
'RCET 0265
'Fall 2020
'Better Calculator


Option Explicit On
Option Strict On
Option Compare Text
Module BetterCalculator

    Sub Main()
        Dim userFirstNum, userSecondNum, userMathSelect As String
        Dim firstNum, secondNum, mathNum As Integer
        Dim data As Boolean




        Do
            Console.WriteLine("Please enter 2 numbers. Enter 'Q' at any time to quit")
            Do Until data = True

                Do Until data = True ' "Q" is not evaluated here - TJR

                    Try
                        Console.WriteLine("Choose a number: ")
                        userFirstNum = Console.ReadLine()
                        firstNum = CInt(userFirstNum)
                        Console.WriteLine("You Selected: " & userFirstNum)
                        data = True
                    Catch
                        Console.WriteLine("You Selected: " & userFirstNum & ". Please enter a whole number")
                        data = False

                    End Try

                Loop



                Try
                    Console.WriteLine("Choose a second number: ")
                    userSecondNum = Console.ReadLine()
                    secondNum = CInt(userSecondNum)
                    Console.WriteLine("You Selected: " & userSecondNum)
                    data = True
                Catch
                    Console.WriteLine("You Selected: " & userSecondNum & ". Please enter a whole number")
                    data = False
                End Try

                If data = False Then
                    'unused remove this - TJR
                End If

            Loop

            Do Until userMathSelect = "1" Or userMathSelect = "2" Or userMathSelect = "3" Or userMathSelect = "4" ' "Q" is not evaluated here - TJR

                Console.WriteLine("Choose one of the following options:")
                Console.WriteLine("1. Add")
                Console.WriteLine("2. Subtract")
                Console.WriteLine("3. Multiply")
                Console.WriteLine("4. Divide")

                userMathSelect = Console.ReadLine()
                mathNum = CInt(userMathSelect) 'Crashes here with bad input. Put conversion in a try catch. - TJR

                If mathNum > 4 Then
                    Console.WriteLine("That is not a math option, please select 1-4")
                ElseIf mathNum = 1 Then
                    Console.WriteLine("Your Answer: " & firstNum + secondNum)
                    Console.ReadLine()
                ElseIf mathNum = 2 Then
                    Console.WriteLine("Your Answer: " & firstNum - secondNum)
                    Console.ReadLine()
                ElseIf mathNum = 3 Then
                    Console.WriteLine("Your Answer: " & firstNum * secondNum)
                    Console.ReadLine()
                ElseIf mathNum = 4 Then
                    Console.WriteLine("Your Answer: " & firstNum / secondNum)
                    Console.ReadLine()
                ElseIf mathNum < 4 Then
                    Console.WriteLine("That is not a math option, please select 1-4")
                End If

            Loop

            'This extra user input with no prompt is awkward - TJR 
            'Ask user if they want to quit or continue - TJR
            'even better evaluate for Q in each of the user inputs from above. - TJR
            If Console.ReadKey().Key = ConsoleKey.Q Then
                Exit Sub
            End If

            'Here is the bug you mentioned - TJR
            'Set data to False here to continue - TJR
            'Clear userMathSelect here to continue - TJR
            data = False
            userMathSelect = ""
        Loop
    End Sub

End Module
