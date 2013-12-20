@Code
    ViewData("Title") = "Caseload"
End Code

@section Header
    @Html.ActionLink("Back", "Index", "Home", Nothing, New With {.data_icon = "arrow-l", .data_rel = "back"})
    @Html.ActionLink("Home", "Index", "Home", Nothing, New With {.data_iconpos = "ui-btn-right"})
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



