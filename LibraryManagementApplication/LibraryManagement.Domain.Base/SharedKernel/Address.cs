using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Domain.Base.SharedKernel
{
    public class Address : BaseValueObject<Address>
    {
        public string Street { get;  }
        public string City { get;  }

        public string State { get;  }
        public string ZipCode { get;  }
        public string Country { get;  }
        public Address(string street, string city, string state, string zipCode, string country)
        {
            Street = street;
            City = city;
            State = state;
            ZipCode = zipCode;
            Country = country;
        }

        protected override bool EqualsCore(Address other)
        {
            return Street == other.Street
                && City == other.City
                && ZipCode == other.ZipCode
                && State == other.State
                && Country == other.Country;
        }

        protected override int GetHashCodeCore()
        {
            unchecked
            {
                int hashCode = Street.GetHashCode();
                hashCode = (hashCode * 397) ^ City.GetHashCode();
                hashCode = (hashCode * 397) ^ ZipCode.GetHashCode();
                hashCode = (hashCode * 397) ^ ZipCode.GetHashCode();
                return hashCode;
            }
        }

        public static implicit operator Address(string v)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append(Street);
            sb.AppendFormat(" {0}", City);
            sb.AppendFormat(" {0}", State);
            sb.AppendFormat(" {0}", Country);
            sb.AppendFormat(" {0}", ZipCode);
            return sb.ToString();
        }
    }
}
