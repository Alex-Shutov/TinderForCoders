using System;
using System.Collections.Generic;

#nullable disable

namespace TinderForCoders
{
    public partial class UserDevelop
    {
        public int ProjectId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Aims { get; set; }
        public bool? TagC { get; set; }
        public bool? TagJava { get; set; }
        public bool? TagJavaScrypt { get; set; }
        public bool? TagC1 { get; set; }
        public bool? TagPython { get; set; }
        public bool? TagHtmlCss { get; set; }
        public bool? TagPhp { get; set; }
        public bool? TagGo { get; set; }
        public int DeveloperId { get; set; }

        public virtual UserTable Developer { get; set; }
    }
}
