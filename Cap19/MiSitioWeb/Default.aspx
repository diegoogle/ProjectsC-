<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true"
  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
  <asp:Panel ID="Panel10" runat="server" BackColor="Transparent" Width="100%" HorizontalAlign="Center">
    <br /><br /><br /><br /><br /><br /> 
    <h2 style="text-align:center;">Mostrar datos</h2> 
    <br /><br /><br /><br /><br /><br />
  </asp:Panel>
  <asp:RoundedCornersExtender ID="RoundedCornersExtender10" runat="server" TargetControlID="Panel10"
    Radius="14" BorderColor="Gray">
  </asp:RoundedCornersExtender>
</asp:Content>
