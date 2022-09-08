/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public static class ActorFSMUtils // TypeDefIndex: 21114
{
	// Fields
	public static int Anim_Freestyle_SitOnFloor01; // 0x00
	public static int Anim_Freestyle_SitOnFloor02; // 0x04
	public static int Anim_Freestyle_SitOnChair01; // 0x08
	public static int Anim_Freestyle_SitOnChair02; // 0x0C
	public static int Anim_Freestyle_AvatarSitOnChair01; // 0x10
	public static int Anim_Freestyle_AvatarSitOnChair02; // 0x14
	public static int Anim_Interaction_HitLightBack; // 0x18
	public static int Anim_Interaction_HitLightFront; // 0x1C
	public static int Anim_Interaction_TurnLeft; // 0x20
	public static int Anim_Interaction_TurnRight; // 0x24
	public static float ARRIVED_RADIUS; // 0x28

	// Constructors
	static ActorFSMUtils() {} // 0x00000001830E7940-0x00000001830E7A70

	// Methods
	// [XID] // 0x0000000189651A00-0x0000000189651A20
	public static bool IsInArriveRange(DummyActionPoint actionPoint, Vector3 pos) => default; // 0x00000001830E69C0-0x00000001830E6C00
	// [XID] // 0x00000001896592D0-0x00000001896592F0
	public static int GetNpcSitOnChairPerformId(int avatarPerformId) => default; // 0x00000001830E7410-0x00000001830E7560
	// [XID] // 0x0000000189660990-0x00000001896609B0
	public static LevelTrafficPlugin GetLevelTrafficPlugin() => default; // 0x00000001830E68B0-0x00000001830E69C0
	// [XID] // 0x00000001896683A0-0x00000001896683C0
	public static TrafficPathQueryPattern FindTrafficPath(Vector3 start, Vector3 goal, List<Vector3> posList, Action<bool, List<Vector3>> OnFindPathResult) => default; // 0x00000001830E7260-0x00000001830E7410
	// [XID] // 0x000000018966FE70-0x000000018966FE90
	public static void TransitToLastState(NpcActor owner, ActorFSMStateID lastStateId) {} // 0x00000001830E7690-0x00000001830E7840
	// [XID] // 0x00000001896776A0-0x00000001896776C0
	public static GeneralPattern GetTargetActionPattern(DummyActionPoint targetActionPoint, Vector3 myPos) => default; // 0x00000001830E6E00-0x00000001830E6F40
	// [XID] // 0x000000018967EC40-0x000000018967EC60
	private static ActionPointData GetActionPointData(ActionPointType actionType) => default; // 0x00000001830E6790-0x00000001830E68B0
	// [XID] // 0x0000000189686530-0x0000000189686550
	public static int GetRandomFreestyle(ActionPointType actionType) => default; // 0x00000001830E6660-0x00000001830E6790
	// [XID] // 0x000000018968E390-0x000000018968E3B0
	public static int ChooseFreestyleFromLevelActionPoint(LevelActionPoint levelActionPoint) => default; // 0x00000001830E6C00-0x00000001830E6D20
	// [XID] // 0x0000000189695C30-0x0000000189695C50
	public static FocusToPlayerType GetFocusToPlayerType(ActionPointType actionType) => default; // 0x00000001830E6D20-0x00000001830E6E00
	// [XID] // 0x000000018969D3A0-0x000000018969D3C0
	public static bool CanDoReaction(ActorFSMReactionType reactionType, ActionPointType actionType) => default; // 0x00000001830E7840-0x00000001830E7940
	// [XID] // 0x000000018969E2C0-0x000000018969E2E0
	public static LevelActionPoint GetCurrentActionPoint(BaseEntity entity) => default; // 0x00000001830E6550-0x00000001830E6660
	// [XID] // 0x00000001896ABC30-0x00000001896ABC50
	public static void OverrideTargetFreestyle(BaseEntity entity, int freestyle, bool doRefresh) {} // 0x00000001830E7560-0x00000001830E7690
	// [IDTag] // 0x00000001896B2D70-0x00000001896B2DB0
	// [XID] // 0x00000001896B2D70-0x00000001896B2DB0
	public static bool IsAtConvsationPoint(BaseEntity entity) => default; // 0x00000001830E7100-0x00000001830E7260
	// [IDTag] // 0x00000001896BD3A0-0x00000001896BD3E0
	// [XID] // 0x00000001896BD3A0-0x00000001896BD3E0
	public static bool IsAtConvsationPoint(Vector3 myPos, LevelActionPoint curActionPoint) => default; // 0x00000001830E6F40-0x00000001830E7100
}

