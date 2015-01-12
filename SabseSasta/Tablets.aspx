<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Tablets.aspx.cs" Inherits="SabseSasta.Tablets" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script type="text/javascript">
        window.history.forward(1);
</script>
      <style type="text/css">
        .auto-style5 {
            width:300px;

        }
        .auto-style6 {
            height: 23px;
            width: 160px;
        }
        .auto-style7 {
            width: 299px;
        }
        .auto-style8 {
            width: 160px;
        }
        .accordionHeader
{
    border: 1px solid #2F4F4F;
    color: white;
    background-color: #2E4d7B;
	font-family: Arial, Sans-Serif;
	font-size: 12px;
	font-weight: bold;
    padding: 5px;
    margin-top: 5px;
    cursor: pointer;
}

.accordionHeaderSelected
{
    border: 1px solid #2F4F4F;
    color: white;
    background-color: #5078B3;
	font-family: Arial, Sans-Serif;
	font-size: 12px;
	font-weight: bold;
    padding: 5px;
    margin-top: 5px;
    cursor: pointer;
}

.accordionContent
{
    background-color: #D3DEEF;
    border: 1px dashed #2F4F4F;
    border-top: none;
    padding: 5px;
    padding-top: 10px;
}
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <script runat="Server" type="text/C#">
        [System.Web.Services.WebMethod]
        [System.Web.Script.Services.ScriptMethod]
        public static AjaxControlToolkit.Slide[] GetSlides()
        {
            return new AjaxControlToolkit.Slide[] { 
            new AjaxControlToolkit.Slide("Pictures/slideshow/pic1.jpg","pic1","pic2"),
            new AjaxControlToolkit.Slide("Pictures/slideshow/pic2.jpg","pic1","pic2"),
            new AjaxControlToolkit.Slide("Pictures/slideshow/pic3.jpg","pic1","pic2"),
            new AjaxControlToolkit.Slide("Pictures/slideshow/pic4.jpg","pic1","pic2"),
            new AjaxControlToolkit.Slide("Pictures/slideshow/pic5.jpg","pic1","pic2"),
            new AjaxControlToolkit.Slide("Pictures/slideshow/pic6.jpg","pic1","pic2"),
            new AjaxControlToolkit.Slide("Pictures/slideshow/pic7.jpg","pic1","pic2"),
            new AjaxControlToolkit.Slide("Pictures/slideshow/pic8.jpg","pic1","pic2"),
            new AjaxControlToolkit.Slide("Pictures/slideshow/pic9.jpg","pic1","pic2"),
            new AjaxControlToolkit.Slide("Pictures/slideshow/pic10.jpg","pic1","pic2"),
            new AjaxControlToolkit.Slide("Pictures/slideshow/pic11.jpg","pic1","pic2"),
            new AjaxControlToolkit.Slide("Pictures/slideshow/pic12.jpg","pic1","pic2"),
            new AjaxControlToolkit.Slide("Pictures/slideshow/pic13.jpg","pic1","pic2"),
            new AjaxControlToolkit.Slide("Pictures/slideshow/pic14.jpg","pic1","pic2"),
            new AjaxControlToolkit.Slide("Pictures/slideshow/pic15.jpg","pic1","pic2")};
        }
    </script>
    <table style="width:100%;">
        <tr>
            <td class="auto-style7" align="left">
                <asp:Image ID="Image1" runat="server" />
                <asp:SlideShowExtender ID="SlideShowExtender1" runat="server"
                    TargetControlID="Image1"
                SlideShowServiceMethod="GetSlides" 
                AutoPlay="true" 
                Loop="true" SlideShowAnimationType="SlideRight"></asp:SlideShowExtender>
            </td>
           
            <td class="auto-style8">
                <table style="width:100%;">
                    <tr>
                        <td colspan="4">
                            <asp:Label ID="Label12" runat="server" Text="Mobiles"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/Pictures/electronic/pics9.jpg" />
                        </td>
                        <td>
                            <asp:ImageButton ID="ImageButton2" runat="server" ImageUrl="~/Pictures/electronic/pics10.jpg" />
                        </td>
                        <td>
                            <asp:ImageButton ID="ImageButton3" runat="server" ImageUrl="~/Pictures/electronic/pics11.jpg" />
                        </td>
                        <td>
                            <asp:ImageButton ID="ImageButton4" runat="server" ImageUrl="~/Pictures/electronic/pics12.jpg" BorderColor="#FFCC66" />
                        </td>
                    </tr>
                    <tr>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                </table>
            </td>
            <td class="auto-style5" align="right">
                <asp:Accordion ID="MyAccordion" runat="server" SelectedIndex="0"
            HeaderCssClass="accordionHeader" HeaderSelectedCssClass="accordionHeaderSelected"
            ContentCssClass="accordionContent" FadeTransitions="true" FramesPerSecond="40" 
            TransitionDuration="250" AutoSize="None" RequireOpenedPane="false" SuppressHeaderPostbacks="true" align="left">
           <Panes>
            <asp:AccordionPane ID="AccordionPane1" runat="server">
                <Header>ELECTRONICS</Header>
                <Content>
                    <table>
                        <tr><td><asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Index.aspx">Mobiles</asp:HyperLink></td></tr>
                        <tr><td><asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/Computers.aspx">Computers</asp:HyperLink></td></tr>
                        <tr><td><asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/Laptops.aspx">Laptops</asp:HyperLink></td></tr>
                        <tr><td><asp:HyperLink ID="HyperLink4" runat="server" NavigateUrl="~/Tablets.aspx">Tablets</asp:HyperLink></td></tr>
                    </table>
                </Content>
            </asp:AccordionPane>
            <asp:AccordionPane ID="AccordionPane2" runat="server">
                <Header>MEN</Header>
                <Content>
                   <table>
                        <tr><td>Clothing</td></tr>
                        <tr><td>Footwear</td></tr>
                        <tr><td>Watchs</td></tr>
                        <tr><td>Sunglasses</td></tr>
                    </table>
                </Content>
            </asp:AccordionPane>
                <asp:AccordionPane ID="AccordionPane3" runat="server">
                <Header>WOMEN</Header>
                <Content>
                   <table>
                        <tr><td>Clothing</td></tr>
                        <tr><td>Footwear</td></tr>
                        <tr><td>Jewellery</td></tr>
                        <tr><td>Bags</td></tr>
                    </table>
                </Content>
                </asp:AccordionPane>
                <asp:AccordionPane ID="AccordionPane4" runat="server">
                <Header>BABY & KIDS</Header>
                <Content>
                   <table>
                       <tr><td>Kid's Clothing</td></tr>
                        <tr><td>Kid's Footwear</td></tr>
                        <tr><td>Baby Diapers</td></tr>
                        <tr><td>Toys & Games</td></tr>
                    </table>                 
                </Content>
                    </asp:AccordionPane>
                    <asp:AccordionPane ID="AccordionPane5" runat="server">
                <Header>BOOKS AND MEDIA</Header>
                <Content>
                   <table>
                        <tr><td>Books</td></tr>
                        <tr><td>Movies</td></tr>
                        <tr><td>TV Shows</td></tr>
                        <tr><td>Music</td></tr>                       
                    </table>
                </Content>
            </asp:AccordionPane>
                    <asp:AccordionPane ID="AccordionPane6" runat="server">
                <Header>HOME AND KITCHEN</Header>
                <Content>
                   <table>
                        <tr><td>Bed</td></tr>
                        <tr><td>Kitchen</td></tr>
                        <tr><td>Home Appliances</td></tr>
                        <tr><td>Bath Accessories</td></tr>   
                    </table>
                </Content>
            </asp:AccordionPane>
          
          
            </Panes>
        </asp:Accordion>
            </td>
        </tr>
        </table>
</asp:Content>