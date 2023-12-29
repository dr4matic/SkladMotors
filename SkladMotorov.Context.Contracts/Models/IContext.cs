using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkladMotorov.Context.Contracts.Models
{
    public interface IContext
    {
        ICollection<Nakladnaya> Nakladnayas { get; }
        ICollection<Pokupatel> Pokupatels { get; }
        ICollection<Postavshik> Postavshiks { get; }
        ICollection<Motor> Motors { get; }
    }
}
