Imports System.Data.SqlClient
Imports System.Data

Partial Class Delete
    Inherits System.Web.UI.Page

    Dim _constr As String = ConfigurationManager.ConnectionStrings("con").ConnectionString
    Dim con As SqlConnection
    Dim cmd As SqlCommand

    Protected Sub connection()
        con = New SqlConnection(_constr)
        Try
            con.Open()
        Catch ex As Exception

        End Try
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        connection()

        Dim getID As Integer = Convert.ToInt64(Request.QueryString("id"))

        If getID > 0 Then
            cmd = New SqlCommand("delete from stud where id = '" & getID & "'", con)
            Try
                cmd.ExecuteNonQuery()
                MsgBox("Student Deleted")
                Response.Redirect("Default.aspx")
            Catch ex As Exception
                'MsgBox(ex.Message)
            End Try
        End If

    End Sub
End Class
