@Code
    ViewData("Title") = "About"
End Code

@section Header
    @Html.ActionLink("Back", "Index", "Home", Nothing, New With {.data_icon = "arrow-l", .data_rel = "back"})
    @Html.ActionLink("Home", "Index", "Home", Nothing, New With {.data_iconpos = "ui-btn-right"})
    <h1>@ViewData("Title")</h1>
End Section

<h2>About</h2>

<ul data-role="listview" data-inset="true">
    <li data-role="list-divider">About</li>
    <li>This application was developed by Michael Aguilera.</li>
</ul>

<ul data-role="listview" data-inset="true">
    <li data-role="list-divider">Contact Info</li>
    <li>Email: agullm@dcfs.lacounty.gov</li>
    <li>Phone: (562) 354-6720</li>
</ul>

    
