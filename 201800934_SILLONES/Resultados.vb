Module Resultados

    Const m_sofa = 250.99
    Const m_individual = 150.99
    Const m_doble = 200.99

    Const t_cuerina = 75
    Const t_cuero = 45.99

    Const y_sofa = 8
    Const y_individual = 3.5
    Const y_doble = 6

    Function PrecioCosto() As Double
        Dim pcosto As Long
        If Form1.rb_cuerina.Checked Then
            Select Case Form1.cb_tsillon.SelectedIndex
                Case 0
                    pcosto = m_sofa + t_cuerina * y_sofa
                Case 1
                    pcosto = m_individual + t_cuerina * y_individual
                Case 2
                    pcosto = m_doble + t_cuerina * y_doble
            End Select
        ElseIf Form1.rb_cuero.Checked Then
            Select Case Form1.cb_tsillon.SelectedIndex
                Case 0
                    pcosto = m_sofa + t_cuero * y_sofa
                Case 1
                    pcosto = m_individual + t_cuero * y_individual
                Case 2
                    pcosto = m_doble + t_cuero * y_doble
            End Select

        End If

        Return pcosto
    End Function

    Function PrecioVenta() As Double
        Dim pventa As Long

        pventa = PrecioCosto()

        Return pventa + pventa * 0.65
    End Function

    Sub Limpiartabla()
        Form1.tabla.DataSource = ""
        Form1.index = 0
    End Sub

    Sub LimpiarVectores()
        For i = 0 To 7
            Form1.numero_venta(i) = " "
            Form1.tipo_tela(i) = " "
            Form1.tamaño_sillon(i) = " "
            Form1.precio_costo(i) = 0
            Form1.precio_venta(i) = 0
        Next i


    End Sub


End Module
