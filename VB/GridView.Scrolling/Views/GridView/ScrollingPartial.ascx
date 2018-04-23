<%@ Control Language="vb" Inherits="System.Web.Mvc.ViewUserControl<dynamic>" %>

<%
	Html.DevExpress().GridView(Function(settings) AnonymousMethod1(settings)).Bind(Model).Render()
%>

private bool AnonymousMethod1(object settings)
{
	settings.Name = "dxGridView";
	settings.CallbackRouteValues = New { Controller = "GridView", Action = "ScrollingPartial" };
	settings.Columns.Add("ShipName");
	settings.Columns.Add("ShipCity");
	settings.Columns.Add("OrderDate", MVCxGridViewColumnType.DateEdit);
	settings.Columns.Add("RequiredDate", MVCxGridViewColumnType.DateEdit);
	settings.Columns.Add("ShipPostalCode");
	settings.Settings.ShowVerticalScrollBar = (bool)ViewData["ShowVerticalScrollBar"];
	settings.Settings.ShowHorizontalScrollBar = (bool)ViewData["ShowHorizontalScrollBar"];
	settings.Settings.VerticalScrollableHeight = 200;
	settings.SettingsPager.PageSize = 30;
	settings.ClientSideEvents.BeginCallback = "OnBeginCallBack";
	Return True;
}