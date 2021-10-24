using System;
using System.Collections.Generic;

#nullable disable

namespace TinderForCoders
{
    public partial class UserLike
    {
        public int ProjectId { get; set; }
        public int UserId { get; set; }

        public virtual UserDevelop Project { get; set; }
        public virtual UserTable User { get; set; }
    }
}
