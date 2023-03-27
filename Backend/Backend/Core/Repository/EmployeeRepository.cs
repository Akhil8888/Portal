using Backend.Core.Data;
using Backend.Core.Data.Entities;
using Backend.Core.RepositoryInterface;
using Backend.Core.ViewModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Backend.Core.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly ApplicationDbContext _context;

        public EmployeeRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<AdvertisementModel> AddAdvertisement(AdvertisementModel model)
        {
            _context.Advertments.Add(model);
            _context.SaveChanges();
            return model;
        }

        public Task DeleteNews(string newsId)
        {
            throw new NotImplementedException();
        }


        public async Task<List<CommentModel>> GetAllComment()
        {
            return await _context.comments.ToListAsync();
        }

        public async Task<List<NewsModel>> GetAllNews()
        {
           return await _context.NewsList.Where(item => item.IsDeleted == false).ToListAsync();
        }

        public async Task<List<NewsModel>> GetUsersNews(string userId)
        {
            return await _context.NewsList.Where(item => item.UserId == userId).ToListAsync();
        }

        public async Task UpdateNews(NewsModel model)
        {
            var result = _context.NewsList.Update(model);
        }
    }
}
