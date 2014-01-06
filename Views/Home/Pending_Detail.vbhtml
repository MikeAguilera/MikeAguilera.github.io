@Code
    ViewData("Title") = "Detail"
End Code

@section Header
    <h1>@ViewData("Title")</h1>
End Section

<h2>Pending Placement</h2>

@ModelType MvcApplication3.PendingPlacementModel
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
           @Html.ActionLink("Confirm Placement", "Success", "Home", Nothing, New With {.data_rel = "success", .data_role = "button"})
        </li>
    </ul>
    
End Using

@Section Scripts
    @Scripts.Render("~/bundles/jqueryval")
End Section
