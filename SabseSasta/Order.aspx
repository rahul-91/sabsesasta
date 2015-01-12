<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Order.aspx.cs" Inherits="SabseSasta.Order" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style13 {}
        .auto-style14 {
        height: 30px;
    }
        </style>
    <script type="text/javascript">
        window.history.forward(1);
</script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table style="width:100%;">
        <tr>
            <td class="auto-style13" align="center">
                <asp:Image ID="Image3" runat="server" />
            </td>
            <td class="auto-style13" colspan="2" align="center">
                <asp:Image ID="Image2" runat="server" />
            </td>
        </tr>
        <tr>
            <td class="auto-style13" align="center">
                &nbsp;</td>
            <td class="auto-style13" colspan="2" align="center">
                <asp:Label ID="Label14" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style14" align="center">
            </td>
            <td class="auto-style14" colspan="2" align="center">
                <asp:Label ID="Label13" runat="server" Text="No. of Units"></asp:Label>
&nbsp;
                <asp:TextBox ID="TextBox9" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td align="center">
                <asp:Button ID="Button9" runat="server" BackColor="#F76618" BorderColor="#F76618" Font-Bold="True" ForeColor="White" Text="Buy Now" Width="302px" OnClick="Button9_Click" CausesValidation="False" />
                r</td>
            <td>&nbsp;</td>
        </tr>
    </table>

    


</asp:Content>
