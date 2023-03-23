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
       List<BlogPost> blogPosts = new List<BlogPost>();
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
            string subjectline = txtHeader.Text;
            string bodytext = rtbRunBody.Text;
            BlogPost bp = new BlogPost(subjectline, bodytext);
            blogPosts.Add(bp);
            fdDisplay.Blocks.Add(blogPosts[0].BlogpostFormatted());
            DisplayBlogPost();
            UpdateRichTextBox(blogPosts[blogPosts.Count - 1]);
            rtbDisplay.Document = fdDisplay;
        }

        public void DisplayBlogPost()
        {
            lbBlogPost.Items.Clear();

            foreach(BlogPost item in blogPosts)
            {
                lbBlogPost.Items.Add(item);
            }
        }

        private void lbBlogPost_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int selected = lbBlogPost.SelectedIndex;
            if (selected >= 0)
            {
                BlogPost bp = blogPosts[selected];
                UpdateRichTextBox(bp);
            }                       
        }

        public void UpdateRichTextBox(BlogPost post)
        {
            fdDisplay.Blocks.Clear();
            fdDisplay.Blocks.Add(post.BlogpostFormatted());
        }
    }
}
