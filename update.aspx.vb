
Imports System.Data.SqlClient
Imports System.Data

Partial Class update
    Inherits System.Web.UI.Page

    Dim _constr As String = ConfigurationManager.ConnectionStrings("con").ConnectionString
    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Dim ad As New SqlDataAdapter
    Dim ds As New DataSet

    Protected Sub connection()
        con = New SqlConnection(_constr)
        Try
            con.Open()
        Catch ex As Exception

        End Try
    End Sub


    Protected Sub ButtonUpd_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonUpd.Click
        connection()
        Dim getID As Integer = Convert.ToInt64(Request.QueryString("id"))
        cmd = New SqlCommand("update stud set name=@name , gender=@gender where id='" & getID & "'", con)
        cmd.Parameters.AddWithValue("@name", TextBoxName.Text.Trim)
        cmd.Parameters.AddWithValue("@gender", DropDownListGender.SelectedValue)

        Try
            cmd.ExecuteNonQuery()
            MsgBox("Student Updated")
            Response.Redirect("Default.aspx")
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        connection()
        Dim getID As Integer = Convert.ToInt64(Request.QueryString("id"))

        If getID > 0 Then
            ad = New SqlDataAdapter("select * from stud where id=" & getID & "", con)
            ds = New DataSet
            Try
                ad.Fill(ds)
                If IsPostBack = False Then
                    TextBoxID.Text = ds.Tables(0).Rows(0).Item(0)
                    TextBoxName.Text = ds.Tables(0).Rows(0).Item(1).ToString
                    DropDownListGender.SelectedValue = ds.Tables(0).Rows(0).Item(2).ToString
                End If
            Catch ex As Exception
                'MsgBox(ex.Message)
            End Try
        End If
    End Sub
End Class
