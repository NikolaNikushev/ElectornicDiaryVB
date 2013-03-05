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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(message))
        Me.messageInfo = New System.Windows.Forms.RichTextBox()
        Me.labelToWho = New System.Windows.Forms.Label()
        Me.labelToWhoInfo = New System.Windows.Forms.Label()
        Me.send = New System.Windows.Forms.Button()
        Me.back = New System.Windows.Forms.Button()
        Me.Mail = New System.Windows.Forms.Label()
        Me.Subjected = New System.Windows.Forms.Label()
        Me.YourMail = New System.Windows.Forms.TextBox()
        Me.Subject = New System.Windows.Forms.TextBox()
        Me.YourPassword = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'messageInfo
        '
        Me.messageInfo.Location = New System.Drawing.Point(101, 71)
        Me.messageInfo.Name = "messageInfo"
        Me.messageInfo.Size = New System.Drawing.Size(420, 209)
        Me.messageInfo.TabIndex = 8
        Me.messageInfo.Text = ""
        '
        'labelToWho
        '
        Me.labelToWho.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.labelToWho.Location = New System.Drawing.Point(159, 340)
        Me.labelToWho.Name = "labelToWho"
        Me.labelToWho.Size = New System.Drawing.Size(284, 54)
        Me.labelToWho.TabIndex = 7
        '
        'labelToWhoInfo
        '
        Me.labelToWhoInfo.AutoSize = True
        Me.labelToWhoInfo.Location = New System.Drawing.Point(128, 340)
        Me.labelToWhoInfo.Name = "labelToWhoInfo"
        Me.labelToWhoInfo.Size = New System.Drawing.Size(25, 13)
        Me.labelToWhoInfo.TabIndex = 6
        Me.labelToWhoInfo.Text = "До:"
        '
        'send
        '
        Me.send.Location = New System.Drawing.Point(449, 340)
        Me.send.Name = "send"
        Me.send.Size = New System.Drawing.Size(103, 42)
        Me.send.TabIndex = 5
        Me.send.Text = "Изпрати"
        Me.send.UseVisualStyleBackColor = True
        '
        'back
        '
        Me.back.Location = New System.Drawing.Point(12, 340)
        Me.back.Name = "back"
        Me.back.Size = New System.Drawing.Size(98, 42)
        Me.back.TabIndex = 9
        Me.back.Text = "Върни се"
        Me.back.UseVisualStyleBackColor = True
        '
        'Mail
        '
        Me.Mail.AutoSize = True
        Me.Mail.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Mail.Location = New System.Drawing.Point(6, 13)
        Me.Mail.Name = "Mail"
        Me.Mail.Size = New System.Drawing.Size(108, 17)
        Me.Mail.TabIndex = 10
        Me.Mail.Text = "Вашият емайл:"
        '
        'Subjected
        '
        Me.Subjected.AutoSize = True
        Me.Subjected.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Subjected.Location = New System.Drawing.Point(65, 45)
        Me.Subjected.Name = "Subjected"
        Me.Subjected.Size = New System.Drawing.Size(46, 17)
        Me.Subjected.TabIndex = 11
        Me.Subjected.Text = "Тема:"
        '
        'YourMail
        '
        Me.YourMail.Location = New System.Drawing.Point(117, 12)
        Me.YourMail.Name = "YourMail"
        Me.YourMail.Size = New System.Drawing.Size(189, 20)
        Me.YourMail.TabIndex = 12
        '
        'Subject
        '
        Me.Subject.Location = New System.Drawing.Point(117, 45)
        Me.Subject.Name = "Subject"
        Me.Subject.Size = New System.Drawing.Size(189, 20)
        Me.Subject.TabIndex = 13
        '
        'YourPassword
        '
        Me.YourPassword.Location = New System.Drawing.Point(191, 296)
        Me.YourPassword.Name = "YourPassword"
        Me.YourPassword.Size = New System.Drawing.Size(189, 20)
        Me.YourPassword.TabIndex = 14
        Me.YourPassword.UseSystemPasswordChar = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 296)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(173, 17)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Парола към емайлът Ви:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label2.Location = New System.Drawing.Point(386, 297)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(167, 17)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "(Не се запомня никъде)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 168)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 17)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Съобщение:"
        '
        'message
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(564, 394)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.YourPassword)
        Me.Controls.Add(Me.Subject)
        Me.Controls.Add(Me.YourMail)
        Me.Controls.Add(Me.Subjected)
        Me.Controls.Add(Me.Mail)
        Me.Controls.Add(Me.back)
        Me.Controls.Add(Me.messageInfo)
        Me.Controls.Add(Me.labelToWho)
        Me.Controls.Add(Me.labelToWhoInfo)
        Me.Controls.Add(Me.send)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "message"
        Me.Text = "Ново съобщение"
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Private WithEvents messageInfo As System.Windows.Forms.RichTextBox
    Public WithEvents labelToWho As System.Windows.Forms.Label
    Private WithEvents labelToWhoInfo As System.Windows.Forms.Label
    Private WithEvents send As System.Windows.Forms.Button
    Friend WithEvents back As System.Windows.Forms.Button
    Friend WithEvents Mail As System.Windows.Forms.Label
    Friend WithEvents Subjected As System.Windows.Forms.Label
    Friend WithEvents YourMail As System.Windows.Forms.TextBox
    Friend WithEvents Subject As System.Windows.Forms.TextBox
    Friend WithEvents YourPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
