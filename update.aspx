<%@ Page Language="VB" AutoEventWireup="false" CodeFile="update.aspx.vb" Inherits="update" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <center>
    <h1>Update Student</h1>
        <table>
            <tr>
                <td>
                    ID
                </td>
                <td>
                    <asp:TextBox ID="TextBoxID" runat="server" Disabled="disabled"></asp:TextBox>
                    <asp:RequiredFieldValidator
                        ID="RequiredFieldValidatorID" runat="server" ErrorMessage="     Id Needed !" 
                        ControlToValidate="TextBoxID" ForeColor="#CC0000" SetFocusOnError="True"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>
                    Update Name
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
                    Update Gender
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
                    <asp:Button ID="ButtonUpd" runat="server" Text="Update Student" />
                </td>
            </tr>
        </table>
    </center>
    </div>
    </form>
</body>
</html>
