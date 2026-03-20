Imports System.Drawing

Public Module ThemeHelper
    Public Sub ApplyThemeToForm(frm As Form, isDark As Boolean)
        ' isDark=True → DARK colors
        Dim formBg = If(isDark, Color.FromArgb(32, 32, 32), Color.WhiteSmoke)
        Dim inputBg = If(isDark, Color.FromArgb(45, 45, 48), Color.White)
        Dim textColor = If(isDark, Color.WhiteSmoke, Color.DimGray)  ' Light text on dark

        frm.BackColor = formBg
        frm.ForeColor = textColor

        For Each ctrl In GetAllControls(frm)
            If TypeOf ctrl Is TextBox Then
                ctrl.BackColor = inputBg
                ctrl.ForeColor = textColor
            ElseIf TypeOf ctrl Is Button Then
                ctrl.BackColor = If(isDark, Color.FromArgb(60, 60, 65), Color.LightGray)
                ctrl.ForeColor = Color.White
                CType(ctrl, Button).FlatStyle = FlatStyle.Flat
            Else
                ctrl.BackColor = inputBg
                ctrl.ForeColor = textColor
            End If
        Next
    End Sub

    Private Function GetAllControls(container As Control) As List(Of Control)
        Dim result As New List(Of Control)
        For Each ctrl In container.Controls
            result.Add(ctrl)
            result.AddRange(GetAllControls(ctrl))
        Next
        Return result
    End Function
End Module
