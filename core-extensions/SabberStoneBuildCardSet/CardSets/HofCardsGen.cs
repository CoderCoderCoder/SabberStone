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
	public class HofCardsGen
	{
		private static void Mage(IDictionary<string, Power> cards)
		{
			// ------------------------------------------- SPELL - MAGE
			// [CS2_031] Ice Lance - COST:1 
			// - Fac: neutral, Set: hof, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Freeze</b> a character. If it was already <b>Frozen</b>, deal $4 damage instead. @spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - FREEZE = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("CS2_031", new Power {
				// TODO [CS2_031] Ice Lance && Test: Ice Lance_CS2_031
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void MageNonCollect(IDictionary<string, Power> cards)
		{
			// ------------------------------------- ENCHANTMENT - MAGE
			// [EX1_295o] Ice Block (*) - COST:0 
			// - Set: hof, 
			// --------------------------------------------------------
			// Text: Your hero is <b>Immune</b> this turn.
			// --------------------------------------------------------
			// GameTag:
			// - TAG_ONE_TURN_EFFECT = 1
			// --------------------------------------------------------
			cards.Add("EX1_295o", new Power {
				// TODO [EX1_295o] Ice Block && Test: Ice Block_EX1_295o
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void Rogue(IDictionary<string, Power> cards)
		{
			// ------------------------------------------ SPELL - ROGUE
			// [EX1_128] Conceal - COST:1 
			// - Fac: neutral, Set: hof, Rarity: common
			// --------------------------------------------------------
			// Text: Give your minions <b>Stealth</b> until your next_turn.
			// --------------------------------------------------------
			// RefTag:
			// - STEALTH = 1
			// --------------------------------------------------------
			cards.Add("EX1_128", new Power {
				// TODO [EX1_128] Conceal && Test: Conceal_EX1_128
				InfoCardId = "EX1_128e",
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void RogueNonCollect(IDictionary<string, Power> cards)
		{
			// ------------------------------------ ENCHANTMENT - ROGUE
			// [EX1_128e] Concealed (*) - COST:0 
			// - Set: hof, 
			// --------------------------------------------------------
			// Text: Stealthed until your next turn.
			// --------------------------------------------------------
			cards.Add("EX1_128e", new Power {
				// TODO [EX1_128e] Concealed && Test: Concealed_EX1_128e
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void Warlock(IDictionary<string, Power> cards)
		{
			// ---------------------------------------- SPELL - WARLOCK
			// [EX1_316] Power Overwhelming - COST:1 
			// - Fac: neutral, Set: hof, Rarity: common
			// --------------------------------------------------------
			// Text: Give a friendly minion +4/+4 until end of turn. Then, it dies. Horribly.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// - REQ_FRIENDLY_TARGET = 0
			// --------------------------------------------------------
			cards.Add("EX1_316", new Power {
				// TODO [EX1_316] Power Overwhelming && Test: Power Overwhelming_EX1_316
				InfoCardId = "EX1_316e",
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void WarlockNonCollect(IDictionary<string, Power> cards)
		{
			// ---------------------------------- ENCHANTMENT - WARLOCK
			// [EX1_316e] Power Overwhelming (*) - COST:0 
			// - Fac: neutral, Set: hof, 
			// --------------------------------------------------------
			// Text: This minion has +4/+4, but will die a horrible death at the end of the turn.
			// --------------------------------------------------------
			cards.Add("EX1_316e", new Power {
				// TODO [EX1_316e] Power Overwhelming && Test: Power Overwhelming_EX1_316e
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void Neutral(IDictionary<string, Power> cards)
		{
			// --------------------------------------- MINION - NEUTRAL
			// [EX1_016] Sylvanas Windrunner - COST:6 [ATK:5/HP:5] 
			// - Set: hof, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Take
			//       control of a random
			//       enemy minion.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("EX1_016", new Power {
				// TODO [EX1_016] Sylvanas Windrunner && Test: Sylvanas Windrunner_EX1_016
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_062] Old Murk-Eye - COST:4 [ATK:2/HP:4] 
			// - Race: murloc, Fac: neutral, Set: hof, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Charge</b>. Has +1 Attack for each other Murloc on the battlefield.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - CHARGE = 1
			// --------------------------------------------------------
			cards.Add("EX1_062", new Power {
				// TODO [EX1_062] Old Murk-Eye && Test: Old Murk-Eye_EX1_062
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_112] Gelbin Mekkatorque - COST:6 [ATK:6/HP:6] 
			// - Fac: alliance, Set: hof, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Summon an AWESOME invention.
			// --------------------------------------------------------
			// Entourage: Mekka1, Mekka2, Mekka3, Mekka4
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("EX1_112", new Power {
				// TODO [EX1_112] Gelbin Mekkatorque && Test: Gelbin Mekkatorque_EX1_112
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_284] Azure Drake - COST:5 [ATK:4/HP:4] 
			// - Race: dragon, Fac: neutral, Set: hof, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Spell Damage +1</b>
			//       <b>Battlecry:</b> Draw a card.
			// --------------------------------------------------------
			// GameTag:
			// - SPELLPOWER = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("EX1_284", new Power {
				// TODO [EX1_284] Azure Drake && Test: Azure Drake_EX1_284
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [EX1_298] Ragnaros the Firelord - COST:8 [ATK:8/HP:8] 
			// - Race: elemental, Fac: neutral, Set: hof, Rarity: legendary
			// --------------------------------------------------------
			// Text: Can't attack. At the end of your turn, deal 8 damage to a random enemy.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - CANT_ATTACK = 1
			// --------------------------------------------------------
			cards.Add("EX1_298", new Power {
				// TODO [EX1_298] Ragnaros the Firelord && Test: Ragnaros the Firelord_EX1_298
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [NEW1_016] Captain's Parrot - COST:2 [ATK:1/HP:1] 
			// - Race: beast, Set: hof, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Draw a Pirate from your deck.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("NEW1_016", new Power {
				// TODO [NEW1_016] Captain's Parrot && Test: Captain's Parrot_NEW1_016
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [PRO_001] Elite Tauren Chieftain - COST:5 [ATK:5/HP:5] 
			// - Set: hof, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Give both players the power to ROCK! (with a Power Chord card)
			// --------------------------------------------------------
			// Entourage: PRO_001a, PRO_001b, PRO_001c
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("PRO_001", new Power {
				// TODO [PRO_001] Elite Tauren Chieftain && Test: Elite Tauren Chieftain_PRO_001
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void NeutralNonCollect(IDictionary<string, Power> cards)
		{
			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [EX1_507e] Mrgglaargl! (*) - COST:0 
			// - Set: hof, 
			// --------------------------------------------------------
			// Text: +2 Attack from Murloc Warleader.
			// --------------------------------------------------------
			cards.Add("EX1_507e", new Power {
				// TODO [EX1_507e] Mrgglaargl! && Test: Mrgglaargl!_EX1_507e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [Mekka3e] Emboldened! (*) - COST:0 
			// - Set: hof, 
			// --------------------------------------------------------
			// Text: Increased Stats.
			// --------------------------------------------------------
			cards.Add("Mekka3e", new Power {
				// TODO [Mekka3e] Emboldened! && Test: Emboldened!_Mekka3e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [Mekka4e] Transformed (*) - COST:0 
			// - Set: hof, 
			// --------------------------------------------------------
			// Text: Has been transformed into a chicken!
			// --------------------------------------------------------
			// GameTag:
			// - MORPH = 1
			// --------------------------------------------------------
			cards.Add("Mekka4e", new Power {
				// TODO [Mekka4e] Transformed && Test: Transformed_Mekka4e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [NEW1_027e] Yarrr! (*) - COST:0 
			// - Set: hof, 
			// --------------------------------------------------------
			// Text: Southsea Captain is granting +1/+1.
			// --------------------------------------------------------
			cards.Add("NEW1_027e", new Power {
				// TODO [NEW1_027e] Yarrr! && Test: Yarrr!_NEW1_027e
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [Mekka1] Homing Chicken (*) - COST:1 [ATK:0/HP:1] 
			// - Race: mechanical, Fac: alliance, Set: hof, Rarity: common
			// --------------------------------------------------------
			// Text: At the start of your turn, destroy this minion and draw 3 cards.
			// --------------------------------------------------------
			cards.Add("Mekka1", new Power {
				// TODO [Mekka1] Homing Chicken && Test: Homing Chicken_Mekka1
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [Mekka2] Repair Bot (*) - COST:1 [ATK:0/HP:3] 
			// - Race: mechanical, Fac: alliance, Set: hof, Rarity: common
			// --------------------------------------------------------
			// Text: At the end of your turn, restore 6 Health to a damaged character.
			// --------------------------------------------------------
			cards.Add("Mekka2", new Power {
				// TODO [Mekka2] Repair Bot && Test: Repair Bot_Mekka2
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [Mekka3] Emboldener 3000 (*) - COST:1 [ATK:0/HP:4] 
			// - Race: mechanical, Fac: alliance, Set: hof, Rarity: common
			// --------------------------------------------------------
			// Text: At the end of your turn, give a random minion +1/+1.
			// --------------------------------------------------------
			cards.Add("Mekka3", new Power {
				// TODO [Mekka3] Emboldener 3000 && Test: Emboldener 3000_Mekka3
				InfoCardId = "Mekka3e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [Mekka4] Poultryizer (*) - COST:1 [ATK:0/HP:3] 
			// - Race: mechanical, Fac: alliance, Set: hof, Rarity: common
			// --------------------------------------------------------
			// Text: At the start of your turn, transform a random minion into a 1/1 Chicken.
			// --------------------------------------------------------
			cards.Add("Mekka4", new Power {
				// TODO [Mekka4] Poultryizer && Test: Poultryizer_Mekka4
				InfoCardId = "Mekka4e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [Mekka4t] Chicken (*) - COST:0 [ATK:1/HP:1] 
			// - Race: beast, Set: hof, 
			// --------------------------------------------------------
			// Text: <i>Hey Chicken!</i>
			// --------------------------------------------------------
			cards.Add("Mekka4t", new Power {
				// TODO [Mekka4t] Chicken && Test: Chicken_Mekka4t
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [PRO_001at] Murloc (*) - COST:0 [ATK:1/HP:1] 
			// - Race: murloc, Set: hof, 
			// --------------------------------------------------------
			cards.Add("PRO_001at", new Power {
				// TODO [PRO_001at] Murloc && Test: Murloc_PRO_001at
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [PRO_001a] I Am Murloc (*) - COST:4 
			// - Set: hof, 
			// --------------------------------------------------------
			// Text: Summon three, four, or five 1/1 Murlocs.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_NUM_MINION_SLOTS = 1
			// --------------------------------------------------------
			cards.Add("PRO_001a", new Power {
				// TODO [PRO_001a] I Am Murloc && Test: I Am Murloc_PRO_001a
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [PRO_001b] Rogues Do It... (*) - COST:4 
			// - Set: hof, 
			// --------------------------------------------------------
			// Text: Deal $4 damage. Draw a card. @spelldmg
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("PRO_001b", new Power {
				// TODO [PRO_001b] Rogues Do It... && Test: Rogues Do It..._PRO_001b
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [PRO_001c] Power of the Horde (*) - COST:4 
			// - Set: hof, 
			// --------------------------------------------------------
			// Text: Summon a random Horde Warrior.
			// --------------------------------------------------------
			// Entourage: CS2_121, EX1_021, EX1_023, EX1_110, EX1_390, CS2_179
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_NUM_MINION_SLOTS = 1
			// --------------------------------------------------------
			cards.Add("PRO_001c", new Power {
				// TODO [PRO_001c] Power of the Horde && Test: Power of the Horde_PRO_001c
				//PowerTask = null,
				//Trigger = null,
			});

		}

		public static void AddAll(Dictionary<string, Power> cards)
		{
			Mage(cards);
			MageNonCollect(cards);
			Rogue(cards);
			RogueNonCollect(cards);
			Warlock(cards);
			WarlockNonCollect(cards);
			Neutral(cards);
			NeutralNonCollect(cards);
		}
	}
}
