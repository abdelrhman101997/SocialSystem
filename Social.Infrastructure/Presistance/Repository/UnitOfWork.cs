using AutoMapper;
using Social.Domain.Interface;
using Social.Infrastructure.Presistance.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Social.Infrastructure.Presistance.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDBContext _context;

        //public IMovieRepository Movies { get; }

        public UnitOfWork(ApplicationDBContext context)
        {
            _context = context;
           // Movies = new MovieRepository(_context);
        }

        public IRepository<T> Repository<T>() where T : class
        {
            return new Repository<T>(_context);
        }

        public async Task<int> CompleteAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }

      
    }
}
