@Code
    ViewData("Title") = "Placement"
End Code

@section Header
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