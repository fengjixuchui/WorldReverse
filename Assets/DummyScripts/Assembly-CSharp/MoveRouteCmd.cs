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

public sealed class MoveRouteCmd : ActorCommand // TypeDefIndex: 20608
{
	// Fields
	public List<Vector3> targetPosList; // 0x18
	public VCMoveData.MotionFlag motionFlag; // 0x20
	public bool needDynamicAvoidance; // 0x24
	public bool exactlyMove; // 0x25

	// Constructors
	public MoveRouteCmd() {} // 0x0000000183C18930-0x0000000183C189B0

	// Methods
	// [XID] // 0x00000001896F3F80-0x00000001896F3FA0
	public static MoveRouteCmd Get(List<Vector3> targetPosList, VCMoveData.MotionFlag motionFlag, bool needDynamicAvoidance, bool exactlyMove) => default; // 0x0000000183C18750-0x0000000183C18880
	// [XID] // 0x00000001896FB850-0x00000001896FB870
	public override void ResetObject() {} // 0x0000000183C18880-0x0000000183C18930
}

