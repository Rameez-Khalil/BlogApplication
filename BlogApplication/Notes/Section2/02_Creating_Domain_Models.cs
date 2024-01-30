/*
 * ADMIN has the functionality of creating a blogpost and assign tags into it.
 * 
 * A single tag can be used to index multiple tags.
 * 
 * One BlogPosts can have many tags, and multiple tags can have many blogposts -> Many To Many Relationship.
 * 
 * DOMAIN MODEL : 
 *      Domain model identifies the relationship among entities that are involved in our problem domain.
 *      
         *      BLOG DOMAIN MODEL : 
         *              namespace BlogApplication.Models.Domain
        {
            public class BlogPost
            {
                public Guid Id { get; set; }
                public string Heading { get; set; }
                public string PageTitle { get; set; }
                public string PageContent { get; set; }
                public string ShortDescription { get; set; }
                public string FeaturedImageUrl  { get; set; }
                public string UrlHandle { get; set; }
                public DateTime PublishedDate { get; set; }
                public string Author { get; set; }
                public bool Visible { get; set; }

                public ICollection<Tag> Tags { get; set; }
            }
        }

            TAG DOMAIN MODEL : 
                namespace BlogApplication.Models.Domain
                {
                    public class Tag
                    {
                        public Guid Id { get; set; }
                        public string Name { get; set; }
                        public string DisplayName { get; set; }
                        public ICollection<BlogPost> Blogs { get; set; }
                    }
                }

                    

 *      
 */