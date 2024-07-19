using System.Configuration;
using System.Data;

namespace ComponentsDB
{
    public partial class Form1 : Form
    {
        private Component? Component;

        public Form1()
        {
            InitializeComponent();
        }

        private void ShowData(DataSet dataSet)
        {
            DataGridView.DataSource = dataSet.Tables[0];
        }

        private bool IsThisCmpSNumberExist(string cmpSNumber)
        {
            foreach (DataGridViewRow row in DataGridView.Rows)
            {
                if (row.Cells[1].Value != null && string.Equals(cmpSNumber, row.Cells[1].Value.ToString()))
                {
                    return true;
                }
            }
            return false;
        }

        private SComponent FillSComponent()
        {
            SComponent sComponent = new SComponent();

            sComponent.ObjectName = ObjectNameTextBox.Text;
            sComponent.CMPSerialNumber = SerialNumberTextBox.Text;
            try
            {
                sComponent.ProductionDate = DateTime.Parse(ProdDateTextBox.Text);
            }
            catch
            {
                MessageBox.Show("Неправильный формат даты");
            }
            sComponent.PNR = PNRTextBox.Text;
            sComponent.SoftwareVersion = SoftVersionTextBox.Text;
            sComponent.HardwareVersion = HardVersionTextBox.Text;
            sComponent.IEMSerialNumber = SNumberIEMTextBox.Text;
            sComponent.Notes = Notes.Text;

            return sComponent;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string connetcionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=" + Directory.GetCurrentDirectory() + "\\DataBase.mdf;Integrated Security=False;";
            Component = new Component();

            if (Component.ConnectToDataBase(connetcionString))
            {
                MessageBox.Show("Подключение выполнено успешно");
                ShowData(Component.GetData());
            }
            else
            {
                throw new Exception("Не удалось подключиться к базе данных");
            }

            LogIn logIn = new LogIn(Component.GetConnection());
            logIn.ShowDialog();

            if (logIn.IsClosed && !logIn.IsLoggedIn)
            {
                Close();
            }
        }

        private void AddDataBtn_Click(object sender, EventArgs e)
        {
            if (ObjectNameTextBox.Text.Length > 0 && SerialNumberTextBox.Text.Length > 0 && ProdDateTextBox.Text.Length > 0 && PNRTextBox.Text.Length > 0
                && SoftVersionTextBox.Text.Length > 0 && HardVersionTextBox.Text.Length > 0 && SNumberIEMTextBox.Text.Length > 0)
            {
                if (IsThisCmpSNumberExist(SerialNumberTextBox.Text))
                {
                    MessageBox.Show("Компонент с таким же серийным номером уже существует в базе");
                    return;
                }
                SComponent sComponent = FillSComponent();
                Component.AddData(sComponent);
                ShowData(Component.GetData());
            }
            else
            {
                MessageBox.Show("Для занесения данных в базу все текстовые поля должны быть заполнены");
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (DataGridView.SelectedRows.Count > 0)
            {
                Component.DeleteData(DataGridView.SelectedRows[0].Cells[1].Value.ToString());
                DataGridView.ClearSelection();
                ShowData(Component.GetData());
            }
            else
            {
                MessageBox.Show("Не выбрана строка");
            }
        }

        private void FindBtn_Click(object sender, EventArgs e)
        {
            string serialNumber = InputSNumber.Text;
            int numOfString = 1;

            foreach (DataGridViewRow row in DataGridView.Rows)
            {
                if (row.Cells[1].Value != null && string.Equals(serialNumber, row.Cells[1].Value.ToString()))
                {
                    MessageBox.Show($"Компонент с данным серийным номером содержится в строке: {numOfString}");
                    return;
                }
                numOfString++;
            }
            MessageBox.Show("Компонента с данным серийным номером нет в базе");
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (ObjectNameTextBox.Text.Length > 0 && SerialNumberTextBox.Text.Length > 0 && ProdDateTextBox.Text.Length > 0 && PNRTextBox.Text.Length > 0
                && SoftVersionTextBox.Text.Length > 0 && HardVersionTextBox.Text.Length > 0 && SNumberIEMTextBox.Text.Length > 0)
            {
                if (!IsThisCmpSNumberExist(SerialNumberTextBox.Text))
                {
                    MessageBox.Show("Компонента с данным серийным номером нет в базе");
                    return;
                }
                SComponent sComponent = FillSComponent();
                Component.UpdateData(sComponent);
                ShowData(Component.GetData());
            }
            else
            {
                MessageBox.Show("Для занесения данных в базу все текстовые поля должны быть заполнены");
            }
        }

        private void SortBtn_Click(object sender, EventArgs e)
        {
            if (ObjectNameRadioBtn.Checked)
            {
                ShowData(Component.OrderBy("object_name"));
            }
            else if (SNumberCmpRadioBtn.Checked)
            {
                ShowData(Component.OrderBy("cmp_serial_number"));
            }
            else if (ProdDateRadioBtn.Checked)
            {
                ShowData(Component.OrderBy("production_date"));
            }
            else if (PNRRadioBtn.Checked)
            {
                ShowData(Component.OrderBy("PNR"));
            }
            else if (SoftVersionRadioBtn.Checked)
            {
                ShowData(Component.OrderBy("software_version"));
            }
            else if (HardVersionRadioBtn.Checked)
            {
                ShowData(Component.OrderBy("hardware_version"));
            }
            else if (SNumIEMRadioBtn.Checked)
            {
                ShowData(Component.OrderBy("iem_serial_number"));
            }
            else
            {
                MessageBox.Show("Не выбрано свойство компонента");
            }
        }
    }
}