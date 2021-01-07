using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Microsoft.Xna.Framework;
using static Terraria.ModLoader.ModContent;

namespace Pykretemod.Items.armor
{
    [AutoloadEquip(EquipType.Head)]
    public class PykreteHelmetMelee : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Pykrete Helmet");
            Tooltip.SetDefault("5% increased melee damage and critical strike chance and speed");
        }


        public override void SetDefaults()
        {
            item.Size = new Vector2(16);
            item.value = Item.sellPrice(silver: 10);
            item.rare = ItemRarityID.Blue;
            item.defense = 5;
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
            return body.type == ItemType<PykreteChestplate>() && legs.type == ItemType<PykreteLeggings>();
        }
        public override void UpdateEquip(Player player) => player.meleeSpeed += 0.05f;


        public override void UpdateArmorSet(Player player)
        {
            player.meleeDamage += 0.05f;
            player.meleeCrit += 5;
            player.frostBurn = true;
        }
    }
}
