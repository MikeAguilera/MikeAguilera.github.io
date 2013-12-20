@Code
    ViewData("Title") = "Child Search"
End Code

@section Header
    @Html.ActionLink("Back", "Index", "Home", Nothing, New With {.data_icon = "arrow-l", .data_rel = "back"})
    @Html.ActionLink("Home", "Index", "Home", Nothing, New With {.data_iconpos = "ui-btn-right"})
    <h1>@ViewData("Title")</h1>
End Section

<h2>Child Profile</h2>
<p>
    Enter the information below to search for a child. 
</p>

@ModelType MvcApplication3.CaseModel
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

        <li data-role="fieldcontain">
            <input type="submit" value="Search" />
        </li>
    </ul>
    
End Using

@Section Scripts
    @Scripts.Render("~/bundles/jqueryval")
End Section