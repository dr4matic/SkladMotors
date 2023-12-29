using Microsoft.AspNetCore.Mvc;
using SkladMotorov.Context.Contracts.Models;

namespace SkladMotorov.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NakladnayaController : ControllerBase
    {
        private readonly IContext context1;
        public NakladnayaController(IContext context1)
        {
            this.context1 = context1;
        }
        [HttpGet] //localhost:111224/group
        public IActionResult GetAllNakladnaya()
        {
            var nakladnayalist = context1.Nakladnayas.ToList();
            return Ok(nakladnayalist);
        }
        [HttpGet("{id}")]
        public IActionResult Get(Guid id)
        {
            var nakladnayalist = context1.Nakladnayas.FirstOrDefault(x => x.Id == id);
            return Ok(nakladnayalist);
        }
        [HttpPost]
        public IActionResult Create(Nakladnaya model)
        {
            var item = new Nakladnaya
            {
                Id = Guid.NewGuid(),
                Name = model.Name,
                Description = model.Description,
                CreatedAT = DateTime.Now,
                CreatedBy = "Я",
                UpdatedAt = DateTime.Now,
                UpdatedBy = "Я богатырь!"
            };
            context1.Nakladnayas.Add(item);
            return Ok(item);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            var group = context1.Nakladnayas.FirstOrDefault(x => x.Id == id);
            if (group != null)
            {
                context1.Nakladnayas.Remove(group);
            }
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult Edit(Guid Id, Nakladnaya model)
        {
            var group = context1.Nakladnayas.FirstOrDefault(x => x.Id == Id);
            if (group != null)
            {
                return NotFound();
            }
            group.Name = model.Name;
            group.Description = model.Description;
            group.UpdatedAt = DateTime.Now;
            return Ok(group);
        }
    }
}
