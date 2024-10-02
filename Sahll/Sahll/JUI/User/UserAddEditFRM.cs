using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sahll.JUI.User
{
    public partial class UserAddEditFRM : Form
    {
        public UserAddEditFRM()
        {
            InitializeComponent();
            fillquestions();
            fillroles();
        }

        private void fillroles()
        {
            cmbrole.Items.Add("مدير");
            cmbrole.Items.Add("موظف");
        }

        void fillquestions()
        {
            cmbquestions.Items.Add("اسم أول مدرسة التحقت بها؟");
            cmbquestions.Items.Add("اسم حيوانك الأليف الأول؟");
            cmbquestions.Items.Add("اسم مدينتك المفضلة؟");
            cmbquestions.Items.Add("أفضل صديق لك في الطفولة؟");
            cmbquestions.Items.Add("ما هي مهنة والدتك؟");
            cmbquestions.Items.Add("اسم أول كتاب قرأته؟");
            cmbquestions.Items.Add("طعامك المفضل؟");
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void picuserimage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp" // Optional: Add a filter to show only image files
            };

            var res = openFileDialog.ShowDialog();

            if (res == DialogResult.OK)
            {
                // Load the selected image into the PictureBox
                picuserimage.Image = Image.FromFile(openFileDialog.FileName);
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {


            //JUI
            this.Close();
        }
    }
}
