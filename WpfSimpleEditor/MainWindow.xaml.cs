using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
//using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfSimpleEditor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void FileSave_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            if (saveFile.ShowDialog() == true)
            {
                string fileName = saveFile.FileName;
                TextRange range = new TextRange(richTextBox.Document.ContentStart, richTextBox.Document.ContentEnd);
                range.Save(saveFile.OpenFile(), DataFormats.Rtf);
                MessageBox.Show("File Successfully Saved!");
            }
        }

        private void FileOpen_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Rich Text Format (*.rtf)|*.rtf|All Files (*.*)|*.*";
            if (openFile.ShowDialog() == true)
            {
                TextRange range = new TextRange(richTextBox.Document.ContentStart, richTextBox.Document.ContentEnd);
                range.Load(openFile.OpenFile(), DataFormats.Rtf);
            }
        }

        private void FileClose_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult messageBoxResult = System.Windows.MessageBox.Show("Close the application?", "Close Application", System.Windows.MessageBoxButton.YesNo, MessageBoxImage.Question );
            if (messageBoxResult == MessageBoxResult.Yes)
            {
                //Application.Current.Shutdown();
                this.Close();
            }
        }

        private void Font_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Forms.FontDialog fontDialog = new System.Windows.Forms.FontDialog();
            if (fontDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                richTextBox.Selection.ApplyPropertyValue(Inline.FontSizeProperty, fontDialog.Font.Size.ToString());
                richTextBox.Selection.ApplyPropertyValue(Inline.FontFamilyProperty, fontDialog.Font.FontFamily.Name);
                //richTextBox.Selection.ApplyPropertyValue(Inline.FontStyleProperty, fontDialog.Font.Style);
                
            }
        }

        private void FontColor_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Forms.ColorDialog color = new System.Windows.Forms.ColorDialog();
            if(color.ShowDialog()== System.Windows.Forms.DialogResult.OK)
            {
                richTextBox.Selection.ApplyPropertyValue(Inline.ForegroundProperty, color.Color.Name);
            }
        }
    }
}
