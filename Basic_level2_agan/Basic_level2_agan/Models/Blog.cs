using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Basic_level2_agan.Models
{
    public class Blog
    {
        public int? id { get; set; }
        
        /// <summary>
        /// validattion tin
        /// </summary>
        [StringLength(60, MinimumLength = 2)]
        [Required]
        public string tin { get; set; }
        
        /// <summary>
        /// validation loai
        /// </summary>
         [StringLength(60, MinimumLength = 2)]
         [Required]     
        public string loai { get; set; }
      
         /// <summary>
         /// validation trangthai
         /// </summary>
         [StringLength(60, MinimumLength = 2)]
         [Required]
        public string trangThai { get; set; }  
         /// <summary>
         /// validation vitri
         /// </summary>
         [StringLength(60, MinimumLength = 2)]
         [Required]
        public string viTri { get; set; }

         /// <summary>
         /// validation motangan
         /// </summary>
         [StringLength(60, MinimumLength = 2)]
         [Required]
         public string motangan { get; set; }

          /// <summary>
          /// validation chitiet
          /// </summary>
         [StringLength(60, MinimumLength = 2)]
         [Required]
         public string chitiet { get; set; }

        /// <summary>
        /// validation ngay public
        /// </summary>
        [Required(ErrorMessage="Enter the issue date")]
        [DataType(DataType.Date)]
        public DateTime ngayPublic { get; set; }
    

        
    }
    /// <summary>
    /// connect database BlogDBContext
    /// </summary>
    public class BlogDBContext : DbContext
    {
        public DbSet<Blog> Blogs { get; set; }
    }
   

}