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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblOne = New System.Windows.Forms.Label()
        Me.lblTwo = New System.Windows.Forms.Label()
        Me.lblThree = New System.Windows.Forms.Label()
        Me.lblOut = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(271, 123)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(195, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Generate Random Number"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lblOne
        '
        Me.lblOne.AutoSize = True
        Me.lblOne.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOne.Location = New System.Drawing.Point(265, 89)
        Me.lblOne.Name = "lblOne"
        Me.lblOne.Size = New System.Drawing.Size(0, 31)
        Me.lblOne.TabIndex = 1
        '
        'lblTwo
        '
        Me.lblTwo.AutoSize = True
        Me.lblTwo.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTwo.Location = New System.Drawing.Point(352, 89)
        Me.lblTwo.Name = "lblTwo"
        Me.lblTwo.Size = New System.Drawing.Size(0, 31)
        Me.lblTwo.TabIndex = 2
        '
        'lblThree
        '
        Me.lblThree.AutoSize = True
        Me.lblThree.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblThree.Location = New System.Drawing.Point(436, 89)
        Me.lblThree.Name = "lblThree"
        Me.lblThree.Size = New System.Drawing.Size(0, 31)
        Me.lblThree.TabIndex = 3
        '
        'lblOut
        '
        Me.lblOut.AutoSize = True
        Me.lblOut.BackColor = System.Drawing.SystemColors.Menu
        Me.lblOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOut.Location = New System.Drawing.Point(12, 222)
        Me.lblOut.Name = "lblOut"
        Me.lblOut.Size = New System.Drawing.Size(0, 31)
        Me.lblOut.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(711, 262)
        Me.Controls.Add(Me.lblOut)
        Me.Controls.Add(Me.lblThree)
        Me.Controls.Add(Me.lblTwo)
        Me.Controls.Add(Me.lblOne)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents lblOne As System.Windows.Forms.Label
    Friend WithEvents lblTwo As System.Windows.Forms.Label
    Friend WithEvents lblThree As System.Windows.Forms.Label
    Friend WithEvents lblOut As System.Windows.Forms.Label

End Class
