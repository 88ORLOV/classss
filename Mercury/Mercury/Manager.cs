using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercury
{
    /// <summary>
    /// Данные менеджера, принимающего заявку
    /// </summary>
    public class Manager
    {
        /// <summary>
        /// Фамилия
        /// </summary>
        public string Surname { get; set; }

        /// <summary>
        /// Имя
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Отчество
        /// </summary>
        public string Patronymic { get; set; }

        public override string ToString()
        {
            return $"Фамилия: {Surname}, Имя: {Name}, Отчество: {Patronymic}";
        }
    }
}
