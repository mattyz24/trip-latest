<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.dgv1 = New System.Windows.Forms.DataGridView()
        Me.Approved = New System.Windows.Forms.Button()
        Me.Cancel = New System.Windows.Forms.Button()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Label1.Location = New System.Drawing.Point(357, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(205, 31)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "LIST OF TRIPS"
        '
        'Button7
        '
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.Button7.Location = New System.Drawing.Point(141, 593)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(96, 45)
        Me.Button7.TabIndex = 69
        Me.Button7.Text = "Save As"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.Button6.Location = New System.Drawing.Point(22, 593)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(96, 45)
        Me.Button6.TabIndex = 68
        Me.Button6.Text = "Print"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'dgv1
        '
        Me.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv1.Location = New System.Drawing.Point(12, 57)
        Me.dgv1.Name = "dgv1"
        Me.dgv1.Size = New System.Drawing.Size(1061, 530)
        Me.dgv1.TabIndex = 70
        '
        'Approved
        '
        Me.Approved.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.Approved.Location = New System.Drawing.Point(346, 593)
        Me.Approved.Name = "Approved"
        Me.Approved.Size = New System.Drawing.Size(96, 45)
        Me.Approved.TabIndex = 71
        Me.Approved.Text = "Approved"
        Me.Approved.UseVisualStyleBackColor = True
        '
        'Cancel
        '
        Me.Cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.Cancel.Location = New System.Drawing.Point(466, 593)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(96, 45)
        Me.Cancel.TabIndex = 72
        Me.Cancel.Text = "Cancel"
        Me.Cancel.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 749)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.Approved)
        Me.Controls.Add(Me.dgv1)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form3"
        Me.Text = "Form3"
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents dgv1 As System.Windows.Forms.DataGridView
    Friend WithEvents Approved As System.Windows.Forms.Button
    Friend WithEvents Cancel As System.Windows.Forms.Button
End Class
