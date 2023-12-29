using SkladMotorov.Context.Contracts.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkladMotorov.Context
{
    public class SVContext : IContext
    {
        private ICollection<Nakladnaya> nakladnayas;
        private ICollection<Pokupatel> pokupatels;
        private ICollection<Postavshik> postavshiks;
        private ICollection<Motor> motors;

        public SVContext()
        {
            nakladnayas = new HashSet<Nakladnaya>();
            pokupatels = new HashSet<Pokupatel>();
            postavshiks = new HashSet<Postavshik>();
            motors = new HashSet<Motor>();
            Seed();
        }
        public ICollection<Nakladnaya> Nakladnayas => nakladnayas;

        public ICollection<Pokupatel> Pokupatels => pokupatels;

        public ICollection<Postavshik> Postavshiks => postavshiks;

        public ICollection<Motor> Motors => motors;


        private void Seed()
        {
            Nakladnayas.Add(new Nakladnaya
            {
                Id = Guid.NewGuid(),
                Name = "ОАО Цикада",
                Description = "Накладная № 123434234, ИНН 1343167286, КПП 1133322, Адрес покупателя: Чернобыль"
            });
            Nakladnayas.Add(new Nakladnaya
            {
                Id = Guid.NewGuid(),
                Name = "Дикси",
                Description = "Накладная № 123434234, ИНН 1221122212, КПП 1134552, Адрес покупателя: Сингапур"
            });
            Pokupatels.Add(new Pokupatel
            {
                Id = Guid.NewGuid(),
                Name = "Павленко Илья Евгеньевич",
                Number = 799102950,
                Adres = "Санкт-Петербург, ул. Тореза 40",
                Email = "Getero@mail.ru"
            });
            Pokupatels.Add(new Pokupatel
            {
                Id = Guid.NewGuid(),
                Name = "Рукенглаз Андрей Алексеевич",
                Number = 793221122,
                Adres = "Москва, ул. Гоголя 20",
                Email = "Gay@mail.ru"
            });
            Postavshiks.Add(new Postavshik
            {
                Id = Guid.NewGuid(),
                Email = "maga@mail.ru",
                Name = "Магамед Мага Магамедович",
                Adres = "Австралия, Жинь-Шинь 21",
                Index = 222233,
                Inn = 123132131,
                RS = 464563362
            });
            Postavshiks.Add(new Postavshik
            {
                Id = Guid.NewGuid(),
                Email = "shtorm@mail.ru",
                Name = "Джонсон Джексон Шторм",
                Adres = "Китай, Хуй-Вынь",
                Index = 543523,
                Inn = 23434341,
                RS = 213125487
            });
            Motors.Add(new Motor
            {
                Id = Guid.NewGuid(),
                Name = "BMW S85",
                Cilindr = 5,
                Value = 35
            });
            Motors.Add(new Motor
            {
                Id = Guid.NewGuid(),
                Name = "Audio R8 V8",
                Cilindr = 1000,
                Value = 2
            });
        }
    }
}
