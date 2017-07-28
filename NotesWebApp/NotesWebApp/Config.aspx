<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Config.aspx.cs" Inherits="NotesWebApp.Config" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Config</title>
    <link rel="stylesheet" type="text/css" href="Style.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div class="header-wrap">
                <asp:Label ID="usernameLabel" runat="server" Text="Label" CssClass="header-element-username"></asp:Label>
                <asp:Button ID="configButton" runat="server" Text="Notes" CssClass="header-element-config" OnClick="configButton_Click" CausesValidation="False" />
                <asp:Button ID="logoutButton" runat="server" Text="Logout" OnClick="logoutButton_Click" CssClass="header-element-logout" CausesValidation="False" />
            </div>
            <div class="body-wrap">

                <div class="center-div">
                    <div class="register-wrap-body-element">
                        <asp:Label ID="currPwLabel" runat="server" CssClass="label-element">Current Password</asp:Label>
                        <asp:TextBox ID="currPwTb" runat="server" CssClass="input-text-box"></asp:TextBox>
                        <asp:RequiredFieldValidator runat="server" ControlToValidate="currPwTb" Display="Dynamic" ErrorMessage="Required" ForeColor="Red"></asp:RequiredFieldValidator>
                        <asp:Label ID="currPwError" runat="server" ForeColor="Red"></asp:Label>
                    </div>
                    <div class="register-wrap-body-element">
                        <asp:Label ID="newPwLabel" runat="server" CssClass="label-element">New Password</asp:Label>
                        <asp:TextBox ID="newPwTb" runat="server" CssClass="input-text-box"></asp:TextBox>
                        <asp:RequiredFieldValidator runat="server" ControlToValidate="newPwTb" ErrorMessage="Required" ForeColor="Red" Display="Dynamic" />
                        <asp:CompareValidator runat="server" ControlToCompare="currPwTb" ControlToValidate="newPwTb" Display="Dynamic" ErrorMessage="New password cannot match old password!" ForeColor="Red" Operator="NotEqual"></asp:CompareValidator>
                    </div>
                    <div class="register-wrap-body-element">
                        <asp:Label ID="confirmNewPwLabel" runat="server" CssClass="label-element">Confirm New Password</asp:Label>
                        <asp:TextBox ID="confirmNewPwTb" runat="server" CssClass="input-text-box"></asp:TextBox>
                        <asp:RequiredFieldValidator runat="server" ControlToValidate="confirmNewPwTb" ErrorMessage="Required" ForeColor="Red" Display="Dynamic" />
                        <asp:CompareValidator runat="server" ControlToCompare="newPwTb" ControlToValidate="confirmNewPwTb" Display="Dynamic" ErrorMessage="New password doesn't match!" ForeColor="Red"></asp:CompareValidator>
                    </div>
                    <div class="register-wrap-body-element">
                        <asp:Button ID="cancelButton" runat="server" Text="Cancel" CssClass="button" CausesValidation="False" OnClick="cancelButton_Click" />
                        <asp:Button ID="confirmBtn" runat="server" Text="Confirm" CssClass="button" OnClick="confirmBtn_Click" />
                        <br />
                        <asp:Label ID="pwChangeLabel" runat="server" ForeColor="Red"></asp:Label>
                    </div>
                </div>


            </div>
        </div>
    </form>
</body>
</html>
