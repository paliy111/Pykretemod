using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using static Terraria.ModLoader.ModContent;
using Microsoft.Xna.Framework;

namespace Pykretemod.Items.armor
{
    [AutoloadEquip(EquipType.Head)]
    public class PykreteHelmetRange : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Pykrete Headgear");
            Tooltip.SetDefault("5% increased ranged dammage and crit chance");
        }
        public override void SetDefaults()
        {
            item.Size = new Vector2(16);
            item.value = Item.sellPrice(silver: 10);
            item.rare = ItemRarityID.Blue;
            item.defense = 4;
        }


        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemType<Pykrete>(), 12);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }


        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return body.type == ItemType<PykreteChestplate>() && legs.type == ItemType<PykreteLeggings>() && head.type == ItemType<PykreteHelmetRange>();
        }
        public override void UpdateEquip(Player player)
        {
            player.rangedDamage += 0.05f;
        }


        public override void UpdateArmorSet(Player player)
        {
            player.rangedDamage += 0.05f;
            player.rangedCrit += 5;
            player.frostBurn = true;
        }
    }
}

