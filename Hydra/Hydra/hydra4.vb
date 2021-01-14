Public Class hydra4
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Dim h1 As hydra2 = New hydra2()
        Dim h3 As hydra3 = New hydra3()
        Dim h2 As hydra4 = New hydra4()

        h1.Show()
        h3.Show()
        h2.Show()
        Me.Hide()

        h1.Location = New Point(Rnd() * 900, Rnd() * 180)
        h3.Location = New Point(Rnd() * 860, Rnd() * 300)
        h2.Location = New Point(Rnd() * 700, Rnd() * 485)
    End Sub

    Private Sub hydra4_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        e.Cancel = True
    End Sub

    Private Sub hydra4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TopMost = True
    End Sub
End Class