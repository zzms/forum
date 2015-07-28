﻿using System;
using ENode.Commanding;

namespace Forum.Commands.Posts
{
    [Serializable]
    public class CreatePostCommand : Command
    {
        public string Subject { get; private set; }
        public string Body { get; private set; }
        public string SectionId { get; private set; }
        public string AuthorId { get; private set; }

        private CreatePostCommand() { }
        public CreatePostCommand(string id, string subject, string body, string sectionId, string authorId) : base(id)
        {
            Subject = subject;
            Body = body;
            SectionId = sectionId;
            AuthorId = authorId;
        }
    }
}
