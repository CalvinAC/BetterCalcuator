﻿'Calvin Coxen
'RCET 0265
'Fall 2020
'Better Calculator
'https://github.com/CalvinAC/BetterCalcuator


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

                Do Until data = True

                    'Prompts user to enter a number & verifies that number
                    Try
                        Console.WriteLine("Choose a number: ")
                        userFirstNum = Console.ReadLine()
                        firstNum = CInt(userFirstNum)
                        Console.WriteLine("You Selected: " & userFirstNum)
                        data = True
                    Catch
                        Console.WriteLine("You Selected: " & userFirstNum & ". Please enter a whole number")

                        If userFirstNum = "Q" Then
                            Exit Sub
                        End If

                        data = False
                    End Try

                Loop


                'Prompts user to enter a second number & verifies that number
                Try
                    Console.WriteLine("Choose a second number: ")
                    userSecondNum = Console.ReadLine()
                    secondNum = CInt(userSecondNum)
                    Console.WriteLine("You Selected: " & userSecondNum)
                    data = True
                Catch
                    Console.WriteLine("You Selected: " & userSecondNum & ". Please enter a whole number")
                    If userSecondNum = "Q" Then
                        Exit Sub
                    End If
                    data = False
                End Try

            Loop

            'Prompts user to select a math function
            Do Until userMathSelect = "1" Or userMathSelect = "2" Or userMathSelect = "3" Or userMathSelect = "4"

                'Prompts user to select a math function
                'Verifies selected function is an option

                Try
                    Console.WriteLine("Choose one of the following options:")
                    Console.WriteLine("1. Add")
                    Console.WriteLine("2. Subtract")
                    Console.WriteLine("3. Multiply")
                    Console.WriteLine("4. Divide")

                    userMathSelect = Console.ReadLine()
                    mathNum = CInt(userMathSelect)


                    data = True

                Catch
                    Console.WriteLine("You Selected: " & userSecondNum & ". Please enter a whole number")
                    If userMathSelect = "Q" Then
                        Exit Sub
                    End If
                    data = False

                End Try

                'Performs math operation assigned to number 
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

            data = False
            userMathSelect = ""
        Loop
    End Sub

End Module
