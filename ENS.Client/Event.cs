using ENS_Server_Client_.Domain.Entities;
using System;
using System.Globalization;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace ENS.Client
{
    public partial class Event : Form
    {

        private const string DatePlaceholder = "00/00/2024 00:00:00";


        private HttpClient client = new HttpClient();

        public Event(string ticket)
        {
            InitializeComponent();

            client.BaseAddress = new Uri("https://localhost:7278/");
        }

        private void Event_Load(object sender, EventArgs e)
        {
            TimeBox.Text = DatePlaceholder;
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

        private async void Entbtn_ClickAsync(object sender, EventArgs e)
        {
            DateTimeOffsetJsonConverter date = new DateTimeOffsetJsonConverter();
            var t = TimeBox.Text;
            var text = "05/24/2024 15:31:14";

            var res = DateTime.ParseExact(TimeBox.Text, "MM/dd/yyyy HH:mm:ss", CultureInfo.InvariantCulture);

            try
            {

                var test = new Test4
                {
                    Token = TokenBox.Text,
                    PostedDate = res.ToString("o"),
                    Contacts = textBox1.Text.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries).ToList(),
                    Subject = textBox2.Text,
                    Text = textBox3.Text,
                    Type = (EventType)Enum.Parse(typeof(EventType), textBox4.Text)
                };

                HttpResponseMessage message = await client.PostAsJsonAsync($"https://localhost:7278/api/Event/Create?headerToken={test.Token}", test);
                var error = message.Content.ReadAsStringAsync().Result;
                
            }
            catch (ArgumentException ex)
            {
                // Обработка ошибки, возникшей из-за неверного формата даты и времени.
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
       
    }
 
    public class DateTimeOffsetJsonConverter : JsonConverter<DateTimeOffset>
    {
        public override DateTimeOffset Read(
            ref Utf8JsonReader reader,
            Type typeToConvert,
            JsonSerializerOptions options) =>
            DateTimeOffset.ParseExact(reader.GetString()!,
                "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture);

        public override void Write(
            Utf8JsonWriter writer,
            DateTimeOffset dateTimeValue,
            JsonSerializerOptions options) =>
            writer.WriteStringValue(dateTimeValue.ToString(
                "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture));
    }

    public class Test4
    {
        public string Token { get; set; }
        public string PostedDate { get; set; }
        public List<string> Contacts { get; set; }
        public string Text { get; set; }
        public string Subject { get; set; }
        public EventType Type { get; set; }
    }
}
