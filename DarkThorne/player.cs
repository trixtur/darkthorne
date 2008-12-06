// player.cs created with MonoDevelop
// User: drox at 2:59 PM 12/5/2008
//
// To change standard headers go to Edit->Preferences->Coding->Standard Headers
//

using System;

namespace DarkThorne
{
	
	
	public class player
	{
		private string player_name;
		private int player_level;
		private int player_strength;
		private int player_intellect;
		private int player_constitution;
		private int player_wisdom;
		private int player_armorclass;
		private int player_agility;
		private int player_health;
		private int player_mana;
		
		public player()
		{
			this.player_name = string.Empty;
			this.player_intellect = 0;
			this.player_level = 0;
			this.player_strength = 0;
			this.player_agility = 0;
			this.player_armorclass = 0;
			this.player_constitution = 0;
			this.player_health = 100;
			this.player_mana = 50;
			this.player_wisdom = 0;
		}
		
		public player( string name, int intellect, int level, int strength)
		{
			this.player_name = name;
			this.player_intellect = intellect;
			this.player_level = level;
			this.player_strength = strength;
			this.player_agility = 0;
			this.player_armorclass = 0;
			this.player_constitution = 0;
			this.player_health = 100;
			this.player_mana = 50;
			this.player_wisdom = 0;
		}
		
		public void SetLevel( int level)
		{
			this.player_level = level;
		}
		
		public int GetLevel()
		{
			return this.player_level;
		}
		public void SetName(string name)
		{
			this.player_name = name;
		}
		public string GetName()
		{
			return this.player_name;
		}
		public void SetIntellect(int intellect)
		{
			this.player_intellect = intellect;
		}
		public int GetInellect()
		{
			return this.player_intellect;
		}
		public void SetStrength(int strength)
		{
			this.player_strength = strength;
		}
		public int GetStrength()
		{
			return this.player_strength;
		}
		public void SetAgility(int agility)
		{
			this.player_agility = agility;
		}
		public int GetAgility()
		{
			return this.player_agility;
		}
		public void SetArmorclass(int armorclass)
		{
			this.player_armorclass = armorclass;
		}
		public int GetArmorclass()
		{
			return this.player_armorclass;
		}
		public void SetConstitution(int constitution)
		{
			this.player_constitution = constitution;
		}
		public int GetConstitution()
		{
			return this.player_constitution;
		}
		public void SetHealth(int health)
		{
			this.player_health = health;
		}
		public int GetHealth()
		{
			return this.player_health;
		}
		public void SetMana(int mana)
		{
			this.player_mana = mana;
		}
		public int GetMana()
		{
			return this.player_mana;
		}
		public void SetWisdom(int wisdom)
		{
			this.player_wisdom = wisdom;
		}
		public int GetWisdom()
		{
			return this.player_wisdom;
		}
	}
}