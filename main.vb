Imports System.Windows.Forms

Partial Public Class main
    Public Sub New()
        InitializeComponent()
    End Sub



    Private Sub main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
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

            ' Set default limb to "+"
            ComboBoxSignlimb1.SelectedIndex = 0
            ComboBoxSignlimb1.Text = "+"
            ComboBoxSignlimb2.SelectedIndex = 0
            ComboBoxSignlimb2.Text = "+"
            ComboBoxSignlimb3.SelectedIndex = 0
            ComboBoxSignlimb3.Text = "+"
            ComboBoxSignlimb4.SelectedIndex = 0
            ComboBoxSignlimb4.Text = "+"
            ComboBoxSignlimb5.SelectedIndex = 0
            ComboBoxSignlimb5.Text = "+"

            ' NOTE: Event handlers for IE population are defined with Handles clauses below
        Catch
            ' ignore designer-time errors
        End Try
    End Sub

    Private Sub CheckAndPopulateIE1(sender As Object, e As EventArgs) Handles SiteBody31.SelectedIndexChanged, SiteHs41.TextChanged
        If SiteBody31.SelectedIndex >= 0 AndAlso Not String.IsNullOrEmpty(SiteHs41.Text) Then
            ' Body and Hs selected, populate IE from settings
            Const regKey As String = "HKEY_CURRENT_USER\Software\CNCalc\SiteSettings"
            Dim defaultIE As String = CStr(Microsoft.Win32.Registry.GetValue(regKey, "DefaultIE", ""))
            If Not String.IsNullOrEmpty(defaultIE) Then
                ' Get angle format from settings
                Dim angleFormat As String = CStr(Microsoft.Win32.Registry.GetValue(regKey, "AngleFormat", "DMS"))
                ' Convert IE value to proper format
                Dim convertedIE As String = ConvertIEToFormat(defaultIE, angleFormat)
                SiteIc61.Text = convertedIE
            End If
            ' Also populate CORRdip
            PopulateCORRdipForSite(SiteDip61)
        Else
            ' Clear both if inputs are incomplete
            SiteIc61.Text = ""
            SiteDip61.Text = ""
        End If
        ' Update Ha
        UpdateHaForSite(SiteHs41, SiteIc61, SiteDip61, SiteHa61)
    End Sub

    Private Sub CheckAndPopulateIE2(sender As Object, e As EventArgs) Handles SiteBody32.SelectedIndexChanged, SiteHs42.TextChanged
        If SiteBody32.SelectedIndex >= 0 AndAlso Not String.IsNullOrEmpty(SiteHs42.Text) Then
            Const regKey As String = "HKEY_CURRENT_USER\Software\CNCalc\SiteSettings"
            Dim defaultIE As String = CStr(Microsoft.Win32.Registry.GetValue(regKey, "DefaultIE", ""))
            If Not String.IsNullOrEmpty(defaultIE) Then
                Dim angleFormat As String = CStr(Microsoft.Win32.Registry.GetValue(regKey, "AngleFormat", "DMS"))
                Dim convertedIE As String = ConvertIEToFormat(defaultIE, angleFormat)
                SiteIc62.Text = convertedIE
            End If
            PopulateCORRdipForSite(SiteDip62)
        Else
            SiteIc62.Text = ""
            SiteDip62.Text = ""
        End If
        ' Update Ha
        UpdateHaForSite(SiteHs42, SiteIc62, SiteDip62, SiteHa62)
    End Sub

    Private Sub CheckAndPopulateIE3(sender As Object, e As EventArgs) Handles SiteBody33.SelectedIndexChanged, SiteHs43.TextChanged
        If SiteBody33.SelectedIndex >= 0 AndAlso Not String.IsNullOrEmpty(SiteHs43.Text) Then
            Const regKey As String = "HKEY_CURRENT_USER\Software\CNCalc\SiteSettings"
            Dim defaultIE As String = CStr(Microsoft.Win32.Registry.GetValue(regKey, "DefaultIE", ""))
            If Not String.IsNullOrEmpty(defaultIE) Then
                Dim angleFormat As String = CStr(Microsoft.Win32.Registry.GetValue(regKey, "AngleFormat", "DMS"))
                Dim convertedIE As String = ConvertIEToFormat(defaultIE, angleFormat)
                SiteIc63.Text = convertedIE
            End If
            PopulateCORRdipForSite(SiteDip63)
        Else
            SiteIc63.Text = ""
            SiteDip63.Text = ""
        End If
        ' Update Ha
        UpdateHaForSite(SiteHs43, SiteIc63, SiteDip63, SiteHa63)
    End Sub

    Private Sub CheckAndPopulateIE4(sender As Object, e As EventArgs) Handles SiteBody34.SelectedIndexChanged, SiteHs44.TextChanged
        If SiteBody34.SelectedIndex >= 0 AndAlso Not String.IsNullOrEmpty(SiteHs44.Text) Then
            Const regKey As String = "HKEY_CURRENT_USER\Software\CNCalc\SiteSettings"
            Dim defaultIE As String = CStr(Microsoft.Win32.Registry.GetValue(regKey, "DefaultIE", ""))
            If Not String.IsNullOrEmpty(defaultIE) Then
                Dim angleFormat As String = CStr(Microsoft.Win32.Registry.GetValue(regKey, "AngleFormat", "DMS"))
                Dim convertedIE As String = ConvertIEToFormat(defaultIE, angleFormat)
                SiteIc64.Text = convertedIE
            End If
            PopulateCORRdipForSite(SiteDip64)
        Else
            SiteIc64.Text = ""
            SiteDip64.Text = ""
        End If
        ' Update Ha
        UpdateHaForSite(SiteHs44, SiteIc64, SiteDip64, SiteHa64)
    End Sub

    Private Sub CheckAndPopulateIE5(sender As Object, e As EventArgs) Handles SiteBody35.SelectedIndexChanged, SiteHs45.TextChanged
        If SiteBody35.SelectedIndex >= 0 AndAlso Not String.IsNullOrEmpty(SiteHs45.Text) Then
            Const regKey As String = "HKEY_CURRENT_USER\Software\CNCalc\SiteSettings"
            Dim defaultIE As String = CStr(Microsoft.Win32.Registry.GetValue(regKey, "DefaultIE", ""))
            If Not String.IsNullOrEmpty(defaultIE) Then
                Dim angleFormat As String = CStr(Microsoft.Win32.Registry.GetValue(regKey, "AngleFormat", "DMS"))
                Dim convertedIE As String = ConvertIEToFormat(defaultIE, angleFormat)
                SiteIc65.Text = convertedIE
            End If
            PopulateCORRdipForSite(SiteDip65)
        Else
            SiteIc65.Text = ""
            SiteDip65.Text = ""
        End If
        ' Update Ha
        UpdateHaForSite(SiteHs45, SiteIc65, SiteDip65, SiteHa65)
    End Sub

    Private Sub AssignSiteCorrections(siteNum As Integer, hpVal As Double?, paVal As Double?, sdVal As Double?, rVal As Double?)
        Dim sdDisplay As Double? = Nothing
        If sdVal.HasValue Then sdDisplay = sdVal.Value * SIGNlimb()

        ' Assign each site's fields explicitly to avoid inline expressions
        If siteNum = 1 Then
            If hpVal.HasValue Then Me.SiteHp61.Text = FmtDeg(hpVal.Value) Else Me.SiteHp61.Text = String.Empty
            If paVal.HasValue Then Me.SitePa61.Text = FmtDeg(paVal.Value) Else Me.SitePa61.Text = String.Empty
            If sdDisplay.HasValue Then Me.SiteSd61.Text = FmtDeg(sdDisplay.Value) Else Me.SiteSd61.Text = String.Empty
            If rVal.HasValue Then Me.SiteR61.Text = FmtDeg(rVal.Value) Else Me.SiteR61.Text = String.Empty
            Return
        End If
        If siteNum = 2 Then
            If hpVal.HasValue Then Me.SiteHp62.Text = FmtDeg(hpVal.Value) Else Me.SiteHp62.Text = String.Empty
            If paVal.HasValue Then Me.SitePa62.Text = FmtDeg(paVal.Value) Else Me.SitePa62.Text = String.Empty
            If sdDisplay.HasValue Then Me.SiteSd62.Text = FmtDeg(sdDisplay.Value) Else Me.SiteSd62.Text = String.Empty
            If rVal.HasValue Then Me.SiteR62.Text = FmtDeg(rVal.Value) Else Me.SiteR62.Text = String.Empty
            Return
        End If
        If siteNum = 3 Then
            If hpVal.HasValue Then Me.SiteHp63.Text = FmtDeg(hpVal.Value) Else Me.SiteHp63.Text = String.Empty
            If paVal.HasValue Then Me.SitePa63.Text = FmtDeg(paVal.Value) Else Me.SitePa63.Text = String.Empty
            If sdDisplay.HasValue Then Me.SiteSd63.Text = FmtDeg(sdDisplay.Value) Else Me.SiteSd63.Text = String.Empty
            If rVal.HasValue Then Me.SiteR63.Text = FmtDeg(rVal.Value) Else Me.SiteR63.Text = String.Empty
            Return
        End If
        If siteNum = 4 Then
            If hpVal.HasValue Then Me.SiteHp64.Text = FmtDeg(hpVal.Value) Else Me.SiteHp64.Text = String.Empty
            If paVal.HasValue Then Me.SitePa64.Text = FmtDeg(paVal.Value) Else Me.SitePa64.Text = String.Empty
            If sdDisplay.HasValue Then Me.SiteSd64.Text = FmtDeg(sdDisplay.Value) Else Me.SiteSd64.Text = String.Empty
            If rVal.HasValue Then Me.SiteR64.Text = FmtDeg(rVal.Value) Else Me.SiteR64.Text = String.Empty
            Return
        End If
        If siteNum = 5 Then
            If hpVal.HasValue Then Me.SiteHp65.Text = FmtDeg(hpVal.Value) Else Me.SiteHp65.Text = String.Empty
            If paVal.HasValue Then Me.SitePa65.Text = FmtDeg(paVal.Value) Else Me.SitePa65.Text = String.Empty
            If sdDisplay.HasValue Then Me.SiteSd65.Text = FmtDeg(sdDisplay.Value) Else Me.SiteSd65.Text = String.Empty
            If rVal.HasValue Then Me.SiteR65.Text = FmtDeg(rVal.Value) Else Me.SiteR65.Text = String.Empty
            Return
        End If
    End Sub
     Private Function SIGNlimb() As Double
         Return 1.0
     End Function

    ' Convert MM.M (minutes) to appropriate angle format
    Private Function ConvertIEToFormat(minutes As String, angleFormat As String) As String
        Try
            Dim mm As Double = Double.Parse(minutes, Globalization.CultureInfo.InvariantCulture)

            Select Case angleFormat
                Case "DD"
                    ' Convert MM.M to DD (decimal degrees)
                    Dim dd As Double = mm / 60.0
                    Return dd.ToString("0.0000", Globalization.CultureInfo.InvariantCulture) & ChrW(&HB0)

                Case "DMS"
                    ' Convert MM.M to DMS (Degrees:Minutes:Seconds)
                    Dim wholeMinutes As Integer = CInt(Int(mm))
                    Dim seconds As Double = (mm - wholeMinutes) * 60.0
                    Return "0:" & wholeMinutes.ToString("00") & ":" & seconds.ToString("00.0")

                Case "DM"
                    ' MM.M is already in DM (Degrees:Minutes) format, just reformat
                    Dim degrees As Integer = 0
                    Dim fractionalMinutes As Double = mm
                    Return degrees.ToString() & ":" & fractionalMinutes.ToString("00.0")

                Case Else
                    ' Default to DD
                    Dim dd As Double = mm / 60.0
                    Return dd.ToString("0.0000", Globalization.CultureInfo.InvariantCulture) & ChrW(&HB0)
            End Select
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine("Error converting IE: " & ex.Message)
            Return minutes
        End Try
    End Function

    ' Calculate CORRdip: CORRdip = -0.0293 * sqrt(Heye)
    ' Calculate CORRdip: CORRdip = -0.0293 * sqrt(Heye)
    ' Input can be numeric (8) or formatted with feet/inch markers (8' or 8" or 8 ft)
    Private Function CalculateCORRdip(heye As String) As String
        Try
            ' Normalize input: trim whitespace and remove common height markers
            Dim normalized As String = heye.Trim()
            ' Remove feet markers
            normalized = normalized.Replace("'", "").Replace("""", "").Replace("ft", "").Replace("in", "")
            normalized = normalized.Trim()

            Dim heyeValue As Double = Double.Parse(normalized, Globalization.CultureInfo.InvariantCulture)
            If heyeValue < 0 Then
                Return ""
            End If
            Dim corrDip As Double = -0.0293 * Math.Sqrt(heyeValue)
            ' Return as DD format with degree symbol
            Return corrDip.ToString("0.0000", Globalization.CultureInfo.InvariantCulture) & ChrW(&HB0)
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine("Error calculating CORRdip: " & ex.Message)
            Return ""
        End Try
    End Function

     Private Function FmtDeg(ByVal deg As Double) As String
         Try
             Return deg.ToString("0.0000", Globalization.CultureInfo.InvariantCulture) & ChrW(&HB0)
         Catch
             Return deg.ToString()
         End Try
     End Function

    Private Function ParseAngle(angleStr As String) As Double
        Try
            ' Remove degree symbol and whitespace
            Dim normalized As String = angleStr.Trim().Replace(ChrW(&HB0), "").Trim()
            Return Double.Parse(normalized, Globalization.CultureInfo.InvariantCulture)
        Catch
            Return 0.0
        End Try
    End Function

    Private Function CalculateHa(hsStr As String, icStr As String, corrDipStr As String) As String
        Try
            ' Parse each component
            Dim hs As Double = ParseAngle(hsStr)
            Dim ic As Double = ParseAngle(icStr)
            Dim corrDip As Double = ParseAngle(corrDipStr)

            ' Ha = Hs + IC + CORRdip
            Dim ha As Double = hs + ic + corrDip

            ' Format as DD with degree symbol
            Return ha.ToString("0.0000", Globalization.CultureInfo.InvariantCulture) & ChrW(&HB0)
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine("Error calculating Ha: " & ex.Message)
            Return ""
        End Try
    End Function

    Private Sub UpdateHaForSite(hsControl As TextBox, icControl As TextBox, corrDipControl As TextBox, haControl As TextBox)
        If Not String.IsNullOrEmpty(hsControl.Text) AndAlso Not String.IsNullOrEmpty(icControl.Text) AndAlso Not String.IsNullOrEmpty(corrDipControl.Text) Then
            haControl.Text = CalculateHa(hsControl.Text, icControl.Text, corrDipControl.Text)
        Else
            haControl.Text = ""
        End If
    End Sub

    ' Populate CORRdip for a single site
    Private Sub PopulateCORRdipForSite(dipControl As TextBox)
        Const regKey As String = "HKEY_CURRENT_USER\Software\CNCalc\SiteSettings"
        Dim defaultHeye As String = CStr(Microsoft.Win32.Registry.GetValue(regKey, "DefaultHeye", ""))

        If Not String.IsNullOrEmpty(defaultHeye) Then
            Dim corrDip As String = CalculateCORRdip(defaultHeye)
            dipControl.Text = corrDip
        Else
            dipControl.Text = ""
        End If
    End Sub

    ' Event handlers for IC and CORRdip text changes to update Ha
    Private Sub SiteIc61_TextChanged(sender As Object, e As EventArgs) Handles SiteIc61.TextChanged
        UpdateHaForSite(SiteHs41, SiteIc61, SiteDip61, SiteHa61)
    End Sub

    Private Sub SiteIc62_TextChanged(sender As Object, e As EventArgs) Handles SiteIc62.TextChanged
        UpdateHaForSite(SiteHs42, SiteIc62, SiteDip62, SiteHa62)
    End Sub

    Private Sub SiteIc63_TextChanged(sender As Object, e As EventArgs) Handles SiteIc63.TextChanged
        UpdateHaForSite(SiteHs43, SiteIc63, SiteDip63, SiteHa63)
    End Sub

    Private Sub SiteIc64_TextChanged(sender As Object, e As EventArgs) Handles SiteIc64.TextChanged
        UpdateHaForSite(SiteHs44, SiteIc64, SiteDip64, SiteHa64)
    End Sub

    Private Sub SiteIc65_TextChanged(sender As Object, e As EventArgs) Handles SiteIc65.TextChanged
        UpdateHaForSite(SiteHs45, SiteIc65, SiteDip65, SiteHa65)
    End Sub

    Private Sub SiteDip61_TextChanged(sender As Object, e As EventArgs) Handles SiteDip61.TextChanged
        UpdateHaForSite(SiteHs41, SiteIc61, SiteDip61, SiteHa61)
    End Sub

    Private Sub SiteDip62_TextChanged(sender As Object, e As EventArgs) Handles SiteDip62.TextChanged
        UpdateHaForSite(SiteHs42, SiteIc62, SiteDip62, SiteHa62)
    End Sub

    Private Sub SiteDip63_TextChanged(sender As Object, e As EventArgs) Handles SiteDip63.TextChanged
        UpdateHaForSite(SiteHs43, SiteIc63, SiteDip63, SiteHa63)
    End Sub

    Private Sub SiteDip64_TextChanged(sender As Object, e As EventArgs) Handles SiteDip64.TextChanged
        UpdateHaForSite(SiteHs44, SiteIc64, SiteDip64, SiteHa64)
    End Sub

    Private Sub SiteDip65_TextChanged(sender As Object, e As EventArgs) Handles SiteDip65.TextChanged
        UpdateHaForSite(SiteHs45, SiteIc65, SiteDip65, SiteHa65)
    End Sub

    ' Recalculate all IE values when angle format changes
    Private Sub RecalculateAllIEValues()
        RefreshIEValue(SiteBody31.SelectedIndex, SiteHs41.Text, SiteIc61)
        RefreshIEValue(SiteBody32.SelectedIndex, SiteHs42.Text, SiteIc62)
        RefreshIEValue(SiteBody33.SelectedIndex, SiteHs43.Text, SiteIc63)
        RefreshIEValue(SiteBody34.SelectedIndex, SiteHs44.Text, SiteIc64)
        RefreshIEValue(SiteBody35.SelectedIndex, SiteHs45.Text, SiteIc65)
    End Sub

    ' Refresh IE value for a single site
    Private Sub RefreshIEValue(bodyIndex As Integer, hsValue As String, ieControl As TextBox)
        If bodyIndex >= 0 AndAlso Not String.IsNullOrEmpty(hsValue) Then
            Const regKey As String = "HKEY_CURRENT_USER\Software\CNCalc\SiteSettings"
            Dim defaultIE As String = CStr(Microsoft.Win32.Registry.GetValue(regKey, "DefaultIE", ""))
            If Not String.IsNullOrEmpty(defaultIE) Then
                Dim angleFormat As String = CStr(Microsoft.Win32.Registry.GetValue(regKey, "AngleFormat", "DMS"))
                Dim convertedIE As String = ConvertIEToFormat(defaultIE, angleFormat)
                ieControl.Text = convertedIE
            End If
        End If
    End Sub

    ' Populate CORRdip for all sites when values change
    Private Sub PopulateCORRdipValues()
        Dim regKey As String = "HKEY_CURRENT_USER\Software\CNCalc\SiteSettings"
        Dim defaultHeye As String = CStr(Microsoft.Win32.Registry.GetValue(regKey, "DefaultHeye", ""))

        If Not String.IsNullOrEmpty(defaultHeye) Then
            Dim corrDip As String = CalculateCORRdip(defaultHeye)
            ' Populate CORRdip only for sites that have Body and Hs filled
            If SiteBody31.SelectedIndex >= 0 AndAlso Not String.IsNullOrEmpty(SiteHs41.Text) Then SiteDip61.Text = corrDip
            If SiteBody32.SelectedIndex >= 0 AndAlso Not String.IsNullOrEmpty(SiteHs42.Text) Then SiteDip62.Text = corrDip
            If SiteBody33.SelectedIndex >= 0 AndAlso Not String.IsNullOrEmpty(SiteHs43.Text) Then SiteDip63.Text = corrDip
            If SiteBody34.SelectedIndex >= 0 AndAlso Not String.IsNullOrEmpty(SiteHs44.Text) Then SiteDip64.Text = corrDip
            If SiteBody35.SelectedIndex >= 0 AndAlso Not String.IsNullOrEmpty(SiteHs45.Text) Then SiteDip65.Text = corrDip
        End If
    End Sub

    Private Sub SiteSettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SiteSettingsToolStripMenuItem.Click
        Dim settingsForm As New SettingsForm()
        If settingsForm.ShowDialog(Me) = DialogResult.OK Then
            ' Settings were changed and OK was clicked
            RecalculateAllIEValues()  ' Recalculate IE values in case angle format changed
            PopulateCORRdipValues()    ' Calculate CORRdip based on new Heye value
        End If
    End Sub
End Class

