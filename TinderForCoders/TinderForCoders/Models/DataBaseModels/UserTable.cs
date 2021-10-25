using System;
using System.Collections.Generic;

#nullable disable

namespace TinderForCoders
{
    public partial class UserTable
    {
        public UserTable()
        {
            UserDevelops = new HashSet<UserDevelop>();
        }

        public int UserId { get; set; }
        public string UserLogin { get; set; }
        public string UserEmail { get; set; }
        public string UserPassword { get; set; }
        public string UserName { get; set; }
        public string UserSurname { get; set; }
        public string UserGit { get; set; }
        public bool? UserTagC { get; set; }
        public bool? UserTagJava { get; set; }
        public bool? UserTagCC { get; set; }
        public bool? UserTagPython { get; set; }
        public bool? UserTagJavaScrypt { get; set; }
        public bool? UserTagPhp { get; set; }
        public bool? UserTagHtmlCss { get; set; }
        public bool? UserTagGo { get; set; }

        public virtual ICollection<UserDevelop> UserDevelops { get; set; }
    }
}
