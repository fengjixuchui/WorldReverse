/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole.Config;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	[LuaCallCSharp] // 0x0000000189BA67A0-0x0000000189BA67C0
	public static class CampHelper // TypeDefIndex: 31383
	{
		// Fields
		public const int CAMP_NONE = 0; // Metadata: 0x00B12612
		public const int CAMP_PLAYER = 1001; // Metadata: 0x00B12616
		public const int CAMP_MONSTER = 4001; // Metadata: 0x00B1261A
		public const int CAMP_ITEM = 1001; // Metadata: 0x00B1261E
		public const int CAMP_GRASS = 9001; // Metadata: 0x00B12622
		public const int CAMP_WATER = 9002; // Metadata: 0x00B12626
		public const int CAMP_ENVIRO = 9999; // Metadata: 0x00B1262A
		private static Dictionary<uint, Dictionary<int, uint[]>> _targetCampsForLuaWrap; // 0x00
		private static uint[] _allCampsForLuaWrap; // 0x08
	
		// Constructors
		static CampHelper() {} // 0x0000000181ADA6B0-0x0000000181ADA740
	
		// Methods
		// [IDTag] // 0x0000000189AD9F30-0x0000000189AD9F70
		// [XID] // 0x0000000189AD9F30-0x0000000189AD9F70
		public static bool IsTarget(LCBaseCombat combatCom1, LCBaseCombat combatCom2, TargetType targetType) => default; // 0x0000000181AD9F00-0x0000000181ADA0A0
		// [IDTag] // 0x0000000189AE4AC0-0x0000000189AE4B00
		// [XID] // 0x0000000189AE4AC0-0x0000000189AE4B00
		public static bool IsTarget(uint camp1, LCBaseCombat combatCom2, uint runtimeID1, TargetType targetType) => default; // 0x0000000181ADA520-0x0000000181ADA6B0
		// [XID] // 0x000000018988F780-0x000000018988F7A0
		private static bool IsTargetGhost(uint camp1, LCBaseCombat combatCom2, uint runtimeID1, TargetType targetType) => default; // 0x0000000181AD9AD0-0x0000000181AD9F00
		// [IDTag] // 0x0000000189AF6A10-0x0000000189AF6A50
		// [XID] // 0x0000000189AF6A10-0x0000000189AF6A50
		public static bool IsTarget(uint camp1, uint camp2, uint runtimeID1, uint runtimeID2, TargetType targetType) => default; // 0x0000000181ADA0A0-0x0000000181ADA520
		// [XID] // 0x00000001897C8980-0x00000001897C89A0
		public static SimpleSafeUInt32[] GetTargetCamps(uint selfCamp, TargetType targetType) => default; // 0x0000000181AD96B0-0x0000000181AD9AD0
		// [XID] // 0x00000001897D0050-0x00000001897D0070
		public static SimpleSafeUInt32[] GetAllCamps() => default; // 0x0000000181AD8C50-0x0000000181AD8D20
		// [XID] // 0x0000000189B0FFA0-0x0000000189B0FFC0
		public static SimpleSafeUInt32[] GetAllCampsExcept(SimpleSafeUInt32[] exceptCamps) => default; // 0x0000000181AD86F0-0x0000000181AD89D0
		// [XID] // 0x0000000189B17100-0x0000000189B17120
		public static uint GetCampByAbilityTarget(AbilityTargetting campBasedOn, LCAbility self, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity attackTarget, BaseEntity target, BaseEntity other) => default; // 0x0000000181AD8D20-0x0000000181AD9140
		// [XID] // 0x00000001897B8F40-0x00000001897B8F60
		private static uint GetCampIDFromLCAbility(LCAbility target) => default; // 0x0000000181AD9210-0x0000000181AD92F0
		// [XID] // 0x0000000189B263B0-0x0000000189B263D0
		private static uint GetCampIDFromEntity(BaseEntity entity) => default; // 0x0000000181AD9140-0x0000000181AD9210
		// [XID] // 0x0000000189B2D5F0-0x0000000189B2D610
		public static uint[] GetTargetCampsForLuaWrap(uint selfCamp, TargetType targetType) => default; // 0x0000000181AD92F0-0x0000000181AD96B0
		// [XID] // 0x0000000189B34AE0-0x0000000189B34B00
		public static uint[] GetAllCampsForLuaWrap() => default; // 0x0000000181AD89D0-0x0000000181AD8C50
		// [XID] // 0x0000000189B3C2F0-0x0000000189B3C310
		public static uint[] GetAllCampsExceptForLuaWrap(uint[] exceptCamps) => default; // 0x0000000181AD8480-0x0000000181AD86F0
	}
}
