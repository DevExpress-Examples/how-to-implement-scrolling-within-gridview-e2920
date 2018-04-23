@Html.DevExpress().GridView(Sub(settings)
                                settings.Name = "GridView"
                                settings.Width = Unit.Pixel(600)
                                settings.CallbackRouteValues = New With {Key .Action = "GridViewPartial", Key .Controller = "Home"}
                                settings.KeyFieldName = "ID"
                                settings.Columns.Add("ID").Width = 150
                                settings.Columns.Add("A").Width = 150
                                settings.Columns.Add("B").Width = 150
                                settings.Columns.Add("C").Width = 150
                                settings.Columns.Add("D").Width = 150
                                settings.SettingsPager.Mode = GridViewPagerMode.ShowAllRecords
                                If (Session("enableScroll") IsNot Nothing) Then
                                    If (DirectCast(Session("enableScroll"), Boolean)) Then
                                        settings.Settings.VerticalScrollBarMode = ScrollBarMode.Visible
                                        settings.Settings.VerticalScrollableHeight = 300
                                        settings.Settings.HorizontalScrollBarMode = ScrollBarMode.Visible
                                    Else
                                        settings.Settings.VerticalScrollBarMode = ScrollBarMode.Hidden
                                        settings.Settings.HorizontalScrollBarMode = ScrollBarMode.Hidden
                                    End If

                                End If
                            End Sub).Bind(Model).GetHtml()
