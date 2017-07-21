<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="NotesWebApp.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:LoginView ID="LoginView1" runat="server">
            <AnonymousTemplate>
                WELCOME! PLEASE LOG IN TO VIEW YOUR NOTES!<br />
                <asp:LoginStatus ID="LoginStatus1" runat="server" />
            </AnonymousTemplate>
            <LoggedInTemplate>
                Good to see you. Here are you notes!
                <asp:LoginStatus ID="LoginStatus2" runat="server" />
            </LoggedInTemplate>
        </asp:LoginView>
    </form>
</body>
</html>
