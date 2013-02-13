<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addSubject
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
        Me.textBox4 = New System.Windows.Forms.TextBox()
        Me.label5 = New System.Windows.Forms.Label()
        Me.button2 = New System.Windows.Forms.Button()
        Me.textBox3 = New System.Windows.Forms.TextBox()
        Me.label4 = New System.Windows.Forms.Label()
        Me.textBox2 = New System.Windows.Forms.TextBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.checkBox1 = New System.Windows.Forms.CheckBox()
        Me.button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'textBox4
        '
        Me.textBox4.Location = New System.Drawing.Point(127, 71)
        Me.textBox4.Name = "textBox4"
        Me.textBox4.Size = New System.Drawing.Size(100, 20)
        Me.textBox4.TabIndex = 23
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(5, 71)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(116, 13)
        Me.label5.TabIndex = 22
        Me.label5.Text = "Колко часа седмично"
        '
        'button2
        '
        Me.button2.Location = New System.Drawing.Point(6, 119)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(95, 23)
        Me.button2.TabIndex = 21
        Me.button2.Text = "Върни се"
        Me.button2.UseVisualStyleBackColor = True
        '
        'textBox3
        '
        Me.textBox3.Location = New System.Drawing.Point(127, 41)
        Me.textBox3.Name = "textBox3"
        Me.textBox3.Size = New System.Drawing.Size(100, 20)
        Me.textBox3.TabIndex = 20
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(5, 41)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(80, 13)
        Me.label4.TabIndex = 19
        Me.label4.Text = "Преподавател"
        '
        'textBox2
        '
        Me.textBox2.Location = New System.Drawing.Point(127, 9)
        Me.textBox2.Name = "textBox2"
        Me.textBox2.Size = New System.Drawing.Size(100, 20)
        Me.textBox2.TabIndex = 18
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(5, 9)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(29, 13)
        Me.label3.TabIndex = 17
        Me.label3.Text = "Име"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(5, 97)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(42, 13)
        Me.label2.TabIndex = 16
        Me.label2.Text = "Модул:"
        '
        'checkBox1
        '
        Me.checkBox1.AutoSize = True
        Me.checkBox1.Location = New System.Drawing.Point(53, 97)
        Me.checkBox1.Name = "checkBox1"
        Me.checkBox1.Size = New System.Drawing.Size(80, 17)
        Me.checkBox1.TabIndex = 15
        Me.checkBox1.Text = "checkBox1"
        Me.checkBox1.UseVisualStyleBackColor = True
        '
        'button1
        '
        Me.button1.Location = New System.Drawing.Point(152, 109)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(75, 33)
        Me.button1.TabIndex = 12
        Me.button1.Text = "Добави"
        Me.button1.UseVisualStyleBackColor = True
        '
        'addSubject
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(236, 149)
        Me.Controls.Add(Me.textBox4)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.button2)
        Me.Controls.Add(Me.textBox3)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.textBox2)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.checkBox1)
        Me.Controls.Add(Me.button1)
        Me.Name = "addSubject"
        Me.Text = "addSubject"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents textBox4 As System.Windows.Forms.TextBox
    Private WithEvents label5 As System.Windows.Forms.Label
    Private WithEvents button2 As System.Windows.Forms.Button
    Private WithEvents textBox3 As System.Windows.Forms.TextBox
    Private WithEvents label4 As System.Windows.Forms.Label
    Private WithEvents textBox2 As System.Windows.Forms.TextBox
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents checkBox1 As System.Windows.Forms.CheckBox
    Private WithEvents button1 As System.Windows.Forms.Button
End Class
