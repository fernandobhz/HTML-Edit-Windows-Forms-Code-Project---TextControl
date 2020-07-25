Public Class Form1

    Private Editor1 As LiveSwitch.TextControl.Editor

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Editor1 = New LiveSwitch.TextControl.Editor
        Editor1.Width = Me.ClientSize.Width
        Editor1.Height = Me.ClientSize.Height - 50
        Editor1.Anchor = AnchorStyles.Left Or AnchorStyles.Top Or AnchorStyles.Right

        Me.Controls.Add(Editor1)
    End Sub

    'http://www.codeproject.com/Articles/15559/A-Windows-Forms-based-text-editor-with-HTML-output

    Private Path As String = IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "HtmlEditorWindowsForms.html")

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If My.Computer.FileSystem.FileExists(Path) Then
            Editor1.Html = My.Computer.FileSystem.ReadAllText(Path)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        My.Computer.FileSystem.WriteAllText(Path, Editor1.Html, False)
    End Sub

End Class
