using System;
using System.Collections.Generic;
using System.Text;

namespace DarkThorne
{
    class Command_Handler
    {
        AlphaUtils.AlphaRichTextBox m_output;

        private void Write(string toWrite)
        {
            m_output.AppendText(toWrite + "\n");
        }

        public Command_Handler(AlphaUtils.AlphaRichTextBox ob)
        {
            m_output = ob;
            ob.Select();
        }

        public void Handle(string command)
        {
            switch(command.ToLower())
            {
                case("help"):
                    Write("You can't be helped!");
                    break;

                default:
                    Write("What?");
                    break;
            }
        }
    }
}
