Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.Mvc
Imports GridView.Scrolling.Models

Namespace GridView.Scrolling.Controllers
	<HandleError> _
	Public Class GridViewController
		Inherits Controller
		Public Function Index() As ActionResult
			Return Scrolling()
		End Function
		Public Function Scrolling() As ActionResult
			ViewData("ShowVerticalScrollBar") = True
			ViewData("ShowHorizontalScrollBar") = True
			Return View("Scrolling", NorthwindDataProvider.GetInvoices())
		End Function
		Public Function ScrollingPartial() As ActionResult
			GetRequestParemetrs()
			Return PartialView("ScrollingPartial", NorthwindDataProvider.GetInvoices())
		End Function
		Private Sub GetRequestParemetrs()
			ViewData("ShowVerticalScrollBar") = If(String.IsNullOrEmpty(Request.Params("ShowVerticalScrollBar")), True, Boolean.Parse(Request.Params("ShowVerticalScrollBar")))
			ViewData("ShowHorizontalScrollBar") = If(String.IsNullOrEmpty(Request.Params("ShowHorizontalScrollBar")), True, Boolean.Parse(Request.Params("ShowHorizontalScrollBar")))
		End Sub
	End Class
End Namespace
