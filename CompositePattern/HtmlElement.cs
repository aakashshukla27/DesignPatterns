using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    public class HtmlElement : HtmlTag
    {
        private string tagName;
        private string startTag;
        private string endTag;
        private string tagBody;

        public HtmlElement(string tagName)
        {
            this.tagName = tagName;
            this.tagBody = "";
            this.startTag = "";
            this.endTag = "";
        }

        public override void generateHtml()
        {
            Console.WriteLine(startTag + "" + tagBody + "" + endTag);
        }

        public override string getTagName()
        {
            return tagName;
        }

        public override void setEndTag(string tag)
        {
            this.endTag = tag;
        }

        public override void setStartTag(string tag)
        {
            this.startTag = tag;
        }
    }
}
