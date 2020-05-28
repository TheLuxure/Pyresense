using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Pyresense.NPCs.Town
{
	// [AutoloadHead] and npc.townNPC are extremely important and absolutely both necessary for any Town NPC to work at all.
	[AutoloadHead]
	public class Alchemist : ModNPC
	{
		private bool shopRecycle;

		public override string Texture => "Pyresense/NPCs/Town/Alchemist";

		//public override string[] AltTextures => new[] { "Pyresense/NPCs/Alchemist_Alt_1" };

		public override bool Autoload(ref string name) {
			name = "Alchemist";
			return mod.Properties.Autoload;
		}

		public override void SetStaticDefaults() {
			// DisplayName automatically assigned from .lang files, but the commented line below is the normal approach.
			// DisplayName.SetDefault("Example Person");
			Main.npcFrameCount[npc.type] = 25;
			NPCID.Sets.ExtraFramesCount[npc.type] = 9;
			NPCID.Sets.AttackFrameCount[npc.type] = 4;
			NPCID.Sets.DangerDetectRange[npc.type] = 700;
			NPCID.Sets.AttackType[npc.type] = 0;
			NPCID.Sets.AttackTime[npc.type] = 45;
			NPCID.Sets.AttackAverageChance[npc.type] = 15;
			NPCID.Sets.HatOffsetY[npc.type] = 4;
		}

		public override void SetDefaults() {
			npc.townNPC = true;
			npc.friendly = true;
			npc.width = 18;
			npc.height = 40;
			npc.aiStyle = 7;
			npc.damage = 10;
			npc.defense = 15;
			npc.lifeMax = 250;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath1;
			npc.knockBackResist = 0.5f;
			animationType = NPCID.Guide;
		}

		public override bool CanTownNPCSpawn(int numTownNPCs, int money) {
			for (int k = 0; k < 255; k++) {
				Player player = Main.player[k];
				if (!player.active) {
					continue;
				}

				foreach (Item item in player.inventory) {
					if (item.type == 2344 || item.type == 303 || item.type == 300 || item.type == 2325 || item.type == 2324 || item.type == 2326 ||
						item.type == 2329 || item.type == 2346 || item.type == 295 || item.type == 2354 || item.type == 2327 || item.type == 291 ||
						item.type == 305 || item.type == 2326 || item.type == 2323 || item.type == 304 || item.type == 2348 || item.type == 297 ||
						item.type == 292 || item.type == 2345 || item.type == 2352 || item.type == 294 || item.type == 293 || item.type == 2322 ||
						item.type == 299 || item.type == 288 || item.type == 2347 || item.type == 289 || item.type == 298 || item.type == 2355 ||
						item.type == 296 || item.type == 2353 || item.type == 2328 || item.type == 290 || item.type == 301 || item.type == 2326 ||
						item.type == 2359 || item.type == 302 || item.type == 2349) {
						return true;
					}
				}
			}
			return false;
		}

		public override string TownNPCName() {
			switch (WorldGen.genRand.Next(5)) {
				case 0:
					return "Mol";
				case 1:
					return "Vin";
				case 2:
					return "Van";
				case 3:
					return "Mist";
				default:
					return "Alchem";
			}
		}

		public override void FindFrame(int frameHeight) {
			/*npc.frame.Width = 40;
			if (((int)Main.time / 10) % 2 == 0)
			{
				npc.frame.X = 40;
			}
			else
			{
				npc.frame.X = 0;
			}*/
		}

		public override string GetChat() {
			switch (Main.rand.Next(2)) {
				case 0:
					return "...";
				default:
					return "... What?";
			}
		}

		public override void SetChatButtons(ref string button, ref string button2) {
			button = "Potion-"+ Language.GetTextValue("LegacyInterface.28");
			button2 = "Random " + Language.GetTextValue("LegacyInterface.28");
		}
		public override void OnChatButtonClicked(bool firstButton, ref bool shop)
		{
			shop = true;
			((Alchemist)mod.GetNPC(Name)).shopRecycle = !firstButton;
		}
		public override void SetupShop(Chest shop, ref int nextSlot) {
			if (shopRecycle) {
				if (Main.rand.NextBool(3)) {
					shop.item[nextSlot].SetDefaults(31);
					shop.item[nextSlot].shopCustomPrice = 80;
					nextSlot++;
					shop.item[nextSlot].SetDefaults(126);
					shop.item[nextSlot].shopCustomPrice = 80;
					nextSlot++;
					if (Main.player[Main.myPlayer].ZoneJungle) {
						shop.item[nextSlot].SetDefaults(1134);
						shop.item[nextSlot].shopCustomPrice = 160;
						nextSlot++;
					}
					shop.item[nextSlot].SetDefaults(3000);
					shop.item[nextSlot].shopCustomPrice = 400000;
					nextSlot++;
					shop.item[nextSlot].SetDefaults(5);
					shop.item[nextSlot].shopCustomPrice = 5000;
					nextSlot++;
					shop.item[nextSlot].SetDefaults(28);
					shop.item[nextSlot].shopCustomPrice = 6000;
					nextSlot++;
					shop.item[nextSlot].SetDefaults(110);
					shop.item[nextSlot].shopCustomPrice = 2000;
					nextSlot++;
					if (Main.player[Main.myPlayer].ZoneDirtLayerHeight || Main.player[Main.myPlayer].ZoneRockLayerHeight) {
						shop.item[nextSlot].SetDefaults(188);
						shop.item[nextSlot].shopCustomPrice = 4000;
						nextSlot++;
						shop.item[nextSlot].SetDefaults(189);
						shop.item[nextSlot].shopCustomPrice = 1000;
						nextSlot++;
					}
					if (Main.hardMode) {
						shop.item[nextSlot].SetDefaults(499);
						shop.item[nextSlot].shopCustomPrice = 20000;
						nextSlot++;
						shop.item[nextSlot].SetDefaults(500);
						shop.item[nextSlot].shopCustomPrice = 20000;
						nextSlot++;
						if (NPC.downedMoonlord) {
							shop.item[nextSlot].SetDefaults(3544);
							shop.item[nextSlot].shopCustomPrice = 60000;
							nextSlot++;
						}
						shop.item[nextSlot].SetDefaults(2209);
						shop.item[nextSlot].shopCustomPrice = 6000;
						nextSlot++;
						if (Main.bloodMoon) {
							shop.item[nextSlot].SetDefaults(1353);
							shop.item[nextSlot].shopCustomPrice = 10000;
							nextSlot++;
							shop.item[nextSlot].SetDefaults(1354);
							shop.item[nextSlot].shopCustomPrice = 10000;
							nextSlot++;
							shop.item[nextSlot].SetDefaults(1355);
							shop.item[nextSlot].shopCustomPrice = 10000;
							nextSlot++;
							shop.item[nextSlot].SetDefaults(1356);
							shop.item[nextSlot].shopCustomPrice = 10000;
							nextSlot++;
							shop.item[nextSlot].SetDefaults(1357);
							shop.item[nextSlot].shopCustomPrice = 10000;
							nextSlot++;
							shop.item[nextSlot].SetDefaults(1359);
							shop.item[nextSlot].shopCustomPrice = 10000;
							nextSlot++;
							shop.item[nextSlot].SetDefaults(1340);
							shop.item[nextSlot].shopCustomPrice = 10000;
							nextSlot++;
						}
					}
				} else if (Main.rand.NextBool(3)) {
					shop.item[nextSlot].SetDefaults(1340);
					shop.item[nextSlot].shopCustomPrice = 10000;
					nextSlot++;
				} else {
					shop.item[nextSlot].SetDefaults(2756);
					shop.item[nextSlot].shopCustomPrice = 4000;
					nextSlot++;
					shop.item[nextSlot].SetDefaults(2350);
					shop.item[nextSlot].shopCustomPrice = 4000;
					nextSlot++;
					shop.item[nextSlot].SetDefaults(2351);
					shop.item[nextSlot].shopCustomPrice = 4000;
					nextSlot++;
					shop.item[nextSlot].SetDefaults(2997);
					shop.item[nextSlot].shopCustomPrice = 4000;
					nextSlot++;
					if (Main.bloodMoon && NPC.downedMoonlord && NPC.downedFishron && NPC.downedPlantBoss && NPC.downedSlimeKing &&
						NPC.downedMechBossAny && NPC.downedFrost && NPC.downedPirates && NPC.downedClown && NPC.savedTaxCollector
						&& NPC.savedGoblin && NPC.savedWizard && NPC.savedMech && NPC.savedAngler && NPC.savedStylist && NPC.savedBartender &&
						WorldGen.crimson && Main.hardMode && Main.expertMode)
						{
						shop.item[nextSlot].SetDefaults(678);
						shop.item[nextSlot].shopCustomPrice = 4000000;
						nextSlot++;
					}
				}
			}
			else {
				shop.item[nextSlot].SetDefaults(2344);
				shop.item[nextSlot].shopCustomPrice = 4000;
				nextSlot++;
				shop.item[nextSlot].SetDefaults(303);
				shop.item[nextSlot].shopCustomPrice = 4000;
				nextSlot++;
				shop.item[nextSlot].SetDefaults(300);
				shop.item[nextSlot].shopCustomPrice = 4000;
				nextSlot++;
				shop.item[nextSlot].SetDefaults(2325);
				shop.item[nextSlot].shopCustomPrice = 4000;
				nextSlot++;
				shop.item[nextSlot].SetDefaults(2324);
				shop.item[nextSlot].shopCustomPrice = 4000;
				nextSlot++;
				shop.item[nextSlot].SetDefaults(2326);
				shop.item[nextSlot].shopCustomPrice = 4000;
				nextSlot++;
				shop.item[nextSlot].SetDefaults(2329);
				shop.item[nextSlot].shopCustomPrice = 4000;
				nextSlot++;
				shop.item[nextSlot].SetDefaults(2346);
				shop.item[nextSlot].shopCustomPrice = 4000;
				nextSlot++;
				shop.item[nextSlot].SetDefaults(295);
				shop.item[nextSlot].shopCustomPrice = 4000;
				nextSlot++;
				shop.item[nextSlot].SetDefaults(2354);
				shop.item[nextSlot].shopCustomPrice = 4000;
				nextSlot++;
				shop.item[nextSlot].SetDefaults(2327);
				shop.item[nextSlot].shopCustomPrice = 4000;
				nextSlot++;
				shop.item[nextSlot].SetDefaults(291);
				shop.item[nextSlot].shopCustomPrice = 4000;
				nextSlot++;
				shop.item[nextSlot].SetDefaults(305);
				shop.item[nextSlot].shopCustomPrice = 4000;
				nextSlot++;
				shop.item[nextSlot].SetDefaults(2326);
				shop.item[nextSlot].shopCustomPrice = 4000;
				nextSlot++;
				shop.item[nextSlot].SetDefaults(2323);
				shop.item[nextSlot].shopCustomPrice = 4000;
				nextSlot++;
				shop.item[nextSlot].SetDefaults(304);
				shop.item[nextSlot].shopCustomPrice = 4000;
				nextSlot++;
				shop.item[nextSlot].SetDefaults(2348);
				shop.item[nextSlot].shopCustomPrice = 4000;
				nextSlot++;
				shop.item[nextSlot].SetDefaults(297);
				shop.item[nextSlot].shopCustomPrice = 4000;
				nextSlot++;
				shop.item[nextSlot].SetDefaults(292);
				shop.item[nextSlot].shopCustomPrice = 4000;
				nextSlot++;
				shop.item[nextSlot].SetDefaults(2345);
				shop.item[nextSlot].shopCustomPrice = 4000;
				nextSlot++;
				shop.item[nextSlot].SetDefaults(2352);
				shop.item[nextSlot].shopCustomPrice = 4000;
				nextSlot++;
				shop.item[nextSlot].SetDefaults(294);
				shop.item[nextSlot].shopCustomPrice = 4000;
				nextSlot++;
				shop.item[nextSlot].SetDefaults(293);
				shop.item[nextSlot].shopCustomPrice = 4000;
				nextSlot++;
				shop.item[nextSlot].SetDefaults(2322);
				shop.item[nextSlot].shopCustomPrice = 4000;
				nextSlot++;
				shop.item[nextSlot].SetDefaults(299);
				shop.item[nextSlot].shopCustomPrice = 4000;
				nextSlot++;
				shop.item[nextSlot].SetDefaults(288);
				shop.item[nextSlot].shopCustomPrice = 4000;
				nextSlot++;
				shop.item[nextSlot].SetDefaults(2347);
				shop.item[nextSlot].shopCustomPrice = 4000;
				nextSlot++;
				shop.item[nextSlot].SetDefaults(289);
				shop.item[nextSlot].shopCustomPrice = 4000;
				nextSlot++;
				shop.item[nextSlot].SetDefaults(298);
				shop.item[nextSlot].shopCustomPrice = 4000;
				nextSlot++;
				shop.item[nextSlot].SetDefaults(2355);
				shop.item[nextSlot].shopCustomPrice = 4000;
				nextSlot++;
				shop.item[nextSlot].SetDefaults(296);
				shop.item[nextSlot].shopCustomPrice = 4000;
				nextSlot++;
				shop.item[nextSlot].SetDefaults(2353);
				shop.item[nextSlot].shopCustomPrice = 4000;
				nextSlot++;
				shop.item[nextSlot].SetDefaults(2328);
				shop.item[nextSlot].shopCustomPrice = 4000;
				nextSlot++;
				shop.item[nextSlot].SetDefaults(290);
				shop.item[nextSlot].shopCustomPrice = 4000;
				nextSlot++;
				shop.item[nextSlot].SetDefaults(301);
				shop.item[nextSlot].shopCustomPrice = 4000;
				nextSlot++;
				shop.item[nextSlot].SetDefaults(2326);
				shop.item[nextSlot].shopCustomPrice = 4000;
				nextSlot++;
				shop.item[nextSlot].SetDefaults(2359);
				shop.item[nextSlot].shopCustomPrice = 4000;
				nextSlot++;
				shop.item[nextSlot].SetDefaults(302);
				shop.item[nextSlot].shopCustomPrice = 4000;
				nextSlot++;
				shop.item[nextSlot].SetDefaults(2349);
				shop.item[nextSlot].shopCustomPrice = 4000;
				nextSlot++;
			}
		}

		public override bool CanGoToStatue(bool toKingStatue) {
			return true;
		}

		public override void TownNPCAttackStrength(ref int damage, ref float knockback) {
			damage = 20;
			knockback = 4f;
		}

		public override void TownNPCAttackCooldown(ref int cooldown, ref int randExtraCooldown) {
			cooldown = 30;
			randExtraCooldown = 30;
		}

		public override void TownNPCAttackProj(ref int projType, ref int attackDelay) {
			projType = 45;
			attackDelay = 1;
		}

		public override void TownNPCAttackProjSpeed(ref float multiplier, ref float gravityCorrection, ref float randomOffset) {
			multiplier = 12f;
			randomOffset = 2f;
		}
	}
}
