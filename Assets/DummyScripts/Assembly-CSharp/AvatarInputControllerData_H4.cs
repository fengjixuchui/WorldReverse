/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public static class AvatarInputControllerData_H4 // TypeDefIndex: 19487
{
	// Fields
	public static float forceInputX; // 0x00
	public static float forceInputY; // 0x04
	public static DebugMoveModeType debugMoveMode; // 0x08
	public const KeyCode SLOW_MOVE_KEY_CODE = KeyCode.LeftShift; // Metadata: 0x00AFC8F0
	public const float TO_WALK_INPUT_RATIO = 0.35f; // Metadata: 0x00AFC8F4
	public const float TO_SPRINT_INPUT_RATIO = 0.95f; // Metadata: 0x00AFC8F8
	public const float SPRINT_BACK_TO_RUN_INPUT_RATIO = 0.7f; // Metadata: 0x00AFC8FC
	public const float TO_RUN_INPUT_RATIO = 0.45f; // Metadata: 0x00AFC900
	public const float TO_SPRINT_INPUT_TIME = 2f; // Metadata: 0x00AFC904
	public static float TO_WALK_MOLD_CHANGE_THRESHOLD; // 0x0C

	// Nested types
	public enum DebugMoveModeType // TypeDefIndex: 19488
	{
		Normal = 0,
		AlwaysWalk = 1,
		AlwaysRun = 2,
		AlwaysSprint = 3
	}

	// Constructors
	static AvatarInputControllerData_H4() {} // 0x00000001820C4220-0x00000001820C42A0
}

