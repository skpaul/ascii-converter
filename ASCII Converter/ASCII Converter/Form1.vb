Public Class Form1

    Public Sub New()

        InitializeComponent()
        Me.Icon = My.Resources.keyboardIco
        btnCharToAscii.Image = My.Resources.five
        btnAsciiToChar.Image = My.Resources.Six
        btnReset.Image = My.Resources.reset
    End Sub

    Private Sub txtCharacter_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCharacter.KeyPress
        txtAscii.Text = Asc(e.KeyChar)
    End Sub

    Private Sub txtAscii_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAscii.KeyPress

    End Sub

    Private Sub txtAscii_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtAscii.KeyUp
        Try
            txtCharacter.Text = Chr(CInt(txtAscii.Text))
        Catch ex As Exception
            Exit Sub
        End Try

    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        txtCharacter.Clear()
        txtAscii.Clear()
    End Sub
End Class
