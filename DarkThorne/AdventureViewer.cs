using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DarkThorne
{
    public partial class AdventureViewer : Form
    {
        Command_Handler m_handler;
        private void AdventureViewer_Load(object sender, EventArgs e)
        {
            m_outputBox.AppendText("Welcome to DarkThorne!\n");
            m_handler = new Command_Handler(m_outputBox);
        }

        public AdventureViewer()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void m_inputBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                //m_outputBox.AppendText(m_inputBox.Text + "\n");
                m_handler.Handle(m_inputBox.Text);
                m_outputBox.Select();
                m_inputBox.Text = string.Empty;
                e.SuppressKeyPress = true;
            }
        }

        private void m_outputBox_KeyDown(object sender, KeyEventArgs e)
        {
            m_inputBox.Focus();
            if(!e.Alt && !e.Control && !e.Shift && !(e.KeyData == Keys.Back))
                m_inputBox.AppendText( ((char)e.KeyData).ToString());
            e.SuppressKeyPress = true;
        }



    }
}