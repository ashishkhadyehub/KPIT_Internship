<%@ Page Title="" Language="C#" MasterPageFile="~/User.Master" AutoEventWireup="true" CodeBehind="QS2.aspx.cs" Inherits="Internship.Sessions.QS2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div class="container">
    <div class="row">
        <div class="col-md-6">
            <div class="form-group my-2">
                <label>Name</label>
                <asp:TextBox runat="server" ID="txtName" CssClass="form-control"></asp:TextBox>
            </div>
             <div class="form-group my-2">
                <label>Contact</label>
                <asp:TextBox runat="server" ID="txtContact" CssClass="form-control"></asp:TextBox>
            </div>
           
        </div>
    </div>
</div>
</asp:Content>
