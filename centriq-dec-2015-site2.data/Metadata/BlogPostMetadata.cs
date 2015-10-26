using centriq_dec_2015_site2.data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace centriq_dec_2015_site.data.Metadata
{
    class BlogPostMetadata
    {
        [Key]
        public int BlogPostID { get; set; }
        public int BlogAuthorID { get; set; }

        [AllowHtml]
        [Required]
        public string Content { get; set; }

        [ScaffoldColumn(false)]
        public System.DateTime PostDate { get; set; }

        public int BlogID { get; set; }

        [Required]
        [StringLength(150)]
        public string Title { get; set; }

        public virtual Blog Blog { get; set; }
        public virtual BlogAuthor BlogAuthor { get; set; }
    }

    [MetadataType(typeof(BlogPostMetadata))]
    public partial class BlogPost { }
}
