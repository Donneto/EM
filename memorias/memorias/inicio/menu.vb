Public Class menu

   

    Private Sub BarButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        Dim iparticipantes As New inicioparticipantes
        iparticipantes.MdiParent = Me
        iparticipantes.Show()
    End Sub

    Private Sub BarButtonItem6_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem6.ItemClick
        Dim icapacitadores As New iniciocapacitadores
        icapacitadores.MdiParent = Me
        icapacitadores.Show()
    End Sub

    Private Sub BarButtonItem7_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem7.ItemClick
        Dim italler As New iniciotaller
        italler.MdiParent = Me
        italler.Show()
    End Sub

    Private Sub BarButtonItem14_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem14.ItemClick
        Me.Close()
    End Sub

    Private Sub BarButtonItem15_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem15.ItemClick
        Dim imemorias As New iniciomemorias
        imemorias.MdiParent = Me
        imemorias.Show()
    End Sub

    Private Sub BarButtonItem16_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem16.ItemClick
        Dim imovpolitico As New iniciomovpolitico
        imovpolitico.MdiParent = Me
        imovpolitico.Show()
    End Sub

    Private Sub BarButtonItem17_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem17.ItemClick
        Dim ipais As New iniciopaises
        ipais.MdiParent = Me
        ipais.Show()
    End Sub

    Private Sub BarButtonItem18_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem18.ItemClick
        Dim iregion As New inicioregiones
        iregion.MdiParent = Me
        iregion.Show()
    End Sub

    Private Sub BarButtonItem19_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem19.ItemClick
        Dim itipotaller As New iniciotipotaller
        itipotaller.MdiParent = Me
        itipotaller.Show()
    End Sub

    Private Sub BarButtonItem20_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem20.ItemClick
        If Me.RibbonControl1.Minimized = True Then
            Me.RibbonControl1.Minimized = False
            BarButtonItem20.Caption = "Oculpar menu"
        Else
            Me.RibbonControl1.Minimized = True
            BarButtonItem20.Caption = "Mostrar menu"
        End If
    End Sub
End Class