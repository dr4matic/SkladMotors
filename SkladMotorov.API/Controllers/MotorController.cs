using Microsoft.AspNetCore.Mvc;
using SkladMotorov.Context.Contracts.Models;

namespace SkladMotorov.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MotorController : ControllerBase
    {
        private readonly IContext context1;
        public MotorController(IContext context1)
        {
            this.context1 = context1;
        }
        [HttpGet] //localhost:111224/group
        public IActionResult GetAllMotor()
        {
            var motorlist = context1.Motors.ToList();
            return Ok(motorlist);
        }
        [HttpGet("{id}")]
        public IActionResult Get(Guid id)
        {
            var motorlist = context1.Motors.FirstOrDefault(x => x.Id == id);
            return Ok(motorlist);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            var group3 = context1.Motors.FirstOrDefault(x => x.Id == id);
            if (group3 != null)
            {
                context1.Motors.Remove(group3);
            }
            return Ok();
        }
        [HttpPost]
        public IActionResult Create(Motor model)
        {
            var item3 = new Motor
            {
                Id = Guid.NewGuid(),
                Name = model.Name,
                Cilindr = model.Cilindr,
                Value = model.Value,
                CreatedAT = DateTime.Now,
                CreatedBy = "Я",
                UpdatedAt = DateTime.Now,
                UpdatedBy = "Я богатырь!"
            };
            context1.Motors.Add(item3);
            return Ok(item3);
        }
        [HttpPut("{id}")]
        public IActionResult Edit(Guid Id, Motor model)
        {
            var group3 = context1.Motors.FirstOrDefault(x => x.Id == Id);
            if (group3 != null)
            {
                return NotFound();
            }
            group3.Name = model.Name;
            group3.Cilindr = model.Cilindr;
            group3.Value = model.Value;
            group3.UpdatedAt = DateTime.Now;
            return Ok(group3);
        }
    }
}
