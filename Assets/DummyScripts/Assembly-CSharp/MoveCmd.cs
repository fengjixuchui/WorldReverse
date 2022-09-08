/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class MoveCmd : ActorCommand // TypeDefIndex: 20607
{
	// Fields
	public Vector3 targetPos; // 0x18
	public VCMoveData.MotionFlag motionFlag; // 0x24
	public bool isMoving; // 0x28

	// Constructors
	public MoveCmd() {} // 0x0000000184ACD4F0-0x0000000184ACD570

	// Methods
	// [XID] // 0x00000001898B2DE0-0x00000001898B2E00
	public static MoveCmd Get(Vector3 targetPos, VCMoveData.MotionFlag motionFlag, bool isMoving) => default; // 0x0000000184ACD2D0-0x0000000184ACD410
	// [XID] // 0x00000001896EC7A0-0x00000001896EC7C0
	public override void ResetObject() {} // 0x0000000184ACD410-0x0000000184ACD4F0
}

