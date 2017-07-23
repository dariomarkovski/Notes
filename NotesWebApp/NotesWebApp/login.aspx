<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="NotesWebApp.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" type="text/css" href="Style.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="login-wrap">
            <div class="login-wrap-title">
                PLEASE LOG IN
            </div>
            <div class="login-wrap-body">
                <div class="login-wrap-body-element">
                    <asp:Label ID="usernameLabel" runat="server" CssClass="label-element">Username</asp:Label>
                    <asp:TextBox ID="usernameTextBox" runat="server" CssClass="input-text-box"></asp:TextBox>
                </div>
                <div class="login-wrap-body-element">
                    <asp:Label ID="passLabel" runat="server" CssClass="label-element">Password</asp:Label>
                    <asp:TextBox ID="passTextBox" runat="server" CssClass="input-text-box" TextMode="Password"></asp:TextBox>
                </div>
                <div class="login-wrap-body-element">
                    <asp:Button ID="loginBtn" runat="server" Text="Log In" OnClick="loginBtn_Click" CssClass="button" />
                    <asp:Button ID="registerBtn" runat="server" Text="Register" OnClick="registerBtn_Click" CssClass="button" />
                </div>
                <div class="login-wrap-body-element">
                    <asp:Label ID="errorLabel" runat="server" Text="" Visible="false"></asp:Label>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
