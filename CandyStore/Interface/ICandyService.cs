using CandyStore.Dto;
using Microsoft.AspNetCore.Mvc;

namespace CandyStore.Interface
{
    public interface ICandyService
    {
        public Task<List<CandyDto>> GetAllTheCandiesNames();
    }
}
