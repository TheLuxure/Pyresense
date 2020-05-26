using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Pyresense.Items.Dev.CAT
{
	public class DreamerStar : ModProjectile
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Dreamer Star");
		}

		public override void SetDefaults() {
			projectile.CloneDefaults(ProjectileID.Starfury);
			aiType = ProjectileID.Starfury;
			projectile.magic = true;
			projectile.damage = 23;
			projectile.scale = .5f;
		}

		public override bool PreKill(int timeLeft) {
			projectile.type = ProjectileID.Starfury;
			return true;
		}
	}
	public class DreamerStarSmall : ModProjectile
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Dreamer Star");
		}

		public override void SetDefaults() {
			projectile.CloneDefaults(ProjectileID.StarWrath);
			aiType = ProjectileID.StarWrath;
			projectile.magic = true;
			projectile.damage = 35;
		}

		public override bool PreKill(int timeLeft) {
			projectile.type = ProjectileID.StarWrath;
			return true;
		}

		public override bool OnTileCollide(Vector2 oldVelocity) {
			for (int i = 0; i < 5; i++) {
				int a = Projectile.NewProjectile(projectile.Center.X, projectile.Center.Y - 16f, Main.rand.Next(-10, 11) * .25f, Main.rand.Next(-10, -5) * .25f, mod.ProjectileType("DreamerStar"), (int)(projectile.damage * .5f), 0, projectile.owner);
				Main.projectile[a].aiStyle = 1;
				Main.projectile[a].tileCollide = true;
			}
			return true;
		}
	}
	public class DreamerStarMedium : ModProjectile
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Dreamer Star");
		}

		public override void SetDefaults() {
			projectile.CloneDefaults(ProjectileID.StarWrath);
			aiType = ProjectileID.StarWrath;
			projectile.magic = true;
			projectile.scale = 2f;
			projectile.damage = 53;
		}

		public override bool PreKill(int timeLeft) {
			projectile.type = ProjectileID.StarWrath;
			return true;
		}

		public override bool OnTileCollide(Vector2 oldVelocity) {
			for (int i = 0; i < 5; i++) {
				int a = Projectile.NewProjectile(projectile.Center.X, projectile.Center.Y - 16f, Main.rand.Next(-10, 11) * .25f, Main.rand.Next(-10, -5) * .25f, mod.ProjectileType("DreamerStar"), (int)(projectile.damage * .5f), 0, projectile.owner);
				Main.projectile[a].aiStyle = 1;
				Main.projectile[a].tileCollide = true;
			}
			return true;
		}
	}
	public class DreamerStarLarge : ModProjectile
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Dreamer Star");
		}

		public override void SetDefaults() {
			projectile.CloneDefaults(ProjectileID.StarWrath);
			aiType = ProjectileID.StarWrath;
			projectile.magic = true;
			projectile.scale = 3f;
			projectile.damage = 70;
		}

		public override bool PreKill(int timeLeft) {
			projectile.type = ProjectileID.StarWrath;
			return true;
		}

		public override bool OnTileCollide(Vector2 oldVelocity) {
			for (int i = 0; i < 5; i++) {
				int a = Projectile.NewProjectile(projectile.Center.X, projectile.Center.Y - 16f, Main.rand.Next(-10, 11) * .25f, Main.rand.Next(-10, -5) * .25f, mod.ProjectileType("DreamerStar"), (int)(projectile.damage * .5f), 0, projectile.owner);
				Main.projectile[a].aiStyle = 1;
				Main.projectile[a].tileCollide = true;
			}
			return true;
		}
	}
	public class DreamerStarMega2 : ModProjectile
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Dreamer Star");
		}

		public override void SetDefaults() {
			projectile.CloneDefaults(ProjectileID.StarWrath);
			aiType = ProjectileID.StarWrath;
			projectile.magic = true;
			projectile.scale = 4f;
			projectile.damage = 70;
		}

		public override bool PreKill(int timeLeft) {
			projectile.type = ProjectileID.StarWrath;
			return true;
		}

		public override bool OnTileCollide(Vector2 oldVelocity) {
			for (int i = 0; i < 5; i++) {
				int a = Projectile.NewProjectile(projectile.Center.X, projectile.Center.Y - 16f, Main.rand.Next(-10, 11) * .25f, Main.rand.Next(-10, -5) * .25f, mod.ProjectileType("DreamerStar"), (int)(projectile.damage * .5f), 0, projectile.owner);
				Main.projectile[a].aiStyle = 1;
				Main.projectile[a].tileCollide = true;
			}
			return true;
		}
	}
	//Ultra Attack (mega star)
	public class DreamerStarUltra : ModProjectile
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Dreamer Star");
		}

		public override void SetDefaults() {
			projectile.CloneDefaults(ProjectileID.StarWrath);
			aiType = ProjectileID.StarWrath;
			projectile.magic = true;
			projectile.scale = 5f;
			projectile.damage = 70;
		}

		public override bool PreKill(int timeLeft) {
			projectile.type = ProjectileID.StarWrath;
			return true;
		}

		public override bool OnTileCollide(Vector2 oldVelocity) {
			for (int i = 0; i < 5; i++) {
				int a = Projectile.NewProjectile(projectile.Center.X, projectile.Center.Y - 16f, Main.rand.Next(-10, 11) * .25f, Main.rand.Next(-10, -5) * .25f, mod.ProjectileType("DreamerStarMega"), (int)(projectile.damage * .5f), 0, projectile.owner);
				Main.projectile[a].aiStyle = 1;
				Main.projectile[a].tileCollide = true;
			}
			return true;
		}
	}
	public class DreamerStarSmall2 : ModProjectile
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Dreamer Star");
		}

		public override void SetDefaults() {
			projectile.CloneDefaults(ProjectileID.Starfury);
			aiType = ProjectileID.Starfury;
			projectile.magic = true;
			projectile.damage = 35;
		}

		public override bool PreKill(int timeLeft) {
			projectile.type = ProjectileID.Starfury;
			return true;
		}

		public override bool OnTileCollide(Vector2 oldVelocity) {
			for (int i = 0; i < 5; i++) {
				int a = Projectile.NewProjectile(projectile.Center.X, projectile.Center.Y - 16f, Main.rand.Next(-10, 11) * .25f, Main.rand.Next(-10, -5) * .25f, mod.ProjectileType("DreamerStar"), (int)(projectile.damage * .5f), 0, projectile.owner);
				Main.projectile[a].aiStyle = 1;
				Main.projectile[a].tileCollide = true;
			}
			return true;
		}
	}
	public class DreamerStarMedium2 : ModProjectile
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Dreamer Star");
		}

		public override void SetDefaults() {
			projectile.CloneDefaults(ProjectileID.Starfury);
			aiType = ProjectileID.Starfury;
			projectile.magic = true;
			projectile.scale = 2f;
			projectile.damage = 53;
		}

		public override bool PreKill(int timeLeft) {
			projectile.type = ProjectileID.Starfury;
			return true;
		}

		public override bool OnTileCollide(Vector2 oldVelocity) {
			for (int i = 0; i < 5; i++) {
				int a = Projectile.NewProjectile(projectile.Center.X, projectile.Center.Y - 16f, Main.rand.Next(-10, 11) * .25f, Main.rand.Next(-10, -5) * .25f, mod.ProjectileType("DreamerStarSmall2"), (int)(projectile.damage * .5f), 0, projectile.owner);
				Main.projectile[a].aiStyle = 1;
				Main.projectile[a].tileCollide = true;
			}
			return true;
		}
	}
	public class DreamerStarLarge2 : ModProjectile
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Dreamer Star");
		}

		public override void SetDefaults() {
			projectile.CloneDefaults(ProjectileID.Starfury);
			aiType = ProjectileID.Starfury;
			projectile.magic = true;
			projectile.scale = 3f;
			projectile.damage = 70;
		}

		public override bool PreKill(int timeLeft) {
			projectile.type = ProjectileID.Starfury;
			return true;
		}

		public override bool OnTileCollide(Vector2 oldVelocity) {
			for (int i = 0; i < 5; i++) {
				int a = Projectile.NewProjectile(projectile.Center.X, projectile.Center.Y - 16f, Main.rand.Next(-10, 11) * .25f, Main.rand.Next(-10, -5) * .25f, mod.ProjectileType("DreamerStarMedium2"), (int)(projectile.damage * .5f), 0, projectile.owner);
				Main.projectile[a].aiStyle = 1;
				Main.projectile[a].tileCollide = true;
			}
			return true;
		}
	}
	public class DreamerStarMega : ModProjectile
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Dreamer Star");
		}

		public override void SetDefaults() {
			projectile.CloneDefaults(ProjectileID.Starfury);
			aiType = ProjectileID.Starfury;
			projectile.magic = true;
			projectile.scale = 4f;
			projectile.damage = 70;
		}

		public override bool PreKill(int timeLeft) {
			projectile.type = ProjectileID.Starfury;
			return true;
		}

		public override bool OnTileCollide(Vector2 oldVelocity) {
			for (int i = 0; i < 5; i++) {
				int a = Projectile.NewProjectile(projectile.Center.X, projectile.Center.Y - 16f, Main.rand.Next(-10, 11) * .25f, Main.rand.Next(-10, -5) * .25f, mod.ProjectileType("DreamerStarLarge2"), (int)(projectile.damage * .5f), 0, projectile.owner);
				Main.projectile[a].aiStyle = 1;
				Main.projectile[a].tileCollide = true;
			}
			return true;
		}
	}
}