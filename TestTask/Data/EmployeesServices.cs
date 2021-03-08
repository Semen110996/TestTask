using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestTask.Models;

namespace TestTask.Data
{
    public class EmployeesServices
    {
        private readonly ApplicationDbContext _context;

        public EmployeesServices(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Employee>> Get()
        {
            return await _context.Employees.ToListAsync();
        }

        public async void Delete(int id)
        {
            var removeObj = _context.Employees.Where(e => e.Id == id).FirstOrDefault();
            _context.Employees.Remove(removeObj);
            _context.SaveChanges();
        }

        public async void Update(int id, string Name, string Surname, string Patronymic, string Phone, int CompanyId)
        {
            var updateObj = _context.Employees.Where(e => e.Id == id).FirstOrDefault();
            updateObj.Name = Name;
            updateObj.Surname = Surname;
            updateObj.Patronymic = Patronymic;
            updateObj.Phone = Phone;
            updateObj.CompanyId = CompanyId;
            _context.SaveChanges();
        }

        public async void Add(string Name, string Surname, string Patronymic, string Phone, int CompanyId)
        {
            _context.Employees.Add(new Employee(Name, Surname, Patronymic, Phone, CompanyId));
            _context.SaveChanges();
        }
    }
}
