Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.Mvc

Namespace EnableScrollingDynamically.Controllers
	Public Class HomeController
		Inherits Controller

		' GET: Home
		Public Function Index() As ActionResult
			Return View()
		End Function
		Public Function GridViewPartial(ByVal enableScroll? As Boolean) As ActionResult
			If enableScroll IsNot Nothing Then
				Session("enableScroll") = enableScroll
			End If
			Return PartialView("GridViewPartial", SimpleData.GetData())
		End Function
	End Class
	Public Class SimpleData
		Public Shared Function GetData() As Object
			Return Enumerable.Range(0, 25).Select(Function(i) New With {Key .ID = i, Key .A = i * 10, Key .B = i Mod 2, Key .C = "Test Text" & i.ToString(), Key .D = "Test Text1" & i.ToString()})
		End Function
	End Class
End Namespace