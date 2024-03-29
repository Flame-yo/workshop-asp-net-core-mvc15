using SalesWebMvc15.Data;
using SalesWebMvc15.Models;
using System.Collections.Generic;
using System.Linq;

namespace SalesWebMvc15.Services
{
    public class SellerService
    {
        private readonly SalesWebMvc15Context _context;

        public SellerService(SalesWebMvc15Context context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }

        public void Insert(Seller seller)
        {
            _context.Add(seller);
            _context.SaveChanges();
        }

        public Seller FindById(int id)
        {
            return _context.Seller.FirstOrDefault(x => x.Id == id);
        }

    }
}
