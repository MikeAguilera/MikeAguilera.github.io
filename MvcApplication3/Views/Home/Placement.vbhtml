@Code
    ViewData("Title") = "Placement"
End Code

@section Header
    @Html.ActionLink("Back", "Index", "Home", Nothing, New With {.data_icon = "arrow-l", .data_rel = "back"})
    @Html.ActionLink("Home", "Index", "Home", Nothing, New With {.data_iconpos = "ui-btn-right"})
    <h1>@ViewData("Title")</h1>
End Section


<h2>Placement</h2>
<p>
     Click to confirm pending placements. 
</p>

<ul data-role="listview" data-inset="true">
    
    <li>@Html.ActionLink("Pending Placements", "Pending_Placements", "Home")</li>
    <li>@Html.ActionLink("Confirmed Placements", "Confirmed_Placements", "Home")</li>
</ul>