using PWS_6;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PWS_6_Client
{
    public partial class Form1 : Form
    {
        WSCAVModel.WSCAVEntities1 wSCAVEntities;
        public Form1()
        {
            wSCAVEntities = new WSCAVModel.WSCAVEntities1(new Uri("https://localhost:44357/WcfDataService1.svc/"));

            InitializeComponent();
        }

        private void getStudents_Click(object sender, EventArgs e)
        {
            result.Text = "";
            foreach (var student in wSCAVEntities.Students.AsEnumerable())
            {
                result.Text += string.Format("Student: '{0}' (id:{1})\n", student.Name, student.Id);
            }
        }

        private void getNotes_Click(object sender, EventArgs e)
        {
            var notes = wSCAVEntities.Notes.Where(n => n.Note1 >= 4).ToList();

            result.Text = "";
            foreach (var note in notes)
            {
                result.Text += string.Format("Note: {0} on exam {1} (id student:{2})\n", note.Note1, note.Subj, note.Id);
            }
        }
    }
}
