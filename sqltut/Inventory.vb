Public Class Inventory

    Public SQL As New SQLControll

    Public Sub LoadGrid(Optional Query As String = "")
        If Query = "" Then
            SQL.ExecQuery("SELECT * FROM Products;")
        Else
            SQL.ExecQuery(Query)

        End If

        'ERROR HADNLING
        If SQL.HasException(True) Then Exit Sub


        ' IF ALL GOOD THEN POPULATE GRID
        dgvData.DataSource = SQL.DBDT
    End Sub

    Private Sub FindItem()
        SQL.AddParams("@Item", "%" & txtSearch.Text & "%")
        LoadGrid("SELECT * FROM Products WHERE PartNo LIKE @item;")
    End Sub

    Private Sub Inventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = Form1
        LoadGrid()
    End Sub

    Private Sub cmdSearch_Click(sender As Object, e As EventArgs) Handles cmdSearch.Click
        FindItem()
    End Sub
End Class