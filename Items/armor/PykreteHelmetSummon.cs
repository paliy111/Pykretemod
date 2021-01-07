using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Microsoft.Xna.Framework;

namespace Pykretemod.Items.armor
{
    [AutoloadEquip(EquipType.Head)]
    public class PykreteHelmetSummon : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Pykrete Hat");
            Tooltip.SetDefault("increases your max number of minions by 2 and increases minion damage by 5%");
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
            return body.type == ItemType<PykreteChestplate>() && legs.type == ItemType<PykreteLeggings>() && head.type == ItemType<PykreteHelmetSummon>();
        }
        public override void UpdateEquip(Player player)
        {
            player.minionDamage += 0.05f;
            player.maxMinions += 2;
        }


        public override void UpdateArmorSet(Player player)
        {
            player.minionDamage += 0.05f;
            player.maxMinions += 1;
        }
    }
}
