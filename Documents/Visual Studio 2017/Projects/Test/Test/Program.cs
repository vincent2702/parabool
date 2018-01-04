using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;
using Word = Microsoft.Office.Interop.Word;

namespace Test
{
    class Program
    {
        public class Account
        {
            public int ID { get; set; }
            public double Balance { get; set; }
        }

        static void DisplayInExcel1(IEnumerable<Account> accounts)
        {
            var excelApp = new Excel.Application();
            // make the object visible
            excelApp.Visible = false;

            // Create a new, empty workbook and add it to the collection returned 
            // by property Workbooks. The new workbook becomes the active workbook.
            // Add has an optional parameter for specifying a praticular template. 
            // Because no argument is sent in this example, Add creates a new workbook.
            excelApp.Workbooks.Open(@"C:\Users\vince\Documents\Visual Studio 2017\Projects\Test\Test\bin\Debug\Test2.xlsx", ReadOnly: false);

            // This example uses a single worksheet. the explicit type casting is
            // removed in a later procedure.
            Excel._Worksheet worksheet = (Excel.Worksheet)excelApp.ActiveSheet;

            // Establish column headings in cells A1 and B1
            worksheet.Cells[1, "A"] = "ID Number";
            worksheet.Cells[1, "B"] = "Current Balance";

            var row = 1;
            foreach (var acct in accounts)
            {
                row++;
                worksheet.Cells[row, "A"] = acct.ID;
                worksheet.Cells[row, "B"] = acct.Balance;
            }

            worksheet.Columns[1].Autofit();
            worksheet.Columns[2].Autofit();

            excelApp.ActiveWorkbook.Save();

            
            
        }

        static void ReadText()
        {
            // The files used in this example are created in the topic
            // How to: Write to a Text File. You can change the path and
            // file name to substitute text files of your own.

            // Example #1
            // Read the file as one string.
            string text = System.IO.File.ReadAllText(@"C:\Users\vince\Documents\Visual Studio 2017\Projects\streeplijst\streeplijst\bin\Debug\SavedList.txt");

            // Display the file contents to the console. Variable text is a string.
            System.Console.WriteLine("{0}", text);

            // Example #2
            // Read each line of the file into a string array. Each element
            // of the array is one line of the file.
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\vince\Documents\Visual Studio 2017\Projects\streeplijst\streeplijst\bin\Debug\SavedList.txt");

            // Display the file contents by using a foreach loop.
            
            foreach (string line in lines)
            {
                // Use a tab to indent each line of the file.
                String[] words = line.Split(';');
                foreach (String word in words)
                {
                    Console.WriteLine("\t\t\t" + word);
                }
            }
            
            String[] words1 = lines[1].Split(';');

            foreach (String word in words1)
            {
                Console.WriteLine("\t\t\t" + word);
            }

            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            System.Console.ReadKey();
        }

        static void DisplayInExcel(IEnumerable<Account> accounts, Action<Account, Excel.Range> DisplayFunc)
        {
            var excelApp = new Excel.Application();
            // Add a new Excel workbook.
            excelApp.Workbooks.Add();
            excelApp.Visible = true;
            excelApp.Range["A1"].Value = "ID";
            excelApp.Range["B1"].Value = "Balance";
            excelApp.Range["A2"].Select();

            foreach (var ac in accounts)
            {
                DisplayFunc(ac, excelApp.ActiveCell);
                excelApp.ActiveCell.Offset[1, 0].Select();
            }
            // Copy the results to the Clipboard.
            excelApp.Range["A1:B3"].Copy();

            excelApp.Columns[1].AutoFit();
            excelApp.Columns[2].AutoFit();

        }

        static void Main(string[] args)
        {
            // Creat a list of account
            var bankAccounts = new List<Account>
            {
                new Account
                {
                    ID = 345689,
                    Balance = 541.27
                },
                new Account
                {
                    ID = 4568,
                    Balance = 127.44
                }

            };

            ReadText();



            //DisplayInExcel1(bankAccounts);

            //// display the list in an excel spreadsheet
            //DisplayInExcel(bankAccounts, (account, cell) =>
            //// This multiline lambda expression sets custom processing rules  
            //// for the bankAccounts.
            //{
            //    cell.Value = account.ID;
            //    cell.Offset[0, 1].Value = account.Balance;
            //    if (account.Balance < 0)
            //    {
            //        cell.Interior.Color = 255;
            //        cell.Offset[0, 1].Interior.Color = 255;
            //    }
            //});

        }
    }
}
