using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace ComponentsDB
{
    /// <summary>
    /// Содержит функционал базы данных для компонента
    /// </summary>
    internal class Component
    {
        private SqlConnection? SqlConnection = null;

        /// <summary>
        /// Получает подключение к базе данных
        /// </summary>
        /// <returns>SqlConnection</returns>
        public SqlConnection? GetConnection()
        {
            try
            {
                return SqlConnection;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        private void ExecuteCommand(string command, SComponent sComponent)
        {
            SqlCommand sqlCommand = new SqlCommand(command, SqlConnection);

            sqlCommand.Parameters.AddWithValue("object_name", sComponent.ObjectName);
            sqlCommand.Parameters.AddWithValue("cmp_serial_number", sComponent.CMPSerialNumber);
            sqlCommand.Parameters.AddWithValue("production_date", $"{sComponent.ProductionDate.Year}.{sComponent.ProductionDate.Month}.{sComponent.ProductionDate.Day}");
            sqlCommand.Parameters.AddWithValue("PNR", sComponent.PNR);
            sqlCommand.Parameters.AddWithValue("software_version", sComponent.SoftwareVersion);
            sqlCommand.Parameters.AddWithValue("hardware_version", sComponent.HardwareVersion);
            sqlCommand.Parameters.AddWithValue("iem_serial_number", sComponent.IEMSerialNumber);
            sqlCommand.Parameters.AddWithValue("notes", sComponent.Notes);

            sqlCommand.ExecuteNonQuery();
        }

        private DataSet GetDataSet(string command)
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command, SqlConnection);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);
            return dataSet;
        }

        /// <summary>
        /// Подключение к базе данных
        /// </summary>
        /// <param name="connectionString"></param>
        /// <returns>true, если подключение выполнено успешно, иначе false</returns>
        public bool ConnectToDataBase(string connectionString)
        {
            SqlConnection = new SqlConnection(connectionString);
            SqlConnection.Open();

            if (SqlConnection.State == ConnectionState.Open)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Добавляет данные в таблицу Component
        /// </summary>
        /// <param name="sComponent"></param>
        public void AddData(SComponent sComponent)
        {
            string command = "INSERT INTO [Component] (object_name, cmp_serial_number, production_date, PNR, software_version, hardware_version, iem_serial_number, notes) VALUES (@object_name, @cmp_serial_number, @production_date, @PNR, @software_version, @hardware_version, @iem_serial_number, @notes)";
            ExecuteCommand(command, sComponent);
        }

        /// <summary>
        /// Возвращает все данные таблицы Component
        /// </summary>
        /// <returns>DataSet</returns>
        public DataSet GetData()
        {
            string command = "SELECT * FROM [Component]";
            return GetDataSet(command);
        }

        /// <summary>
        /// Удаляет данные из таблицы Component
        /// </summary>
        /// <param name="cmpSerialNumber"></param>
        public void DeleteData(string cmpSerialNumber)
        {
            string command = $"DELETE FROM [Component] WHERE cmp_serial_number = @cmpSerialNumber";
            SqlCommand sqlCommand = new SqlCommand(command, SqlConnection);
            sqlCommand.Parameters.AddWithValue("cmpSerialNumber", cmpSerialNumber);
            sqlCommand.ExecuteNonQuery();
        }

        /// <summary>
        /// Обновляет данные в таблице Component
        /// </summary>
        /// <param name="sComponent"></param>
        public void UpdateData(SComponent sComponent)
        {
            string command = "UPDATE [Component] SET object_name = @object_name, cmp_serial_number = @cmp_serial_number, production_date = @production_date, PNR = @PNR, software_version = @software_version, hardware_version = @hardware_version, iem_serial_number = @iem_serial_number, notes = @notes WHERE cmp_serial_number = @cmp_serial_number";
            ExecuteCommand(command, sComponent);
        }

        /// <summary>
        /// Сортирует данные в таблице по указанному столбцу
        /// </summary>
        /// <param name="column"></param>
        public DataSet OrderBy(string column)
        {
            string command = "SELECT * FROM [Component] ORDER BY " + column;
            return GetDataSet(command);
        }
    }
}