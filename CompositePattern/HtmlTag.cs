using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    public abstract class HtmlTag
    {
		public abstract string getTagName();
		public abstract void setStartTag(string tag);
		public abstract void setEndTag(string tag);
		public void setTagBody(string tagBody)
		{
			throw new InvalidOperationException("Current operation is not support for this object");
		}
		public virtual void addChildTag(HtmlTag htmlTag)
		{
			throw new InvalidOperationException("Current operation is not support for this object");
		}
		public virtual void removeChildTag(HtmlTag htmlTag)
		{
			throw new InvalidOperationException("Current operation is not support for this object");
		}
		public virtual List<HtmlTag> getChildren()
		{
			throw new InvalidOperationException("Current operation is not support for this object");
		}
		public abstract void generateHtml();
	}
}
