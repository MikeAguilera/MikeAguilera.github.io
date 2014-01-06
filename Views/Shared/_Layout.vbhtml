<!DOCTYPE html>
<html lang="en">
    <head>
        <meta charset="utf-8" />
        <title>@ViewData("Title")</title>
        <meta name="viewport" content="width=device-width" />
        <link href="~/favicon.ico" rel="shortcut icon" type="image/x-icon" />
        @Styles.Render("~/Content/mobileCss", "~/Content/css")
        @Scripts.Render("~/bundles/modernizr")
    </head>
    <body>
        <div data-role="page" data-theme="b">
            <div data-role="header">
                @If IsSectionDefined("Header") Then
                    @RenderSection("Header")
                    @Html.ActionLink("Back", "Index", "Home", Nothing, New With {.data_icon = "arrow-l", .data_rel = "back"})
                    @Html.ActionLink("Home", "Index", "Home", Nothing, New With {.data_iconpos = "ui-btn-right"})
                Else
                    @<h1>@ViewData("Title")</h1>
                    @Html.Partial("_LoginPartial")
                End If
            </div>
            <div data-role="content">
                @RenderBody()
            </div>
             <div data-role ="footer" data-position ="fixed" data-iconpos="bottom">
            <div data-role ="navbar">
                 <ul>
                 <li>@Html.ActionLink("Placement", "Placement", "Home", Nothing, New With {.data_icon = "ui-btn ui-icon-home"})</li>
                 <li>@Html.ActionLink("Stop Plcmnt", "Stop_Placement", "Home", Nothing, New With {.data_icon = "ui-btn ui-icon-alert"})</li>
                <li>@Html.ActionLink("Child Search", "Child_Search", "Home", Nothing, New With {.data_icon = "ui-btn ui-icon-search"})</li>
                <li>@Html.ActionLink("About", "About", "Home", Nothing, New With {.data_icon = "ui-btn ui-icon-info"})</li>
            </ul>
                </div>
        </div>
        </div>
        
       

        @Scripts.Render("~/bundles/jquery", "~/bundles/jquerymobile")
        @RenderSection("scripts", required:=False)
    </body>
</html>
