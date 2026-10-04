Imports System
Module CNCalcHelpers
    Public Function FormatAngleGlobal(deg As Double) As String
        Try
            Return deg.ToString("0.0000", Globalization.CultureInfo.InvariantCulture) & ChrW(&HB0)
        Catch
            Return deg.ToString()
        End Try
    End Function
End Module
