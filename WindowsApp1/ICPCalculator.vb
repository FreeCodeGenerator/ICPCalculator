Public Class ICPCalculator
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub SamWeiTB_TextChanged(sender As Object, e As EventArgs) Handles SamWeiTB.TextChanged
        ' Esta función permite ingresar solo números positivos en 'Sample Weight'
        SamWeiTB.MaxLength = 7

        If String.IsNullOrEmpty(SamWeiTB.Text) OrElse SamWeiTB.Text = "0" Then
            Label33.Text = "Sample Weight should be greater than zero!"
            Label33.ForeColor = Color.FromArgb(255, 0, 0)
            wtPL.Text = ""
            ppmPL.Text = ""
            wtZnL.Text = ""
            ppmZnL.Text = ""
            wtMgL.Text = ""
            ppmMgL.Text = ""
            wtCaL.Text = ""
            ppmCaL.Text = ""
        Else
            Label33.Text = ""
            ' No permite escribir más de un punto decimal ni letras
            If Not IsNumeric(SamWeiTB.Text) And SamWeiTB.Text.Length > 0 Then
                SamWeiTB.Text = SamWeiTB.Text.Substring(0, SamWeiTB.Text.Length - 1)
            Else
                ' No permite escribir '-'
                If SamWeiTB.Text.Replace("-", "") <> SamWeiTB.Text Then
                    SamWeiTB.Text = SamWeiTB.Text.Replace("-", "")
                Else
                    ' No permite escribir ','
                    If SamWeiTB.Text.Replace(",", "") <> SamWeiTB.Text Then
                        SamWeiTB.Text = SamWeiTB.Text.Replace(",", "")
                    Else
                        ' No permite escribir espacios en blanco. Luego se llama al cálculo
                        If SamWeiTB.Text.Replace(" ", "") <> SamWeiTB.Text Then
                            SamWeiTB.Text = SamWeiTB.Text.Replace(" ", "")
                        Else
                            ppmPTB_TextChanged(sender, e)
                            ppmZnTB_TextChanged(sender, e)
                            ppmMgTB_TextChanged(sender, e)
                            ppmCaTB_TextChanged(sender, e)
                            ppmBaTB_TextChanged(sender, e)
                            ppmBTB_TextChanged(sender, e)
                            ppmCuTB_TextChanged(sender, e)
                            ppmMoTB_TextChanged(sender, e)
                            ppmSTB_TextChanged(sender, e)
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub Label33_Click(sender As Object, e As EventArgs) Handles Label33.Click

    End Sub

    Private Sub TotWeiTB_TextChanged(sender As Object, e As EventArgs) Handles TotWeiTB.TextChanged
        ' Este código permite ingresar solo números positivos en 'Total Weight'
        TotWeiTB.MaxLength = 7

        If String.IsNullOrEmpty(TotWeiTB.Text) OrElse TotWeiTB.Text = "0" Then
            wtPL.Text = ""
            ppmPL.Text = ""
            wtZnL.Text = ""
            ppmZnL.Text = ""
            wtMgL.Text = ""
            ppmMgL.Text = ""
            wtCaL.Text = ""
            ppmCaL.Text = ""
        Else
            ' No permite escribir más de un punto decimal ni letras
            If Not IsNumeric(TotWeiTB.Text) And TotWeiTB.Text.Length > 0 Then
                TotWeiTB.Text = TotWeiTB.Text.Substring(0, TotWeiTB.Text.Length - 1)
            Else
                ' No permite escribir '-', ',', o espacios en blanco
                If TotWeiTB.Text.Replace("-", "") <> TotWeiTB.Text Then
                    TotWeiTB.Text = TotWeiTB.Text.Replace("-", "")
                Else
                    ' No permite escribir ','
                    If TotWeiTB.Text.Replace(",", "") <> TotWeiTB.Text Then
                        TotWeiTB.Text = TotWeiTB.Text.Replace(",", "")
                    Else
                        ' No permite escribir espacios en blanco
                        If TotWeiTB.Text.Replace(" ", "") <> TotWeiTB.Text Then
                            TotWeiTB.Text = TotWeiTB.Text.Replace(" ", "")
                        Else
                            ppmPTB_TextChanged(sender, e)
                            ppmZnTB_TextChanged(sender, e)
                            ppmMgTB_TextChanged(sender, e)
                            ppmCaTB_TextChanged(sender, e)
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub ppmPTB_TextChanged(sender As Object, e As EventArgs) Handles ppmPTB.TextChanged
        ' Este código permite ingresar solo números positivos en ppmPTB
        ' y calcula %Wt(P) y ppm(P)
        ppmPTB.MaxLength = 5

        If String.IsNullOrEmpty(ppmPTB.Text) OrElse ppmPTB.Text = "0" Then
            wtPL.Text = ""
            ppmPL.Text = ""
        Else
            ' Si se escribe en ppmPTB y Sample Weight está vacío, se muestra un mensaje en rojo
            If String.IsNullOrEmpty(SamWeiTB.Text) Then
                Label33.Text = "Sample Weight is needed!"
                Label33.ForeColor = Color.FromArgb(255, 0, 0)
                ppmPTB.Text = ""
            Else
                ' No permite escribir más de un punto decimal ni letras
                If Not IsNumeric(ppmPTB.Text) And ppmPTB.Text.Length > 0 Then
                    ppmPTB.Text = ppmPTB.Text.Substring(0, ppmPTB.Text.Length - 1)
                Else
                    ' No permite escribir '-'
                    If ppmPTB.Text.Replace("-", "") <> ppmPTB.Text Then
                        ppmPTB.Text = ppmPTB.Text.Replace("-", "")
                    Else
                        ' No permite escribir ','
                        If ppmPTB.Text.Replace(",", "") <> ppmPTB.Text Then
                            ppmPTB.Text = ppmPTB.Text.Replace(",", "")
                        Else
                            ' No permite escribir espacios en blanco
                            If ppmPTB.Text.Replace(" ", "") <> ppmPTB.Text Then
                                ppmPTB.Text = ppmPTB.Text.Replace(" ", "")
                            Else
                                If String.IsNullOrEmpty(TotWeiTB.Text) OrElse TotWeiTB.Text = "0" Then
                                    wtPL.Text = ""
                                    ppmPL.Text = ""
                                    Exit Sub
                                Else
                                    wtPL.Text = CDbl(TotWeiTB.Text) * CDbl(ppmPTB.Text) / CDbl(SamWeiTB.Text) / 10000
                                    wtPL.Text = Format(CDbl(wtPL.Text), "0.00000000")
                                    wtPL.ForeColor = Color.FromArgb(0, 130, 0)
                                    ppmPL.Text = CDbl(TotWeiTB.Text) * CDbl(ppmPTB.Text) / CDbl(SamWeiTB.Text)
                                    ppmPL.Text = Format(CDbl(ppmPL.Text), "0.0000")
                                    ppmPL.ForeColor = Color.FromArgb(0, 0, 255)
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub ppmZnTB_TextChanged(sender As Object, e As EventArgs) Handles ppmZnTB.TextChanged
        ' Este código permite ingresar solo números positivos en ppmZnTB
        ' y calcula %Wt(Zn) y ppm(Zn)
        ppmZnTB.MaxLength = 5

        If String.IsNullOrEmpty(ppmZnTB.Text) OrElse ppmZnTB.Text = "0" Then
            wtZnL.Text = ""
            ppmZnL.Text = ""
        Else
            ' Si se escribe en ppmZnTB y Sample Weight está vacío, se muestra un mensaje en rojo
            If String.IsNullOrEmpty(SamWeiTB.Text) Then
                Label33.Text = "Sample Weight is needed!"
                Label33.ForeColor = Color.FromArgb(255, 0, 0)
                ppmZnTB.Text = ""
            Else
                ' No permite escribir más de un punto decimal ni letras
                If Not IsNumeric(ppmZnTB.Text) And ppmZnTB.Text.Length > 0 Then
                    ppmZnTB.Text = ppmZnTB.Text.Substring(0, ppmZnTB.Text.Length - 1)
                Else
                    ' No permite escribir '-'
                    If ppmZnTB.Text.Replace("-", "") <> ppmZnTB.Text Then
                        ppmZnTB.Text = ppmZnTB.Text.Replace("-", "")
                    Else
                        ' No permite escribir ','
                        If ppmZnTB.Text.Replace(",", "") <> ppmZnTB.Text Then
                            ppmZnTB.Text = ppmZnTB.Text.Replace(",", "")
                        Else
                            ' No permite escribir espacios en blanco
                            If ppmZnTB.Text.Replace(" ", "") <> ppmZnTB.Text Then
                                ppmZnTB.Text = ppmZnTB.Text.Replace(" ", "")
                            Else
                                If String.IsNullOrEmpty(TotWeiTB.Text) OrElse TotWeiTB.Text = "0" Then
                                    wtZnL.Text = ""
                                    ppmZnL.Text = ""
                                    Exit Sub
                                Else
                                    wtZnL.Text = CDbl(TotWeiTB.Text) * CDbl(ppmZnTB.Text) / CDbl(SamWeiTB.Text) / 10000
                                    wtZnL.Text = String.Format("{0:0.00000000}", CDbl(wtZnL.Text))
                                    wtZnL.ForeColor = Color.FromArgb(0, 130, 0)
                                    ppmZnL.Text = CDbl(TotWeiTB.Text) * CDbl(ppmZnTB.Text) / CDbl(SamWeiTB.Text)
                                    ppmZnL.Text = String.Format("{0:0.0000}", CDbl(ppmZnL.Text))
                                    ppmZnL.ForeColor = Color.FromArgb(0, 0, 255)
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub ppmMgTB_TextChanged(sender As Object, e As EventArgs) Handles ppmMgTB.TextChanged
        ' Este código permite ingresar solo números positivos en ppmMgTB
        ' y calcula %Wt(Mg) y ppm(Mg)
        ppmMgTB.MaxLength = 5

        If String.IsNullOrEmpty(ppmMgTB.Text) OrElse ppmMgTB.Text = "0" Then
            wtMgL.Text = ""
            ppmMgL.Text = ""
        Else
            ' Si se escribe en ppmMgTB y Sample Weight está vacío, se muestra un mensaje en rojo
            If String.IsNullOrEmpty(SamWeiTB.Text) Then
                Label33.Text = "Sample Weight is needed!"
                Label33.ForeColor = Color.FromArgb(255, 0, 0)
                ppmMgTB.Text = ""
            Else
                ' No permite escribir más de un punto decimal ni letras
                If Not IsNumeric(ppmMgTB.Text) And ppmMgTB.Text.Length > 0 Then
                    ppmMgTB.Text = ppmMgTB.Text.Substring(0, ppmMgTB.Text.Length - 1)
                Else
                    ' No permite escribir '-'
                    If ppmMgTB.Text.Replace("-", "") <> ppmMgTB.Text Then
                        ppmMgTB.Text = ppmMgTB.Text.Replace("-", "")
                    Else
                        ' No permite escribir ','
                        If ppmMgTB.Text.Replace(",", "") <> ppmMgTB.Text Then
                            ppmMgTB.Text = ppmMgTB.Text.Replace(",", "")
                        Else
                            ' No permite escribir espacios en blanco
                            If ppmMgTB.Text.Replace(" ", "") <> ppmMgTB.Text Then
                                ppmMgTB.Text = ppmMgTB.Text.Replace(" ", "")
                            Else
                                If String.IsNullOrEmpty(TotWeiTB.Text) OrElse TotWeiTB.Text = "0" Then
                                    wtMgL.Text = ""
                                    ppmMgL.Text = ""
                                    Exit Sub
                                Else
                                    wtMgL.Text = CDbl(TotWeiTB.Text) * CDbl(ppmMgTB.Text) / CDbl(SamWeiTB.Text) / 10000
                                    wtMgL.Text = String.Format("{0:0.00000000}", CDbl(wtMgL.Text))
                                    wtMgL.ForeColor = Color.FromArgb(0, 130, 0)
                                    ppmMgL.Text = CDbl(TotWeiTB.Text) * CDbl(ppmMgTB.Text) / CDbl(SamWeiTB.Text)
                                    ppmMgL.Text = String.Format("{0:0.0000}", CDbl(ppmMgL.Text))
                                    ppmMgL.ForeColor = Color.FromArgb(0, 0, 255)
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub ppmCaTB_TextChanged(sender As Object, e As EventArgs) Handles ppmCaTB.TextChanged
        ' Este código permite ingresar solo números positivos en ppmCaTB
        ' y calcula %Wt(Ca) y ppm(Ca)
        ppmCaTB.MaxLength = 5

        If String.IsNullOrEmpty(ppmCaTB.Text) OrElse ppmCaTB.Text = "0" Then
            wtCaL.Text = ""
            ppmCaL.Text = ""
        Else
            ' Si se escribe en ppmCaTB y Sample Weight está vacío, se muestra un mensaje en rojo
            If String.IsNullOrEmpty(SamWeiTB.Text) Then
                Label33.Text = "Sample Weight is needed!"
                Label33.ForeColor = Color.FromArgb(255, 0, 0)
                ppmCaTB.Text = ""
            Else
                ' No permite escribir más de un punto decimal ni letras
                If Not IsNumeric(ppmCaTB.Text) And ppmCaTB.Text.Length > 0 Then
                    ppmCaTB.Text = ppmCaTB.Text.Substring(0, ppmCaTB.Text.Length - 1)
                Else
                    ' No permite escribir '-'
                    If ppmCaTB.Text.Replace("-", "") <> ppmCaTB.Text Then
                        ppmCaTB.Text = ppmCaTB.Text.Replace("-", "")
                    Else
                        ' No permite escribir ','
                        If ppmCaTB.Text.Replace(",", "") <> ppmCaTB.Text Then
                            ppmCaTB.Text = ppmCaTB.Text.Replace(",", "")
                        Else
                            ' No permite escribir espacios en blanco
                            If ppmCaTB.Text.Replace(" ", "") <> ppmCaTB.Text Then
                                ppmCaTB.Text = ppmCaTB.Text.Replace(" ", "")
                            Else
                                If String.IsNullOrEmpty(TotWeiTB.Text) OrElse TotWeiTB.Text = "0" Then
                                    wtCaL.Text = ""
                                    ppmCaL.Text = ""
                                    Exit Sub
                                Else
                                    wtCaL.Text = CDbl(TotWeiTB.Text) * CDbl(ppmCaTB.Text) / CDbl(SamWeiTB.Text) / 10000
                                    wtCaL.Text = String.Format("{0:0.00000000}", CDbl(wtCaL.Text))
                                    wtCaL.ForeColor = Color.FromArgb(0, 130, 0)
                                    ppmCaL.Text = CDbl(TotWeiTB.Text) * CDbl(ppmCaTB.Text) / CDbl(SamWeiTB.Text)
                                    ppmCaL.Text = String.Format("{0:0.0000}", CDbl(ppmCaL.Text))
                                    ppmCaL.ForeColor = Color.FromArgb(0, 0, 255)
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub ppmBaTB_TextChanged(sender As Object, e As EventArgs) Handles ppmBaTB.TextChanged
        ' Este código permite ingresar solo números positivos en ppmBaTB
        ' y calcula %Wt(P) y ppm(P)
        ppmBaTB.MaxLength = 5

        If String.IsNullOrEmpty(ppmBaTB.Text) OrElse ppmBaTB.Text = "0" Then
            wtBaL.Text = ""
            ppmBaL.Text = ""
        Else
            ' Si se escribe en ppmBaTB y Sample Weight está vacío, se muestra un mensaje en rojo
            If String.IsNullOrEmpty(SamWeiTB.Text) Then
                Label13.Text = "Sample Weight is needed!"
                Label13.ForeColor = Color.FromArgb(255, 0, 0)
                ppmBaTB.Text = ""
            Else
                ' No permite escribir más de un punto decimal ni letras
                If Not IsNumeric(ppmBaTB.Text) And ppmBaTB.Text.Length > 0 Then
                    ppmBaTB.Text = ppmBaTB.Text.Substring(0, ppmBaTB.Text.Length - 1)
                Else
                    ' No permite escribir '-'
                    If ppmBaTB.Text.Replace("-", "") <> ppmBaTB.Text Then
                        ppmBaTB.Text = ppmBaTB.Text.Replace("-", "")
                    Else
                        ' No permite escribir ','
                        If ppmBaTB.Text.Replace(",", "") <> ppmBaTB.Text Then
                            ppmBaTB.Text = ppmBaTB.Text.Replace(",", "")
                        Else
                            ' No permite escribir espacios en blanco
                            If ppmBaTB.Text.Replace(" ", "") <> ppmBaTB.Text Then
                                ppmBaTB.Text = ppmBaTB.Text.Replace(" ", "")
                            Else
                                If String.IsNullOrEmpty(TotWeiTB.Text) OrElse TotWeiTB.Text = "0" Then
                                    wtBaL.Text = ""
                                    ppmBaL.Text = ""
                                    Exit Sub
                                Else
                                    wtBaL.Text = CDbl(TotWeiTB.Text) * CDbl(ppmBaTB.Text) / CDbl(SamWeiTB.Text) / 10000
                                    wtBaL.Text = String.Format("{0:0.00000000}", CDbl(wtBaL.Text))
                                    wtBaL.ForeColor = Color.FromArgb(0, 130, 0)
                                    ppmBaL.Text = CDbl(TotWeiTB.Text) * CDbl(ppmBaTB.Text) / CDbl(SamWeiTB.Text)
                                    ppmBaL.Text = String.Format("{0:0.0000}", CDbl(ppmBaL.Text))
                                    ppmBaL.ForeColor = Color.FromArgb(0, 0, 255)
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub ppmBTB_TextChanged(sender As Object, e As EventArgs) Handles ppmBTB.TextChanged
        ' Este código permite ingresar solo números positivos en ppmBTB
        ' y calcula %Wt(P) y ppm(P)
        ppmBTB.MaxLength = 5

        If String.IsNullOrEmpty(ppmBTB.Text) OrElse ppmBTB.Text = "0" Then
            wtBL.Text = ""
            ppmBL.Text = ""
        Else
            ' Si se escribe en ppmBTB y Sample Weight está vacío, se muestra un mensaje en rojo
            If String.IsNullOrEmpty(SamWeiTB.Text) Then
                Label13.Text = "Sample Weight is needed!"
                Label13.ForeColor = Color.FromArgb(255, 0, 0)
                ppmBTB.Text = ""
            Else
                ' No permite escribir más de un punto decimal ni letras
                If Not IsNumeric(ppmBTB.Text) And ppmBTB.Text.Length > 0 Then
                    ppmBTB.Text = ppmBTB.Text.Substring(0, ppmBTB.Text.Length - 1)
                Else
                    ' No permite escribir '-'
                    If ppmBTB.Text.Replace("-", "") <> ppmBTB.Text Then
                        ppmBTB.Text = ppmBTB.Text.Replace("-", "")
                    Else
                        ' No permite escribir ','
                        If ppmBTB.Text.Replace(",", "") <> ppmBTB.Text Then
                            ppmBTB.Text = ppmBTB.Text.Replace(",", "")
                        Else
                            ' No permite escribir espacios en blanco
                            If ppmBTB.Text.Replace(" ", "") <> ppmBTB.Text Then
                                ppmBTB.Text = ppmBTB.Text.Replace(" ", "")
                            Else
                                If String.IsNullOrEmpty(TotWeiTB.Text) OrElse TotWeiTB.Text = "0" Then
                                    wtBL.Text = ""
                                    ppmBL.Text = ""
                                    Exit Sub
                                Else
                                    wtBL.Text = CDbl(TotWeiTB.Text) * CDbl(ppmBTB.Text) / CDbl(SamWeiTB.Text) / 10000
                                    wtBL.Text = String.Format("{0:0.00000000}", CDbl(wtBL.Text))
                                    wtBL.ForeColor = Color.FromArgb(0, 130, 0)
                                    ppmBL.Text = CDbl(TotWeiTB.Text) * CDbl(ppmBTB.Text) / CDbl(SamWeiTB.Text)
                                    ppmBL.Text = String.Format("{0:0.0000}", CDbl(ppmBL.Text))
                                    ppmBL.ForeColor = Color.FromArgb(0, 0, 255)
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub ppmCuTB_TextChanged(sender As Object, e As EventArgs) Handles ppmCuTB.TextChanged
        ' Este código permite ingresar solo números positivos en ppmCuTB
        ' y calcula %Wt(P) y ppm(P)
        ppmCuTB.MaxLength = 5

        If String.IsNullOrEmpty(ppmCuTB.Text) OrElse ppmCuTB.Text = "0" Then
            wtCuL.Text = ""
            ppmCuL.Text = ""
        Else
            ' Si se escribe en ppmCuTB y Sample Weight está vacío, se muestra un mensaje en rojo
            If String.IsNullOrEmpty(SamWeiTB.Text) Then
                Label13.Text = "Sample Weight is needed!"
                Label13.ForeColor = Color.FromArgb(255, 0, 0)
                ppmCuTB.Text = ""
            Else
                ' No permite escribir más de un punto decimal ni letras
                If Not IsNumeric(ppmCuTB.Text) And ppmCuTB.Text.Length > 0 Then
                    ppmCuTB.Text = ppmCuTB.Text.Substring(0, ppmCuTB.Text.Length - 1)
                Else
                    ' No permite escribir '-'
                    If ppmCuTB.Text.Replace("-", "") <> ppmCuTB.Text Then
                        ppmCuTB.Text = ppmCuTB.Text.Replace("-", "")
                    Else
                        ' No permite escribir ','
                        If ppmCuTB.Text.Replace(",", "") <> ppmCuTB.Text Then
                            ppmCuTB.Text = ppmCuTB.Text.Replace(",", "")
                        Else
                            ' No permite escribir espacios en blanco
                            If ppmCuTB.Text.Replace(" ", "") <> ppmCuTB.Text Then
                                ppmCuTB.Text = ppmCuTB.Text.Replace(" ", "")
                            Else
                                If String.IsNullOrEmpty(TotWeiTB.Text) OrElse TotWeiTB.Text = "0" Then
                                    wtCuL.Text = ""
                                    ppmCuL.Text = ""
                                    Exit Sub
                                Else
                                    wtCuL.Text = CDbl(TotWeiTB.Text) * CDbl(ppmCuTB.Text) / CDbl(SamWeiTB.Text) / 10000
                                    wtCuL.Text = String.Format("{0:0.00000000}", CDbl(wtCuL.Text))
                                    wtCuL.ForeColor = Color.FromArgb(0, 130, 0)
                                    ppmCuL.Text = CDbl(TotWeiTB.Text) * CDbl(ppmCuTB.Text) / CDbl(SamWeiTB.Text)
                                    ppmCuL.Text = String.Format("{0:0.0000}", CDbl(ppmCuL.Text))
                                    ppmCuL.ForeColor = Color.FromArgb(0, 0, 255)
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub ppmMoTB_TextChanged(sender As Object, e As EventArgs) Handles ppmMoTB.TextChanged
        ' Este código permite ingresar solo números positivos en ppmMoTB
        ' y calcula %Wt(P) y ppm(P)
        ppmMoTB.MaxLength = 5

        If String.IsNullOrEmpty(ppmMoTB.Text) OrElse ppmMoTB.Text = "0" Then
            wtMoL.Text = ""
            ppmMoL.Text = ""
        Else
            ' Si se escribe en ppmMoTB y Sample Weight está vacío, se muestra un mensaje en rojo
            If String.IsNullOrEmpty(SamWeiTB.Text) Then
                Label13.Text = "Sample Weight is needed!"
                Label13.ForeColor = Color.FromArgb(255, 0, 0)
                ppmMoTB.Text = ""
            Else
                ' No permite escribir más de un punto decimal ni letras
                If Not IsNumeric(ppmMoTB.Text) And ppmMoTB.Text.Length > 0 Then
                    ppmMoTB.Text = ppmMoTB.Text.Substring(0, ppmMoTB.Text.Length - 1)
                Else
                    ' No permite escribir '-'
                    If ppmMoTB.Text.Replace("-", "") <> ppmMoTB.Text Then
                        ppmMoTB.Text = ppmMoTB.Text.Replace("-", "")
                    Else
                        ' No permite escribir ','
                        If ppmMoTB.Text.Replace(",", "") <> ppmMoTB.Text Then
                            ppmMoTB.Text = ppmMoTB.Text.Replace(",", "")
                        Else
                            ' No permite escribir espacios en blanco
                            If ppmMoTB.Text.Replace(" ", "") <> ppmMoTB.Text Then
                                ppmMoTB.Text = ppmMoTB.Text.Replace(" ", "")
                            Else
                                If String.IsNullOrEmpty(TotWeiTB.Text) OrElse TotWeiTB.Text = "0" Then
                                    wtMoL.Text = ""
                                    ppmMoL.Text = ""
                                    Exit Sub
                                Else
                                    wtMoL.Text = CDbl(TotWeiTB.Text) * CDbl(ppmMoTB.Text) / CDbl(SamWeiTB.Text) / 10000
                                    wtMoL.Text = String.Format("{0:0.00000000}", CDbl(wtMoL.Text))
                                    wtMoL.ForeColor = Color.FromArgb(0, 130, 0)
                                    ppmMoL.Text = CDbl(TotWeiTB.Text) * CDbl(ppmMoTB.Text) / CDbl(SamWeiTB.Text)
                                    ppmMoL.Text = String.Format("{0:0.0000}", CDbl(ppmMoL.Text))
                                    ppmMoL.ForeColor = Color.FromArgb(0, 0, 255)
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub ppmSTB_TextChanged(sender As Object, e As EventArgs) Handles ppmSTB.TextChanged
        ' Este código permite ingresar solo números positivos en ppmSTB
        ' y calcula %Wt(P) y ppm(P)
        ppmSTB.MaxLength = 5

        If String.IsNullOrEmpty(ppmSTB.Text) OrElse ppmSTB.Text = "0" Then
            wtSL.Text = ""
            ppmSL.Text = ""
        Else
            ' Si se escribe en ppmSTB y Sample Weight está vacío, se muestra un mensaje en rojo
            If String.IsNullOrEmpty(SamWeiTB.Text) Then
                Label13.Text = "Sample Weight is needed!"
                Label13.ForeColor = Color.FromArgb(255, 0, 0)
                ppmSTB.Text = ""
            Else
                ' No permite escribir más de un punto decimal ni letras
                If Not IsNumeric(ppmSTB.Text) And ppmSTB.Text.Length > 0 Then
                    ppmSTB.Text = ppmSTB.Text.Substring(0, ppmSTB.Text.Length - 1)
                Else
                    ' No permite escribir '-'
                    If ppmSTB.Text.Replace("-", "") <> ppmSTB.Text Then
                        ppmSTB.Text = ppmSTB.Text.Replace("-", "")
                    Else
                        ' No permite escribir ','
                        If ppmSTB.Text.Replace(",", "") <> ppmSTB.Text Then
                            ppmSTB.Text = ppmSTB.Text.Replace(",", "")
                        Else
                            ' No permite escribir espacios en blanco
                            If ppmSTB.Text.Replace(" ", "") <> ppmSTB.Text Then
                                ppmSTB.Text = ppmSTB.Text.Replace(" ", "")
                            Else
                                If String.IsNullOrEmpty(TotWeiTB.Text) OrElse TotWeiTB.Text = "0" Then
                                    wtSL.Text = ""
                                    ppmSL.Text = ""
                                    Exit Sub
                                Else
                                    wtSL.Text = CDbl(TotWeiTB.Text) * CDbl(ppmSTB.Text) / CDbl(SamWeiTB.Text) / 10000
                                    wtSL.Text = String.Format("{0:0.00000000}", CDbl(wtSL.Text))
                                    wtSL.ForeColor = Color.FromArgb(0, 130, 0)
                                    ppmSL.Text = CDbl(TotWeiTB.Text) * CDbl(ppmSTB.Text) / CDbl(SamWeiTB.Text)
                                    ppmSL.Text = String.Format("{0:0.0000}", CDbl(ppmSL.Text))
                                    ppmSL.ForeColor = Color.FromArgb(0, 0, 255)
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        If String.IsNullOrEmpty(SamWeiTB.Text) And String.IsNullOrEmpty(TotWeiTB.Text) _
    And String.IsNullOrEmpty(ppmPTB.Text) And String.IsNullOrEmpty(ppmZnTB.Text) _
    And String.IsNullOrEmpty(ppmMgTB.Text) And String.IsNullOrEmpty(ppmCaTB.Text) Then
            Label33.Text = "All is already clean!"
            Label33.ForeColor = Color.FromArgb(255, 0, 0)
        Else
            SamWeiTB.Text = ""
            TotWeiTB.Text = ""
            ppmPTB.Text = ""
            ppmZnTB.Text = ""
            ppmMgTB.Text = ""
            ppmCaTB.Text = ""
            ppmBaTB.Text = ""
            ppmBTB.Text = ""
            ppmCuTB.Text = ""
            ppmMoTB.Text = ""
            ppmSTB.Text = ""
            Label33.Text = ""
        End If
    End Sub

    Private Sub CommandButton1_Click(sender As Object, e As EventArgs) Handles CommandButton1.Click
        Application.Exit()
    End Sub
