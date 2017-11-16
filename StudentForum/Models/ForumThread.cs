using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StudentForum.Models;

namespace StudentForum.Models
{
   public class ForumThread
   {
      public long Id { get; set; }
      public string Title { get; set; }
      public string Content { get; set; }
      public virtual ApplicationUser Author { get; set; }
      public ICollection<string> FilePaths { get; set; }
      public virtual ICollection<ForumComment> Comments { get; set; }

   }
}