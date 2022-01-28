using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    class AddressRepository
    {
        public Address Retive(int addressId)
        {
            // create the instance of the address classs
            // pass in the reqested Id
            Address address = new Address(addressId);
           // code that retrives the defined address

            // Temporary hard coded values to return 
            // Populated address
            if (addressId == 1)
            {
                address.AddressType = 1;
                address.StreetLine1 = "Addis Abeba";
                address.StreetLine2 = "Arada";
                address.City = "Addis Abeba";
                address.State = "Addis Abeba";
                address.Country = "Ethiopia";
                address.PostalCode = "0000";
            }
            return address;
        }

        public IEnumerable<Address> RetiveByCustomerId(int customerId)
        {
            // code that retrives the defined address
            // for the customer.

            // Temporarty hard-coded values to return
            // set of addres for the customer
            var addressList = new List<Address>();
            var address = new Address(1) { 
            AddressType = 1,
           StreetLine1 = "Addis Abeba",
           StreetLine2 = "Arada",
           City = "Addis Abeba",
           State = "Addis Abeba",
           Country = "Ethiopia",
           PostalCode = "0000",
        };

            addressList.Add(address);
           address = new Address(2)
            {
                AddressType = 2,
                StreetLine1 = "Godner",
                StreetLine2 = "Arada",
                City = "Gonder",
                State = "Addis Abeba",
                Country = "Ethiopia",
                PostalCode = "0001",
            };
            addressList.Add(address);
            address = new Address(4) {
                        AddressType = 4,
                        StreetLine1 = "Godner",
                        StreetLine2 = "Arada",
                        City = "Gonder",
                        State = "Addis Abeba",
                        Country = "Ethiopia",
                        PostalCode = "0001",
            };
            return addressList;

        }

        public bool Save(Address address)
        {
            // code that saves the [asssed in address

            return true;
        }
    }
}
