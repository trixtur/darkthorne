using System;
using System.Collections.Generic;
using System.Text;

namespace DarkThorne
{
    class Driver
    {
        private player m_player;
        private Command_Handler m_cHandler;

        /// <summary>
        /// Default Constructor
        /// </summary>
        public Driver()
        {
            m_player = new player();
            m_cHandler = null;
        }

        /// <summary>
        /// Give the game driver access to the command handler.
        /// </summary>
        /// <param name="handler">The command handler for writing to the screen.</param>
        public void AddHandler(Command_Handler handler)
        {
            m_cHandler = handler;
            if(!this.Initialized())
            {
                handler.SendQuery("What is your name?");
            }
        }

        public string GetPlayerInfo()
        {
            StringBuilder info = new StringBuilder();
            string tab = "\t\t";
            if (m_player.GetName().Length > 4)
                tab = "\t";
            info.Append("/*************User Info***************/\n");
            info.Append("Name:\t\t" + m_player.GetName() + tab);
            info.Append("Level: \t" +m_player.GetLevel() + "\n");
            info.Append("Health:\t\t" + m_player.GetHealth() + "\t\t");
            info.Append("Mana:\t" + m_player.GetMana() + "\n");
            info.Append("----------------Stats------------------\n");
            info.Append("Intellect:\t" + m_player.GetInellect() + "\t\t");
            info.Append("Strength:\t" + m_player.GetStrength() + "\n");
            info.Append("Agility:\t\t"+m_player.GetAgility() + "\t\t");
            info.Append("Armor:\t\t" + m_player.GetArmorclass() + "\n");
            info.Append("Wisdom:\t\t" + m_player.GetWisdom() + "\t\t\n");
            info.Append("/*************************************/\n");
            return info.ToString();
        }

        public bool Initialized()
        {
            bool init = true;
            if (!m_player.HasName())
                init = false;
            return init;
        }

        public void SetupPlayer(string name)
        {
            m_player.SetName(name);
        }
    }
}
