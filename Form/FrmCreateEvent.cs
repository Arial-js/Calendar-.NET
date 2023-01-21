using System;
using System.Windows.Forms;
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
            TxtDate.Text = UserControlDays.Static_day + "/" + FrmCalendar.Static_month + "/" + FrmCalendar.Static_year;
        }

        // this method save the events in the date that you clicked and if he's iterable in the format d/m/yyyy
        private void BtnSaveEvent_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(TxtEvent.Text) || string.IsNullOrEmpty(TxtStart.Text) || string.IsNullOrEmpty(TxtEnd.Text))
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
                        TxtDate.Text = dateTime.AddDays(double.Parse(UserControlDays.Static_day.ToString())-1).AddMonths(FrmCalendar.Static_month - 1).AddYears(FrmCalendar.Static_year ++).ToString("d/M/yyyy");
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
