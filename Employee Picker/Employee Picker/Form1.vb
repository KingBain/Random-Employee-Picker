Public Class frmPicker
    Public Function RandomNumber(ByVal MaxNumber As Integer, ByVal MinNumber As Integer) As Integer

        'initialize random number generator
        Dim r As New Random(System.DateTime.Now.Millisecond)

        'if passed incorrect arguments, swap them
        'can also throw exception or return 0

        If MinNumber > MaxNumber Then
            Dim t As Integer = MinNumber
            MinNumber = MaxNumber
            MaxNumber = t
        End If

        Return r.Next(MinNumber, MaxNumber)

    End Function


    Private Sub btnLoad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoad.Click

        clbPeople.Items.Clear()
        Dim oRead As System.IO.StreamReader
        Dim LineIn As String
        oRead = IO.File.OpenText("people.txt")

        While oRead.Peek <> -1
            LineIn = oRead.ReadLine()
            If LineIn <> "" Then
                clbPeople.Items.Add(LineIn)
            End If

        End While

        oRead.Close()
        numBox.Enabled = True

    End Sub


    Private Sub numBox_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles numBox.ValueChanged
        If numBox.Value <> 0 Then
            btnRandom.Enabled = True
        Else
            btnRandom.Enabled = False
        End If
    End Sub

    Private Sub btnRandom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRandom.Click

        Dim person As Object
        Dim holder As New ArrayList
        Dim count = 0
        Dim winner = ""


        For Each person In clbPeople.CheckedItems
            holder.Add(person.ToString())
            count += 1
        Next (person)


        If count <= numBox.Value Then
            MsgBox("Please select more people from the list or lower the amount of people you need")
        Else
            Dim aRandom As New Random 'random number generator
            Dim aNumber As Integer 'a palce to store a random number
            Dim aRndL As List(Of String)
            aRndL = New List(Of String)

            Do While aRndL.Count < numBox.Value
                aNumber = aRandom.Next(0, count) 'pick a number from 0 to the total amount of people selected
                If aRndL.IndexOf(aNumber.ToString) = -1 Then 'not picked
                    winner += holder(aNumber.ToString) + " "
                    aRndL.Add(aNumber.ToString) 'add it

                End If
            Loop

            MsgBox(winner)

        End If
        



    End Sub
End Class
