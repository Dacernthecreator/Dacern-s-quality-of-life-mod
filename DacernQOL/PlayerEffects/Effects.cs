using DacernQOL.Items;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace DacernQOL.PlayerEffects
{
	public class DacernPlayer : ModPlayer
    {
        public override void PostUpdate()
        {
            player.pickSpeed -= 2;
            player.maxRunSpeed += 0.5f;
            player.accRunSpeed += 0.5f;
            player.tileSpeed += 2;
            player.jumpSpeedBoost += 2;
            player.moveSpeed += 0.5f;
            player.wallSpeed += 0.5f;
            if (Main.hardMode)
            {
                player.noFallDmg = true;
            }
        }

        public override void SetupStartInventory(IList<Item> items, bool mediumcoreDeath)
        {
            Item item = new Item();
            item.SetDefaults(ItemID.BonePickaxe);
            item.stack = 1;
            items.Add(item);

            item = new Item();
            item.SetDefaults(ModContent.ItemType<BoneAxe>());
            item.stack = 1;
            items.Add(item);

        }

    }
}