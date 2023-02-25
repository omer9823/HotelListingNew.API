using HotelListingNew.API.Contracts;
using HotelListingNew.API.Data;

namespace HotelListingNew.API.Repository
{
    public class HotelsRepository : GenericRepository<Hotel>, IHotelsRepository
    {
        public HotelsRepository(HotelListingDbContext context) : base(context)
        {
        }
    }
}
