
Public Class Form1

    ' Function To Generate Keys
    Public Function rdmString1(ByVal lenght As Integer) As String
        Dim strb As New System.Text.StringBuilder
        Dim ch() As String = {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "1", "2", "3", "4", "5", "6", "7", "8", "9", "0"}

        Dim UpperBound As Integer = UBound(ch)

        For x As Integer = 1 To lenght
            strb.Append(ch(Int(Rnd() * UpperBound)))
        Next
        Return strb.ToString


    End Function

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Environment.Exit(0)
        TextBox3.Text = ":: Exiting Key Generator! Goodbye ::"

    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim rdmstring As String
        rdmstring = rdmString1(4) ' You Can Change The Value From 4 To Any Number
        Dim rdmstring2 As String
        rdmstring2 = rdmString1(4) ' Insted Of 4 You Can Have 6 Witch Will Generate 6 Letters & Numbers
        Dim rdmstring3 As String
        rdmstring3 = rdmString1(4)
        Dim rdmstring4 As String
        rdmstring4 = rdmString1(4)

        TextBox2.Text = rdmstring + "-" + rdmstring2 + "-" + rdmstring3 + "-" + rdmstring4 ' You Can Add A Format / Pattern In

        TextBox3.Text = ":: Generated Serial Key! ::"
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        Clipboard.SetText(TextBox2.Text) ' Copys Key To Clipboard
        TextBox3.Text = ":: Serial Key Copied :) ::"

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play(My.Resources.The_Best_Keygen_Song_Ever_HQ, AudioPlayMode.BackgroundLoop) ' Plays Music In The Background And Loops It :)
    End Sub
End Class
