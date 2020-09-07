Public Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label1.Text = 2 * 5 - 6 / (1 + 1) + 5 * (4 - 1)
    End Sub

End Class