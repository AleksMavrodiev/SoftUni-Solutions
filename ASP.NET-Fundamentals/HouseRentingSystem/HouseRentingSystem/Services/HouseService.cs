using HouseRentingSystem.Data;
using HouseRentingSystem.Models;
using HouseRentingSystem.Services.Contracts;

namespace HouseRentingSystem.Services
{
    public class HouseService : IHouseService
    {
        private readonly HouseRenting dbContext;

        public HouseService(HouseRenting dbContext)
        {
            this.dbContext = dbContext;
        }
        public Task<IEnumerable<HouseIndexViewModel>> LastThreeHousesAsync()
        {
            throw new NotImplementedException();
        }
    }
}
