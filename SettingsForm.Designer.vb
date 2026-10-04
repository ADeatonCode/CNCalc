<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SettingsForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DefaultHeyeTextBox = New System.Windows.Forms.TextBox()
        Me.DefaultIETextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.AssumedLatTextBox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.AssumedLonTextBox = New System.Windows.Forms.TextBox()
        Me.OKButton = New System.Windows.Forms.Button()
        Me.CancelButton = New System.Windows.Forms.Button()
        Me.UnitSystemGroupBox = New System.Windows.Forms.GroupBox()
        Me.ImperialRadioButton = New System.Windows.Forms.RadioButton()
        Me.MetricRadioButton = New System.Windows.Forms.RadioButton()
        Me.PressureUnitGroupBox = New System.Windows.Forms.GroupBox()
        Me.MbRadioButton = New System.Windows.Forms.RadioButton()
        Me.InHgRadioButton = New System.Windows.Forms.RadioButton()
        Me.MmHgRadioButton = New System.Windows.Forms.RadioButton()
        Me.AtmRadioButton = New System.Windows.Forms.RadioButton()
        Me.PsiRadioButton = New System.Windows.Forms.RadioButton()
        Me.AngleFormatGroupBox = New System.Windows.Forms.GroupBox()
        Me.DegreesMinutesSecondsRadioButton = New System.Windows.Forms.RadioButton()
        Me.DegreesMinutesRadioButton = New System.Windows.Forms.RadioButton()
        Me.DecimalDegreesRadioButton = New System.Windows.Forms.RadioButton()
        Me.UnitSystemGroupBox.SuspendLayout()
        Me.PressureUnitGroupBox.SuspendLayout()
        Me.AngleFormatGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Site Settings"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Default Heye:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Default IE (minutes):"
        '
        'DefaultHeyeTextBox
        '
        Me.DefaultHeyeTextBox.Location = New System.Drawing.Point(150, 50)
        Me.DefaultHeyeTextBox.Name = "DefaultHeyeTextBox"
        Me.DefaultHeyeTextBox.Size = New System.Drawing.Size(150, 20)
        Me.DefaultHeyeTextBox.TabIndex = 4
        '
        'DefaultIETextBox
        '
        Me.DefaultIETextBox.Location = New System.Drawing.Point(150, 90)
        Me.DefaultIETextBox.Name = "DefaultIETextBox"
        Me.DefaultIETextBox.Size = New System.Drawing.Size(150, 20)
        Me.DefaultIETextBox.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 115)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(118, 17)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Assumed Position:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(30, 140)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(28, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Lat:"
        '
        'AssumedLatTextBox
        '
        Me.AssumedLatTextBox.Location = New System.Drawing.Point(150, 137)
        Me.AssumedLatTextBox.Name = "AssumedLatTextBox"
        Me.AssumedLatTextBox.Size = New System.Drawing.Size(150, 20)
        Me.AssumedLatTextBox.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(30, 165)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Lon:"
        '
        'AssumedLonTextBox
        '
        Me.AssumedLonTextBox.Location = New System.Drawing.Point(150, 162)
        Me.AssumedLonTextBox.Name = "AssumedLonTextBox"
        Me.AssumedLonTextBox.Size = New System.Drawing.Size(150, 20)
        Me.AssumedLonTextBox.TabIndex = 10
        '
        'UnitSystemGroupBox
        '
        Me.UnitSystemGroupBox.Controls.Add(Me.ImperialRadioButton)
        Me.UnitSystemGroupBox.Controls.Add(Me.MetricRadioButton)
        Me.UnitSystemGroupBox.Location = New System.Drawing.Point(12, 190)
        Me.UnitSystemGroupBox.Name = "UnitSystemGroupBox"
        Me.UnitSystemGroupBox.Size = New System.Drawing.Size(288, 60)
        Me.UnitSystemGroupBox.TabIndex = 12
        Me.UnitSystemGroupBox.TabStop = False
        Me.UnitSystemGroupBox.Text = "Height Units"
        '
        'ImperialRadioButton
        '
        Me.ImperialRadioButton.AutoSize = True
        Me.ImperialRadioButton.Checked = True
        Me.ImperialRadioButton.Location = New System.Drawing.Point(12, 25)
        Me.ImperialRadioButton.Name = "ImperialRadioButton"
        Me.ImperialRadioButton.Size = New System.Drawing.Size(61, 17)
        Me.ImperialRadioButton.TabIndex = 0
        Me.ImperialRadioButton.TabStop = True
        Me.ImperialRadioButton.Text = "Feet"
        Me.ImperialRadioButton.UseVisualStyleBackColor = True
        '
        'MetricRadioButton
        '
        Me.MetricRadioButton.AutoSize = True
        Me.MetricRadioButton.Location = New System.Drawing.Point(140, 25)
        Me.MetricRadioButton.Name = "MetricRadioButton"
        Me.MetricRadioButton.Size = New System.Drawing.Size(54, 17)
        Me.MetricRadioButton.TabIndex = 1
        Me.MetricRadioButton.Text = "Meters"
        Me.MetricRadioButton.UseVisualStyleBackColor = True
        '
        'PressureUnitGroupBox
        '
        Me.PressureUnitGroupBox.Controls.Add(Me.MbRadioButton)
        Me.PressureUnitGroupBox.Controls.Add(Me.InHgRadioButton)
        Me.PressureUnitGroupBox.Controls.Add(Me.MmHgRadioButton)
        Me.PressureUnitGroupBox.Controls.Add(Me.AtmRadioButton)
        Me.PressureUnitGroupBox.Controls.Add(Me.PsiRadioButton)
        Me.PressureUnitGroupBox.Location = New System.Drawing.Point(12, 256)
        Me.PressureUnitGroupBox.Name = "PressureUnitGroupBox"
        Me.PressureUnitGroupBox.Size = New System.Drawing.Size(288, 90)
        Me.PressureUnitGroupBox.TabIndex = 7
        Me.PressureUnitGroupBox.TabStop = False
        Me.PressureUnitGroupBox.Text = "Pressure Unit"
        '
        'MbRadioButton
        '
        Me.MbRadioButton.AutoSize = True
        Me.MbRadioButton.Checked = True
        Me.MbRadioButton.Location = New System.Drawing.Point(12, 23)
        Me.MbRadioButton.Name = "MbRadioButton"
        Me.MbRadioButton.Size = New System.Drawing.Size(40, 17)
        Me.MbRadioButton.TabIndex = 0
        Me.MbRadioButton.TabStop = True
        Me.MbRadioButton.Text = "mb"
        Me.MbRadioButton.UseVisualStyleBackColor = True
        '
        'InHgRadioButton
        '
        Me.InHgRadioButton.AutoSize = True
        Me.InHgRadioButton.Location = New System.Drawing.Point(80, 23)
        Me.InHgRadioButton.Name = "InHgRadioButton"
        Me.InHgRadioButton.Size = New System.Drawing.Size(50, 17)
        Me.InHgRadioButton.TabIndex = 1
        Me.InHgRadioButton.Text = "inHg"
        Me.InHgRadioButton.UseVisualStyleBackColor = True
        '
        'MmHgRadioButton
        '
        Me.MmHgRadioButton.AutoSize = True
        Me.MmHgRadioButton.Location = New System.Drawing.Point(153, 23)
        Me.MmHgRadioButton.Name = "MmHgRadioButton"
        Me.MmHgRadioButton.Size = New System.Drawing.Size(52, 17)
        Me.MmHgRadioButton.TabIndex = 2
        Me.MmHgRadioButton.Text = "mmHg"
        Me.MmHgRadioButton.UseVisualStyleBackColor = True
        '
        'AtmRadioButton
        '
        Me.AtmRadioButton.AutoSize = True
        Me.AtmRadioButton.Location = New System.Drawing.Point(12, 50)
        Me.AtmRadioButton.Name = "AtmRadioButton"
        Me.AtmRadioButton.Size = New System.Drawing.Size(44, 17)
        Me.AtmRadioButton.TabIndex = 3
        Me.AtmRadioButton.Text = "atm"
        Me.AtmRadioButton.UseVisualStyleBackColor = True
        '
        'PsiRadioButton
        '
        Me.PsiRadioButton.AutoSize = True
        Me.PsiRadioButton.Location = New System.Drawing.Point(80, 50)
        Me.PsiRadioButton.Name = "PsiRadioButton"
        Me.PsiRadioButton.Size = New System.Drawing.Size(41, 17)
        Me.PsiRadioButton.TabIndex = 4
        Me.PsiRadioButton.Text = "psi"
        Me.PsiRadioButton.UseVisualStyleBackColor = True
        '
        'AngleFormatGroupBox
        '
        Me.AngleFormatGroupBox.Controls.Add(Me.DegreesMinutesSecondsRadioButton)
        Me.AngleFormatGroupBox.Controls.Add(Me.DegreesMinutesRadioButton)
        Me.AngleFormatGroupBox.Controls.Add(Me.DecimalDegreesRadioButton)
        Me.AngleFormatGroupBox.Location = New System.Drawing.Point(12, 352)
        Me.AngleFormatGroupBox.Name = "AngleFormatGroupBox"
        Me.AngleFormatGroupBox.Size = New System.Drawing.Size(288, 85)
        Me.AngleFormatGroupBox.TabIndex = 8
        Me.AngleFormatGroupBox.TabStop = False
        Me.AngleFormatGroupBox.Text = "Angle Format"
        '
        'DegreesMinutesSecondsRadioButton
        '
        Me.DegreesMinutesSecondsRadioButton.AutoSize = True
        Me.DegreesMinutesSecondsRadioButton.Checked = True
        Me.DegreesMinutesSecondsRadioButton.Location = New System.Drawing.Point(12, 25)
        Me.DegreesMinutesSecondsRadioButton.Name = "DegreesMinutesSecondsRadioButton"
        Me.DegreesMinutesSecondsRadioButton.Size = New System.Drawing.Size(125, 17)
        Me.DegreesMinutesSecondsRadioButton.TabIndex = 0
        Me.DegreesMinutesSecondsRadioButton.TabStop = True
        Me.DegreesMinutesSecondsRadioButton.Text = "Degrees:Min:Sec"
        Me.DegreesMinutesSecondsRadioButton.UseVisualStyleBackColor = True
        '
        'DegreesMinutesRadioButton
        '
        Me.DegreesMinutesRadioButton.AutoSize = True
        Me.DegreesMinutesRadioButton.Location = New System.Drawing.Point(160, 25)
        Me.DegreesMinutesRadioButton.Name = "DegreesMinutesRadioButton"
        Me.DegreesMinutesRadioButton.Size = New System.Drawing.Size(99, 17)
        Me.DegreesMinutesRadioButton.TabIndex = 1
        Me.DegreesMinutesRadioButton.Text = "Degrees:Min"
        Me.DegreesMinutesRadioButton.UseVisualStyleBackColor = True
        '
        'DecimalDegreesRadioButton
        '
        Me.DecimalDegreesRadioButton.AutoSize = True
        Me.DecimalDegreesRadioButton.Location = New System.Drawing.Point(12, 50)
        Me.DecimalDegreesRadioButton.Name = "DecimalDegreesRadioButton"
        Me.DecimalDegreesRadioButton.Size = New System.Drawing.Size(128, 17)
        Me.DecimalDegreesRadioButton.TabIndex = 2
        Me.DecimalDegreesRadioButton.Text = "Decimal Degrees"
        Me.DecimalDegreesRadioButton.UseVisualStyleBackColor = True
        '
        'OKButton
        '
        Me.OKButton.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.OKButton.Location = New System.Drawing.Point(150, 450)
        Me.OKButton.Name = "OKButton"
        Me.OKButton.Size = New System.Drawing.Size(70, 23)
        Me.OKButton.TabIndex = 13
        Me.OKButton.Text = "OK"
        Me.OKButton.UseVisualStyleBackColor = True
        '
        'CancelButton
        '
        Me.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CancelButton.Location = New System.Drawing.Point(230, 450)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(70, 23)
        Me.CancelButton.TabIndex = 14
        Me.CancelButton.Text = "Cancel"
        Me.CancelButton.UseVisualStyleBackColor = True
        '
        'SettingsForm
        '
        Me.AcceptButton = Me.OKButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.CancelButton
        Me.ClientSize = New System.Drawing.Size(320, 490)
        Me.ControlBox = True
        Me.Controls.Add(Me.AngleFormatGroupBox)
        Me.Controls.Add(Me.PressureUnitGroupBox)
        Me.Controls.Add(Me.UnitSystemGroupBox)
        Me.Controls.Add(Me.AssumedLonTextBox)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.AssumedLatTextBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DefaultIETextBox)
        Me.Controls.Add(Me.DefaultHeyeTextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.OKButton)
        Me.Controls.Add(Me.CancelButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SettingsForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Site Settings"
        Me.UnitSystemGroupBox.ResumeLayout(False)
        Me.UnitSystemGroupBox.PerformLayout()
        Me.PressureUnitGroupBox.ResumeLayout(False)
        Me.PressureUnitGroupBox.PerformLayout()
        Me.AngleFormatGroupBox.ResumeLayout(False)
        Me.AngleFormatGroupBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents DefaultHeyeTextBox As Windows.Forms.TextBox
    Friend WithEvents DefaultIETextBox As Windows.Forms.TextBox
    Friend WithEvents Label4 As Windows.Forms.Label
    Friend WithEvents Label5 As Windows.Forms.Label
    Friend WithEvents AssumedLatTextBox As Windows.Forms.TextBox
    Friend WithEvents Label6 As Windows.Forms.Label
    Friend WithEvents AssumedLonTextBox As Windows.Forms.TextBox
    Friend WithEvents OKButton As Windows.Forms.Button
    Friend WithEvents CancelButton As Windows.Forms.Button
    Friend WithEvents UnitSystemGroupBox As Windows.Forms.GroupBox
    Friend WithEvents ImperialRadioButton As Windows.Forms.RadioButton
    Friend WithEvents MetricRadioButton As Windows.Forms.RadioButton
    Friend WithEvents PressureUnitGroupBox As Windows.Forms.GroupBox
    Friend WithEvents MbRadioButton As Windows.Forms.RadioButton
    Friend WithEvents InHgRadioButton As Windows.Forms.RadioButton
    Friend WithEvents MmHgRadioButton As Windows.Forms.RadioButton
    Friend WithEvents AtmRadioButton As Windows.Forms.RadioButton
    Friend WithEvents PsiRadioButton As Windows.Forms.RadioButton
    Friend WithEvents AngleFormatGroupBox As Windows.Forms.GroupBox
    Friend WithEvents DegreesMinutesSecondsRadioButton As Windows.Forms.RadioButton
    Friend WithEvents DegreesMinutesRadioButton As Windows.Forms.RadioButton
    Friend WithEvents DecimalDegreesRadioButton As Windows.Forms.RadioButton
End Class
