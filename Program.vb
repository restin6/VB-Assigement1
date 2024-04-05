Imports System
Imports System.Data
Imports System.Transactions

Module Module1
    Class User

        Public name As String
        Public classname As String
        Public roll_no As String
        Public Sub insert(ByVal n1 As String, n2 As String, n3 As String)
            name = n1
            classname = n2
            roll_no = n3
        End Sub
        Public Sub display()
            Console.WriteLine("Name: {0}", name)
            Console.WriteLine("Class Name: {0}", classname)
            Console.WriteLine("Roll No: {0}", roll_no)
        End Sub
        Public Sub update()

        End Sub
        Public Sub delete()

        End Sub
    End Class

    Sub Main()
        Dim i As String
        Dim j As Integer
        Dim n As Integer
        Dim obj(5) As User
        Console.WriteLine("Enter Number of User: ")
        n = Console.ReadLine()
        Do

            Console.WriteLine("1-Insert Details")
            Console.WriteLine("2-Display Detailss")
            Console.WriteLine("3-Update Details")
            Console.WriteLine("n4-Delete Details")
            Dim op As Integer
            Console.WriteLine("Enter your Option: ")
            op = Console.ReadLine()
            Select Case op
                Case 1
                    For j = 0 To n - 1
                        obj(j) = New User()
                        Console.WriteLine("Insert user {0} Details", j + 1)
                        Console.WriteLine("Enter Number of User: ")
                        obj(j).name = Console.ReadLine()
                        Console.WriteLine("Enter Class Name : ")
                        obj(j).classname = Console.ReadLine()
                        Console.WriteLine("Enter Roll Number: ")
                        obj(j).roll_no = Console.ReadLine()
                        obj(j).insert(obj(j).name, obj(j).classname, obj(j).roll_no)
                    Next
                Case 2
                    For j = 0 To n - 1
                        Console.WriteLine("User {0} Details", j + 1)
                        obj(j).display()
                        Console.WriteLine(" ")
                    Next
                Case 3
                    Console.WriteLine("Enter which User Do you want to be Update")
                    j = Console.ReadLine()
                    obj(j).update()

                Case 4
                    Console.WriteLine("Enter which User Do you want to be Delete")
                    j = Console.ReadLine()
                    obj(j).delete()

                Case Else
                    Console.WriteLine("Invalid Option")
            End Select
            Console.WriteLine("do you want contioune y / n")
            i = Console.ReadLine()
        Loop While i = "y"
    End Sub

End Module
