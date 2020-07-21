using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BankAspCore.Data;
using Domain.Model;

namespace BankAspCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceProvidersController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ServiceProvidersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/ServiceProviders
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ServiceProvider>>> GetServiceProviders()
        {
            return await _context.ServiceProviders.ToListAsync();
        }

        // GET: api/ServiceProviders/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ServiceProvider>> GetServiceProvider(int id)
        {
            var serviceProvider = await _context.ServiceProviders.FindAsync(id);

            if (serviceProvider == null)
            {
                return NotFound();
            }

            return serviceProvider;
        }

        // PUT: api/ServiceProviders/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutServiceProvider(int id, ServiceProvider serviceProvider)
        {
            if (id != serviceProvider.Id)
            {
                return BadRequest();
            }

            _context.Entry(serviceProvider).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ServiceProviderExists(id))
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

        // POST: api/ServiceProviders
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<ServiceProvider>> PostServiceProvider(ServiceProvider serviceProvider)
        {
            _context.ServiceProviders.Add(serviceProvider);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetServiceProvider", new { id = serviceProvider.Id }, serviceProvider);
        }

        // DELETE: api/ServiceProviders/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<ServiceProvider>> DeleteServiceProvider(int id)
        {
            var serviceProvider = await _context.ServiceProviders.FindAsync(id);
            if (serviceProvider == null)
            {
                return NotFound();
            }

            _context.ServiceProviders.Remove(serviceProvider);
            await _context.SaveChangesAsync();

            return serviceProvider;
        }

        private bool ServiceProviderExists(int id)
        {
            return _context.ServiceProviders.Any(e => e.Id == id);
        }
    }
}
