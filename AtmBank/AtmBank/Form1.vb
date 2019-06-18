Public Class Form1
    Dim pin As Integer
    Dim Bal As Integer
    Dim Save As Integer
    Dim Deposit As Boolean = False
    Dim sav As Boolean = False
    Dim fileName As String = CurDir() & "\atm.txt"

    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        If System.IO.File.Exists(fileName) Then
            Dim fileReader As New System.IO.StreamReader(fileName)
            pin = fileReader.ReadLine


            Dim theirGuess = InputBox("Please enter your pin")
            Do While theirGuess <> pin
                theirGuess = InputBox("Sorry Wrong Pin" & vbCrLf & "Please try again")
            Loop

            'Outside the loop'
            Bal = fileReader.ReadLine
            Save = fileReader.ReadLine
            fileReader.Close()
        Else
            lblInterface.Text = "Sorry were experinencing some Troubles Chief."
            Exit Sub
            'This will jump out of sub this means the code below will not excute'
        End If
        btnInsert.Enabled = False
        'pin = InputBox("Please enter your pin code")'
        lblInterface.Text = "What would you like to do today?"
        btnWithdraw.Show()
        btnDeposit.Show()
        btnYes.Hide()
        btnNo.Hide()
        txtAmt.Hide()
    End Sub

    Private Sub btnDeposit_Click(sender As Object, e As EventArgs) Handles btnDeposit.Click
        lblInterface.Text = "Which account would you like to use?"
        Deposit = True
        btnDeposit.Hide()
        btnWithdraw.Hide()
        btnChq.Show()
        btnSave.Show()
        txtAmt.Hide()
        btnYes.Hide()
        btnNo.Hide()
    End Sub

    Private Sub btnWithdraw_Click(sender As Object, e As EventArgs) Handles btnWithdraw.Click
        lblInterface.Text = "Which account would you like to use?"
        Deposit = False
        btnDeposit.Hide()
        btnWithdraw.Hide()
        btnChq.Show()
        btnSave.Show()
        txtAmt.Hide()
        btnYes.Hide()
        btnNo.Hide()
    End Sub

    Private Sub txtAmt_KeyUp(sender As Object, e As KeyEventArgs) Handles txtAmt.KeyUp
        Me.Text = e.KeyCode
        If e.KeyCode = 13 Then
            If sav = False Then
                'So Chequing is True'
                If Deposit Then
                    Bal += txtAmt.Text
                    Dim fileWriter As New System.IO.StreamWriter(fileName)
                    fileWriter.WriteLine(pin)
                    fileWriter.WriteLine(Bal)
                    fileWriter.Close()

                    lblInterface.Text = "Nice. Your Balance is now:  $" & Bal & vbCrLf & "Would you like to do anything else?"
                    btnYes.Show()
                    btnNo.Show()
                    txtAmt.Clear()
                    txtAmt.Enabled = False
                End If
                'End if for Deposit
                If Deposit = False Then
                    Bal -= txtAmt.Text
                    Dim fileWriter As New System.IO.StreamWriter(fileName)
                    fileWriter.WriteLine(pin)
                    fileWriter.WriteLine(Bal)
                    fileWriter.Close()

                    lblInterface.Text = "Nice Your Balance is now:  $" & Bal & vbCrLf & "Would you like to do anything else?"
                    btnYes.Show()
                    btnNo.Show()
                    txtAmt.Clear()
                    txtAmt.Enabled = False
                End If
            End If
            'If Cheq is False'
            If sav Then
                'If Savings is True'
                If Deposit Then
                    Save += txtAmt.Text
                    Dim fileWriter As New System.IO.StreamWriter(fileName)
                    fileWriter.WriteLine(pin)
                    fileWriter.WriteLine(Bal)
                    fileWriter.WriteLine(Save)
                    fileWriter.Close()

                    lblInterface.Text = "Nice. Your Balance is now:  $" & Save & vbCrLf & "Would you like to do anything else?"
                    btnYes.Show()
                    btnNo.Show()
                    txtAmt.Clear()
                    txtAmt.Enabled = False
                End If
                'End if for Deposit
                If Deposit = False Then
                    Save -= txtAmt.Text
                    Dim fileWriter As New System.IO.StreamWriter(fileName)
                    fileWriter.WriteLine(pin)
                    fileWriter.WriteLine(Bal)
                    fileWriter.WriteLine(Save)
                    fileWriter.Close()

                    lblInterface.Text = "Nice Your Balance is now:  $" & Save & vbCrLf & "Would you like to do anything else?"
                    btnYes.Show()
                    btnNo.Show()
                    txtAmt.Clear()
                    txtAmt.Enabled = False
                End If
            End If
        End If

    End Sub

    Private Sub btnChq_Click(sender As Object, e As EventArgs) Handles btnChq.Click
        sav = False
        If Deposit Then
            lblInterface.Text = "How much do you, want to deposit?"
        End If
        If Deposit = False Then
            lblInterface.Text = "How much do you, want to withdraw?"
        End If
        btnChq.Hide()
        btnSave.Hide()
        txtAmt.Show()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        sav = True
        If Deposit Then
            lblInterface.Text = "How much do you, want to deposit?"
        End If
        If Deposit = False Then
            lblInterface.Text = "How much do you, want to withdraw?"
        End If
        btnChq.Hide()
        btnSave.Hide()
        txtAmt.Show()
    End Sub

    Private Sub btnNo_Click(sender As Object, e As EventArgs) Handles btnNo.Click
        End
    End Sub

    Private Sub btnYes_Click(sender As Object, e As EventArgs) Handles btnYes.Click
        lblInterface.Text = "What would you like to do today?"
        btnWithdraw.Show()
        btnDeposit.Show()
        btnYes.Hide()
        btnNo.Hide()
        txtAmt.Hide()
    End Sub
End Class
