using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project.DatabaseContext.Tables
{
    /// <summary>
    /// Product Detail
    /// </summary>
   [Table("ProductTbl")]
    public class ProductTbl
    {
        [Key]
        public string Id {  get; set; }
        public string Img {  get; set; }
        public string ProductType {  get; set; }    
        public string ProductName {  get; set; }
        public string ProductDescription {  get; set; } 
        public string ProductCategory {  get; set; }
        public decimal ProductPrice {  get; set; }  
        public decimal ProductVolume {  get; set; } 
        public decimal Rating { get; set; }

        public string LoginId { get; set; }
     
        public virtual LoginTbl LoginTbl {  get; set; } 
    }
}
