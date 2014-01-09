@Code
    ViewData("Title") = "Caseload"
End Code

@section Header
    <h1>@ViewData("Title")</h1>
End Section

<h2>Caseload</h2>

<p>Here are your cases.</p>

<ul data-role="listview" data-inset="true" data-filter="true">
   
    <li>@Html.ActionLink("Child 1", "Caseload_Detail", "Home")</li>
    <li>@Html.ActionLink("Child 2", "Caseload_Detail", "Home")</li>
    <li>@Html.ActionLink("Child 3", "Caseload_Detail", "Home")</li>
    <li>@Html.ActionLink("Child 4", "Caseload_Detail", "Home")</li>
</ul>



