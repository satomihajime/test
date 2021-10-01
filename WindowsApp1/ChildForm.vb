Public Class ChildForm

    Public name As String

    Private Sub ChildForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Label1.Text = name
    End Sub
End Class