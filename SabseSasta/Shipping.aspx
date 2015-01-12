<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Shipping.aspx.cs" Inherits="SabseSasta.Shipping" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script type="text/javascript">
        window.history.forward(1);
</script>
    <style type="text/css">
        .auto-style13 {
            width: 133px;
        }
        .auto-style14 {
            width: 133px;
            height: 26px;
        }
        .auto-style15 {
            height: 26px;
        }
    .auto-style16 {
        width: 615px;
    }
    .auto-style17 {
        height: 23px;
    }
    .auto-style18 {
        width: 615px;
        height: 23px;
    }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table style="width:100%;">
        <tr>
            <td class="auto-style13">
                <asp:Label ID="Label13" runat="server" Text="Email"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox9" runat="server" Width="200px"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ControlToValidate="TextBox9" Display="Dynamic" ErrorMessage="Enter Email" ForeColor="#990000"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" ControlToValidate="TextBox9" Display="Dynamic" ErrorMessage="Enter correct email" ForeColor="#990000" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style14">Address</td>
            <td class="auto-style15">
                <asp:TextBox ID="TextBox10" runat="server" TextMode="MultiLine" Width="200px" Height="92px"></asp:TextBox>
            </td>
            <td class="auto-style15">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="TextBox10" Display="Dynamic" ErrorMessage="Enter Address" ForeColor="#990000"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style13">
                <asp:Label ID="Label14" runat="server" Text="Contact Number"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox11" runat="server" Width="200px"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="TextBox11" Display="Dynamic" ErrorMessage="Enter Contact Number" ForeColor="#990000"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style13">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style13">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>

            <br />
            <br />
            <br />
            <br />
            <table style="width: 100%;">
                <tr>
                    <td colspan="3" align="center">
                        <asp:GridView ID="GridView1" runat="server">
                        </asp:GridView>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style17"></td>
                    <td align="right" class="auto-style18">
                        <asp:Label ID="Label15" runat="server" Text="Total Amount     "></asp:Label>
                    </td>
                    <td align="right" class="auto-style17">
                        <asp:Label ID="Label16" runat="server" Text="Rs : "></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td class="auto-style16">&nbsp;</td>
                    <td align ="right">
                        <asp:Button ID="Button9" runat="server" Text="Make Payement" OnClick="Button9_Click" CausesValidation="False" />
                    </td>
                </tr>
            </table>
        </tr>
    </table>
</asp:Content>
