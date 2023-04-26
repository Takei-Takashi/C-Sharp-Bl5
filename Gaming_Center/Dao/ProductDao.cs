using Gaming_Center.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaming_Center.Dao
{
    public class ProductDao
    {
        public List<Product> GetAllProduct()
        {
            try
            {
                using (var context = new Gaming_CenterContext())
                {
                    return context.Products.Include(p => p.Genres).Include(p => p.Publisher).ToList();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Product> GetProductsByString(string s)
        {
            try
            {
                using (var context = new Gaming_CenterContext())
                {
                    return context.Products.Include(p => p.Genres).Include(p => p.Publisher).Where(p => p.ProductName.Contains(s)).ToList();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void DeleteProduct(int id)
        {
            try
            {
                using (var context = new Gaming_CenterContext())
                {
                    Product product = context.Products.Include(p => p.Genres).Include(p => p.Publisher).FirstOrDefault(p => p.ProductId == id);
                    product.Genres.Clear();
                    context.Products.Remove(product);
                    context.SaveChanges();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        public Product GetProductById(int id)
        {
            try
            {
                using (var context = new Gaming_CenterContext())
                {
                    return context.Products.Include(p => p.Genres).Include(p => p.Publisher).FirstOrDefault(p => p.ProductId == id);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        public bool UpdateProduct(Product updatedProduct)
        {
            try
            {
                using (var context = new Gaming_CenterContext())
                {
                    var product = context.Products.Include(p => p.Genres)
                        .FirstOrDefault(p => p.ProductId == updatedProduct.ProductId);

                    if (product != null)
                    {
                        // Cập nhật thông tin các trường của sản phẩm
                        product.ProductName = updatedProduct.ProductName;
                        product.PublisherId = updatedProduct.PublisherId;
                        product.ReleaseDate = updatedProduct.ReleaseDate;
                        product.Price = updatedProduct.Price;
                        product.Discount = updatedProduct.Discount;

                        // Xóa danh sách genre cũ của sản phẩm
                        product.Genres.Clear();

                        // Thêm các genre mới được chọn vào danh sách genre của sản phẩm
                        foreach (var genre in updatedProduct.Genres)
                        {
                            var existingGenre = context.Genres
                                .FirstOrDefault(g => g.GenresName == genre.GenresName);
                            if (existingGenre != null)
                            {
                                product.Genres.Add(existingGenre);
                            }
                        }

                        context.SaveChanges();
                        return true;
                    }

                    return false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool InsertProduct(Product product, List<Genre> genres)
        {
            try
            {
                using (var context = new Gaming_CenterContext())
                {
                    // Lấy các đối tượng Genre đã tồn tại từ CSDL
                    var existingGenres = context.Genres.Where(g => genres.Select(x => x.GenresId).Contains(g.GenresId)).ToList();
                    // Thêm các đối tượng Genre vào CSDL
                    foreach (var genre in existingGenres)
                    {
                        product.Genres.Add(genre);
                    }

                    // Thêm đối tượng Product mới vào CSDL
                    context.Products.Add(product);

                    context.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
