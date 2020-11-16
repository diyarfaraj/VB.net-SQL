Imports System.Data.SqlClient




Public Class SQLControll
    Private DbCon As New SqlConnection("Server=localDb\demoDB;Database=SQLTutorial;User=demoUser;Pwd=Password1;")
    Private DBCmd As SqlCommand

    'DB DATA
    Public DBDA As SqlDataAdapter
    Public DBDT As DataTable

    '   QUERY PARAMS
    Public Params As New List(Of SqlParameter)

    'QUERY STATS
    Public RecordCont As Integer
    Public Exception As String

    Public Sub New()
    End Sub

    'ALLOW CONNECTION STRIN OVERRIDE

    Public Sub New(ConnectionString As String)
        DbCon = New SqlConnection(ConnectionString)
    End Sub

    ' EXECUTE QUERY SUB
    Public Sub ExecQuery(Query As String)
        ' RESET QUERY STAT
        RecordCont = 0
        Exception = ""

        Try
            DbCon.Open()

            'CREATE DB COMMAND
            DBCmd = New SqlCommand(Query, DbCon)

            'LOAD PARAMS INTO DB COMMAND
            Params.ForEach(Sub(p) DBCmd.Parameters.Add(p))

            'CLEAR PARAM LIST
            Params.Clear()

            'EXUCUTE COMMAND AND FILL OUR DATA SET
            DBDT = New DataTable
            DBDA = New SqlDataAdapter(DBCmd)

            RecordCont = DBDA.Fill(DBDT)

        Catch ex As Exception
            ' CATCH ERROR
            Exception = "ExecQuery Error: " & vbNewLine & ex.Message


        Finally
            'CLOSE CONNECITON
            If DbCon.State = ConnectionState.Open Then DbCon.Close()
        End Try

    End Sub

    '  ADD PARAMS
    Public Sub AddParams(Name As String, Value As Object)
        Dim NewParam As New SqlParameter(Name, Value)
        Params.Add(NewParam)
    End Sub

    'ERROR CHECKING
    Public Function HasException(Optional Report As Boolean = False) As Boolean
        If String.IsNullOrEmpty(Exception) Then Return False
        If Report = True Then MsgBox(Exception, MsgBoxStyle.Critical, "Excepcioneess")
        Return True
    End Function
End Class
