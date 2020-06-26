using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Pyresense
{
	public class PyresenseGlobalNPC : GlobalNPC
	{
		public override bool InstancePerEntity => true;
		
		public bool curseCATsCurse;

		public override void ResetEffects(NPC npc) {
			curseCATsCurse = false;
		}

		public override void SetDefaults(NPC npc) {
			if(!Main.dedServ)
			{
				//King Slime colored
				if(ModContent.GetInstance<Config>().KingSlimeColored && npc.type == 50)
				{
					npc.alpha = 0;
					//Red
					if (Main.rand.NextBool((int)0.68027210884)) {
						npc.color = Color.IndianRed;
					} else if (Main.rand.NextBool((int)0.68027210884)) {
						npc.color = Color.LightCoral;
					} else if (Main.rand.NextBool((int)0.68027210884)) {
						npc.color = Color.Salmon;
					} else if (Main.rand.NextBool((int)0.68027210884)) {
						npc.color = Color.DarkSalmon;
					} else if (Main.rand.NextBool((int)0.68027210884)) {
						npc.color = Color.LightSalmon;
					} else if (Main.rand.NextBool((int)0.68027210884)) {
						npc.color = Color.Crimson;
					} else if (Main.rand.NextBool((int)0.68027210884)) {
						npc.color = Color.Red;
					} else if (Main.rand.NextBool((int)0.68027210884)) {
						npc.color = new Color(178, 34, 34);
					} else if (Main.rand.NextBool((int)0.68027210884)) {
						npc.color = Color.DarkRed;
					//Pink
					} else if (Main.rand.NextBool((int)0.68027210884)) {
						npc.color = Color.Pink;
					} else if (Main.rand.NextBool((int)0.68027210884)) {
						npc.color = Color.LightPink;
					} else if (Main.rand.NextBool((int)0.68027210884)) {
						npc.color = Color.HotPink;
					} else if (Main.rand.NextBool((int)0.68027210884)) {
						npc.color = Color.DeepPink;
					} else if (Main.rand.NextBool((int)0.68027210884)) {
						npc.color = Color.MediumVioletRed;
					} else if (Main.rand.NextBool((int)0.68027210884)) {
						npc.color = Color.PaleVioletRed;
					//Orange
					} else if (Main.rand.NextBool((int)0.68027210884)) {
						npc.color = Color.LightSalmon;
					} else if (Main.rand.NextBool((int)0.68027210884)) {
						npc.color = Color.Coral;
					} else if (Main.rand.NextBool((int)0.68027210884)) {
						npc.color = Color.Tomato;
					} else if (Main.rand.NextBool((int)0.68027210884)) {
						npc.color = Color.OrangeRed;
					} else if (Main.rand.NextBool((int)0.68027210884)) {
						npc.color = Color.DarkOrange;
					} else if (Main.rand.NextBool((int)0.68027210884)) {
						npc.color = Color.Orange;
					//Yellow
					} else if (Main.rand.NextBool((int)0.68027210884)) {
						npc.color = Color.Gold;
					} else if (Main.rand.NextBool((int)0.68027210884)) {
						npc.color = Color.Yellow;
					} else if (Main.rand.NextBool((int)0.68027210884)) {
						npc.color = Color.LightYellow;
					} else if (Main.rand.NextBool((int)0.68027210884)) {
						npc.color = Color.LemonChiffon;
					} else if (Main.rand.NextBool((int)0.68027210884)) {
						npc.color = Color.LightGoldenrodYellow;
					} else if (Main.rand.NextBool((int)0.68027210884)) {
						npc.color = Color.PapayaWhip;
					} else if (Main.rand.NextBool((int)0.68027210884)) {
						npc.color = Color.Moccasin;
					} else if (Main.rand.NextBool((int)0.68027210884)) {
						npc.color = Color.PeachPuff;
					} else if (Main.rand.NextBool((int)0.68027210884)) {
						npc.color = Color.PaleGoldenrod;
					} else if (Main.rand.NextBool((int)0.68027210884)) {
						npc.color = Color.Khaki;
					} else if (Main.rand.NextBool((int)0.68027210884)) {
						npc.color = Color.DarkKhaki;
					//Purple
					} else if (Main.rand.NextBool((int)0.68027210884)) {
						npc.color = Color.Lavender;
					} else if (Main.rand.NextBool((int)0.68027210884)) {
						npc.color = Color.Thistle;
					} else if (Main.rand.NextBool((int)0.68027210884)) {
						npc.color = Color.Plum;
					} else if (Main.rand.NextBool((int)0.68027210884)) {
						npc.color = Color.Violet;
					} else if (Main.rand.NextBool((int)0.68027210884)) {
						npc.color = Color.Orchid;
					} else if (Main.rand.NextBool((int)0.68027210884)) {
						npc.color = Color.Fuchsia;
					} else if (Main.rand.NextBool((int)0.68027210884)) {
						npc.color = Color.Magenta;
					} else if (Main.rand.NextBool((int)0.68027210884)) {
						npc.color = Color.MediumOrchid;
					} else if (Main.rand.NextBool((int)0.68027210884)) {
						npc.color = Color.MediumPurple;
					} else if (Main.rand.NextBool((int)0.68027210884)) {
						npc.color = Color.BlueViolet;
					} else if (Main.rand.NextBool((int)0.68027210884)) {
						npc.color = Color.DarkViolet;
					} else if (Main.rand.NextBool((int)0.68027210884)) {
						npc.color = Color.DarkMagenta;
					} else if (Main.rand.NextBool((int)0.68027210884)) {
						npc.color = Color.Purple;
					} else if (Main.rand.NextBool((int)0.68027210884)) {
						npc.color = Color.Indigo;
					} else if (Main.rand.NextBool((int)0.68027210884)) {
						npc.color = Color.SlateBlue;
					} else if (Main.rand.NextBool((int)0.68027210884)) {
						npc.color = Color.DarkSlateBlue;
					//Brown
					} else if (Main.rand.NextBool((int)0.68027210884)) {
						npc.color = Color.Cornsilk;
					} else if (Main.rand.NextBool((int)0.68027210884)) {
						npc.color = Color.BlanchedAlmond;
					} else if (Main.rand.NextBool((int)0.68027210884)) {
						npc.color = Color.Bisque;
					} else if (Main.rand.NextBool((int)0.68027210884)) {
						npc.color = Color.NavajoWhite;
					} else if (Main.rand.NextBool((int)0.68027210884)) {
						npc.color = Color.Wheat;
					} else if (Main.rand.NextBool((int)0.68027210884)) {
						npc.color = Color.BurlyWood;
					} else if (Main.rand.NextBool((int)0.68027210884)) {
						npc.color = Color.Tan;
					} else if (Main.rand.NextBool((int)0.68027210884)) {
						npc.color = Color.RosyBrown;
					} else if (Main.rand.NextBool((int)0.68027210884)) {
						npc.color = Color.SandyBrown;
					} else if (Main.rand.NextBool((int)0.68027210884)) {
						npc.color = Color.Goldenrod;
					} else if (Main.rand.NextBool((int)0.68027210884)) {
						npc.color = new Color(184, 134, 11);
					} else if (Main.rand.NextBool((int)0.68027210884)) {
						npc.color = Color.Peru;
					} else if (Main.rand.NextBool((int)0.68027210884)) {
						npc.color = Color.Chocolate;
					} else if (Main.rand.NextBool((int)0.68027210884)) {
						npc.color = Color.SaddleBrown;
					} else if (Main.rand.NextBool((int)0.68027210884)) {
						npc.color = Color.Sienna;
					} else if (Main.rand.NextBool((int)0.68027210884)) {
						npc.color = Color.Brown;
					} else if (Main.rand.NextBool((int)0.68027210884)) {
						npc.color = Color.Maroon;
					//Green
					} else if (Main.rand.NextBool((int)0.68027210884)) {
						npc.color = Color.GreenYellow;
					} else if (Main.rand.NextBool((int)0.68027210884)) {
						npc.color = Color.Chartreuse;
					} else if (Main.rand.NextBool((int)0.68027210884)) {
						npc.color = Color.LawnGreen;
					} else if (Main.rand.NextBool((int)0.68027210884)) {
						npc.color = Color.Lime;
					} else if (Main.rand.NextBool((int)0.68027210884)) {
						npc.color = Color.LimeGreen;
					} else if (Main.rand.NextBool((int)0.68027210884)) {
						npc.color = Color.PaleGreen;
					} else if (Main.rand.NextBool((int)0.68027210884)) {
						npc.color = Color.LightGreen;
					} else if (Main.rand.NextBool((int)0.68027210884)) {
						npc.color = Color.MediumSpringGreen;
					} else if (Main.rand.NextBool((int)0.68027210884)) {
						npc.color = Color.SpringGreen;
					} else if (Main.rand.NextBool((int)0.68027210884)) {
						npc.color = Color.MediumSeaGreen;
					} else if (Main.rand.NextBool((int)0.68027210884)) {
						npc.color = Color.SeaGreen;
					} else if (Main.rand.NextBool((int)0.68027210884)) {
						npc.color = Color.ForestGreen;
					} else if (Main.rand.NextBool((int)0.68027210884)) {
						npc.color = Color.Green;
					} else if (Main.rand.NextBool((int)0.68027210884)) {
						npc.color = Color.DarkGreen;
					} else if (Main.rand.NextBool((int)0.68027210884)) {
						npc.color = Color.YellowGreen;
					} else if (Main.rand.NextBool((int)0.68027210884)) {
						npc.color = Color.OliveDrab;
					} else if (Main.rand.NextBool((int)0.68027210884)) {
						npc.color = Color.Olive;
					} else if (Main.rand.NextBool((int)0.68027210884)) {
						npc.color = Color.DarkOliveGreen;
					} else if (Main.rand.NextBool((int)0.68027210884)) {
						npc.color = Color.MediumAquamarine;
					} else if (Main.rand.NextBool((int)0.68027210884)) {
						npc.color = Color.DarkSeaGreen;
					} else if (Main.rand.NextBool((int)0.68027210884)) {
						npc.color = Color.LightSeaGreen;
					} else if (Main.rand.NextBool((int)0.68027210884)) {
						npc.color = Color.DarkCyan;
					} else if (Main.rand.NextBool((int)0.68027210884)) {
						npc.color = Color.Teal;
					//Blue
					} else if (Main.rand.NextBool((int)0.68027210884)) {
						npc.color = Color.Aqua;
					} else if (Main.rand.NextBool((int)0.68027210884)) {
						npc.color = Color.Cyan;
					} else if (Main.rand.NextBool((int)0.68027210884)) {
						npc.color = Color.LightCyan;
					} else if (Main.rand.NextBool((int)0.68027210884)) {
						npc.color = Color.PaleTurquoise;
					} else if (Main.rand.NextBool((int)0.68027210884)) {
						npc.color = Color.Aquamarine;
					} else if (Main.rand.NextBool((int)0.68027210884)) {
						npc.color = Color.Turquoise;
					} else if (Main.rand.NextBool((int)0.68027210884)) {
						npc.color = Color.MediumTurquoise;
					} else if (Main.rand.NextBool((int)0.68027210884)) {
						npc.color = Color.DarkTurquoise;
					} else if (Main.rand.NextBool((int)0.68027210884)) {
						npc.color = Color.CadetBlue;
					} else if (Main.rand.NextBool((int)0.68027210884)) {
						npc.color = Color.SteelBlue;
					} else if (Main.rand.NextBool((int)0.68027210884)) {
						npc.color = Color.LightSteelBlue;
					} else if (Main.rand.NextBool((int)0.68027210884)) {
						npc.color = Color.PowderBlue;
					} else if (Main.rand.NextBool((int)0.68027210884)) {
						npc.color = Color.LightBlue;
					} else if (Main.rand.NextBool((int)0.68027210884)) {
						npc.color = Color.SkyBlue;
					} else if (Main.rand.NextBool((int)0.68027210884)) {
						npc.color = Color.LightSkyBlue;
					} else if (Main.rand.NextBool((int)0.68027210884)) {
						npc.color = Color.DeepSkyBlue;
					} else if (Main.rand.NextBool((int)0.68027210884)) {
						npc.color = Color.DodgerBlue;
					} else if (Main.rand.NextBool((int)0.68027210884)) {
						npc.color = Color.CornflowerBlue;
					} else if (Main.rand.NextBool((int)0.68027210884)) {
						npc.color = Color.MediumSlateBlue;
					} else if (Main.rand.NextBool((int)0.68027210884)) {
						npc.color = Color.RoyalBlue;
					} else if (Main.rand.NextBool((int)0.68027210884)) {
						npc.color = Color.Blue;
					} else if (Main.rand.NextBool((int)0.68027210884)) {
						npc.color = Color.MediumBlue;
					} else if (Main.rand.NextBool((int)0.68027210884)) {
						npc.color = Color.DarkBlue;
					} else if (Main.rand.NextBool((int)0.68027210884)) {
						npc.color = Color.Navy;
					} else if (Main.rand.NextBool((int)0.68027210884)) {
						npc.color = Color.MidnightBlue;
					//White
					} else if (Main.rand.NextBool((int)0.68027210884)) {
						npc.color = Color.White;
					} else if (Main.rand.NextBool((int)0.68027210884)) {
						npc.color = Color.Snow;
					} else if (Main.rand.NextBool((int)0.68027210884)) {
						npc.color = Color.Honeydew;
					} else if (Main.rand.NextBool((int)0.68027210884)) {
						npc.color = Color.MintCream;
					} else if (Main.rand.NextBool((int)0.68027210884)) {
						npc.color = Color.Azure;
					} else if (Main.rand.NextBool((int)0.68027210884)) {
						npc.color = Color.AliceBlue;
					} else if (Main.rand.NextBool((int)0.68027210884)) {
						npc.color = Color.GhostWhite;
					} else if (Main.rand.NextBool((int)0.68027210884)) {
						npc.color = Color.WhiteSmoke;
					} else if (Main.rand.NextBool((int)0.68027210884)) {
						npc.color = new Color(255, 245, 238);
					} else if (Main.rand.NextBool((int)0.68027210884)) {
						npc.color = Color.Beige;
					} else if (Main.rand.NextBool((int)0.68027210884)) {
						npc.color = Color.OldLace;
					} else if (Main.rand.NextBool((int)0.68027210884)) {
						npc.color = Color.FloralWhite;
					} else if (Main.rand.NextBool((int)0.68027210884)) {
						npc.color = Color.Ivory;
					} else if (Main.rand.NextBool((int)0.68027210884)) {
						npc.color = Color.AntiqueWhite;
					} else if (Main.rand.NextBool((int)0.68027210884)) {
						npc.color = Color.Linen;
					} else if (Main.rand.NextBool((int)0.68027210884)) {
						npc.color = Color.LavenderBlush;
					} else if (Main.rand.NextBool((int)0.68027210884)) {
						npc.color = Color.MistyRose;
					//Gray
					} else if (Main.rand.NextBool((int)0.68027210884)) {
						npc.color = Color.Gainsboro;
					} else if (Main.rand.NextBool((int)0.68027210884)) {
						npc.color = Color.LightGray;
					} else if (Main.rand.NextBool((int)0.68027210884)) {
						npc.color = Color.LightGray;
					} else if (Main.rand.NextBool((int)0.68027210884)) {
						npc.color = Color.Silver;
					} else if (Main.rand.NextBool((int)0.68027210884)) {
						npc.color = Color.DarkGray;
					} else if (Main.rand.NextBool((int)0.68027210884)) {
						npc.color = Color.DarkGray;
					} else if (Main.rand.NextBool((int)0.68027210884)) {
						npc.color = Color.Gray;
					} else if (Main.rand.NextBool((int)0.68027210884)) {
						npc.color = Color.Gray;
					} else if (Main.rand.NextBool((int)0.68027210884)) {
						npc.color = Color.DimGray;
					} else if (Main.rand.NextBool((int)0.68027210884)) {
						npc.color = Color.DimGray;
					} else if (Main.rand.NextBool((int)0.68027210884)) {
						npc.color = Color.LightSlateGray;
					} else if (Main.rand.NextBool((int)0.68027210884)) {
						npc.color = Color.LightSlateGray;
					} else if (Main.rand.NextBool((int)0.68027210884)) {
						npc.color = Color.SlateGray;
					} else if (Main.rand.NextBool((int)0.68027210884)) {
						npc.color = Color.SlateGray;
					} else if (Main.rand.NextBool((int)0.68027210884)) {
						npc.color = Color.DarkSlateGray;
					} else if (Main.rand.NextBool((int)0.68027210884)) {
						npc.color = Color.DarkSlateGray;
					} else {
						npc.color = Color.Black;
					}
				}
			}
			if (npc.type == 127) {
				if (NPC.AnyNPCs(128)) {
					npc.defense = npc.defense * 225;
				}
				if (NPC.AnyNPCs(129)) {
					npc.defense = npc.defense * 225;
				}
				if (NPC.AnyNPCs(130)) {
					npc.defense = npc.defense * 225;
				}
				if (NPC.AnyNPCs(131)) {
					npc.defense = npc.defense * 225;
				}
			}
		}

		public override void NPCLoot(NPC npc)
		{
			if (Main.rand.NextBool(30) && npc.lifeMax >= 5) {
				Item.NewItem(npc.getRect(), ItemType<Items.Misc.HunterStone>());
			}
			if (Main.rand.NextBool(30) && npc.lifeMax >= 5) {
				Item.NewItem(npc.getRect(), ItemType<Items.Misc.BloodStone>());
			}
			if (npc.type == 4 && Main.rand.NextBool(2) && !Main.expertMode)
			{
				Item.NewItem(npc.getRect(), ItemType<Items.Weapons.Summon.EyeStaff>());
			}
			if (npc.type == 6 && Main.rand.NextBool(100))
			{
				Item.NewItem(npc.getRect(), ItemType<Items.Weapons.Summon.EaterofSoulStaff>());
			}
			if (npc.type == 173 && Main.rand.NextBool(100))
			{
				Item.NewItem(npc.getRect(), ItemType<Items.Weapons.Summon.CrimeraStaff>());
			}
			if (npc.type == 370 && !Main.expertMode)
			{
				Item.NewItem(npc.getRect(), ItemType<Items.Souls.SoulofTide>(), Main.rand.Next(20, 40));
			}
		}

		public override void UpdateLifeRegen(NPC npc, ref int damage) {
			if (curseCATsCurse) {
				if (npc.lifeRegen > 0) {
					npc.lifeRegen = 0;
				}
				npc.lifeRegen -= 128;
				if (damage < 24) {
					damage = 24;
				}
			}
		}
	}
}