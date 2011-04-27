<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<SpecFlowDemo.Core.Models.Customer>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Create
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Create</h2>

    <% using (Html.BeginForm()) {%>
        <%: Html.ValidationSummary(true) %>

        <fieldset>
            <legend>Fields</legend>
            <div>
                <%: Html.LabelFor(m => m.Name) %>:
                <%: Html.TextBoxFor(m => m.Name) %>
            </div>
            <div>
                <%: Html.LabelFor(m => m.Email) %>:
                <%: Html.TextBoxFor(m => m.Email) %>
            </div>
            <div>
                <%: Html.LabelFor(m => m.Phone) %>:
                <%: Html.TextBoxFor(m => m.Phone) %>
            </div>
            <p>
                <input type="submit" value="Create" />
            </p>
        </fieldset>

    <% } %>

    <div>
        <%: Html.ActionLink("Back to List", "Index") %>
    </div>

</asp:Content>

