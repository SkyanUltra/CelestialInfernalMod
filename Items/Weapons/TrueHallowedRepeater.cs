using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CelestialInfernalMod.Items.Weapons
{
	public class TrueHallowedRepeater : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("True Hallowed Repeater");
		}

		public override void SetDefaults()
		{
			item.damage = 45;
			item.width = 56;
			item.height = 48;
			item.useTime = 12;
			item.useAnimation = 12;
			item.useStyle = 5;
			item.value = Item.buyPrice(0, 25, 0, 0);
			item.rare = 7;
			item.noMelee = true;
			item.useAmmo = AmmoID.Arrow;
			item.UseSound = SoundID.Item5;
			item.shoot = 1;
            item.autoReuse = true;
            item.knockBack = 3.5f;
			item.shootSpeed = 12f;
			item.ranged = true;
        }
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(578, 1);
            recipe.AddIngredient(mod.ItemType("BrokenHeroBow"), 1);
			recipe.AddTile(134);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}