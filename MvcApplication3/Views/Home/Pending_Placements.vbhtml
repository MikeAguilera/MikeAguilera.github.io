@Code
    ViewData("Title") = "Pending"
End Code

@section Header
    @Html.ActionLink("Back", "Index", "Home", Nothing, New With {.data_icon = "arrow-l", .data_rel = "back"})
    @Html.ActionLink("Home", "Index", "Home", Nothing, New With {.data_iconpos = "ui-btn-right"})
    <h1>@ViewData("Title")</h1>
End Section

<h1>Pending Placements</h1>
<p>Select a pending placement to confirm that you placed the child(ren).</p>

<ul data-role="listview" data-inset="true" data-filter="true">
    <li>@Html.ActionLink("Child 1", "Pending_Detail", "Home")</li>
    <li>@Html.ActionLink("Child 2", "Pending_Detail", "Home")</li>
    <li>@Html.ActionLink("Child 3", "Pending_Detail", "Home")</li>
    <li>@Html.ActionLink("Child 4", "Pending_Detail", "Home")</li>
</ul>
