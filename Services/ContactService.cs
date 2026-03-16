using BorchePortfolio.Models;
using BorchePortfolio.Data;
using Microsoft.EntityFrameworkCore;



namespace BorchePortfolio.Services
{
    public class ContactService
    {
        private readonly ApplicationDbContext _context;


        public ContactService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task SaveAsync(ContactMessage message)
        {
            _context.ContactMessages.Add(message);
            await _context.SaveChangesAsync();
        }

        public async Task<List<ContactMessage>> GetAllAsync()
        {
            return await _context.ContactMessages
                .OrderByDescending(x => x.CreatedAt)
                .ToListAsync();
        }
       
        public async Task DeleteAsync(int id)
        {
            var message = await _context.ContactMessages.FindAsync(id);
            if(message != null)
            {
                _context.ContactMessages.Remove(message);
                await _context.SaveChangesAsync();
            }
        }
    }
}
