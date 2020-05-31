using Microsoft.Xna.Framework;
using MonoMod.Cil;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Pyresense.NPCs.Critters
{
	internal class SunScorpion : ModNPC
	{
		/*public override bool Autoload(ref string name) {
			IL.Terraria.Wiring.HitWireSingle += HookStatue;
			return base.Autoload(ref name);
		}*/

		private void HookStatue(ILContext il) {
			var c = new ILCursor(il);

			ILLabel[] targets = null;
			while (c.TryGotoNext(i => i.MatchSwitch(out targets))) {
				int offset = 0;
				if (c.Prev.MatchSub() && c.Prev.Previous.MatchLdcI4(out offset)) {
					;
				}

				if (targets.Length < 56 - offset) {
					continue;
				}

				var target = targets[56 - offset];
				if (target == null) {
					continue;
				}

				c.GotoLabel(target);
				c.GotoNext(i => i.MatchCall(typeof(Utils), nameof(Utils.SelectRandom)));

				c.EmitDelegate<Func<short[], short[]>>(arr => {
					Array.Resize(ref arr, arr.Length+1);
					arr[arr.Length-1] = (short)npc.type;
					return arr;
				});

				return;
			}

			throw new Exception("Hook location not found, switch(*) { case 56: ...");
		}

		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Sun Scorpion");
			Main.npcFrameCount[npc.type] = Main.npcFrameCount[NPCID.ScorpionBlack];
			Main.npcCatchable[npc.type] = true;
		}

		public override void SetDefaults() {
			npc.CloneDefaults(NPCID.ScorpionBlack);
			npc.catchItem = (short)ItemType<SunScorpion_Item>();
			npc.lavaImmune = false;
			npc.friendly = true;
			aiType = NPCID.ScorpionBlack;
			animationType = NPCID.ScorpionBlack;
		}

		public override bool? CanBeHitByItem(Player player, Item item) {
			return true;
		}

		public override bool? CanBeHitByProjectile(Projectile projectile) {
			return true;
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo) {
			return spawnInfo.player.ZoneUndergroundDesert ? 0.01f : 0f;
		}

		public override bool PreAI() {
			if (Collision.WetCollision(npc.position, npc.width, npc.height))
			{
				npc.life = 0;
				npc.HitEffect();
				npc.active = false;
				Main.PlaySound(SoundID.NPCDeath16, npc.position);
			}
			return base.PreAI();
		}

		public override void OnCatchNPC(Player player, Item item) {
			item.stack = 1;

			/*try {
				var npcCenter = npc.Center.ToTileCoordinates();
				if (!WorldGen.SolidTile(npcCenter.X, npcCenter.Y) && Main.tile[npcCenter.X, npcCenter.Y].liquid == 0) {
					Main.tile[npcCenter.X, npcCenter.Y].liquid = (byte)Main.rand.Next(50, 150);
					Main.tile[npcCenter.X, npcCenter.Y].lava(true);
					Main.tile[npcCenter.X, npcCenter.Y].honey(false);
					WorldGen.SquareTileFrame(npcCenter.X, npcCenter.Y, true);
				}
			}
			catch {
				return;
			}*/
		}
	}

	internal class SunScorpion_Item : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Sun Scorpion");
			Tooltip.SetDefault("Summons the Pharaoh");
		}

		public override void SetDefaults() {
			item.width = 24;
            item.height = 24;
            item.maxStack = 20;
            item.value = 1000;
            item.rare = 0;
            item.useAnimation = 30;
            item.useTime = 30;
            item.useStyle = 4;
            item.consumable = true;
		}

		public override bool CanUseItem(Player player)
        {           
            return player.ZoneDesert || player.ZoneUndergroundDesert && !NPC.AnyNPCs(mod.NPCType("Pharaoh"));
        }

		public override bool UseItem(Player player)
        {
            NPC.SpawnOnPlayer(player.whoAmI, mod.NPCType("Pharaoh"));   //boss spawn
            Main.PlaySound(15, (int)player.position.X, (int)player.position.Y, 0);

            return true;
        }

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(3, 50);
			recipe.AddIngredient(this, 5);
			recipe.AddTile(283);
			recipe.SetResult(3656);
			recipe.AddRecipe();
		}
	}
}
