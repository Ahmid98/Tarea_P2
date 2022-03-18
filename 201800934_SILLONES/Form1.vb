Public Class Form1
    Public numero_venta(7) As String
    Public tipo_tela(7) As String
    Public tamaño_sillon(7) As String
    Public precio_costo(7) As Long
    Public precio_venta(7) As Long
    Public index As Byte = 0


    Private Sub btn_calcular_Click(sender As Object, e As EventArgs) Handles btn_calcular.Click


        If index < 8 Then
            If txt_nventa.Text <> "" Then
                numero_venta(index) = txt_nventa.Text
            Else
                MsgBox("Debe ingresar un numero de venta..")
                Exit Sub
            End If

            If rb_cuerina.Checked Or rb_cuero.Checked Then
                If rb_cuerina.Checked Then
                    tipo_tela(index) = "Cuerina"
                ElseIf rb_cuero.Checked Then
                    tipo_tela(index) = "Cuero"
                End If
            Else
                MsgBox("Debe seleccionar una tela..")
                Exit Sub
            End If

            If cb_tsillon.SelectedIndex <> -1 Then
                tamaño_sillon(index) = cb_tsillon.SelectedItem
            Else
                MsgBox("Debe seleccionar un tamaño..")
                Exit Sub
            End If

            precio_costo(index) = System.Math.Round(Resultados.PrecioCosto, 2)
            precio_venta(index) = System.Math.Round(Resultados.PrecioVenta, 2)

            tabla.Rows.Add(numero_venta(index), tipo_tela(index), tamaño_sillon(index), precio_costo(index), precio_venta(index))
            index = index + 1
        Else
            MsgBox("La tabla ya no acepta mas datos..")
            Exit Sub
        End If
    End Sub

    Private Sub txt_nventa_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_nventa.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub LIMPIARENTRADASToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIMPIARENTRADASToolStripMenuItem.Click
        txt_nventa.Clear()
        rb_cuerina.Checked = False
        rb_cuero.Checked = False
        cb_tsillon.SelectedIndex = -1
    End Sub

    Private Sub LIMPIARTABLAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIMPIARTABLAToolStripMenuItem.Click
        Resultados.Limpiartabla()
    End Sub

    Private Sub LIMPIARVECTORESToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIMPIARVECTORESToolStripMenuItem.Click
        Resultados.LimpiarVectores()
    End Sub

    Private Sub SALIRToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SALIRToolStripMenuItem.Click
        If MsgBox("Deseas salir", vbYesNo, "") = vbYes Then
            End
        End If
    End Sub
End Class
