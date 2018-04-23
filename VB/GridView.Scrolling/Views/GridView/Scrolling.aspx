<%@ Page Language="vb" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
	<script type="text/javascript">
		var showVerticalScrollBar = <%=ViewData("ShowVerticalScrollBar").ToString().ToLower()%>
		var showHorizontalScrollBar = <%=ViewData("ShowHorizontalScrollBar").ToString().ToLower()%>

		$(document).ready(function() {
			$("#btShowHorizontalScrollBar").click(
				function() {
					showHorizontalScrollBar = !showHorizontalScrollBar;
					dxGridView.PerformCallback();
					$("#btShowHorizontalScrollBar").val((showHorizontalScrollBar ? "Hide" : "Show") + " horizontal scroll bar");
				}
			);
			$("#btShowVerticalScrollBar").click(
				function() {
					showVerticalScrollBar = !showVerticalScrollBar;
					dxGridView.PerformCallback();
					$("#btShowVerticalScrollBar").val((showVerticalScrollBar ? "Hide" : "Show") + " vertical scroll bar");
				}
			);
		}); 
		function OnBeginCallBack(s, e){
			e.customArgs["ShowVerticalScrollBar"] = showVerticalScrollBar;
			e.customArgs["ShowHorizontalScrollBar"] = showHorizontalScrollBar;
		}
	</script>
	<%
		Html.RenderPartial("ScrollingPartial", Model)
	%>

	<div>
		<input id="btShowHorizontalScrollBar" type="button" value = "Hide horizontal scroll bar"/>
		<input id="btShowVerticalScrollBar" type="button" value = "Hide vertical scroll bar"/>
	</div>
</asp:Content>