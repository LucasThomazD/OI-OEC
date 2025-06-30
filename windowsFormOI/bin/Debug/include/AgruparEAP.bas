Sub AgruparPorTamanhoCaracteres()
    Dim ws As Worksheet
    Dim ultimaLinha As Long
    Dim i As Long
    Dim nivelAgrupamento As Integer
    
    Set ws = ActiveSheet
    ultimaLinha = ws.Cells(ws.Rows.Count, 1).End(xlUp).Row
    
    ' Desativa a atualização da tela para melhorar desempenho
    Application.ScreenUpdating = False
    
    ' Percorre cada linha e aplica agrupamento com base no tamanho do texto
    For i = 2 To ultimaLinha
        nivelAgrupamento = Len(ws.Cells(i, 1).Value) ' Conta os caracteres da célula
        
        If nivelAgrupamento <= 8 Then
            ws.Rows(i).OutlineLevel = 1
        ElseIf nivelAgrupamento <= 9 Then
            ws.Rows(i).OutlineLevel = 2
        ElseIf nivelAgrupamento <= 12 Then
            ws.Rows(i).OutlineLevel = 3
        ElseIf nivelAgrupamento <= 15 Then
            ws.Rows(i).OutlineLevel = 4
        ElseIf nivelAgrupamento <= 16 Then
            ws.Rows(i).OutlineLevel = 5
        ElseIf nivelAgrupamento <= 19 Then
            ws.Rows(i).OutlineLevel = 6
        Else
            ws.Rows(i).OutlineLevel = 7
        End If
    Next i
    
    ' Habilita a estrutura de tópicos
    ws.Outline.ShowLevels RowLevels:=1
    
    ' Reativa a atualização da tela
    Application.ScreenUpdating = True
End Sub