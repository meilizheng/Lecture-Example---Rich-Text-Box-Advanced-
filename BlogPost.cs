using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Media;
using System.Windows;

namespace Lecture_Example___Rich_Text_Box___Advanced__
{
    public class BlogPost
    {
        string _subjectline;
        string _bodyText;
        DateTime _timeStamp;
        public BlogPost(string subjectline, string bodyText)
        {
            _subjectline = subjectline;
            _bodyText = bodyText;
            _timeStamp = DateTime.Now;
        }

        public string Subjectline { get => _subjectline; set => _subjectline = value; }
        public string BodyText { get => _bodyText; set => _bodyText = value; }


        public Run HeaderFormatted(string subjectline)
        {
            Run headerrun = new Run(subjectline);
            headerrun.FontSize = 18;
            headerrun.Foreground = new SolidColorBrush(Colors.Cyan);
            headerrun.FontStyle = FontStyles.Oblique;
            return headerrun;
        }

        public Run BodyFormatted(string bodyText)
        {
            Run runNewBody = new Run(bodyText);
            runNewBody.FontSize = 16;
            runNewBody.FontWeight = FontWeights.Bold;
            runNewBody.FontStyle = FontStyles.Italic;
            runNewBody.Foreground = new SolidColorBrush(Colors.White);
            return runNewBody;
        }

        public Paragraph BlogpostFormatted()
        {
            Paragraph newParagraph = new Paragraph();
            string subjectline = _subjectline;
            string bodyText = _bodyText;
            Run header = HeaderFormatted(subjectline);
            Run body = BodyFormatted(bodyText);
            newParagraph.Inlines.Add(subjectline);
            newParagraph.Inlines.Add("\n");
            newParagraph.Inlines.Add(body);
            return newParagraph;
        }

        public override string ToString()
        {
            return _timeStamp.ToShortTimeString() + " " + _subjectline;
        }
    }
}
