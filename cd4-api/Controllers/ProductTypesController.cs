using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using cd4_api.Models;

namespace cd4_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductTypesController : ControllerBase
    {
        private readonly CoreDbContext _context;

        public ProductTypesController(CoreDbContext context)
        {
            _context = context;
        }

        // GET: api/ProductTypes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductType>>> GetProductType()
        {
            return await _context.ProductType.ToListAsync();
        }

        // GET: api/ProductTypes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ProductType>> GetProductType(string id)
        {
            var productType = await _context.ProductType.FindAsync(id);

            if (productType == null)
            {
                return NotFound();
            }

            return productType;
        }

        // PUT: api/ProductTypes/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProductType(string id, ProductType productType)
        {
            if (id != productType.Id)
            {
                return BadRequest();
            }

            _context.Entry(productType).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProductTypeExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/ProductTypes
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<ProductType>> PostProductType(ProductType productType)
        {
            _context.ProductType.Add(productType);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (ProductTypeExists(productType.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetProductType", new { id = productType.Id }, productType);
        }

        // DELETE: api/ProductTypes/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<ProductType>> DeleteProductType(string id)
        {
            var productType = await _context.ProductType.FindAsync(id);
            if (productType == null)
            {
                return NotFound();
            }

            _context.ProductType.Remove(productType);
            await _context.SaveChangesAsync();

            return productType;
        }

        private bool ProductTypeExists(string id)
        {
            return _context.ProductType.Any(e => e.Id == id);
        }
    }
}
