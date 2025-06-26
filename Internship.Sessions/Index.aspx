<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Internship.Sessions.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Webform</title>
      <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet">
  <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container mt-3">
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
               <asp:Button runat="server" ID="btnSubmit" CssClass="btn btn-success" Text="Register" />
               
            
        </div>
    </form>
</body>
</html>
