﻿using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace CelestialInfernalMod.Items.Tools
{
	public class EclipseAxe : ModItem
	{
		public override void SetDefaults()
		{
			item.damage = 16;
			item.width = 32;
			item.height = 32;
			item.useTime = 12;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = Item.buyPrice(0, 0, 65, 0);
			item.rare = 3;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;

			item.axe = 60;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("EclipseEssence"), 12); //modded materials
			recipe.AddIngredient(ItemID.HallowedBar, 8);
			recipe.AddIngredient(ItemID.Wood, 4); //vanilla materials
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
