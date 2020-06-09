using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;

namespace Presentation
{
    public partial class LearnForm : Form
    {
        LearnModel learn = new LearnModel();

        public LearnForm()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearForm()
        {
            txtAnswer.Clear();
            txtQuestion.Clear();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                learn.InsertQuestion(txtQuestion.Text, txtAnswer.Text);
                MessageBox.Show("Se registro correctamente!");
                ClearForm();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo registrar!");
            }
        }

        private void LearnForm_Load(object sender, EventArgs e)
        {
        }
    }
}
