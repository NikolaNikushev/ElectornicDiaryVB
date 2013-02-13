<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class summary
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
        Me.listView1 = New System.Windows.Forms.ListView()
        Me.button2 = New System.Windows.Forms.Button()
        Me.button1 = New System.Windows.Forms.Button()
        Me.label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'listView1
        '
        Me.listView1.Alignment = System.Windows.Forms.ListViewAlignment.Left
        Me.listView1.Location = New System.Drawing.Point(4, 25)
        Me.listView1.Name = "listView1"
        Me.listView1.Size = New System.Drawing.Size(269, 205)
        Me.listView1.TabIndex = 7
        Me.listView1.TileSize = New System.Drawing.Size(250, 30)
        Me.listView1.UseCompatibleStateImageBehavior = False
        Me.listView1.View = System.Windows.Forms.View.Tile
        '
        'button2
        '
        Me.button2.Location = New System.Drawing.Point(198, 236)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(75, 23)
        Me.button2.TabIndex = 6
        Me.button2.Text = "Продължи"
        Me.button2.UseVisualStyleBackColor = True
        '
        'button1
        '
        Me.button1.Location = New System.Drawing.Point(13, 236)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(75, 23)
        Me.button1.TabIndex = 5
        Me.button1.Text = "Върни се"
        Me.button1.UseVisualStyleBackColor = True
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(1, 9)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(187, 13)
        Me.label1.TabIndex = 4
        Me.label1.Text = "Вие направихте следните промени:"
        '
        'summary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.listView1)
        Me.Controls.Add(Me.button2)
        Me.Controls.Add(Me.button1)
        Me.Controls.Add(Me.label1)
        Me.Name = "summary"
        Me.Text = "summary"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents listView1 As System.Windows.Forms.ListView
    Private WithEvents button2 As System.Windows.Forms.Button
    Private WithEvents button1 As System.Windows.Forms.Button
    Private WithEvents label1 As System.Windows.Forms.Label
End Class
