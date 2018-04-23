﻿<h2>Index</h2>
<script type="text/javascript">
    function OnClick(s, e) {
        $.ajax({
            url: '@Url.Action("GridViewPartial", "Home")',
            type: "GET",
            data: { enableScroll: btnEnable.GetChecked() },
            success: function (data) {
                $('#dvContainer').html(data);
            },
            error: function (xhr, textStatus, errorThrown) {
                alert('Request Status: ' + xhr.status + '; Status Text: ' + textStatus + '; Error: ' + errorThrown);
            }
        });
    }
</script>
<div id="dvContainer">
    @Html.Action("GridViewPartial")
</div>
@Html.DevExpress().Button(Sub(settings)
                              settings.Name = "btnEnable"
                              settings.Text = "Enable"
                              settings.GroupName = "group"
                              settings.ClientSideEvents.Click = "OnClick"
                          End Sub).GetHtml()
@Html.DevExpress().Button(Sub(settings)
                              settings.Name = "btnDisable"
                              settings.Text = "Disable"
                              settings.GroupName = "group"
                              settings.ClientSideEvents.Click = "OnClick"
                          End Sub).GetHtml()



