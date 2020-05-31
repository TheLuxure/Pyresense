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
		//Accessories
		public bool accPharaohsMedallion = false;

		//Debuffs/Buffs
		public bool curseCATsCurse;

		public override void ResetEffects() 
		{
			//Accessories
			accPharaohsMedallion = false;

			//Debuffs/Buffs
			curseCATsCurse = false;
		}

		public override void UpdateDead() {
			curseCATsCurse = false;
		}

		public override void UpdateBadLifeRegen() {
			if (curseCATsCurse) {
				if (player.lifeRegen > 0) {
					player.lifeRegen = 0;
				}
				player.lifeRegenTime = 0;
				player.lifeRegen -= 128;
			}
		}

		public override float UseTimeMultiplier(Item item) {
            return accPharaohsMedallion ? 1f : 1f;
		}
	}
}
