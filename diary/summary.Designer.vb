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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(summary))
        Me.summaryView = New System.Windows.Forms.ListView()
        Me.forward = New System.Windows.Forms.Button()
        Me.back = New System.Windows.Forms.Button()
        Me.labelSummary = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'summaryView
        '
        Me.summaryView.Alignment = System.Windows.Forms.ListViewAlignment.Left
        Me.summaryView.Location = New System.Drawing.Point(4, 29)
        Me.summaryView.Name = "summaryView"
        Me.summaryView.Size = New System.Drawing.Size(269, 201)
        Me.summaryView.TabIndex = 7
        Me.summaryView.TileSize = New System.Drawing.Size(250, 30)
        Me.summaryView.UseCompatibleStateImageBehavior = False
        Me.summaryView.View = System.Windows.Forms.View.Tile
        '
        'forward
        '
        Me.forward.Location = New System.Drawing.Point(197, 236)
        Me.forward.Name = "forward"
        Me.forward.Size = New System.Drawing.Size(75, 23)
        Me.forward.TabIndex = 6
        Me.forward.Text = "Продължи"
        Me.forward.UseVisualStyleBackColor = True
        '
        'back
        '
        Me.back.Location = New System.Drawing.Point(12, 236)
        Me.back.Name = "back"
        Me.back.Size = New System.Drawing.Size(75, 23)
        Me.back.TabIndex = 5
        Me.back.Text = "Върни се"
        Me.back.UseVisualStyleBackColor = True
        '
        'labelSummary
        '
        Me.labelSummary.AutoSize = True
        Me.labelSummary.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.labelSummary.Location = New System.Drawing.Point(1, 9)
        Me.labelSummary.Name = "labelSummary"
        Me.labelSummary.Size = New System.Drawing.Size(244, 17)
        Me.labelSummary.TabIndex = 4
        Me.labelSummary.Text = "Вие направихте следните промени:"
        '
        'summary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 268)
        Me.Controls.Add(Me.summaryView)
        Me.Controls.Add(Me.forward)
        Me.Controls.Add(Me.back)
        Me.Controls.Add(Me.labelSummary)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "summary"
        Me.Text = "Направени промени"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents summaryView As System.Windows.Forms.ListView
    Private WithEvents forward As System.Windows.Forms.Button
    Private WithEvents back As System.Windows.Forms.Button
    Private WithEvents labelSummary As System.Windows.Forms.Label
End Class
