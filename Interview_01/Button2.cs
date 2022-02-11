using System;
using System.Collections.Generic;
using System.Text;

namespace Interview_01
{
    public class Button2 : Button
    {
        // Same as Button, but will use <button> instead of <a>
        public override string Render()
        {
             if((this.Text != "" || this.Text != null) && (this.Id != "" || this.Id != null) && (this.Style != "" || this.Style != null))
            {
                return "<button class=\"btn btn-primary\" id=\""+this.Id +"\" style=\""+this.Style +"\">"+this.Text+"</a>";                
            }
            else if((this.Text != "" || this.Text != null) && (this.Id == "" || this.Id == null) && (this.Style == "" || this.Style == null))
            {
                return "<button class=\"btn btn-primary\">"+this.Text+"</a>";
            }  
        }
    }
}
