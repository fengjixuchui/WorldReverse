/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public static class AIGlobal // TypeDefIndex: 20398
{
	// Fields
	public static float AVATAR_MELEE_SLOT_RADIUS; // 0x00
	public static float AVOIDANCE_FORCE; // 0x04
	public static float AVOIDANCE_RADIUS; // 0x08
	public static float LOD_0_RANGE; // 0x0C
	public static float LOD_1_RANGE; // 0x10
	public static float LOD_2_RANGE; // 0x14
	public static float LOD_COLLISION_RANGE; // 0x18
	public const float AI_FUZZY_EPSILON = 0.0001f; // Metadata: 0x00AFD867
	public const float INVALID_DISTANCE = -1f; // Metadata: 0x00AFD86B
	public const string ABILITY_AI_LEAVECOMBAT_RESET = "AI_LeaveCombat_Reset"; // Metadata: 0x00AFD86F
	public static Vector3 INVALID_POSITION; // 0x1C
	public const float PHYSICS_SOUND_TRAVEL_SPEED_INVERSE = 0.05f; // Metadata: 0x00AFD887
	public static bool DEBUG_DRAW_MELEE_SLOT; // 0x28
	public static DungeonType curDungeonType; // 0x2C
	public static bool AI_STUCK_ENABLE; // 0x30
	public static float AI_STUCK_CHECK_TIME; // 0x34
	public static Dictionary<uint, AIStuckInfo> aiStuckConfigIDs; // 0x38
	public static Dictionary<MonsterConfigIdentifier, AIStuckInfo> aiStuckDebugByGroupId; // 0x40
	public static AIKnowledge curKnowledge; // 0x48
	public static bool AI_ENTER_COMBAT_ENABLE; // 0x50
	public static bool isEnterCombatDebugInTheatreMechanicus; // 0x51
	public static HashSet<DungeonType> enterCombatDebugByDungeonType; // 0x58
	public static HashSet<MonsterConfigIdentifier> enterCombatDebugByGroupId; // 0x60
	private static bool isInitDebugLogSwitch; // 0x68
	private static bool isThreatDebugInTower; // 0x69
	private static HashSet<DungeonType> threatDebugByDungeonType; // 0x70
	public static HashSet<MonsterConfigIdentifier> threatDebugByGroupId; // 0x78
	public static bool AI_RETURN_TO_BORN_ENABLE; // 0x80
	public static HashSet<DungeonType> returnToBornDebugByDungeonType; // 0x88
	public static float returnToBornPositionRange; // 0x90

	// Nested types
	public struct AIStuckInfo // TypeDefIndex: 20399
	{
		// Fields
		public float checkTime; // 0x00
		internal Func<bool> checkEnableCondition; // 0x08
	}

	// Constructors
	static AIGlobal() {} // 0x0000000182E87A70-0x0000000182E87BC0

	// Methods
	// [XID] // 0x0000000189A12DD0-0x0000000189A12DF0
	public static void InitGlobalAISetting(ConfigGlobalAI config) {} // 0x0000000182E86D40-0x0000000182E87000
	// [XID] // 0x0000000189A1A150-0x0000000189A1A170
	private static void InitDebugLogSwitch() {} // 0x0000000182E876B0-0x0000000182E87A70
	// [XID] // 0x0000000189B5A520-0x0000000189B5A540
	public static bool AIStuckLogEnable(AIKnowledge knowledge) => default; // 0x0000000182E873C0-0x0000000182E876B0
	// [XID] // 0x0000000189BA4490-0x0000000189BA44B0
	public static bool AIStuckTimeCheck(float lastAnimationStateChangeTime, AIKnowledge knowledge) => default; // 0x0000000182E87000-0x0000000182E87260
	// [XID] // 0x0000000189A095A0-0x0000000189A095C0
	public static bool ThreatDebugLogEnable(MonsterConfigIdentifier monsterConfigId) => default; // 0x0000000182E868F0-0x0000000182E86AF0
	// [XID] // 0x0000000189A37D70-0x0000000189A37D90
	public static bool EnterCombatDebugLogEnable(AIKnowledge knowledge) => default; // 0x0000000182E86AF0-0x0000000182E86D40
	// [XID] // 0x00000001896E3360-0x00000001896E3380
	public static bool ReturnToBornPosLogEnable() => default; // 0x0000000182E87260-0x0000000182E873C0
	// [XID] // 0x00000001896EA880-0x00000001896EA8A0
	public static bool ReturnToBornCheckInvalidPosition(Vector3 position) => default; // 0x0000000182E86730-0x0000000182E868F0
}

