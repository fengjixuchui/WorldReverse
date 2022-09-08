/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine.Events;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public static class ResinUtils // TypeDefIndex: 28713
{
	// Fields
	public const uint RESIN_CARD_CONFIG_ID = 102; // Metadata: 0x00B0E5A1
	public const uint RESIN_ITEM_ID = 106; // Metadata: 0x00B0E5A5
	public const uint CONDENSE_RESIN_ITEM_ID = 220007; // Metadata: 0x00B0E5A9
	public const uint CONDENSE_RESIN_REPLACE_COST = 20; // Metadata: 0x00B0E5AD
	public const uint FRAGILE_RESIN_ITEM_ID = 107009; // Metadata: 0x00B0E5B1
	public const uint TIMING_RESIN_ITEM_ID = 107012; // Metadata: 0x00B0E5B5
	private static UnityAction _showTipsDialogAction; // 0x00
	private static DateTime _nextCanOpenRewardsTimeStamp; // 0x08
	private static readonly float _openRewardInterval; // 0x18

	// Properties
	public static UnityAction showTipsDialogAction { /* [XID] */ /* 0x00000001895F6520-0x00000001895F6540 */ get; } // 0x0000000183D87400-0x0000000183D875C0 

	// Constructors
	static ResinUtils() {} // 0x0000000183D875C0-0x0000000183D87680

	// Methods
	// [XID] // 0x00000001895E7250-0x00000001895E7270
	public static bool HaveCondenseResin() => default; // 0x0000000183D86E20-0x0000000183D86F00
	// [XID] // 0x00000001895EEB00-0x00000001895EEB20
	public static bool CanThisGadgetUseCondenseResin(uint resinCost, uint gadgetRunTimeId) => default; // 0x0000000183D86F00-0x0000000183D87070
	// [XID] // 0x00000001895FD830-0x00000001895FD850
	private static void ShowTipsDialog() {} // 0x0000000183D86580-0x0000000183D86780
	// [XID] // 0x0000000189605100-0x0000000189605120
	public static void ShowNormalDungeonTips() {} // 0x0000000183D86440-0x0000000183D86580
	// [XID] // 0x000000018960CB10-0x000000018960CB30
	public static void ShowWeeklyBossTips(uint remainNum, uint discountNumLimit) {} // 0x0000000183D87070-0x0000000183D87400
	// [XID] // 0x00000001896140C0-0x00000001896140E0
	public static void OpenReward(uint resinCost, uint entityRuntimeID, uint entityConfigID, Action<ResinCostType> finishRequest = null, bool hasReunionPrivilege = false /* Metadata: 0x00B0E5A0 */, WeeklyBossResinDiscountInfoStruct weeklyBossResin = default) {} // 0x0000000183D86780-0x0000000183D86E20
}

