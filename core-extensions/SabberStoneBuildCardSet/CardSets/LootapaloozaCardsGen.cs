using System.Collections.Generic;
using SabberStoneCore.Enchants;
using SabberStoneCore.Conditions;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Zones;
using SabberStoneCore.Model.Entities;
using SabberStoneCore.Tasks;
using SabberStoneCore.Tasks.SimpleTasks;

namespace SabberStoneCore.CardSets.Undefined
{
	public class LootapaloozaCardsGen
	{
		private static void Druid(IDictionary<string, Power> cards)
		{
			// ----------------------------------------- MINION - DRUID
			// [LOOT_048] Ironwood Golem - COST:4 [ATK:3/HP:6] 
			// - Fac: neutral, Set: lootapalooza, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			//       Can only attack if you have 3 or more Armor.
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("LOOT_048", new Power {
				// TODO [LOOT_048] Ironwood Golem && Test: Ironwood Golem_LOOT_048
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- MINION - DRUID
			// [LOOT_056] Astral Tiger - COST:4 [ATK:3/HP:5] 
			// - Set: lootapalooza, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Shuffle a
			//        copy of this minion into_your_deck.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("LOOT_056", new Power {
				// TODO [LOOT_056] Astral Tiger && Test: Astral Tiger_LOOT_056
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- MINION - DRUID
			// [LOOT_314] Grizzled Guardian - COST:8 [ATK:3/HP:5] 
			// - Race: beast, Set: lootapalooza, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			//       <b>Deathrattle:</b> <b>Recruit</b> 2_minions that cost (4)_or_less.
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			// RefTag:
			// - RECRUIT = 1
			// --------------------------------------------------------
			cards.Add("LOOT_314", new Power {
				// TODO [LOOT_314] Grizzled Guardian && Test: Grizzled Guardian_LOOT_314
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- MINION - DRUID
			// [LOOT_329] Ixlid, Fungal Lord - COST:5 [ATK:2/HP:4] 
			// - Race: elemental, Set: lootapalooza, Rarity: legendary
			// --------------------------------------------------------
			// Text: After you play a minion, summon a copy of it.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - 717 = 1
			// --------------------------------------------------------
			cards.Add("LOOT_329", new Power {
				// TODO [LOOT_329] Ixlid, Fungal Lord && Test: Ixlid, Fungal Lord_LOOT_329
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- MINION - DRUID
			// [LOOT_351] Greedy Sprite - COST:3 [ATK:3/HP:1] 
			// - Set: lootapalooza, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Gain an empty Mana Crystal.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("LOOT_351", new Power {
				// TODO [LOOT_351] Greedy Sprite && Test: Greedy Sprite_LOOT_351
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ SPELL - DRUID
			// [LOOT_047] Barkskin - COST:1 
			// - Set: lootapalooza, Rarity: common
			// --------------------------------------------------------
			// Text: Give a minion +3 Health. Gain 3 Armor.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("LOOT_047", new Power {
				// TODO [LOOT_047] Barkskin && Test: Barkskin_LOOT_047
				InfoCardId = "LOOT_047e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ SPELL - DRUID
			// [LOOT_051] Lesser Jasper Spellstone - COST:1 
			// - Set: lootapalooza, Rarity: rare
			// --------------------------------------------------------
			// Text: Deal $2 damage to a minion. @<i>(Gain 3 Armor to upgrade.)</i> @spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - TAG_SCRIPT_DATA_NUM_2 = 3
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			// RefTag:
			// - ARMOR = 1
			// --------------------------------------------------------
			cards.Add("LOOT_051", new Power {
				// TODO [LOOT_051] Lesser Jasper Spellstone && Test: Lesser Jasper Spellstone_LOOT_051
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ SPELL - DRUID
			// [LOOT_054] Branching Paths - COST:4 
			// - Set: lootapalooza, Rarity: epic
			// --------------------------------------------------------
			// Text: [x]<b>Choose Twice -</b> Draw a
			//       card; Give your minions 
			//       +1 Attack; Gain 6 Armor.
			// --------------------------------------------------------
			// Entourage: LOOT_054d, LOOT_054b, LOOT_054c
			// --------------------------------------------------------
			cards.Add("LOOT_054", new Power {
				// TODO [LOOT_054] Branching Paths && Test: Branching Paths_LOOT_054
				InfoCardId = "LOOT_054be",
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ SPELL - DRUID
			// [LOOT_309] Oaken Summons - COST:4 
			// - Set: lootapalooza, Rarity: common
			// --------------------------------------------------------
			// Text: Gain 6 Armor.
			//       <b>Recruit</b> a minion that costs (4) or less.
			// --------------------------------------------------------
			// RefTag:
			// - RECRUIT = 1
			// --------------------------------------------------------
			cards.Add("LOOT_309", new Power {
				// TODO [LOOT_309] Oaken Summons && Test: Oaken Summons_LOOT_309
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- WEAPON - DRUID
			// [LOOT_392] Twig of the World Tree - COST:4 [ATK:1/HP:0] 
			// - Set: lootapalooza, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Gain 10 Mana Crystals.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - DURABILITY = 5
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("LOOT_392", new Power {
				// TODO [LOOT_392] Twig of the World Tree && Test: Twig of the World Tree_LOOT_392
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void DruidNonCollect(IDictionary<string, Power> cards)
		{
			// ------------------------------------------ SPELL - DRUID
			// [LOOT_051t1] Jasper Spellstone (*) - COST:1 
			// - Set: lootapalooza, Rarity: rare
			// --------------------------------------------------------
			// Text: Deal $4 damage to a minion. @ @spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - TAG_SCRIPT_DATA_NUM_2 = 3
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			// RefTag:
			// - ARMOR = 1
			// --------------------------------------------------------
			cards.Add("LOOT_051t1", new Power {
				// TODO [LOOT_051t1] Jasper Spellstone && Test: Jasper Spellstone_LOOT_051t1
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ SPELL - DRUID
			// [LOOT_051t2] Greater Jasper Spellstone (*) - COST:1 
			// - Set: lootapalooza, Rarity: rare
			// --------------------------------------------------------
			// Text: Deal $6 damage to a minion. @spelldmg
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("LOOT_051t2", new Power {
				// TODO [LOOT_051t2] Greater Jasper Spellstone && Test: Greater Jasper Spellstone_LOOT_051t2
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ SPELL - DRUID
			// [LOOT_054b] Explore the Darkness (*) - COST:0 
			// - Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: Give your minions +1 Attack.
			// --------------------------------------------------------
			cards.Add("LOOT_054b", new Power {
				// TODO [LOOT_054b] Explore the Darkness && Test: Explore the Darkness_LOOT_054b
				InfoCardId = "LOOT_054be",
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ SPELL - DRUID
			// [LOOT_054c] Loot the Chest (*) - COST:0 
			// - Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: Gain 6 Armor.
			// --------------------------------------------------------
			cards.Add("LOOT_054c", new Power {
				// TODO [LOOT_054c] Loot the Chest && Test: Loot the Chest_LOOT_054c
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ SPELL - DRUID
			// [LOOT_054d] Eat the Mushroom (*) - COST:0 
			// - Fac: neutral, Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: Draw a card.
			// --------------------------------------------------------
			cards.Add("LOOT_054d", new Power {
				// TODO [LOOT_054d] Eat the Mushroom && Test: Eat the Mushroom_LOOT_054d
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void Hunter(IDictionary<string, Power> cards)
		{
			// ---------------------------------------- MINION - HUNTER
			// [LOOT_078] Cave Hydra - COST:3 [ATK:2/HP:4] 
			// - Race: beast, Set: lootapalooza, Rarity: common
			// --------------------------------------------------------
			// Text: Also damages the minions next to whomever
			//       this attacks.
			// --------------------------------------------------------
			cards.Add("LOOT_078", new Power {
				// TODO [LOOT_078] Cave Hydra && Test: Cave Hydra_LOOT_078
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- MINION - HUNTER
			// [LOOT_511] Kathrena Winterwisp - COST:8 [ATK:6/HP:6] 
			// - Set: lootapalooza, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry and Deathrattle:</b> <b>Recruit</b> a Beast.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - DEATHRATTLE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - RECRUIT = 1
			// --------------------------------------------------------
			cards.Add("LOOT_511", new Power {
				// TODO [LOOT_511] Kathrena Winterwisp && Test: Kathrena Winterwisp_LOOT_511
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- MINION - HUNTER
			// [LOOT_520] Seeping Oozeling - COST:6 [ATK:5/HP:4] 
			// - Set: lootapalooza, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Gain the <b>Deathrattle</b> of a random minion in your deck.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("LOOT_520", new Power {
				// TODO [LOOT_520] Seeping Oozeling && Test: Seeping Oozeling_LOOT_520
				InfoCardId = "LOOT_520e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- SPELL - HUNTER
			// [LOOT_077] Flanking Strike - COST:4 
			// - Set: lootapalooza, Rarity: common
			// --------------------------------------------------------
			// Text: Deal $3 damage to a minion. Summon a 3/3 Wolf. @spelldmg
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("LOOT_077", new Power {
				// TODO [LOOT_077] Flanking Strike && Test: Flanking Strike_LOOT_077
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- SPELL - HUNTER
			// [LOOT_079] Wandering Monster - COST:2 
			// - Fac: neutral, Set: lootapalooza, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Secret:</b> When an enemy attacks your hero, summon a 3-Cost minion as the new target.
			// --------------------------------------------------------
			// GameTag:
			// - SECRET = 1
			// --------------------------------------------------------
			cards.Add("LOOT_079", new Power {
				// TODO [LOOT_079] Wandering Monster && Test: Wandering Monster_LOOT_079
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- SPELL - HUNTER
			// [LOOT_080] Lesser Emerald Spellstone - COST:5 
			// - Set: lootapalooza, Rarity: rare
			// --------------------------------------------------------
			// Text: Summon two 3/3_Wolves. <i>(Play a <b>Secret</b> to upgrade.)</i>
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("LOOT_080", new Power {
				// TODO [LOOT_080] Lesser Emerald Spellstone && Test: Lesser Emerald Spellstone_LOOT_080
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- SPELL - HUNTER
			// [LOOT_217] To My Side! - COST:6 
			// - Set: lootapalooza, Rarity: epic
			// --------------------------------------------------------
			// Text: [x]Summon an Animal
			//       Companion, or 2 if your
			//       deck has no minions.
			// --------------------------------------------------------
			// Entourage: NEW1_032, NEW1_033, NEW1_034
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_NUM_MINION_SLOTS = 1
			// --------------------------------------------------------
			cards.Add("LOOT_217", new Power {
				// TODO [LOOT_217] To My Side! && Test: To My Side!_LOOT_217
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- SPELL - HUNTER
			// [LOOT_522] Crushing Walls - COST:7 
			// - Set: lootapalooza, Rarity: epic
			// --------------------------------------------------------
			// Text: Destroy your opponent's left and right-most minions.
			// --------------------------------------------------------
			cards.Add("LOOT_522", new Power {
				// TODO [LOOT_522] Crushing Walls && Test: Crushing Walls_LOOT_522
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- WEAPON - HUNTER
			// [LOOT_085] Rhok'delar - COST:7 [ATK:4/HP:0] 
			// - Set: lootapalooza, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> If your deck has no minions, fill your_hand with Hunter_spells.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - DURABILITY = 2
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("LOOT_085", new Power {
				// TODO [LOOT_085] Rhok'delar && Test: Rhok'delar_LOOT_085
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- WEAPON - HUNTER
			// [LOOT_222] Candleshot - COST:1 [ATK:1/HP:0] 
			// - Set: lootapalooza, Rarity: common
			// --------------------------------------------------------
			// Text: Your hero is <b>Immune</b> while attacking.
			// --------------------------------------------------------
			// GameTag:
			// - DURABILITY = 3
			// --------------------------------------------------------
			// RefTag:
			// - IMMUNE = 1
			// --------------------------------------------------------
			cards.Add("LOOT_222", new Power {
				// TODO [LOOT_222] Candleshot && Test: Candleshot_LOOT_222
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void HunterNonCollect(IDictionary<string, Power> cards)
		{
			// ---------------------------------------- MINION - HUNTER
			// [LOOT_077t] Wolf (*) - COST:3 [ATK:3/HP:3] 
			// - Race: beast, Set: lootapalooza, 
			// --------------------------------------------------------
			cards.Add("LOOT_077t", new Power {
				// TODO [LOOT_077t] Wolf && Test: Wolf_LOOT_077t
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- SPELL - HUNTER
			// [LOOT_080t2] Emerald Spellstone (*) - COST:5 
			// - Set: lootapalooza, Rarity: rare
			// --------------------------------------------------------
			// Text: Summon three 3/3_Wolves. <i>(Play a <b>Secret</b> to upgrade.)</i>
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("LOOT_080t2", new Power {
				// TODO [LOOT_080t2] Emerald Spellstone && Test: Emerald Spellstone_LOOT_080t2
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- SPELL - HUNTER
			// [LOOT_080t3] Greater Emerald Spellstone (*) - COST:5 
			// - Set: lootapalooza, Rarity: rare
			// --------------------------------------------------------
			// Text: Summon four 3/3_Wolves.
			// --------------------------------------------------------
			cards.Add("LOOT_080t3", new Power {
				// TODO [LOOT_080t3] Greater Emerald Spellstone && Test: Greater Emerald Spellstone_LOOT_080t3
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void Mage(IDictionary<string, Power> cards)
		{
			// ------------------------------------------ MINION - MAGE
			// [LOOT_170] Raven Familiar - COST:2 [ATK:2/HP:2] 
			// - Race: beast, Set: lootapalooza, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Reveal a spell in each deck. If yours costs more, draw it.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("LOOT_170", new Power {
				// TODO [LOOT_170] Raven Familiar && Test: Raven Familiar_LOOT_170
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ MINION - MAGE
			// [LOOT_231] Arcane Artificer - COST:1 [ATK:1/HP:2] 
			// - Race: elemental, Set: lootapalooza, Rarity: common
			// --------------------------------------------------------
			// Text: Whenever you cast a spell, gain Armor equal to its_Cost.
			// --------------------------------------------------------
			cards.Add("LOOT_231", new Power {
				// TODO [LOOT_231] Arcane Artificer && Test: Arcane Artificer_LOOT_231
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ MINION - MAGE
			// [LOOT_535] Dragoncaller Alanna - COST:9 [ATK:3/HP:3] 
			// - Set: lootapalooza, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Summon a 5/5 Dragon for each spell you cast this game that costs (5) or more.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("LOOT_535", new Power {
				// TODO [LOOT_535] Dragoncaller Alanna && Test: Dragoncaller Alanna_LOOT_535
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ MINION - MAGE
			// [LOOT_537] Leyline Manipulator - COST:4 [ATK:4/HP:5] 
			// - Race: elemental, Set: lootapalooza, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> If you're holding any cards that didn't start in your deck, reduce their Cost by (2).
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("LOOT_537", new Power {
				// TODO [LOOT_537] Leyline Manipulator && Test: Leyline Manipulator_LOOT_537
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------- SPELL - MAGE
			// [LOOT_101] Explosive Runes - COST:3 
			// - Fac: neutral, Set: lootapalooza, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Secret:</b> After your opponent plays a minion, deal $6 damage to it and any excess to their hero. @spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - SECRET = 1
			// - ImmuneToSpellpower = 1
			// --------------------------------------------------------
			cards.Add("LOOT_101", new Power {
				// TODO [LOOT_101] Explosive Runes && Test: Explosive Runes_LOOT_101
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------- SPELL - MAGE
			// [LOOT_103] Lesser Ruby Spellstone - COST:2 
			// - Set: lootapalooza, Rarity: rare
			// --------------------------------------------------------
			// Text: Add 1 random Mage spell to your hand. @<i>(Play 2 Elementals to_upgrade.)</i>
			// --------------------------------------------------------
			// GameTag:
			// - TAG_SCRIPT_DATA_NUM_2 = 2
			// --------------------------------------------------------
			cards.Add("LOOT_103", new Power {
				// TODO [LOOT_103] Lesser Ruby Spellstone && Test: Lesser Ruby Spellstone_LOOT_103
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------- SPELL - MAGE
			// [LOOT_104] Shifting Scroll - COST:0 
			// - Set: lootapalooza, Rarity: common
			// --------------------------------------------------------
			// Text: Each turn this is in your hand, transform it into a random Mage spell.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_CANNOT_PLAY_THIS = 0
			// --------------------------------------------------------
			cards.Add("LOOT_104", new Power {
				// TODO [LOOT_104] Shifting Scroll && Test: Shifting Scroll_LOOT_104
				InfoCardId = "LOOT_104e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------- SPELL - MAGE
			// [LOOT_106] Deck of Wonders - COST:5 
			// - Set: lootapalooza, Rarity: epic
			// --------------------------------------------------------
			// Text: Shuffle 5 Scrolls into your deck. When drawn, cast a random spell.
			// --------------------------------------------------------
			cards.Add("LOOT_106", new Power {
				// TODO [LOOT_106] Deck of Wonders && Test: Deck of Wonders_LOOT_106
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------- SPELL - MAGE
			// [LOOT_172] Dragon's Fury - COST:5 
			// - Fac: neutral, Set: lootapalooza, Rarity: epic
			// --------------------------------------------------------
			// Text: Reveal a spell from your deck. Deal damage equal to its Cost to all_minions. @spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - AFFECTED_BY_SPELL_POWER = 1
			// --------------------------------------------------------
			cards.Add("LOOT_172", new Power {
				// TODO [LOOT_172] Dragon's Fury && Test: Dragon's Fury_LOOT_172
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ WEAPON - MAGE
			// [LOOT_108] Aluneth - COST:6 
			// - Set: lootapalooza, Rarity: legendary
			// --------------------------------------------------------
			// Text: At the end of your turn, draw 3 cards.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - DURABILITY = 3
			// - InvisibleDeathrattle = 1
			// --------------------------------------------------------
			cards.Add("LOOT_108", new Power {
				// TODO [LOOT_108] Aluneth && Test: Aluneth_LOOT_108
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void MageNonCollect(IDictionary<string, Power> cards)
		{
			// ------------------------------------- ENCHANTMENT - MAGE
			// [LOOT_104e] Shifting (*) - COST:0 
			// - Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: Transforming into random Mage spells.
			// --------------------------------------------------------
			cards.Add("LOOT_104e", new Power {
				// TODO [LOOT_104e] Shifting && Test: Shifting_LOOT_104e
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ MINION - MAGE
			// [LOOT_535t] Fire Dragon (*) - COST:5 [ATK:5/HP:5] 
			// - Race: dragon, Set: lootapalooza, 
			// --------------------------------------------------------
			cards.Add("LOOT_535t", new Power {
				// TODO [LOOT_535t] Fire Dragon && Test: Fire Dragon_LOOT_535t
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------- SPELL - MAGE
			// [LOOT_103t1] Ruby Spellstone (*) - COST:2 
			// - Set: lootapalooza, Rarity: rare
			// --------------------------------------------------------
			// Text: Add 2 random Mage spells to your hand.
			//       @
			// --------------------------------------------------------
			// GameTag:
			// - TAG_SCRIPT_DATA_NUM_2 = 2
			// --------------------------------------------------------
			cards.Add("LOOT_103t1", new Power {
				// TODO [LOOT_103t1] Ruby Spellstone && Test: Ruby Spellstone_LOOT_103t1
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------- SPELL - MAGE
			// [LOOT_103t2] Greater Ruby Spellstone (*) - COST:2 
			// - Set: lootapalooza, Rarity: rare
			// --------------------------------------------------------
			// Text: Add 3 random Mage spells to your hand.
			// --------------------------------------------------------
			cards.Add("LOOT_103t2", new Power {
				// TODO [LOOT_103t2] Greater Ruby Spellstone && Test: Greater Ruby Spellstone_LOOT_103t2
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------- SPELL - MAGE
			// [LOOT_106t] Scroll of Wonder (*) - COST:5 
			// - Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: Cast a random spell. Draw a card.
			//       Cast this when drawn.
			// --------------------------------------------------------
			// GameTag:
			// - TOPDECK = 1
			// --------------------------------------------------------
			cards.Add("LOOT_106t", new Power {
				// TODO [LOOT_106t] Scroll of Wonder && Test: Scroll of Wonder_LOOT_106t
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void Paladin(IDictionary<string, Power> cards)
		{
			// --------------------------------------- MINION - PALADIN
			// [LOOT_216] Lynessa Sunsorrow - COST:7 [ATK:1/HP:1] 
			// - Set: lootapalooza, Rarity: legendary
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> Cast each spell
			//       you cast on your minions
			//        this game on this one.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("LOOT_216", new Power {
				// TODO [LOOT_216] Lynessa Sunsorrow && Test: Lynessa Sunsorrow_LOOT_216
				InfoCardId = "LOOT_216e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - PALADIN
			// [LOOT_313] Crystal Lion - COST:6 [ATK:5/HP:5] 
			// - Set: lootapalooza, Rarity: rare
			// --------------------------------------------------------
			// Text: [x]<b>Divine Shield</b>
			//       Costs (1) less for each Silver
			//       Hand Recruit you control.
			// --------------------------------------------------------
			// GameTag:
			// - DIVINE_SHIELD = 1
			// --------------------------------------------------------
			cards.Add("LOOT_313", new Power {
				// TODO [LOOT_313] Crystal Lion && Test: Crystal Lion_LOOT_313
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - PALADIN
			// [LOOT_363] Drygulch Jailor - COST:2 [ATK:1/HP:1] 
			// - Set: lootapalooza, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Add 3 Silver_Hand Recruits to_your_hand.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("LOOT_363", new Power {
				// TODO [LOOT_363] Drygulch Jailor && Test: Drygulch Jailor_LOOT_363
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - PALADIN
			// [LOOT_398] Benevolent Djinn - COST:3 [ATK:2/HP:4] 
			// - Race: elemental, Set: lootapalooza, Rarity: common
			// --------------------------------------------------------
			// Text: At the end of your turn, restore 3 Health to your_hero.
			// --------------------------------------------------------
			cards.Add("LOOT_398", new Power {
				// TODO [LOOT_398] Benevolent Djinn && Test: Benevolent Djinn_LOOT_398
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - PALADIN
			// [LOOT_088] Potion of Heroism - COST:2 
			// - Fac: neutral, Set: lootapalooza, Rarity: common
			// --------------------------------------------------------
			// Text: Give a minion <b>Divine_Shield</b>.
			//       Draw a card.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			// RefTag:
			// - DIVINE_SHIELD = 1
			// --------------------------------------------------------
			cards.Add("LOOT_088", new Power {
				// TODO [LOOT_088] Potion of Heroism && Test: Potion of Heroism_LOOT_088
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - PALADIN
			// [LOOT_091] Lesser Pearl Spellstone - COST:2 
			// - Set: lootapalooza, Rarity: rare
			// --------------------------------------------------------
			// Text: Summon a 2/2 Spirit with <b>Taunt</b>. @<i>(Restore 3 Health to upgrade.)</i>
			// --------------------------------------------------------
			// GameTag:
			// - TAG_SCRIPT_DATA_NUM_2 = 3
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			// RefTag:
			// - HEALTH = 1
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("LOOT_091", new Power {
				// TODO [LOOT_091] Lesser Pearl Spellstone && Test: Lesser Pearl Spellstone_LOOT_091
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - PALADIN
			// [LOOT_093] Call to Arms - COST:4 
			// - Set: lootapalooza, Rarity: epic
			// --------------------------------------------------------
			// Text: [x]<b>Recruit</b> 3 minions that
			//        cost (2) or less.
			// --------------------------------------------------------
			// RefTag:
			// - RECRUIT = 1
			// --------------------------------------------------------
			cards.Add("LOOT_093", new Power {
				// TODO [LOOT_093] Call to Arms && Test: Call to Arms_LOOT_093
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - PALADIN
			// [LOOT_333] Level Up! - COST:5 
			// - Set: lootapalooza, Rarity: epic
			// --------------------------------------------------------
			// Text: Give your Silver Hand Recruits +2/+2 and_<b>Taunt</b>.
			// --------------------------------------------------------
			// GameTag:
			// - 717 = 1
			// --------------------------------------------------------
			// RefTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("LOOT_333", new Power {
				// TODO [LOOT_333] Level Up! && Test: Level Up!_LOOT_333
				InfoCardId = "LOOT_333e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- WEAPON - PALADIN
			// [LOOT_286] Unidentified Maul - COST:3 [ATK:2/HP:0] 
			// - Set: lootapalooza, Rarity: rare
			// --------------------------------------------------------
			// Text: Gains a bonus effect in_your hand.
			// --------------------------------------------------------
			// Entourage: LOOT_286t2, LOOT_286t3, LOOT_286t1, LOOT_286t4
			// --------------------------------------------------------
			// GameTag:
			// - DURABILITY = 2
			// --------------------------------------------------------
			cards.Add("LOOT_286", new Power {
				// TODO [LOOT_286] Unidentified Maul && Test: Unidentified Maul_LOOT_286
				InfoCardId = "LOOT_286t3e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- WEAPON - PALADIN
			// [LOOT_500] Val'anyr - COST:6 [ATK:4/HP:0] 
			// - Set: lootapalooza, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Give a minion in your hand +4/+2. When it dies, reequip this.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - DURABILITY = 2
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("LOOT_500", new Power {
				// TODO [LOOT_500] Val'anyr && Test: Val'anyr_LOOT_500
				InfoCardId = "LOOT_500e",
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void PaladinNonCollect(IDictionary<string, Power> cards)
		{
			// --------------------------------------- MINION - PALADIN
			// [LOOT_091t] Guardian Spirit (*) - COST:2 [ATK:2/HP:2] 
			// - Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("LOOT_091t", new Power {
				// TODO [LOOT_091t] Guardian Spirit && Test: Guardian Spirit_LOOT_091t
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - PALADIN
			// [LOOT_091t1t] Guardian Spirit (*) - COST:4 [ATK:4/HP:4] 
			// - Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("LOOT_091t1t", new Power {
				// TODO [LOOT_091t1t] Guardian Spirit && Test: Guardian Spirit_LOOT_091t1t
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - PALADIN
			// [LOOT_091t2t] Guardian Spirit (*) - COST:6 [ATK:6/HP:6] 
			// - Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("LOOT_091t2t", new Power {
				// TODO [LOOT_091t2t] Guardian Spirit && Test: Guardian Spirit_LOOT_091t2t
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - PALADIN
			// [LOOT_091t1] Pearl Spellstone (*) - COST:2 
			// - Set: lootapalooza, Rarity: rare
			// --------------------------------------------------------
			// Text: Summon a 4/4 Spirit with <b>Taunt</b>. @
			// --------------------------------------------------------
			// GameTag:
			// - TAG_SCRIPT_DATA_NUM_2 = 3
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			// RefTag:
			// - HEALTH = 1
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("LOOT_091t1", new Power {
				// TODO [LOOT_091t1] Pearl Spellstone && Test: Pearl Spellstone_LOOT_091t1
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - PALADIN
			// [LOOT_091t2] Greater Pearl Spellstone (*) - COST:2 
			// - Set: lootapalooza, Rarity: rare
			// --------------------------------------------------------
			// Text: Summon a 6/6 Spirit with <b>Taunt</b>.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			// RefTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("LOOT_091t2", new Power {
				// TODO [LOOT_091t2] Greater Pearl Spellstone && Test: Greater Pearl Spellstone_LOOT_091t2
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- WEAPON - PALADIN
			// [LOOT_286t1] Champion's Maul (*) - COST:3 [ATK:2/HP:0] 
			// - Set: lootapalooza, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Summon two 1/1 Silver Hand Recruits.
			// --------------------------------------------------------
			// GameTag:
			// - DURABILITY = 2
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("LOOT_286t1", new Power {
				// TODO [LOOT_286t1] Champion's Maul && Test: Champion's Maul_LOOT_286t1
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- WEAPON - PALADIN
			// [LOOT_286t2] Sacred Maul (*) - COST:3 [ATK:2/HP:0] 
			// - Set: lootapalooza, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Give your minions <b>Taunt</b>.
			// --------------------------------------------------------
			// GameTag:
			// - DURABILITY = 2
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("LOOT_286t2", new Power {
				// TODO [LOOT_286t2] Sacred Maul && Test: Sacred Maul_LOOT_286t2
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- WEAPON - PALADIN
			// [LOOT_286t3] Blessed Maul (*) - COST:3 [ATK:2/HP:0] 
			// - Set: lootapalooza, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Give your minions +1 Attack.
			// --------------------------------------------------------
			// GameTag:
			// - DURABILITY = 2
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("LOOT_286t3", new Power {
				// TODO [LOOT_286t3] Blessed Maul && Test: Blessed Maul_LOOT_286t3
				InfoCardId = "LOOT_286t3e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- WEAPON - PALADIN
			// [LOOT_286t4] Purifier's Maul (*) - COST:3 [ATK:2/HP:0] 
			// - Set: lootapalooza, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Give your minions <b>Divine Shield</b>.
			// --------------------------------------------------------
			// GameTag:
			// - DURABILITY = 2
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("LOOT_286t4", new Power {
				// TODO [LOOT_286t4] Purifier's Maul && Test: Purifier's Maul_LOOT_286t4
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- WEAPON - PALADIN
			// [LOOT_500d] Val'anyr Reequip Effect Dummy (*) - COST:0 
			// - Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: It is a dummy card for holding a effect to play when reequipping Val'anyr (LOOT_500)
			// --------------------------------------------------------
			cards.Add("LOOT_500d", new Power {
				// TODO [LOOT_500d] Val'anyr Reequip Effect Dummy && Test: Val'anyr Reequip Effect Dummy_LOOT_500d
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void Priest(IDictionary<string, Power> cards)
		{
			// ---------------------------------------- MINION - PRIEST
			// [LOOT_410] Duskbreaker - COST:4 [ATK:3/HP:3] 
			// - Race: dragon, Set: lootapalooza, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> If you're holding
			//       a Dragon, deal 3 damage to all other minions.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_ENEMY_TARGET = 0
			// --------------------------------------------------------
			cards.Add("LOOT_410", new Power {
				// TODO [LOOT_410] Duskbreaker && Test: Duskbreaker_LOOT_410
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- MINION - PRIEST
			// [LOOT_528] Twilight Acolyte - COST:3 [ATK:2/HP:4] 
			// - Set: lootapalooza, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> If you're holding
			//       a Dragon, swap this minion's Attack with another minion's.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_IF_AVAILABLE_AND_DRAGON_IN_HAND = 0
			// --------------------------------------------------------
			cards.Add("LOOT_528", new Power {
				// TODO [LOOT_528] Twilight Acolyte && Test: Twilight Acolyte_LOOT_528
				InfoCardId = "LOOT_528e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- MINION - PRIEST
			// [LOOT_534] Gilded Gargoyle - COST:3 [ATK:2/HP:2] 
			// - Set: lootapalooza, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Add a Coin to your hand.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("LOOT_534", new Power {
				// TODO [LOOT_534] Gilded Gargoyle && Test: Gilded Gargoyle_LOOT_534
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- MINION - PRIEST
			// [LOOT_538] Temporus - COST:7 [ATK:6/HP:6] 
			// - Race: dragon, Set: lootapalooza, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Your opponent takes two turns. Then you take two turns.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("LOOT_538", new Power {
				// TODO [LOOT_538] Temporus && Test: Temporus_LOOT_538
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- SPELL - PRIEST
			// [LOOT_008] Psychic Scream - COST:7 
			// - Set: lootapalooza, Rarity: epic
			// --------------------------------------------------------
			// Text: Shuffle all minions into your opponent's deck.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_ENEMY_TARGET = 0
			// --------------------------------------------------------
			cards.Add("LOOT_008", new Power {
				// TODO [LOOT_008] Psychic Scream && Test: Psychic Scream_LOOT_008
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- SPELL - PRIEST
			// [LOOT_187] Twilight's Call - COST:3 
			// - Fac: neutral, Set: lootapalooza, Rarity: rare
			// --------------------------------------------------------
			// Text: Summon 1/1 copies of 2 friendly <b>Deathrattle</b> minions
			//       that died this game.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_FRIENDLY_MINION_DIED_THIS_GAME = 0
			// --------------------------------------------------------
			// RefTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("LOOT_187", new Power {
				// TODO [LOOT_187] Twilight's Call && Test: Twilight's Call_LOOT_187
				InfoCardId = "LOOT_187e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- SPELL - PRIEST
			// [LOOT_278] Unidentified Elixir - COST:3 
			// - Set: lootapalooza, Rarity: common
			// --------------------------------------------------------
			// Text: Give a minion +2/+2. Gains a bonus effect in_your hand.
			// --------------------------------------------------------
			// Entourage: LOOT_278t1, LOOT_278t2, LOOT_278t3, LOOT_278t4
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("LOOT_278", new Power {
				// TODO [LOOT_278] Unidentified Elixir && Test: Unidentified Elixir_LOOT_278
				InfoCardId = "LOOT_278e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- SPELL - PRIEST
			// [LOOT_353] Psionic Probe - COST:1 
			// - Set: lootapalooza, Rarity: common
			// --------------------------------------------------------
			// Text: Copy a spell in your opponent's deck and add it to your hand.
			// --------------------------------------------------------
			cards.Add("LOOT_353", new Power {
				// TODO [LOOT_353] Psionic Probe && Test: Psionic Probe_LOOT_353
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- SPELL - PRIEST
			// [LOOT_507] Lesser Diamond Spellstone - COST:7 
			// - Set: lootapalooza, Rarity: rare
			// --------------------------------------------------------
			// Text: Resurrect 2 different friendly minions. @<i>(Cast 4 spells to upgrade.)</i>
			// --------------------------------------------------------
			// GameTag:
			// - TAG_SCRIPT_DATA_NUM_2 = 4
			// --------------------------------------------------------
			cards.Add("LOOT_507", new Power {
				// TODO [LOOT_507] Lesser Diamond Spellstone && Test: Lesser Diamond Spellstone_LOOT_507
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- WEAPON - PRIEST
			// [LOOT_209] Dragon Soul - COST:3 
			// - Set: lootapalooza, Rarity: legendary
			// --------------------------------------------------------
			// Text: After you cast 3 spells in a turn, summon a 5/5 Dragon.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - DURABILITY = 3
			// --------------------------------------------------------
			cards.Add("LOOT_209", new Power {
				// TODO [LOOT_209] Dragon Soul && Test: Dragon Soul_LOOT_209
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void PriestNonCollect(IDictionary<string, Power> cards)
		{
			// ---------------------------------------- MINION - PRIEST
			// [LOOT_209t] Dragon Spirit (*) - COST:5 [ATK:5/HP:5] 
			// - Race: dragon, Set: lootapalooza, 
			// --------------------------------------------------------
			cards.Add("LOOT_209t", new Power {
				// TODO [LOOT_209t] Dragon Spirit && Test: Dragon Spirit_LOOT_209t
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- SPELL - PRIEST
			// [LOOT_278t1] Elixir of Life (*) - COST:3 
			// - Set: lootapalooza, Rarity: common
			// --------------------------------------------------------
			// Text: Give a minion +2/+2 and <b>Lifesteal</b>.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("LOOT_278t1", new Power {
				// TODO [LOOT_278t1] Elixir of Life && Test: Elixir of Life_LOOT_278t1
				InfoCardId = "LOOT_278t1e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- SPELL - PRIEST
			// [LOOT_278t2] Elixir of Purity (*) - COST:3 
			// - Set: lootapalooza, Rarity: common
			// --------------------------------------------------------
			// Text: Give a minion +2/+2 and <b>Divine Shield</b>.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("LOOT_278t2", new Power {
				// TODO [LOOT_278t2] Elixir of Purity && Test: Elixir of Purity_LOOT_278t2
				InfoCardId = "LOOT_278t2e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- SPELL - PRIEST
			// [LOOT_278t3] Elixir of Shadows (*) - COST:3 
			// - Set: lootapalooza, Rarity: common
			// --------------------------------------------------------
			// Text: Give a minion +2/+2. Summon a 1/1 copy of_it.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("LOOT_278t3", new Power {
				// TODO [LOOT_278t3] Elixir of Shadows && Test: Elixir of Shadows_LOOT_278t3
				InfoCardId = "LOOT_278t3e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- SPELL - PRIEST
			// [LOOT_278t4] Elixir of Hope (*) - COST:3 
			// - Set: lootapalooza, Rarity: common
			// --------------------------------------------------------
			// Text: [x]Give a minion +2/+2
			//       and "<b>Deathrattle:</b> Return
			//       this minion to your hand."
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("LOOT_278t4", new Power {
				// TODO [LOOT_278t4] Elixir of Hope && Test: Elixir of Hope_LOOT_278t4
				InfoCardId = "LOOT_278t4e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- SPELL - PRIEST
			// [LOOT_507t] Diamond Spellstone (*) - COST:7 
			// - Set: lootapalooza, Rarity: rare
			// --------------------------------------------------------
			// Text: Resurrect 3 different friendly minions. @
			// --------------------------------------------------------
			// GameTag:
			// - TAG_SCRIPT_DATA_NUM_2 = 4
			// --------------------------------------------------------
			cards.Add("LOOT_507t", new Power {
				// TODO [LOOT_507t] Diamond Spellstone && Test: Diamond Spellstone_LOOT_507t
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- SPELL - PRIEST
			// [LOOT_507t2] Greater Diamond Spellstone (*) - COST:7 
			// - Set: lootapalooza, Rarity: rare
			// --------------------------------------------------------
			// Text: Resurrect 4 different friendly minions.
			// --------------------------------------------------------
			cards.Add("LOOT_507t2", new Power {
				// TODO [LOOT_507t2] Greater Diamond Spellstone && Test: Greater Diamond Spellstone_LOOT_507t2
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void Rogue(IDictionary<string, Power> cards)
		{
			// ----------------------------------------- MINION - ROGUE
			// [LOOT_026] Fal'dorei Strider - COST:4 [ATK:4/HP:4] 
			// - Set: lootapalooza, Rarity: epic
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> Shuffle 3
			//       Ambushes into your deck.
			//       When drawn, summon
			//       a 4/4 Spider.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("LOOT_026", new Power {
				// TODO [LOOT_026] Fal'dorei Strider && Test: Fal'dorei Strider_LOOT_026
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- MINION - ROGUE
			// [LOOT_033] Cavern Shinyfinder - COST:2 [ATK:3/HP:1] 
			// - Set: lootapalooza, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Draw a weapon from your deck.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("LOOT_033", new Power {
				// TODO [LOOT_033] Cavern Shinyfinder && Test: Cavern Shinyfinder_LOOT_033
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- MINION - ROGUE
			// [LOOT_165] Sonya Shadowdancer - COST:3 [ATK:2/HP:2] 
			// - Set: lootapalooza, Rarity: legendary
			// --------------------------------------------------------
			// Text: After a friendly minion dies, add a 1/1 copy of it to your hand. It costs (1).
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("LOOT_165", new Power {
				// TODO [LOOT_165] Sonya Shadowdancer && Test: Sonya Shadowdancer_LOOT_165
				InfoCardId = "LOOT_165e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- MINION - ROGUE
			// [LOOT_211] Elven Minstrel - COST:4 [ATK:3/HP:2] 
			// - Set: lootapalooza, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Combo:</b> Draw 2 minions from your deck.
			// --------------------------------------------------------
			// GameTag:
			// - COMBO = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_FRIENDLY_TARGET = 0
			// --------------------------------------------------------
			cards.Add("LOOT_211", new Power {
				// TODO [LOOT_211] Elven Minstrel && Test: Elven Minstrel_LOOT_211
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- MINION - ROGUE
			// [LOOT_412] Kobold Illusionist - COST:4 [ATK:3/HP:3] 
			// - Fac: alliance, Set: lootapalooza, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Summon a 1/1 copy of a minion from your hand.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("LOOT_412", new Power {
				// TODO [LOOT_412] Kobold Illusionist && Test: Kobold Illusionist_LOOT_412
				InfoCardId = "LOOT_412e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ SPELL - ROGUE
			// [LOOT_204] Cheat Death - COST:2 
			// - Set: lootapalooza, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Secret:</b> When a friendly minion dies, return it to your hand.
			//       It costs (2) less.
			// --------------------------------------------------------
			// GameTag:
			// - SECRET = 1
			// --------------------------------------------------------
			cards.Add("LOOT_204", new Power {
				// TODO [LOOT_204] Cheat Death && Test: Cheat Death_LOOT_204
				InfoCardId = "LOOT_204e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ SPELL - ROGUE
			// [LOOT_210] Sudden Betrayal - COST:2 
			// - Set: lootapalooza, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Secret:</b> When a minion attacks your hero, instead it attacks one of_its neighbors.
			// --------------------------------------------------------
			// GameTag:
			// - SECRET = 1
			// --------------------------------------------------------
			cards.Add("LOOT_210", new Power {
				// TODO [LOOT_210] Sudden Betrayal && Test: Sudden Betrayal_LOOT_210
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ SPELL - ROGUE
			// [LOOT_214] Evasion - COST:2 
			// - Set: lootapalooza, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Secret:</b> After your hero takes damage, become <b>Immune</b> this turn.
			// --------------------------------------------------------
			// GameTag:
			// - SECRET = 1
			// --------------------------------------------------------
			cards.Add("LOOT_214", new Power {
				// TODO [LOOT_214] Evasion && Test: Evasion_LOOT_214
				InfoCardId = "LOOT_214e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ SPELL - ROGUE
			// [LOOT_503] Lesser Onyx Spellstone - COST:5 
			// - Set: lootapalooza, Rarity: rare
			// --------------------------------------------------------
			// Text: Destroy 1 random enemy minion.
			//       @<i>(Play 3 <b>Deathrattle</b> cards to upgrade.)</i>
			// --------------------------------------------------------
			// GameTag:
			// - TAG_SCRIPT_DATA_NUM_2 = 3
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINIMUM_ENEMY_MINIONS = 1
			// --------------------------------------------------------
			// RefTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("LOOT_503", new Power {
				// TODO [LOOT_503] Lesser Onyx Spellstone && Test: Lesser Onyx Spellstone_LOOT_503
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- WEAPON - ROGUE
			// [LOOT_542] Kingsbane - COST:1 [ATK:1/HP:3] 
			// - Set: lootapalooza, Rarity: legendary
			// --------------------------------------------------------
			// Text: [x]<b>Deathrattle:</b> Shuffle
			//       this into your deck.
			//       It keeps any
			//       enchantments.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - DURABILITY = 3
			// - DEATHRATTLE = 1
			// - KEEP_ENCHANTMENTS = 1
			// --------------------------------------------------------
			cards.Add("LOOT_542", new Power {
				// TODO [LOOT_542] Kingsbane && Test: Kingsbane_LOOT_542
				InfoCardId = "LOOT_542e",
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void RogueNonCollect(IDictionary<string, Power> cards)
		{
			// ------------------------------------ ENCHANTMENT - ROGUE
			// [LOOT_542e] Kingsbane Shuffle (*) - COST:0 
			// - Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: Getting ready to shuffle in.
			// --------------------------------------------------------
			cards.Add("LOOT_542e", new Power {
				// TODO [LOOT_542e] Kingsbane Shuffle && Test: Kingsbane Shuffle_LOOT_542e
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- MINION - ROGUE
			// [LOOT_026t] Leyline Spider (*) - COST:4 [ATK:4/HP:4] 
			// - Race: beast, Set: lootapalooza, 
			// --------------------------------------------------------
			cards.Add("LOOT_026t", new Power {
				// TODO [LOOT_026t] Leyline Spider && Test: Leyline Spider_LOOT_026t
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ SPELL - ROGUE
			// [LOOT_026e] Spider Ambush! (*) - COST:4 
			// - Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: Summon a 4/4 Spider. Draw a card.
			//       Cast this when drawn.
			// --------------------------------------------------------
			// GameTag:
			// - TOPDECK = 1
			// --------------------------------------------------------
			cards.Add("LOOT_026e", new Power {
				// TODO [LOOT_026e] Spider Ambush! && Test: Spider Ambush!_LOOT_026e
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ SPELL - ROGUE
			// [LOOT_503t] Onyx Spellstone (*) - COST:5 
			// - Set: lootapalooza, Rarity: rare
			// --------------------------------------------------------
			// Text: Destroy up to 2 random enemy minions.
			//       @
			// --------------------------------------------------------
			// GameTag:
			// - TAG_SCRIPT_DATA_NUM_2 = 3
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINIMUM_ENEMY_MINIONS = 1
			// --------------------------------------------------------
			// RefTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("LOOT_503t", new Power {
				// TODO [LOOT_503t] Onyx Spellstone && Test: Onyx Spellstone_LOOT_503t
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ SPELL - ROGUE
			// [LOOT_503t2] Greater Onyx Spellstone (*) - COST:5 
			// - Set: lootapalooza, Rarity: rare
			// --------------------------------------------------------
			// Text: Destroy up to 3 random enemy minions.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINIMUM_ENEMY_MINIONS = 1
			// --------------------------------------------------------
			cards.Add("LOOT_503t2", new Power {
				// TODO [LOOT_503t2] Greater Onyx Spellstone && Test: Greater Onyx Spellstone_LOOT_503t2
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void Shaman(IDictionary<string, Power> cards)
		{
			// ---------------------------------------- MINION - SHAMAN
			// [LOOT_062] Kobold Hermit - COST:2 [ATK:1/HP:1] 
			// - Set: lootapalooza, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Choose a basic Totem. Summon it.
			// --------------------------------------------------------
			// Entourage: CS2_052, CS2_050, NEW1_009, CS2_051
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("LOOT_062", new Power {
				// TODO [LOOT_062] Kobold Hermit && Test: Kobold Hermit_LOOT_062
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- MINION - SHAMAN
			// [LOOT_358] Grumble, Worldshaker - COST:6 [ATK:7/HP:7] 
			// - Race: elemental, Set: lootapalooza, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Return your other minions to your hand. They cost (1).
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("LOOT_358", new Power {
				// TODO [LOOT_358] Grumble, Worldshaker && Test: Grumble, Worldshaker_LOOT_358
				InfoCardId = "LOOT_358e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- MINION - SHAMAN
			// [LOOT_517] Murmuring Elemental - COST:2 [ATK:1/HP:1] 
			// - Race: elemental, Set: lootapalooza, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Your next <b>Battlecry</b> this turn triggers_twice.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("LOOT_517", new Power {
				// TODO [LOOT_517] Murmuring Elemental && Test: Murmuring Elemental_LOOT_517
				InfoCardId = "LOOT_517e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- MINION - SHAMAN
			// [LOOT_518] Windshear Stormcaller - COST:5 [ATK:5/HP:5] 
			// - Set: lootapalooza, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> If you control all 4 basic Totems, summon Al'Akir_the_Windlord.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("LOOT_518", new Power {
				// TODO [LOOT_518] Windshear Stormcaller && Test: Windshear Stormcaller_LOOT_518
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- SPELL - SHAMAN
			// [LOOT_060] Crushing Hand - COST:2 
			// - Fac: neutral, Set: lootapalooza, Rarity: common
			// --------------------------------------------------------
			// Text: Deal $8 damage to a minion. <b><b>Overload</b>:</b> (3) @spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - OVERLOAD = 3
			// - OVERLOAD_OWED = 3
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("LOOT_060", new Power {
				// TODO [LOOT_060] Crushing Hand && Test: Crushing Hand_LOOT_060
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- SPELL - SHAMAN
			// [LOOT_064] Lesser Sapphire Spellstone - COST:7 
			// - Set: lootapalooza, Rarity: rare
			// --------------------------------------------------------
			// Text: Summon 1 copy of a friendly minion. @<i>(<b>Overload</b> 3 Mana Crystals to upgrade.)</i>
			// --------------------------------------------------------
			// GameTag:
			// - TAG_SCRIPT_DATA_NUM_2 = 3
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_FRIENDLY_TARGET = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			// RefTag:
			// - OVERLOAD = 1
			// --------------------------------------------------------
			cards.Add("LOOT_064", new Power {
				// TODO [LOOT_064] Lesser Sapphire Spellstone && Test: Lesser Sapphire Spellstone_LOOT_064
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- SPELL - SHAMAN
			// [LOOT_344] Primal Talismans - COST:3 
			// - Set: lootapalooza, Rarity: rare
			// --------------------------------------------------------
			// Text: Give your minions "<b>Deathrattle:</b> Summon a random basic Totem."
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			// RefTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("LOOT_344", new Power {
				// TODO [LOOT_344] Primal Talismans && Test: Primal Talismans_LOOT_344
				InfoCardId = "LOOT_344e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- SPELL - SHAMAN
			// [LOOT_373] Healing Rain - COST:3 
			// - Set: lootapalooza, Rarity: common
			// --------------------------------------------------------
			// Text: Restore #12 Health randomly split among all friendly characters.
			// --------------------------------------------------------
			// GameTag:
			// - ImmuneToSpellpower = 1
			// --------------------------------------------------------
			cards.Add("LOOT_373", new Power {
				// TODO [LOOT_373] Healing Rain && Test: Healing Rain_LOOT_373
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- SPELL - SHAMAN
			// [LOOT_504] Unstable Evolution - COST:1 
			// - Set: lootapalooza, Rarity: epic
			// --------------------------------------------------------
			// Text: Transform a friendly minion into
			//       one that costs (1) more. Repeatable this turn.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// - REQ_FRIENDLY_TARGET = 0
			// --------------------------------------------------------
			cards.Add("LOOT_504", new Power {
				// TODO [LOOT_504] Unstable Evolution && Test: Unstable Evolution_LOOT_504
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- WEAPON - SHAMAN
			// [LOOT_506] The Runespear - COST:8 [ATK:3/HP:0] 
			// - Set: lootapalooza, Rarity: legendary
			// --------------------------------------------------------
			// Text: After your hero attacks, <b>Discover</b> a spell
			//       and cast it with random targets.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - DURABILITY = 3
			// --------------------------------------------------------
			// RefTag:
			// - DISCOVER = 1
			// --------------------------------------------------------
			cards.Add("LOOT_506", new Power {
				// TODO [LOOT_506] The Runespear && Test: The Runespear_LOOT_506
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void ShamanNonCollect(IDictionary<string, Power> cards)
		{
			// ----------------------------------- ENCHANTMENT - SHAMAN
			// [LOOT_344e] Primal Talisman (*) - COST:0 
			// - Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Summon a random basic Totem.
			// --------------------------------------------------------
			cards.Add("LOOT_344e", new Power {
				// TODO [LOOT_344e] Primal Talisman && Test: Primal Talisman_LOOT_344e
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- SPELL - SHAMAN
			// [LOOT_064t1] Sapphire Spellstone (*) - COST:7 
			// - Set: lootapalooza, Rarity: rare
			// --------------------------------------------------------
			// Text: Summon 2 copies of a friendly minion. @
			// --------------------------------------------------------
			// GameTag:
			// - TAG_SCRIPT_DATA_NUM_2 = 3
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_FRIENDLY_TARGET = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			// RefTag:
			// - OVERLOAD = 1
			// --------------------------------------------------------
			cards.Add("LOOT_064t1", new Power {
				// TODO [LOOT_064t1] Sapphire Spellstone && Test: Sapphire Spellstone_LOOT_064t1
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- SPELL - SHAMAN
			// [LOOT_064t2] Greater Sapphire Spellstone (*) - COST:7 
			// - Set: lootapalooza, Rarity: rare
			// --------------------------------------------------------
			// Text: Summon 3 copies of a friendly minion.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// - REQ_FRIENDLY_TARGET = 0
			// --------------------------------------------------------
			cards.Add("LOOT_064t2", new Power {
				// TODO [LOOT_064t2] Greater Sapphire Spellstone && Test: Greater Sapphire Spellstone_LOOT_064t2
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- SPELL - SHAMAN
			// [LOOT_504t] Unstable Evolution (*) - COST:1 
			// - Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: Transform a friendly minion into
			//       one that costs (1) more. Repeatable this turn.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// - REQ_FRIENDLY_TARGET = 0
			// --------------------------------------------------------
			cards.Add("LOOT_504t", new Power {
				// TODO [LOOT_504t] Unstable Evolution && Test: Unstable Evolution_LOOT_504t
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void Warlock(IDictionary<string, Power> cards)
		{
			// --------------------------------------- MINION - WARLOCK
			// [LOOT_013] Vulgar Homunculus - COST:2 [ATK:2/HP:4] 
			// - Race: demon, Fac: neutral, Set: lootapalooza, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			//       <b>Battlecry:</b> Deal 2 damage to your hero.
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("LOOT_013", new Power {
				// TODO [LOOT_013] Vulgar Homunculus && Test: Vulgar Homunculus_LOOT_013
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - WARLOCK
			// [LOOT_014] Kobold Librarian - COST:1 [ATK:2/HP:1] 
			// - Fac: neutral, Set: lootapalooza, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Draw a card. Deal 2 damage to your_hero.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("LOOT_014", new Power {
				// TODO [LOOT_014] Kobold Librarian && Test: Kobold Librarian_LOOT_014
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - WARLOCK
			// [LOOT_018] Hooked Reaver - COST:4 [ATK:4/HP:4] 
			// - Race: demon, Set: lootapalooza, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> If you have 15 or_less Health, gain +3/+3_and <b>Taunt</b>.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("LOOT_018", new Power {
				// TODO [LOOT_018] Hooked Reaver && Test: Hooked Reaver_LOOT_018
				InfoCardId = "LOOT_018e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - WARLOCK
			// [LOOT_306] Possessed Lackey - COST:5 [ATK:2/HP:2] 
			// - Set: lootapalooza, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> <b>Recruit</b> a_Demon.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			// RefTag:
			// - RECRUIT = 1
			// --------------------------------------------------------
			cards.Add("LOOT_306", new Power {
				// TODO [LOOT_306] Possessed Lackey && Test: Possessed Lackey_LOOT_306
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - WARLOCK
			// [LOOT_368] Voidlord - COST:9 [ATK:3/HP:9] 
			// - Race: demon, Set: lootapalooza, Rarity: epic
			// --------------------------------------------------------
			// Text: [x]<b>Taunt</b>
			//        <b>Deathrattle:</b> Summon three
			//       1/3 Demons with <b>Taunt</b>.
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("LOOT_368", new Power {
				// TODO [LOOT_368] Voidlord && Test: Voidlord_LOOT_368
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - WARLOCK
			// [LOOT_415] Rin, the First Disciple - COST:6 [ATK:3/HP:6] 
			// - Set: lootapalooza, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			//       <b>Deathrattle:</b> Add 'The First Seal' to your hand.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - TAUNT = 1
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("LOOT_415", new Power {
				// TODO [LOOT_415] Rin, the First Disciple && Test: Rin, the First Disciple_LOOT_415
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - WARLOCK
			// [LOOT_017] Dark Pact - COST:1 
			// - Fac: alliance, Set: lootapalooza, Rarity: common
			// --------------------------------------------------------
			// Text: Destroy a friendly minion. Restore #8 Health to your hero.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_FRIENDLY_TARGET = 0
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("LOOT_017", new Power {
				// TODO [LOOT_017] Dark Pact && Test: Dark Pact_LOOT_017
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - WARLOCK
			// [LOOT_043] Lesser Amethyst Spellstone - COST:4 
			// - Set: lootapalooza, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Lifesteal.</b> Deal $3 damage to a minion. <i>(Take damage from your cards to upgrade.)</i> @spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - LIFESTEAL = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("LOOT_043", new Power {
				// TODO [LOOT_043] Lesser Amethyst Spellstone && Test: Lesser Amethyst Spellstone_LOOT_043
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - WARLOCK
			// [LOOT_417] Cataclysm - COST:4 
			// - Set: lootapalooza, Rarity: epic
			// --------------------------------------------------------
			// Text: Destroy all minions. Discard your hand.
			// --------------------------------------------------------
			// GameTag:
			// - 890 = 10
			// --------------------------------------------------------
			cards.Add("LOOT_417", new Power {
				// TODO [LOOT_417] Cataclysm && Test: Cataclysm_LOOT_417
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- WEAPON - WARLOCK
			// [LOOT_420] Skull of the Man'ari - COST:5 
			// - Set: lootapalooza, Rarity: legendary
			// --------------------------------------------------------
			// Text: At the start of your turn, summon a Demon from your hand.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - DURABILITY = 3
			// - InvisibleDeathrattle = 1
			// --------------------------------------------------------
			cards.Add("LOOT_420", new Power {
				// TODO [LOOT_420] Skull of the Man'ari && Test: Skull of the Man'ari_LOOT_420
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void WarlockNonCollect(IDictionary<string, Power> cards)
		{
			// --------------------------------------- MINION - WARLOCK
			// [LOOT_415t1t] Felhunter (*) - COST:2 [ATK:2/HP:2] 
			// - Race: demon, Set: lootapalooza, 
			// --------------------------------------------------------
			cards.Add("LOOT_415t1t", new Power {
				// TODO [LOOT_415t1t] Felhunter && Test: Felhunter_LOOT_415t1t
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - WARLOCK
			// [LOOT_415t2t] Felhunter (*) - COST:3 [ATK:3/HP:3] 
			// - Race: demon, Set: lootapalooza, 
			// --------------------------------------------------------
			cards.Add("LOOT_415t2t", new Power {
				// TODO [LOOT_415t2t] Felhunter && Test: Felhunter_LOOT_415t2t
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - WARLOCK
			// [LOOT_415t3t] Felhunter (*) - COST:4 [ATK:4/HP:4] 
			// - Race: demon, Set: lootapalooza, 
			// --------------------------------------------------------
			cards.Add("LOOT_415t3t", new Power {
				// TODO [LOOT_415t3t] Felhunter && Test: Felhunter_LOOT_415t3t
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - WARLOCK
			// [LOOT_415t4t] Felhunter (*) - COST:5 [ATK:5/HP:5] 
			// - Race: demon, Set: lootapalooza, 
			// --------------------------------------------------------
			cards.Add("LOOT_415t4t", new Power {
				// TODO [LOOT_415t4t] Felhunter && Test: Felhunter_LOOT_415t4t
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - WARLOCK
			// [LOOT_415t5t] Felhunter (*) - COST:6 [ATK:6/HP:6] 
			// - Race: demon, Set: lootapalooza, 
			// --------------------------------------------------------
			cards.Add("LOOT_415t5t", new Power {
				// TODO [LOOT_415t5t] Felhunter && Test: Felhunter_LOOT_415t5t
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - WARLOCK
			// [LOOT_415t6] Azari, the Devourer (*) - COST:10 [ATK:10/HP:10] 
			// - Race: demon, Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Destroy your opponent's deck.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("LOOT_415t6", new Power {
				// TODO [LOOT_415t6] Azari, the Devourer && Test: Azari, the Devourer_LOOT_415t6
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - WARLOCK
			// [LOOT_043t2] Amethyst Spellstone (*) - COST:4 
			// - Set: lootapalooza, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Lifesteal.</b> Deal $5 damage to a minion. <i>(Take damage from your cards to upgrade.)</i> @spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - LIFESTEAL = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("LOOT_043t2", new Power {
				// TODO [LOOT_043t2] Amethyst Spellstone && Test: Amethyst Spellstone_LOOT_043t2
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - WARLOCK
			// [LOOT_043t3] Greater Amethyst Spellstone (*) - COST:4 
			// - Set: lootapalooza, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Lifesteal.</b> Deal $7 damage to a minion. @spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - LIFESTEAL = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("LOOT_043t3", new Power {
				// TODO [LOOT_043t3] Greater Amethyst Spellstone && Test: Greater Amethyst Spellstone_LOOT_043t3
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - WARLOCK
			// [LOOT_415t1] The First Seal (*) - COST:5 
			// - Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: Summon a 2/2 Demon. Add 'The Second Seal' to your hand.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_NUM_MINION_SLOTS = 1
			// --------------------------------------------------------
			cards.Add("LOOT_415t1", new Power {
				// TODO [LOOT_415t1] The First Seal && Test: The First Seal_LOOT_415t1
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - WARLOCK
			// [LOOT_415t2] The Second Seal (*) - COST:5 
			// - Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: Summon a 3/3 Demon. Add 'The Third Seal'
			//       to your hand.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_NUM_MINION_SLOTS = 1
			// --------------------------------------------------------
			cards.Add("LOOT_415t2", new Power {
				// TODO [LOOT_415t2] The Second Seal && Test: The Second Seal_LOOT_415t2
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - WARLOCK
			// [LOOT_415t3] The Third Seal (*) - COST:5 
			// - Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: Summon a 4/4 Demon. Add 'The Fourth Seal' to your hand.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_NUM_MINION_SLOTS = 1
			// --------------------------------------------------------
			cards.Add("LOOT_415t3", new Power {
				// TODO [LOOT_415t3] The Third Seal && Test: The Third Seal_LOOT_415t3
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - WARLOCK
			// [LOOT_415t4] The Fourth Seal (*) - COST:5 
			// - Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: Summon a 5/5 Demon. Add 'The Final Seal'
			//       to your hand.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_NUM_MINION_SLOTS = 1
			// --------------------------------------------------------
			cards.Add("LOOT_415t4", new Power {
				// TODO [LOOT_415t4] The Fourth Seal && Test: The Fourth Seal_LOOT_415t4
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - WARLOCK
			// [LOOT_415t5] The Final Seal (*) - COST:5 
			// - Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: [x]Summon a 6/6 Demon.
			//       Add 'Azari, the Devourer'
			//       to your hand.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_NUM_MINION_SLOTS = 1
			// --------------------------------------------------------
			cards.Add("LOOT_415t5", new Power {
				// TODO [LOOT_415t5] The Final Seal && Test: The Final Seal_LOOT_415t5
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void Warrior(IDictionary<string, Power> cards)
		{
			// --------------------------------------- MINION - WARRIOR
			// [LOOT_041] Kobold Barbarian - COST:3 [ATK:4/HP:4] 
			// - Set: lootapalooza, Rarity: rare
			// --------------------------------------------------------
			// Text: At the start of your turn, attack a random enemy.
			// --------------------------------------------------------
			cards.Add("LOOT_041", new Power {
				// TODO [LOOT_041] Kobold Barbarian && Test: Kobold Barbarian_LOOT_041
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - WARRIOR
			// [LOOT_365] Gemstudded Golem - COST:6 [ATK:5/HP:9] 
			// - Set: lootapalooza, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			//       Can only attack if you have 5 or more Armor.
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("LOOT_365", new Power {
				// TODO [LOOT_365] Gemstudded Golem && Test: Gemstudded Golem_LOOT_365
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - WARRIOR
			// [LOOT_367] Drywhisker Armorer - COST:2 [ATK:2/HP:2] 
			// - Set: lootapalooza, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> For each enemy minion, gain 2 Armor.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("LOOT_367", new Power {
				// TODO [LOOT_367] Drywhisker Armorer && Test: Drywhisker Armorer_LOOT_367
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - WARRIOR
			// [LOOT_519] Geosculptor Yip - COST:8 [ATK:4/HP:8] 
			// - Set: lootapalooza, Rarity: legendary
			// --------------------------------------------------------
			// Text: At the end of your turn, summon a random minion with_Cost_equal_to_your Armor <i>(up to 10)</i>.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("LOOT_519", new Power {
				// TODO [LOOT_519] Geosculptor Yip && Test: Geosculptor Yip_LOOT_519
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - WARRIOR
			// [LOOT_203] Lesser Mithril Spellstone - COST:7 
			// - Set: lootapalooza, Rarity: rare
			// --------------------------------------------------------
			// Text: Summon one 5/5 Mithril Golem. <i>(Equip a weapon to upgrade.)</i>
			// --------------------------------------------------------
			cards.Add("LOOT_203", new Power {
				// TODO [LOOT_203] Lesser Mithril Spellstone && Test: Lesser Mithril Spellstone_LOOT_203
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - WARRIOR
			// [LOOT_285] Unidentified Shield - COST:6 
			// - Set: lootapalooza, Rarity: common
			// --------------------------------------------------------
			// Text: Gain 5 Armor.
			//       Gains a bonus effect in_your hand.
			// --------------------------------------------------------
			// Entourage: LOOT_285t, LOOT_285t2, LOOT_285t3, LOOT_285t4
			// --------------------------------------------------------
			cards.Add("LOOT_285", new Power {
				// TODO [LOOT_285] Unidentified Shield && Test: Unidentified Shield_LOOT_285
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - WARRIOR
			// [LOOT_364] Reckless Flurry - COST:3 
			// - Set: lootapalooza, Rarity: epic
			// --------------------------------------------------------
			// Text: Spend all your Armor. Deal that much damage to all minions.
			// --------------------------------------------------------
			cards.Add("LOOT_364", new Power {
				// TODO [LOOT_364] Reckless Flurry && Test: Reckless Flurry_LOOT_364
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - WARRIOR
			// [LOOT_370] Gather Your Party - COST:6 
			// - Set: lootapalooza, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Recruit</b> a minion.
			// --------------------------------------------------------
			// RefTag:
			// - RECRUIT = 1
			// --------------------------------------------------------
			cards.Add("LOOT_370", new Power {
				// TODO [LOOT_370] Gather Your Party && Test: Gather Your Party_LOOT_370
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- WEAPON - WARRIOR
			// [LOOT_044] Bladed Gauntlet - COST:2 
			// - Set: lootapalooza, Rarity: epic
			// --------------------------------------------------------
			// Text: Has Attack equal to your Armor. Can't attack heroes.
			// --------------------------------------------------------
			// GameTag:
			// - DURABILITY = 2
			// --------------------------------------------------------
			cards.Add("LOOT_044", new Power {
				// TODO [LOOT_044] Bladed Gauntlet && Test: Bladed Gauntlet_LOOT_044
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- WEAPON - WARRIOR
			// [LOOT_380] Woecleaver - COST:8 [ATK:3/HP:0] 
			// - Set: lootapalooza, Rarity: legendary
			// --------------------------------------------------------
			// Text: After your hero attacks, <b>Recruit</b> a minion.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - DURABILITY = 3
			// --------------------------------------------------------
			// RefTag:
			// - RECRUIT = 1
			// --------------------------------------------------------
			cards.Add("LOOT_380", new Power {
				// TODO [LOOT_380] Woecleaver && Test: Woecleaver_LOOT_380
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void WarriorNonCollect(IDictionary<string, Power> cards)
		{
			// ---------------------------------- ENCHANTMENT - WARRIOR
			// [LOOT_528e] Twilight Curse (*) - COST:0 
			// - Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: Attack was swapped.
			// --------------------------------------------------------
			cards.Add("LOOT_528e", new Power {
				// TODO [LOOT_528e] Twilight Curse && Test: Twilight Curse_LOOT_528e
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - WARRIOR
			// [LOOT_203t4] Mithril Golem (*) - COST:5 [ATK:5/HP:5] 
			// - Set: lootapalooza, 
			// --------------------------------------------------------
			cards.Add("LOOT_203t4", new Power {
				// TODO [LOOT_203t4] Mithril Golem && Test: Mithril Golem_LOOT_203t4
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - WARRIOR
			// [LOOT_285t3t] Iron Golem (*) - COST:5 [ATK:5/HP:5] 
			// - Set: lootapalooza, 
			// --------------------------------------------------------
			cards.Add("LOOT_285t3t", new Power {
				// TODO [LOOT_285t3t] Iron Golem && Test: Iron Golem_LOOT_285t3t
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - WARRIOR
			// [LOOT_203t2] Mithril Spellstone (*) - COST:7 
			// - Set: lootapalooza, Rarity: rare
			// --------------------------------------------------------
			// Text: Summon two 5/5 Mithril Golems. <i>(Equip a weapon to upgrade.)</i>
			// --------------------------------------------------------
			cards.Add("LOOT_203t2", new Power {
				// TODO [LOOT_203t2] Mithril Spellstone && Test: Mithril Spellstone_LOOT_203t2
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - WARRIOR
			// [LOOT_203t3] Greater Mithril Spellstone (*) - COST:7 
			// - Set: lootapalooza, Rarity: rare
			// --------------------------------------------------------
			// Text: Summon three 5/5 Mithril Golems.
			// --------------------------------------------------------
			cards.Add("LOOT_203t3", new Power {
				// TODO [LOOT_203t3] Greater Mithril Spellstone && Test: Greater Mithril Spellstone_LOOT_203t3
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - WARRIOR
			// [LOOT_285t] Tower Shield +10 (*) - COST:6 
			// - Set: lootapalooza, Rarity: common
			// --------------------------------------------------------
			// Text: Gain 5 Armor.
			//       Gain 10 more Armor.
			// --------------------------------------------------------
			cards.Add("LOOT_285t", new Power {
				// TODO [LOOT_285t] Tower Shield +10 && Test: Tower Shield +10_LOOT_285t
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - WARRIOR
			// [LOOT_285t2] Serrated Shield (*) - COST:6 
			// - Set: lootapalooza, Rarity: common
			// --------------------------------------------------------
			// Text: Gain 5 Armor.
			//       Deal $5 damage. @spelldmg
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("LOOT_285t2", new Power {
				// TODO [LOOT_285t2] Serrated Shield && Test: Serrated Shield_LOOT_285t2
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - WARRIOR
			// [LOOT_285t3] Runed Shield (*) - COST:6 
			// - Set: lootapalooza, Rarity: common
			// --------------------------------------------------------
			// Text: Gain 5 Armor.
			//       Summon a 5/5 Golem.
			// --------------------------------------------------------
			cards.Add("LOOT_285t3", new Power {
				// TODO [LOOT_285t3] Runed Shield && Test: Runed Shield_LOOT_285t3
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - WARRIOR
			// [LOOT_285t4] Spiked Shield (*) - COST:6 
			// - Set: lootapalooza, Rarity: common
			// --------------------------------------------------------
			// Text: Gain 5 Armor.
			//       Equip a 5/2 weapon.
			// --------------------------------------------------------
			cards.Add("LOOT_285t4", new Power {
				// TODO [LOOT_285t4] Spiked Shield && Test: Spiked Shield_LOOT_285t4
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- WEAPON - WARRIOR
			// [LOOT_285t4t] Spiked Shield (*) - COST:5 [ATK:5/HP:0] 
			// - Set: lootapalooza, 
			// --------------------------------------------------------
			// GameTag:
			// - DURABILITY = 2
			// --------------------------------------------------------
			cards.Add("LOOT_285t4t", new Power {
				// TODO [LOOT_285t4t] Spiked Shield && Test: Spiked Shield_LOOT_285t4t
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void Neutral(IDictionary<string, Power> cards)
		{
			// --------------------------------------- MINION - NEUTRAL
			// [LOOT_069] Sewer Crawler - COST:3 [ATK:1/HP:1] 
			// - Fac: neutral, Set: lootapalooza, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Summon a 2/3_Giant Rat.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("LOOT_069", new Power {
				// TODO [LOOT_069] Sewer Crawler && Test: Sewer Crawler_LOOT_069
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [LOOT_111] Scorp-o-matic - COST:2 [ATK:1/HP:2] 
			// - Race: mechanical, Set: lootapalooza, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Destroy a minion with 1 or less Attack.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_MAX_ATTACK = 1
			// - REQ_TARGET_IF_AVAILABLE = 0
			// --------------------------------------------------------
			cards.Add("LOOT_111", new Power {
				// TODO [LOOT_111] Scorp-o-matic && Test: Scorp-o-matic_LOOT_111
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [LOOT_117] Wax Elemental - COST:1 [ATK:0/HP:2] 
			// - Race: elemental, Set: lootapalooza, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			//       <b>Divine Shield</b>
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// - DIVINE_SHIELD = 1
			// --------------------------------------------------------
			cards.Add("LOOT_117", new Power {
				// TODO [LOOT_117] Wax Elemental && Test: Wax Elemental_LOOT_117
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [LOOT_118] Ebon Dragonsmith - COST:4 [ATK:3/HP:4] 
			// - Race: dragon, Set: lootapalooza, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Reduce the Cost of a random weapon in your hand by (2).
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("LOOT_118", new Power {
				// TODO [LOOT_118] Ebon Dragonsmith && Test: Ebon Dragonsmith_LOOT_118
				InfoCardId = "LOOT_118e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [LOOT_122] Corrosive Sludge - COST:5 [ATK:5/HP:5] 
			// - Fac: alliance, Set: lootapalooza, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Destroy your opponent's weapon.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("LOOT_122", new Power {
				// TODO [LOOT_122] Corrosive Sludge && Test: Corrosive Sludge_LOOT_122
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [LOOT_124] Lone Champion - COST:3 [ATK:2/HP:4] 
			// - Set: lootapalooza, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> If you control no other minions, gain <b>Taunt</b> and <b>Divine Shield</b>.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - TAUNT = 1
			// - DIVINE_SHIELD = 1
			// --------------------------------------------------------
			cards.Add("LOOT_124", new Power {
				// TODO [LOOT_124] Lone Champion && Test: Lone Champion_LOOT_124
				InfoCardId = "LOOT_124e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [LOOT_125] Stoneskin Basilisk - COST:3 [ATK:1/HP:1] 
			// - Race: beast, Set: lootapalooza, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Divine Shield</b>
			//        <b>Poisonous</b>
			// --------------------------------------------------------
			// GameTag:
			// - DIVINE_SHIELD = 1
			// - POISONOUS = 1
			// --------------------------------------------------------
			cards.Add("LOOT_125", new Power {
				// TODO [LOOT_125] Stoneskin Basilisk && Test: Stoneskin Basilisk_LOOT_125
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [LOOT_130] Arcane Tyrant - COST:5 [ATK:4/HP:4] 
			// - Race: elemental, Set: lootapalooza, Rarity: epic
			// --------------------------------------------------------
			// Text: Costs (0) if you've cast a spell that costs (5) or more this turn.
			// --------------------------------------------------------
			cards.Add("LOOT_130", new Power {
				// TODO [LOOT_130] Arcane Tyrant && Test: Arcane Tyrant_LOOT_130
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [LOOT_131] Green Jelly - COST:5 [ATK:3/HP:3] 
			// - Set: lootapalooza, Rarity: common
			// --------------------------------------------------------
			// Text: At the end of your turn, summon a 1/2 Ooze with_<b>Taunt</b>.
			// --------------------------------------------------------
			// RefTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("LOOT_131", new Power {
				// TODO [LOOT_131] Green Jelly && Test: Green Jelly_LOOT_131
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [LOOT_132] Dragonslayer - COST:3 [ATK:4/HP:3] 
			// - Set: lootapalooza, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Deal 6 damage to a Dragon.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_IF_AVAILABLE = 0
			// - REQ_TARGET_WITH_RACE = 24
			// --------------------------------------------------------
			cards.Add("LOOT_132", new Power {
				// TODO [LOOT_132] Dragonslayer && Test: Dragonslayer_LOOT_132
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [LOOT_134] Toothy Chest - COST:3 [ATK:0/HP:4] 
			// - Fac: neutral, Set: lootapalooza, Rarity: common
			// --------------------------------------------------------
			// Text: At the start of your turn, set this minion's Attack to 4.
			// --------------------------------------------------------
			cards.Add("LOOT_134", new Power {
				// TODO [LOOT_134] Toothy Chest && Test: Toothy Chest_LOOT_134
				InfoCardId = "LOOT_134e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [LOOT_136] Sneaky Devil - COST:4 [ATK:2/HP:2] 
			// - Race: demon, Fac: alliance, Set: lootapalooza, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Stealth</b>
			//       Your other minions have +1 Attack.
			// --------------------------------------------------------
			// GameTag:
			// - STEALTH = 1
			// --------------------------------------------------------
			cards.Add("LOOT_136", new Power {
				// TODO [LOOT_136] Sneaky Devil && Test: Sneaky Devil_LOOT_136
				InfoCardId = "LOOT_136e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [LOOT_137] Sleepy Dragon - COST:9 [ATK:4/HP:12] 
			// - Race: dragon, Set: lootapalooza, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("LOOT_137", new Power {
				// TODO [LOOT_137] Sleepy Dragon && Test: Sleepy Dragon_LOOT_137
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [LOOT_144] Hoarding Dragon - COST:4 [ATK:5/HP:6] 
			// - Race: dragon, Set: lootapalooza, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Give your opponent two Coins.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("LOOT_144", new Power {
				// TODO [LOOT_144] Hoarding Dragon && Test: Hoarding Dragon_LOOT_144
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [LOOT_149] Corridor Creeper - COST:7 [ATK:2/HP:5] 
			// - Race: beast, Fac: neutral, Set: lootapalooza, Rarity: epic
			// --------------------------------------------------------
			// Text: Costs (1) less whenever a minion dies while this is_in_your hand.
			// --------------------------------------------------------
			cards.Add("LOOT_149", new Power {
				// TODO [LOOT_149] Corridor Creeper && Test: Corridor Creeper_LOOT_149
				InfoCardId = "LOOT_149e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [LOOT_150] Furbolg Mossbinder - COST:5 [ATK:1/HP:1] 
			// - Fac: alliance, Set: lootapalooza, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Transform a friendly minion into a 6/6_Elemental.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_IF_AVAILABLE = 0
			// - REQ_MINION_TARGET = 0
			// - REQ_FRIENDLY_TARGET = 0
			// --------------------------------------------------------
			cards.Add("LOOT_150", new Power {
				// TODO [LOOT_150] Furbolg Mossbinder && Test: Furbolg Mossbinder_LOOT_150
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [LOOT_152] Boisterous Bard - COST:3 [ATK:3/HP:2] 
			// - Fac: alliance, Set: lootapalooza, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Give your other minions +1 Health.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("LOOT_152", new Power {
				// TODO [LOOT_152] Boisterous Bard && Test: Boisterous Bard_LOOT_152
				InfoCardId = "LOOT_152e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [LOOT_153] Violet Wurm - COST:8 [ATK:7/HP:7] 
			// - Race: beast, Set: lootapalooza, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Summon seven 1/1 Grubs.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("LOOT_153", new Power {
				// TODO [LOOT_153] Violet Wurm && Test: Violet Wurm_LOOT_153
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [LOOT_154] Gravelsnout Knight - COST:1 [ATK:2/HP:3] 
			// - Set: lootapalooza, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Summon a random 1-Cost minion for_your opponent.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("LOOT_154", new Power {
				// TODO [LOOT_154] Gravelsnout Knight && Test: Gravelsnout Knight_LOOT_154
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [LOOT_161] Carnivorous Cube - COST:5 [ATK:4/HP:6] 
			// - Set: lootapalooza, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Destroy
			//       a friendly minion.
			//       <b>Deathrattle:</b> Summon 2 copies of it.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_IF_AVAILABLE = 0
			// - REQ_MINION_TARGET = 0
			// - REQ_FRIENDLY_TARGET = 0
			// --------------------------------------------------------
			cards.Add("LOOT_161", new Power {
				// TODO [LOOT_161] Carnivorous Cube && Test: Carnivorous Cube_LOOT_161
				InfoCardId = "LOOT_161e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [LOOT_167] Fungalmancer - COST:5 [ATK:2/HP:2] 
			// - Set: lootapalooza, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Give adjacent minions +2/+2.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("LOOT_167", new Power {
				// TODO [LOOT_167] Fungalmancer && Test: Fungalmancer_LOOT_167
				InfoCardId = "LOOT_167e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [LOOT_184] Silver Vanguard - COST:7 [ATK:3/HP:3] 
			// - Set: lootapalooza, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> <b>Recruit</b> an
			//       8-Cost minion.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			// RefTag:
			// - RECRUIT = 1
			// --------------------------------------------------------
			cards.Add("LOOT_184", new Power {
				// TODO [LOOT_184] Silver Vanguard && Test: Silver Vanguard_LOOT_184
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [LOOT_193] Shimmering Courser - COST:4 [ATK:3/HP:3] 
			// - Race: beast, Set: lootapalooza, Rarity: epic
			// --------------------------------------------------------
			// Text: Only you can target
			//       this with spells and
			//       Hero Powers.
			// --------------------------------------------------------
			cards.Add("LOOT_193", new Power {
				// TODO [LOOT_193] Shimmering Courser && Test: Shimmering Courser_LOOT_193
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [LOOT_218] Feral Gibberer - COST:1 [ATK:1/HP:1] 
			// - Set: lootapalooza, Rarity: rare
			// --------------------------------------------------------
			// Text: After this minion attacks a hero, add a copy of it to_your hand.
			// --------------------------------------------------------
			cards.Add("LOOT_218", new Power {
				// TODO [LOOT_218] Feral Gibberer && Test: Feral Gibberer_LOOT_218
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [LOOT_233] Cursed Disciple - COST:4 [ATK:5/HP:1] 
			// - Set: lootapalooza, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Summon a 5/1 Revenant.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("LOOT_233", new Power {
				// TODO [LOOT_233] Cursed Disciple && Test: Cursed Disciple_LOOT_233
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [LOOT_258] Dire Mole - COST:1 [ATK:1/HP:3] 
			// - Race: beast, Set: lootapalooza, Rarity: common
			// --------------------------------------------------------
			cards.Add("LOOT_258", new Power {
				// TODO [LOOT_258] Dire Mole && Test: Dire Mole_LOOT_258
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [LOOT_291] Shroom Brewer - COST:4 [ATK:4/HP:4] 
			// - Set: lootapalooza, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Restore 4_Health.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_IF_AVAILABLE = 0
			// --------------------------------------------------------
			cards.Add("LOOT_291", new Power {
				// TODO [LOOT_291] Shroom Brewer && Test: Shroom Brewer_LOOT_291
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [LOOT_315] Trogg Gloomeater - COST:5 [ATK:1/HP:5] 
			// - Set: lootapalooza, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			//       <b>Poisonous</b>
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// - POISONOUS = 1
			// --------------------------------------------------------
			cards.Add("LOOT_315", new Power {
				// TODO [LOOT_315] Trogg Gloomeater && Test: Trogg Gloomeater_LOOT_315
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [LOOT_347] Kobold Apprentice - COST:3 [ATK:2/HP:1] 
			// - Set: lootapalooza, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Deal 3 damage randomly split among all_enemies.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("LOOT_347", new Power {
				// TODO [LOOT_347] Kobold Apprentice && Test: Kobold Apprentice_LOOT_347
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [LOOT_357] Marin the Fox - COST:8 [ATK:6/HP:6] 
			// - Set: lootapalooza, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Summon a 0/8 Treasure Chest for your opponent. <i>(Break it for awesome loot!)</i>
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("LOOT_357", new Power {
				// TODO [LOOT_357] Marin the Fox && Test: Marin the Fox_LOOT_357
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [LOOT_375] Guild Recruiter - COST:5 [ATK:2/HP:4] 
			// - Set: lootapalooza, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> <b>Recruit</b> a minion that costs (4) or less.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - RECRUIT = 1
			// --------------------------------------------------------
			cards.Add("LOOT_375", new Power {
				// TODO [LOOT_375] Guild Recruiter && Test: Guild Recruiter_LOOT_375
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [LOOT_382] Kobold Monk - COST:4 [ATK:3/HP:6] 
			// - Set: lootapalooza, Rarity: rare
			// --------------------------------------------------------
			// Text: Your hero can't be targeted by spells or Hero_Powers.
			// --------------------------------------------------------
			cards.Add("LOOT_382", new Power {
				// TODO [LOOT_382] Kobold Monk && Test: Kobold Monk_LOOT_382
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [LOOT_383] Hungry Ettin - COST:6 [ATK:4/HP:10] 
			// - Set: lootapalooza, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			//       <b>Battlecry:</b> Summon a random 2-Cost minion for your opponent.
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("LOOT_383", new Power {
				// TODO [LOOT_383] Hungry Ettin && Test: Hungry Ettin_LOOT_383
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [LOOT_388] Fungal Enchanter - COST:3 [ATK:3/HP:3] 
			// - Set: lootapalooza, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Restore 2 Health to all friendly characters.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("LOOT_388", new Power {
				// TODO [LOOT_388] Fungal Enchanter && Test: Fungal Enchanter_LOOT_388
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [LOOT_389] Rummaging Kobold - COST:3 [ATK:1/HP:3] 
			// - Set: lootapalooza, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Return one of your destroyed weapons to your hand.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("LOOT_389", new Power {
				// TODO [LOOT_389] Rummaging Kobold && Test: Rummaging Kobold_LOOT_389
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [LOOT_394] Shrieking Shroom - COST:3 [ATK:1/HP:2] 
			// - Set: lootapalooza, Rarity: rare
			// --------------------------------------------------------
			// Text: At the end of your turn, summon a random
			//       1-Cost minion.
			// --------------------------------------------------------
			cards.Add("LOOT_394", new Power {
				// TODO [LOOT_394] Shrieking Shroom && Test: Shrieking Shroom_LOOT_394
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [LOOT_413] Plated Beetle - COST:2 [ATK:2/HP:3] 
			// - Race: beast, Set: lootapalooza, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Gain 3 Armor.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("LOOT_413", new Power {
				// TODO [LOOT_413] Plated Beetle && Test: Plated Beetle_LOOT_413
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [LOOT_414] Grand Archivist - COST:8 [ATK:4/HP:7] 
			// - Set: lootapalooza, Rarity: epic
			// --------------------------------------------------------
			// Text: At the end of your turn, cast a spell from your deck <i>(targets chosen randomly)</i>.
			// --------------------------------------------------------
			cards.Add("LOOT_414", new Power {
				// TODO [LOOT_414] Grand Archivist && Test: Grand Archivist_LOOT_414
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [LOOT_516] Zola the Gorgon - COST:3 [ATK:2/HP:2] 
			// - Set: lootapalooza, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Choose a friendly minion. Add a Golden copy of it to your hand.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_IF_AVAILABLE = 0
			// - REQ_FRIENDLY_TARGET = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("LOOT_516", new Power {
				// TODO [LOOT_516] Zola the Gorgon && Test: Zola the Gorgon_LOOT_516
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [LOOT_521] Master Oakheart - COST:9 [ATK:5/HP:5] 
			// - Set: lootapalooza, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> <b>Recruit</b> a 1, 2, and 3-Attack minion.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// RefTag:
			// - RECRUIT = 1
			// --------------------------------------------------------
			cards.Add("LOOT_521", new Power {
				// TODO [LOOT_521] Master Oakheart && Test: Master Oakheart_LOOT_521
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [LOOT_526] The Darkness - COST:4 [ATK:20/HP:20] 
			// - Set: lootapalooza, Rarity: legendary
			// --------------------------------------------------------
			// Text: [x]Starts dormant.
			//       <b>Battlecry:</b> Shuffle 3 Candles
			//       into the enemy deck. When
			//       drawn, this awakens.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("LOOT_526", new Power {
				// TODO [LOOT_526] The Darkness && Test: The Darkness_LOOT_526
				InfoCardId = "LOOT_526et",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [LOOT_529] Void Ripper - COST:3 [ATK:3/HP:3] 
			// - Race: demon, Set: lootapalooza, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Swap the
			//       Attack and Health of all_other_minions.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("LOOT_529", new Power {
				// TODO [LOOT_529] Void Ripper && Test: Void Ripper_LOOT_529
				InfoCardId = "LOOT_529e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [LOOT_539] Spiteful Summoner - COST:6 [ATK:4/HP:4] 
			// - Fac: neutral, Set: lootapalooza, Rarity: epic
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> Reveal a spell
			//       from your deck. Summon
			//        a random minion with
			//       the same Cost.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("LOOT_539", new Power {
				// TODO [LOOT_539] Spiteful Summoner && Test: Spiteful Summoner_LOOT_539
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [LOOT_540] Dragonhatcher - COST:9 [ATK:2/HP:4] 
			// - Set: lootapalooza, Rarity: epic
			// --------------------------------------------------------
			// Text: At the end of your turn, <b>Recruit</b> a Dragon.
			// --------------------------------------------------------
			// RefTag:
			// - RECRUIT = 1
			// --------------------------------------------------------
			cards.Add("LOOT_540", new Power {
				// TODO [LOOT_540] Dragonhatcher && Test: Dragonhatcher_LOOT_540
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [LOOT_541] King Togwaggle - COST:8 [ATK:5/HP:5] 
			// - Set: lootapalooza, Rarity: legendary
			// --------------------------------------------------------
			// Text: [x]<b>Battlecry:</b> Swap decks
			//       with your opponent.
			//       Give them a Ransom
			//       spell to swap back.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("LOOT_541", new Power {
				// TODO [LOOT_541] King Togwaggle && Test: King Togwaggle_LOOT_541
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void NeutralNonCollect(IDictionary<string, Power> cards)
		{
			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [LOOT_018e] Hooked Horror (*) - COST:0 
			// - Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: +3/+3.
			//       <b>Taunt</b>
			// --------------------------------------------------------
			cards.Add("LOOT_018e", new Power {
				// TODO [LOOT_018e] Hooked Horror && Test: Hooked Horror_LOOT_018e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [LOOT_047e] Barkskin (*) - COST:0 
			// - Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: +3 Health.
			// --------------------------------------------------------
			cards.Add("LOOT_047e", new Power {
				// TODO [LOOT_047e] Barkskin && Test: Barkskin_LOOT_047e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [LOOT_054be] Fearless (*) - COST:0 
			// - Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: +1 Attack.
			// --------------------------------------------------------
			cards.Add("LOOT_054be", new Power {
				// TODO [LOOT_054be] Fearless && Test: Fearless_LOOT_054be
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [LOOT_118e] Smithing (*) - COST:0 
			// - Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: Cost reduced.
			// --------------------------------------------------------
			cards.Add("LOOT_118e", new Power {
				// TODO [LOOT_118e] Smithing && Test: Smithing_LOOT_118e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [LOOT_124e] Lonely (*) - COST:0 
			// - Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: <b>Taunt</b> and <b>Divine Shield</b>.
			// --------------------------------------------------------
			cards.Add("LOOT_124e", new Power {
				// TODO [LOOT_124e] Lonely && Test: Lonely_LOOT_124e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [LOOT_134e] Toothy (*) - COST:0 
			// - Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: Attack set to 4.
			// --------------------------------------------------------
			cards.Add("LOOT_134e", new Power {
				// TODO [LOOT_134e] Toothy && Test: Toothy_LOOT_134e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [LOOT_136e] Devilish Power (*) - COST:0 
			// - Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: Sneaky Devil is granting this minion +1 Attack.
			// --------------------------------------------------------
			cards.Add("LOOT_136e", new Power {
				// TODO [LOOT_136e] Devilish Power && Test: Devilish Power_LOOT_136e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [LOOT_149e] Creepier (*) - COST:0 
			// - Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: Costs (1) less.
			// --------------------------------------------------------
			cards.Add("LOOT_149e", new Power {
				// TODO [LOOT_149e] Creepier && Test: Creepier_LOOT_149e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [LOOT_152e] Inspired (*) - COST:0 
			// - Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: +1 Health.
			// --------------------------------------------------------
			cards.Add("LOOT_152e", new Power {
				// TODO [LOOT_152e] Inspired && Test: Inspired_LOOT_152e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [LOOT_161e] Carnivorous Cube (*) - COST:0 
			// - Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: Destroyed {0}.
			// --------------------------------------------------------
			cards.Add("LOOT_161e", new Power {
				// TODO [LOOT_161e] Carnivorous Cube && Test: Carnivorous Cube_LOOT_161e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [LOOT_165e] Sonya's Shadow (*) - COST:0 
			// - Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: Sonya Shadowdancer made this 1/1.
			// --------------------------------------------------------
			cards.Add("LOOT_165e", new Power {
				// TODO [LOOT_165e] Sonya's Shadow && Test: Sonya's Shadow_LOOT_165e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [LOOT_167e] Magic Mushroom (*) - COST:0 
			// - Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: +2/+2.
			// --------------------------------------------------------
			cards.Add("LOOT_167e", new Power {
				// TODO [LOOT_167e] Magic Mushroom && Test: Magic Mushroom_LOOT_167e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [LOOT_187e] Shadowy (*) - COST:0 
			// - Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: 1/1.
			// --------------------------------------------------------
			cards.Add("LOOT_187e", new Power {
				// TODO [LOOT_187e] Shadowy && Test: Shadowy_LOOT_187e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [LOOT_204e] Close Call (*) - COST:0 
			// - Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: Costs (2) less.
			// --------------------------------------------------------
			cards.Add("LOOT_204e", new Power {
				// TODO [LOOT_204e] Close Call && Test: Close Call_LOOT_204e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [LOOT_214e] Evasive (*) - COST:0 
			// - Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: <b>Immune</b> until end of turn.
			// --------------------------------------------------------
			// GameTag:
			// - TAG_ONE_TURN_EFFECT = 1
			// --------------------------------------------------------
			cards.Add("LOOT_214e", new Power {
				// TODO [LOOT_214e] Evasive && Test: Evasive_LOOT_214e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [LOOT_216e] Light of the Exarch (*) - COST:0 
			// - Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: Spell cast on minion.
			// --------------------------------------------------------
			cards.Add("LOOT_216e", new Power {
				// TODO [LOOT_216e] Light of the Exarch && Test: Light of the Exarch_LOOT_216e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [LOOT_278e] Tastes Like ???? (*) - COST:0 
			// - Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: +2/+2.
			// --------------------------------------------------------
			cards.Add("LOOT_278e", new Power {
				// TODO [LOOT_278e] Tastes Like ???? && Test: Tastes Like ????_LOOT_278e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [LOOT_278t1e] Sanguine (*) - COST:0 
			// - Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: +2/+2 and <b>Lifesteal</b>.
			// --------------------------------------------------------
			// GameTag:
			// - LIFESTEAL = 1
			// --------------------------------------------------------
			cards.Add("LOOT_278t1e", new Power {
				// TODO [LOOT_278t1e] Sanguine && Test: Sanguine_LOOT_278t1e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [LOOT_278t2e] Pure (*) - COST:0 
			// - Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: +2/+2 and <b>Divine Shield</b>.
			// --------------------------------------------------------
			cards.Add("LOOT_278t2e", new Power {
				// TODO [LOOT_278t2e] Pure && Test: Pure_LOOT_278t2e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [LOOT_278t3e] Shadowtouched (*) - COST:0 
			// - Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: +2/+2.
			// --------------------------------------------------------
			cards.Add("LOOT_278t3e", new Power {
				// TODO [LOOT_278t3e] Shadowtouched && Test: Shadowtouched_LOOT_278t3e
				InfoCardId = "LOOT_278t3e2",
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [LOOT_278t3e2] Shadowy (*) - COST:0 
			// - Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: 1/1.
			// --------------------------------------------------------
			cards.Add("LOOT_278t3e2", new Power {
				// TODO [LOOT_278t3e2] Shadowy && Test: Shadowy_LOOT_278t3e2
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [LOOT_278t4e] Hopeful (*) - COST:0 
			// - Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: +2/+2. <b>Deathrattle:</b> Return this minion to your hand.
			// --------------------------------------------------------
			cards.Add("LOOT_278t4e", new Power {
				// TODO [LOOT_278t4e] Hopeful && Test: Hopeful_LOOT_278t4e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [LOOT_286t3e] Holy Blessings (*) - COST:0 
			// - Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: +1 Attack.
			// --------------------------------------------------------
			cards.Add("LOOT_286t3e", new Power {
				// TODO [LOOT_286t3e] Holy Blessings && Test: Holy Blessings_LOOT_286t3e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [LOOT_333e] +1 Level! (*) - COST:0 
			// - Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: +2/+2 and <b>Taunt</b>.
			// --------------------------------------------------------
			cards.Add("LOOT_333e", new Power {
				// TODO [LOOT_333e] +1 Level! && Test: +1 Level!_LOOT_333e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [LOOT_358e] Grumbly Tumbly (*) - COST:0 
			// - Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: Costs (1).
			// --------------------------------------------------------
			cards.Add("LOOT_358e", new Power {
				// TODO [LOOT_358e] Grumbly Tumbly && Test: Grumbly Tumbly_LOOT_358e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [LOOT_412e] Shadowy (*) - COST:0 
			// - Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: 1/1.
			// --------------------------------------------------------
			cards.Add("LOOT_412e", new Power {
				// TODO [LOOT_412e] Shadowy && Test: Shadowy_LOOT_412e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [LOOT_500e] Wielding Val'anyr (*) - COST:0 
			// - Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: +4/+2.
			//       <b>Deathrattle:</b> Equip a 4/2 Val'anyr.
			// --------------------------------------------------------
			cards.Add("LOOT_500e", new Power {
				// TODO [LOOT_500e] Wielding Val'anyr && Test: Wielding Val'anyr_LOOT_500e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [LOOT_517e] Murmurs (*) - COST:0 
			// - Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: Your next <b>Battlecry</b> this turn triggers twice.
			// --------------------------------------------------------
			cards.Add("LOOT_517e", new Power {
				// TODO [LOOT_517e] Murmurs && Test: Murmurs_LOOT_517e
				InfoCardId = "LOOT_517e2",
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [LOOT_517e2] Murmuring (*) - COST:0 
			// - Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: Your next <b>Battlecry</b> this turn triggers twice.
			// --------------------------------------------------------
			cards.Add("LOOT_517e2", new Power {
				// TODO [LOOT_517e2] Murmuring && Test: Murmuring_LOOT_517e2
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [LOOT_520e] Albino Chameleon (*) - COST:0 
			// - Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: Copied Deathrattle from {0}.
			// --------------------------------------------------------
			cards.Add("LOOT_520e", new Power {
				// TODO [LOOT_520e] Albino Chameleon && Test: Albino Chameleon_LOOT_520e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [LOOT_526et] Darkness Candle Detect (*) - COST:0 
			// - Set: lootapalooza, 
			// --------------------------------------------------------
			cards.Add("LOOT_526et", new Power {
				// TODO [LOOT_526et] Darkness Candle Detect && Test: Darkness Candle Detect_LOOT_526et
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [LOOT_529e] Void Shift (*) - COST:0 
			// - Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: Attack and Health have been swapped.
			// --------------------------------------------------------
			cards.Add("LOOT_529e", new Power {
				// TODO [LOOT_529e] Void Shift && Test: Void Shift_LOOT_529e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [LOOT_998le] Wand's Wonder (*) - COST:0 
			// - Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: Costs (0).
			// --------------------------------------------------------
			cards.Add("LOOT_998le", new Power {
				// TODO [LOOT_998le] Wand's Wonder && Test: Wand's Wonder_LOOT_998le
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [ICC_828t4] Stoneskin Basilisk (*) - COST:3 [ATK:1/HP:1] 
			// - Race: beast, Set: lootapalooza, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Divine Shield</b>
			//        <b>Poisonous</b>@<b>Divine Shield</b>, <b>Poisonous</b>
			// --------------------------------------------------------
			// GameTag:
			// - DIVINE_SHIELD = 1
			// - POISONOUS = 1
			// --------------------------------------------------------
			cards.Add("ICC_828t4", new Power {
				// TODO [ICC_828t4] Stoneskin Basilisk && Test: Stoneskin Basilisk_ICC_828t4
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [LOOT_069t] Giant Rat (*) - COST:3 [ATK:2/HP:3] 
			// - Race: beast, Set: lootapalooza, 
			// --------------------------------------------------------
			cards.Add("LOOT_069t", new Power {
				// TODO [LOOT_069t] Giant Rat && Test: Giant Rat_LOOT_069t
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [LOOT_131t1] Green Ooze (*) - COST:2 [ATK:1/HP:2] 
			// - Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("LOOT_131t1", new Power {
				// TODO [LOOT_131t1] Green Ooze && Test: Green Ooze_LOOT_131t1
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [LOOT_150t1] Moss Elemental (*) - COST:6 [ATK:6/HP:6] 
			// - Race: elemental, Set: lootapalooza, 
			// --------------------------------------------------------
			cards.Add("LOOT_150t1", new Power {
				// TODO [LOOT_150t1] Moss Elemental && Test: Moss Elemental_LOOT_150t1
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [LOOT_153t1] Grub (*) - COST:1 [ATK:1/HP:1] 
			// - Race: beast, Set: lootapalooza, 
			// --------------------------------------------------------
			cards.Add("LOOT_153t1", new Power {
				// TODO [LOOT_153t1] Grub && Test: Grub_LOOT_153t1
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [LOOT_233t] Cursed Revenant (*) - COST:4 [ATK:5/HP:1] 
			// - Set: lootapalooza, 
			// --------------------------------------------------------
			cards.Add("LOOT_233t", new Power {
				// TODO [LOOT_233t] Cursed Revenant && Test: Cursed Revenant_LOOT_233t
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [LOOT_357l] Master Chest (*) - COST:3 [ATK:0/HP:8] 
			// - Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Give your opponent a fantastic treasure!
			// --------------------------------------------------------
			// Entourage: LOOT_998h, LOOT_998j, LOOT_998l, LOOT_998k
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - DEATHRATTLE = 1
			// - MULTIPLY_BUFF_VALUE = 1
			// --------------------------------------------------------
			cards.Add("LOOT_357l", new Power {
				// TODO [LOOT_357l] Master Chest && Test: Master Chest_LOOT_357l
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [LOOT_526d] The Darkness (*) - COST:4 [ATK:20/HP:20] 
			// - Set: lootapalooza, Rarity: legendary
			// --------------------------------------------------------
			// Text: @
			// --------------------------------------------------------
			// GameTag:
			// - TAG_SCRIPT_DATA_NUM_2 = 3
			// - ELITE = 1
			// - HIDE_STATS = 1
			// - UNTOUCHABLE = 1
			// - SCORE_VALUE_1 = 3
			// - IGNORE_HIDE_STATS_FOR_BIG_CARD = 1
			// --------------------------------------------------------
			cards.Add("LOOT_526d", new Power {
				// TODO [LOOT_526d] The Darkness && Test: The Darkness_LOOT_526d
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [LOOT_998k] Golden Kobold (*) - COST:3 [ATK:6/HP:6] 
			// - Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			//       <b>Battlecry:</b> Replace your hand with <b>Legendary</b> minions.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - TAUNT = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("LOOT_998k", new Power {
				// TODO [LOOT_998k] Golden Kobold && Test: Golden Kobold_LOOT_998k
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [LOOT_526t] Darkness Candle (*) - COST:4 
			// - Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: Snuff out a candle. Draw a card.
			//       Cast this when drawn.
			// --------------------------------------------------------
			// GameTag:
			// - TOPDECK = 1
			// --------------------------------------------------------
			cards.Add("LOOT_526t", new Power {
				// TODO [LOOT_526t] Darkness Candle && Test: Darkness Candle_LOOT_526t
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [LOOT_541t] King's Ransom (*) - COST:5 
			// - Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: Swap decks with your_opponent.
			// --------------------------------------------------------
			cards.Add("LOOT_541t", new Power {
				// TODO [LOOT_541t] King's Ransom && Test: King's Ransom_LOOT_541t
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [LOOT_998h] Tolin's Goblet (*) - COST:3 
			// - Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: Draw a card. Fill your hand with copies of it.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("LOOT_998h", new Power {
				// TODO [LOOT_998h] Tolin's Goblet && Test: Tolin's Goblet_LOOT_998h
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [LOOT_998j] Zarog's Crown (*) - COST:3 
			// - Fac: neutral, Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: <b>Discover</b> a <b>Legendary</b> minion. Summon two copies of it.
			// --------------------------------------------------------
			// GameTag:
			// - DISCOVER = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_NUM_MINION_SLOTS = 1
			// --------------------------------------------------------
			cards.Add("LOOT_998j", new Power {
				// TODO [LOOT_998j] Zarog's Crown && Test: Zarog's Crown_LOOT_998j
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [LOOT_998l] Wondrous Wand (*) - COST:3 
			// - Set: lootapalooza, 
			// --------------------------------------------------------
			// Text: Draw 3 cards. Reduce their Costs to (0).
			// --------------------------------------------------------
			cards.Add("LOOT_998l", new Power {
				// TODO [LOOT_998l] Wondrous Wand && Test: Wondrous Wand_LOOT_998l
				InfoCardId = "LOOT_998le",
				//PowerTask = null,
				//Trigger = null,
			});

		}

		public static void AddAll(Dictionary<string, Power> cards)
		{
			Druid(cards);
			DruidNonCollect(cards);
			Hunter(cards);
			HunterNonCollect(cards);
			Mage(cards);
			MageNonCollect(cards);
			Paladin(cards);
			PaladinNonCollect(cards);
			Priest(cards);
			PriestNonCollect(cards);
			Rogue(cards);
			RogueNonCollect(cards);
			Shaman(cards);
			ShamanNonCollect(cards);
			Warlock(cards);
			WarlockNonCollect(cards);
			Warrior(cards);
			WarriorNonCollect(cards);
			Neutral(cards);
			NeutralNonCollect(cards);
		}
	}
}
