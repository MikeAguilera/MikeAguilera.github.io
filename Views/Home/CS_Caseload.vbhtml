@Code
    ViewData("Title") = "CS Caseload"
End Code

@section Header
    <h1>@ViewData("Title")</h1>
End Section

<h2>Cases</h2>

<p>Select a case.</p>

<ul data-role="listview" data-inset="true" data-filter="true">
   
    <li>@Html.ActionLink("Child 1", "CS_Detail", "Home")</li>
    <li>@Html.ActionLink("Child 2", "CS_Detail", "Home")</li>
    <li>@Html.ActionLink("Child 3", "CS_Detail", "Home")</li>
    <li>@Html.ActionLink("Child 4", "CS_Detail", "Home")</li>
</ul>

