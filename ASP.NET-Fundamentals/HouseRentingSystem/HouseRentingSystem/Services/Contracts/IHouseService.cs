using HouseRentingSystem.Models;

namespace HouseRentingSystem.Services.Contracts
{
    public interface IHouseService
    {
        public Task<IEnumerable<HouseIndexViewModel>> LastThreeHousesAsync();
    }
}
