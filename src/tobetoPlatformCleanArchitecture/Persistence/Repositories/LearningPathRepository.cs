using Application.Services.Repositories;
using Domain.Entities;
using Core.Persistence.Repositories;
using Persistence.Contexts;

namespace Persistence.Repositories;

public class LearningPathRepository : EfRepositoryBase<LearningPath, int, BaseDbContext>, ILearningPathRepository
{
    public LearningPathRepository(BaseDbContext context) : base(context)
    {
    }
}