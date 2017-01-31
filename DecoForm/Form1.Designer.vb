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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.InfoTextBox = New System.Windows.Forms.RichTextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.startWordButton = New System.Windows.Forms.Button()
        Me.setDecoParamButton = New System.Windows.Forms.Button()
        Me.clearDecoParamButton = New System.Windows.Forms.Button()
        Me.clearAppearance = New System.Windows.Forms.Button()
        Me.setWhiteBack = New System.Windows.Forms.Button()
        Me.setYellowColor = New System.Windows.Forms.Button()
        Me.setRedColor = New System.Windows.Forms.Button()
        Me.setGreenColor = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(397, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Decoration Specification Dashboard"
        '
        'InfoTextBox
        '
        Me.InfoTextBox.BackColor = System.Drawing.SystemColors.Info
        Me.InfoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.InfoTextBox.Location = New System.Drawing.Point(6, 145)
        Me.InfoTextBox.Name = "InfoTextBox"
        Me.InfoTextBox.Size = New System.Drawing.Size(470, 104)
        Me.InfoTextBox.TabIndex = 1
        Me.InfoTextBox.Text = ""
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox1.Controls.Add(Me.clearAppearance)
        Me.GroupBox1.Controls.Add(Me.setWhiteBack)
        Me.GroupBox1.Controls.Add(Me.setYellowColor)
        Me.GroupBox1.Controls.Add(Me.setRedColor)
        Me.GroupBox1.Controls.Add(Me.setGreenColor)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 66)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(493, 288)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Coloring Actions"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox2.Controls.Add(Me.setDecoParamButton)
        Me.GroupBox2.Controls.Add(Me.clearDecoParamButton)
        Me.GroupBox2.Controls.Add(Me.InfoTextBox)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 370)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(493, 255)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Parameter Control"
        '
        'startWordButton
        '
        Me.startWordButton.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.startWordButton.Image = Global.DecoForm.My.Resources.Resources.word2013icon
        Me.startWordButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.startWordButton.Location = New System.Drawing.Point(102, 641)
        Me.startWordButton.Name = "startWordButton"
        Me.startWordButton.Size = New System.Drawing.Size(308, 84)
        Me.startWordButton.TabIndex = 5
        Me.startWordButton.Text = "Start MS Word"
        Me.startWordButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.startWordButton.UseVisualStyleBackColor = True
        '
        'setDecoParamButton
        '
        Me.setDecoParamButton.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.setDecoParamButton.Image = Global.DecoForm.My.Resources.Resources.blue_plus
        Me.setDecoParamButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.setDecoParamButton.Location = New System.Drawing.Point(6, 33)
        Me.setDecoParamButton.Name = "setDecoParamButton"
        Me.setDecoParamButton.Size = New System.Drawing.Size(232, 106)
        Me.setDecoParamButton.TabIndex = 2
        Me.setDecoParamButton.Text = "Set Deco Spec Parameter"
        Me.setDecoParamButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.setDecoParamButton.UseVisualStyleBackColor = True
        '
        'clearDecoParamButton
        '
        Me.clearDecoParamButton.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clearDecoParamButton.Image = Global.DecoForm.My.Resources.Resources.blue_minus
        Me.clearDecoParamButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.clearDecoParamButton.Location = New System.Drawing.Point(244, 33)
        Me.clearDecoParamButton.Name = "clearDecoParamButton"
        Me.clearDecoParamButton.Size = New System.Drawing.Size(232, 106)
        Me.clearDecoParamButton.TabIndex = 3
        Me.clearDecoParamButton.Text = "Clear Deco Spec Parameter"
        Me.clearDecoParamButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.clearDecoParamButton.UseVisualStyleBackColor = True
        '
        'clearAppearance
        '
        Me.clearAppearance.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.clearAppearance.Image = Global.DecoForm.My.Resources.Resources.recycle_trash_can
        Me.clearAppearance.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.clearAppearance.Location = New System.Drawing.Point(28, 170)
        Me.clearAppearance.Name = "clearAppearance"
        Me.clearAppearance.Size = New System.Drawing.Size(200, 100)
        Me.clearAppearance.TabIndex = 4
        Me.clearAppearance.Text = "Clear Appearance"
        Me.clearAppearance.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.clearAppearance.UseVisualStyleBackColor = True
        '
        'setWhiteBack
        '
        Me.setWhiteBack.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.setWhiteBack.Image = Global.DecoForm.My.Resources.Resources.white_back
        Me.setWhiteBack.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.setWhiteBack.Location = New System.Drawing.Point(268, 170)
        Me.setWhiteBack.Name = "setWhiteBack"
        Me.setWhiteBack.Size = New System.Drawing.Size(200, 100)
        Me.setWhiteBack.TabIndex = 3
        Me.setWhiteBack.Text = "White background"
        Me.setWhiteBack.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.setWhiteBack.UseVisualStyleBackColor = True
        '
        'setYellowColor
        '
        Me.setYellowColor.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.setYellowColor.Image = Global.DecoForm.My.Resources.Resources.paint_yellow2
        Me.setYellowColor.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.setYellowColor.Location = New System.Drawing.Point(198, 38)
        Me.setYellowColor.Name = "setYellowColor"
        Me.setYellowColor.Size = New System.Drawing.Size(100, 100)
        Me.setYellowColor.TabIndex = 2
        Me.setYellowColor.Text = "Yellow"
        Me.setYellowColor.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.setYellowColor.UseVisualStyleBackColor = True
        '
        'setRedColor
        '
        Me.setRedColor.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.setRedColor.Image = Global.DecoForm.My.Resources.Resources.paint_red
        Me.setRedColor.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.setRedColor.Location = New System.Drawing.Point(368, 38)
        Me.setRedColor.Name = "setRedColor"
        Me.setRedColor.Size = New System.Drawing.Size(100, 100)
        Me.setRedColor.TabIndex = 1
        Me.setRedColor.Text = "Red"
        Me.setRedColor.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.setRedColor.UseVisualStyleBackColor = True
        '
        'setGreenColor
        '
        Me.setGreenColor.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.setGreenColor.Image = Global.DecoForm.My.Resources.Resources.green_paint
        Me.setGreenColor.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.setGreenColor.Location = New System.Drawing.Point(28, 38)
        Me.setGreenColor.Name = "setGreenColor"
        Me.setGreenColor.Size = New System.Drawing.Size(100, 100)
        Me.setGreenColor.TabIndex = 0
        Me.setGreenColor.Text = "Green"
        Me.setGreenColor.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.setGreenColor.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(524, 740)
        Me.Controls.Add(Me.startWordButton)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(550, 800)
        Me.Name = "Form1"
        Me.Text = "Decorations Specification Dashboard"
        Me.TopMost = True
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents InfoTextBox As RichTextBox
    Friend WithEvents setDecoParamButton As Button
    Friend WithEvents clearDecoParamButton As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents clearAppearance As Button
    Friend WithEvents setWhiteBack As Button
    Friend WithEvents setYellowColor As Button
    Friend WithEvents setRedColor As Button
    Friend WithEvents setGreenColor As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents startWordButton As Button
End Class
