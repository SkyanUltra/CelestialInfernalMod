using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CelestialInfernalMod.Items.Weapons
{
	public class HeavenlyStaff : ModItem
	{

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Heavenly Staff"); 
            Item.staff[item.type] = true;
		}
        public override void SetDefaults()
		{
			item.damage = 58;
			item.width = 28;
			item.height = 28;
			item.useTime = 18;
			item.useAnimation = 18;
			item.useStyle = 5;
			item.value = Item.buyPrice(0, 13, 55, 0);
			item.rare = 5;
			item.knockBack = 2;
			item.noMelee = true;
			item.mana = 8;
			item.UseSound = SoundID.Item20;
			item.shoot = ProjectileID.AmethystBolt;
			item.shootSpeed = 8f;
			item.autoReuse = true;
			item.magic = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("PutridVertebrae"), 18); //modded materials
			recipe.AddIngredient(ItemID.Vilethorn, 1);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
            recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("PutridVertebrae"), 18); //modded materials
			recipe.AddIngredient(ItemID.CrimsonRod, 1);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}