public void exportDataGridToExcel(DataGridView dGrid) {
            try {
                Excel.Application xlApp;
                Excel.Workbook xlWorkBook;
                Excel.Worksheet xlWorkSheet;

                xlApp = new Excel.Application();
                xlWorkBook = xlApp.Workbooks.Add();
                xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
                int i = 0;
                int j = 0;

                for (i = 0; i < dGrid.RowCount - 1; i++) {
                    for (j = 0; j < dGrid.ColumnCount - 1; j++) {
                        DataGridViewCell cell = dGrid[j, i];
                        xlWorkSheet.Cells[i + 1, j + 1] = cell.Value;
                    }
                }
                xlWorkBook.SaveAs(pathFile);
                xlWorkBook.Close(false);
                xlApp.Quit();

                releaseObject(xlWorkSheet);
                releaseObject(xlWorkBook);
                releaseObject(xlApp);
                System.Diagnostics.Process.Start(pathFile);
            } catch (Exception e) {
                throw new ApplicationException(nameClass + " <exportDataGridToExcel> " + e.Message);
            }
        }
