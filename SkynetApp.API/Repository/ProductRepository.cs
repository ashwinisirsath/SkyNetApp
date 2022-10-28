using SkynetApp.API.Service;
using SkynetApp.API.Data;
using SkynetApp.API.Models;
using Dapper;

namespace SkynetApp.API.Repository
{
    public class ProductRepository : IProductService
    {   private readonly SkynetDbContext _context;
        public ProductRepository(SkynetDbContext context)
        {
            _context=context;
        }
        //public async Task <IEnumerabl<Product>> GetAllProducts()
        //{
        //    string SQL = @"Select * from tblProsuct";
        //    using (var conn = _context.CreateConnection())
        //    {
        //        var result = await conn.QueryAsync<Product>(SQL);
        //        return (IEnumerabl<Product>)result;
                
        //    }
        //}



        public async Task<IEnumerable<Product>> GetAllProducts()
        {
            string SQL = @"Select * from tblProduct";
            using (var conn = _context.CreateConnection())
            {
                var result = await conn.QueryAsync<Product>(SQL);
                return result;

            }

        }

        public async Task<IEnumerable<Product>> GetProduct(int id)
        {
           string sql=@"SELECT * FROM tblProduct WHERE Id=" + id.ToString();
           using var conn=_context.CreateConnection();
           var result = await conn.QueryAsync<Product>(sql);
            var FilterdRecords=new List<Product>();

            foreach (var item in result)
            {
                if(item.Price>10)
                {
                    FilterdRecords.Add(item);
                }
            }
            return FilterdRecords;
        }
    }
}
