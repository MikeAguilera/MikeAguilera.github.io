Public Class HomeController
    Inherits System.Web.Mvc.Controller

    Function Index() As ActionResult
        ViewData("Message") = "Welcome to Mobile CSW! Select a link below."

        Return View()
    End Function

    Function Placement() As ActionResult
        ViewData("Message") = "Your Case page."

        Return View()
    End Function

    Function Pending_Placements() As ActionResult
        ViewData("Message") = "Your Pending Placement page."

        Return View()
    End Function

    Function Pending_Detail() As ActionResult
        ViewData("Message") = "Your Pending Placement page."

        Return View()
    End Function

    Function Confirmed_Detail() As ActionResult
        ViewData("Message") = "Your Pending Placement page."

        Return View()
    End Function

    Function ER_Caseload() As ActionResult
        ViewData("Message") = "Your ER Caseload page."

        Return View()
    End Function

    Function Referrals() As ActionResult
        ViewData("Message") = "Your Referral page."

        Return View()
    End Function

    Function Case1() As ActionResult
        ViewData("Message") = "Your client information page."

        Return View()
    End Function

    Function Child_Search() As ActionResult
        ViewData("Message") = "Your client information page."

        Return View()
    End Function

    Function Confirmed_Placements() As ActionResult
        ViewData("Message") = "Confirmed Placments"

        Return View()
    End Function

    Function CS_Caseload() As ActionResult
        ViewData("Message") = "Confirmed Placments"

        Return View()
    End Function

    Function CS_Detail() As ActionResult
        ViewData("Message") = "Confirmed Placments"

        Return View()
    End Function

    Function ER_Detail() As ActionResult
        ViewData("Message") = "Confirmed Placments"

        Return View()
    End Function

    Function Stop_Placement() As ActionResult
        ViewData("Message") = "Confirmed Placments"

        Return View()
    End Function

    Function Caseload() As ActionResult
        ViewData("Message") = "Confirmed Placments"

        Return View()
    End Function

    Function About() As ActionResult
        ViewData("Message") = "Confirmed Placments"

        Return View()
    End Function

    Function Success() As ActionResult
        ViewData("Message") = "Confirmed Placments"

        Return View()
    End Function

    Function Caseload_Detail() As ActionResult
        ViewData("Message") = "Confirmed Placments"

        Return View()
    End Function

End Class
