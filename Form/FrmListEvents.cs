using System;
using System.Windows.Forms;
using Calendar.Utility;
using Calendar.Classes;

namespace Calendar
{
    public partial class FrmListEvents : Form
    {
        private int ID; // ID needed when you delete a record
        private string name;
        private double start;
        private double end;
        private int iterable;

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
                DgListEvents.DataSource = dataManagement.ShowListEvents(UserControlDays.Static_day + "/" + FrmCalendar.Static_month + "/" + FrmCalendar.Static_year);
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
                LogFile.WriteLog(ex.Message + " " + DateTime.Now);
            }

        }

        // This method allows you to get id from the datagridview when you click on the row
        private void DgListEvents_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                ID = Convert.ToInt32(DgListEvents.Rows[e.RowIndex].Cells[0].Value.ToString());
                name = DgListEvents.Rows[e.RowIndex].Cells[1].Value.ToString();
                start = Convert.ToDouble(DgListEvents.Rows[e.RowIndex].Cells[3].Value.ToString());
                end = Convert.ToDouble(DgListEvents.Rows[e.RowIndex].Cells[4].Value.ToString());
                iterable = Convert.ToInt32(DgListEvents.Rows[e.RowIndex].Cells[5].Value.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Console.WriteLine(ex.Message);
                LogFile.WriteLog(ex.Message + " " + DateTime.Now);
            }
        }

        /* This method allows you to get id from the datagridview when you click on cell
         * Check https://www.c-sharpcorner.com/UploadFile/1e050f/insert-update-and-delete-record-in-datagridview-C-Sharp/
         */
        private void DgListEvents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DgListEvents.Rows[e.RowIndex].Cells[2].ReadOnly = true;
                DgListEvents.Rows[e.RowIndex].Cells[5].ReadOnly = true;
                ID = Convert.ToInt32(DgListEvents.Rows[e.RowIndex].Cells[0].Value.ToString());
                name = DgListEvents.Rows[e.RowIndex].Cells[1].Value.ToString();
                start = Convert.ToDouble(DgListEvents.Rows[e.RowIndex].Cells[3].Value.ToString());
                end = Convert.ToDouble(DgListEvents.Rows[e.RowIndex].Cells[4].Value.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                LogFile.WriteLog(ex.Message + " " + DateTime.Now);
            }
        }

        // This method UPDATE the cell after you edit it, you can edit all cells but date and ofc id
        // https://www.codegrepper.com/code-examples/whatever/get+cell+value+on+cellvaluechanged+c%23+datagridview
        private void DgListEvents_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataManagement dataManagement = new DataManagement();
                dataManagement.OpenConnection();
                ID = Convert.ToInt32(DgListEvents.Rows[e.RowIndex].Cells[0].Value.ToString());
                name = DgListEvents.Rows[e.RowIndex].Cells[1].Value.ToString();
                start = Convert.ToDouble(DgListEvents.Rows[e.RowIndex].Cells[3].Value.ToString());
                end = Convert.ToDouble(DgListEvents.Rows[e.RowIndex].Cells[4].Value.ToString());
                iterable = Convert.ToInt32(DgListEvents.Rows[e.RowIndex].Cells[5].Value.ToString());
                dataManagement.UpdateEvent(ID, name, start, end, iterable);
                dataManagement.ShowListEvents(UserControlDays.Static_day + "/" + FrmCalendar.Static_month + "/" + FrmCalendar.Static_year);


                dataManagement.CloseConnection();
            }
            catch(FormatException ex)
            {
                MessageBox.Show("Errore: Formato non supportato!");
                LogFile.WriteLog(ex.Message + " " + DateTime.Now);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore: " + ex.Message);
                LogFile.WriteLog(ex.Message + " " + DateTime.Now);
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
                DgListEvents.DataSource = dataManagement.ShowListEvents(UserControlDays.Static_day + "/" + FrmCalendar.Static_month + "/" + FrmCalendar.Static_year);
                dataManagement.CloseConnection();
            } catch(Exception ex)
            {
                MessageBox.Show("Problema: " + ex.Message);
                LogFile.WriteLog(ex.Message + " " + DateTime.Now);
            }
        }
    }
}
