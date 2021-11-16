using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Calendar.Utility;

namespace Calendar
{
    public partial class FrmListEvents : Form
    {
        public FrmListEvents()
        {
            InitializeComponent();
        }

        private void FrmListEvents_Load(object sender, EventArgs e)
        {
            try
            {
                DataManagement dataManagement = new DataManagement();
                dataManagement.OpenConnection();
                DgListEvents.DataSource = dataManagement.ShowListEvents(UserControlDays.static_day + "/" + FrmCalendar.static_month + "/" + FrmCalendar.static_year);
                DgListEvents.Columns[0].Visible = false;
                DgListEvents.Columns[1].Width = 180;
                DgListEvents.Columns[1].HeaderText = "Nome";
                DgListEvents.Columns[2].HeaderText = "Data";
                DgListEvents.Columns[3].HeaderText = "Inizio";
                DgListEvents.Columns[4].HeaderText = "Fine";
                DgListEvents.Columns[5].HeaderText = "Sempre Attivo";
                dataManagement.CloseConnection();
            } catch(Exception ex)
            {
                MessageBox.Show("Problema: " + ex.Message);
            }

        }

        /* https://www.c-sharpcorner.com/UploadFile/1e050f/insert-update-and-delete-record-in-datagridview-C-Sharp/
         * https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.datagridview.selectionchanged?view=windowsdesktop-5.0
         */
        private void DgListEvents_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            DataManagement dataManagement = new DataManagement();
            dataManagement.OpenConnection();
            //DgListEvents.Rows[e.RowIndex].SetValues(dataManagement.UpdateEventName());
        }

        private int ID; // ID needed when you delete a record

        // This method allows you to get id from the datagridview when you click on the row
        private void DgListEvents_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                ID = Convert.ToInt32(DgListEvents.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        // This method allows you to get id from the datagridview when you click on cell
        private void DgListEvents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                ID = Convert.ToInt32(DgListEvents.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        // This method is for the button Delete
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DataManagement dataManagement = new DataManagement();
                dataManagement.OpenConnection();
                dataManagement.DeleteEvent(ID);
                MessageBox.Show("Evento eliminato correttamente");
                DgListEvents.DataSource = dataManagement.ShowListEvents(UserControlDays.static_day + "/" + FrmCalendar.static_month + "/" + FrmCalendar.static_year);
                dataManagement.CloseConnection();
            } catch(Exception ex)
            {
                MessageBox.Show("Problema: " + ex.Message);
            }
        }
    }
}
