using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActivityPost.Entities
{
    class Post
    {
        public DateTime Moment { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int Likes { get; set; }
        public List<Comment> Comments { get; set; } = new List<Comment>();

        public Post(DateTime moment, string title, string content, int likes)
        {
            Moment = moment;
            Title = title;
            Content = content;
            Likes = likes;
        }

        public void addComent(Comment c) 
        {
            Comments.Add(c);
        }

        public void removecomment(Comment c)
        {
            Comments.Remove(c); 
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Title);
            sb.AppendLine("Likes "+Likes + " - " + Moment);
            sb.AppendLine(Content);
            sb.AppendLine("comments:");
            foreach(Comment c in Comments)
            {
                sb.AppendLine(c.text);
            }
            return sb.ToString();
        }

    }
}
