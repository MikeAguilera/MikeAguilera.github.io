@Code
    ViewData("Title") = "ER Caseload"
End Code

@section Header
    <h1>@ViewData("Title")</h1>
End Section

<h2>Referrals</h2>

<p>Select a referral.</p>

<ul data-role="listview" data-inset="true" data-filter="true">
   
    <li>@Html.ActionLink("Child 1", "ER_Detail", "Home")</li>
    <li>@Html.ActionLink("Child 2", "ER_Detail", "Home")</li>
    <li>@Html.ActionLink("Child 3", "ER_Detail", "Home")</li>
    <li>@Html.ActionLink("Child 4", "ER_Detail", "Home")</li>
</ul>

