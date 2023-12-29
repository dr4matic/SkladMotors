using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkladMotorov.Context.Contracts.Models
{
    public class Motor : BaseEntyty
    {
        /// <summary>
        /// Наименование товара
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Кол-во цилиндров
        /// </summary>
        public int Cilindr { get; set; }

        /// <summary>
        /// Количество
        /// </summary>
        public int Value { get; set; }
    }
}
