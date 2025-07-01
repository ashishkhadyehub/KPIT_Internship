<%@ Page Title="" Language="C#" MasterPageFile="~/User.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Internship.Sessions.Register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <%--head tag--%>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <%--body tag--%>
  <div class="container mt-3">
      <div class="row">
          <div class="col-md-6">
               <h2>User Registration</h2>
 
     <div class="mb-3 mt-3">
         <label>Name:</label>
         <asp:TextBox runat="server" ID="txtName" CssClass="form-control" ></asp:TextBox>
         
     </div>
     <div class="mb-3 mt-3">
         <label>Contact:</label>
         <asp:TextBox TextMode="Number" runat="server" ID="txtContact" CssClass="form-control" ></asp:TextBox>
         
     </div>
    <div class="mb-3 mt-3">
         <label>Email:</label>
         <asp:TextBox runat="server" TextMode="Email" ID="txtEmail" CssClass="form-control" ></asp:TextBox>
         
     </div>
    <div class="mb-3 mt-3">
         <label>Select City:</label>
         <asp:DropDownList runat="server" ID="ddlCity" CssClass="form-control">
             <asp:ListItem>Select City</asp:ListItem>
             <asp:ListItem>Kolhapur</asp:ListItem>
             <asp:ListItem>Pune</asp:ListItem>
             <asp:ListItem>Delhi</asp:ListItem>
         </asp:DropDownList>
         
     </div>
    <asp:Button runat="server" ID="btnSubmit" OnClick="btnSubmit_Click" CssClass="btn btn-success" Text="Register" />
          </div>
      </div>
    
        
     
 </div>
</asp:Content>
