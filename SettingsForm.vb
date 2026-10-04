Public Class SettingsForm
    Private regKey As String = "HKEY_CURRENT_USER\Software\CNCalc\SiteSettings"

    Public Property DefaultHeye As String
        Get
            Return DefaultHeyeTextBox.Text
        End Get
        Set(value As String)
            DefaultHeyeTextBox.Text = value
        End Set
    End Property

    Public Property DefaultIE As String
        Get
            Return DefaultIETextBox.Text
        End Get
        Set(value As String)
            DefaultIETextBox.Text = value
        End Set
    End Property

    Public Property AssumedLat As String
        Get
            Return AssumedLatTextBox.Text
        End Get
        Set(value As String)
            AssumedLatTextBox.Text = value
        End Set
    End Property

    Public Property AssumedLon As String
        Get
            Return AssumedLonTextBox.Text
        End Get
        Set(value As String)
            AssumedLonTextBox.Text = value
        End Set
    End Property

    Public Property HeightUnit As String
        Get
            If ImperialRadioButton.Checked Then
                Return "Feet"
            Else
                Return "Meters"
            End If
        End Get
        Set(value As String)
            If value = "Meters" Then
                MetricRadioButton.Checked = True
            Else
                ImperialRadioButton.Checked = True
            End If
        End Set
    End Property

    Public Function GetHeightUnitAbbr() As String
        If ImperialRadioButton.Checked Then
            Return "ft"
        Else
            Return "m"
        End If
    End Function

    Public Property PressureUnit As String
        Get
            If MbRadioButton.Checked Then
                Return "mb"
            ElseIf InHgRadioButton.Checked Then
                Return "inHg"
            ElseIf MmHgRadioButton.Checked Then
                Return "mmHg"
            ElseIf AtmRadioButton.Checked Then
                Return "atm"
            ElseIf PsiRadioButton.Checked Then
                Return "psi"
            End If
            Return "mb"
        End Get
        Set(value As String)
            Select Case value
                Case "inHg"
                    InHgRadioButton.Checked = True
                Case "mmHg"
                    MmHgRadioButton.Checked = True
                Case "atm"
                    AtmRadioButton.Checked = True
                Case "psi"
                    PsiRadioButton.Checked = True
                Case Else
                    MbRadioButton.Checked = True
            End Select
        End Set
    End Property

    Public Property AngleFormat As String
        Get
            If DegreesMinutesSecondsRadioButton.Checked Then
                Return "DMS"
            ElseIf DegreesMinutesRadioButton.Checked Then
                Return "DM"
            Else
                Return "DecimalDegrees"
            End If
        End Get
        Set(value As String)
            Select Case value
                Case "DM"
                    DegreesMinutesRadioButton.Checked = True
                Case "DecimalDegrees"
                    DecimalDegreesRadioButton.Checked = True
                Case Else
                    DegreesMinutesSecondsRadioButton.Checked = True
            End Select
        End Set
    End Property

    Private Sub SettingsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load settings from Registry
        DefaultHeye = CStr(Microsoft.Win32.Registry.GetValue(regKey, "DefaultHeye", ""))
        DefaultIE = CStr(Microsoft.Win32.Registry.GetValue(regKey, "DefaultIE", ""))
        AssumedLat = CStr(Microsoft.Win32.Registry.GetValue(regKey, "AssumedLat", ""))
        AssumedLon = CStr(Microsoft.Win32.Registry.GetValue(regKey, "AssumedLon", ""))
        HeightUnit = CStr(Microsoft.Win32.Registry.GetValue(regKey, "HeightUnit", "Feet"))
        PressureUnit = CStr(Microsoft.Win32.Registry.GetValue(regKey, "PressureUnit", "mb"))
        AngleFormat = CStr(Microsoft.Win32.Registry.GetValue(regKey, "AngleFormat", "DMS"))
    End Sub

    Private Sub SettingsForm_FormClosing(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles MyBase.FormClosing
        ' Only save if user clicked OK
        If Me.DialogResult = DialogResult.OK Then
            Microsoft.Win32.Registry.SetValue(regKey, "DefaultHeye", DefaultHeye)
            Microsoft.Win32.Registry.SetValue(regKey, "DefaultIE", DefaultIE)
            Microsoft.Win32.Registry.SetValue(regKey, "AssumedLat", AssumedLat)
            Microsoft.Win32.Registry.SetValue(regKey, "AssumedLon", AssumedLon)
            Microsoft.Win32.Registry.SetValue(regKey, "HeightUnit", HeightUnit)
            Microsoft.Win32.Registry.SetValue(regKey, "PressureUnit", PressureUnit)
            Microsoft.Win32.Registry.SetValue(regKey, "AngleFormat", AngleFormat)
        End If
    End Sub
End Class



