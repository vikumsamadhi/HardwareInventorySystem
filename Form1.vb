Imports Excel = Microsoft.Office.Interop.Excel

Public Class Form1
    ' Excel variables
    Dim xlApp As Excel.Application
    Dim xlWorkbook As Excel.Workbook
    Dim xlWorksheet As Excel.Worksheet

    ' Barcode Font
    Dim barcodeFont As New Font("Free 3 of 9", 48) ' Ensure you have this barcode font installed

    ' Load data from Excel
    Private Sub LoadData_Click(sender As Object, e As EventArgs) Handles btnLoadData.Click
        Dim barcodeFilter As String = txtBarcode.Text ' Get the barcode from the input box

        ' Open Excel file
        xlApp = New Excel.Application
        xlWorkbook = xlApp.Workbooks.Open("D:\New folder (4)\HardwareInventorySystem\Data_Sheet - Copy.xlsx", [ReadOnly]:=False, [Editable]:=True)
        xlWorksheet = xlWorkbook.Sheets(1)

        ' Clear the DataGridView before loading new data
        DataGridView1.Rows.Clear()

        Dim row As Integer = 2 ' Start from row 2 (assuming row 1 has headers)

        ' Loop through the Excel sheet rows
        While xlWorksheet.Cells(row, 1).Value IsNot Nothing
            Dim itemName As String = xlWorksheet.Cells(row, 1).Value
            Dim quantity As Integer = xlWorksheet.Cells(row, 2).Value
            Dim barcode As String = xlWorksheet.Cells(row, 3).Value

            ' Load only rows with matching barcode, or all rows if no filter is applied
            If String.IsNullOrEmpty(barcodeFilter) OrElse barcode = barcodeFilter Then
                DataGridView1.Rows.Add(itemName, quantity, barcode)
            End If

            row += 1
        End While

        ' Close Excel resources
        xlWorkbook.Close()
        xlApp.Quit()

        ' Display a message after loading the data
        MessageBox.Show("Data loaded successfully!", "Load Data", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Sub btnViewAll_Click(sender As Object, e As EventArgs) Handles btnViewAll.Click
        ' Open Excel file
        xlApp = New Excel.Application
        xlWorkbook = xlApp.Workbooks.Open("D:\New folder (4)\HardwareInventorySystem\Data_Sheet - Copy.xlsx", [ReadOnly]:=False, [Editable]:=True)
        xlWorksheet = xlWorkbook.Sheets(1)

        ' Create a new DataGridView to hold the data temporarily
        Dim tempDataGridView As New DataGridView
        tempDataGridView.Columns.Add("ItemName", "Item Name")
        tempDataGridView.Columns.Add("Quantity", "Quantity")
        tempDataGridView.Columns.Add("Barcode", "Barcode")

        ' Loop through the Excel sheet rows and load all data
        Dim row As Integer = 2 ' Start from row 2 (assuming row 1 has headers)
        While xlWorksheet.Cells(row, 1).Value IsNot Nothing
            Dim itemName As String = xlWorksheet.Cells(row, 1).Value
            Dim quantity As Integer = xlWorksheet.Cells(row, 2).Value
            Dim barcode As String = xlWorksheet.Cells(row, 3).Value

            ' Add all rows to the temp DataGridView
            tempDataGridView.Rows.Add(itemName, quantity, barcode)

            row += 1
        End While

        ' Close Excel resources
        xlWorkbook.Close()
        xlApp.Quit()

        ' Create an instance of the new form (FormViewAll)
        Dim formViewAll As New FormViewAll

        ' Pass the temporary DataGridView to the new form
        formViewAll.DataSource = tempDataGridView

        ' Show the new form as a dialog or non-modal window
        formViewAll.ShowDialog()

        ' Optionally, clear the temp DataGridView after use
        tempDataGridView.Rows.Clear()
    End Sub


    ' Add or update item in DataGridView and Excel
    Private Sub btnInOut_Click(sender As Object, e As EventArgs) Handles btnIn.Click, btnOut.Click
        Dim itemName As String = txtItemName.Text
        Dim quantity As Integer
        Dim barcode As String = txtBarcode.Text

        ' Validate quantity input
        If Not Integer.TryParse(txtQuantity.Text, quantity) Then
            MessageBox.Show("Please enter a valid quantity.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Open Excel to update data
        xlApp = New Excel.Application
        xlWorkbook = xlApp.Workbooks.Open("D:\New folder (4)\HardwareInventorySystem\Data_Sheet - Copy.xlsx", [ReadOnly]:=False, [Editable]:=True)
        xlWorksheet = xlWorkbook.Sheets(1)

        Dim row As Integer = 2
        Dim found As Boolean = False

        ' Search for the barcode in the Excel file
        While xlWorksheet.Cells(row, 1).Value IsNot Nothing
            If xlWorksheet.Cells(row, 3).Value.ToString() = barcode Then
                found = True
                ' If found, update the quantity
                Dim currentQty As Integer = Integer.Parse(xlWorksheet.Cells(row, 2).Value.ToString())
                If sender Is btnIn Then
                    xlWorksheet.Cells(row, 2).Value = currentQty + quantity
                ElseIf sender Is btnOut Then
                    xlWorksheet.Cells(row, 2).Value = Math.Max(currentQty - quantity, 0) ' Avoid negative quantities
                End If
                Exit While
            End If
            row += 1
        End While

        ' If the barcode was not found, add a new row for the item
        If Not found Then
            xlWorksheet.Cells(row, 1).Value = itemName
            xlWorksheet.Cells(row, 2).Value = quantity
            xlWorksheet.Cells(row, 3).Value = barcode
        End If

        ' Save and close the workbook
        xlWorkbook.Save()
        xlWorkbook.Saved = True
        xlWorkbook.Close()
        xlApp.Quit()

        ' Update the DataGridView to reflect changes
        LoadData_Click(Nothing, Nothing)
        ClearForm()
    End Sub

    ' Delete item from DataGridView and Excel
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim barcode As String = txtBarcode.Text

        ' Check if barcode is provided
        If String.IsNullOrEmpty(barcode) Then
            MessageBox.Show("Please enter a barcode to delete.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Open Excel to delete the item
        xlApp = New Excel.Application
        xlWorkbook = xlApp.Workbooks.Open("D:\New folder (4)\HardwareInventorySystem\Data_Sheet - Copy.xlsx", [ReadOnly]:=False, [Editable]:=True)
        xlWorksheet = xlWorkbook.Sheets(1)

        Dim row As Integer = 2
        Dim found As Boolean = False

        ' Search for the barcode in the Excel file
        While xlWorksheet.Cells(row, 1).Value IsNot Nothing
            If xlWorksheet.Cells(row, 3).Value.ToString() = barcode Then
                found = True
                ' If found, delete the row by clearing the cells
                xlWorksheet.Rows(row).Delete()
                Exit While
            End If
            row += 1
        End While

        ' Save and close the workbook
        If found Then
            xlWorkbook.Save()
            MessageBox.Show("Item deleted successfully!", "Delete Item", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Barcode not found!", "Delete Item", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

        xlWorkbook.Close()
        xlApp.Quit()

        ' Update the DataGridView to reflect changes
        LoadData_Click(Nothing, Nothing)
    End Sub

    ' Save DataGridView data to Excel (manual save)


    ' Clear the form (TextBoxes and DataGridView)
    Private Sub ClearForm()
        txtItemName.Clear()
        txtQuantity.Clear()
        txtBarcode.Clear()
        DataGridView1.Rows.Clear()
    End Sub
End Class
