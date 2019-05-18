using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercury
{
    public class Information
    {
        /// <summary>
        /// Номер телефона
        /// </summary>
        public string Phonenumber { get; set; }

        /// <summary>
        /// ФИО клиента
        /// </summary>
        public string SNP { get; set; }

        /// <summary>
        /// Фотография
        /// </summary>
        public byte[] Photo { get; set; }

        /// <summary>
        /// Менеджеры
        /// </summary>
        public List<Manager> Manager { get; set; }

        /// <summary>
        /// Заявки
        /// </summary>
        public List<Customer> Customer { get; set; }
    }
}
