﻿using System;

#nullable disable

namespace SocialMedia.Core.Entities
{
    public partial class Comment
    {
        public int CommentId { get; set; }
        public int IdPost { get; set; }
        public int UserID { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public bool IsActive { get; set; }

        public virtual Post Post { get; set; }
        public virtual User User { get; set; }
    }
}
