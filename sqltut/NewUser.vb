Public Class NewUser
    Private SQL As New SQLControll
    Private Sub NewUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = Form1

    End Sub

    Private Sub InsertUser()
        ' ADD SQL PARAMS & RUN THE COMMAND
        SQL.AddParams("@User", txtUser.Text)
        SQL.AddParams("@Password", txtPassword.Text)
        SQL.AddParams("@Active", cbActive.Checked)
        SQL.AddParams("@Admin", cbAdmin.Checked)


        SQL.ExecQuery("INSERT INTO members (username,password,active,admin,joindate) " &
                      "VALUES (@User,@Password,@Active,@Admin,GETDATE());", True)

        'REPORT & ABORT
        If SQL.HasException(True) Then Exit Sub

        If SQL.DBDT.Rows.Count > 0 Then
            Dim r As DataRow = SQL.DBDT.Rows(0)
            MsgBox(r("LastID").ToString)
        End If

        MsgBox("USER CREATED SUCCESSFULLY")
    End Sub

    Private Sub cmdSubmit_Click(sender As Object, e As EventArgs) Handles cmdSubmit.Click
        InsertUser()

        'CLEAR FILEDS
        txtPassword.Clear()
        txtUser.Clear()
        cbActive.Checked = False
        cbAdmin.Checked = False
        cmdSubmit.Enabled = False

    End Sub

    Private Sub txtFields_TextChanged(sender As Object, e As EventArgs) Handles txtUser.TextChanged, txtPassword.TextChanged
        'BASIC VALIDATION
        If Not String.IsNullOrEmpty(txtUser.Text) AndAlso Not String.IsNullOrWhiteSpace(txtPassword.Text) Then
            cmdSubmit.Enabled = True
        End If
    End Sub
End Class