using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    class HtmlParentElement : HtmlTag
    {
        private string tagName;
        private string startTag;
        private string endTag;
        private List<HtmlTag> childrenTag;

        public HtmlParentElement(String tagName)
        {
            this.tagName = tagName;
            this.startTag = "";
            this.endTag = "";
            this.childrenTag = new List<HtmlTag>();
        }

        public override void generateHtml()
        {
            Console.WriteLine(startTag);
            foreach (HtmlTag tag in childrenTag)
            {
                tag.generateHtml();
            }
            Console.WriteLine(endTag);
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
        public override List<HtmlTag> getChildren()
        {
            return childrenTag;
        }

        public override void addChildTag(HtmlTag htmlTag)
        {
            childrenTag.Add(htmlTag);
        }


        public override void removeChildTag(HtmlTag htmlTag)
        {
            childrenTag.Remove(htmlTag);
        }
    }
}
