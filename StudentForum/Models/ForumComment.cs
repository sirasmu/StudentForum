namespace StudentForum.Models
{
   public class ForumComment
   {

      public long Id { get; set; }
      public virtual ApplicationUser Author { get; set; }
      public string Content { get; set; }
   }
}