using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
namespace ItFoto.Models
{
    public class SendEmailDb : DbContext
    {
        public SendEmailDb(DbContextOptions<SendEmailDb> options) : base(options)
        {
        }
        // add email object to db
        public DbSet<emailSent> emailSent { get; set; }

        public async Task AddEmail(emailSent data)
        {
            await emailSent.AddAsync(data);
            await SaveChangesAsync();
        }

        public async Task<List<emailSent>> GetEmails()
        {
            return await emailSent.ToListAsync();
        }
    }
    // add message
    
}
