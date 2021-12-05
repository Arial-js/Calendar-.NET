using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using Calendar.Utility;
using Calendar.Classes;

namespace Calendar
{
    public partial class FrmCreateEvent : Form
    {
        public FrmCreateEvent()
        {
            InitializeComponent();
        }

        // in this load I set the TxtDate with the current date that you clicked
        private void FrmCreateEvent_Load(object sender, EventArgs e)
        {
            TxtDate.Text = UserControlDays.static_day + "/" + FrmCalendar.static_month + "/" + FrmCalendar.static_year;
        }

        // this method save the events in the date that you clicked and if he's iterable in the format d/m/yyyy
        private void BtnSaveEvent_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(TxtEvent.Text) | string.IsNullOrEmpty(TxtStart.Text) | string.IsNullOrEmpty(TxtEnd.Text))
                {
                    MessageBox.Show("Compila tutti i campi!");
                }
                if (double.Parse(TxtStart.Text) > 24 || double.Parse(TxtStart.Text) < 0 || double.Parse(TxtEnd.Text) > 24 || double.Parse(TxtEnd.Text) < 0)
                {
                    MessageBox.Show("Inserisci degli orari corretti da 0 a 24");
                }
                else if(!ChkBoxIterable.Checked)
                {

                    DataManagement dataManagement = new DataManagement();
                    dataManagement.OpenConnection();
                    int check = 1;
                    check = Convert.ToInt32(ChkBoxIterable.Checked);
                    dataManagement.CreateEvent(TxtEvent.Text, float.Parse(TxtStart.Text), float.Parse(TxtEnd.Text), TxtDate.Text, check);
                    MessageBox.Show("Nuovo Evento Creato!");
                    dataManagement.CloseConnection();
                    this.Close();
                }
                else
                {
                    DataManagement dataManagement = new DataManagement();
                    dataManagement.OpenConnection();
                    int check = 1;
                    check = Convert.ToInt32(ChkBoxIterable.Checked);
                    for(int i = 0; i <= 5; ++i)
                    {
                        dataManagement.CreateEvent(TxtEvent.Text, float.Parse(TxtStart.Text), float.Parse(TxtEnd.Text), TxtDate.Text, check);
                        DateTime dateTime = new DateTime();
                        TxtDate.Text = dateTime.AddDays(double.Parse(UserControlDays.static_day.ToString())-1).AddMonths(FrmCalendar.static_month - 1).AddYears(FrmCalendar.static_year ++).ToString("d/M/yyyy");
                    }
                    MessageBox.Show("Nuovo Evento Creato!");
                    dataManagement.CloseConnection();
                    this.Close();
                }
            } catch(FormatException ex)
            {
                MessageBox.Show("Errore: Dati inseriti non validi!");
                LogFile.WriteLog(ex.Message + " " + DateTime.Now);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                LogFile.WriteLog(ex.Message + " " + DateTime.Now);
            }
        }
    }
}
