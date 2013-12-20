@Code
    ViewData("Title") = "Success"
End Code

@section Header
    @Html.ActionLink("Back", "Index", "Home", Nothing, New With {.data_icon = "arrow-l", .data_rel = "back"})
    @Html.ActionLink("Home", "Index", "Home", Nothing, New With {.data_iconpos = "ui-btn-right"})
    <h1>@ViewData("Title")</h1>
End Section

<h2>Success</h2>

<ul data-role="listview" data-inset="true">
    <li data-role="list-divider">Placement Confirmation</li>
    <li>You have sucessfully confirmed the placement!</li>
</ul>