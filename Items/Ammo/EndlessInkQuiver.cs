using System.Collections.Generic;
using System.Linq;
using System;
using System.Data;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Pyresense.Items.Ammo
{
	public class EndlessInkQuiver : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Endless Ink Quiver");
			//Tooltip.SetDefault("Summons Stars from sky!");
		}

		public override void SetDefaults() {
			item.CloneDefaults(40);
			item.consumable = false;
			item.maxStack = 1;
			item.rare = 5;
			item.damage = 600;
			if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProj>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjRed1>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjRed2>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjRed3>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjRed4>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjRed5>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjRed6>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjRed7>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjRed8>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjRed9>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjPink1>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjPink2>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjPink3>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjPink4>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjPink5>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjPink6>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjOrange1>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjOrange2>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjOrange3>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjOrange4>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjOrange5>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjOrange6>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjYellow1>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjYellow2>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjYellow3>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjYellow4>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjYellow5>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjYellow6>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjYellow7>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjYellow8>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjYellow9>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjYellow10>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjYellow11>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjYellow12>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjYellow13>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjPurple1>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjPurple2>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjPurple3>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjPurple4>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjPurple5>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjPurple6>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjPurple7>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjPurple8>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjPurple9>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjPurple10>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjPurple11>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjPurple12>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjPurple13>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjPurple14>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjPurple15>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjPurple16>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjPurple17>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjBrown1>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjBrown2>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjBrown3>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjBrown4>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjBrown5>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjBrown6>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjBrown7>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjBrown8>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjBrown9>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjBrown10>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjBrown11>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjBrown12>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjBrown13>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjBrown14>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjBrown15>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjBrown16>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjBrown17>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjGreen1>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjGreen2>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjGreen3>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjGreen4>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjGreen5>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjGreen6>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjGreen7>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjGreen8>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjGreen9>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjGreen10>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjGreen11>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjGreen12>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjGreen13>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjGreen14>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjGreen15>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjGreen16>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjGreen17>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjGreen18>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjGreen19>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjGreen20>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjGreen21>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjGreen22>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjGreen23>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjBlue1>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjBlue2>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjBlue3>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjBlue4>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjBlue5>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjBlue6>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjBlue7>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjBlue8>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjBlue9>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjBlue10>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjBlue11>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjBlue12>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjBlue13>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjBlue14>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjBlue15>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjBlue16>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjBlue17>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjBlue18>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjBlue19>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjBlue20>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjBlue21>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjBlue22>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjBlue23>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjBlue24>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjBlue25>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjWhite1>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjWhite2>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjWhite3>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjWhite4>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjWhite5>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjWhite6>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjWhite7>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjWhite8>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjWhite9>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjWhite10>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjWhite11>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjWhite12>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjWhite13>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjWhite14>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjWhite15>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjWhite16>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjWhite17>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjWhite18>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjGray1>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjGray2>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjGray3>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjGray4>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjGray5>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjGray6>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjGray7>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjGray8>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjGray9>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjGray10>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjGray11>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjGray12>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjGray13>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjGray14>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjGray15>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjGray16>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjGray17>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = 639;
			} else if (Main.rand.NextBool(165)) {
				item.shoot = 474;
			} else if (Main.rand.NextBool(165)) {
				item.shoot = 282;
			} else if (Main.rand.NextBool(165)) {
				item.shoot = 278;
			} else if (Main.rand.NextBool(165)) {
				item.shoot = 225;
			} else if (Main.rand.NextBool(165)) {
				item.shoot = 172;
			} else if (Main.rand.NextBool(165)) {
				item.shoot = 103;
			} else if (Main.rand.NextBool(165)) {
				item.shoot = 91;
			} else if (Main.rand.NextBool(165)) {
				item.shoot = 41;
			} else if (Main.rand.NextBool(165)) {
				item.shoot = 5;
			} else if (Main.rand.NextBool(165)) {
				item.shoot = 4;
			} else if (Main.rand.NextBool(165)) {
				item.shoot = 2;
			} else {
				item.shoot = 1;
			}
		}

		public override void Update(ref float gravity, ref float maxFallSpeed) {
			if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProj>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjRed1>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjRed2>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjRed3>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjRed4>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjRed5>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjRed6>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjRed7>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjRed8>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjRed9>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjPink1>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjPink2>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjPink3>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjPink4>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjPink5>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjPink6>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjOrange1>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjOrange2>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjOrange3>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjOrange4>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjOrange5>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjOrange6>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjYellow1>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjYellow2>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjYellow3>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjYellow4>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjYellow5>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjYellow6>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjYellow7>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjYellow8>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjYellow9>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjYellow10>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjYellow11>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjYellow12>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjYellow13>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjPurple1>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjPurple2>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjPurple3>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjPurple4>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjPurple5>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjPurple6>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjPurple7>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjPurple8>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjPurple9>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjPurple10>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjPurple11>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjPurple12>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjPurple13>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjPurple14>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjPurple15>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjPurple16>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjPurple17>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjBrown1>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjBrown2>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjBrown3>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjBrown4>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjBrown5>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjBrown6>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjBrown7>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjBrown8>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjBrown9>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjBrown10>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjBrown11>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjBrown12>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjBrown13>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjBrown14>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjBrown15>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjBrown16>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjBrown17>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjGreen1>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjGreen2>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjGreen3>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjGreen4>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjGreen5>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjGreen6>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjGreen7>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjGreen8>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjGreen9>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjGreen10>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjGreen11>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjGreen12>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjGreen13>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjGreen14>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjGreen15>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjGreen16>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjGreen17>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjGreen18>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjGreen19>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjGreen20>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjGreen21>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjGreen22>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjGreen23>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjBlue1>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjBlue2>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjBlue3>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjBlue4>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjBlue5>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjBlue6>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjBlue7>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjBlue8>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjBlue9>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjBlue10>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjBlue11>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjBlue12>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjBlue13>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjBlue14>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjBlue15>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjBlue16>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjBlue17>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjBlue18>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjBlue19>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjBlue20>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjBlue21>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjBlue22>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjBlue23>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjBlue24>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjBlue25>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjWhite1>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjWhite2>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjWhite3>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjWhite4>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjWhite5>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjWhite6>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjWhite7>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjWhite8>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjWhite9>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjWhite10>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjWhite11>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjWhite12>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjWhite13>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjWhite14>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjWhite15>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjWhite16>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjWhite17>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjWhite18>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjGray1>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjGray2>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjGray3>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjGray4>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjGray5>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjGray6>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjGray7>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjGray8>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjGray9>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjGray10>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjGray11>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjGray12>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjGray13>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjGray14>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjGray15>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjGray16>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = ProjectileType<InkArrowProjGray17>();
			} else if (Main.rand.NextBool(165)) {
				item.shoot = 639;
			} else if (Main.rand.NextBool(165)) {
				item.shoot = 474;
			} else if (Main.rand.NextBool(165)) {
				item.shoot = 282;
			} else if (Main.rand.NextBool(165)) {
				item.shoot = 278;
			} else if (Main.rand.NextBool(165)) {
				item.shoot = 225;
			} else if (Main.rand.NextBool(165)) {
				item.shoot = 172;
			} else if (Main.rand.NextBool(165)) {
				item.shoot = 103;
			} else if (Main.rand.NextBool(165)) {
				item.shoot = 91;
			} else if (Main.rand.NextBool(165)) {
				item.shoot = 41;
			} else if (Main.rand.NextBool(165)) {
				item.shoot = 5;
			} else if (Main.rand.NextBool(165)) {
				item.shoot = 4;
			} else if (Main.rand.NextBool(165)) {
				item.shoot = 2;
			} else {
				item.shoot = 1;
			}
		}

		public override Color? GetAlpha(Color lightColor) {
			return Main.DiscoColor;
		}

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "InkArrow", 3996);
			recipe.AddTile(125);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

		public override void ModifyTooltips(List<TooltipLine> tooltips) {
			TooltipLine tt = tooltips.FirstOrDefault(x => x.Name == "Damage" && x.mod == "Terraria");
			if (tt != null) {
				string[] splitText = tt.text.Split(' ');
				string damageValue = splitText.First();
				string damageWord = splitText.Last();
				tt.text = "20 ranged damage";
			}
		}
	}
}