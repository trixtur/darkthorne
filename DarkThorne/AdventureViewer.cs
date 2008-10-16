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
            m_handler = new Command_Handler(m_outputBox);
            m_outputBox.AppendText("Welcome to DarkThorne!\n");
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
            KeysConverter v = new KeysConverter();
            int val = v.Compare(Keys.Enter, e.KeyCode);
            if (val == 0)
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
            if(!e.Alt && !e.Control && !e.Shift)
                m_inputBox.AppendText( ((char)e.KeyData).ToString());
            e.SuppressKeyPress = true;
        }



    }
}