﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.imgurl = New System.Windows.Forms.TextBox()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.TrackBar1 = New System.Windows.Forms.TrackBar()
        Me.Quality_Indicator = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(318, 155)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(223, 52)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "OPEN IN BROWSER"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Paste Video Link:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Image Link:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 28)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(430, 21)
        Me.TextBox1.TabIndex = 5
        '
        'imgurl
        '
        Me.imgurl.Location = New System.Drawing.Point(12, 72)
        Me.imgurl.Name = "imgurl"
        Me.imgurl.ReadOnly = True
        Me.imgurl.Size = New System.Drawing.Size(530, 21)
        Me.imgurl.TabIndex = 7
        '
        'WebBrowser1
        '
        Me.WebBrowser1.AllowWebBrowserDrop = False
        Me.WebBrowser1.IsWebBrowserContextMenuEnabled = False
        Me.WebBrowser1.Location = New System.Drawing.Point(12, 214)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(529, 332)
        Me.WebBrowser1.TabIndex = 8
        Me.WebBrowser1.Url = New System.Uri("about:blank", System.UriKind.Absolute)
        '
        'TrackBar1
        '
        Me.TrackBar1.Location = New System.Drawing.Point(63, 99)
        Me.TrackBar1.Maximum = 4
        Me.TrackBar1.Minimum = 1
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Size = New System.Drawing.Size(342, 45)
        Me.TrackBar1.TabIndex = 0
        Me.TrackBar1.Value = 4
        '
        'Quality_Indicator
        '
        Me.Quality_Indicator.AutoSize = True
        Me.Quality_Indicator.Location = New System.Drawing.Point(412, 103)
        Me.Quality_Indicator.Name = "Quality_Indicator"
        Me.Quality_Indicator.Size = New System.Drawing.Size(55, 15)
        Me.Quality_Indicator.TabIndex = 9
        Me.Quality_Indicator.Text = "MAXRES"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 103)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 15)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Quality:"
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.DefaultExt = "jpg"
        Me.SaveFileDialog1.SupportMultiDottedExtensions = True
        Me.SaveFileDialog1.Title = "Save thumbnail image..."
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button2.Location = New System.Drawing.Point(14, 155)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(108, 52)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "SAVE"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button3.Location = New System.Drawing.Point(128, 155)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(184, 52)
        Me.Button3.TabIndex = 1
        Me.Button3.Text = "PREVIEW"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button4.Location = New System.Drawing.Point(449, 28)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(92, 21)
        Me.Button4.TabIndex = 13
        Me.Button4.Text = "SUMBIT"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(558, 563)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Quality_Indicator)
        Me.Controls.Add(Me.TrackBar1)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Controls.Add(Me.imgurl)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Get YouTube Thumbnail Image"
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents imgurl As TextBox
    Friend WithEvents WebBrowser1 As WebBrowser
    Friend WithEvents TrackBar1 As TrackBar
    Friend WithEvents Quality_Indicator As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
End Class
