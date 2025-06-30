<%@ Page Title="" Language="C#" MasterPageFile="~/User.Master" AutoEventWireup="true" CodeBehind="S1.aspx.cs" Inherits="Internship.Sessions.S1" %>
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
                <asp:Button runat="server" OnClick="btnConfirm_Click" ID="btnConfirm" Class="btn btn-primary" Text="Confirm Now" />
            </div>
        </div>
    </div>
</asp:Content>
