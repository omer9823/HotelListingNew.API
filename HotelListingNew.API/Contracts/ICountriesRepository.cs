using HotelListingNew.API.Data;

namespace HotelListingNew.API.Contracts
{
    public interface ICountriesRepository : IGenericRepository<Country>
    {
        Task<Country> GetDetails(int? id);
    }
}
