using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Terraria;
using Terraria.DataStructures;
using Terraria.GameInput;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;
using static Terraria.ModLoader.ModContent;

namespace Pyresense
{

	public class PyresensePlayer : ModPlayer
	{
		//Debuffs/Buffs
		public bool cureCurseDebuff;

		public override void ResetEffects() 
		{
			//Debuffs/Buffs
			cureCurseDebuff = false;
		}

		public override void UpdateDead() {
			cureCurseDebuff = false;
		}

		public override void UpdateBadLifeRegen() {
			/*if (cureCurseDebuff) {
				if (player.lifeRegen > 0) {
					player.lifeRegen = 0;
				}
				player.lifeRegenTime = 0;
				player.lifeRegen -= 128;
			}*/
		}
	}
}
