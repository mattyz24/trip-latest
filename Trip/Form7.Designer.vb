<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form7
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.fuel = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.purchased = New System.Windows.Forms.Label()
        Me.loaded = New System.Windows.Forms.Label()
        Me.travel = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Label1.Location = New System.Drawing.Point(376, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(359, 31)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "MONTHLY CONSUMPTION"
        '
        'Button7
        '
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.Button7.Location = New System.Drawing.Point(166, 644)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(96, 45)
        Me.Button7.TabIndex = 72
        Me.Button7.Text = "Save As"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.Button6.Location = New System.Drawing.Point(294, 644)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(96, 45)
        Me.Button6.TabIndex = 71
        Me.Button6.Text = "Print"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'dgv1
        '
        Me.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv1.Location = New System.Drawing.Point(12, 52)
        Me.dgv1.Name = "dgv1"
        Me.dgv1.Size = New System.Drawing.Size(1120, 530)
        Me.dgv1.TabIndex = 74
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(424, 598)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(237, 23)
        Me.Label2.TabIndex = 76
        Me.Label2.Text = "Total of Fuel Consumption:"
        '
        'fuel
        '
        Me.fuel.AutoSize = True
        Me.fuel.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fuel.Location = New System.Drawing.Point(661, 600)
        Me.fuel.Name = "fuel"
        Me.fuel.Size = New System.Drawing.Size(0, 21)
        Me.fuel.TabIndex = 77
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(424, 644)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(170, 23)
        Me.Label4.TabIndex = 78
        Me.Label4.Text = "Distance Traveled:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(900, 600)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(136, 23)
        Me.Label7.TabIndex = 79
        Me.Label7.Text = "Liters Loaded:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(782, 639)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(254, 23)
        Me.Label3.TabIndex = 80
        Me.Label3.Text = "Amount of Diesel Purchased:"
        '
        'purchased
        '
        Me.purchased.AutoSize = True
        Me.purchased.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.purchased.Location = New System.Drawing.Point(1042, 641)
        Me.purchased.Name = "purchased"
        Me.purchased.Size = New System.Drawing.Size(0, 21)
        Me.purchased.TabIndex = 81
        '
        'loaded
        '
        Me.loaded.AutoSize = True
        Me.loaded.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loaded.Location = New System.Drawing.Point(1042, 600)
        Me.loaded.Name = "loaded"
        Me.loaded.Size = New System.Drawing.Size(0, 21)
        Me.loaded.TabIndex = 82
        '
        'travel
        '
        Me.travel.AutoSize = True
        Me.travel.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.travel.Location = New System.Drawing.Point(609, 644)
        Me.travel.Name = "travel"
        Me.travel.Size = New System.Drawing.Size(0, 21)
        Me.travel.TabIndex = 83
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.Button1.Location = New System.Drawing.Point(40, 644)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(96, 45)
        Me.Button1.TabIndex = 84
        Me.Button1.Text = "Sum"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(40, 598)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(272, 32)
        Me.TextBox1.TabIndex = 85
        '
        'Form7
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.travel)
        Me.Controls.Add(Me.loaded)
        Me.Controls.Add(Me.purchased)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.fuel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgv1)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form7"
        Me.Text = "Form7"
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents dgv1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents fuel As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents purchased As System.Windows.Forms.Label
    Friend WithEvents loaded As System.Windows.Forms.Label
    Friend WithEvents travel As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
End Class
