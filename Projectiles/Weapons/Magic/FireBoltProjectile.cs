using Pyresense.Dusts.Weapons.Magic;
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

namespace Pyresense.Projectiles.Weapons.Magic
{
	public class FireBoltProjectile : ModProjectile
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Fire Bolt");
		}

		public override void SetDefaults() {
			projectile.CloneDefaults(ProjectileID.WaterBolt);
			aiType = ProjectileID.WaterBolt;
		}

		public override bool PreKill(int timeLeft) {
			projectile.type = ProjectileID.WaterBolt;
			return true;
		}

		public override bool OnTileCollide(Vector2 oldVelocity) {
			for (int i = 0; i < 5; i++) {
				int a = Projectile.NewProjectile(projectile.Center.X, projectile.Center.Y - 16f, Main.rand.Next(-10, 11) * .25f, Main.rand.Next(-10, -5) * .25f, ProjectileID.WaterBolt, (int)(projectile.damage * .5f), 0, projectile.owner);
				Main.projectile[a].aiStyle = 1;
				Main.projectile[a].tileCollide = true;
			}
			return true;
		}

		public override bool PreAI() {
			return true;
		}
		public override void AI() {
			Dust.NewDust(projectile.position + projectile.velocity, projectile.width, projectile.height, DustType<FireBoltDust>(), projectile.velocity.X * 0.5f, projectile.velocity.Y * 0.5f);
		}
	}
}