@Code
    ViewData("Title") = "Mobile CSW"
End Code

<h2>@ViewData("Message")</h2>
<p>
    Click <a href="#" title="Help">here</a> for help.
</p>

<ul data-role="listview" data-inset="true">
        <li>@Html.ActionLink("Placement", "Placement", "Home")</li>
        <li>@Html.ActionLink("Stop Placement", "Stop_Placement", "Home")</li>
        <li>@Html.ActionLink("Child Search", "Child_Search", "Home")</li>
        <li>@Html.ActionLink("Cases", "CS_Caseload", "Home")</li>
        <li>@Html.ActionLink("Referrals", "ER_Caseload", "Home")</li>
</ul>
