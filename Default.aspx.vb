Imports System.Data.SqlClient
Imports System.Data

Partial Class _Default
    Inherits System.Web.UI.Page

    Dim _constr As String = ConfigurationManager.ConnectionStrings("con").ConnectionString
    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Dim ad As SqlDataAdapter
    Dim ds As DataSet

    Protected Sub connection()
        con = New SqlConnection(_constr)
        Try
            con.Open()
            'MsgBox("Connected")
        Catch ex As Exception

        End Try
    End Sub

    Protected Sub createTable()
        cmd = New SqlCommand("create table stud(id int primary key,name text,gender varchar(64))", con)
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            'Page.Controls.Add(New LiteralControl("<script>alert('Table Exists')</script>"))
        End Try
    End Sub

    Protected Sub insertRecord()
        cmd = New SqlCommand("insert into stud values(@id,@name,@gender)", con)
        Try
            cmd.Parameters.AddWithValue("@id", Convert.ToInt64(TextBoxID.Text.Trim))
            cmd.Parameters.AddWithValue("@name", TextBoxName.Text.Trim)
            cmd.Parameters.AddWithValue("@gender", DropDownListGender.SelectedValue)
            cmd.ExecuteNonQuery()
            Page.Controls.Add(New LiteralControl("<script>alert('Student Added')</script>"))
        Catch ex As Exception
            Page.Controls.Add(New LiteralControl("<script>alert('Student Exists')</script>"))
        End Try
    End Sub

    Protected Sub ClearFields()
        TextBoxID.Text = ""
        TextBoxName.Text = ""
    End Sub

    Protected Sub ShowData()
        ad = New SqlDataAdapter("select * from stud", con)
        ds = New DataSet

        Try
            ad.Fill(ds)
            GridView1.DataSource = ds.Tables(0)
            GridView1.DataBind()
        Catch ex As Exception
            MsgBox("Table empty")
        End Try
    End Sub

    Protected Sub ButtonAdd_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonAdd.Click
        connection()
        createTable()
        insertRecord()
        ShowData()
        ClearFields()
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        connection()
        ShowData()
    End Sub
End Class
