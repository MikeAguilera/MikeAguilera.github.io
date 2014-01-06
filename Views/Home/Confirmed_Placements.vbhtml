@Code
    ViewData("Title") = "Confirmed"
End Code

@section Header
    <h1>@ViewData("Title")</h1>
End Section

<h2>Confirmed Placements</h2>
<p>Select a placement to see the details.</p>

<ul data-role="listview" data-inset="true" data-filter="true">
    <li>@Html.ActionLink("Child 1", "Confirmed_Detail", "Home")</li>
    <li>@Html.ActionLink("Child 2", "Confirmed_Detail", "Home")</li>
    <li>@Html.ActionLink("Child 3", "Confirmed_Detail", "Home")</li>
    <li>@Html.ActionLink("Child 4", "Confirmed_Detail", "Home")</li>
</ul>

