/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;
using UnityEngine;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class LandingInfo : MoveInfoBase, IAutoAllocRecycle // TypeDefIndex: 20208
{
	// Fields
	public const float LANDING_RAY_DISTANCE = 50f; // Metadata: 0x00AFD35A
	public const float LANDING_OVETTIME = 5f; // Metadata: 0x00AFD35E
	public LevelActionPoint levelLandingPoint; // 0x10
	public LandingStatus status; // 0x18
	public Vector3? landingPosition; // 0x1C
	public bool landing; // 0x2C
	public float landingOvertimeTick; // 0x30
	public bool touchDown; // 0x34

	// Nested types
	public enum LandingStatus // TypeDefIndex: 20209
	{
		Inactive = 0,
		Descending = 1,
		Landing = 2,
		Landed = 3
	}

	// Constructors
	public LandingInfo() {} // 0x0000000185168230-0x00000001851682A0

	// Methods
	[BlackList] // 0x0000000189BB21B0-0x0000000189BB21F0
	// [XID] // 0x0000000189BB21B0-0x0000000189BB21F0
	public override void AutoAllocTypeFields() {} // 0x0000000185166BE0-0x0000000185166C80
	[BlackList] // 0x0000000189BBC700-0x0000000189BBC740
	// [XID] // 0x0000000189BBC700-0x0000000189BBC740
	public override void AutoRecycleTypeFields() {} // 0x0000000185166C80-0x0000000185166D50
	[BlackList] // 0x0000000189BC7150-0x0000000189BC7190
	// [XID] // 0x0000000189BC7150-0x0000000189BC7190
	public override void ReturnToObjectPool() {} // 0x0000000185168190-0x0000000185168230
	// [XID] // 0x0000000189BD1D00-0x0000000189BD1D20
	public override void Clear() {} // 0x0000000185166DB0-0x0000000185166E60
	// [XID] // 0x0000000189BD9330-0x0000000189BD9350
	public override void Enter(AILocomotionHandler taskHandler, AIKnowledge aiKnowledge, LCAIManager aiManager) {} // 0x00000001851680A0-0x0000000185168190
	// [XID] // 0x00000001895E5EF0-0x00000001895E5F10
	public override void Leave(AILocomotionHandler taskHandler, AIKnowledge aiKnowledge, LCAIManager aiManager) {} // 0x0000000185167F00-0x0000000185167FE0
	// [XID] // 0x00000001895ED830-0x00000001895ED850
	public override void UpdateInternal(AILocomotionHandler taskHandler, AIKnowledge aiKnowledge, LCAIBeta lcai, LCAIManager aiManager) {} // 0x0000000185166E60-0x0000000185167240
	// [IDTag] // 0x00000001895F4F10-0x00000001895F4F50
	// [XID] // 0x00000001895F4F10-0x00000001895F4F50
	public static Vector3 GenerateLandingPoint(AIKnowledge knowledge) => default; // 0x0000000185167330-0x0000000185167950
	// [IDTag] // 0x00000001895FF510-0x00000001895FF550
	// [XID] // 0x00000001895FF510-0x00000001895FF550
	public static Vector3 GenerateLandingPoint(AIKnowledge knowledge, Vector3 presetLandingPoint) => default; // 0x0000000185167950-0x0000000185167C50
	// [XID] // 0x0000000189609F90-0x0000000189609FB0
	public static bool CheckTouchGround(Vector3 currentPos) => default; // 0x0000000185167C50-0x0000000185167E70
}

