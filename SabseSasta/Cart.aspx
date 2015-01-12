<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Cart.aspx.cs" Inherits="SabseSasta.Cart" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script type="text/javascript">
        window.history.forward(1);
</script>
    <style type="text/css">
    .auto-style16 {
        width: 270px;
    }
    .auto-style17 {
        width: 274px;
    }
    .auto-style18 {
        width: 270px;
        height: 23px;
    }
    .auto-style19 {
        width: 274px;
        height: 23px;
    }
    .auto-style20 {
        height: 23px;
    }
    .auto-style21 {
        height: 136px;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table style="width:100%;" __designer:mapid="275">
    <tr __designer:mapid="276">
        <td colspan="3" align="center" __designer:mapid="277" class="auto-style21">
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
        </td>
    </tr>
    <tr __designer:mapid="279">
        <td class="auto-style18" __designer:mapid="27a"></td>
        <td __designer:mapid="27b" class="auto-style19"></td>
        <td __designer:mapid="27c" class="auto-style20"></td>
    </tr>
    <tr __designer:mapid="27d">
        <td class="auto-style16" align="right" __designer:mapid="27e">&nbsp;</td>
        <td __designer:mapid="280" class="auto-style17">
            <asp:Button ID="Button10" runat="server" Height="28px" Text="Continue Shopping" Width="142px" OnClick="Button10_Click" CausesValidation="False" />
            <asp:Button ID="Button11" runat="server" Text="Make Payment" CausesValidation="False" Height="28px" OnClick="Button11_Click" />
        </td>
        <td __designer:mapid="281">&nbsp;</td>
    </tr>
</table>
</asp:Content>
