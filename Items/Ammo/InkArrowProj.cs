using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Pyresense.Items.Ammo
{
	//Red
		public class InkArrowProjRed1 : InkArrowProjBase
		{
			public override string Texture
			{
				get
				{
					return "Pyresense/Items/Ammo/InkArrowProj";
				}
			}

			public override void SetStaticDefaults() {
				DisplayName.SetDefault("Ink Arrow");     //The English name of the projectile
			}

			public override void SetDefaults() {
				projectile.CloneDefaults(1);
				projectile.friendly = true;         //Can the projectile deal damage to enemies?
				projectile.hostile = false;         //Can the projectile deal damage to the player?
				projectile.ranged = true;           //Is the projectile shoot by a ranged weapon?
				projectile.penetrate = 3;           //How many monsters the projectile can penetrate. (OnTileCollide below also decrements penetrate for bounces as well)
				projectile.timeLeft = 3600;          //The live time for the projectile (60 = 1 second, so 600 is 10 seconds)
				projectile.light = 0.5f;            //How much light emit around the projectile
				projectile.ignoreWater = true;          //Does the projectile's speed be influenced by water?
				projectile.tileCollide = false;          //Can the projectile collide with tiles?
			}

			public override Color? GetAlpha(Color lightColor) {
				return new Color(205, 92, 92);
			}
		}
		public class InkArrowProjRed2 : InkArrowProjBase
		{
			public override string Texture
			{
				get
				{
					return "Pyresense/Items/Ammo/InkArrowProj";
				}
			}

			public override void SetStaticDefaults() {
				DisplayName.SetDefault("Ink Arrow");     //The English name of the projectile
			}

			public override void SetDefaults() {
				projectile.CloneDefaults(1);
				projectile.friendly = true;         //Can the projectile deal damage to enemies?
				projectile.hostile = false;         //Can the projectile deal damage to the player?
				projectile.ranged = true;           //Is the projectile shoot by a ranged weapon?
				projectile.penetrate = 3;           //How many monsters the projectile can penetrate. (OnTileCollide below also decrements penetrate for bounces as well)
				projectile.timeLeft = 3600;          //The live time for the projectile (60 = 1 second, so 600 is 10 seconds)
				projectile.light = 0.5f;            //How much light emit around the projectile
				projectile.ignoreWater = true;          //Does the projectile's speed be influenced by water?
				projectile.tileCollide = false;          //Can the projectile collide with tiles?
			}

			public override Color? GetAlpha(Color lightColor) {
				return new Color(240, 128, 128);
			}
		}
		public class InkArrowProjRed3 : InkArrowProjBase
		{
			public override string Texture
			{
				get
				{
					return "Pyresense/Items/Ammo/InkArrowProj";
				}
			}

			public override void SetStaticDefaults() {
				DisplayName.SetDefault("Ink Arrow");     //The English name of the projectile
			}

			public override void SetDefaults() {
				projectile.CloneDefaults(1);
				projectile.friendly = true;         //Can the projectile deal damage to enemies?
				projectile.hostile = false;         //Can the projectile deal damage to the player?
				projectile.ranged = true;           //Is the projectile shoot by a ranged weapon?
				projectile.penetrate = 3;           //How many monsters the projectile can penetrate. (OnTileCollide below also decrements penetrate for bounces as well)
				projectile.timeLeft = 3600;          //The live time for the projectile (60 = 1 second, so 600 is 10 seconds)
				projectile.light = 0.5f;            //How much light emit around the projectile
				projectile.ignoreWater = true;          //Does the projectile's speed be influenced by water?
				projectile.tileCollide = false;          //Can the projectile collide with tiles?
			}

			public override Color? GetAlpha(Color lightColor) {
				return new Color(250, 128, 114);
			}
		}
		public class InkArrowProjRed4 : InkArrowProjBase
		{
			public override string Texture
			{
				get
				{
					return "Pyresense/Items/Ammo/InkArrowProj";
				}
			}

			public override void SetStaticDefaults() {
				DisplayName.SetDefault("Ink Arrow");     //The English name of the projectile
			}

			public override void SetDefaults() {
				projectile.CloneDefaults(1);
				projectile.friendly = true;         //Can the projectile deal damage to enemies?
				projectile.hostile = false;         //Can the projectile deal damage to the player?
				projectile.ranged = true;           //Is the projectile shoot by a ranged weapon?
				projectile.penetrate = 3;           //How many monsters the projectile can penetrate. (OnTileCollide below also decrements penetrate for bounces as well)
				projectile.timeLeft = 3600;          //The live time for the projectile (60 = 1 second, so 600 is 10 seconds)
				projectile.light = 0.5f;            //How much light emit around the projectile
				projectile.ignoreWater = true;          //Does the projectile's speed be influenced by water?
				projectile.tileCollide = false;          //Can the projectile collide with tiles?
			}

			public override Color? GetAlpha(Color lightColor) {
				return new Color(233, 150, 122);
			}
		}
		public class InkArrowProjRed5 : InkArrowProjBase
		{
			public override string Texture
			{
				get
				{
					return "Pyresense/Items/Ammo/InkArrowProj";
				}
			}

			public override void SetStaticDefaults() {
				DisplayName.SetDefault("Ink Arrow");     //The English name of the projectile
			}

			public override void SetDefaults() {
				projectile.CloneDefaults(1);
				projectile.friendly = true;         //Can the projectile deal damage to enemies?
				projectile.hostile = false;         //Can the projectile deal damage to the player?
				projectile.ranged = true;           //Is the projectile shoot by a ranged weapon?
				projectile.penetrate = 3;           //How many monsters the projectile can penetrate. (OnTileCollide below also decrements penetrate for bounces as well)
				projectile.timeLeft = 3600;          //The live time for the projectile (60 = 1 second, so 600 is 10 seconds)
				projectile.light = 0.5f;            //How much light emit around the projectile
				projectile.ignoreWater = true;          //Does the projectile's speed be influenced by water?
				projectile.tileCollide = false;          //Can the projectile collide with tiles?
			}

			public override Color? GetAlpha(Color lightColor) {
				return new Color(255, 160, 122);
			}
		}
		public class InkArrowProjRed6 : InkArrowProjBase
		{
			public override string Texture
			{
				get
				{
					return "Pyresense/Items/Ammo/InkArrowProj";
				}
			}

			public override void SetStaticDefaults() {
				DisplayName.SetDefault("Ink Arrow");     //The English name of the projectile
			}

			public override void SetDefaults() {
				projectile.CloneDefaults(1);
				projectile.friendly = true;         //Can the projectile deal damage to enemies?
				projectile.hostile = false;         //Can the projectile deal damage to the player?
				projectile.ranged = true;           //Is the projectile shoot by a ranged weapon?
				projectile.penetrate = 3;           //How many monsters the projectile can penetrate. (OnTileCollide below also decrements penetrate for bounces as well)
				projectile.timeLeft = 3600;          //The live time for the projectile (60 = 1 second, so 600 is 10 seconds)
				projectile.light = 0.5f;            //How much light emit around the projectile
				projectile.ignoreWater = true;          //Does the projectile's speed be influenced by water?
				projectile.tileCollide = false;          //Can the projectile collide with tiles?
			}

			public override Color? GetAlpha(Color lightColor) {
				return new Color(220, 20, 60);
			}
		}
		public class InkArrowProjRed7 : InkArrowProjBase
		{
			public override string Texture
			{
				get
				{
					return "Pyresense/Items/Ammo/InkArrowProj";
				}
			}

			public override void SetStaticDefaults() {
				DisplayName.SetDefault("Ink Arrow");     //The English name of the projectile
			}

			public override void SetDefaults() {
				projectile.CloneDefaults(1);
				projectile.friendly = true;         //Can the projectile deal damage to enemies?
				projectile.hostile = false;         //Can the projectile deal damage to the player?
				projectile.ranged = true;           //Is the projectile shoot by a ranged weapon?
				projectile.penetrate = 3;           //How many monsters the projectile can penetrate. (OnTileCollide below also decrements penetrate for bounces as well)
				projectile.timeLeft = 3600;          //The live time for the projectile (60 = 1 second, so 600 is 10 seconds)
				projectile.light = 0.5f;            //How much light emit around the projectile
				projectile.ignoreWater = true;          //Does the projectile's speed be influenced by water?
				projectile.tileCollide = false;          //Can the projectile collide with tiles?
			}

			public override Color? GetAlpha(Color lightColor) {
				return new Color(255, 0, 0);
			}
		}
		public class InkArrowProjRed8 : InkArrowProjBase
		{
			public override string Texture
			{
				get
				{
					return "Pyresense/Items/Ammo/InkArrowProj";
				}
			}

			public override void SetStaticDefaults() {
				DisplayName.SetDefault("Ink Arrow");     //The English name of the projectile
			}

			public override void SetDefaults() {
				projectile.CloneDefaults(1);
				projectile.friendly = true;         //Can the projectile deal damage to enemies?
				projectile.hostile = false;         //Can the projectile deal damage to the player?
				projectile.ranged = true;           //Is the projectile shoot by a ranged weapon?
				projectile.penetrate = 3;           //How many monsters the projectile can penetrate. (OnTileCollide below also decrements penetrate for bounces as well)
				projectile.timeLeft = 3600;          //The live time for the projectile (60 = 1 second, so 600 is 10 seconds)
				projectile.light = 0.5f;            //How much light emit around the projectile
				projectile.ignoreWater = true;          //Does the projectile's speed be influenced by water?
				projectile.tileCollide = false;          //Can the projectile collide with tiles?
			}

			public override Color? GetAlpha(Color lightColor) {
				return new Color(178, 34, 34);
			}
		}
		public class InkArrowProjRed9 : InkArrowProjBase
		{
			public override string Texture
			{
				get
				{
					return "Pyresense/Items/Ammo/InkArrowProj";
				}
			}

			public override void SetStaticDefaults() {
				DisplayName.SetDefault("Ink Arrow");     //The English name of the projectile
			}

			public override void SetDefaults() {
				projectile.CloneDefaults(1);
				projectile.friendly = true;         //Can the projectile deal damage to enemies?
				projectile.hostile = false;         //Can the projectile deal damage to the player?
				projectile.ranged = true;           //Is the projectile shoot by a ranged weapon?
				projectile.penetrate = 3;           //How many monsters the projectile can penetrate. (OnTileCollide below also decrements penetrate for bounces as well)
				projectile.timeLeft = 3600;          //The live time for the projectile (60 = 1 second, so 600 is 10 seconds)
				projectile.light = 0.5f;            //How much light emit around the projectile
				projectile.ignoreWater = true;          //Does the projectile's speed be influenced by water?
				projectile.tileCollide = false;          //Can the projectile collide with tiles?
			}

			public override Color? GetAlpha(Color lightColor) {
				return new Color(139, 0, 0);
			}
		}
	//Pink
		public class InkArrowProjPink1 : InkArrowProjBase
		{
			public override string Texture
			{
				get
				{
					return "Pyresense/Items/Ammo/InkArrowProj";
				}
			}

			public override void SetStaticDefaults() {
				DisplayName.SetDefault("Ink Arrow");     //The English name of the projectile
			}

			public override void SetDefaults() {
				projectile.CloneDefaults(1);
				projectile.friendly = true;         //Can the projectile deal damage to enemies?
				projectile.hostile = false;         //Can the projectile deal damage to the player?
				projectile.ranged = true;           //Is the projectile shoot by a ranged weapon?
				projectile.penetrate = 3;           //How many monsters the projectile can penetrate. (OnTileCollide below also decrements penetrate for bounces as well)
				projectile.timeLeft = 3600;          //The live time for the projectile (60 = 1 second, so 600 is 10 seconds)
				projectile.light = 0.5f;            //How much light emit around the projectile
				projectile.ignoreWater = true;          //Does the projectile's speed be influenced by water?
				projectile.tileCollide = false;          //Can the projectile collide with tiles?
			}

			public override Color? GetAlpha(Color lightColor) {
				return new Color(255, 192, 203);
			}
		}
		public class InkArrowProjPink2 : InkArrowProjBase
		{
			public override string Texture
			{
				get
				{
					return "Pyresense/Items/Ammo/InkArrowProj";
				}
			}

			public override void SetStaticDefaults() {
				DisplayName.SetDefault("Ink Arrow");     //The English name of the projectile
			}

			public override void SetDefaults() {
				projectile.CloneDefaults(1);
				projectile.friendly = true;         //Can the projectile deal damage to enemies?
				projectile.hostile = false;         //Can the projectile deal damage to the player?
				projectile.ranged = true;           //Is the projectile shoot by a ranged weapon?
				projectile.penetrate = 3;           //How many monsters the projectile can penetrate. (OnTileCollide below also decrements penetrate for bounces as well)
				projectile.timeLeft = 3600;          //The live time for the projectile (60 = 1 second, so 600 is 10 seconds)
				projectile.light = 0.5f;            //How much light emit around the projectile
				projectile.ignoreWater = true;          //Does the projectile's speed be influenced by water?
				projectile.tileCollide = false;          //Can the projectile collide with tiles?
			}

			public override Color? GetAlpha(Color lightColor) {
				return new Color(255, 182, 193);
			}
		}
		public class InkArrowProjPink3 : InkArrowProjBase
		{
			public override string Texture
			{
				get
				{
					return "Pyresense/Items/Ammo/InkArrowProj";
				}
			}

			public override void SetStaticDefaults() {
				DisplayName.SetDefault("Ink Arrow");     //The English name of the projectile
			}

			public override void SetDefaults() {
				projectile.CloneDefaults(1);
				projectile.friendly = true;         //Can the projectile deal damage to enemies?
				projectile.hostile = false;         //Can the projectile deal damage to the player?
				projectile.ranged = true;           //Is the projectile shoot by a ranged weapon?
				projectile.penetrate = 3;           //How many monsters the projectile can penetrate. (OnTileCollide below also decrements penetrate for bounces as well)
				projectile.timeLeft = 3600;          //The live time for the projectile (60 = 1 second, so 600 is 10 seconds)
				projectile.light = 0.5f;            //How much light emit around the projectile
				projectile.ignoreWater = true;          //Does the projectile's speed be influenced by water?
				projectile.tileCollide = false;          //Can the projectile collide with tiles?
			}

			public override Color? GetAlpha(Color lightColor) {
				return new Color(255, 105, 180);
			}
		}
		public class InkArrowProjPink4 : InkArrowProjBase
		{
			public override string Texture
			{
				get
				{
					return "Pyresense/Items/Ammo/InkArrowProj";
				}
			}

			public override void SetStaticDefaults() {
				DisplayName.SetDefault("Ink Arrow");     //The English name of the projectile
			}

			public override void SetDefaults() {
				projectile.CloneDefaults(1);
				projectile.friendly = true;         //Can the projectile deal damage to enemies?
				projectile.hostile = false;         //Can the projectile deal damage to the player?
				projectile.ranged = true;           //Is the projectile shoot by a ranged weapon?
				projectile.penetrate = 3;           //How many monsters the projectile can penetrate. (OnTileCollide below also decrements penetrate for bounces as well)
				projectile.timeLeft = 3600;          //The live time for the projectile (60 = 1 second, so 600 is 10 seconds)
				projectile.light = 0.5f;            //How much light emit around the projectile
				projectile.ignoreWater = true;          //Does the projectile's speed be influenced by water?
				projectile.tileCollide = false;          //Can the projectile collide with tiles?
			}

			public override Color? GetAlpha(Color lightColor) {
				return new Color(255, 20, 147);
			}
		}
		public class InkArrowProjPink5 : InkArrowProjBase
		{
			public override string Texture
			{
				get
				{
					return "Pyresense/Items/Ammo/InkArrowProj";
				}
			}

			public override void SetStaticDefaults() {
				DisplayName.SetDefault("Ink Arrow");     //The English name of the projectile
			}

			public override void SetDefaults() {
				projectile.CloneDefaults(1);
				projectile.friendly = true;         //Can the projectile deal damage to enemies?
				projectile.hostile = false;         //Can the projectile deal damage to the player?
				projectile.ranged = true;           //Is the projectile shoot by a ranged weapon?
				projectile.penetrate = 3;           //How many monsters the projectile can penetrate. (OnTileCollide below also decrements penetrate for bounces as well)
				projectile.timeLeft = 3600;          //The live time for the projectile (60 = 1 second, so 600 is 10 seconds)
				projectile.light = 0.5f;            //How much light emit around the projectile
				projectile.ignoreWater = true;          //Does the projectile's speed be influenced by water?
				projectile.tileCollide = false;          //Can the projectile collide with tiles?
			}

			public override Color? GetAlpha(Color lightColor) {
				return new Color(199, 21, 133);
			}
		}
		public class InkArrowProjPink6 : InkArrowProjBase
		{
			public override string Texture
			{
				get
				{
					return "Pyresense/Items/Ammo/InkArrowProj";
				}
			}

			public override void SetStaticDefaults() {
				DisplayName.SetDefault("Ink Arrow");     //The English name of the projectile
			}

			public override void SetDefaults() {
				projectile.CloneDefaults(1);
				projectile.friendly = true;         //Can the projectile deal damage to enemies?
				projectile.hostile = false;         //Can the projectile deal damage to the player?
				projectile.ranged = true;           //Is the projectile shoot by a ranged weapon?
				projectile.penetrate = 3;           //How many monsters the projectile can penetrate. (OnTileCollide below also decrements penetrate for bounces as well)
				projectile.timeLeft = 3600;          //The live time for the projectile (60 = 1 second, so 600 is 10 seconds)
				projectile.light = 0.5f;            //How much light emit around the projectile
				projectile.ignoreWater = true;          //Does the projectile's speed be influenced by water?
				projectile.tileCollide = false;          //Can the projectile collide with tiles?
			}

			public override Color? GetAlpha(Color lightColor) {
				return new Color(219, 112, 147);
			}
		}
	//Orange
		public class InkArrowProjOrange1 : InkArrowProjBase
		{
			public override string Texture
			{
				get
				{
					return "Pyresense/Items/Ammo/InkArrowProj";
				}
			}

			public override void SetStaticDefaults() {
				DisplayName.SetDefault("Ink Arrow");     //The English name of the projectile
			}

			public override void SetDefaults() {
				projectile.CloneDefaults(1);
				projectile.friendly = true;         //Can the projectile deal damage to enemies?
				projectile.hostile = false;         //Can the projectile deal damage to the player?
				projectile.ranged = true;           //Is the projectile shoot by a ranged weapon?
				projectile.penetrate = 3;           //How many monsters the projectile can penetrate. (OnTileCollide below also decrements penetrate for bounces as well)
				projectile.timeLeft = 3600;          //The live time for the projectile (60 = 1 second, so 600 is 10 seconds)
				projectile.light = 0.5f;            //How much light emit around the projectile
				projectile.ignoreWater = true;          //Does the projectile's speed be influenced by water?
				projectile.tileCollide = false;          //Can the projectile collide with tiles?
			}

			public override Color? GetAlpha(Color lightColor) {
				return new Color(255, 160, 122);
			}
		}
		public class InkArrowProjOrange2 : InkArrowProjBase
		{
			public override string Texture
			{
				get
				{
					return "Pyresense/Items/Ammo/InkArrowProj";
				}
			}

			public override void SetStaticDefaults() {
				DisplayName.SetDefault("Ink Arrow");     //The English name of the projectile
			}

			public override void SetDefaults() {
				projectile.CloneDefaults(1);
				projectile.friendly = true;         //Can the projectile deal damage to enemies?
				projectile.hostile = false;         //Can the projectile deal damage to the player?
				projectile.ranged = true;           //Is the projectile shoot by a ranged weapon?
				projectile.penetrate = 3;           //How many monsters the projectile can penetrate. (OnTileCollide below also decrements penetrate for bounces as well)
				projectile.timeLeft = 3600;          //The live time for the projectile (60 = 1 second, so 600 is 10 seconds)
				projectile.light = 0.5f;            //How much light emit around the projectile
				projectile.ignoreWater = true;          //Does the projectile's speed be influenced by water?
				projectile.tileCollide = false;          //Can the projectile collide with tiles?
			}

			public override Color? GetAlpha(Color lightColor) {
				return new Color(255, 127, 80);
			}
		}
		public class InkArrowProjOrange3 : InkArrowProjBase
		{
			public override string Texture
			{
				get
				{
					return "Pyresense/Items/Ammo/InkArrowProj";
				}
			}

			public override void SetStaticDefaults() {
				DisplayName.SetDefault("Ink Arrow");     //The English name of the projectile
			}

			public override void SetDefaults() {
				projectile.CloneDefaults(1);
				projectile.friendly = true;         //Can the projectile deal damage to enemies?
				projectile.hostile = false;         //Can the projectile deal damage to the player?
				projectile.ranged = true;           //Is the projectile shoot by a ranged weapon?
				projectile.penetrate = 3;           //How many monsters the projectile can penetrate. (OnTileCollide below also decrements penetrate for bounces as well)
				projectile.timeLeft = 3600;          //The live time for the projectile (60 = 1 second, so 600 is 10 seconds)
				projectile.light = 0.5f;            //How much light emit around the projectile
				projectile.ignoreWater = true;          //Does the projectile's speed be influenced by water?
				projectile.tileCollide = false;          //Can the projectile collide with tiles?
			}

			public override Color? GetAlpha(Color lightColor) {
				return new Color(255, 99, 71);
			}
		}
		public class InkArrowProjOrange4 : InkArrowProjBase
		{
			public override string Texture
			{
				get
				{
					return "Pyresense/Items/Ammo/InkArrowProj";
				}
			}

			public override void SetStaticDefaults() {
				DisplayName.SetDefault("Ink Arrow");     //The English name of the projectile
			}

			public override void SetDefaults() {
				projectile.CloneDefaults(1);
				projectile.friendly = true;         //Can the projectile deal damage to enemies?
				projectile.hostile = false;         //Can the projectile deal damage to the player?
				projectile.ranged = true;           //Is the projectile shoot by a ranged weapon?
				projectile.penetrate = 3;           //How many monsters the projectile can penetrate. (OnTileCollide below also decrements penetrate for bounces as well)
				projectile.timeLeft = 3600;          //The live time for the projectile (60 = 1 second, so 600 is 10 seconds)
				projectile.light = 0.5f;            //How much light emit around the projectile
				projectile.ignoreWater = true;          //Does the projectile's speed be influenced by water?
				projectile.tileCollide = false;          //Can the projectile collide with tiles?
			}

			public override Color? GetAlpha(Color lightColor) {
				return new Color(255, 69, 0);
			}
		}
		public class InkArrowProjOrange5 : InkArrowProjBase
		{
			public override string Texture
			{
				get
				{
					return "Pyresense/Items/Ammo/InkArrowProj";
				}
			}

			public override void SetStaticDefaults() {
				DisplayName.SetDefault("Ink Arrow");     //The English name of the projectile
			}

			public override void SetDefaults() {
				projectile.CloneDefaults(1);
				projectile.friendly = true;         //Can the projectile deal damage to enemies?
				projectile.hostile = false;         //Can the projectile deal damage to the player?
				projectile.ranged = true;           //Is the projectile shoot by a ranged weapon?
				projectile.penetrate = 3;           //How many monsters the projectile can penetrate. (OnTileCollide below also decrements penetrate for bounces as well)
				projectile.timeLeft = 3600;          //The live time for the projectile (60 = 1 second, so 600 is 10 seconds)
				projectile.light = 0.5f;            //How much light emit around the projectile
				projectile.ignoreWater = true;          //Does the projectile's speed be influenced by water?
				projectile.tileCollide = false;          //Can the projectile collide with tiles?
			}

			public override Color? GetAlpha(Color lightColor) {
				return new Color(255, 140, 0);
			}
		}
		public class InkArrowProjOrange6 : InkArrowProjBase
		{
			public override string Texture
			{
				get
				{
					return "Pyresense/Items/Ammo/InkArrowProj";
				}
			}

			public override void SetStaticDefaults() {
				DisplayName.SetDefault("Ink Arrow");     //The English name of the projectile
			}

			public override void SetDefaults() {
				projectile.CloneDefaults(1);
				projectile.friendly = true;         //Can the projectile deal damage to enemies?
				projectile.hostile = false;         //Can the projectile deal damage to the player?
				projectile.ranged = true;           //Is the projectile shoot by a ranged weapon?
				projectile.penetrate = 3;           //How many monsters the projectile can penetrate. (OnTileCollide below also decrements penetrate for bounces as well)
				projectile.timeLeft = 3600;          //The live time for the projectile (60 = 1 second, so 600 is 10 seconds)
				projectile.light = 0.5f;            //How much light emit around the projectile
				projectile.ignoreWater = true;          //Does the projectile's speed be influenced by water?
				projectile.tileCollide = false;          //Can the projectile collide with tiles?
			}

			public override Color? GetAlpha(Color lightColor) {
				return new Color(255, 165, 0);
			}
		}
	//Yellow
		public class InkArrowProjYellow1 : InkArrowProjBase
		{
			public override string Texture
			{
				get
				{
					return "Pyresense/Items/Ammo/InkArrowProj";
				}
			}

			public override void SetStaticDefaults() {
				DisplayName.SetDefault("Ink Arrow");     //The English name of the projectile
			}

			public override void SetDefaults() {
				projectile.CloneDefaults(1);
				projectile.friendly = true;         //Can the projectile deal damage to enemies?
				projectile.hostile = false;         //Can the projectile deal damage to the player?
				projectile.ranged = true;           //Is the projectile shoot by a ranged weapon?
				projectile.penetrate = 3;           //How many monsters the projectile can penetrate. (OnTileCollide below also decrements penetrate for bounces as well)
				projectile.timeLeft = 3600;          //The live time for the projectile (60 = 1 second, so 600 is 10 seconds)
				projectile.light = 0.5f;            //How much light emit around the projectile
				projectile.ignoreWater = true;          //Does the projectile's speed be influenced by water?
				projectile.tileCollide = false;          //Can the projectile collide with tiles?
			}

			public override Color? GetAlpha(Color lightColor) {
				return new Color(255, 215, 0);
			}
		}
		public class InkArrowProjYellow2 : InkArrowProjBase
		{
			public override string Texture
			{
				get
				{
					return "Pyresense/Items/Ammo/InkArrowProj";
				}
			}

			public override void SetStaticDefaults() {
				DisplayName.SetDefault("Ink Arrow");     //The English name of the projectile
			}

			public override void SetDefaults() {
				projectile.CloneDefaults(1);
				projectile.friendly = true;         //Can the projectile deal damage to enemies?
				projectile.hostile = false;         //Can the projectile deal damage to the player?
				projectile.ranged = true;           //Is the projectile shoot by a ranged weapon?
				projectile.penetrate = 3;           //How many monsters the projectile can penetrate. (OnTileCollide below also decrements penetrate for bounces as well)
				projectile.timeLeft = 3600;          //The live time for the projectile (60 = 1 second, so 600 is 10 seconds)
				projectile.light = 0.5f;            //How much light emit around the projectile
				projectile.ignoreWater = true;          //Does the projectile's speed be influenced by water?
				projectile.tileCollide = false;          //Can the projectile collide with tiles?
			}

			public override Color? GetAlpha(Color lightColor) {
				return new Color(255, 255, 0);
			}
		}
		public class InkArrowProjYellow3 : InkArrowProjBase
		{
			public override string Texture
			{
				get
				{
					return "Pyresense/Items/Ammo/InkArrowProj";
				}
			}

			public override void SetStaticDefaults() {
				DisplayName.SetDefault("Ink Arrow");     //The English name of the projectile
			}

			public override void SetDefaults() {
				projectile.CloneDefaults(1);
				projectile.friendly = true;         //Can the projectile deal damage to enemies?
				projectile.hostile = false;         //Can the projectile deal damage to the player?
				projectile.ranged = true;           //Is the projectile shoot by a ranged weapon?
				projectile.penetrate = 3;           //How many monsters the projectile can penetrate. (OnTileCollide below also decrements penetrate for bounces as well)
				projectile.timeLeft = 3600;          //The live time for the projectile (60 = 1 second, so 600 is 10 seconds)
				projectile.light = 0.5f;            //How much light emit around the projectile
				projectile.ignoreWater = true;          //Does the projectile's speed be influenced by water?
				projectile.tileCollide = false;          //Can the projectile collide with tiles?
			}

			public override Color? GetAlpha(Color lightColor) {
				return new Color(255, 255, 224);
			}
		}
		public class InkArrowProjYellow4 : InkArrowProjBase
		{
			public override string Texture
			{
				get
				{
					return "Pyresense/Items/Ammo/InkArrowProj";
				}
			}

			public override void SetStaticDefaults() {
				DisplayName.SetDefault("Ink Arrow");     //The English name of the projectile
			}

			public override void SetDefaults() {
				projectile.CloneDefaults(1);
				projectile.friendly = true;         //Can the projectile deal damage to enemies?
				projectile.hostile = false;         //Can the projectile deal damage to the player?
				projectile.ranged = true;           //Is the projectile shoot by a ranged weapon?
				projectile.penetrate = 3;           //How many monsters the projectile can penetrate. (OnTileCollide below also decrements penetrate for bounces as well)
				projectile.timeLeft = 3600;          //The live time for the projectile (60 = 1 second, so 600 is 10 seconds)
				projectile.light = 0.5f;            //How much light emit around the projectile
				projectile.ignoreWater = true;          //Does the projectile's speed be influenced by water?
				projectile.tileCollide = false;          //Can the projectile collide with tiles?
			}

			public override Color? GetAlpha(Color lightColor) {
				return new Color(255, 250, 205);
			}
		}
		public class InkArrowProjYellow5 : InkArrowProjBase
		{
			public override string Texture
			{
				get
				{
					return "Pyresense/Items/Ammo/InkArrowProj";
				}
			}

			public override void SetStaticDefaults() {
				DisplayName.SetDefault("Ink Arrow");     //The English name of the projectile
			}

			public override void SetDefaults() {
				projectile.CloneDefaults(1);
				projectile.friendly = true;         //Can the projectile deal damage to enemies?
				projectile.hostile = false;         //Can the projectile deal damage to the player?
				projectile.ranged = true;           //Is the projectile shoot by a ranged weapon?
				projectile.penetrate = 3;           //How many monsters the projectile can penetrate. (OnTileCollide below also decrements penetrate for bounces as well)
				projectile.timeLeft = 3600;          //The live time for the projectile (60 = 1 second, so 600 is 10 seconds)
				projectile.light = 0.5f;            //How much light emit around the projectile
				projectile.ignoreWater = true;          //Does the projectile's speed be influenced by water?
				projectile.tileCollide = false;          //Can the projectile collide with tiles?
			}

			public override Color? GetAlpha(Color lightColor) {
				return new Color(250, 250, 210);
			}
		}
		public class InkArrowProjYellow6 : InkArrowProjBase
		{
			public override string Texture
			{
				get
				{
					return "Pyresense/Items/Ammo/InkArrowProj";
				}
			}

			public override void SetStaticDefaults() {
				DisplayName.SetDefault("Ink Arrow");     //The English name of the projectile
			}

			public override void SetDefaults() {
				projectile.CloneDefaults(1);
				projectile.friendly = true;         //Can the projectile deal damage to enemies?
				projectile.hostile = false;         //Can the projectile deal damage to the player?
				projectile.ranged = true;           //Is the projectile shoot by a ranged weapon?
				projectile.penetrate = 3;           //How many monsters the projectile can penetrate. (OnTileCollide below also decrements penetrate for bounces as well)
				projectile.timeLeft = 3600;          //The live time for the projectile (60 = 1 second, so 600 is 10 seconds)
				projectile.light = 0.5f;            //How much light emit around the projectile
				projectile.ignoreWater = true;          //Does the projectile's speed be influenced by water?
				projectile.tileCollide = false;          //Can the projectile collide with tiles?
			}

			public override Color? GetAlpha(Color lightColor) {
				return new Color(255, 239, 213);
			}
		}
		public class InkArrowProjYellow7 : InkArrowProjBase
		{
			public override string Texture
			{
				get
				{
					return "Pyresense/Items/Ammo/InkArrowProj";
				}
			}

			public override void SetStaticDefaults() {
				DisplayName.SetDefault("Ink Arrow");     //The English name of the projectile
			}

			public override void SetDefaults() {
				projectile.CloneDefaults(1);
				projectile.friendly = true;         //Can the projectile deal damage to enemies?
				projectile.hostile = false;         //Can the projectile deal damage to the player?
				projectile.ranged = true;           //Is the projectile shoot by a ranged weapon?
				projectile.penetrate = 3;           //How many monsters the projectile can penetrate. (OnTileCollide below also decrements penetrate for bounces as well)
				projectile.timeLeft = 3600;          //The live time for the projectile (60 = 1 second, so 600 is 10 seconds)
				projectile.light = 0.5f;            //How much light emit around the projectile
				projectile.ignoreWater = true;          //Does the projectile's speed be influenced by water?
				projectile.tileCollide = false;          //Can the projectile collide with tiles?
			}

			public override Color? GetAlpha(Color lightColor) {
				return new Color(255, 239, 213);
			}
		}
		public class InkArrowProjYellow8 : InkArrowProjBase
		{
			public override string Texture
			{
				get
				{
					return "Pyresense/Items/Ammo/InkArrowProj";
				}
			}

			public override void SetStaticDefaults() {
				DisplayName.SetDefault("Ink Arrow");     //The English name of the projectile
			}

			public override void SetDefaults() {
				projectile.CloneDefaults(1);
				projectile.friendly = true;         //Can the projectile deal damage to enemies?
				projectile.hostile = false;         //Can the projectile deal damage to the player?
				projectile.ranged = true;           //Is the projectile shoot by a ranged weapon?
				projectile.penetrate = 3;           //How many monsters the projectile can penetrate. (OnTileCollide below also decrements penetrate for bounces as well)
				projectile.timeLeft = 3600;          //The live time for the projectile (60 = 1 second, so 600 is 10 seconds)
				projectile.light = 0.5f;            //How much light emit around the projectile
				projectile.ignoreWater = true;          //Does the projectile's speed be influenced by water?
				projectile.tileCollide = false;          //Can the projectile collide with tiles?
			}

			public override Color? GetAlpha(Color lightColor) {
				return new Color(255, 228, 181);
			}
		}
		public class InkArrowProjYellow9 : InkArrowProjBase
		{
			public override string Texture
			{
				get
				{
					return "Pyresense/Items/Ammo/InkArrowProj";
				}
			}

			public override void SetStaticDefaults() {
				DisplayName.SetDefault("Ink Arrow");     //The English name of the projectile
			}

			public override void SetDefaults() {
				projectile.CloneDefaults(1);
				projectile.friendly = true;         //Can the projectile deal damage to enemies?
				projectile.hostile = false;         //Can the projectile deal damage to the player?
				projectile.ranged = true;           //Is the projectile shoot by a ranged weapon?
				projectile.penetrate = 3;           //How many monsters the projectile can penetrate. (OnTileCollide below also decrements penetrate for bounces as well)
				projectile.timeLeft = 3600;          //The live time for the projectile (60 = 1 second, so 600 is 10 seconds)
				projectile.light = 0.5f;            //How much light emit around the projectile
				projectile.ignoreWater = true;          //Does the projectile's speed be influenced by water?
				projectile.tileCollide = false;          //Can the projectile collide with tiles?
			}

			public override Color? GetAlpha(Color lightColor) {
				return new Color(255, 218, 185);
			}
		}
		public class InkArrowProjYellow10 : InkArrowProjBase
		{
			public override string Texture
			{
				get
				{
					return "Pyresense/Items/Ammo/InkArrowProj";
				}
			}

			public override void SetStaticDefaults() {
				DisplayName.SetDefault("Ink Arrow");     //The English name of the projectile
			}

			public override void SetDefaults() {
				projectile.CloneDefaults(1);
				projectile.friendly = true;         //Can the projectile deal damage to enemies?
				projectile.hostile = false;         //Can the projectile deal damage to the player?
				projectile.ranged = true;           //Is the projectile shoot by a ranged weapon?
				projectile.penetrate = 3;           //How many monsters the projectile can penetrate. (OnTileCollide below also decrements penetrate for bounces as well)
				projectile.timeLeft = 3600;          //The live time for the projectile (60 = 1 second, so 600 is 10 seconds)
				projectile.light = 0.5f;            //How much light emit around the projectile
				projectile.ignoreWater = true;          //Does the projectile's speed be influenced by water?
				projectile.tileCollide = false;          //Can the projectile collide with tiles?
			}

			public override Color? GetAlpha(Color lightColor) {
				return new Color(255, 218, 185);
			}
		}
		public class InkArrowProjYellow11 : InkArrowProjBase
		{
			public override string Texture
			{
				get
				{
					return "Pyresense/Items/Ammo/InkArrowProj";
				}
			}

			public override void SetStaticDefaults() {
				DisplayName.SetDefault("Ink Arrow");     //The English name of the projectile
			}

			public override void SetDefaults() {
				projectile.CloneDefaults(1);
				projectile.friendly = true;         //Can the projectile deal damage to enemies?
				projectile.hostile = false;         //Can the projectile deal damage to the player?
				projectile.ranged = true;           //Is the projectile shoot by a ranged weapon?
				projectile.penetrate = 3;           //How many monsters the projectile can penetrate. (OnTileCollide below also decrements penetrate for bounces as well)
				projectile.timeLeft = 3600;          //The live time for the projectile (60 = 1 second, so 600 is 10 seconds)
				projectile.light = 0.5f;            //How much light emit around the projectile
				projectile.ignoreWater = true;          //Does the projectile's speed be influenced by water?
				projectile.tileCollide = false;          //Can the projectile collide with tiles?
			}

			public override Color? GetAlpha(Color lightColor) {
				return new Color(238, 232, 170);
			}
		}
		public class InkArrowProjYellow12 : InkArrowProjBase
		{
			public override string Texture
			{
				get
				{
					return "Pyresense/Items/Ammo/InkArrowProj";
				}
			}

			public override void SetStaticDefaults() {
				DisplayName.SetDefault("Ink Arrow");     //The English name of the projectile
			}

			public override void SetDefaults() {
				projectile.CloneDefaults(1);
				projectile.friendly = true;         //Can the projectile deal damage to enemies?
				projectile.hostile = false;         //Can the projectile deal damage to the player?
				projectile.ranged = true;           //Is the projectile shoot by a ranged weapon?
				projectile.penetrate = 3;           //How many monsters the projectile can penetrate. (OnTileCollide below also decrements penetrate for bounces as well)
				projectile.timeLeft = 3600;          //The live time for the projectile (60 = 1 second, so 600 is 10 seconds)
				projectile.light = 0.5f;            //How much light emit around the projectile
				projectile.ignoreWater = true;          //Does the projectile's speed be influenced by water?
				projectile.tileCollide = false;          //Can the projectile collide with tiles?
			}

			public override Color? GetAlpha(Color lightColor) {
				return new Color(240, 230, 140);
			}
		}
		public class InkArrowProjYellow13 : InkArrowProjBase
		{
			public override string Texture
			{
				get
				{
					return "Pyresense/Items/Ammo/InkArrowProj";
				}
			}

			public override void SetStaticDefaults() {
				DisplayName.SetDefault("Ink Arrow");     //The English name of the projectile
			}

			public override void SetDefaults() {
				projectile.CloneDefaults(1);
				projectile.friendly = true;         //Can the projectile deal damage to enemies?
				projectile.hostile = false;         //Can the projectile deal damage to the player?
				projectile.ranged = true;           //Is the projectile shoot by a ranged weapon?
				projectile.penetrate = 3;           //How many monsters the projectile can penetrate. (OnTileCollide below also decrements penetrate for bounces as well)
				projectile.timeLeft = 3600;          //The live time for the projectile (60 = 1 second, so 600 is 10 seconds)
				projectile.light = 0.5f;            //How much light emit around the projectile
				projectile.ignoreWater = true;          //Does the projectile's speed be influenced by water?
				projectile.tileCollide = false;          //Can the projectile collide with tiles?
			}

			public override Color? GetAlpha(Color lightColor) {
				return new Color(189, 183, 107);
			}
		}
	//Purple
		public class InkArrowProjPurple1 : InkArrowProjBase
		{
			public override string Texture
			{
				get
				{
					return "Pyresense/Items/Ammo/InkArrowProj";
				}
			}

			public override void SetStaticDefaults() {
				DisplayName.SetDefault("Ink Arrow");     //The English name of the projectile
			}

			public override void SetDefaults() {
				projectile.CloneDefaults(1);
				projectile.friendly = true;         //Can the projectile deal damage to enemies?
				projectile.hostile = false;         //Can the projectile deal damage to the player?
				projectile.ranged = true;           //Is the projectile shoot by a ranged weapon?
				projectile.penetrate = 3;           //How many monsters the projectile can penetrate. (OnTileCollide below also decrements penetrate for bounces as well)
				projectile.timeLeft = 3600;          //The live time for the projectile (60 = 1 second, so 600 is 10 seconds)
				projectile.light = 0.5f;            //How much light emit around the projectile
				projectile.ignoreWater = true;          //Does the projectile's speed be influenced by water?
				projectile.tileCollide = false;          //Can the projectile collide with tiles?
			}

			public override Color? GetAlpha(Color lightColor) {
				return new Color(230, 230, 250);
			}
		}
		public class InkArrowProjPurple2 : InkArrowProjBase
		{
			public override string Texture
			{
				get
				{
					return "Pyresense/Items/Ammo/InkArrowProj";
				}
			}

			public override void SetStaticDefaults() {
				DisplayName.SetDefault("Ink Arrow");     //The English name of the projectile
			}

			public override void SetDefaults() {
				projectile.CloneDefaults(1);
				projectile.friendly = true;         //Can the projectile deal damage to enemies?
				projectile.hostile = false;         //Can the projectile deal damage to the player?
				projectile.ranged = true;           //Is the projectile shoot by a ranged weapon?
				projectile.penetrate = 3;           //How many monsters the projectile can penetrate. (OnTileCollide below also decrements penetrate for bounces as well)
				projectile.timeLeft = 3600;          //The live time for the projectile (60 = 1 second, so 600 is 10 seconds)
				projectile.light = 0.5f;            //How much light emit around the projectile
				projectile.ignoreWater = true;          //Does the projectile's speed be influenced by water?
				projectile.tileCollide = false;          //Can the projectile collide with tiles?
			}

			public override Color? GetAlpha(Color lightColor) {
				return new Color(216, 191, 216);
			}
		}
		public class InkArrowProjPurple3 : InkArrowProjBase
		{
			public override string Texture
			{
				get
				{
					return "Pyresense/Items/Ammo/InkArrowProj";
				}
			}

			public override void SetStaticDefaults() {
				DisplayName.SetDefault("Ink Arrow");     //The English name of the projectile
			}

			public override void SetDefaults() {
				projectile.CloneDefaults(1);
				projectile.friendly = true;         //Can the projectile deal damage to enemies?
				projectile.hostile = false;         //Can the projectile deal damage to the player?
				projectile.ranged = true;           //Is the projectile shoot by a ranged weapon?
				projectile.penetrate = 3;           //How many monsters the projectile can penetrate. (OnTileCollide below also decrements penetrate for bounces as well)
				projectile.timeLeft = 3600;          //The live time for the projectile (60 = 1 second, so 600 is 10 seconds)
				projectile.light = 0.5f;            //How much light emit around the projectile
				projectile.ignoreWater = true;          //Does the projectile's speed be influenced by water?
				projectile.tileCollide = false;          //Can the projectile collide with tiles?
			}

			public override Color? GetAlpha(Color lightColor) {
				return new Color(221, 160, 221);
			}
		}
		public class InkArrowProjPurple4 : InkArrowProjBase
		{
			public override string Texture
			{
				get
				{
					return "Pyresense/Items/Ammo/InkArrowProj";
				}
			}

			public override void SetStaticDefaults() {
				DisplayName.SetDefault("Ink Arrow");     //The English name of the projectile
			}

			public override void SetDefaults() {
				projectile.CloneDefaults(1);
				projectile.friendly = true;         //Can the projectile deal damage to enemies?
				projectile.hostile = false;         //Can the projectile deal damage to the player?
				projectile.ranged = true;           //Is the projectile shoot by a ranged weapon?
				projectile.penetrate = 3;           //How many monsters the projectile can penetrate. (OnTileCollide below also decrements penetrate for bounces as well)
				projectile.timeLeft = 3600;          //The live time for the projectile (60 = 1 second, so 600 is 10 seconds)
				projectile.light = 0.5f;            //How much light emit around the projectile
				projectile.ignoreWater = true;          //Does the projectile's speed be influenced by water?
				projectile.tileCollide = false;          //Can the projectile collide with tiles?
			}

			public override Color? GetAlpha(Color lightColor) {
				return new Color(238, 130, 238);
			}
		}
		public class InkArrowProjPurple5 : InkArrowProjBase
		{
			public override string Texture
			{
				get
				{
					return "Pyresense/Items/Ammo/InkArrowProj";
				}
			}

			public override void SetStaticDefaults() {
				DisplayName.SetDefault("Ink Arrow");     //The English name of the projectile
			}

			public override void SetDefaults() {
				projectile.CloneDefaults(1);
				projectile.friendly = true;         //Can the projectile deal damage to enemies?
				projectile.hostile = false;         //Can the projectile deal damage to the player?
				projectile.ranged = true;           //Is the projectile shoot by a ranged weapon?
				projectile.penetrate = 3;           //How many monsters the projectile can penetrate. (OnTileCollide below also decrements penetrate for bounces as well)
				projectile.timeLeft = 3600;          //The live time for the projectile (60 = 1 second, so 600 is 10 seconds)
				projectile.light = 0.5f;            //How much light emit around the projectile
				projectile.ignoreWater = true;          //Does the projectile's speed be influenced by water?
				projectile.tileCollide = false;          //Can the projectile collide with tiles?
			}

			public override Color? GetAlpha(Color lightColor) {
				return new Color(218, 112, 214);
			}
		}
		public class InkArrowProjPurple6 : InkArrowProjBase
		{
			public override string Texture
			{
				get
				{
					return "Pyresense/Items/Ammo/InkArrowProj";
				}
			}

			public override void SetStaticDefaults() {
				DisplayName.SetDefault("Ink Arrow");     //The English name of the projectile
			}

			public override void SetDefaults() {
				projectile.CloneDefaults(1);
				projectile.friendly = true;         //Can the projectile deal damage to enemies?
				projectile.hostile = false;         //Can the projectile deal damage to the player?
				projectile.ranged = true;           //Is the projectile shoot by a ranged weapon?
				projectile.penetrate = 3;           //How many monsters the projectile can penetrate. (OnTileCollide below also decrements penetrate for bounces as well)
				projectile.timeLeft = 3600;          //The live time for the projectile (60 = 1 second, so 600 is 10 seconds)
				projectile.light = 0.5f;            //How much light emit around the projectile
				projectile.ignoreWater = true;          //Does the projectile's speed be influenced by water?
				projectile.tileCollide = false;          //Can the projectile collide with tiles?
			}

			public override Color? GetAlpha(Color lightColor) {
				return new Color(255, 0, 255);
			}
		}
		public class InkArrowProjPurple7 : InkArrowProjBase
		{
			public override string Texture
			{
				get
				{
					return "Pyresense/Items/Ammo/InkArrowProj";
				}
			}

			public override void SetStaticDefaults() {
				DisplayName.SetDefault("Ink Arrow");     //The English name of the projectile
			}

			public override void SetDefaults() {
				projectile.CloneDefaults(1);
				projectile.friendly = true;         //Can the projectile deal damage to enemies?
				projectile.hostile = false;         //Can the projectile deal damage to the player?
				projectile.ranged = true;           //Is the projectile shoot by a ranged weapon?
				projectile.penetrate = 3;           //How many monsters the projectile can penetrate. (OnTileCollide below also decrements penetrate for bounces as well)
				projectile.timeLeft = 3600;          //The live time for the projectile (60 = 1 second, so 600 is 10 seconds)
				projectile.light = 0.5f;            //How much light emit around the projectile
				projectile.ignoreWater = true;          //Does the projectile's speed be influenced by water?
				projectile.tileCollide = false;          //Can the projectile collide with tiles?
			}

			public override Color? GetAlpha(Color lightColor) {
				return new Color(255, 0, 255);
			}
		}
		public class InkArrowProjPurple8 : InkArrowProjBase
		{
			public override string Texture
			{
				get
				{
					return "Pyresense/Items/Ammo/InkArrowProj";
				}
			}

			public override void SetStaticDefaults() {
				DisplayName.SetDefault("Ink Arrow");     //The English name of the projectile
			}

			public override void SetDefaults() {
				projectile.CloneDefaults(1);
				projectile.friendly = true;         //Can the projectile deal damage to enemies?
				projectile.hostile = false;         //Can the projectile deal damage to the player?
				projectile.ranged = true;           //Is the projectile shoot by a ranged weapon?
				projectile.penetrate = 3;           //How many monsters the projectile can penetrate. (OnTileCollide below also decrements penetrate for bounces as well)
				projectile.timeLeft = 3600;          //The live time for the projectile (60 = 1 second, so 600 is 10 seconds)
				projectile.light = 0.5f;            //How much light emit around the projectile
				projectile.ignoreWater = true;          //Does the projectile's speed be influenced by water?
				projectile.tileCollide = false;          //Can the projectile collide with tiles?
			}

			public override Color? GetAlpha(Color lightColor) {
				return new Color(186, 85, 211);
			}
		}
		public class InkArrowProjPurple9 : InkArrowProjBase
		{
			public override string Texture
			{
				get
				{
					return "Pyresense/Items/Ammo/InkArrowProj";
				}
			}

			public override void SetStaticDefaults() {
				DisplayName.SetDefault("Ink Arrow");     //The English name of the projectile
			}

			public override void SetDefaults() {
				projectile.CloneDefaults(1);
				projectile.friendly = true;         //Can the projectile deal damage to enemies?
				projectile.hostile = false;         //Can the projectile deal damage to the player?
				projectile.ranged = true;           //Is the projectile shoot by a ranged weapon?
				projectile.penetrate = 3;           //How many monsters the projectile can penetrate. (OnTileCollide below also decrements penetrate for bounces as well)
				projectile.timeLeft = 3600;          //The live time for the projectile (60 = 1 second, so 600 is 10 seconds)
				projectile.light = 0.5f;            //How much light emit around the projectile
				projectile.ignoreWater = true;          //Does the projectile's speed be influenced by water?
				projectile.tileCollide = false;          //Can the projectile collide with tiles?
			}

			public override Color? GetAlpha(Color lightColor) {
				return new Color(147, 112, 219);
			}
		}
		public class InkArrowProjPurple10 : InkArrowProjBase
		{
			public override string Texture
			{
				get
				{
					return "Pyresense/Items/Ammo/InkArrowProj";
				}
			}

			public override void SetStaticDefaults() {
				DisplayName.SetDefault("Ink Arrow");     //The English name of the projectile
			}

			public override void SetDefaults() {
				projectile.CloneDefaults(1);
				projectile.friendly = true;         //Can the projectile deal damage to enemies?
				projectile.hostile = false;         //Can the projectile deal damage to the player?
				projectile.ranged = true;           //Is the projectile shoot by a ranged weapon?
				projectile.penetrate = 3;           //How many monsters the projectile can penetrate. (OnTileCollide below also decrements penetrate for bounces as well)
				projectile.timeLeft = 3600;          //The live time for the projectile (60 = 1 second, so 600 is 10 seconds)
				projectile.light = 0.5f;            //How much light emit around the projectile
				projectile.ignoreWater = true;          //Does the projectile's speed be influenced by water?
				projectile.tileCollide = false;          //Can the projectile collide with tiles?
			}

			public override Color? GetAlpha(Color lightColor) {
				return new Color(138, 43, 226);
			}
		}
		public class InkArrowProjPurple11 : InkArrowProjBase
		{
			public override string Texture
			{
				get
				{
					return "Pyresense/Items/Ammo/InkArrowProj";
				}
			}

			public override void SetStaticDefaults() {
				DisplayName.SetDefault("Ink Arrow");     //The English name of the projectile
			}

			public override void SetDefaults() {
				projectile.CloneDefaults(1);
				projectile.friendly = true;         //Can the projectile deal damage to enemies?
				projectile.hostile = false;         //Can the projectile deal damage to the player?
				projectile.ranged = true;           //Is the projectile shoot by a ranged weapon?
				projectile.penetrate = 3;           //How many monsters the projectile can penetrate. (OnTileCollide below also decrements penetrate for bounces as well)
				projectile.timeLeft = 3600;          //The live time for the projectile (60 = 1 second, so 600 is 10 seconds)
				projectile.light = 0.5f;            //How much light emit around the projectile
				projectile.ignoreWater = true;          //Does the projectile's speed be influenced by water?
				projectile.tileCollide = false;          //Can the projectile collide with tiles?
			}

			public override Color? GetAlpha(Color lightColor) {
				return new Color(148, 0, 211);
			}
		}
		public class InkArrowProjPurple12 : InkArrowProjBase
		{
			public override string Texture
			{
				get
				{
					return "Pyresense/Items/Ammo/InkArrowProj";
				}
			}

			public override void SetStaticDefaults() {
				DisplayName.SetDefault("Ink Arrow");     //The English name of the projectile
			}

			public override void SetDefaults() {
				projectile.CloneDefaults(1);
				projectile.friendly = true;         //Can the projectile deal damage to enemies?
				projectile.hostile = false;         //Can the projectile deal damage to the player?
				projectile.ranged = true;           //Is the projectile shoot by a ranged weapon?
				projectile.penetrate = 3;           //How many monsters the projectile can penetrate. (OnTileCollide below also decrements penetrate for bounces as well)
				projectile.timeLeft = 3600;          //The live time for the projectile (60 = 1 second, so 600 is 10 seconds)
				projectile.light = 0.5f;            //How much light emit around the projectile
				projectile.ignoreWater = true;          //Does the projectile's speed be influenced by water?
				projectile.tileCollide = false;          //Can the projectile collide with tiles?
			}

			public override Color? GetAlpha(Color lightColor) {
				return new Color(153, 50, 204);
			}
		}
		public class InkArrowProjPurple13 : InkArrowProjBase
		{
			public override string Texture
			{
				get
				{
					return "Pyresense/Items/Ammo/InkArrowProj";
				}
			}

			public override void SetStaticDefaults() {
				DisplayName.SetDefault("Ink Arrow");     //The English name of the projectile
			}

			public override void SetDefaults() {
				projectile.CloneDefaults(1);
				projectile.friendly = true;         //Can the projectile deal damage to enemies?
				projectile.hostile = false;         //Can the projectile deal damage to the player?
				projectile.ranged = true;           //Is the projectile shoot by a ranged weapon?
				projectile.penetrate = 3;           //How many monsters the projectile can penetrate. (OnTileCollide below also decrements penetrate for bounces as well)
				projectile.timeLeft = 3600;          //The live time for the projectile (60 = 1 second, so 600 is 10 seconds)
				projectile.light = 0.5f;            //How much light emit around the projectile
				projectile.ignoreWater = true;          //Does the projectile's speed be influenced by water?
				projectile.tileCollide = false;          //Can the projectile collide with tiles?
			}

			public override Color? GetAlpha(Color lightColor) {
				return new Color(139, 0, 139);
			}
		}
		public class InkArrowProjPurple14 : InkArrowProjBase
		{
			public override string Texture
			{
				get
				{
					return "Pyresense/Items/Ammo/InkArrowProj";
				}
			}

			public override void SetStaticDefaults() {
				DisplayName.SetDefault("Ink Arrow");     //The English name of the projectile
			}

			public override void SetDefaults() {
				projectile.CloneDefaults(1);
				projectile.friendly = true;         //Can the projectile deal damage to enemies?
				projectile.hostile = false;         //Can the projectile deal damage to the player?
				projectile.ranged = true;           //Is the projectile shoot by a ranged weapon?
				projectile.penetrate = 3;           //How many monsters the projectile can penetrate. (OnTileCollide below also decrements penetrate for bounces as well)
				projectile.timeLeft = 3600;          //The live time for the projectile (60 = 1 second, so 600 is 10 seconds)
				projectile.light = 0.5f;            //How much light emit around the projectile
				projectile.ignoreWater = true;          //Does the projectile's speed be influenced by water?
				projectile.tileCollide = false;          //Can the projectile collide with tiles?
			}

			public override Color? GetAlpha(Color lightColor) {
				return new Color(128, 0, 128);
			}
		}
		public class InkArrowProjPurple15 : InkArrowProjBase
		{
			public override string Texture
			{
				get
				{
					return "Pyresense/Items/Ammo/InkArrowProj";
				}
			}

			public override void SetStaticDefaults() {
				DisplayName.SetDefault("Ink Arrow");     //The English name of the projectile
			}

			public override void SetDefaults() {
				projectile.CloneDefaults(1);
				projectile.friendly = true;         //Can the projectile deal damage to enemies?
				projectile.hostile = false;         //Can the projectile deal damage to the player?
				projectile.ranged = true;           //Is the projectile shoot by a ranged weapon?
				projectile.penetrate = 3;           //How many monsters the projectile can penetrate. (OnTileCollide below also decrements penetrate for bounces as well)
				projectile.timeLeft = 3600;          //The live time for the projectile (60 = 1 second, so 600 is 10 seconds)
				projectile.light = 0.5f;            //How much light emit around the projectile
				projectile.ignoreWater = true;          //Does the projectile's speed be influenced by water?
				projectile.tileCollide = false;          //Can the projectile collide with tiles?
			}

			public override Color? GetAlpha(Color lightColor) {
				return new Color(75, 0, 130);
			}
		}
		public class InkArrowProjPurple16 : InkArrowProjBase
		{
			public override string Texture
			{
				get
				{
					return "Pyresense/Items/Ammo/InkArrowProj";
				}
			}

			public override void SetStaticDefaults() {
				DisplayName.SetDefault("Ink Arrow");     //The English name of the projectile
			}

			public override void SetDefaults() {
				projectile.CloneDefaults(1);
				projectile.friendly = true;         //Can the projectile deal damage to enemies?
				projectile.hostile = false;         //Can the projectile deal damage to the player?
				projectile.ranged = true;           //Is the projectile shoot by a ranged weapon?
				projectile.penetrate = 3;           //How many monsters the projectile can penetrate. (OnTileCollide below also decrements penetrate for bounces as well)
				projectile.timeLeft = 3600;          //The live time for the projectile (60 = 1 second, so 600 is 10 seconds)
				projectile.light = 0.5f;            //How much light emit around the projectile
				projectile.ignoreWater = true;          //Does the projectile's speed be influenced by water?
				projectile.tileCollide = false;          //Can the projectile collide with tiles?
			}

			public override Color? GetAlpha(Color lightColor) {
				return new Color(106, 90, 205);
			}
		}
		public class InkArrowProjPurple17 : InkArrowProjBase
		{
			public override string Texture
			{
				get
				{
					return "Pyresense/Items/Ammo/InkArrowProj";
				}
			}

			public override void SetStaticDefaults() {
				DisplayName.SetDefault("Ink Arrow");     //The English name of the projectile
			}

			public override void SetDefaults() {
				projectile.CloneDefaults(1);
				projectile.friendly = true;         //Can the projectile deal damage to enemies?
				projectile.hostile = false;         //Can the projectile deal damage to the player?
				projectile.ranged = true;           //Is the projectile shoot by a ranged weapon?
				projectile.penetrate = 3;           //How many monsters the projectile can penetrate. (OnTileCollide below also decrements penetrate for bounces as well)
				projectile.timeLeft = 3600;          //The live time for the projectile (60 = 1 second, so 600 is 10 seconds)
				projectile.light = 0.5f;            //How much light emit around the projectile
				projectile.ignoreWater = true;          //Does the projectile's speed be influenced by water?
				projectile.tileCollide = false;          //Can the projectile collide with tiles?
			}

			public override Color? GetAlpha(Color lightColor) {
				return new Color(72, 61, 139);
			}
		}
	//Brown
		public class InkArrowProjBrown1 : InkArrowProjBase
		{
			public override string Texture
			{
				get
				{
					return "Pyresense/Items/Ammo/InkArrowProj";
				}
			}

			public override void SetStaticDefaults() {
				DisplayName.SetDefault("Ink Arrow");     //The English name of the projectile
			}

			public override void SetDefaults() {
				projectile.CloneDefaults(1);
				projectile.friendly = true;         //Can the projectile deal damage to enemies?
				projectile.hostile = false;         //Can the projectile deal damage to the player?
				projectile.ranged = true;           //Is the projectile shoot by a ranged weapon?
				projectile.penetrate = 3;           //How many monsters the projectile can penetrate. (OnTileCollide below also decrements penetrate for bounces as well)
				projectile.timeLeft = 3600;          //The live time for the projectile (60 = 1 second, so 600 is 10 seconds)
				projectile.light = 0.5f;            //How much light emit around the projectile
				projectile.ignoreWater = true;          //Does the projectile's speed be influenced by water?
				projectile.tileCollide = false;          //Can the projectile collide with tiles?
			}

			public override Color? GetAlpha(Color lightColor) {
				return new Color(255, 248, 220);
			}
		}
		public class InkArrowProjBrown2 : InkArrowProjBase
		{
			public override string Texture
			{
				get
				{
					return "Pyresense/Items/Ammo/InkArrowProj";
				}
			}

			public override void SetStaticDefaults() {
				DisplayName.SetDefault("Ink Arrow");     //The English name of the projectile
			}

			public override void SetDefaults() {
				projectile.CloneDefaults(1);
				projectile.friendly = true;         //Can the projectile deal damage to enemies?
				projectile.hostile = false;         //Can the projectile deal damage to the player?
				projectile.ranged = true;           //Is the projectile shoot by a ranged weapon?
				projectile.penetrate = 3;           //How many monsters the projectile can penetrate. (OnTileCollide below also decrements penetrate for bounces as well)
				projectile.timeLeft = 3600;          //The live time for the projectile (60 = 1 second, so 600 is 10 seconds)
				projectile.light = 0.5f;            //How much light emit around the projectile
				projectile.ignoreWater = true;          //Does the projectile's speed be influenced by water?
				projectile.tileCollide = false;          //Can the projectile collide with tiles?
			}

			public override Color? GetAlpha(Color lightColor) {
				return new Color(255, 235, 205);
			}
		}
		public class InkArrowProjBrown3 : InkArrowProjBase
		{
			public override string Texture
			{
				get
				{
					return "Pyresense/Items/Ammo/InkArrowProj";
				}
			}

			public override void SetStaticDefaults() {
				DisplayName.SetDefault("Ink Arrow");     //The English name of the projectile
			}

			public override void SetDefaults() {
				projectile.CloneDefaults(1);
				projectile.friendly = true;         //Can the projectile deal damage to enemies?
				projectile.hostile = false;         //Can the projectile deal damage to the player?
				projectile.ranged = true;           //Is the projectile shoot by a ranged weapon?
				projectile.penetrate = 3;           //How many monsters the projectile can penetrate. (OnTileCollide below also decrements penetrate for bounces as well)
				projectile.timeLeft = 3600;          //The live time for the projectile (60 = 1 second, so 600 is 10 seconds)
				projectile.light = 0.5f;            //How much light emit around the projectile
				projectile.ignoreWater = true;          //Does the projectile's speed be influenced by water?
				projectile.tileCollide = false;          //Can the projectile collide with tiles?
			}

			public override Color? GetAlpha(Color lightColor) {
				return new Color(255, 228, 196);
			}
		}
		public class InkArrowProjBrown4 : InkArrowProjBase
		{
			public override string Texture
			{
				get
				{
					return "Pyresense/Items/Ammo/InkArrowProj";
				}
			}

			public override void SetStaticDefaults() {
				DisplayName.SetDefault("Ink Arrow");     //The English name of the projectile
			}

			public override void SetDefaults() {
				projectile.CloneDefaults(1);
				projectile.friendly = true;         //Can the projectile deal damage to enemies?
				projectile.hostile = false;         //Can the projectile deal damage to the player?
				projectile.ranged = true;           //Is the projectile shoot by a ranged weapon?
				projectile.penetrate = 3;           //How many monsters the projectile can penetrate. (OnTileCollide below also decrements penetrate for bounces as well)
				projectile.timeLeft = 3600;          //The live time for the projectile (60 = 1 second, so 600 is 10 seconds)
				projectile.light = 0.5f;            //How much light emit around the projectile
				projectile.ignoreWater = true;          //Does the projectile's speed be influenced by water?
				projectile.tileCollide = false;          //Can the projectile collide with tiles?
			}

			public override Color? GetAlpha(Color lightColor) {
				return new Color(255, 222, 173);
			}
		}
		public class InkArrowProjBrown5 : InkArrowProjBase
		{
			public override string Texture
			{
				get
				{
					return "Pyresense/Items/Ammo/InkArrowProj";
				}
			}

			public override void SetStaticDefaults() {
				DisplayName.SetDefault("Ink Arrow");     //The English name of the projectile
			}

			public override void SetDefaults() {
				projectile.CloneDefaults(1);
				projectile.friendly = true;         //Can the projectile deal damage to enemies?
				projectile.hostile = false;         //Can the projectile deal damage to the player?
				projectile.ranged = true;           //Is the projectile shoot by a ranged weapon?
				projectile.penetrate = 3;           //How many monsters the projectile can penetrate. (OnTileCollide below also decrements penetrate for bounces as well)
				projectile.timeLeft = 3600;          //The live time for the projectile (60 = 1 second, so 600 is 10 seconds)
				projectile.light = 0.5f;            //How much light emit around the projectile
				projectile.ignoreWater = true;          //Does the projectile's speed be influenced by water?
				projectile.tileCollide = false;          //Can the projectile collide with tiles?
			}

			public override Color? GetAlpha(Color lightColor) {
				return new Color(245, 222, 179);
			}
		}
		public class InkArrowProjBrown6 : InkArrowProjBase
		{
			public override string Texture
			{
				get
				{
					return "Pyresense/Items/Ammo/InkArrowProj";
				}
			}

			public override void SetStaticDefaults() {
				DisplayName.SetDefault("Ink Arrow");     //The English name of the projectile
			}

			public override void SetDefaults() {
				projectile.CloneDefaults(1);
				projectile.friendly = true;         //Can the projectile deal damage to enemies?
				projectile.hostile = false;         //Can the projectile deal damage to the player?
				projectile.ranged = true;           //Is the projectile shoot by a ranged weapon?
				projectile.penetrate = 3;           //How many monsters the projectile can penetrate. (OnTileCollide below also decrements penetrate for bounces as well)
				projectile.timeLeft = 3600;          //The live time for the projectile (60 = 1 second, so 600 is 10 seconds)
				projectile.light = 0.5f;            //How much light emit around the projectile
				projectile.ignoreWater = true;          //Does the projectile's speed be influenced by water?
				projectile.tileCollide = false;          //Can the projectile collide with tiles?
			}

			public override Color? GetAlpha(Color lightColor) {
				return new Color(222, 184, 135);
			}
		}
		public class InkArrowProjBrown7 : InkArrowProjBase
		{
			public override string Texture
			{
				get
				{
					return "Pyresense/Items/Ammo/InkArrowProj";
				}
			}

			public override void SetStaticDefaults() {
				DisplayName.SetDefault("Ink Arrow");     //The English name of the projectile
			}

			public override void SetDefaults() {
				projectile.CloneDefaults(1);
				projectile.friendly = true;         //Can the projectile deal damage to enemies?
				projectile.hostile = false;         //Can the projectile deal damage to the player?
				projectile.ranged = true;           //Is the projectile shoot by a ranged weapon?
				projectile.penetrate = 3;           //How many monsters the projectile can penetrate. (OnTileCollide below also decrements penetrate for bounces as well)
				projectile.timeLeft = 3600;          //The live time for the projectile (60 = 1 second, so 600 is 10 seconds)
				projectile.light = 0.5f;            //How much light emit around the projectile
				projectile.ignoreWater = true;          //Does the projectile's speed be influenced by water?
				projectile.tileCollide = false;          //Can the projectile collide with tiles?
			}

			public override Color? GetAlpha(Color lightColor) {
				return new Color(210, 180, 140);
			}
		}
		public class InkArrowProjBrown8 : InkArrowProjBase
		{
			public override string Texture
			{
				get
				{
					return "Pyresense/Items/Ammo/InkArrowProj";
				}
			}

			public override void SetStaticDefaults() {
				DisplayName.SetDefault("Ink Arrow");     //The English name of the projectile
			}

			public override void SetDefaults() {
				projectile.CloneDefaults(1);
				projectile.friendly = true;         //Can the projectile deal damage to enemies?
				projectile.hostile = false;         //Can the projectile deal damage to the player?
				projectile.ranged = true;           //Is the projectile shoot by a ranged weapon?
				projectile.penetrate = 3;           //How many monsters the projectile can penetrate. (OnTileCollide below also decrements penetrate for bounces as well)
				projectile.timeLeft = 3600;          //The live time for the projectile (60 = 1 second, so 600 is 10 seconds)
				projectile.light = 0.5f;            //How much light emit around the projectile
				projectile.ignoreWater = true;          //Does the projectile's speed be influenced by water?
				projectile.tileCollide = false;          //Can the projectile collide with tiles?
			}

			public override Color? GetAlpha(Color lightColor) {
				return new Color(188, 143, 143);
			}
		}
		public class InkArrowProjBrown9 : InkArrowProjBase
		{
			public override string Texture
			{
				get
				{
					return "Pyresense/Items/Ammo/InkArrowProj";
				}
			}

			public override void SetStaticDefaults() {
				DisplayName.SetDefault("Ink Arrow");     //The English name of the projectile
			}

			public override void SetDefaults() {
				projectile.CloneDefaults(1);
				projectile.friendly = true;         //Can the projectile deal damage to enemies?
				projectile.hostile = false;         //Can the projectile deal damage to the player?
				projectile.ranged = true;           //Is the projectile shoot by a ranged weapon?
				projectile.penetrate = 3;           //How many monsters the projectile can penetrate. (OnTileCollide below also decrements penetrate for bounces as well)
				projectile.timeLeft = 3600;          //The live time for the projectile (60 = 1 second, so 600 is 10 seconds)
				projectile.light = 0.5f;            //How much light emit around the projectile
				projectile.ignoreWater = true;          //Does the projectile's speed be influenced by water?
				projectile.tileCollide = false;          //Can the projectile collide with tiles?
			}

			public override Color? GetAlpha(Color lightColor) {
				return new Color(244, 164, 96);
			}
		}
		public class InkArrowProjBrown10 : InkArrowProjBase
		{
			public override string Texture
			{
				get
				{
					return "Pyresense/Items/Ammo/InkArrowProj";
				}
			}

			public override void SetStaticDefaults() {
				DisplayName.SetDefault("Ink Arrow");     //The English name of the projectile
			}

			public override void SetDefaults() {
				projectile.CloneDefaults(1);
				projectile.friendly = true;         //Can the projectile deal damage to enemies?
				projectile.hostile = false;         //Can the projectile deal damage to the player?
				projectile.ranged = true;           //Is the projectile shoot by a ranged weapon?
				projectile.penetrate = 3;           //How many monsters the projectile can penetrate. (OnTileCollide below also decrements penetrate for bounces as well)
				projectile.timeLeft = 3600;          //The live time for the projectile (60 = 1 second, so 600 is 10 seconds)
				projectile.light = 0.5f;            //How much light emit around the projectile
				projectile.ignoreWater = true;          //Does the projectile's speed be influenced by water?
				projectile.tileCollide = false;          //Can the projectile collide with tiles?
			}

			public override Color? GetAlpha(Color lightColor) {
				return new Color(218, 165, 32);
			}
		}
		public class InkArrowProjBrown11 : InkArrowProjBase
		{
			public override string Texture
			{
				get
				{
					return "Pyresense/Items/Ammo/InkArrowProj";
				}
			}

			public override void SetStaticDefaults() {
				DisplayName.SetDefault("Ink Arrow");     //The English name of the projectile
			}

			public override void SetDefaults() {
				projectile.CloneDefaults(1);
				projectile.friendly = true;         //Can the projectile deal damage to enemies?
				projectile.hostile = false;         //Can the projectile deal damage to the player?
				projectile.ranged = true;           //Is the projectile shoot by a ranged weapon?
				projectile.penetrate = 3;           //How many monsters the projectile can penetrate. (OnTileCollide below also decrements penetrate for bounces as well)
				projectile.timeLeft = 3600;          //The live time for the projectile (60 = 1 second, so 600 is 10 seconds)
				projectile.light = 0.5f;            //How much light emit around the projectile
				projectile.ignoreWater = true;          //Does the projectile's speed be influenced by water?
				projectile.tileCollide = false;          //Can the projectile collide with tiles?
			}

			public override Color? GetAlpha(Color lightColor) {
				return new Color(184, 134, 11);
			}
		}
		public class InkArrowProjBrown12 : InkArrowProjBase
		{
			public override string Texture
			{
				get
				{
					return "Pyresense/Items/Ammo/InkArrowProj";
				}
			}

			public override void SetStaticDefaults() {
				DisplayName.SetDefault("Ink Arrow");     //The English name of the projectile
			}

			public override void SetDefaults() {
				projectile.CloneDefaults(1);
				projectile.friendly = true;         //Can the projectile deal damage to enemies?
				projectile.hostile = false;         //Can the projectile deal damage to the player?
				projectile.ranged = true;           //Is the projectile shoot by a ranged weapon?
				projectile.penetrate = 3;           //How many monsters the projectile can penetrate. (OnTileCollide below also decrements penetrate for bounces as well)
				projectile.timeLeft = 3600;          //The live time for the projectile (60 = 1 second, so 600 is 10 seconds)
				projectile.light = 0.5f;            //How much light emit around the projectile
				projectile.ignoreWater = true;          //Does the projectile's speed be influenced by water?
				projectile.tileCollide = false;          //Can the projectile collide with tiles?
			}

			public override Color? GetAlpha(Color lightColor) {
				return new Color(205, 133, 63);
			}
		}
		public class InkArrowProjBrown13 : InkArrowProjBase
		{
			public override string Texture
			{
				get
				{
					return "Pyresense/Items/Ammo/InkArrowProj";
				}
			}

			public override void SetStaticDefaults() {
				DisplayName.SetDefault("Ink Arrow");     //The English name of the projectile
			}

			public override void SetDefaults() {
				projectile.CloneDefaults(1);
				projectile.friendly = true;         //Can the projectile deal damage to enemies?
				projectile.hostile = false;         //Can the projectile deal damage to the player?
				projectile.ranged = true;           //Is the projectile shoot by a ranged weapon?
				projectile.penetrate = 3;           //How many monsters the projectile can penetrate. (OnTileCollide below also decrements penetrate for bounces as well)
				projectile.timeLeft = 3600;          //The live time for the projectile (60 = 1 second, so 600 is 10 seconds)
				projectile.light = 0.5f;            //How much light emit around the projectile
				projectile.ignoreWater = true;          //Does the projectile's speed be influenced by water?
				projectile.tileCollide = false;          //Can the projectile collide with tiles?
			}

			public override Color? GetAlpha(Color lightColor) {
				return new Color(210, 105, 30);
			}
		}
		public class InkArrowProjBrown14 : InkArrowProjBase
		{
			public override string Texture
			{
				get
				{
					return "Pyresense/Items/Ammo/InkArrowProj";
				}
			}

			public override void SetStaticDefaults() {
				DisplayName.SetDefault("Ink Arrow");     //The English name of the projectile
			}

			public override void SetDefaults() {
				projectile.CloneDefaults(1);
				projectile.friendly = true;         //Can the projectile deal damage to enemies?
				projectile.hostile = false;         //Can the projectile deal damage to the player?
				projectile.ranged = true;           //Is the projectile shoot by a ranged weapon?
				projectile.penetrate = 3;           //How many monsters the projectile can penetrate. (OnTileCollide below also decrements penetrate for bounces as well)
				projectile.timeLeft = 3600;          //The live time for the projectile (60 = 1 second, so 600 is 10 seconds)
				projectile.light = 0.5f;            //How much light emit around the projectile
				projectile.ignoreWater = true;          //Does the projectile's speed be influenced by water?
				projectile.tileCollide = false;          //Can the projectile collide with tiles?
			}

			public override Color? GetAlpha(Color lightColor) {
				return new Color(139, 69, 19);
			}
		}
		public class InkArrowProjBrown15 : InkArrowProjBase
		{
			public override string Texture
			{
				get
				{
					return "Pyresense/Items/Ammo/InkArrowProj";
				}
			}

			public override void SetStaticDefaults() {
				DisplayName.SetDefault("Ink Arrow");     //The English name of the projectile
			}

			public override void SetDefaults() {
				projectile.CloneDefaults(1);
				projectile.friendly = true;         //Can the projectile deal damage to enemies?
				projectile.hostile = false;         //Can the projectile deal damage to the player?
				projectile.ranged = true;           //Is the projectile shoot by a ranged weapon?
				projectile.penetrate = 3;           //How many monsters the projectile can penetrate. (OnTileCollide below also decrements penetrate for bounces as well)
				projectile.timeLeft = 3600;          //The live time for the projectile (60 = 1 second, so 600 is 10 seconds)
				projectile.light = 0.5f;            //How much light emit around the projectile
				projectile.ignoreWater = true;          //Does the projectile's speed be influenced by water?
				projectile.tileCollide = false;          //Can the projectile collide with tiles?
			}

			public override Color? GetAlpha(Color lightColor) {
				return new Color(160, 82, 45);
			}
		}
		public class InkArrowProjBrown16 : InkArrowProjBase
		{
			public override string Texture
			{
				get
				{
					return "Pyresense/Items/Ammo/InkArrowProj";
				}
			}

			public override void SetStaticDefaults() {
				DisplayName.SetDefault("Ink Arrow");     //The English name of the projectile
			}

			public override void SetDefaults() {
				projectile.CloneDefaults(1);
				projectile.friendly = true;         //Can the projectile deal damage to enemies?
				projectile.hostile = false;         //Can the projectile deal damage to the player?
				projectile.ranged = true;           //Is the projectile shoot by a ranged weapon?
				projectile.penetrate = 3;           //How many monsters the projectile can penetrate. (OnTileCollide below also decrements penetrate for bounces as well)
				projectile.timeLeft = 3600;          //The live time for the projectile (60 = 1 second, so 600 is 10 seconds)
				projectile.light = 0.5f;            //How much light emit around the projectile
				projectile.ignoreWater = true;          //Does the projectile's speed be influenced by water?
				projectile.tileCollide = false;          //Can the projectile collide with tiles?
			}

			public override Color? GetAlpha(Color lightColor) {
				return new Color(165, 42, 42);
			}
		}
		public class InkArrowProjBrown17 : InkArrowProjBase
		{
			public override string Texture
			{
				get
				{
					return "Pyresense/Items/Ammo/InkArrowProj";
				}
			}

			public override void SetStaticDefaults() {
				DisplayName.SetDefault("Ink Arrow");     //The English name of the projectile
			}

			public override void SetDefaults() {
				projectile.CloneDefaults(1);
				projectile.friendly = true;         //Can the projectile deal damage to enemies?
				projectile.hostile = false;         //Can the projectile deal damage to the player?
				projectile.ranged = true;           //Is the projectile shoot by a ranged weapon?
				projectile.penetrate = 3;           //How many monsters the projectile can penetrate. (OnTileCollide below also decrements penetrate for bounces as well)
				projectile.timeLeft = 3600;          //The live time for the projectile (60 = 1 second, so 600 is 10 seconds)
				projectile.light = 0.5f;            //How much light emit around the projectile
				projectile.ignoreWater = true;          //Does the projectile's speed be influenced by water?
				projectile.tileCollide = false;          //Can the projectile collide with tiles?
			}

			public override Color? GetAlpha(Color lightColor) {
				return new Color(128, 0, 0);
			}
		}
	//Green
		public class InkArrowProjGreen1 : InkArrowProjBase
		{
			public override string Texture
			{
				get
				{
					return "Pyresense/Items/Ammo/InkArrowProj";
				}
			}

			public override void SetStaticDefaults() {
				DisplayName.SetDefault("Ink Arrow");     //The English name of the projectile
			}

			public override void SetDefaults() {
				projectile.CloneDefaults(1);
				projectile.friendly = true;         //Can the projectile deal damage to enemies?
				projectile.hostile = false;         //Can the projectile deal damage to the player?
				projectile.ranged = true;           //Is the projectile shoot by a ranged weapon?
				projectile.penetrate = 3;           //How many monsters the projectile can penetrate. (OnTileCollide below also decrements penetrate for bounces as well)
				projectile.timeLeft = 3600;          //The live time for the projectile (60 = 1 second, so 600 is 10 seconds)
				projectile.light = 0.5f;            //How much light emit around the projectile
				projectile.ignoreWater = true;          //Does the projectile's speed be influenced by water?
				projectile.tileCollide = false;          //Can the projectile collide with tiles?
			}

			public override Color? GetAlpha(Color lightColor) {
				return new Color(173, 255, 47);
			}
		}
		public class InkArrowProjGreen2 : InkArrowProjBase
		{
			public override string Texture
			{
				get
				{
					return "Pyresense/Items/Ammo/InkArrowProj";
				}
			}

			public override void SetStaticDefaults() {
				DisplayName.SetDefault("Ink Arrow");     //The English name of the projectile
			}

			public override void SetDefaults() {
				projectile.CloneDefaults(1);
				projectile.friendly = true;         //Can the projectile deal damage to enemies?
				projectile.hostile = false;         //Can the projectile deal damage to the player?
				projectile.ranged = true;           //Is the projectile shoot by a ranged weapon?
				projectile.penetrate = 3;           //How many monsters the projectile can penetrate. (OnTileCollide below also decrements penetrate for bounces as well)
				projectile.timeLeft = 3600;          //The live time for the projectile (60 = 1 second, so 600 is 10 seconds)
				projectile.light = 0.5f;            //How much light emit around the projectile
				projectile.ignoreWater = true;          //Does the projectile's speed be influenced by water?
				projectile.tileCollide = false;          //Can the projectile collide with tiles?
			}

			public override Color? GetAlpha(Color lightColor) {
				return new Color(127, 255, 0);
			}
		}
		public class InkArrowProjGreen3 : InkArrowProjBase
		{
			public override string Texture
			{
				get
				{
					return "Pyresense/Items/Ammo/InkArrowProj";
				}
			}

			public override void SetStaticDefaults() {
				DisplayName.SetDefault("Ink Arrow");     //The English name of the projectile
			}

			public override void SetDefaults() {
				projectile.CloneDefaults(1);
				projectile.friendly = true;         //Can the projectile deal damage to enemies?
				projectile.hostile = false;         //Can the projectile deal damage to the player?
				projectile.ranged = true;           //Is the projectile shoot by a ranged weapon?
				projectile.penetrate = 3;           //How many monsters the projectile can penetrate. (OnTileCollide below also decrements penetrate for bounces as well)
				projectile.timeLeft = 3600;          //The live time for the projectile (60 = 1 second, so 600 is 10 seconds)
				projectile.light = 0.5f;            //How much light emit around the projectile
				projectile.ignoreWater = true;          //Does the projectile's speed be influenced by water?
				projectile.tileCollide = false;          //Can the projectile collide with tiles?
			}

			public override Color? GetAlpha(Color lightColor) {
				return new Color(124, 252, 0);
			}
		}
		public class InkArrowProjGreen4 : InkArrowProjBase
		{
			public override string Texture
			{
				get
				{
					return "Pyresense/Items/Ammo/InkArrowProj";
				}
			}

			public override void SetStaticDefaults() {
				DisplayName.SetDefault("Ink Arrow");     //The English name of the projectile
			}

			public override void SetDefaults() {
				projectile.CloneDefaults(1);
				projectile.friendly = true;         //Can the projectile deal damage to enemies?
				projectile.hostile = false;         //Can the projectile deal damage to the player?
				projectile.ranged = true;           //Is the projectile shoot by a ranged weapon?
				projectile.penetrate = 3;           //How many monsters the projectile can penetrate. (OnTileCollide below also decrements penetrate for bounces as well)
				projectile.timeLeft = 3600;          //The live time for the projectile (60 = 1 second, so 600 is 10 seconds)
				projectile.light = 0.5f;            //How much light emit around the projectile
				projectile.ignoreWater = true;          //Does the projectile's speed be influenced by water?
				projectile.tileCollide = false;          //Can the projectile collide with tiles?
			}

			public override Color? GetAlpha(Color lightColor) {
				return new Color(0, 255, 0);
			}
		}
		public class InkArrowProjGreen5 : InkArrowProjBase
		{
			public override string Texture
			{
				get
				{
					return "Pyresense/Items/Ammo/InkArrowProj";
				}
			}

			public override void SetStaticDefaults() {
				DisplayName.SetDefault("Ink Arrow");     //The English name of the projectile
			}

			public override void SetDefaults() {
				projectile.CloneDefaults(1);
				projectile.friendly = true;         //Can the projectile deal damage to enemies?
				projectile.hostile = false;         //Can the projectile deal damage to the player?
				projectile.ranged = true;           //Is the projectile shoot by a ranged weapon?
				projectile.penetrate = 3;           //How many monsters the projectile can penetrate. (OnTileCollide below also decrements penetrate for bounces as well)
				projectile.timeLeft = 3600;          //The live time for the projectile (60 = 1 second, so 600 is 10 seconds)
				projectile.light = 0.5f;            //How much light emit around the projectile
				projectile.ignoreWater = true;          //Does the projectile's speed be influenced by water?
				projectile.tileCollide = false;          //Can the projectile collide with tiles?
			}

			public override Color? GetAlpha(Color lightColor) {
				return new Color(50, 205, 50);
			}
		}
		public class InkArrowProjGreen6 : InkArrowProjBase
		{
			public override string Texture
			{
				get
				{
					return "Pyresense/Items/Ammo/InkArrowProj";
				}
			}

			public override void SetStaticDefaults() {
				DisplayName.SetDefault("Ink Arrow");     //The English name of the projectile
			}

			public override void SetDefaults() {
				projectile.CloneDefaults(1);
				projectile.friendly = true;         //Can the projectile deal damage to enemies?
				projectile.hostile = false;         //Can the projectile deal damage to the player?
				projectile.ranged = true;           //Is the projectile shoot by a ranged weapon?
				projectile.penetrate = 3;           //How many monsters the projectile can penetrate. (OnTileCollide below also decrements penetrate for bounces as well)
				projectile.timeLeft = 3600;          //The live time for the projectile (60 = 1 second, so 600 is 10 seconds)
				projectile.light = 0.5f;            //How much light emit around the projectile
				projectile.ignoreWater = true;          //Does the projectile's speed be influenced by water?
				projectile.tileCollide = false;          //Can the projectile collide with tiles?
			}

			public override Color? GetAlpha(Color lightColor) {
				return new Color(152, 251, 152);
			}
		}
		public class InkArrowProjGreen7 : InkArrowProjBase
		{
			public override string Texture
			{
				get
				{
					return "Pyresense/Items/Ammo/InkArrowProj";
				}
			}

			public override void SetStaticDefaults() {
				DisplayName.SetDefault("Ink Arrow");     //The English name of the projectile
			}

			public override void SetDefaults() {
				projectile.CloneDefaults(1);
				projectile.friendly = true;         //Can the projectile deal damage to enemies?
				projectile.hostile = false;         //Can the projectile deal damage to the player?
				projectile.ranged = true;           //Is the projectile shoot by a ranged weapon?
				projectile.penetrate = 3;           //How many monsters the projectile can penetrate. (OnTileCollide below also decrements penetrate for bounces as well)
				projectile.timeLeft = 3600;          //The live time for the projectile (60 = 1 second, so 600 is 10 seconds)
				projectile.light = 0.5f;            //How much light emit around the projectile
				projectile.ignoreWater = true;          //Does the projectile's speed be influenced by water?
				projectile.tileCollide = false;          //Can the projectile collide with tiles?
			}

			public override Color? GetAlpha(Color lightColor) {
				return new Color(144, 238, 144);
			}
		}
		public class InkArrowProjGreen8 : InkArrowProjBase
		{
			public override string Texture
			{
				get
				{
					return "Pyresense/Items/Ammo/InkArrowProj";
				}
			}

			public override void SetStaticDefaults() {
				DisplayName.SetDefault("Ink Arrow");     //The English name of the projectile
			}

			public override void SetDefaults() {
				projectile.CloneDefaults(1);
				projectile.friendly = true;         //Can the projectile deal damage to enemies?
				projectile.hostile = false;         //Can the projectile deal damage to the player?
				projectile.ranged = true;           //Is the projectile shoot by a ranged weapon?
				projectile.penetrate = 3;           //How many monsters the projectile can penetrate. (OnTileCollide below also decrements penetrate for bounces as well)
				projectile.timeLeft = 3600;          //The live time for the projectile (60 = 1 second, so 600 is 10 seconds)
				projectile.light = 0.5f;            //How much light emit around the projectile
				projectile.ignoreWater = true;          //Does the projectile's speed be influenced by water?
				projectile.tileCollide = false;          //Can the projectile collide with tiles?
			}

			public override Color? GetAlpha(Color lightColor) {
				return new Color(0, 250, 154);
			}
		}
		public class InkArrowProjGreen9 : InkArrowProjBase
		{
			public override string Texture
			{
				get
				{
					return "Pyresense/Items/Ammo/InkArrowProj";
				}
			}

			public override void SetStaticDefaults() {
				DisplayName.SetDefault("Ink Arrow");     //The English name of the projectile
			}

			public override void SetDefaults() {
				projectile.CloneDefaults(1);
				projectile.friendly = true;         //Can the projectile deal damage to enemies?
				projectile.hostile = false;         //Can the projectile deal damage to the player?
				projectile.ranged = true;           //Is the projectile shoot by a ranged weapon?
				projectile.penetrate = 3;           //How many monsters the projectile can penetrate. (OnTileCollide below also decrements penetrate for bounces as well)
				projectile.timeLeft = 3600;          //The live time for the projectile (60 = 1 second, so 600 is 10 seconds)
				projectile.light = 0.5f;            //How much light emit around the projectile
				projectile.ignoreWater = true;          //Does the projectile's speed be influenced by water?
				projectile.tileCollide = false;          //Can the projectile collide with tiles?
			}

			public override Color? GetAlpha(Color lightColor) {
				return new Color(0, 255, 127);
			}
		}
		public class InkArrowProjGreen10 : InkArrowProjBase
		{
			public override string Texture
			{
				get
				{
					return "Pyresense/Items/Ammo/InkArrowProj";
				}
			}

			public override void SetStaticDefaults() {
				DisplayName.SetDefault("Ink Arrow");     //The English name of the projectile
			}

			public override void SetDefaults() {
				projectile.CloneDefaults(1);
				projectile.friendly = true;         //Can the projectile deal damage to enemies?
				projectile.hostile = false;         //Can the projectile deal damage to the player?
				projectile.ranged = true;           //Is the projectile shoot by a ranged weapon?
				projectile.penetrate = 3;           //How many monsters the projectile can penetrate. (OnTileCollide below also decrements penetrate for bounces as well)
				projectile.timeLeft = 3600;          //The live time for the projectile (60 = 1 second, so 600 is 10 seconds)
				projectile.light = 0.5f;            //How much light emit around the projectile
				projectile.ignoreWater = true;          //Does the projectile's speed be influenced by water?
				projectile.tileCollide = false;          //Can the projectile collide with tiles?
			}

			public override Color? GetAlpha(Color lightColor) {
				return new Color(60, 179, 113);
			}
		}
		public class InkArrowProjGreen11 : InkArrowProjBase
		{
			public override string Texture
			{
				get
				{
					return "Pyresense/Items/Ammo/InkArrowProj";
				}
			}

			public override void SetStaticDefaults() {
				DisplayName.SetDefault("Ink Arrow");     //The English name of the projectile
			}

			public override void SetDefaults() {
				projectile.CloneDefaults(1);
				projectile.friendly = true;         //Can the projectile deal damage to enemies?
				projectile.hostile = false;         //Can the projectile deal damage to the player?
				projectile.ranged = true;           //Is the projectile shoot by a ranged weapon?
				projectile.penetrate = 3;           //How many monsters the projectile can penetrate. (OnTileCollide below also decrements penetrate for bounces as well)
				projectile.timeLeft = 3600;          //The live time for the projectile (60 = 1 second, so 600 is 10 seconds)
				projectile.light = 0.5f;            //How much light emit around the projectile
				projectile.ignoreWater = true;          //Does the projectile's speed be influenced by water?
				projectile.tileCollide = false;          //Can the projectile collide with tiles?
			}

			public override Color? GetAlpha(Color lightColor) {
				return new Color(46, 139, 87);
			}
		}
		public class InkArrowProjGreen12 : InkArrowProjBase
		{
			public override string Texture
			{
				get
				{
					return "Pyresense/Items/Ammo/InkArrowProj";
				}
			}

			public override void SetStaticDefaults() {
				DisplayName.SetDefault("Ink Arrow");     //The English name of the projectile
			}

			public override void SetDefaults() {
				projectile.CloneDefaults(1);
				projectile.friendly = true;         //Can the projectile deal damage to enemies?
				projectile.hostile = false;         //Can the projectile deal damage to the player?
				projectile.ranged = true;           //Is the projectile shoot by a ranged weapon?
				projectile.penetrate = 3;           //How many monsters the projectile can penetrate. (OnTileCollide below also decrements penetrate for bounces as well)
				projectile.timeLeft = 3600;          //The live time for the projectile (60 = 1 second, so 600 is 10 seconds)
				projectile.light = 0.5f;            //How much light emit around the projectile
				projectile.ignoreWater = true;          //Does the projectile's speed be influenced by water?
				projectile.tileCollide = false;          //Can the projectile collide with tiles?
			}

			public override Color? GetAlpha(Color lightColor) {
				return new Color(34, 139, 34);
			}
		}
		public class InkArrowProjGreen13 : InkArrowProjBase
		{
			public override string Texture
			{
				get
				{
					return "Pyresense/Items/Ammo/InkArrowProj";
				}
			}

			public override void SetStaticDefaults() {
				DisplayName.SetDefault("Ink Arrow");     //The English name of the projectile
			}

			public override void SetDefaults() {
				projectile.CloneDefaults(1);
				projectile.friendly = true;         //Can the projectile deal damage to enemies?
				projectile.hostile = false;         //Can the projectile deal damage to the player?
				projectile.ranged = true;           //Is the projectile shoot by a ranged weapon?
				projectile.penetrate = 3;           //How many monsters the projectile can penetrate. (OnTileCollide below also decrements penetrate for bounces as well)
				projectile.timeLeft = 3600;          //The live time for the projectile (60 = 1 second, so 600 is 10 seconds)
				projectile.light = 0.5f;            //How much light emit around the projectile
				projectile.ignoreWater = true;          //Does the projectile's speed be influenced by water?
				projectile.tileCollide = false;          //Can the projectile collide with tiles?
			}

			public override Color? GetAlpha(Color lightColor) {
				return new Color(0, 128, 0);
			}
		}
		public class InkArrowProjGreen14 : InkArrowProjBase
		{
			public override string Texture
			{
				get
				{
					return "Pyresense/Items/Ammo/InkArrowProj";
				}
			}

			public override void SetStaticDefaults() {
				DisplayName.SetDefault("Ink Arrow");     //The English name of the projectile
			}

			public override void SetDefaults() {
				projectile.CloneDefaults(1);
				projectile.friendly = true;         //Can the projectile deal damage to enemies?
				projectile.hostile = false;         //Can the projectile deal damage to the player?
				projectile.ranged = true;           //Is the projectile shoot by a ranged weapon?
				projectile.penetrate = 3;           //How many monsters the projectile can penetrate. (OnTileCollide below also decrements penetrate for bounces as well)
				projectile.timeLeft = 3600;          //The live time for the projectile (60 = 1 second, so 600 is 10 seconds)
				projectile.light = 0.5f;            //How much light emit around the projectile
				projectile.ignoreWater = true;          //Does the projectile's speed be influenced by water?
				projectile.tileCollide = false;          //Can the projectile collide with tiles?
			}

			public override Color? GetAlpha(Color lightColor) {
				return new Color(0, 100, 0);
			}
		}
		public class InkArrowProjGreen15 : InkArrowProjBase
		{
			public override string Texture
			{
				get
				{
					return "Pyresense/Items/Ammo/InkArrowProj";
				}
			}

			public override void SetStaticDefaults() {
				DisplayName.SetDefault("Ink Arrow");     //The English name of the projectile
			}

			public override void SetDefaults() {
				projectile.CloneDefaults(1);
				projectile.friendly = true;         //Can the projectile deal damage to enemies?
				projectile.hostile = false;         //Can the projectile deal damage to the player?
				projectile.ranged = true;           //Is the projectile shoot by a ranged weapon?
				projectile.penetrate = 3;           //How many monsters the projectile can penetrate. (OnTileCollide below also decrements penetrate for bounces as well)
				projectile.timeLeft = 3600;          //The live time for the projectile (60 = 1 second, so 600 is 10 seconds)
				projectile.light = 0.5f;            //How much light emit around the projectile
				projectile.ignoreWater = true;          //Does the projectile's speed be influenced by water?
				projectile.tileCollide = false;          //Can the projectile collide with tiles?
			}

			public override Color? GetAlpha(Color lightColor) {
				return new Color(154, 205, 50);
			}
		}
		public class InkArrowProjGreen16 : InkArrowProjBase
		{
			public override string Texture
			{
				get
				{
					return "Pyresense/Items/Ammo/InkArrowProj";
				}
			}

			public override void SetStaticDefaults() {
				DisplayName.SetDefault("Ink Arrow");     //The English name of the projectile
			}

			public override void SetDefaults() {
				projectile.CloneDefaults(1);
				projectile.friendly = true;         //Can the projectile deal damage to enemies?
				projectile.hostile = false;         //Can the projectile deal damage to the player?
				projectile.ranged = true;           //Is the projectile shoot by a ranged weapon?
				projectile.penetrate = 3;           //How many monsters the projectile can penetrate. (OnTileCollide below also decrements penetrate for bounces as well)
				projectile.timeLeft = 3600;          //The live time for the projectile (60 = 1 second, so 600 is 10 seconds)
				projectile.light = 0.5f;            //How much light emit around the projectile
				projectile.ignoreWater = true;          //Does the projectile's speed be influenced by water?
				projectile.tileCollide = false;          //Can the projectile collide with tiles?
			}

			public override Color? GetAlpha(Color lightColor) {
				return new Color(107, 142, 35);
			}
		}
		public class InkArrowProjGreen17 : InkArrowProjBase
		{
			public override string Texture
			{
				get
				{
					return "Pyresense/Items/Ammo/InkArrowProj";
				}
			}

			public override void SetStaticDefaults() {
				DisplayName.SetDefault("Ink Arrow");     //The English name of the projectile
			}

			public override void SetDefaults() {
				projectile.CloneDefaults(1);
				projectile.friendly = true;         //Can the projectile deal damage to enemies?
				projectile.hostile = false;         //Can the projectile deal damage to the player?
				projectile.ranged = true;           //Is the projectile shoot by a ranged weapon?
				projectile.penetrate = 3;           //How many monsters the projectile can penetrate. (OnTileCollide below also decrements penetrate for bounces as well)
				projectile.timeLeft = 3600;          //The live time for the projectile (60 = 1 second, so 600 is 10 seconds)
				projectile.light = 0.5f;            //How much light emit around the projectile
				projectile.ignoreWater = true;          //Does the projectile's speed be influenced by water?
				projectile.tileCollide = false;          //Can the projectile collide with tiles?
			}

			public override Color? GetAlpha(Color lightColor) {
				return new Color(128, 128, 0);
			}
		}
		public class InkArrowProjGreen18 : InkArrowProjBase
		{
			public override string Texture
			{
				get
				{
					return "Pyresense/Items/Ammo/InkArrowProj";
				}
			}

			public override void SetStaticDefaults() {
				DisplayName.SetDefault("Ink Arrow");     //The English name of the projectile
			}

			public override void SetDefaults() {
				projectile.CloneDefaults(1);
				projectile.friendly = true;         //Can the projectile deal damage to enemies?
				projectile.hostile = false;         //Can the projectile deal damage to the player?
				projectile.ranged = true;           //Is the projectile shoot by a ranged weapon?
				projectile.penetrate = 3;           //How many monsters the projectile can penetrate. (OnTileCollide below also decrements penetrate for bounces as well)
				projectile.timeLeft = 3600;          //The live time for the projectile (60 = 1 second, so 600 is 10 seconds)
				projectile.light = 0.5f;            //How much light emit around the projectile
				projectile.ignoreWater = true;          //Does the projectile's speed be influenced by water?
				projectile.tileCollide = false;          //Can the projectile collide with tiles?
			}

			public override Color? GetAlpha(Color lightColor) {
				return new Color(85, 107, 107);
			}
		}
		public class InkArrowProjGreen19 : InkArrowProjBase
		{
			public override string Texture
			{
				get
				{
					return "Pyresense/Items/Ammo/InkArrowProj";
				}
			}

			public override void SetStaticDefaults() {
				DisplayName.SetDefault("Ink Arrow");     //The English name of the projectile
			}

			public override void SetDefaults() {
				projectile.CloneDefaults(1);
				projectile.friendly = true;         //Can the projectile deal damage to enemies?
				projectile.hostile = false;         //Can the projectile deal damage to the player?
				projectile.ranged = true;           //Is the projectile shoot by a ranged weapon?
				projectile.penetrate = 3;           //How many monsters the projectile can penetrate. (OnTileCollide below also decrements penetrate for bounces as well)
				projectile.timeLeft = 3600;          //The live time for the projectile (60 = 1 second, so 600 is 10 seconds)
				projectile.light = 0.5f;            //How much light emit around the projectile
				projectile.ignoreWater = true;          //Does the projectile's speed be influenced by water?
				projectile.tileCollide = false;          //Can the projectile collide with tiles?
			}

			public override Color? GetAlpha(Color lightColor) {
				return new Color(102, 205, 170);
			}
		}
		public class InkArrowProjGreen20 : InkArrowProjBase
		{
			public override string Texture
			{
				get
				{
					return "Pyresense/Items/Ammo/InkArrowProj";
				}
			}

			public override void SetStaticDefaults() {
				DisplayName.SetDefault("Ink Arrow");     //The English name of the projectile
			}

			public override void SetDefaults() {
				projectile.CloneDefaults(1);
				projectile.friendly = true;         //Can the projectile deal damage to enemies?
				projectile.hostile = false;         //Can the projectile deal damage to the player?
				projectile.ranged = true;           //Is the projectile shoot by a ranged weapon?
				projectile.penetrate = 3;           //How many monsters the projectile can penetrate. (OnTileCollide below also decrements penetrate for bounces as well)
				projectile.timeLeft = 3600;          //The live time for the projectile (60 = 1 second, so 600 is 10 seconds)
				projectile.light = 0.5f;            //How much light emit around the projectile
				projectile.ignoreWater = true;          //Does the projectile's speed be influenced by water?
				projectile.tileCollide = false;          //Can the projectile collide with tiles?
			}

			public override Color? GetAlpha(Color lightColor) {
				return new Color(143, 188, 143);
			}
		}
		public class InkArrowProjGreen21 : InkArrowProjBase
		{
			public override string Texture
			{
				get
				{
					return "Pyresense/Items/Ammo/InkArrowProj";
				}
			}

			public override void SetStaticDefaults() {
				DisplayName.SetDefault("Ink Arrow");     //The English name of the projectile
			}

			public override void SetDefaults() {
				projectile.CloneDefaults(1);
				projectile.friendly = true;         //Can the projectile deal damage to enemies?
				projectile.hostile = false;         //Can the projectile deal damage to the player?
				projectile.ranged = true;           //Is the projectile shoot by a ranged weapon?
				projectile.penetrate = 3;           //How many monsters the projectile can penetrate. (OnTileCollide below also decrements penetrate for bounces as well)
				projectile.timeLeft = 3600;          //The live time for the projectile (60 = 1 second, so 600 is 10 seconds)
				projectile.light = 0.5f;            //How much light emit around the projectile
				projectile.ignoreWater = true;          //Does the projectile's speed be influenced by water?
				projectile.tileCollide = false;          //Can the projectile collide with tiles?
			}

			public override Color? GetAlpha(Color lightColor) {
				return new Color(32, 178, 170);
			}
		}
		public class InkArrowProjGreen22 : InkArrowProjBase
		{
			public override string Texture
			{
				get
				{
					return "Pyresense/Items/Ammo/InkArrowProj";
				}
			}

			public override void SetStaticDefaults() {
				DisplayName.SetDefault("Ink Arrow");     //The English name of the projectile
			}

			public override void SetDefaults() {
				projectile.CloneDefaults(1);
				projectile.friendly = true;         //Can the projectile deal damage to enemies?
				projectile.hostile = false;         //Can the projectile deal damage to the player?
				projectile.ranged = true;           //Is the projectile shoot by a ranged weapon?
				projectile.penetrate = 3;           //How many monsters the projectile can penetrate. (OnTileCollide below also decrements penetrate for bounces as well)
				projectile.timeLeft = 3600;          //The live time for the projectile (60 = 1 second, so 600 is 10 seconds)
				projectile.light = 0.5f;            //How much light emit around the projectile
				projectile.ignoreWater = true;          //Does the projectile's speed be influenced by water?
				projectile.tileCollide = false;          //Can the projectile collide with tiles?
			}

			public override Color? GetAlpha(Color lightColor) {
				return new Color(0, 139, 139);
			}
		}
		public class InkArrowProjGreen23 : InkArrowProjBase
		{
			public override string Texture
			{
				get
				{
					return "Pyresense/Items/Ammo/InkArrowProj";
				}
			}

			public override void SetStaticDefaults() {
				DisplayName.SetDefault("Ink Arrow");     //The English name of the projectile
			}

			public override void SetDefaults() {
				projectile.CloneDefaults(1);
				projectile.friendly = true;         //Can the projectile deal damage to enemies?
				projectile.hostile = false;         //Can the projectile deal damage to the player?
				projectile.ranged = true;           //Is the projectile shoot by a ranged weapon?
				projectile.penetrate = 3;           //How many monsters the projectile can penetrate. (OnTileCollide below also decrements penetrate for bounces as well)
				projectile.timeLeft = 3600;          //The live time for the projectile (60 = 1 second, so 600 is 10 seconds)
				projectile.light = 0.5f;            //How much light emit around the projectile
				projectile.ignoreWater = true;          //Does the projectile's speed be influenced by water?
				projectile.tileCollide = false;          //Can the projectile collide with tiles?
			}

			public override Color? GetAlpha(Color lightColor) {
				return new Color(0, 128, 128);
			}
		}
	//Blue
		public class InkArrowProjBlue1 : InkArrowProjBase
		{
			public override string Texture
			{
				get
				{
					return "Pyresense/Items/Ammo/InkArrowProj";
				}
			}

			public override void SetStaticDefaults() {
				DisplayName.SetDefault("Ink Arrow");     //The English name of the projectile
			}

			public override void SetDefaults() {
				projectile.CloneDefaults(1);
				projectile.friendly = true;         //Can the projectile deal damage to enemies?
				projectile.hostile = false;         //Can the projectile deal damage to the player?
				projectile.ranged = true;           //Is the projectile shoot by a ranged weapon?
				projectile.penetrate = 3;           //How many monsters the projectile can penetrate. (OnTileCollide below also decrements penetrate for bounces as well)
				projectile.timeLeft = 3600;          //The live time for the projectile (60 = 1 second, so 600 is 10 seconds)
				projectile.light = 0.5f;            //How much light emit around the projectile
				projectile.ignoreWater = true;          //Does the projectile's speed be influenced by water?
				projectile.tileCollide = false;          //Can the projectile collide with tiles?
			}

			public override Color? GetAlpha(Color lightColor) {
				return new Color(0, 255, 255);
			}
		}
		public class InkArrowProjBlue2 : InkArrowProjBase
		{
			public override string Texture
			{
				get
				{
					return "Pyresense/Items/Ammo/InkArrowProj";
				}
			}

			public override void SetStaticDefaults() {
				DisplayName.SetDefault("Ink Arrow");     //The English name of the projectile
			}

			public override void SetDefaults() {
				projectile.CloneDefaults(1);
				projectile.friendly = true;         //Can the projectile deal damage to enemies?
				projectile.hostile = false;         //Can the projectile deal damage to the player?
				projectile.ranged = true;           //Is the projectile shoot by a ranged weapon?
				projectile.penetrate = 3;           //How many monsters the projectile can penetrate. (OnTileCollide below also decrements penetrate for bounces as well)
				projectile.timeLeft = 3600;          //The live time for the projectile (60 = 1 second, so 600 is 10 seconds)
				projectile.light = 0.5f;            //How much light emit around the projectile
				projectile.ignoreWater = true;          //Does the projectile's speed be influenced by water?
				projectile.tileCollide = false;          //Can the projectile collide with tiles?
			}

			public override Color? GetAlpha(Color lightColor) {
				return new Color(0, 255, 255);
			}
		}
		public class InkArrowProjBlue3 : InkArrowProjBase
		{
			public override string Texture
			{
				get
				{
					return "Pyresense/Items/Ammo/InkArrowProj";
				}
			}

			public override void SetStaticDefaults() {
				DisplayName.SetDefault("Ink Arrow");     //The English name of the projectile
			}

			public override void SetDefaults() {
				projectile.CloneDefaults(1);
				projectile.friendly = true;         //Can the projectile deal damage to enemies?
				projectile.hostile = false;         //Can the projectile deal damage to the player?
				projectile.ranged = true;           //Is the projectile shoot by a ranged weapon?
				projectile.penetrate = 3;           //How many monsters the projectile can penetrate. (OnTileCollide below also decrements penetrate for bounces as well)
				projectile.timeLeft = 3600;          //The live time for the projectile (60 = 1 second, so 600 is 10 seconds)
				projectile.light = 0.5f;            //How much light emit around the projectile
				projectile.ignoreWater = true;          //Does the projectile's speed be influenced by water?
				projectile.tileCollide = false;          //Can the projectile collide with tiles?
			}

			public override Color? GetAlpha(Color lightColor) {
				return new Color(224, 255, 255);
			}
		}
		public class InkArrowProjBlue4 : InkArrowProjBase
		{
			public override string Texture
			{
				get
				{
					return "Pyresense/Items/Ammo/InkArrowProj";
				}
			}

			public override void SetStaticDefaults() {
				DisplayName.SetDefault("Ink Arrow");     //The English name of the projectile
			}

			public override void SetDefaults() {
				projectile.CloneDefaults(1);
				projectile.friendly = true;         //Can the projectile deal damage to enemies?
				projectile.hostile = false;         //Can the projectile deal damage to the player?
				projectile.ranged = true;           //Is the projectile shoot by a ranged weapon?
				projectile.penetrate = 3;           //How many monsters the projectile can penetrate. (OnTileCollide below also decrements penetrate for bounces as well)
				projectile.timeLeft = 3600;          //The live time for the projectile (60 = 1 second, so 600 is 10 seconds)
				projectile.light = 0.5f;            //How much light emit around the projectile
				projectile.ignoreWater = true;          //Does the projectile's speed be influenced by water?
				projectile.tileCollide = false;          //Can the projectile collide with tiles?
			}

			public override Color? GetAlpha(Color lightColor) {
				return new Color(175, 238, 238);
			}
		}
		public class InkArrowProjBlue5 : InkArrowProjBase
		{
			public override string Texture
			{
				get
				{
					return "Pyresense/Items/Ammo/InkArrowProj";
				}
			}

			public override void SetStaticDefaults() {
				DisplayName.SetDefault("Ink Arrow");     //The English name of the projectile
			}

			public override void SetDefaults() {
				projectile.CloneDefaults(1);
				projectile.friendly = true;         //Can the projectile deal damage to enemies?
				projectile.hostile = false;         //Can the projectile deal damage to the player?
				projectile.ranged = true;           //Is the projectile shoot by a ranged weapon?
				projectile.penetrate = 3;           //How many monsters the projectile can penetrate. (OnTileCollide below also decrements penetrate for bounces as well)
				projectile.timeLeft = 3600;          //The live time for the projectile (60 = 1 second, so 600 is 10 seconds)
				projectile.light = 0.5f;            //How much light emit around the projectile
				projectile.ignoreWater = true;          //Does the projectile's speed be influenced by water?
				projectile.tileCollide = false;          //Can the projectile collide with tiles?
			}

			public override Color? GetAlpha(Color lightColor) {
				return new Color(127, 255, 212);
			}
		}
		public class InkArrowProjBlue6 : InkArrowProjBase
		{
			public override string Texture
			{
				get
				{
					return "Pyresense/Items/Ammo/InkArrowProj";
				}
			}

			public override void SetStaticDefaults() {
				DisplayName.SetDefault("Ink Arrow");     //The English name of the projectile
			}

			public override void SetDefaults() {
				projectile.CloneDefaults(1);
				projectile.friendly = true;         //Can the projectile deal damage to enemies?
				projectile.hostile = false;         //Can the projectile deal damage to the player?
				projectile.ranged = true;           //Is the projectile shoot by a ranged weapon?
				projectile.penetrate = 3;           //How many monsters the projectile can penetrate. (OnTileCollide below also decrements penetrate for bounces as well)
				projectile.timeLeft = 3600;          //The live time for the projectile (60 = 1 second, so 600 is 10 seconds)
				projectile.light = 0.5f;            //How much light emit around the projectile
				projectile.ignoreWater = true;          //Does the projectile's speed be influenced by water?
				projectile.tileCollide = false;          //Can the projectile collide with tiles?
			}

			public override Color? GetAlpha(Color lightColor) {
				return new Color(64, 224, 208);
			}
		}
		public class InkArrowProjBlue7 : InkArrowProjBase
		{
			public override string Texture
			{
				get
				{
					return "Pyresense/Items/Ammo/InkArrowProj";
				}
			}

			public override void SetStaticDefaults() {
				DisplayName.SetDefault("Ink Arrow");     //The English name of the projectile
			}

			public override void SetDefaults() {
				projectile.CloneDefaults(1);
				projectile.friendly = true;         //Can the projectile deal damage to enemies?
				projectile.hostile = false;         //Can the projectile deal damage to the player?
				projectile.ranged = true;           //Is the projectile shoot by a ranged weapon?
				projectile.penetrate = 3;           //How many monsters the projectile can penetrate. (OnTileCollide below also decrements penetrate for bounces as well)
				projectile.timeLeft = 3600;          //The live time for the projectile (60 = 1 second, so 600 is 10 seconds)
				projectile.light = 0.5f;            //How much light emit around the projectile
				projectile.ignoreWater = true;          //Does the projectile's speed be influenced by water?
				projectile.tileCollide = false;          //Can the projectile collide with tiles?
			}

			public override Color? GetAlpha(Color lightColor) {
				return new Color(72, 209, 204);
			}
		}
		public class InkArrowProjBlue8 : InkArrowProjBase
		{
			public override string Texture
			{
				get
				{
					return "Pyresense/Items/Ammo/InkArrowProj";
				}
			}

			public override void SetStaticDefaults() {
				DisplayName.SetDefault("Ink Arrow");     //The English name of the projectile
			}

			public override void SetDefaults() {
				projectile.CloneDefaults(1);
				projectile.friendly = true;         //Can the projectile deal damage to enemies?
				projectile.hostile = false;         //Can the projectile deal damage to the player?
				projectile.ranged = true;           //Is the projectile shoot by a ranged weapon?
				projectile.penetrate = 3;           //How many monsters the projectile can penetrate. (OnTileCollide below also decrements penetrate for bounces as well)
				projectile.timeLeft = 3600;          //The live time for the projectile (60 = 1 second, so 600 is 10 seconds)
				projectile.light = 0.5f;            //How much light emit around the projectile
				projectile.ignoreWater = true;          //Does the projectile's speed be influenced by water?
				projectile.tileCollide = false;          //Can the projectile collide with tiles?
			}

			public override Color? GetAlpha(Color lightColor) {
				return new Color(0, 206, 209);
			}
		}
		public class InkArrowProjBlue9 : InkArrowProjBase
		{
			public override string Texture
			{
				get
				{
					return "Pyresense/Items/Ammo/InkArrowProj";
				}
			}

			public override void SetStaticDefaults() {
				DisplayName.SetDefault("Ink Arrow");     //The English name of the projectile
			}

			public override void SetDefaults() {
				projectile.CloneDefaults(1);
				projectile.friendly = true;         //Can the projectile deal damage to enemies?
				projectile.hostile = false;         //Can the projectile deal damage to the player?
				projectile.ranged = true;           //Is the projectile shoot by a ranged weapon?
				projectile.penetrate = 3;           //How many monsters the projectile can penetrate. (OnTileCollide below also decrements penetrate for bounces as well)
				projectile.timeLeft = 3600;          //The live time for the projectile (60 = 1 second, so 600 is 10 seconds)
				projectile.light = 0.5f;            //How much light emit around the projectile
				projectile.ignoreWater = true;          //Does the projectile's speed be influenced by water?
				projectile.tileCollide = false;          //Can the projectile collide with tiles?
			}

			public override Color? GetAlpha(Color lightColor) {
				return new Color(95, 158, 160);
			}
		}
		public class InkArrowProjBlue10 : InkArrowProjBase
		{
			public override string Texture
			{
				get
				{
					return "Pyresense/Items/Ammo/InkArrowProj";
				}
			}

			public override void SetStaticDefaults() {
				DisplayName.SetDefault("Ink Arrow");     //The English name of the projectile
			}

			public override void SetDefaults() {
				projectile.CloneDefaults(1);
				projectile.friendly = true;         //Can the projectile deal damage to enemies?
				projectile.hostile = false;         //Can the projectile deal damage to the player?
				projectile.ranged = true;           //Is the projectile shoot by a ranged weapon?
				projectile.penetrate = 3;           //How many monsters the projectile can penetrate. (OnTileCollide below also decrements penetrate for bounces as well)
				projectile.timeLeft = 3600;          //The live time for the projectile (60 = 1 second, so 600 is 10 seconds)
				projectile.light = 0.5f;            //How much light emit around the projectile
				projectile.ignoreWater = true;          //Does the projectile's speed be influenced by water?
				projectile.tileCollide = false;          //Can the projectile collide with tiles?
			}

			public override Color? GetAlpha(Color lightColor) {
				return new Color(70, 130, 180);
			}
		}
		public class InkArrowProjBlue11 : InkArrowProjBase
		{
			public override string Texture
			{
				get
				{
					return "Pyresense/Items/Ammo/InkArrowProj";
				}
			}

			public override void SetStaticDefaults() {
				DisplayName.SetDefault("Ink Arrow");     //The English name of the projectile
			}

			public override void SetDefaults() {
				projectile.CloneDefaults(1);
				projectile.friendly = true;         //Can the projectile deal damage to enemies?
				projectile.hostile = false;         //Can the projectile deal damage to the player?
				projectile.ranged = true;           //Is the projectile shoot by a ranged weapon?
				projectile.penetrate = 3;           //How many monsters the projectile can penetrate. (OnTileCollide below also decrements penetrate for bounces as well)
				projectile.timeLeft = 3600;          //The live time for the projectile (60 = 1 second, so 600 is 10 seconds)
				projectile.light = 0.5f;            //How much light emit around the projectile
				projectile.ignoreWater = true;          //Does the projectile's speed be influenced by water?
				projectile.tileCollide = false;          //Can the projectile collide with tiles?
			}

			public override Color? GetAlpha(Color lightColor) {
				return new Color(176, 196, 222);
			}
		}
		public class InkArrowProjBlue12 : InkArrowProjBase
		{
			public override string Texture
			{
				get
				{
					return "Pyresense/Items/Ammo/InkArrowProj";
				}
			}

			public override void SetStaticDefaults() {
				DisplayName.SetDefault("Ink Arrow");     //The English name of the projectile
			}

			public override void SetDefaults() {
				projectile.CloneDefaults(1);
				projectile.friendly = true;         //Can the projectile deal damage to enemies?
				projectile.hostile = false;         //Can the projectile deal damage to the player?
				projectile.ranged = true;           //Is the projectile shoot by a ranged weapon?
				projectile.penetrate = 3;           //How many monsters the projectile can penetrate. (OnTileCollide below also decrements penetrate for bounces as well)
				projectile.timeLeft = 3600;          //The live time for the projectile (60 = 1 second, so 600 is 10 seconds)
				projectile.light = 0.5f;            //How much light emit around the projectile
				projectile.ignoreWater = true;          //Does the projectile's speed be influenced by water?
				projectile.tileCollide = false;          //Can the projectile collide with tiles?
			}

			public override Color? GetAlpha(Color lightColor) {
				return new Color(176, 224, 230);
			}
		}
		public class InkArrowProjBlue13 : InkArrowProjBase
		{
			public override string Texture
			{
				get
				{
					return "Pyresense/Items/Ammo/InkArrowProj";
				}
			}

			public override void SetStaticDefaults() {
				DisplayName.SetDefault("Ink Arrow");     //The English name of the projectile
			}

			public override void SetDefaults() {
				projectile.CloneDefaults(1);
				projectile.friendly = true;         //Can the projectile deal damage to enemies?
				projectile.hostile = false;         //Can the projectile deal damage to the player?
				projectile.ranged = true;           //Is the projectile shoot by a ranged weapon?
				projectile.penetrate = 3;           //How many monsters the projectile can penetrate. (OnTileCollide below also decrements penetrate for bounces as well)
				projectile.timeLeft = 3600;          //The live time for the projectile (60 = 1 second, so 600 is 10 seconds)
				projectile.light = 0.5f;            //How much light emit around the projectile
				projectile.ignoreWater = true;          //Does the projectile's speed be influenced by water?
				projectile.tileCollide = false;          //Can the projectile collide with tiles?
			}

			public override Color? GetAlpha(Color lightColor) {
				return new Color(173, 216, 230);
			}
		}
		public class InkArrowProjBlue14 : InkArrowProjBase
		{
			public override string Texture
			{
				get
				{
					return "Pyresense/Items/Ammo/InkArrowProj";
				}
			}

			public override void SetStaticDefaults() {
				DisplayName.SetDefault("Ink Arrow");     //The English name of the projectile
			}

			public override void SetDefaults() {
				projectile.CloneDefaults(1);
				projectile.friendly = true;         //Can the projectile deal damage to enemies?
				projectile.hostile = false;         //Can the projectile deal damage to the player?
				projectile.ranged = true;           //Is the projectile shoot by a ranged weapon?
				projectile.penetrate = 3;           //How many monsters the projectile can penetrate. (OnTileCollide below also decrements penetrate for bounces as well)
				projectile.timeLeft = 3600;          //The live time for the projectile (60 = 1 second, so 600 is 10 seconds)
				projectile.light = 0.5f;            //How much light emit around the projectile
				projectile.ignoreWater = true;          //Does the projectile's speed be influenced by water?
				projectile.tileCollide = false;          //Can the projectile collide with tiles?
			}

			public override Color? GetAlpha(Color lightColor) {
				return new Color(135, 206, 235);
			}
		}
		public class InkArrowProjBlue15 : InkArrowProjBase
		{
			public override string Texture
			{
				get
				{
					return "Pyresense/Items/Ammo/InkArrowProj";
				}
			}

			public override void SetStaticDefaults() {
				DisplayName.SetDefault("Ink Arrow");     //The English name of the projectile
			}

			public override void SetDefaults() {
				projectile.CloneDefaults(1);
				projectile.friendly = true;         //Can the projectile deal damage to enemies?
				projectile.hostile = false;         //Can the projectile deal damage to the player?
				projectile.ranged = true;           //Is the projectile shoot by a ranged weapon?
				projectile.penetrate = 3;           //How many monsters the projectile can penetrate. (OnTileCollide below also decrements penetrate for bounces as well)
				projectile.timeLeft = 3600;          //The live time for the projectile (60 = 1 second, so 600 is 10 seconds)
				projectile.light = 0.5f;            //How much light emit around the projectile
				projectile.ignoreWater = true;          //Does the projectile's speed be influenced by water?
				projectile.tileCollide = false;          //Can the projectile collide with tiles?
			}

			public override Color? GetAlpha(Color lightColor) {
				return new Color(135, 206, 250);
			}
		}
		public class InkArrowProjBlue16 : InkArrowProjBase
		{
			public override string Texture
			{
				get
				{
					return "Pyresense/Items/Ammo/InkArrowProj";
				}
			}

			public override void SetStaticDefaults() {
				DisplayName.SetDefault("Ink Arrow");     //The English name of the projectile
			}

			public override void SetDefaults() {
				projectile.CloneDefaults(1);
				projectile.friendly = true;         //Can the projectile deal damage to enemies?
				projectile.hostile = false;         //Can the projectile deal damage to the player?
				projectile.ranged = true;           //Is the projectile shoot by a ranged weapon?
				projectile.penetrate = 3;           //How many monsters the projectile can penetrate. (OnTileCollide below also decrements penetrate for bounces as well)
				projectile.timeLeft = 3600;          //The live time for the projectile (60 = 1 second, so 600 is 10 seconds)
				projectile.light = 0.5f;            //How much light emit around the projectile
				projectile.ignoreWater = true;          //Does the projectile's speed be influenced by water?
				projectile.tileCollide = false;          //Can the projectile collide with tiles?
			}

			public override Color? GetAlpha(Color lightColor) {
				return new Color(0, 191, 255);
			}
		}
		public class InkArrowProjBlue17 : InkArrowProjBase
		{
			public override string Texture
			{
				get
				{
					return "Pyresense/Items/Ammo/InkArrowProj";
				}
			}

			public override void SetStaticDefaults() {
				DisplayName.SetDefault("Ink Arrow");     //The English name of the projectile
			}

			public override void SetDefaults() {
				projectile.CloneDefaults(1);
				projectile.friendly = true;         //Can the projectile deal damage to enemies?
				projectile.hostile = false;         //Can the projectile deal damage to the player?
				projectile.ranged = true;           //Is the projectile shoot by a ranged weapon?
				projectile.penetrate = 3;           //How many monsters the projectile can penetrate. (OnTileCollide below also decrements penetrate for bounces as well)
				projectile.timeLeft = 3600;          //The live time for the projectile (60 = 1 second, so 600 is 10 seconds)
				projectile.light = 0.5f;            //How much light emit around the projectile
				projectile.ignoreWater = true;          //Does the projectile's speed be influenced by water?
				projectile.tileCollide = false;          //Can the projectile collide with tiles?
			}

			public override Color? GetAlpha(Color lightColor) {
				return new Color(30, 144, 255);
			}
		}
		public class InkArrowProjBlue18 : InkArrowProjBase
		{
			public override string Texture
			{
				get
				{
					return "Pyresense/Items/Ammo/InkArrowProj";
				}
			}

			public override void SetStaticDefaults() {
				DisplayName.SetDefault("Ink Arrow");     //The English name of the projectile
			}

			public override void SetDefaults() {
				projectile.CloneDefaults(1);
				projectile.friendly = true;         //Can the projectile deal damage to enemies?
				projectile.hostile = false;         //Can the projectile deal damage to the player?
				projectile.ranged = true;           //Is the projectile shoot by a ranged weapon?
				projectile.penetrate = 3;           //How many monsters the projectile can penetrate. (OnTileCollide below also decrements penetrate for bounces as well)
				projectile.timeLeft = 3600;          //The live time for the projectile (60 = 1 second, so 600 is 10 seconds)
				projectile.light = 0.5f;            //How much light emit around the projectile
				projectile.ignoreWater = true;          //Does the projectile's speed be influenced by water?
				projectile.tileCollide = false;          //Can the projectile collide with tiles?
			}

			public override Color? GetAlpha(Color lightColor) {
				return new Color(100, 149, 237);
			}
		}
		public class InkArrowProjBlue19 : InkArrowProjBase
		{
			public override string Texture
			{
				get
				{
					return "Pyresense/Items/Ammo/InkArrowProj";
				}
			}

			public override void SetStaticDefaults() {
				DisplayName.SetDefault("Ink Arrow");     //The English name of the projectile
			}

			public override void SetDefaults() {
				projectile.CloneDefaults(1);
				projectile.friendly = true;         //Can the projectile deal damage to enemies?
				projectile.hostile = false;         //Can the projectile deal damage to the player?
				projectile.ranged = true;           //Is the projectile shoot by a ranged weapon?
				projectile.penetrate = 3;           //How many monsters the projectile can penetrate. (OnTileCollide below also decrements penetrate for bounces as well)
				projectile.timeLeft = 3600;          //The live time for the projectile (60 = 1 second, so 600 is 10 seconds)
				projectile.light = 0.5f;            //How much light emit around the projectile
				projectile.ignoreWater = true;          //Does the projectile's speed be influenced by water?
				projectile.tileCollide = false;          //Can the projectile collide with tiles?
			}

			public override Color? GetAlpha(Color lightColor) {
				return new Color(123, 104, 238);
			}
		}
		public class InkArrowProjBlue20 : InkArrowProjBase
		{
			public override string Texture
			{
				get
				{
					return "Pyresense/Items/Ammo/InkArrowProj";
				}
			}

			public override void SetStaticDefaults() {
				DisplayName.SetDefault("Ink Arrow");     //The English name of the projectile
			}

			public override void SetDefaults() {
				projectile.CloneDefaults(1);
				projectile.friendly = true;         //Can the projectile deal damage to enemies?
				projectile.hostile = false;         //Can the projectile deal damage to the player?
				projectile.ranged = true;           //Is the projectile shoot by a ranged weapon?
				projectile.penetrate = 3;           //How many monsters the projectile can penetrate. (OnTileCollide below also decrements penetrate for bounces as well)
				projectile.timeLeft = 3600;          //The live time for the projectile (60 = 1 second, so 600 is 10 seconds)
				projectile.light = 0.5f;            //How much light emit around the projectile
				projectile.ignoreWater = true;          //Does the projectile's speed be influenced by water?
				projectile.tileCollide = false;          //Can the projectile collide with tiles?
			}

			public override Color? GetAlpha(Color lightColor) {
				return new Color(65, 105, 255);
			}
		}
		public class InkArrowProjBlue21 : InkArrowProjBase
		{
			public override string Texture
			{
				get
				{
					return "Pyresense/Items/Ammo/InkArrowProj";
				}
			}

			public override void SetStaticDefaults() {
				DisplayName.SetDefault("Ink Arrow");     //The English name of the projectile
			}

			public override void SetDefaults() {
				projectile.CloneDefaults(1);
				projectile.friendly = true;         //Can the projectile deal damage to enemies?
				projectile.hostile = false;         //Can the projectile deal damage to the player?
				projectile.ranged = true;           //Is the projectile shoot by a ranged weapon?
				projectile.penetrate = 3;           //How many monsters the projectile can penetrate. (OnTileCollide below also decrements penetrate for bounces as well)
				projectile.timeLeft = 3600;          //The live time for the projectile (60 = 1 second, so 600 is 10 seconds)
				projectile.light = 0.5f;            //How much light emit around the projectile
				projectile.ignoreWater = true;          //Does the projectile's speed be influenced by water?
				projectile.tileCollide = false;          //Can the projectile collide with tiles?
			}

			public override Color? GetAlpha(Color lightColor) {
				return new Color(0, 0, 255);
			}
		}
		public class InkArrowProjBlue22 : InkArrowProjBase
		{
			public override string Texture
			{
				get
				{
					return "Pyresense/Items/Ammo/InkArrowProj";
				}
			}

			public override void SetStaticDefaults() {
				DisplayName.SetDefault("Ink Arrow");     //The English name of the projectile
			}

			public override void SetDefaults() {
				projectile.CloneDefaults(1);
				projectile.friendly = true;         //Can the projectile deal damage to enemies?
				projectile.hostile = false;         //Can the projectile deal damage to the player?
				projectile.ranged = true;           //Is the projectile shoot by a ranged weapon?
				projectile.penetrate = 3;           //How many monsters the projectile can penetrate. (OnTileCollide below also decrements penetrate for bounces as well)
				projectile.timeLeft = 3600;          //The live time for the projectile (60 = 1 second, so 600 is 10 seconds)
				projectile.light = 0.5f;            //How much light emit around the projectile
				projectile.ignoreWater = true;          //Does the projectile's speed be influenced by water?
				projectile.tileCollide = false;          //Can the projectile collide with tiles?
			}

			public override Color? GetAlpha(Color lightColor) {
				return new Color(0, 0, 205);
			}
		}
		public class InkArrowProjBlue23 : InkArrowProjBase
		{
			public override string Texture
			{
				get
				{
					return "Pyresense/Items/Ammo/InkArrowProj";
				}
			}

			public override void SetStaticDefaults() {
				DisplayName.SetDefault("Ink Arrow");     //The English name of the projectile
			}

			public override void SetDefaults() {
				projectile.CloneDefaults(1);
				projectile.friendly = true;         //Can the projectile deal damage to enemies?
				projectile.hostile = false;         //Can the projectile deal damage to the player?
				projectile.ranged = true;           //Is the projectile shoot by a ranged weapon?
				projectile.penetrate = 3;           //How many monsters the projectile can penetrate. (OnTileCollide below also decrements penetrate for bounces as well)
				projectile.timeLeft = 3600;          //The live time for the projectile (60 = 1 second, so 600 is 10 seconds)
				projectile.light = 0.5f;            //How much light emit around the projectile
				projectile.ignoreWater = true;          //Does the projectile's speed be influenced by water?
				projectile.tileCollide = false;          //Can the projectile collide with tiles?
			}

			public override Color? GetAlpha(Color lightColor) {
				return new Color(0, 0, 139);
			}
		}
		public class InkArrowProjBlue24 : InkArrowProjBase
		{
			public override string Texture
			{
				get
				{
					return "Pyresense/Items/Ammo/InkArrowProj";
				}
			}

			public override void SetStaticDefaults() {
				DisplayName.SetDefault("Ink Arrow");     //The English name of the projectile
			}

			public override void SetDefaults() {
				projectile.CloneDefaults(1);
				projectile.friendly = true;         //Can the projectile deal damage to enemies?
				projectile.hostile = false;         //Can the projectile deal damage to the player?
				projectile.ranged = true;           //Is the projectile shoot by a ranged weapon?
				projectile.penetrate = 3;           //How many monsters the projectile can penetrate. (OnTileCollide below also decrements penetrate for bounces as well)
				projectile.timeLeft = 3600;          //The live time for the projectile (60 = 1 second, so 600 is 10 seconds)
				projectile.light = 0.5f;            //How much light emit around the projectile
				projectile.ignoreWater = true;          //Does the projectile's speed be influenced by water?
				projectile.tileCollide = false;          //Can the projectile collide with tiles?
			}

			public override Color? GetAlpha(Color lightColor) {
				return new Color(0, 0, 128);
			}
		}
		public class InkArrowProjBlue25 : InkArrowProjBase
		{
			public override string Texture
			{
				get
				{
					return "Pyresense/Items/Ammo/InkArrowProj";
				}
			}

			public override void SetStaticDefaults() {
				DisplayName.SetDefault("Ink Arrow");     //The English name of the projectile
			}

			public override void SetDefaults() {
				projectile.CloneDefaults(1);
				projectile.friendly = true;         //Can the projectile deal damage to enemies?
				projectile.hostile = false;         //Can the projectile deal damage to the player?
				projectile.ranged = true;           //Is the projectile shoot by a ranged weapon?
				projectile.penetrate = 3;           //How many monsters the projectile can penetrate. (OnTileCollide below also decrements penetrate for bounces as well)
				projectile.timeLeft = 3600;          //The live time for the projectile (60 = 1 second, so 600 is 10 seconds)
				projectile.light = 0.5f;            //How much light emit around the projectile
				projectile.ignoreWater = true;          //Does the projectile's speed be influenced by water?
				projectile.tileCollide = false;          //Can the projectile collide with tiles?
			}

			public override Color? GetAlpha(Color lightColor) {
				return new Color(25, 25, 112);
			}
		}
	//White
		public class InkArrowProjWhite1 : InkArrowProjBase
		{
			public override string Texture
			{
				get
				{
					return "Pyresense/Items/Ammo/InkArrowProj";
				}
			}

			public override void SetStaticDefaults() {
				DisplayName.SetDefault("Ink Arrow");     //The English name of the projectile
			}

			public override void SetDefaults() {
				projectile.CloneDefaults(1);
				projectile.friendly = true;         //Can the projectile deal damage to enemies?
				projectile.hostile = false;         //Can the projectile deal damage to the player?
				projectile.ranged = true;           //Is the projectile shoot by a ranged weapon?
				projectile.penetrate = 3;           //How many monsters the projectile can penetrate. (OnTileCollide below also decrements penetrate for bounces as well)
				projectile.timeLeft = 3600;          //The live time for the projectile (60 = 1 second, so 600 is 10 seconds)
				projectile.light = 0.5f;            //How much light emit around the projectile
				projectile.ignoreWater = true;          //Does the projectile's speed be influenced by water?
				projectile.tileCollide = false;          //Can the projectile collide with tiles?
			}

			public override Color? GetAlpha(Color lightColor) {
				return new Color(255, 255, 255);
			}
		}
		public class InkArrowProjWhite2 : InkArrowProjBase
		{
			public override string Texture
			{
				get
				{
					return "Pyresense/Items/Ammo/InkArrowProj";
				}
			}

			public override void SetStaticDefaults() {
				DisplayName.SetDefault("Ink Arrow");     //The English name of the projectile
			}

			public override void SetDefaults() {
				projectile.CloneDefaults(1);
				projectile.friendly = true;         //Can the projectile deal damage to enemies?
				projectile.hostile = false;         //Can the projectile deal damage to the player?
				projectile.ranged = true;           //Is the projectile shoot by a ranged weapon?
				projectile.penetrate = 3;           //How many monsters the projectile can penetrate. (OnTileCollide below also decrements penetrate for bounces as well)
				projectile.timeLeft = 3600;          //The live time for the projectile (60 = 1 second, so 600 is 10 seconds)
				projectile.light = 0.5f;            //How much light emit around the projectile
				projectile.ignoreWater = true;          //Does the projectile's speed be influenced by water?
				projectile.tileCollide = false;          //Can the projectile collide with tiles?
			}

			public override Color? GetAlpha(Color lightColor) {
				return new Color(255, 250, 250);
			}
		}
		public class InkArrowProjWhite3 : InkArrowProjBase
		{
			public override string Texture
			{
				get
				{
					return "Pyresense/Items/Ammo/InkArrowProj";
				}
			}

			public override void SetStaticDefaults() {
				DisplayName.SetDefault("Ink Arrow");     //The English name of the projectile
			}

			public override void SetDefaults() {
				projectile.CloneDefaults(1);
				projectile.friendly = true;         //Can the projectile deal damage to enemies?
				projectile.hostile = false;         //Can the projectile deal damage to the player?
				projectile.ranged = true;           //Is the projectile shoot by a ranged weapon?
				projectile.penetrate = 3;           //How many monsters the projectile can penetrate. (OnTileCollide below also decrements penetrate for bounces as well)
				projectile.timeLeft = 3600;          //The live time for the projectile (60 = 1 second, so 600 is 10 seconds)
				projectile.light = 0.5f;            //How much light emit around the projectile
				projectile.ignoreWater = true;          //Does the projectile's speed be influenced by water?
				projectile.tileCollide = false;          //Can the projectile collide with tiles?
			}

			public override Color? GetAlpha(Color lightColor) {
				return new Color(240, 255, 240);
			}
		}
		public class InkArrowProjWhite4 : InkArrowProjBase
		{
			public override string Texture
			{
				get
				{
					return "Pyresense/Items/Ammo/InkArrowProj";
				}
			}

			public override void SetStaticDefaults() {
				DisplayName.SetDefault("Ink Arrow");     //The English name of the projectile
			}

			public override void SetDefaults() {
				projectile.CloneDefaults(1);
				projectile.friendly = true;         //Can the projectile deal damage to enemies?
				projectile.hostile = false;         //Can the projectile deal damage to the player?
				projectile.ranged = true;           //Is the projectile shoot by a ranged weapon?
				projectile.penetrate = 3;           //How many monsters the projectile can penetrate. (OnTileCollide below also decrements penetrate for bounces as well)
				projectile.timeLeft = 3600;          //The live time for the projectile (60 = 1 second, so 600 is 10 seconds)
				projectile.light = 0.5f;            //How much light emit around the projectile
				projectile.ignoreWater = true;          //Does the projectile's speed be influenced by water?
				projectile.tileCollide = false;          //Can the projectile collide with tiles?
			}

			public override Color? GetAlpha(Color lightColor) {
				return new Color(245, 255, 250);
			}
		}
		public class InkArrowProjWhite5 : InkArrowProjBase
		{
			public override string Texture
			{
				get
				{
					return "Pyresense/Items/Ammo/InkArrowProj";
				}
			}

			public override void SetStaticDefaults() {
				DisplayName.SetDefault("Ink Arrow");     //The English name of the projectile
			}

			public override void SetDefaults() {
				projectile.CloneDefaults(1);
				projectile.friendly = true;         //Can the projectile deal damage to enemies?
				projectile.hostile = false;         //Can the projectile deal damage to the player?
				projectile.ranged = true;           //Is the projectile shoot by a ranged weapon?
				projectile.penetrate = 3;           //How many monsters the projectile can penetrate. (OnTileCollide below also decrements penetrate for bounces as well)
				projectile.timeLeft = 3600;          //The live time for the projectile (60 = 1 second, so 600 is 10 seconds)
				projectile.light = 0.5f;            //How much light emit around the projectile
				projectile.ignoreWater = true;          //Does the projectile's speed be influenced by water?
				projectile.tileCollide = false;          //Can the projectile collide with tiles?
			}

			public override Color? GetAlpha(Color lightColor) {
				return new Color(240, 255, 255);
			}
		}
		public class InkArrowProjWhite6 : InkArrowProjBase
		{
			public override string Texture
			{
				get
				{
					return "Pyresense/Items/Ammo/InkArrowProj";
				}
			}

			public override void SetStaticDefaults() {
				DisplayName.SetDefault("Ink Arrow");     //The English name of the projectile
			}

			public override void SetDefaults() {
				projectile.CloneDefaults(1);
				projectile.friendly = true;         //Can the projectile deal damage to enemies?
				projectile.hostile = false;         //Can the projectile deal damage to the player?
				projectile.ranged = true;           //Is the projectile shoot by a ranged weapon?
				projectile.penetrate = 3;           //How many monsters the projectile can penetrate. (OnTileCollide below also decrements penetrate for bounces as well)
				projectile.timeLeft = 3600;          //The live time for the projectile (60 = 1 second, so 600 is 10 seconds)
				projectile.light = 0.5f;            //How much light emit around the projectile
				projectile.ignoreWater = true;          //Does the projectile's speed be influenced by water?
				projectile.tileCollide = false;          //Can the projectile collide with tiles?
			}

			public override Color? GetAlpha(Color lightColor) {
				return new Color(240, 248, 255);
			}
		}
		public class InkArrowProjWhite7 : InkArrowProjBase
		{
			public override string Texture
			{
				get
				{
					return "Pyresense/Items/Ammo/InkArrowProj";
				}
			}

			public override void SetStaticDefaults() {
				DisplayName.SetDefault("Ink Arrow");     //The English name of the projectile
			}

			public override void SetDefaults() {
				projectile.CloneDefaults(1);
				projectile.friendly = true;         //Can the projectile deal damage to enemies?
				projectile.hostile = false;         //Can the projectile deal damage to the player?
				projectile.ranged = true;           //Is the projectile shoot by a ranged weapon?
				projectile.penetrate = 3;           //How many monsters the projectile can penetrate. (OnTileCollide below also decrements penetrate for bounces as well)
				projectile.timeLeft = 3600;          //The live time for the projectile (60 = 1 second, so 600 is 10 seconds)
				projectile.light = 0.5f;            //How much light emit around the projectile
				projectile.ignoreWater = true;          //Does the projectile's speed be influenced by water?
				projectile.tileCollide = false;          //Can the projectile collide with tiles?
			}

			public override Color? GetAlpha(Color lightColor) {
				return new Color(248, 248, 255);
			}
		}
		public class InkArrowProjWhite8 : InkArrowProjBase
		{
			public override string Texture
			{
				get
				{
					return "Pyresense/Items/Ammo/InkArrowProj";
				}
			}

			public override void SetStaticDefaults() {
				DisplayName.SetDefault("Ink Arrow");     //The English name of the projectile
			}

			public override void SetDefaults() {
				projectile.CloneDefaults(1);
				projectile.friendly = true;         //Can the projectile deal damage to enemies?
				projectile.hostile = false;         //Can the projectile deal damage to the player?
				projectile.ranged = true;           //Is the projectile shoot by a ranged weapon?
				projectile.penetrate = 3;           //How many monsters the projectile can penetrate. (OnTileCollide below also decrements penetrate for bounces as well)
				projectile.timeLeft = 3600;          //The live time for the projectile (60 = 1 second, so 600 is 10 seconds)
				projectile.light = 0.5f;            //How much light emit around the projectile
				projectile.ignoreWater = true;          //Does the projectile's speed be influenced by water?
				projectile.tileCollide = false;          //Can the projectile collide with tiles?
			}

			public override Color? GetAlpha(Color lightColor) {
				return new Color(245, 245, 245);
			}
		}
		public class InkArrowProjWhite9 : InkArrowProjBase
		{
			public override string Texture
			{
				get
				{
					return "Pyresense/Items/Ammo/InkArrowProj";
				}
			}

			public override void SetStaticDefaults() {
				DisplayName.SetDefault("Ink Arrow");     //The English name of the projectile
			}

			public override void SetDefaults() {
				projectile.CloneDefaults(1);
				projectile.friendly = true;         //Can the projectile deal damage to enemies?
				projectile.hostile = false;         //Can the projectile deal damage to the player?
				projectile.ranged = true;           //Is the projectile shoot by a ranged weapon?
				projectile.penetrate = 3;           //How many monsters the projectile can penetrate. (OnTileCollide below also decrements penetrate for bounces as well)
				projectile.timeLeft = 3600;          //The live time for the projectile (60 = 1 second, so 600 is 10 seconds)
				projectile.light = 0.5f;            //How much light emit around the projectile
				projectile.ignoreWater = true;          //Does the projectile's speed be influenced by water?
				projectile.tileCollide = false;          //Can the projectile collide with tiles?
			}

			public override Color? GetAlpha(Color lightColor) {
				return new Color(255, 245, 238);
			}
		}
		public class InkArrowProjWhite10 : InkArrowProjBase
		{
			public override string Texture
			{
				get
				{
					return "Pyresense/Items/Ammo/InkArrowProj";
				}
			}

			public override void SetStaticDefaults() {
				DisplayName.SetDefault("Ink Arrow");     //The English name of the projectile
			}

			public override void SetDefaults() {
				projectile.CloneDefaults(1);
				projectile.friendly = true;         //Can the projectile deal damage to enemies?
				projectile.hostile = false;         //Can the projectile deal damage to the player?
				projectile.ranged = true;           //Is the projectile shoot by a ranged weapon?
				projectile.penetrate = 3;           //How many monsters the projectile can penetrate. (OnTileCollide below also decrements penetrate for bounces as well)
				projectile.timeLeft = 3600;          //The live time for the projectile (60 = 1 second, so 600 is 10 seconds)
				projectile.light = 0.5f;            //How much light emit around the projectile
				projectile.ignoreWater = true;          //Does the projectile's speed be influenced by water?
				projectile.tileCollide = false;          //Can the projectile collide with tiles?
			}

			public override Color? GetAlpha(Color lightColor) {
				return new Color(245, 245, 220);
			}
		}
		public class InkArrowProjWhite11 : InkArrowProjBase
		{
			public override string Texture
			{
				get
				{
					return "Pyresense/Items/Ammo/InkArrowProj";
				}
			}

			public override void SetStaticDefaults() {
				DisplayName.SetDefault("Ink Arrow");     //The English name of the projectile
			}

			public override void SetDefaults() {
				projectile.CloneDefaults(1);
				projectile.friendly = true;         //Can the projectile deal damage to enemies?
				projectile.hostile = false;         //Can the projectile deal damage to the player?
				projectile.ranged = true;           //Is the projectile shoot by a ranged weapon?
				projectile.penetrate = 3;           //How many monsters the projectile can penetrate. (OnTileCollide below also decrements penetrate for bounces as well)
				projectile.timeLeft = 3600;          //The live time for the projectile (60 = 1 second, so 600 is 10 seconds)
				projectile.light = 0.5f;            //How much light emit around the projectile
				projectile.ignoreWater = true;          //Does the projectile's speed be influenced by water?
				projectile.tileCollide = false;          //Can the projectile collide with tiles?
			}

			public override Color? GetAlpha(Color lightColor) {
				return new Color(253, 245, 230);
			}
		}
		public class InkArrowProjWhite12 : InkArrowProjBase
		{
			public override string Texture
			{
				get
				{
					return "Pyresense/Items/Ammo/InkArrowProj";
				}
			}

			public override void SetStaticDefaults() {
				DisplayName.SetDefault("Ink Arrow");     //The English name of the projectile
			}

			public override void SetDefaults() {
				projectile.CloneDefaults(1);
				projectile.friendly = true;         //Can the projectile deal damage to enemies?
				projectile.hostile = false;         //Can the projectile deal damage to the player?
				projectile.ranged = true;           //Is the projectile shoot by a ranged weapon?
				projectile.penetrate = 3;           //How many monsters the projectile can penetrate. (OnTileCollide below also decrements penetrate for bounces as well)
				projectile.timeLeft = 3600;          //The live time for the projectile (60 = 1 second, so 600 is 10 seconds)
				projectile.light = 0.5f;            //How much light emit around the projectile
				projectile.ignoreWater = true;          //Does the projectile's speed be influenced by water?
				projectile.tileCollide = false;          //Can the projectile collide with tiles?
			}

			public override Color? GetAlpha(Color lightColor) {
				return new Color(255, 250, 240);
			}
		}
		public class InkArrowProjWhite13 : InkArrowProjBase
		{
			public override string Texture
			{
				get
				{
					return "Pyresense/Items/Ammo/InkArrowProj";
				}
			}

			public override void SetStaticDefaults() {
				DisplayName.SetDefault("Ink Arrow");     //The English name of the projectile
			}

			public override void SetDefaults() {
				projectile.CloneDefaults(1);
				projectile.friendly = true;         //Can the projectile deal damage to enemies?
				projectile.hostile = false;         //Can the projectile deal damage to the player?
				projectile.ranged = true;           //Is the projectile shoot by a ranged weapon?
				projectile.penetrate = 3;           //How many monsters the projectile can penetrate. (OnTileCollide below also decrements penetrate for bounces as well)
				projectile.timeLeft = 3600;          //The live time for the projectile (60 = 1 second, so 600 is 10 seconds)
				projectile.light = 0.5f;            //How much light emit around the projectile
				projectile.ignoreWater = true;          //Does the projectile's speed be influenced by water?
				projectile.tileCollide = false;          //Can the projectile collide with tiles?
			}

			public override Color? GetAlpha(Color lightColor) {
				return new Color(255, 255, 240);
			}
		}
		public class InkArrowProjWhite14 : InkArrowProjBase
		{
			public override string Texture
			{
				get
				{
					return "Pyresense/Items/Ammo/InkArrowProj";
				}
			}

			public override void SetStaticDefaults() {
				DisplayName.SetDefault("Ink Arrow");     //The English name of the projectile
			}

			public override void SetDefaults() {
				projectile.CloneDefaults(1);
				projectile.friendly = true;         //Can the projectile deal damage to enemies?
				projectile.hostile = false;         //Can the projectile deal damage to the player?
				projectile.ranged = true;           //Is the projectile shoot by a ranged weapon?
				projectile.penetrate = 3;           //How many monsters the projectile can penetrate. (OnTileCollide below also decrements penetrate for bounces as well)
				projectile.timeLeft = 3600;          //The live time for the projectile (60 = 1 second, so 600 is 10 seconds)
				projectile.light = 0.5f;            //How much light emit around the projectile
				projectile.ignoreWater = true;          //Does the projectile's speed be influenced by water?
				projectile.tileCollide = false;          //Can the projectile collide with tiles?
			}

			public override Color? GetAlpha(Color lightColor) {
				return new Color(250, 235, 215);
			}
		}
		public class InkArrowProjWhite15 : InkArrowProjBase
		{
			public override string Texture
			{
				get
				{
					return "Pyresense/Items/Ammo/InkArrowProj";
				}
			}

			public override void SetStaticDefaults() {
				DisplayName.SetDefault("Ink Arrow");     //The English name of the projectile
			}

			public override void SetDefaults() {
				projectile.CloneDefaults(1);
				projectile.friendly = true;         //Can the projectile deal damage to enemies?
				projectile.hostile = false;         //Can the projectile deal damage to the player?
				projectile.ranged = true;           //Is the projectile shoot by a ranged weapon?
				projectile.penetrate = 3;           //How many monsters the projectile can penetrate. (OnTileCollide below also decrements penetrate for bounces as well)
				projectile.timeLeft = 3600;          //The live time for the projectile (60 = 1 second, so 600 is 10 seconds)
				projectile.light = 0.5f;            //How much light emit around the projectile
				projectile.ignoreWater = true;          //Does the projectile's speed be influenced by water?
				projectile.tileCollide = false;          //Can the projectile collide with tiles?
			}

			public override Color? GetAlpha(Color lightColor) {
				return new Color(250, 240, 230);
			}
		}
		public class InkArrowProjWhite16 : InkArrowProjBase
		{
			public override string Texture
			{
				get
				{
					return "Pyresense/Items/Ammo/InkArrowProj";
				}
			}

			public override void SetStaticDefaults() {
				DisplayName.SetDefault("Ink Arrow");     //The English name of the projectile
			}

			public override void SetDefaults() {
				projectile.CloneDefaults(1);
				projectile.friendly = true;         //Can the projectile deal damage to enemies?
				projectile.hostile = false;         //Can the projectile deal damage to the player?
				projectile.ranged = true;           //Is the projectile shoot by a ranged weapon?
				projectile.penetrate = 3;           //How many monsters the projectile can penetrate. (OnTileCollide below also decrements penetrate for bounces as well)
				projectile.timeLeft = 3600;          //The live time for the projectile (60 = 1 second, so 600 is 10 seconds)
				projectile.light = 0.5f;            //How much light emit around the projectile
				projectile.ignoreWater = true;          //Does the projectile's speed be influenced by water?
				projectile.tileCollide = false;          //Can the projectile collide with tiles?
			}

			public override Color? GetAlpha(Color lightColor) {
				return new Color(250, 240, 230);
			}
		}
		public class InkArrowProjWhite17 : InkArrowProjBase
		{
			public override string Texture
			{
				get
				{
					return "Pyresense/Items/Ammo/InkArrowProj";
				}
			}

			public override void SetStaticDefaults() {
				DisplayName.SetDefault("Ink Arrow");     //The English name of the projectile
			}

			public override void SetDefaults() {
				projectile.CloneDefaults(1);
				projectile.friendly = true;         //Can the projectile deal damage to enemies?
				projectile.hostile = false;         //Can the projectile deal damage to the player?
				projectile.ranged = true;           //Is the projectile shoot by a ranged weapon?
				projectile.penetrate = 3;           //How many monsters the projectile can penetrate. (OnTileCollide below also decrements penetrate for bounces as well)
				projectile.timeLeft = 3600;          //The live time for the projectile (60 = 1 second, so 600 is 10 seconds)
				projectile.light = 0.5f;            //How much light emit around the projectile
				projectile.ignoreWater = true;          //Does the projectile's speed be influenced by water?
				projectile.tileCollide = false;          //Can the projectile collide with tiles?
			}

			public override Color? GetAlpha(Color lightColor) {
				return new Color(255, 240, 245);
			}
		}
		public class InkArrowProjWhite18 : InkArrowProjBase
		{
			public override string Texture
			{
				get
				{
					return "Pyresense/Items/Ammo/InkArrowProj";
				}
			}

			public override void SetStaticDefaults() {
				DisplayName.SetDefault("Ink Arrow");     //The English name of the projectile
			}

			public override void SetDefaults() {
				projectile.CloneDefaults(1);
				projectile.friendly = true;         //Can the projectile deal damage to enemies?
				projectile.hostile = false;         //Can the projectile deal damage to the player?
				projectile.ranged = true;           //Is the projectile shoot by a ranged weapon?
				projectile.penetrate = 3;           //How many monsters the projectile can penetrate. (OnTileCollide below also decrements penetrate for bounces as well)
				projectile.timeLeft = 3600;          //The live time for the projectile (60 = 1 second, so 600 is 10 seconds)
				projectile.light = 0.5f;            //How much light emit around the projectile
				projectile.ignoreWater = true;          //Does the projectile's speed be influenced by water?
				projectile.tileCollide = false;          //Can the projectile collide with tiles?
			}

			public override Color? GetAlpha(Color lightColor) {
				return new Color(255, 228, 225);
			}
		}
	//Gray
		public class InkArrowProjGray1 : InkArrowProjBase
		{
			public override string Texture
			{
				get
				{
					return "Pyresense/Items/Ammo/InkArrowProj";
				}
			}

			public override void SetStaticDefaults() {
				DisplayName.SetDefault("Ink Arrow");     //The English name of the projectile
			}

			public override void SetDefaults() {
				projectile.CloneDefaults(1);
				projectile.friendly = true;         //Can the projectile deal damage to enemies?
				projectile.hostile = false;         //Can the projectile deal damage to the player?
				projectile.ranged = true;           //Is the projectile shoot by a ranged weapon?
				projectile.penetrate = 3;           //How many monsters the projectile can penetrate. (OnTileCollide below also decrements penetrate for bounces as well)
				projectile.timeLeft = 3600;          //The live time for the projectile (60 = 1 second, so 600 is 10 seconds)
				projectile.light = 0.5f;            //How much light emit around the projectile
				projectile.ignoreWater = true;          //Does the projectile's speed be influenced by water?
				projectile.tileCollide = false;          //Can the projectile collide with tiles?
			}

			public override Color? GetAlpha(Color lightColor) {
				return new Color(220, 220, 220);
			}
		}
		public class InkArrowProjGray2 : InkArrowProjBase
		{
			public override string Texture
			{
				get
				{
					return "Pyresense/Items/Ammo/InkArrowProj";
				}
			}

			public override void SetStaticDefaults() {
				DisplayName.SetDefault("Ink Arrow");     //The English name of the projectile
			}

			public override void SetDefaults() {
				projectile.CloneDefaults(1);
				projectile.friendly = true;         //Can the projectile deal damage to enemies?
				projectile.hostile = false;         //Can the projectile deal damage to the player?
				projectile.ranged = true;           //Is the projectile shoot by a ranged weapon?
				projectile.penetrate = 3;           //How many monsters the projectile can penetrate. (OnTileCollide below also decrements penetrate for bounces as well)
				projectile.timeLeft = 3600;          //The live time for the projectile (60 = 1 second, so 600 is 10 seconds)
				projectile.light = 0.5f;            //How much light emit around the projectile
				projectile.ignoreWater = true;          //Does the projectile's speed be influenced by water?
				projectile.tileCollide = false;          //Can the projectile collide with tiles?
			}

			public override Color? GetAlpha(Color lightColor) {
				return new Color(211, 211, 211);
			}
		}
		public class InkArrowProjGray3 : InkArrowProjBase
		{
			public override string Texture
			{
				get
				{
					return "Pyresense/Items/Ammo/InkArrowProj";
				}
			}

			public override void SetStaticDefaults() {
				DisplayName.SetDefault("Ink Arrow");     //The English name of the projectile
			}

			public override void SetDefaults() {
				projectile.CloneDefaults(1);
				projectile.friendly = true;         //Can the projectile deal damage to enemies?
				projectile.hostile = false;         //Can the projectile deal damage to the player?
				projectile.ranged = true;           //Is the projectile shoot by a ranged weapon?
				projectile.penetrate = 3;           //How many monsters the projectile can penetrate. (OnTileCollide below also decrements penetrate for bounces as well)
				projectile.timeLeft = 3600;          //The live time for the projectile (60 = 1 second, so 600 is 10 seconds)
				projectile.light = 0.5f;            //How much light emit around the projectile
				projectile.ignoreWater = true;          //Does the projectile's speed be influenced by water?
				projectile.tileCollide = false;          //Can the projectile collide with tiles?
			}

			public override Color? GetAlpha(Color lightColor) {
				return new Color(211, 211, 211);
			}
		}
		public class InkArrowProjGray4 : InkArrowProjBase
		{
			public override string Texture
			{
				get
				{
					return "Pyresense/Items/Ammo/InkArrowProj";
				}
			}

			public override void SetStaticDefaults() {
				DisplayName.SetDefault("Ink Arrow");     //The English name of the projectile
			}

			public override void SetDefaults() {
				projectile.CloneDefaults(1);
				projectile.friendly = true;         //Can the projectile deal damage to enemies?
				projectile.hostile = false;         //Can the projectile deal damage to the player?
				projectile.ranged = true;           //Is the projectile shoot by a ranged weapon?
				projectile.penetrate = 3;           //How many monsters the projectile can penetrate. (OnTileCollide below also decrements penetrate for bounces as well)
				projectile.timeLeft = 3600;          //The live time for the projectile (60 = 1 second, so 600 is 10 seconds)
				projectile.light = 0.5f;            //How much light emit around the projectile
				projectile.ignoreWater = true;          //Does the projectile's speed be influenced by water?
				projectile.tileCollide = false;          //Can the projectile collide with tiles?
			}

			public override Color? GetAlpha(Color lightColor) {
				return new Color(192, 192, 192);
			}
		}
		public class InkArrowProjGray5 : InkArrowProjBase
		{
			public override string Texture
			{
				get
				{
					return "Pyresense/Items/Ammo/InkArrowProj";
				}
			}

			public override void SetStaticDefaults() {
				DisplayName.SetDefault("Ink Arrow");     //The English name of the projectile
			}

			public override void SetDefaults() {
				projectile.CloneDefaults(1);
				projectile.friendly = true;         //Can the projectile deal damage to enemies?
				projectile.hostile = false;         //Can the projectile deal damage to the player?
				projectile.ranged = true;           //Is the projectile shoot by a ranged weapon?
				projectile.penetrate = 3;           //How many monsters the projectile can penetrate. (OnTileCollide below also decrements penetrate for bounces as well)
				projectile.timeLeft = 3600;          //The live time for the projectile (60 = 1 second, so 600 is 10 seconds)
				projectile.light = 0.5f;            //How much light emit around the projectile
				projectile.ignoreWater = true;          //Does the projectile's speed be influenced by water?
				projectile.tileCollide = false;          //Can the projectile collide with tiles?
			}

			public override Color? GetAlpha(Color lightColor) {
				return new Color(169, 169, 169);
			}
		}
		public class InkArrowProjGray6 : InkArrowProjBase
		{
			public override string Texture
			{
				get
				{
					return "Pyresense/Items/Ammo/InkArrowProj";
				}
			}

			public override void SetStaticDefaults() {
				DisplayName.SetDefault("Ink Arrow");     //The English name of the projectile
			}

			public override void SetDefaults() {
				projectile.CloneDefaults(1);
				projectile.friendly = true;         //Can the projectile deal damage to enemies?
				projectile.hostile = false;         //Can the projectile deal damage to the player?
				projectile.ranged = true;           //Is the projectile shoot by a ranged weapon?
				projectile.penetrate = 3;           //How many monsters the projectile can penetrate. (OnTileCollide below also decrements penetrate for bounces as well)
				projectile.timeLeft = 3600;          //The live time for the projectile (60 = 1 second, so 600 is 10 seconds)
				projectile.light = 0.5f;            //How much light emit around the projectile
				projectile.ignoreWater = true;          //Does the projectile's speed be influenced by water?
				projectile.tileCollide = false;          //Can the projectile collide with tiles?
			}

			public override Color? GetAlpha(Color lightColor) {
				return new Color(169, 169, 169);
			}
		}
		public class InkArrowProjGray7 : InkArrowProjBase
		{
			public override string Texture
			{
				get
				{
					return "Pyresense/Items/Ammo/InkArrowProj";
				}
			}

			public override void SetStaticDefaults() {
				DisplayName.SetDefault("Ink Arrow");     //The English name of the projectile
			}

			public override void SetDefaults() {
				projectile.CloneDefaults(1);
				projectile.friendly = true;         //Can the projectile deal damage to enemies?
				projectile.hostile = false;         //Can the projectile deal damage to the player?
				projectile.ranged = true;           //Is the projectile shoot by a ranged weapon?
				projectile.penetrate = 3;           //How many monsters the projectile can penetrate. (OnTileCollide below also decrements penetrate for bounces as well)
				projectile.timeLeft = 3600;          //The live time for the projectile (60 = 1 second, so 600 is 10 seconds)
				projectile.light = 0.5f;            //How much light emit around the projectile
				projectile.ignoreWater = true;          //Does the projectile's speed be influenced by water?
				projectile.tileCollide = false;          //Can the projectile collide with tiles?
			}

			public override Color? GetAlpha(Color lightColor) {
				return new Color(128, 128, 128);
			}
		}
		public class InkArrowProjGray8 : InkArrowProjBase
		{
			public override string Texture
			{
				get
				{
					return "Pyresense/Items/Ammo/InkArrowProj";
				}
			}

			public override void SetStaticDefaults() {
				DisplayName.SetDefault("Ink Arrow");     //The English name of the projectile
			}

			public override void SetDefaults() {
				projectile.CloneDefaults(1);
				projectile.friendly = true;         //Can the projectile deal damage to enemies?
				projectile.hostile = false;         //Can the projectile deal damage to the player?
				projectile.ranged = true;           //Is the projectile shoot by a ranged weapon?
				projectile.penetrate = 3;           //How many monsters the projectile can penetrate. (OnTileCollide below also decrements penetrate for bounces as well)
				projectile.timeLeft = 3600;          //The live time for the projectile (60 = 1 second, so 600 is 10 seconds)
				projectile.light = 0.5f;            //How much light emit around the projectile
				projectile.ignoreWater = true;          //Does the projectile's speed be influenced by water?
				projectile.tileCollide = false;          //Can the projectile collide with tiles?
			}

			public override Color? GetAlpha(Color lightColor) {
				return new Color(128, 128, 128);
			}
		}
		public class InkArrowProjGray9 : InkArrowProjBase
		{
			public override string Texture
			{
				get
				{
					return "Pyresense/Items/Ammo/InkArrowProj";
				}
			}

			public override void SetStaticDefaults() {
				DisplayName.SetDefault("Ink Arrow");     //The English name of the projectile
			}

			public override void SetDefaults() {
				projectile.CloneDefaults(1);
				projectile.friendly = true;         //Can the projectile deal damage to enemies?
				projectile.hostile = false;         //Can the projectile deal damage to the player?
				projectile.ranged = true;           //Is the projectile shoot by a ranged weapon?
				projectile.penetrate = 3;           //How many monsters the projectile can penetrate. (OnTileCollide below also decrements penetrate for bounces as well)
				projectile.timeLeft = 3600;          //The live time for the projectile (60 = 1 second, so 600 is 10 seconds)
				projectile.light = 0.5f;            //How much light emit around the projectile
				projectile.ignoreWater = true;          //Does the projectile's speed be influenced by water?
				projectile.tileCollide = false;          //Can the projectile collide with tiles?
			}

			public override Color? GetAlpha(Color lightColor) {
				return new Color(105, 105, 105);
			}
		}
		public class InkArrowProjGray10 : InkArrowProjBase
		{
			public override string Texture
			{
				get
				{
					return "Pyresense/Items/Ammo/InkArrowProj";
				}
			}

			public override void SetStaticDefaults() {
				DisplayName.SetDefault("Ink Arrow");     //The English name of the projectile
			}

			public override void SetDefaults() {
				projectile.CloneDefaults(1);
				projectile.friendly = true;         //Can the projectile deal damage to enemies?
				projectile.hostile = false;         //Can the projectile deal damage to the player?
				projectile.ranged = true;           //Is the projectile shoot by a ranged weapon?
				projectile.penetrate = 3;           //How many monsters the projectile can penetrate. (OnTileCollide below also decrements penetrate for bounces as well)
				projectile.timeLeft = 3600;          //The live time for the projectile (60 = 1 second, so 600 is 10 seconds)
				projectile.light = 0.5f;            //How much light emit around the projectile
				projectile.ignoreWater = true;          //Does the projectile's speed be influenced by water?
				projectile.tileCollide = false;          //Can the projectile collide with tiles?
			}

			public override Color? GetAlpha(Color lightColor) {
				return new Color(105, 105, 105);
			}
		}
		public class InkArrowProjGray11 : InkArrowProjBase
		{
			public override string Texture
			{
				get
				{
					return "Pyresense/Items/Ammo/InkArrowProj";
				}
			}

			public override void SetStaticDefaults() {
				DisplayName.SetDefault("Ink Arrow");     //The English name of the projectile
			}

			public override void SetDefaults() {
				projectile.CloneDefaults(1);
				projectile.friendly = true;         //Can the projectile deal damage to enemies?
				projectile.hostile = false;         //Can the projectile deal damage to the player?
				projectile.ranged = true;           //Is the projectile shoot by a ranged weapon?
				projectile.penetrate = 3;           //How many monsters the projectile can penetrate. (OnTileCollide below also decrements penetrate for bounces as well)
				projectile.timeLeft = 3600;          //The live time for the projectile (60 = 1 second, so 600 is 10 seconds)
				projectile.light = 0.5f;            //How much light emit around the projectile
				projectile.ignoreWater = true;          //Does the projectile's speed be influenced by water?
				projectile.tileCollide = false;          //Can the projectile collide with tiles?
			}

			public override Color? GetAlpha(Color lightColor) {
				return new Color(119, 136, 153);
			}
		}
		public class InkArrowProjGray12 : InkArrowProjBase
		{
			public override string Texture
			{
				get
				{
					return "Pyresense/Items/Ammo/InkArrowProj";
				}
			}

			public override void SetStaticDefaults() {
				DisplayName.SetDefault("Ink Arrow");     //The English name of the projectile
			}

			public override void SetDefaults() {
				projectile.CloneDefaults(1);
				projectile.friendly = true;         //Can the projectile deal damage to enemies?
				projectile.hostile = false;         //Can the projectile deal damage to the player?
				projectile.ranged = true;           //Is the projectile shoot by a ranged weapon?
				projectile.penetrate = 3;           //How many monsters the projectile can penetrate. (OnTileCollide below also decrements penetrate for bounces as well)
				projectile.timeLeft = 3600;          //The live time for the projectile (60 = 1 second, so 600 is 10 seconds)
				projectile.light = 0.5f;            //How much light emit around the projectile
				projectile.ignoreWater = true;          //Does the projectile's speed be influenced by water?
				projectile.tileCollide = false;          //Can the projectile collide with tiles?
			}

			public override Color? GetAlpha(Color lightColor) {
				return new Color(119, 136, 153);
			}
		}
		public class InkArrowProjGray13 : InkArrowProjBase
		{
			public override string Texture
			{
				get
				{
					return "Pyresense/Items/Ammo/InkArrowProj";
				}
			}

			public override void SetStaticDefaults() {
				DisplayName.SetDefault("Ink Arrow");     //The English name of the projectile
			}

			public override void SetDefaults() {
				projectile.CloneDefaults(1);
				projectile.friendly = true;         //Can the projectile deal damage to enemies?
				projectile.hostile = false;         //Can the projectile deal damage to the player?
				projectile.ranged = true;           //Is the projectile shoot by a ranged weapon?
				projectile.penetrate = 3;           //How many monsters the projectile can penetrate. (OnTileCollide below also decrements penetrate for bounces as well)
				projectile.timeLeft = 3600;          //The live time for the projectile (60 = 1 second, so 600 is 10 seconds)
				projectile.light = 0.5f;            //How much light emit around the projectile
				projectile.ignoreWater = true;          //Does the projectile's speed be influenced by water?
				projectile.tileCollide = false;          //Can the projectile collide with tiles?
			}

			public override Color? GetAlpha(Color lightColor) {
				return new Color(112, 128, 144);
			}
		}
		public class InkArrowProjGray14 : InkArrowProjBase
		{
			public override string Texture
			{
				get
				{
					return "Pyresense/Items/Ammo/InkArrowProj";
				}
			}

			public override void SetStaticDefaults() {
				DisplayName.SetDefault("Ink Arrow");     //The English name of the projectile
			}

			public override void SetDefaults() {
				projectile.CloneDefaults(1);
				projectile.friendly = true;         //Can the projectile deal damage to enemies?
				projectile.hostile = false;         //Can the projectile deal damage to the player?
				projectile.ranged = true;           //Is the projectile shoot by a ranged weapon?
				projectile.penetrate = 3;           //How many monsters the projectile can penetrate. (OnTileCollide below also decrements penetrate for bounces as well)
				projectile.timeLeft = 3600;          //The live time for the projectile (60 = 1 second, so 600 is 10 seconds)
				projectile.light = 0.5f;            //How much light emit around the projectile
				projectile.ignoreWater = true;          //Does the projectile's speed be influenced by water?
				projectile.tileCollide = false;          //Can the projectile collide with tiles?
			}

			public override Color? GetAlpha(Color lightColor) {
				return new Color(112, 128, 144);
			}
		}
		public class InkArrowProjGray15 : InkArrowProjBase
		{
			public override string Texture
			{
				get
				{
					return "Pyresense/Items/Ammo/InkArrowProj";
				}
			}

			public override void SetStaticDefaults() {
				DisplayName.SetDefault("Ink Arrow");     //The English name of the projectile
			}

			public override void SetDefaults() {
				projectile.CloneDefaults(1);
				projectile.friendly = true;         //Can the projectile deal damage to enemies?
				projectile.hostile = false;         //Can the projectile deal damage to the player?
				projectile.ranged = true;           //Is the projectile shoot by a ranged weapon?
				projectile.penetrate = 3;           //How many monsters the projectile can penetrate. (OnTileCollide below also decrements penetrate for bounces as well)
				projectile.timeLeft = 3600;          //The live time for the projectile (60 = 1 second, so 600 is 10 seconds)
				projectile.light = 0.5f;            //How much light emit around the projectile
				projectile.ignoreWater = true;          //Does the projectile's speed be influenced by water?
				projectile.tileCollide = false;          //Can the projectile collide with tiles?
			}

			public override Color? GetAlpha(Color lightColor) {
				return new Color(47, 79, 79);
			}
		}
		public class InkArrowProjGray16 : InkArrowProjBase
		{
			public override string Texture
			{
				get
				{
					return "Pyresense/Items/Ammo/InkArrowProj";
				}
			}

			public override void SetStaticDefaults() {
				DisplayName.SetDefault("Ink Arrow");     //The English name of the projectile
			}

			public override void SetDefaults() {
				projectile.CloneDefaults(1);
				projectile.friendly = true;         //Can the projectile deal damage to enemies?
				projectile.hostile = false;         //Can the projectile deal damage to the player?
				projectile.ranged = true;           //Is the projectile shoot by a ranged weapon?
				projectile.penetrate = 3;           //How many monsters the projectile can penetrate. (OnTileCollide below also decrements penetrate for bounces as well)
				projectile.timeLeft = 3600;          //The live time for the projectile (60 = 1 second, so 600 is 10 seconds)
				projectile.light = 0.5f;            //How much light emit around the projectile
				projectile.ignoreWater = true;          //Does the projectile's speed be influenced by water?
				projectile.tileCollide = false;          //Can the projectile collide with tiles?
			}

			public override Color? GetAlpha(Color lightColor) {
				return new Color(47, 79, 79);
			}
		}
		public class InkArrowProjGray17 : InkArrowProjBase
		{
			public override string Texture
			{
				get
				{
					return "Pyresense/Items/Ammo/InkArrowProj";
				}
			}

			public override void SetStaticDefaults() {
				DisplayName.SetDefault("Ink Arrow");     //The English name of the projectile
			}

			public override void SetDefaults() {
				projectile.CloneDefaults(1);
				projectile.friendly = true;         //Can the projectile deal damage to enemies?
				projectile.hostile = false;         //Can the projectile deal damage to the player?
				projectile.ranged = true;           //Is the projectile shoot by a ranged weapon?
				projectile.penetrate = 3;           //How many monsters the projectile can penetrate. (OnTileCollide below also decrements penetrate for bounces as well)
				projectile.timeLeft = 3600;          //The live time for the projectile (60 = 1 second, so 600 is 10 seconds)
				projectile.light = 0.5f;            //How much light emit around the projectile
				projectile.ignoreWater = true;          //Does the projectile's speed be influenced by water?
				projectile.tileCollide = false;          //Can the projectile collide with tiles?
			}

			public override Color? GetAlpha(Color lightColor) {
				return new Color(0, 0, 0);
			}
		}
}