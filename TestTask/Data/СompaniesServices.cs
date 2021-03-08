using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestTask.Models;

namespace TestTask.Data
{
    public class СompaniesServices
    {
        private readonly ApplicationDbContext _context;

        public СompaniesServices(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Company>> Get()
        {
            return await _context.Сompanies.ToListAsync();
        }

        public async void Delete(int id)
        {
            var removeObj = _context.Сompanies.Where(e => e.Id == id).FirstOrDefault();
            _context.Сompanies.Remove(removeObj);
            _context.SaveChanges();
        }

        public async void Update(int id, string Name)
        {
            var updateObj = _context.Сompanies.Where(e => e.Id == id).FirstOrDefault();
            updateObj.Name = Name;
            _context.SaveChanges();
        }

        public async void Add(string Name)
        {
            _context.Сompanies.Add(new Company(Name));
            _context.SaveChanges();
        }
    }
}
