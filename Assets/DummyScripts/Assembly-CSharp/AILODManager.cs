/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public static class AILODManager // TypeDefIndex: 20453
{
	// Fields
	private static float MIN_INTERVAL; // 0x00
	private static readonly float[,,] _aiLodTickTable; // 0x08
	private static readonly float[] _systemModuleTickTable; // 0x10

	// Nested types
	public enum BrainModuleType // TypeDefIndex: 20454
	{
		AI_MAIN = 0,
		SENSING = 1,
		THREAT = 2,
		ORDER = 3,
		PRECOMBAT = 4,
		EQUIP = 5,
		AREA = 6,
		PATHFINDING = 7,
		AVOIDANCE = 8,
		BUDDY = 9,
		MIXIN = 10,
		POSE_CONTROL = 11
	}

	public enum SystemModuleType // TypeDefIndex: 20455
	{
		AIMANAGER_COMBAT_INFO = 0,
		AIMANAGER_LEVEL_INFO = 1,
		AIMANAGER_MELEESLOT_INFO = 2,
		AIMANAGER_PATHFOLLOW_AVOIDANCE = 3,
		UI_INDICATOR_VISIBILITY_CHECK = 4,
		UI_INDICATOR_THREATLIST_UPDATE = 5
	}

	// Constructors
	static AILODManager() {} // 0x00000001829CC320-0x00000001829CC430

	// Methods
	// [XID] // 0x0000000189AAFD10-0x0000000189AAFD30
	public static void UpdateLOD(AIKnowledge knowledge) {} // 0x00000001829CC010-0x00000001829CC160
	// [IDTag] // 0x0000000189AB7470-0x0000000189AB74B0
	// [XID] // 0x0000000189AB7470-0x0000000189AB74B0
	public static float GetNextInterval(BrainModuleType type, AIKnowledge knowledge) => default; // 0x00000001829CBE60-0x00000001829CC010
	// [IDTag] // 0x0000000189AC2110-0x0000000189AC2150
	// [XID] // 0x0000000189AC2110-0x0000000189AC2150
	public static float GetNextInterval(SystemModuleType type) => default; // 0x00000001829CBD60-0x00000001829CBE60
	// [XID] // 0x0000000189ACC780-0x0000000189ACC7A0
	public static void UpdateLODSpecificLogic(LCAIBeta ai, AIKnowledge knowledge) {} // 0x00000001829CC160-0x00000001829CC320
}

