using capaServiciosBackend.Backend;
using capaServiciosBackend.claseModelos;
using capaServiciosBackend.modelos;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiRestNorthwind.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShippersController : ControllerBase
    {
        // GET: api/<ShippersController>
        [HttpGet]
        public List<Shipper> Get()
        {
            var Shipp = new ShippersSC().GetShippers().ToList();
            return Shipp;
        }

        // GET api/<ShippersController>/5
        [HttpGet("{id}")]
        public Shipper Get(int id)
        {
            return new ShippersSC().GetShipperByID(id);
        }

        // POST api/<ShippersController>
        [HttpPost]
        public void Post([FromBody] ShipperModel newShipper)
        {
            new ShippersSC().addShipper(newShipper);
        }

        // PUT api/<ShippersController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] ShipperModel newShipper)
        {
            new ShippersSC().updateShipperByID(id, newShipper);
        }

        // DELETE api/<ShippersController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            new ShippersSC().deleteShipperByID(id);
        }
    }
}
