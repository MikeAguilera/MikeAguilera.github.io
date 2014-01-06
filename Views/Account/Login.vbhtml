@ModelType MvcApplication3.LoginModel

@Code
    ViewData("Title") = "Mobile CSW"
End Code

<p>
    Please enter your user name and password. Your user name is E followed by your Employee Number. 
</p>

@Using Html.BeginForm()
    @Html.ValidationSummary()

    @<ul data-role="listview" data-inset="true">
        <li data-role="list-divider">Details</li>

        <li data-role="fieldcontain">
            @Html.LabelFor(Function(m) m.UserName)
            @Html.TextBoxFor(Function(m) m.UserName)
        </li>

        <li data-role="fieldcontain">
            @Html.LabelFor(Function(m) m.Password)
            @Html.PasswordFor(Function(m) m.Password)            
        </li>

        <li data-role="fieldcontain">
            <input type="submit" value="Log in" />
        </li>
    </ul>
End Using

@Section Scripts
    @Scripts.Render("~/bundles/jqueryval")
End Section