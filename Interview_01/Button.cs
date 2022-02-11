using System;
using System.Collections.Generic;
using System.Text;

namespace Interview_01
{
    public class Button
    {
        public string Style { get; set; }
        public string Id { get; set; }
        public string Text { get; set; }

        public virtual string Render()
        {
            if((this.Text != "" || this.Text != null) && (this.Id != "" || this.Id != null) && (this.Style != "" || this.Style != null))
            {
                return "<a class=\"btn btn-primary\" id=\""+this.Id +"\" style=\""+this.Style +"\">"+this.Text+"</a>";                
            }
            else if((this.Text != "" || this.Text != null) && (this.Id == "" || this.Id == null) && (this.Style == "" || this.Style == null))
            {
                return "<a class=\"btn btn-primary\">"+this.Text+"</a>";
            }            
        }

    }
}
