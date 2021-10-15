using Microsoft.EntityFrameworkCore;
using Project.DatabaseContext.Tables;
using Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.DatabaseContext.Services
{
    public class ProductService
    {
        DbEntity _db;
        public ProductService()
        {
            _db = new DbEntity();
        }

        /// <summary>
        /// Getting Product Details
        /// </summary>
        /// <param name="UserId">Login Id</param>
        /// <returns>List of Products</returns>
        public async Task<MasterModel<List<ProductTbl>>> GetProducts(string UserId)
        {
            try
            {
                var products = await _db.productTbls.ToListAsync();
                if (products == null)
                {
                    return new MasterModel<List<ProductTbl>>
                    {
                        Errors = new string[] { "No Record Found" }
                    };
                }
                return new MasterModel<List<ProductTbl>>
                {
                    Status = true,
                    Result = products
                };
            }
            catch (Exception ex)
            {
                return new MasterModel<List<ProductTbl>>
                {
                    Errors = new string[] { ex.Message }
                };
            }

        }
        /// <summary>
        /// Save Product Detail
        /// </summary>
        /// <param name="model">New Product Detail</param>
        /// <param name="UserId">Logged In User Id</param>
        /// <returns></returns>
        public async Task<MasterModel<bool>> SaveProductAsync(ProductModel model, string UserId)
        {
            try
            {
                _db.productTbls.Add(new ProductTbl
                {
                    Id = Guid.NewGuid().ToString(),
                    Img = model.Img,
                    LoginId = UserId,
                    ProductCategory = model.ProductCategory,
                    ProductDescription = model.ProductDescription,
                    ProductName = model.ProductName,
                    ProductPrice = model.ProductPrice,
                    ProductType = model.ProductType,
                    ProductVolume = model.ProductVolume,
                    Rating = 0
                });
                await _db.SaveChangesAsync();
                return new MasterModel<bool>
                {
                    Status = true,
                    Result = true
                };
            }
            catch (Exception ex)
            {
                return new MasterModel<bool>
                {
                    Status = false,
                    Errors = new string[] { ex.Message }
                };
            }
        }

        /// <summary>
        /// Update Product Detail
        /// </summary>
        /// <param name="model">New Product Detail</param>
        /// <param name="UserId">Logged In User Id</param>
        /// <returns></returns>
        public async Task<MasterModel<bool>> UpdateProductAsync(ProductModel model, string UserId)
        {
            try
            {
                var product = await _db.productTbls.Where(x => x.Id == model.Id).SingleOrDefaultAsync();
                if(product == null)
                {
                    return new MasterModel<bool>
                    {
                        Errors = new string[] { "No record found" }
                    };
                }
                product.Rating = model.Rating;
                product.Img = model.Img;
                product.ProductCategory= model.ProductCategory; 
                product.ProductDescription = model.ProductDescription;      
                product.ProductName = model.ProductName;    
                product.ProductPrice = model.ProductPrice;
                product.ProductType = model.ProductType;
                product.ProductVolume = model.ProductVolume;    
                _db.productTbls.Update(product);    
                await _db.SaveChangesAsync();
                return new MasterModel<bool>
                {
                    Status = true,
                    Result = true
                };
            }
            catch (Exception ex)
            {
                return new MasterModel<bool>
                {
                    Status = false,
                    Errors = new string[] { ex.Message }
                };
            }
        }

        /// <summary>
        /// Get Product Detail
        /// </summary>
        /// <param name="Id">Selected Product Id</param>
        /// <param name="UserId">Logged In User Id</param>
        /// <returns></returns>
        public async Task<MasterModel<ProductModel>> GetProduct(string Id, string UserId)
        {
            try
            {
                var result = await _db.productTbls.Where(x => x.Id == Id).Select(x => new ProductModel
                {
                    Id = x.Id,
                    Img = x.Img,
                    ProductCategory = x.ProductCategory,
                    ProductDescription = x.ProductDescription,
                    ProductName = x.ProductName,
                    ProductPrice = x.ProductPrice,
                    ProductType = x.ProductType,
                    ProductVolume = x.ProductVolume,
                    Rating = x.Rating
                }).SingleOrDefaultAsync();
                if (result == null)
                {
                    return new MasterModel<ProductModel>()
                    {
                        Status = false,
                        Errors = new string[] { "No record found" }
                    };
                }
                return new MasterModel<ProductModel>
                {
                    Status = true,
                    Result = result
                };
            }
            catch (Exception ex)
            {
                return new MasterModel<ProductModel>
                {
                    Errors = new string[] { ex.Message }
                };
            }
        }

        /// <summary>
        /// Delete Product Detail
        /// </summary>
        /// <param name="Id">Selected Product Id</param>
        /// <param name="UserId">Logged In User Id</param>
        /// <returns></returns>
        public async Task<MasterModel<bool>> DeleteProduct(string Id, string UserId)
        {
            try
            {
                var result = await _db.productTbls.Where(x => x.Id == Id).SingleOrDefaultAsync();
                if (result == null)
                {
                    return new MasterModel<bool>()
                    {
                        Status = false,
                        Errors = new string[] { "No record found" }
                    };
                }
                _db.productTbls.Remove(result);
                await _db.SaveChangesAsync();
                return new MasterModel<bool>
                {
                    Status = true,
                    Result = true
                };
            }
            catch (Exception ex)
            {
                return new MasterModel<bool>
                {
                    Errors = new string[] { ex.Message }
                };
            }
        }
    }
}
