using Microsoft.Xna.Framework;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Pyresense.Boss.Pharaoh
{
	public class SandBallSmall : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			ProjectileID.Sets.Homing[projectile.type] = true;
		}

		public override void SetDefaults()
		{
			projectile.width = 42;
			projectile.height = 42;
			projectile.alpha =  0;
			projectile.friendly = false;
			projectile.hostile = true;
			projectile.tileCollide = true;
			projectile.ignoreWater = false;
			projectile.scale = 0.5f;
			projectile.damage = 26;
		}
		public override void AI()
		{
			projectile.position += projectile.velocity;
			projectile.velocity *= 1.15f;
			base.AI();
		}
		public override void PostAI()
		{
			int dust1 = Dust.NewDust(projectile.position, projectile.width, projectile.height, DustID.Blood, projectile.velocity.X, projectile.velocity.Y, 0, Color.Red, 1);
			int dust2 = Dust.NewDust(projectile.position, projectile.width, projectile.height, DustID.Blood, projectile.velocity.X, projectile.velocity.Y, 0, Color.Black, 1);
			int dust3 = Dust.NewDust(projectile.position, projectile.width, projectile.height, DustID.Blood, projectile.velocity.X, projectile.velocity.Y, 0, Color.White, 1);
			Main.dust[dust1].velocity /= 2f;
			Main.dust[dust2].velocity /= 2f;
			Main.dust[dust3].velocity /= 2f;
			base.PostAI();
		}
	}
}