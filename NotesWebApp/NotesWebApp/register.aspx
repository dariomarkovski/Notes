<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="NotesWebApp.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Register</title>
    <style>
        body {
            font-family: Verdana;
            background: dodgerblue;
        }

        .register-wrap-title {
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

        .register-wrap-body-element {
            text-align: center;
            padding: 5px;
        }

        .register-wrap-body {
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
        <div class="register-wrap">
            <div class="register-wrap-title">
                ENTER YOUR INFORMATION AND REGISTER
            </div>
            <div class="register-wrap-body">
                <div class="register-wrap-body-element">
                    <asp:Label ID="usernameLabel" runat="server" CssClass="label-element">Username</asp:Label>
                    <asp:TextBox ID="usernameTextBox" runat="server" CssClass="input-text-box"></asp:TextBox>
                    <asp:RequiredFieldValidator runat="server" ControlToValidate="usernameTextBox" ErrorMessage="required" ForeColor="Red" />
                </div>
                <div class="register-wrap-body-element">
                    <asp:Label ID="passLabel" runat="server" CssClass="label-element">Password</asp:Label>
                    <asp:TextBox ID="passTextBox" runat="server" CssClass="input-text-box" TextMode="Password"></asp:TextBox>
                    <asp:RequiredFieldValidator runat="server" ControlToValidate="passTextBox" ErrorMessage="required" ForeColor="Red" />
                </div>
                <div class="register-wrap-body-element">
                    <asp:Label ID="confirmLabel" runat="server" CssClass="label-element">Confirm Password</asp:Label>
                    <asp:TextBox ID="confirmTextBox" runat="server" CssClass="input-text-box" TextMode="Password"></asp:TextBox>
                    <asp:CompareValidator runat="server" ControlToValidate="confirmTextBox" ControlToCompare="passTextBox" ErrorMessage="Password don't match!" ForeColor="Red" />
                </div>
                <div class="register-wrap-body-element">
                    <asp:Label ID="emailLabel" runat="server" CssClass="label-element">Email</asp:Label>
                    <asp:TextBox ID="emailTextBox" runat="server" CssClass="input-text-box"></asp:TextBox>
                    <asp:RequiredFieldValidator runat="server" ControlToValidate="emailTextBox" ErrorMessage="required" ForeColor="Red" />
                </div>
                <div class="register-wrap-body-element">
                    <asp:Button ID="cancelButton" runat="server" Text="Cancel" CssClass="button" CausesValidation="False" OnClick="cancelButton_Click" />
                    <asp:Button ID="registerBtn" runat="server" Text="Register" CssClass="button" OnClick="registerBtn_Click" />
                </div>
                <div class="login-wrap-body-element">
                    <asp:Label ID="errorLabel" runat="server" Text="" Visible="false"></asp:Label>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
