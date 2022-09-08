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

public class AIMiscs // TypeDefIndex: 20510
{
	// Fields
	public static readonly HashSet<AITactic> syncTactic; // 0x00

	// Constructors
	public AIMiscs() {} // 0x00000001821F2650-0x00000001821F26B0
	static AIMiscs() {} // 0x00000001821F25A0-0x00000001821F2650

	// Methods
	// [XID] // 0x000000018973ADF0-0x000000018973AE10
	public static bool CheckEntity(BaseEntity entity) => default; // 0x00000001821F1AA0-0x00000001821F1B60
	// [XID] // 0x0000000189B322C0-0x0000000189B322E0
	public static VCMoveData.MotionDirection ConvertXYToMotionDirection(float x, float y) => default; // 0x00000001821F1910-0x00000001821F1AA0
	// [XID] // 0x0000000189B39C30-0x0000000189B39C50
	public static Vector3? FindTerrainPoint(Vector3 source, float heightRange, bool detectCeiling = true /* Metadata: 0x00AFDB8A */) => default; // 0x00000001821F2070-0x00000001821F24A0
	// [XID] // 0x0000000189AB6C90-0x0000000189AB6CB0
	public static BaseEntity FindNearestAvatar(Vector3 sourcePos, float maxRange = 99f /* Metadata: 0x00AFDB8B */) => default; // 0x00000001821F1B60-0x00000001821F1DC0
	// [XID] // 0x0000000189B48F00-0x0000000189B48F20
	public static BaseEntity FindNearestFollowAvatar(Vector3 sourcePos, float maxRange = 99f /* Metadata: 0x00AFDB8F */) => default; // 0x00000001821F1DC0-0x00000001821F2070
	public static T? GetRandomMember<T>(List<T> list)
		where T : struct => default;
	// [XID] // 0x0000000189B50520-0x0000000189B50540
	public static bool AnimatorStatesContains(string[] states, int stateID) => default; // 0x00000001821F24A0-0x00000001821F25A0
}

