Imports Microsoft.VisualBasic
Public Class Form2

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ListBox1.Items.Add(TextBox1.Text)
        TextBox1.Clear()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ListBox1.Items.Remove(ListBox1.SelectedItem)
    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim StreamW As New IO.StreamWriter("Text2.txt")
        For i = 0 To ListBox1.Items.Count - 1
            StreamW.WriteLine(ListBox1.Items.Item(i))
        Next
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
            e.Handled = True
            MessageBox.Show("veuillez entrer un nombre SVP")
        End If
    End Sub


    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Timer1.Start()
        ProgressBar1.Value = "100"
        Timer1.Interval = "1000"
        Dim StreamW As New IO.StreamWriter("text.txt")
        For i = 0 To ListBox1.Items.Count - 1
            StreamW.WriteLine(ListBox1.Items.Item(i))
        Next
        StreamW.WriteLine("900")
        StreamW.Close()
        StreamW.Dispose()
        System.Diagnostics.Process.Start("C:\Users\Ghita\mes etudes\s6\PFE\Untitled2.exe")

    End Sub


End Class