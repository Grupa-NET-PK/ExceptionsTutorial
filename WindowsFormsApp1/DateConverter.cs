using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class DateConverter : Form
    {
        public DateConverter()
        {
            InitializeComponent();
        }

        private void buttonSetDateInCalendar_Click(object sender, EventArgs e)
        {
            // Podając cokolwiek nieprawidłowego jest ryzyko pojawienia się wyjątku.
            // Można go ładnie obsłużyć, ale WinFormy się nie kraszują, gdy nie obsłużymy.
            // Wyświetlone zostanie okno z opcją zakończenia programu lub kontynuacji.
            
            var writtenDate = textBoxUserDate.Text;
            var day = int.Parse(writtenDate.Substring(0, 2));
            var month = int.Parse(writtenDate.Substring(3, 2));
            var year = int.Parse(writtenDate.Substring(6, 4));

            var dateTime = new DateTime(year, month, day);
            dateTimePicker.Value = dateTime;
        }

        private void linkLabelInstruction_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            textBoxUserDate.Select();
        }
    }
}
