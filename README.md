# Hardware Inventory System

A Windows Forms desktop application written in Visual Basic .NET for managing hardware inventory in an Excel workbook.

## Features

- Load inventory rows from the first worksheet and display item names, quantities, and barcodes.
- Filter inventory by barcode or view all rows.
- Add new items, increase or decrease quantities, and delete items by barcode.
- Save inventory changes back to the workbook.

## Requirements

- Windows and the .NET 8 SDK.
- Microsoft Excel installed. The application uses Excel COM Interop to read and write the workbook.
- The “Free 3 of 9” barcode font if you use the barcode display provided by the interface.

## Workbook format

The first worksheet must use columns A–C in this order: item name, quantity, barcode. Put column headings in row 1 and inventory items from row 2 onward.

## Run

1. Open `HardwareInventorySystem.sln` in Visual Studio.
2. In `Form1.vb`, update the machine-specific path to `Data_Sheet - Copy.xlsx` so it points to the workbook on your computer.
3. Build and run the Windows Forms project.

The workbook path is currently hard-coded in the application, so the path must be changed before it will work on another computer.