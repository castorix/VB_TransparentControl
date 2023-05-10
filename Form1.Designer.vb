<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.TransparentControl2 = New VB_TransparentControl.TransparentControl()
        Me.TransparentControl1 = New VB_TransparentControl.TransparentControl()
        Me.TransparentControl3 = New VB_TransparentControl.TransparentControl()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(74, 28)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(228, 28)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(527, 301)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(228, 342)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(527, 301)
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        '
        'TransparentControl2
        '
        Me.TransparentControl2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TransparentControl2.ImagePath = ""
        Me.TransparentControl2.Location = New System.Drawing.Point(41, 202)
        Me.TransparentControl2.Name = "TransparentControl2"
        Me.TransparentControl2.Size = New System.Drawing.Size(135, 107)
        Me.TransparentControl2.TabIndex = 4
        '
        'TransparentControl1
        '
        Me.TransparentControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TransparentControl1.ImagePath = ""
        Me.TransparentControl1.Location = New System.Drawing.Point(53, 84)
        Me.TransparentControl1.Name = "TransparentControl1"
        Me.TransparentControl1.Size = New System.Drawing.Size(120, 87)
        Me.TransparentControl1.TabIndex = 1
        '
        'TransparentControl3
        '
        Me.TransparentControl3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TransparentControl3.ImagePath = ""
        Me.TransparentControl3.Location = New System.Drawing.Point(53, 352)
        Me.TransparentControl3.Name = "TransparentControl3"
        Me.TransparentControl3.Size = New System.Drawing.Size(123, 111)
        Me.TransparentControl3.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 655)
        Me.Controls.Add(Me.TransparentControl3)
        Me.Controls.Add(Me.TransparentControl1)
        Me.Controls.Add(Me.TransparentControl2)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents TransparentControl1 As TransparentControl
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents TransparentControl2 As TransparentControl
    Friend WithEvents TransparentControl3 As TransparentControl
End Class
