using Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using Models.Domain;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Repositories
{
    public class PostsRepository : IPostsRepository
    {
        private readonly Context _context;
        public PostsRepository(Context context)
        {
            _context = context;
        }

        public async Task<Posts> AddPost(Posts post)
        {
            _context.Posts.Add(post);
            await _context.SaveChangesAsync();
            return post;
        }

        public async Task<int> DeletePost(Posts post)
        {
            _context.Posts.Remove(post);
            return await _context.SaveChangesAsync();
        }

        public async Task<Posts> GetPostById(Guid id)
        {
            return await _context.Posts
                .Include(x => x.UpdatedBy)
                    .ThenInclude(y => y.Rol)
                .Include(z => z.Comments)
                .FirstOrDefaultAsync(z => z.Id == id);
        }

        public async Task<ICollection<Posts>> GetPosts()
        {
            return await _context.Posts
                .Include(z => z.Comments)
                .Include(x => x.UpdatedBy)
                    .ThenInclude(y => y.Rol)
                .ToListAsync();
        }

        public async Task<int> UpdatePost(Posts post)
        {
            return await _context.SaveChangesAsync();
        }
    }
}
