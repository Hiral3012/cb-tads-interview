﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Interview_01
{
    public class Input
    {
        public string Style { get; set; }
        public string Id { get; set; }
        public string Placeholder { get; set; }

        public string Render()
        {
            return "<input class=\"btn btn-primary\" id=\""+this.Id+""\" style=\""+this.Style+"\" placeholder=\""+this.Placeholder+"\"></input>";
        }

    }
}
