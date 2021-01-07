using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Microsoft.Xna.Framework;

namespace Pykretemod.Items.armor

{
    [AutoloadEquip(EquipType.Head)]
    public class PykreteHelmetMage : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Pykrete Mask");
            Tooltip.SetDefault("5% increased magic damage and +20 max mana");
        }
        public override void SetDefaults()
        {
            item.Size = new Vector2(16);
            item.value = Item.sellPrice(silver: 10);
            item.rare = ItemRarityID.Blue;
            item.defense = 3;
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
            return body.type == ItemType<PykreteChestplate>() && legs.type == ItemType<PykreteLeggings>() && head.type == ItemType<PykreteHelmetMage>();
        }
        public override void UpdateEquip(Player player)
        {
            player.magicDamage += 0.05f;
            player.statManaMax2 += 20;
        }


        public override void UpdateArmorSet(Player player)
        {
            player.magicDamage += 0.05f;
            player.magicCrit += 5;
            
        }
    }
}
