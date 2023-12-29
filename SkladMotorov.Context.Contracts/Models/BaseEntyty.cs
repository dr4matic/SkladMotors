using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkladMotorov.Context.Contracts.Models
{
    public abstract class BaseEntyty
    {
        /// <summary>
        /// Индентификатор
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Когда создан
        /// </summary>
        public DateTimeOffset CreatedAT { get; set; }

        /// <summary>
        /// Кем создан
        /// </summary>
        public string CreatedBy { get; set; } = string.Empty;

        /// <summary>
        /// Когда изменён
        /// </summary>
        public DateTimeOffset UpdatedAt { get; set; }

        /// <summary>
        /// Кем изменён
        /// </summary>
        public string UpdatedBy { get; set; } = string.Empty;

        /// <summary>
        /// Дата удаления
        /// </summary>
        public DateTimeOffset? DeletedAt { get; set; }
    }
}
