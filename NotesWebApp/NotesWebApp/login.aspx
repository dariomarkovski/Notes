<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="NotesWebApp.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        body {
            font-family: Verdana;
            background: dodgerblue;
        }

        .login-wrap-title {
            text-align: center;
            font-size: 30px;
            font-weight: bold;
            padding: 20px;
        }

        .input-text-box {
            width: 50%;
            margin: 5px auto auto auto;
            border-radius: 4px;
            display: block;
            font-size: 20px;
        }

        .label-element {
            width: 50%;
            margin: auto;
            display: block;
        }

        .login-wrap-body-element {
            text-align: center;
            padding: 5px;
        }

        .login-wrap-body {
            font-size: 20px;
        }

        .button {
            width: 120px;
            height: 30px;
            background: gray;
            border: none;
            font-weight: 600;
        }

            .button:hover {
                background: darkgray;
                cursor: pointer;
            }
    </style>
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
