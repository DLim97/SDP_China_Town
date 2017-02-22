Imports System.Data.OleDb
Imports System.Data
Public Class WebForm9
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim connect As String = "Provider=Microsoft.Jet.OleDb.4.0;" & "Data Source=|DataDirectory|Hote.mdb"
        Dim query As String = ("INSERT INTO CheckInOut (CheckInOutID , CheckIn, CheckOut, CustomerID, RoomID, ReservationID) VALUES (id , '" & TextBox1.Text & "', '" & Calendar1.TodaysDate.ToShortDateString & "','" & Calendar1.SelectedDate.ToShortDateString & "', NULL, '" & DropDownList1.SelectedValue & "', NULL")
        Dim con As New OleDbConnection(connect)
        Dim cmd As New OleDbCommand(query, con)

        con.Open()

        cmd.ExecuteNonQuery()


    End Sub
End Class