
Public Class FormViewAll
        ' Public property to pass the DataGridView from the main form
        Public Property DataSource As DataGridView

        ' Load event to display the data when the form opens
        Private Sub FormViewAll_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            ' Set up DataGridView columns
            DataGridViewAll.Columns.Add("ItemName", "Item Name")
            DataGridViewAll.Columns.Add("Quantity", "Quantity")
            DataGridViewAll.Columns.Add("Barcode", "Barcode")

            ' Copy rows from the main form's DataGridView to this form's DataGridView
            For Each row As DataGridViewRow In DataSource.Rows
                ' Only add non-empty rows
                If Not row.IsNewRow Then
                    DataGridViewAll.Rows.Add(row.Cells(0).Value, row.Cells(1).Value, row.Cells(2).Value)
                End If
            Next
        End Sub
    End Class

