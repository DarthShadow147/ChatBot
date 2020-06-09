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
    public partial class ChatUI : Form
    {
        SearchAnswerModel answer = new SearchAnswerModel();
        string respuesta;

        public ChatUI()
        {
            InitializeComponent();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void chatbox1_Load(object sender, EventArgs e)
        {
        }

        private void btnLearn_Click(object sender, EventArgs e)
        {
            var ULearForm = new LearnForm();
            ULearForm.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearTxt()
        {
            EnterText.Clear();
        }

        private void appendOutputUser()
        {
            ChatHistory.AppendText("Usted: " + EnterText.Text + "\r\n");
        }

        private void appendOutputHermes()
        {
            ChatHistory.AppendText("Hermes: " + respuesta + "\r\n");
        }

        private void BtnSend_Click(object sender, EventArgs e)
        {
            try
            {
                appendOutputUser();
                respuesta = answer.SearchAnswer(EnterText.Text);
                appendOutputHermes();
                ClearTxt();
            }
            catch (Exception ex)
            {
            }
        }

        private void ChatUI_Load(object sender, EventArgs e)
        {
        }
    }
}
