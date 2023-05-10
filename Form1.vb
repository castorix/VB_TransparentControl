Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim hBitmap As IntPtr = TransparentControl1.LoadImage("Hulk.png", System.Drawing.Color.FromArgb(0))
        TransparentControl1.SetBitmap(hBitmap)
        Dim hBitmap2 As IntPtr = TransparentControl2.LoadImage("Butterfly_small.png", System.Drawing.Color.FromArgb(0))
        TransparentControl2.SetBitmap(hBitmap2)
        Dim hBitmap3 As IntPtr = TransparentControl2.LoadImage("Soccer_Ball_256.png", System.Drawing.Color.FromArgb(0))
        TransparentControl3.SetBitmap(hBitmap3)
    End Sub
End Class
