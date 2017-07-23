<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="NotesWebApp.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Home</title>
    <link rel="stylesheet" type="text/css" href="Style.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div class="header-wrap">
                <asp:Label ID="usernameLabel" runat="server" Text="Label" CssClass="header-element-username"></asp:Label>
                <asp:Button ID="logoutButton" runat="server" Text="Logout" OnClick="logoutButton_Click" CssClass="header-element-logout" />
            </div>
            <div class="body-wrap">

                <div class="center-div">
                    <asp:GridView ID="gvNotes" runat="server" CssClass="grid-view" AutoGenerateColumns="False" OnSelectedIndexChanged="gvNotes_SelectedIndexChanged" DataKeyNames="NoteId,Username,Title,Text">
                        <Columns>
                            <asp:BoundField DataField="NoteId" HeaderText="Id" Visible="False" />
                            <asp:BoundField DataField="Username" HeaderText="Username" Visible="False" />
                            <asp:ButtonField CommandName="select" DataTextField="Title" HeaderText="Titles of Notes" Text="Button" Visible="True" HeaderStyle-CssClass="grid-header" ItemStyle-CssClass="grid-item"></asp:ButtonField>
                            <asp:BoundField DataField="Text" HeaderText="Text" Visible="False" />
                        </Columns>
                    </asp:GridView>
                    <span class="help-span">Click on a title to open note!</span>
                </div>


                <div class="center-div">
                    <asp:TextBox ID="titleBox" runat="server" CssClass="title-box" Visible="False"></asp:TextBox>
                    <asp:TextBox ID="bodyBox" runat="server" CssClass="body-box" TextMode="MultiLine" Rows="10" Visible="False" MaxLength="150"></asp:TextBox>
                </div>

                <div class="center-div btn-div">
                    <asp:Button ID="newNoteBtn" runat="server" Text="Add New Note" CssClass="button" Visible="true" OnClick="newNoteBtn_Click" />
                </div>

                <div class="center-div btn-div">
                    <asp:Button ID="btnDelete" runat="server" Text="Delete" CssClass="button" OnClick="btnDelete_Click" Visible="False" />
                    <asp:Button ID="btnUpdate" runat="server" Text="Update" CssClass="button" OnClick="btnUpdate_Click" Visible="False" />
                    <asp:Button ID="btnUnselect" runat="server" Text="Unselect" CssClass="button" Visible="false" OnClick="btnUnselect_Click" />
                </div>

                <div class="center-div btn-div">
                    <asp:Button ID="cancelBtn" runat="server" Text="Cancel" CssClass="button" Visible="false" OnClick="cancelBtn_Click" />
                    <asp:Button ID="addBtn" runat="server" Text="Add" CssClass="button" Visible="false" OnClick="addBtn_Click" />
                </div>

                <asp:Label ID="errorLabel" runat="server" Text="Label" Visible="False"></asp:Label>
            </div>
        </div>
    </form>
</body>
</html>
