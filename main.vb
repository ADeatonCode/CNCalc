Imports System.Windows.Forms

Public Class main
    Private Sub main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim bodies As String() = {
            "Sun", "Moon", "Venus", "Mars", "Jupiter", "Saturn", "Polaris", "Alpheratz", "Ankaa", "Schedar",
            "Diphda", "Achernar", "Hamal", "Acamar", "Menkar", "Mirfak", "Aldebaran", "Rigel", "Capella", "Bellatrix",
            "Elnath", "Alnilam", "Betelgeuse", "Canopus", "Sirius", "Adhara", "Procyon", "Pollux", "Avior", "Suhail",
            "Miaplacidus", "Alphard", "Regulus", "Dubhe", "Denebola", "Gienah", "Acrux", "Gacrux", "Alioth", "Spica",
            "Alkaid", "Hadar", "Menkent", "Arcturus", "Rigil Kentaurus", "Zubenelgenubi", "Kochab", "Alphecca", "Antares", "Atria",
            "Sabik", "Shaula", "Rasalhague", "Eltanin", "Kaus Australis", "Vega", "Nunki", "Altair", "Peacock", "Deneb",
            "Al Na'ir", "Enif", "Fomalhaut", "Markab"
        }

        SiteBody31.Items.AddRange(bodies)
        SiteBody32.Items.AddRange(bodies)
        SiteBody33.Items.AddRange(bodies)
        SiteBody34.Items.AddRange(bodies)
        SiteBody35.Items.AddRange(bodies)

        SiteDate11.Text = DateTime.Today.ToShortDateString()
        SiteDate12.Text = DateTime.Today.ToShortDateString()
        SiteDate13.Text = DateTime.Today.ToShortDateString()
        SiteDate14.Text = DateTime.Today.ToShortDateString()
        SiteDate15.Text = DateTime.Today.ToShortDateString()

        SiteTime21.Text = DateTime.Now.ToString("HH:mm:ss")
        SiteTime22.Text = DateTime.Now.ToString("HH:mm:ss")
        SiteTime23.Text = DateTime.Now.ToString("HH:mm:ss")
        SiteTime24.Text = DateTime.Now.ToString("HH:mm:ss")
        SiteTime25.Text = DateTime.Now.ToString("HH:mm:ss")
        ' Ensure minute boxes visibility matches current AngleFormat on load
        Dim regKey As String = "HKEY_CURRENT_USER\Software\CNCalc\SiteSettings"
        Dim angleFormat As String = CStr(Microsoft.Win32.Registry.GetValue(regKey, "AngleFormat", My.Settings.AngleFormat))
        Dim isDM As Boolean = (angleFormat = "DM")
        SiteHsMin41.Visible = isDM
        SiteHsMin42.Visible = isDM
        SiteHsMin43.Visible = isDM
        SiteHsMin44.Visible = isDM
        SiteHsMin45.Visible = isDM
    End Sub

    Private Sub OnSiteInputChanged(sender As Object, e As EventArgs) Handles _
        SiteDate11.TextChanged, SiteTime21.TextChanged, SiteBody31.SelectedIndexChanged, SiteHs41.TextChanged, SiteHsMin41.TextChanged,
        SiteDate12.TextChanged, SiteTime22.TextChanged, SiteBody32.SelectedIndexChanged, SiteHs42.TextChanged, SiteHsMin42.TextChanged,
        SiteDate13.TextChanged, SiteTime23.TextChanged, SiteBody33.SelectedIndexChanged, SiteHs43.TextChanged, SiteHsMin43.TextChanged,
        SiteDate14.TextChanged, SiteTime24.TextChanged, SiteBody34.SelectedIndexChanged, SiteHs44.TextChanged, SiteHsMin44.TextChanged,
        SiteDate15.TextChanged, SiteTime25.TextChanged, SiteBody35.SelectedIndexChanged, SiteHs45.TextChanged, SiteHsMin45.TextChanged

        ' Compose hs strings using DM minute boxes only when AngleFormat=DM
        Dim regKey As String = "HKEY_CURRENT_USER\Software\CNCalc\SiteSettings"
        Dim angleFormat As String = CStr(Microsoft.Win32.Registry.GetValue(regKey, "AngleFormat", My.Settings.AngleFormat))

        Dim hs1 As String = If(angleFormat = "DM", (SiteHs41.Text.Trim() & " " & SiteHsMin41.Text.Trim()).Trim(), SiteHs41.Text)
        Dim hs2 As String = If(angleFormat = "DM", (SiteHs42.Text.Trim() & " " & SiteHsMin42.Text.Trim()).Trim(), SiteHs42.Text)
        Dim hs3 As String = If(angleFormat = "DM", (SiteHs43.Text.Trim() & " " & SiteHsMin43.Text.Trim()).Trim(), SiteHs43.Text)
        Dim hs4 As String = If(angleFormat = "DM", (SiteHs44.Text.Trim() & " " & SiteHsMin44.Text.Trim()).Trim(), SiteHs44.Text)
        Dim hs5 As String = If(angleFormat = "DM", (SiteHs45.Text.Trim() & " " & SiteHsMin45.Text.Trim()).Trim(), SiteHs45.Text)

        ' Ensure minute boxes visibility matches angleFormat
        Dim isDM As Boolean = (angleFormat = "DM")
        SiteHsMin41.Visible = isDM
        SiteHsMin42.Visible = isDM
        SiteHsMin43.Visible = isDM
        SiteHsMin44.Visible = isDM
        SiteHsMin45.Visible = isDM

        CheckSite(1, SiteDate11.Text, SiteTime21.Text, Convert.ToString(SiteBody31.SelectedItem), hs1, SiteHa61, SiteHo61)
        CheckSite(2, SiteDate12.Text, SiteTime22.Text, Convert.ToString(SiteBody32.SelectedItem), hs2, SiteHa62, SiteHo62)
        CheckSite(3, SiteDate13.Text, SiteTime23.Text, Convert.ToString(SiteBody33.SelectedItem), hs3, SiteHa63, SiteHo63)
        CheckSite(4, SiteDate14.Text, SiteTime24.Text, Convert.ToString(SiteBody34.SelectedItem), hs4, SiteHa64, SiteHo64)
        CheckSite(5, SiteDate15.Text, SiteTime25.Text, Convert.ToString(SiteBody35.SelectedItem), hs5, SiteHa65, SiteHo65)
    End Sub

    Private Sub CheckSite(siteNum As Integer, dStr As String, tStr As String, bodyStr As String, hsStr As String, outHaTxt As TextBox, outHoTxt As TextBox)
        If Not String.IsNullOrWhiteSpace(dStr) AndAlso
           Not String.IsNullOrWhiteSpace(tStr) AndAlso
           Not String.IsNullOrWhiteSpace(bodyStr) AndAlso
           Not String.IsNullOrWhiteSpace(hsStr) Then

            ' Get IE and Heye values from settings
            ' For now, pass empty strings as placeholders (settings dialog will provide these)
            CalculateSite(siteNum, dStr, tStr, bodyStr, hsStr, outHaTxt, outHoTxt)
        End If
    End Sub

    Private Sub CalculateSite(siteNum As Integer, dStr As String, tStr As String, bodyStr As String, hsStr As String, outHaTxt As TextBox, outHoTxt As TextBox)
        Dim hsDeg As Double = 0
        If Not TryParseAngle(hsStr, hsDeg) Then
            outHaTxt.Text = "Hs Error"
            outHoTxt.Text = ""
            Exit Sub
        End If

        ' Get IC (index correction) and Heye (eye height) from SettingsForm (registry) or fallback to My.Settings
        Dim regKey As String = "HKEY_CURRENT_USER\Software\CNCalc\SiteSettings"
        Dim ieSettings As String = CStr(Microsoft.Win32.Registry.GetValue(regKey, "DefaultIE", My.Settings.DefaultIE))
        Dim heyeSettings As String = CStr(Microsoft.Win32.Registry.GetValue(regKey, "DefaultHeye", My.Settings.DefaultHeye))

        Dim ieType As String = "On"
        Dim ieMinutes As Double = 0
        If Not String.IsNullOrWhiteSpace(ieSettings) Then
            Dim parts = ieSettings.Split(New Char() {" "c, ","c}, StringSplitOptions.RemoveEmptyEntries)
            For Each p In parts
                If p.Equals("Off", StringComparison.OrdinalIgnoreCase) Then
                    ieType = "Off"
                ElseIf p.Equals("On", StringComparison.OrdinalIgnoreCase) Then
                    ieType = "On"
                Else
                    Dim tmp As Double = 0
                    If Double.TryParse(p, tmp) Then
                        ieMinutes = tmp
                        Exit For
                    End If
                End If
            Next
        End If

        Dim ieDegrees As Double = ieMinutes / 60.0
        If ieType.Equals("Off", StringComparison.OrdinalIgnoreCase) Then
            ieDegrees = -ieDegrees
        End If

        ' Parse Heye from settings (numeric expected). If missing or invalid, default to 0.
        Dim heyeValue As Double = 0
        If Not String.IsNullOrWhiteSpace(heyeSettings) Then
            Double.TryParse(heyeSettings, heyeValue)
        End If

        ' CORRdip = -0.0293 * sqrt(Heye) per user specification
        Dim corDip As Double = 0
        If heyeValue >= 0 Then
            corDip = -0.0293 * Math.Sqrt(heyeValue)
        End If

        ' Ha = Hs + IC + CORRdip
        ' IC (index correction) is signed: positive for "On" (adds to Hs), negative for "Off" (subtracts)
        ' CORRdip is computed as a negative value (reduces Ha)
        Dim haDeg As Double = hsDeg + ieDegrees + corDip

        ' Output Ha value
        outHaTxt.Text = FormatAngle(haDeg)

        ' Display index correction and dip correction in the UI for this site.
        Select Case siteNum
            Case 1
                Me.SiteIc61.Text = FormatAngle(ieDegrees)
                Me.SiteDip61.Text = FormatAngle(corDip)
            Case 2
                Me.SiteIc62.Text = FormatAngle(ieDegrees)
                Me.SiteDip62.Text = FormatAngle(corDip)
            Case 3
                Me.SiteIc63.Text = FormatAngle(ieDegrees)
                Me.SiteDip63.Text = FormatAngle(corDip)
            Case 4
                Me.SiteIc64.Text = FormatAngle(ieDegrees)
                Me.SiteDip64.Text = FormatAngle(corDip)
            Case 5
                Me.SiteIc65.Text = FormatAngle(ieDegrees)
                Me.SiteDip65.Text = FormatAngle(corDip)
        End Select

        ' Calculate Ho = Ha - CORalt
        ' CORalt = Ro × f, where f = (P/1010) × (283/(273+T))
        ' Parse pressure (mb) and temperature (Celsius)
        Dim pressure As Double = 1010
        Dim temperature As Double = 15
        ' Read pressure and temperature from registry if provided, otherwise use defaults
        Dim pressureStr As String = CStr(Microsoft.Win32.Registry.GetValue(regKey, "Pressure", "1010"))
        Dim temperatureStr As String = CStr(Microsoft.Win32.Registry.GetValue(regKey, "Temperature", "15"))
        Double.TryParse(pressureStr, pressure)
        Double.TryParse(temperatureStr, temperature)

        ' Calculate f factor for atmospheric refraction
        Dim fFactor As Double = (pressure / 1010.0) * (283.0 / (273.0 + temperature))

        ' Ro is the standard refraction at the horizon (approximately 34 arcminutes or 0.566667 degrees)
        Dim ro As Double = 0.566667

        ' Calculate CORalt (atmospheric refraction correction)
        Dim corAlt As Double = ro * fFactor

        ' Ho = Ha - CORalt
        Dim hoDeg As Double = haDeg - corAlt

        ' Output Ho value
        outHoTxt.Text = FormatAngle(hoDeg)
    End Sub

    Private Function TryParseAngle(input As String, ByRef resultDegrees As Double) As Boolean
        If String.IsNullOrWhiteSpace(input) Then
            Return False
        End If

        Dim s As String = input.Trim()

        ' Preserve leading sign only.
        Dim sign As Integer = 1
        If s.StartsWith("-") Then
            sign = -1
            s = s.Substring(1).Trim()
        ElseIf s.StartsWith("+") Then
            s = s.Substring(1).Trim()
        End If

        ' ASCII-safe normalization:
        ' keep digits and decimal point, replace everything else with spaces.
        Dim sb As New System.Text.StringBuilder(s.Length)
        For Each ch As Char In s
            If Char.IsDigit(ch) OrElse ch = "."c Then
                sb.Append(ch)
            Else
                sb.Append(" "c)
            End If
        Next

        Dim cleaned As String = sb.ToString()
        Dim parts() As String = cleaned.Split(New Char() {" "c}, StringSplitOptions.RemoveEmptyEntries)

        If parts.Length = 1 Then
            Dim deg As Double = 0
            If Double.TryParse(parts(0), deg) Then
                resultDegrees = sign * deg
                Return True
            End If
        ElseIf parts.Length = 2 Then
            Dim deg As Double = 0
            Dim min As Double = 0
            If Double.TryParse(parts(0), deg) AndAlso Double.TryParse(parts(1), min) Then
                resultDegrees = sign * (deg + (min / 60.0))
                Return True
            End If
        ElseIf parts.Length >= 3 Then
            Dim deg As Double = 0
            Dim min As Double = 0
            Dim sec As Double = 0
            If Double.TryParse(parts(0), deg) AndAlso Double.TryParse(parts(1), min) AndAlso Double.TryParse(parts(2), sec) Then
                resultDegrees = sign * (deg + (min / 60.0) + (sec / 3600.0))
                Return True
            End If
        End If

        Return False
    End Function

    Public Function FormatAngle(totalDegrees As Double) As String
        ' Format angle according to user AngleFormat setting (registry -> SettingsForm)
        Dim regKey As String = "HKEY_CURRENT_USER\Software\CNCalc\SiteSettings"
        Dim angleFormat As String = CStr(Microsoft.Win32.Registry.GetValue(regKey, "AngleFormat", My.Settings.AngleFormat))

        Dim sign As String = If(totalDegrees < 0, "-", "")
        Dim absDeg As Double = Math.Abs(totalDegrees)

        Select Case angleFormat
            Case "DM"
                Dim degPart As Integer = CInt(Math.Floor(absDeg))
                Dim minPart As Double = (absDeg - degPart) * 60.0
                ' Use degree symbol (ChrW(&HB0)) followed by minutes
                Return sign & degPart.ToString("00") & ChrW(&HB0) & " " & minPart.ToString("00.0000") & "'"
            Case "DMS"
                Dim degPart As Integer = CInt(Math.Floor(absDeg))
                Dim minFrac As Double = (absDeg - degPart) * 60.0
                Dim minPart As Integer = CInt(Math.Floor(minFrac))
                Dim secPart As Double = (minFrac - minPart) * 60.0
                Return sign & degPart.ToString("00") & ChrW(&HB0) & " " & minPart.ToString("00") & "' " & secPart.ToString("00.00") & Chr(34)
            Case Else
                Return sign & absDeg.ToString("000.0000") & ChrW(&HB0)
        End Select
    End Function

    Private Sub SiteSettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SiteSettingsToolStripMenuItem.Click
        Dim settingsForm As New SettingsForm()
        If settingsForm.ShowDialog(Me) = DialogResult.OK Then
            ' Settings saved successfully
            MessageBox.Show("Settings saved successfully!", "Site Settings", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ' Recalculate sites so updated settings (IC/CORRdip) are applied immediately
            OnSiteInputChanged(Nothing, EventArgs.Empty)
        End If
    End Sub

    Private Sub PreferencesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PreferencesToolStripMenuItem.Click
        ' Placeholder for application preferences (fonts, colors, etc.)
        MessageBox.Show("Preferences dialog will be implemented here.", "Preferences", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

End Class