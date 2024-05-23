using System;
using System.Globalization;
using System.Windows.Forms;

namespace ENS.Client
{
    public partial class Event : Form
    {
        private readonly string eventTicket;
        private const string DatePlaceholder = "dd.mm.yy hh:mm";

        public Event(string ticket)
        {
            InitializeComponent();
            this.eventTicket = ticket;
        }

        private void Event_Load(object sender, EventArgs e)
        {
            TokenBox.Text = eventTicket;
            TimeBox.Text = DatePlaceholder;
            TimeBox.ForeColor = SystemColors.GrayText;
            TimeBox.GotFocus += RemovePlaceholder;
            TimeBox.LostFocus += ShowPlaceholder;
        }

        private void RemovePlaceholder(object sender, EventArgs e)
        {
            if (TimeBox.Text == DatePlaceholder)
            {
                TimeBox.Text = "";
                TimeBox.ForeColor = SystemColors.WindowText;
            }
        }

        private void ShowPlaceholder(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TimeBox.Text))
            {
                TimeBox.Text = DatePlaceholder;
                TimeBox.ForeColor = SystemColors.GrayText;
            }
        }

        private void Entbtn_Click(object sender, EventArgs e)
        {
            if (IsValidDateTime(TimeBox.Text))
            {
                
            }
            else
            {
                MessageBox.Show("Invalid date and time format. Please use dd.mm.yy hh:mm.");
            }
        }

        private bool IsValidDateTime(string input)
        {
            if (input == DatePlaceholder)
                return false;

            DateTime dateTime;
            return DateTime.TryParseExact(input, "dd.MM.yy HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out dateTime);
        }
    }
}
