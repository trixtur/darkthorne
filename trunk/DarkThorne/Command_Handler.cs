using System;
using System.Collections.Generic;
using System.Text;

namespace DarkThorne
{
    class Command_Handler
    {
        AlphaUtils.AlphaRichTextBox m_output;
        Driver m_gDriver;

        private void WriteLine(string toWrite)
        {
            m_output.AppendText(toWrite + "\n");
        }

        private void Write(string toWrite)
        {
            m_output.AppendText(toWrite);
        }

        public Command_Handler(AlphaUtils.AlphaRichTextBox ob, Driver d)
        {
            m_output = ob;
            ob.Select();
            m_gDriver = d;
        }

        public void Handle(string command)
        {
            string[] commandString = command.ToLower().Split(' ');
            if (!m_gDriver.Initialized())
            {
                InitResponse(commandString);
                return;
            }
            switch (commandString[0])
            {
                case("help"):
                    WriteLine("You can't be helped!");
                    break;

                case("say"):
                    Write("You say: ");
                    for (int i = 1; i < commandString.Length; i++)
                    {
                        Write(commandString[i] + " ");
                    }
                    WriteLine("");
                    break;

                case("info"):
                    if (commandString.Length > 1)
                        goto default;
                    Write(m_gDriver.GetPlayerInfo());
                    break;

                default:
                    WriteLine("What?");
                    break;
            }
        }

        private void InitResponse( string[] commandString )
        {
            m_gDriver.SetupPlayer(commandString[0]);
            WriteLine(commandString[0]);
            if (m_gDriver.Initialized())
                WriteLine("Hello " + commandString[0]);
        }

        public void SendQuery(string query)
        {
            Write(query);
        }
    }
}
