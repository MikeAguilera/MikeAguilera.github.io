@Code
    ViewData("Title") = "Caseload Detail"
End Code

@section Header
    <h1>@ViewData("Title")</h1>
End Section

<h2>Caseload Detail</h2>

@ModelType MvcApplication3.CaseModelCaseload
@Using Html.BeginForm()
    @Html.ValidationSummary()

    @<ul data-role="listview" data-inset="true">
        <li data-role="list-divider">Details</li>

        <li data-role="fieldcontain">
            @Html.LabelFor(Function(m) m.LastName)
            @Html.TextBoxFor(Function(m) m.LastName)
        </li>

        <li data-role="fieldcontain">
            @Html.LabelFor(Function(m) m.FirstName)
            @Html.TextBoxFor(Function(m) m.FirstName)            
        </li>

         <li data-role="fieldcontain">
            @Html.LabelFor(Function(m) m.DateOfBirth)
            @Html.TextBoxFor(Function(m) m.DateOfBirth)            
        </li>

         <li data-role="fieldcontain">
            @Html.LabelFor(Function(m) m.Placement)
            @Html.TextBoxFor(Function(m) m.Placement)            
        </li>
    </ul>
    
End Using

@Section Scripts
    @Scripts.Render("~/bundles/jqueryval")
End Section
