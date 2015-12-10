
Partial Class Login
    Inherits System.Web.UI.Page


    Protected Sub Page_Load(sender As Object, e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btn1_Click(sender As Object, e As System.EventArgs) Handles btn1.Click
        Dim name = Me.name.Value
        Dim pw = Me.pw.Value
    End Sub
End Class
