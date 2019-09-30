<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Borrar.aspx.cs" Inherits="Borrar" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
  <asp:Panel ID="Panel12" runat="server" BackColor="Transparent" Width="100%" HorizontalAlign="Center">
    <br /><br /><br /><br /><br /><br /> 
    <h2 style="text-align:center; vertical-align">Borrar datos</h2> 
    <br /><br /><br /><br /><br /><br /> 
  </asp:Panel>
  <asp:RoundedCornersExtender ID="RoundedCornersExtender12" runat="server" TargetControlID="Panel12"
    Radius="14" BorderColor="Gray">
  </asp:RoundedCornersExtender>
</asp:Content>
