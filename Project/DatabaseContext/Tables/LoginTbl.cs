using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Project.Models.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project.DatabaseContext.Tables
{
    /// <summary>
    /// Login Table
    /// </summary>
    [Table("LoginTbl")]
    public class LoginTbl
    {
        [Key]
        public string Id { get; set; }
        public string Username { get; set; }
        public string Password {  get; set; }   
        public string Name { get; set; }
        public LoginEnum Role { get; set; }
        public virtual ICollection<ProductTbl> ProductTbls  {  get; set;}
    }
}
