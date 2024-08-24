#pragma warning disable CS8618 // Non-
using AutoMapper;
using CandyStore.DbContexts;
using CandyStore.Dto;
using CandyStore.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CandyStore.Services
{
    public class CandyService : ICandyService
    {
        public readonly CandyStoreDbContext _dbContext;
        public readonly IMapper _mapper;

        public CandyService(CandyStoreDbContext dbContext, IMapper mapper) 
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<List<CandyDto>> GetAllTheCandiesNames()
        {
            var candies = await _dbContext.Candies.Select(c => c.Name).ToListAsync() ?? throw new Exception("Candy not found");
            return _mapper.Map<List<CandyDto>>(candies);
        }
    }
}
