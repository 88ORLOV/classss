using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercury
{
        /// <summary>
        /// Данные абонента, оставляющего заявку
        /// </summary>
        public class Customer
        {
            

            /// <summary>
            /// Адрес 
            /// </summary>
            public string Adress { get; set; }
            
            /// <summary>
            /// Тарифы
            /// </summary>
            public string Tariffs { get; set; }

            /// <summary>
            /// Дата подключения
            /// </summary>
            public DateTime DateOfApplication { get; set; }

            /// <summary>
            /// Цена
            /// </summary>
            public string Cost { get; set; }

            public override string ToString()
            {
            var db = DateOfApplication.ToLongDateString();
            return $"Адрес: {Adress}, Тарифы: {Tariffs}, Дата подключения: {db}, Цена: {Cost} ";
            }

    }

}
