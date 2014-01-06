@Code
    ViewData("Title") = "Client Information"
End Code

<ul data-role="listview" data-inset="true">
    <li>@Html.ActionLink("Mobile CSW Home", "Index", "Home")</li>
    <li>@Html.ActionLink("Client Information", "Info", "Home")</li>
</ul>