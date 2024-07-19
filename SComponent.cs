using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComponentsDB
{
    /// <summary>
    /// Структура для описания таблицы компонента
    /// </summary>
    internal struct SComponent
    {
        /// <summary>
        /// Наименование объекта, на который поставляется компонент
        /// </summary>
        public string ObjectName;

        /// <summary>
        /// Серийный номер компонента
        /// </summary>
        public string CMPSerialNumber;

        /// <summary>
        /// Дата производства
        /// </summary>
        public DateTime ProductionDate;

        /// <summary>
        /// PNR
        /// </summary>
        public string PNR;

        /// <summary>
        /// Версия ПО
        /// </summary>
        public string SoftwareVersion;

        /// <summary>
        /// Версия АО
        /// </summary>
        public string HardwareVersion;

        /// <summary>
        /// Серийный номер входящих электронных модулей
        /// </summary>
        public string IEMSerialNumber;

        /// <summary>
        /// Особые отметки (примечания)
        /// </summary>
        public string Notes;
    }
}