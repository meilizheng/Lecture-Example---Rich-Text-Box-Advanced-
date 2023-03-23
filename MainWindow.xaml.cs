using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lecture_Example___Rich_Text_Box___Advanced__
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       FlowDocument fdDisplay = new FlowDocument();
        public MainWindow()
        {          
            InitializeComponent();
           
        }

        public void Itworks()
        {
            Paragraph para = new Paragraph();
            Paragraph para2 = new Paragraph();
            Run run = new Run("Lecture Example Rich Text Box");
            run.Background = new SolidColorBrush(Colors.DeepPink);
            Run run1 = new Run("Hello Everyone");
            para.Inlines.Add(run);
            para.Background = new SolidColorBrush(Colors.Azure);
            para2.Inlines.Add(run1);
            fdDisplay.Blocks.Add(para);
            fdDisplay.Blocks.Add(para2);
            fdDisplay.Background = new SolidColorBrush(Colors.Bisque);
            rtbDisplay.Document = fdDisplay;
            rtbDisplay.Background = new SolidColorBrush(Color.FromRgb(25, 25, 25));
        }
        
        public void FlowExample()
        {
            FlowDocument fdDisplay = new FlowDocument();
            Paragraph p = new Paragraph();
            Run r = new Run("Hi all");
            r.FontWeight = FontWeights.Bold;
            r.Foreground = new SolidColorBrush(Colors.Cyan);
            r.FontSize = 18;
            p.Inlines.Add(r);
            fdDisplay.Blocks.Add(p);
            rtbDisplay.Document = fdDisplay;
        }

        private void btnDisply_Click(object sender, RoutedEventArgs e)
        {
            Paragraph newParagraph = new Paragraph();
            string subjectline = txtHeader.Text;
            string body = rtbRunBody.Text;
            Run headerrun = new Run(subjectline);
            headerrun.FontSize = 18;
            headerrun.Foreground = new SolidColorBrush(Colors.Cyan);
            Run runNewBody = new Run(body);
            runNewBody.FontSize = 16;
            runNewBody.FontWeight = FontWeights.Bold;
            runNewBody.Foreground = new SolidColorBrush(Colors.White);
            newParagraph.Inlines.Add(headerrun);
            newParagraph.Inlines.Add("\n");
            newParagraph.Inlines.Add(runNewBody);
            fdDisplay.Blocks.Add(newParagraph);
            rtbDisplay.Document = fdDisplay;
        }
    }
}
