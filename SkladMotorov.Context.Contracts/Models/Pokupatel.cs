using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkladMotorov.Context.Contracts.Models
{
    public class Pokupatel : BaseEntyty
    {
        /// <summary>
        /// Наименование
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Адрес
        /// </summary>
        public string Adres { get; set; } = string.Empty;

        /// <summary>
        /// Номер телефона
        /// </summary>
        public int Number { get; set; }

        /// <summary>
        /// Электронная почта
        /// </summary>
        public string Email { get; set; } = string.Empty;
    }
}
