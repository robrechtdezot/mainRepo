using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CodeManager;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
        {
        InitializeComponent();
        LoadCodeFiles();
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            string fileName = FileNameTextBox.Text;
            string codeContent = CodeContentTextBox.Text;

            if (!string.IsNullOrEmpty(fileName) && !string.IsNullOrEmpty(codeContent))
            {
                using (var db = new CodeManagerContext())
                {
                    var newCodeFile = new CodeFile
                    {
                        FileName = fileName,
                        CodeContent = codeContent,
                        DateAdded = DateTime.Now
                    };
                    db.CodeFiles.Add(newCodeFile);
                    db.SaveChanges();
                }

                FileNameTextBox.Clear();
                CodeContentTextBox.Clear();
                LoadCodeFiles();
            }
            else
            {
                MessageBox.Show("Please provide both file name and code content.");
            }
        }

        private void LoadCodeFiles()
        {
            using (var db = new CodeManagerContext())
            {
                var codeFiles = db.CodeFiles.OrderByDescending(c => c.DateAdded).ToList();
                CodeFileList.Items.Clear();
                foreach (var file in codeFiles)
                {
                    CodeFileList.Items.Add($"{file.FileName} - {file.DateAdded}");
                }
            }
        }
    }
}

    }
}