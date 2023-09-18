<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <center>
        <table>
            <tr>
                <td>
                    Enter ID
                </td>
                <td>
                    <asp:TextBox ID="TextBoxID" runat="server" CausesValidation="true"></asp:TextBox>
                    <asp:RequiredFieldValidator
                        ID="RequiredFieldValidatorID" runat="server" ErrorMessage="     Id Needed !" 
                        ControlToValidate="TextBoxID" ForeColor="#CC0000" SetFocusOnError="True"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>
                    Enter Name
                </td>
                <td>
                    <asp:TextBox ID="TextBoxName" runat="server" CausesValidation="true"></asp:TextBox>
                    <asp:RequiredFieldValidator 
                        ID="RequiredFieldValidatorName" runat="server" 
                        ControlToValidate="TextBoxName" ErrorMessage="   Name Required !" ForeColor="#CC0000" SetFocusOnError="True"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>
                    Enter Gender
                </td>
                <td>
                    <asp:DropDownList ID="DropDownListGender" runat="server">
                        <asp:ListItem>Male</asp:ListItem>
                        <asp:ListItem>Female</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>
                    
                </td>
                <td>
                    <asp:Button ID="ButtonAdd" runat="server" Text="Add Student" />
                </td>
            </tr>
        </table>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
            <Columns>
                <asp:BoundField DataField="id" HeaderText="ID" />
                <asp:BoundField DataField="name" HeaderText="Name" />
                <asp:BoundField DataField="gender" HeaderText="Gender" />
                <asp:HyperLinkField DataNavigateUrlFields="id" 
                    DataNavigateUrlFormatString="update.aspx?id={0}" HeaderText="Update" 
                    Text="Update" />
                <asp:HyperLinkField DataNavigateUrlFields="id" 
                    DataNavigateUrlFormatString="delete.aspx?id={0}" HeaderText="Delete" 
                    Text="Delete" />
            </Columns>
        </asp:GridView>
    </center>
</asp:Content>



