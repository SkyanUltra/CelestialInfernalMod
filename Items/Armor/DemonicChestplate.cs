﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace CelestialInfernalMod.Items.Armor
{
    [AutoloadEquip(EquipType.Body)]
    public class DemonicChestplate : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Demonic Chestplate");
            Tooltip.SetDefault("Increased damage by 10%"
                + "Increased crit chance by 8%");
        }

        public override void SetDefaults()
        {
            item.width = 22;
            item.height = 20;
            item.value = 1000;
            item.rare = 2;
            item.defense = 7; // The Defence value for this piece of armour.
        }

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return body.type == mod.ItemType("DemonicHelmet") && legs.type == mod.ItemType("DemonicLeggings");
        }

        public override void UpdateEquip(Player player)
        {
            player.allDamage += 0.1f;
            player.magicCrit += 8;
            player.rangedCrit += 8;
            player.magicCrit += 8;
            player.thrownCrit += 8;
        }


        public override void AddRecipes()
        {
            ModRecipe r = new ModRecipe(mod);
            r.AddIngredient(mod.ItemType("DemonFlesh"), 35);
            r.AddIngredient(ItemID.HellstoneBar, 20);
            r.AddTile(TileID.Anvils);
            r.SetResult(this);
            r.AddRecipe();
        }
    }
}