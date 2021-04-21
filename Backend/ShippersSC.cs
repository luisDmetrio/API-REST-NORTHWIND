using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaServiciosBackend.claseModelos;
using capaServiciosBackend.modelos;

namespace capaServiciosBackend.Backend
{
    public class ShippersSC
    {
        public NorthwindContext dbContex = new NorthwindContext();

        public IQueryable<Shipper> GetShippers()
        {
            return dbContex.Shippers.AsQueryable();
        }

        public Shipper GetShipperByID(int id)
        {
            return GetShippers().Where(x => x.ShipperId == id).FirstOrDefault();
        }

        public void deleteShipperByID(int id)
        {
            dbContex.Remove(GetShipperByID(id));
            dbContex.SaveChanges();
        }

        public void addShipper(ShipperModel newShipper)
        {
            var addShipper = new Shipper();
            addShipper.CompanyName = newShipper.nombre;
            dbContex.Add(addShipper);
            dbContex.SaveChanges();
        }

        public void updateShipperByID(int id, ShipperModel newShipper)
        {
            var updateShipper = GetShipperByID(id);
            updateShipper.CompanyName = newShipper.nombre;
            dbContex.SaveChanges();
        }

    }
}
