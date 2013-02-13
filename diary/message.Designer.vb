<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class message
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
        Me.richTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'richTextBox1
        '
        Me.richTextBox1.Location = New System.Drawing.Point(12, 12)
        Me.richTextBox1.Name = "richTextBox1"
        Me.richTextBox1.Size = New System.Drawing.Size(260, 209)
        Me.richTextBox1.TabIndex = 8
        Me.richTextBox1.Text = ""
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(124, 232)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(35, 13)
        Me.label2.TabIndex = 7
        Me.label2.Text = "label2"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(93, 232)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(25, 13)
        Me.label1.TabIndex = 6
        Me.label1.Text = "До:"
        '
        'button1
        '
        Me.button1.Location = New System.Drawing.Point(197, 227)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(75, 23)
        Me.button1.TabIndex = 5
        Me.button1.Text = "Изпрати"
        Me.button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(12, 227)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Върни се"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'message
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.richTextBox1)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.button1)
        Me.Name = "message"
        Me.Text = "message"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents richTextBox1 As System.Windows.Forms.RichTextBox
    Public WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
