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
        Me.btnAsciiToChar = New System.Windows.Forms.Button
        Me.btnCharToAscii = New System.Windows.Forms.Button
        Me.txtCharacter = New System.Windows.Forms.TextBox
        Me.txtAscii = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnReset = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnAsciiToChar
        '
        Me.btnAsciiToChar.Location = New System.Drawing.Point(234, 32)
        Me.btnAsciiToChar.Name = "btnAsciiToChar"
        Me.btnAsciiToChar.Size = New System.Drawing.Size(30, 21)
        Me.btnAsciiToChar.TabIndex = 2
        Me.btnAsciiToChar.UseVisualStyleBackColor = True
        '
        'btnCharToAscii
        '
        Me.btnCharToAscii.Location = New System.Drawing.Point(38, 56)
        Me.btnCharToAscii.Name = "btnCharToAscii"
        Me.btnCharToAscii.Size = New System.Drawing.Size(30, 21)
        Me.btnCharToAscii.TabIndex = 1
        Me.btnCharToAscii.TabStop = False
        Me.btnCharToAscii.UseVisualStyleBackColor = True
        '
        'txtCharacter
        '
        Me.txtCharacter.Location = New System.Drawing.Point(70, 33)
        Me.txtCharacter.Name = "txtCharacter"
        Me.txtCharacter.Size = New System.Drawing.Size(162, 20)
        Me.txtCharacter.TabIndex = 0
        '
        'txtAscii
        '
        Me.txtAscii.Location = New System.Drawing.Point(70, 56)
        Me.txtAscii.Name = "txtAscii"
        Me.txtAscii.Size = New System.Drawing.Size(162, 20)
        Me.txtAscii.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Character"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(234, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "ASCII"
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(137, 82)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(42, 28)
        Me.btnReset.TabIndex = 6
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnReset)
        Me.GroupBox1.Controls.Add(Me.btnAsciiToChar)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.btnCharToAscii)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtCharacter)
        Me.GroupBox1.Controls.Add(Me.txtAscii)
        Me.GroupBox1.Location = New System.Drawing.Point(47, 34)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(288, 132)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(377, 227)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ASCII Converter"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnAsciiToChar As System.Windows.Forms.Button
    Friend WithEvents btnCharToAscii As System.Windows.Forms.Button
    Friend WithEvents txtCharacter As System.Windows.Forms.TextBox
    Friend WithEvents txtAscii As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox

End Class
