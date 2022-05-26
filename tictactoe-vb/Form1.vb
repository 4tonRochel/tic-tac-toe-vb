Public Class Form1
    Dim forXorO As Boolean = False
    Dim countOneToScore As Byte = 0

    Sub buttonsEnabledFalse()
        btn1.Enabled = False
        btn2.Enabled = False
        btn3.Enabled = False
        btn4.Enabled = False
        btn5.Enabled = False
        btn6.Enabled = False
        btn7.Enabled = False
        btn8.Enabled = False
        btn9.Enabled = False
    End Sub

    Sub TheWinner()
        'For X ---------------------------------------------------------------------------------------------------
        If btn1.Text = "X" And btn2.Text = "X" And btn3.Text = "X" Then
            btn1.BackColor = Color.Blue
            btn2.BackColor = Color.Blue
            btn3.BackColor = Color.Blue
            MessageBox.Show("Player X Wins!", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information)
            countOneToScore = Convert.ToByte(lblScoreX.Text)
            lblScoreX.Text = Convert.ToString(countOneToScore + 1)
            buttonsEnabledFalse()
        End If
        If btn4.Text = "X" And btn5.Text = "X" And btn6.Text = "X" Then
            btn4.BackColor = Color.Blue
            btn5.BackColor = Color.Blue
            btn6.BackColor = Color.Blue
            MessageBox.Show("Player X Wins!", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information)
            countOneToScore = Convert.ToByte(lblScoreX.Text)
            lblScoreX.Text = Convert.ToString(countOneToScore + 1)
            buttonsEnabledFalse()
        End If
        If btn7.Text = "X" And btn8.Text = "X" And btn9.Text = "X" Then
            btn7.BackColor = Color.Blue
            btn8.BackColor = Color.Blue
            btn9.BackColor = Color.Blue
            MessageBox.Show("Player X Wins!", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information)
            countOneToScore = Convert.ToByte(lblScoreX.Text)
            lblScoreX.Text = Convert.ToString(countOneToScore + 1)
            buttonsEnabledFalse()
        End If
        If btn1.Text = "X" And btn4.Text = "X" And btn7.Text = "X" Then
            btn1.BackColor = Color.Blue
            btn4.BackColor = Color.Blue
            btn7.BackColor = Color.Blue
            MessageBox.Show("Player X Wins!", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information)
            countOneToScore = Convert.ToByte(lblScoreX.Text)
            lblScoreX.Text = Convert.ToString(countOneToScore + 1)
            buttonsEnabledFalse()
        End If
        If btn2.Text = "X" And btn5.Text = "X" And btn8.Text = "X" Then
            btn2.BackColor = Color.Blue
            btn5.BackColor = Color.Blue
            btn8.BackColor = Color.Blue
            MessageBox.Show("Player X Wins!", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information)
            countOneToScore = Convert.ToByte(lblScoreX.Text)
            lblScoreX.Text = Convert.ToString(countOneToScore + 1)
            buttonsEnabledFalse()
        End If
        If btn3.Text = "X" And btn6.Text = "X" And btn9.Text = "X" Then
            btn3.BackColor = Color.Blue
            btn6.BackColor = Color.Blue
            btn9.BackColor = Color.Blue
            MessageBox.Show("Player X Wins!", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information)
            countOneToScore = Convert.ToByte(lblScoreX.Text)
            lblScoreX.Text = Convert.ToString(countOneToScore + 1)
            buttonsEnabledFalse()
        End If
        If btn1.Text = "X" And btn5.Text = "X" And btn9.Text = "X" Then
            btn1.BackColor = Color.Blue
            btn5.BackColor = Color.Blue
            btn9.BackColor = Color.Blue
            MessageBox.Show("Player X Wins!", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information)
            countOneToScore = Convert.ToByte(lblScoreX.Text)
            lblScoreX.Text = Convert.ToString(countOneToScore + 1)
            buttonsEnabledFalse()
        End If
        If btn3.Text = "X" And btn5.Text = "X" And btn7.Text = "X" Then
            btn3.BackColor = Color.Blue
            btn5.BackColor = Color.Blue
            btn7.BackColor = Color.Blue
            MessageBox.Show("Player X Wins!", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information)
            countOneToScore = Convert.ToByte(lblScoreX.Text)
            lblScoreX.Text = Convert.ToString(countOneToScore + 1)
            buttonsEnabledFalse()
        End If

        'For O
        If btn1.Text = "O" And btn2.Text = "O" And btn3.Text = "O" Then
            btn1.BackColor = Color.Red
            btn2.BackColor = Color.Red
            btn3.BackColor = Color.Red
            MessageBox.Show("Player O Wins!", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information)
            countOneToScore = Convert.ToByte(lblScoreO.Text)
            lblScoreO.Text = Convert.ToString(countOneToScore + 1)
            buttonsEnabledFalse()
        End If
        If btn4.Text = "O" And btn5.Text = "O" And btn6.Text = "O" Then
            btn4.BackColor = Color.Red
            btn5.BackColor = Color.Red
            btn6.BackColor = Color.Red
            MessageBox.Show("Player O Wins!", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information)
            countOneToScore = Convert.ToByte(lblScoreO.Text)
            lblScoreO.Text = Convert.ToString(countOneToScore + 1)
            buttonsEnabledFalse()
        End If
        If btn7.Text = "O" And btn8.Text = "O" And btn9.Text = "O" Then
            btn7.BackColor = Color.Red
            btn8.BackColor = Color.Red
            btn9.BackColor = Color.Red
            MessageBox.Show("Player O Wins!", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information)
            countOneToScore = Convert.ToByte(lblScoreO.Text)
            lblScoreO.Text = Convert.ToString(countOneToScore + 1)
            buttonsEnabledFalse()
        End If
        If btn1.Text = "O" And btn4.Text = "O" And btn7.Text = "O" Then
            btn1.BackColor = Color.Red
            btn4.BackColor = Color.Red
            btn7.BackColor = Color.Red
            MessageBox.Show("Player O Wins!", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information)
            countOneToScore = Convert.ToByte(lblScoreO.Text)
            lblScoreO.Text = Convert.ToString(countOneToScore + 1)
            buttonsEnabledFalse()
        End If
        If btn2.Text = "O" And btn5.Text = "O" And btn8.Text = "O" Then
            btn2.BackColor = Color.Red
            btn5.BackColor = Color.Red
            btn8.BackColor = Color.Red
            MessageBox.Show("Player O Wins!", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information)
            countOneToScore = Convert.ToByte(lblScoreO.Text)
            lblScoreO.Text = Convert.ToString(countOneToScore + 1)
            buttonsEnabledFalse()
        End If
        If btn3.Text = "O" And btn6.Text = "O" And btn9.Text = "O" Then
            btn3.BackColor = Color.Red
            btn6.BackColor = Color.Red
            btn9.BackColor = Color.Red
            MessageBox.Show("Player O Wins!", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information)
            countOneToScore = Convert.ToByte(lblScoreO.Text)
            lblScoreO.Text = Convert.ToString(countOneToScore + 1)
            buttonsEnabledFalse()
        End If
        If btn1.Text = "O" And btn5.Text = "O" And btn9.Text = "O" Then
            btn1.BackColor = Color.Red
            btn5.BackColor = Color.Red
            btn9.BackColor = Color.Red
            MessageBox.Show("Player O Wins!", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information)
            countOneToScore = Convert.ToByte(lblScoreO.Text)
            lblScoreO.Text = Convert.ToString(countOneToScore + 1)
            buttonsEnabledFalse()
        End If
        If btn3.Text = "O" And btn5.Text = "O" And btn7.Text = "O" Then
            btn3.BackColor = Color.Red
            btn5.BackColor = Color.Red
            btn7.BackColor = Color.Red
            MessageBox.Show("Player O Wins!", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information)
            countOneToScore = Convert.ToByte(lblScoreO.Text)
            lblScoreO.Text = Convert.ToString(countOneToScore + 1)
            buttonsEnabledFalse()
        End If
    End Sub

    Private Sub Button_Click(sender As Object, e As EventArgs) Handles btn9.Click, btn8.Click, btn7.Click, btn6.Click, btn5.Click, btn4.Click, btn3.Click, btn2.Click, btn1.Click
        Dim a As Button = sender
        If forXorO = False Then
            a.Text = "X"
            forXorO = True
        Else
            a.Text = "O"
            forXorO = False
        End If
        TheWinner()
        a.Enabled = False
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        btn1.Enabled = True
        btn2.Enabled = True
        btn3.Enabled = True
        btn4.Enabled = True
        btn5.Enabled = True
        btn6.Enabled = True
        btn7.Enabled = True
        btn8.Enabled = True
        btn9.Enabled = True

        btn1.Text = ""
        btn2.Text = ""
        btn3.Text = ""
        btn4.Text = ""
        btn5.Text = ""
        btn6.Text = ""
        btn7.Text = ""
        btn8.Text = ""
        btn9.Text = ""

        btn1.BackColor = Color.White
        btn2.BackColor = Color.White
        btn3.BackColor = Color.White
        btn4.BackColor = Color.White
        btn5.BackColor = Color.White
        btn6.BackColor = Color.White
        btn7.BackColor = Color.White
        btn8.BackColor = Color.White
        btn9.BackColor = Color.White
    End Sub

    Private Sub btnNewGame_Click(sender As Object, e As EventArgs) Handles btnNewGame.Click
        btn1.Enabled = True
        btn2.Enabled = True
        btn3.Enabled = True
        btn4.Enabled = True
        btn5.Enabled = True
        btn6.Enabled = True
        btn7.Enabled = True
        btn8.Enabled = True
        btn9.Enabled = True

        btn1.Text = ""
        btn2.Text = ""
        btn3.Text = ""
        btn4.Text = ""
        btn5.Text = ""
        btn6.Text = ""
        btn7.Text = ""
        btn8.Text = ""
        btn9.Text = ""

        btn1.BackColor = Color.White
        btn2.BackColor = Color.White
        btn3.BackColor = Color.White
        btn4.BackColor = Color.White
        btn5.BackColor = Color.White
        btn6.BackColor = Color.White
        btn7.BackColor = Color.White
        btn8.BackColor = Color.White
        btn9.BackColor = Color.White

        lblScoreX.Text = "0"
        lblScoreO.Text = "0"
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim forExit As DialogResult = MessageBox.Show("Are you sure you want to quit ?", "Tic Tac Toe", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If forExit = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub


End Class
