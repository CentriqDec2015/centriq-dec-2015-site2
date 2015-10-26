using centriq_dec_2015_site2.data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace centriq_dec_2015_site.data
{
    class BlogMetadata
    {
        [Key]
        public int BlogID { get; set; }

        public int BlogAuthorID { get; set; }

        [Display(Name="Author")]
        public virtual BlogAuthor BlogAuthor { get; set; }

        public virtual ICollection<BlogPost> BlogPosts { get; set; }
    }

    [MetadataType(typeof(BlogMetadata))]
    public partial class Blog { }
}
