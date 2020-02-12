using LibraryManagement.Domain.Base.SharedKernel;
using Entity = LibraryManagement.DAL.Entity;

namespace LibraryManagement.Infrastructure.Repositories.Mapping
{
   public class AddressMapping
    {
        public static Address MapToAddress(Entity.Address address)
        {
            return new Address(address.Street, address.City, address.State, address.ZipCode, address.Country);
        }
        public static Entity.Address MapToAddressEntity(Address address)
        {
            return new Entity.Address()
            {
                Street = address.Street,
                City = address.City,
                State = address.State,
                ZipCode = address.ZipCode,
                Country = address.Country
            };
        }

    }
}
