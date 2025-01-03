Public Class Form2

    Private Sub dboard_txt_Click(sender As Object, e As EventArgs) Handles dboard_txt.Click
        ' Clear any existing controls in TableLayoutPanel1
        ClearColumn(2)

        ' Create an instance of the dashboard UserControl
        Dim dashboardControl As New dashboard()

        ' Add the UserControl to TableLayoutPanel1
        TableLayoutPanel1.Controls.Add(dashboardControl, 1, 0)
    End Sub

    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel1.Paint

    End Sub

    Private Sub ClearColumn(columnIndex As Integer)
        ' Create a list to store controls to remove (to avoid modifying the collection while iterating)
        Dim controlsToRemove As New List(Of Control)

        ' Iterate through all controls in the TableLayoutPanel
        For Each ctrl As Control In TableLayoutPanel1.Controls
            ' Check if the control is in the specified column
            If TableLayoutPanel1.GetColumn(ctrl) = columnIndex Then
                controlsToRemove.Add(ctrl)
            End If
        Next

        ' Remove the identified controls
        For Each ctrl As Control In controlsToRemove
            TableLayoutPanel1.Controls.Remove(ctrl)
        Next
    End Sub

    Private Sub stock_txt_Click(sender As Object, e As EventArgs) Handles stock_txt.Click
        ' Clear any existing controls in TableLayoutPanel1
        ClearColumn(2)

        ' Create an instance of the dashboard UserControl
        Dim dashboardControl As New stock()

        ' Add the UserControl to TableLayoutPanel1
        TableLayoutPanel1.Controls.Add(dashboardControl, 1, 0)
    End Sub

    Private Sub supplier_txt_Click(sender As Object, e As EventArgs) Handles supplier_txt.Click
        ' Clear any existing controls in TableLayoutPanel1
        ClearColumn(2)

        ' Create an instance of the dashboard UserControl
        Dim dashboardControl As New supplier()

        ' Add the UserControl to TableLayoutPanel1
        TableLayoutPanel1.Controls.Add(dashboardControl, 1, 0)
    End Sub

    Private Sub sndo_txt_Click(sender As Object, e As EventArgs) Handles sndo_txt.Click
        ' Clear any existing controls in TableLayoutPanel1
        ClearColumn(2)

        ' Create an instance of the dashboard UserControl
        Dim dashboardControl As New reports()

        ' Add the UserControl to TableLayoutPanel1
        TableLayoutPanel1.Controls.Add(dashboardControl, 1, 0)
    End Sub

    Private Sub purchases_txt_Click(sender As Object, e As EventArgs) Handles purchases_txt.Click
        ' Clear any existing controls in TableLayoutPanel1
        ClearColumn(2)

        ' Create an instance of the dashboard UserControl
        Dim dashboardControl As New purchases()

        ' Add the UserControl to TableLayoutPanel1
        TableLayoutPanel1.Controls.Add(dashboardControl, 1, 0)
    End Sub

    Private Sub profile_txt_Click(sender As Object, e As EventArgs) Handles profile_txt.Click
        ' Clear any existing controls in TableLayoutPanel1
        ClearColumn(2)

        ' Create an instance of the dashboard UserControl
        Dim dashboardControl As New profile()

        ' Add the UserControl to TableLayoutPanel1
        TableLayoutPanel1.Controls.Add(dashboardControl, 1, 0)
    End Sub

    Private Sub logout_txt_Click(sender As Object, e As EventArgs) Handles logout_txt.Click

    End Sub
End Class