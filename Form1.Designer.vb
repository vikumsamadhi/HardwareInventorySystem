<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        btnOut = New Button()
        btnLoadData = New Button()
        txtItemName = New TextBox()
        txtQuantity = New TextBox()
        txtBarcode = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        btnIn = New Button()
        DataGridView1 = New DataGridView()
        ItemNameColumn = New DataGridViewTextBoxColumn()
        QuantityColumn = New DataGridViewTextBoxColumn()
        BarcodeColumn = New DataGridViewTextBoxColumn()
        btnDelete = New Button()
        btnViewAll = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnOut
        ' 
        btnOut.Location = New Point(405, 29)
        btnOut.Name = "btnOut"
        btnOut.Size = New Size(75, 23)
        btnOut.TabIndex = 1
        btnOut.Text = "Issue"
        btnOut.UseVisualStyleBackColor = True
        ' 
        ' btnLoadData
        ' 
        btnLoadData.Location = New Point(187, 420)
        btnLoadData.Name = "btnLoadData"
        btnLoadData.Size = New Size(75, 23)
        btnLoadData.TabIndex = 5
        btnLoadData.Text = "View"
        btnLoadData.UseVisualStyleBackColor = True
        ' 
        ' txtItemName
        ' 
        txtItemName.Location = New Point(138, 69)
        txtItemName.Name = "txtItemName"
        txtItemName.Size = New Size(124, 23)
        txtItemName.TabIndex = 6
        ' 
        ' txtQuantity
        ' 
        txtQuantity.Location = New Point(138, 106)
        txtQuantity.Name = "txtQuantity"
        txtQuantity.Size = New Size(42, 23)
        txtQuantity.TabIndex = 7
        ' 
        ' txtBarcode
        ' 
        txtBarcode.Location = New Point(138, 29)
        txtBarcode.Name = "txtBarcode"
        txtBarcode.Size = New Size(127, 23)
        txtBarcode.TabIndex = 8
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(22, 29)
        Label1.Name = "Label1"
        Label1.Size = New Size(50, 15)
        Label1.TabIndex = 9
        Label1.Text = "Barcode"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(22, 69)
        Label2.Name = "Label2"
        Label2.Size = New Size(73, 15)
        Label2.TabIndex = 10
        Label2.Text = "Ithem Name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(22, 109)
        Label3.Name = "Label3"
        Label3.Size = New Size(53, 15)
        Label3.TabIndex = 11
        Label3.Text = "Quantity"
        ' 
        ' btnIn
        ' 
        btnIn.Location = New Point(301, 29)
        btnIn.Name = "btnIn"
        btnIn.Size = New Size(75, 23)
        btnIn.TabIndex = 12
        btnIn.Text = "Stock IN"
        btnIn.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {ItemNameColumn, QuantityColumn, BarcodeColumn})
        DataGridView1.Location = New Point(12, 182)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(468, 49)
        DataGridView1.TabIndex = 13
        ' 
        ' ItemNameColumn
        ' 
        ItemNameColumn.HeaderText = "Item Name"
        ItemNameColumn.Name = "ItemNameColumn"
        ' 
        ' QuantityColumn
        ' 
        QuantityColumn.HeaderText = "Quantity"
        QuantityColumn.Name = "QuantityColumn"
        ' 
        ' BarcodeColumn
        ' 
        BarcodeColumn.HeaderText = "Barcode"
        BarcodeColumn.Name = "BarcodeColumn"
        ' 
        ' btnDelete
        ' 
        btnDelete.Location = New Point(419, 420)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(75, 23)
        btnDelete.TabIndex = 14
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' btnViewAll
        ' 
        btnViewAll.Location = New Point(301, 420)
        btnViewAll.Name = "btnViewAll"
        btnViewAll.Size = New Size(75, 23)
        btnViewAll.TabIndex = 15
        btnViewAll.Text = "View All "
        btnViewAll.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(506, 450)
        Controls.Add(btnViewAll)
        Controls.Add(btnDelete)
        Controls.Add(DataGridView1)
        Controls.Add(btnIn)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtBarcode)
        Controls.Add(txtQuantity)
        Controls.Add(txtItemName)
        Controls.Add(btnLoadData)
        Controls.Add(btnOut)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Form1"
        Text = "Sewmini Store App"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents AddItem_Click As Button
    Friend WithEvents btnOut As Button
    Friend WithEvents btnLoadData As Button
    Friend WithEvents txtItemName As TextBox
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents txtBarcode As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnIn As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ItemNameColumn As DataGridViewTextBoxColumn
    Friend WithEvents QuantityColumn As DataGridViewTextBoxColumn
    Friend WithEvents BarcodeColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrintDocument As Printing.PrintDocument
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnViewAll As Button


End Class
