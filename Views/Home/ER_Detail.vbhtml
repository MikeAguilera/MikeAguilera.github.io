@Code
    ViewData("Title") = "Client"
End Code

<h2>Client Information</h2>

@section Header
    <h1>@ViewData("Title")</h1>
End Section

<p>
    Here is your client's information. 
</p>

@ModelType MvcApplication3.ErCaseModel
@Using Html.BeginForm()
    @Html.ValidationSummary()

    @<ul data-role="listview" data-inset="true">
        <li data-role="list-divider">Details</li>

        <li data-role="fieldcontain">
            @Html.LabelFor(Function(m) m.LastName)
        </li>

        <li data-role="fieldcontain">
            @Html.LabelFor(Function(m) m.FirstName)           
        </li>

         <li data-role="fieldcontain">
            @Html.LabelFor(Function(m) m.DateOfBirth)           
        </li>

         <li data-role="fieldcontain">
            @Html.LabelFor(Function(m) m.Placement)           
        </li>

        <li data-role="fieldcontain">
            @Html.LabelFor(Function(m) m.Referral)           
        </li>

    </ul>
    
End Using

@Section Scripts
    @Scripts.Render("~/bundles/jqueryval")
End Section

