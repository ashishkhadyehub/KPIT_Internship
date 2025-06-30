<%@ Page Title="" Language="C#" MasterPageFile="~/User.Master" AutoEventWireup="true" CodeBehind="ViewStateExample.aspx.cs" Inherits="Internship.Sessions.ViewStateExample" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-md-6">
                <h3>ViewState Example</h3>
                <asp:TextBox runat="server" ID="txtcount"></asp:TextBox>
                <asp:Button runat="server" Text="Click" ID="btnclick" OnClick="btnclick_Click" />
            </div>
        </div>
    </div>
</asp:Content>
