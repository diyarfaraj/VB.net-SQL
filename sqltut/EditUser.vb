Public Class EditUser
    Private SQL As New SQLControll

    Private Sub FetchUsers()
        'REFRESH USER LIST
        lbUsers.Items.Clear()

        'ADD PARAMS & RUN QUERY
        SQL.AddParams("@Users", "%" & txtFilter.Text & "%")
        SQL.ExecQuery("SELECT username " &
                      "FROM members " &
                      "WHERE Username LIKE @Users ORDER BY username;")

        'REPORT AND ABORT
        If SQL.HasException(True) Then Exit Sub

        'LOOP ROWS AND RETURN USERS TO OUR LIST
        For Each r As DataRow In SQL.DBDT.Rows
            lbUsers.Items.Add(r("username"))
        Next
    End Sub

    Private Sub GetUserDetails(Username As String)
        SQL.AddParams("@User", Username)
        SQL.ExecQuery("SELECT TOP 1 * FROM members WHERE username = @User")

        If SQL.RecordCont < 1 Then Exit Sub
        For Each r As DataRow In SQL.DBDT.Rows
            txtID.Text = r("ID")
            txtUsername.Text = r("username")
            txtPassword.Text = r("password")
            cbActive.Checked = r("active")
            cbAdmin.Checked = r("admin")


        Next
    End Sub

    Private Sub UpdateUser()
        SQL.AddParams("@password", txtPassword.Text)
        SQL.AddParams("@active", cbActive.Checked)
        SQL.AddParams("@admin", cbAdmin.Checked)
        SQL.AddParams("@id", txtID.Text)


        SQL.ExecQuery("UPDATE members SET password = @password, active = @active, admin = @admin WHERE ID = @id;")

        If SQL.HasException(True) Then Exit Sub

        MsgBox("User has been updated")

        'CLEAR FIELDS AFTER UPDATE
        txtID.Clear()
        txtPassword.Clear()
        txtUsername.Clear()
        cbAdmin.Checked = False
        cbActive.Checked = False



    End Sub

    Private Sub EditUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = Form1
        FetchUsers()
    End Sub

    Private Sub txtFilter_KeyDown(sender As Object, e As KeyEventArgs) Handles txtFilter.KeyDown
        If e.KeyCode = Keys.Enter Then
            FetchUsers()
            e.Handled = True
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub lbUsers_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbUsers.SelectedIndexChanged
        GetUserDetails(lbUsers.Text)
    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        UpdateUser()
    End Sub
End Class