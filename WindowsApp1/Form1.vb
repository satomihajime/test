Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        test("見積")
        test("発注")
    End Sub

    Private Sub test(name As String)
        Dim cf As ChildForm = New ChildForm()
        cf.name = name
        cf.MdiParent = Me
        cf.Show()

    End Sub

    Private prevLocation As Point
    Private prevSize As Drawing.Size

    Private Sub ToolStripLabel2_Click(sender As Object, e As EventArgs) Handles ToolStripLabel2.Click
        test("テスト")
    End Sub

    Private Sub ToolStripLabel3_Click(sender As Object, e As EventArgs) Handles ToolStripLabel3.Click

        prevSize = Me.Size
        prevLocation = Me.Location

        Dim list = Screen.AllScreens
        If list.Count >= 2 Then

            Dim sc = list.First
            Dim Width = sc.WorkingArea.Width
            Dim Height = sc.WorkingArea.Height

            Me.Size = New Drawing.Size(Width * 2, Height)
            Me.Location = New Drawing.Point(0, 0)

        End If

        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub ToolStripLabel4_Click(sender As Object, e As EventArgs) Handles ToolStripLabel4.Click
        Me.Size = prevSize
        Me.Location = prevLocation

        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub
End Class
