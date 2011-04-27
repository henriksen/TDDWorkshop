<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<SpecFlowDemo.Core.Models.Customer>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	ViewPage1
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>ViewPage1</h2>

    <fieldset>
        <legend>Fields</legend>
        
        <div class="display-label">Id</div>
        <div class="display-field"><%: Model.Id %></div>
        
        <div class="display-label">Name</div>
        <div class="display-field"><%: Model.Name %></div>
        
        <div class="display-label">Email</div>
        <div class="display-field"><%: Model.Email %></div>
        
        <div class="display-label">Phone</div>
        <div class="display-field"><%: Model.Phone %></div>
        
    </fieldset>
    <p>
        <%: Html.ActionLink("Edit", "Edit", new { id=Model.Id }) %> |
        <%: Html.ActionLink("Back to List", "Index") %>
    </p>

</asp:Content>

