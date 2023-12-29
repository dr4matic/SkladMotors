using Microsoft.AspNetCore.Mvc;
using SkladMotorov.Context.Contracts.Models;

namespace SkladMotorov.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PokupatelController : ControllerBase
    {
        private readonly IContext context1;
        public PokupatelController(IContext context1)
        {
            this.context1 = context1;
        }
        [HttpGet] //localhost:111224/group
        public IActionResult GetAllPlatelshik()
        {
            var platelshiklist = context1.Pokupatels.ToList();
            return Ok(platelshiklist);
        }
        [HttpGet("{id}")]
        public IActionResult Get(Guid id)
        {
            var platelshiklist = context1.Pokupatels.FirstOrDefault(x => x.Id == id);
            return Ok(platelshiklist);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            var group1 = context1.Postavshiks.FirstOrDefault(x => x.Id == id);
            if (group1 != null)
            {
                context1.Postavshiks.Remove(group1);
            }
            return Ok();
        }
        [HttpPost]
        public IActionResult Create(Pokupatel model)
        {
            var item1 = new Pokupatel
            {
                Id = Guid.NewGuid(),
                Name = model.Name,
                Adres = model.Adres,
                Email = model.Email,
                CreatedAT = DateTime.Now,
                CreatedBy = "Я",
                UpdatedAt = DateTime.Now,
                UpdatedBy = "Я богатырь!"
            };
            context1.Pokupatels.Add(item1);
            return Ok(item1);
        }
        [HttpPut("{id}")]
        public IActionResult Edit(Guid Id, Pokupatel model)
        {
            var group1 = context1.Pokupatels.FirstOrDefault(x => x.Id == Id);
            if (group1 != null)
            {
                return NotFound();
            }
            group1.Name = model.Name;
            group1.Adres = model.Adres;
            group1.Email = model.Email;
            group1.UpdatedAt = DateTime.Now;

            return Ok(group1);
        }
    }
}
