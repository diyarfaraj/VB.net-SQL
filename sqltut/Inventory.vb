Public Class Inventory

    Public SQL As New SQLControll

    Public Sub LoadGrid()
        SQL.ExecQuery("SELECT * FROM Products;")
        If SQL.HasException(True) Then Exit Sub

        ' IF ALL GOOD THEN POPULATE GRID
        dgvData.DataSource = SQL.DBDT
    End Sub

    Private Sub Inventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = Form1
        LoadGrid()
    End Sub
End Class