using Pyresense.Items.Dev.CAT;
using System;
using System.Collections.Generic;
using System.Messaging;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;
using Terraria.Graphics.Shaders;
using System.IO;
using Microsoft.Xna.Framework;
using Terraria.UI;
using Microsoft.Xna.Framework.Graphics;
using static Terraria.ModLoader.ModContent;

namespace Pyresense.Items.Dev.CAT
{
	// Ethereal Flames is an example of a buff that causes constant loss of life.
	// See ExamplePlayer.UpdateBadLifeRegen and ExampleGlobalNPC.UpdateLifeRegen for more information.
	public class CATsCurse : ModBuff
	{
		public override void SetDefaults() {
			DisplayName.SetDefault("CAT's Curse");
			Description.SetDefault("You are cursed by CAT's Curse");
			Main.debuff[Type] = true;
			Main.pvpBuff[Type] = true;
			longerExpertDebuff = true;
		}

		public override void Update(Player player, ref int buffIndex) {
			player.GetModPlayer<PyresensePlayer>().curseCATsCurse = true;
		}

		public override void Update(NPC npc, ref int buffIndex) {
			npc.GetGlobalNPC<PyresenseGlobalNPC>().curseCATsCurse = true;
		}
	}
}
