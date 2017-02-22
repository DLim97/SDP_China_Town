Public Class WebForm2
    Inherits System.Web.UI.Page
    Dim con As New OleDb.OleDbConnection

    Dim dbProvider As String
    Dim dbSource As String
    Dim da As New OleDb.OleDbDataAdapter
    Dim ds As New DataSet
    Dim Sql As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        dbProvider = "PROVIDER=Microsoft.JET.OLEDB.4.0;"
        dbSource = "Data Source=|DataDirectory|Hote.mdb"
        con.ConnectionString = dbProvider & dbSource
        con.Open()



        Sql = "SELECT * FROM RoomDetails"
        da = New OleDb.OleDbDataAdapter(Sql, con)
        da.Fill(ds, "ModifyRoom")

        Dim dt As New DataTable
        da.Fill(dt)
        gd1.DataSource = dt
        gd1.DataBind()

    End Sub
End Class