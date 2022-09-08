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

public sealed class VCAvatarMoveToTask : VCBase // TypeDefIndex: 11798
{
	// Fields
	private bool _isInMoveTo; // 0x108
	private int _currMoveIndex; // 0x10C
	private MoveToState _state; // 0x110
	private VCMoveData.MotionFlag _motionFlag; // 0x114
	private AvatarMoveToTask _currMoveTask; // 0x118
	private List<Vector3> _routeList; // 0x120

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x00000001896EA6C0-0x00000001896EA6E0 */ get => default; } // 0x00000001811FE9E0-0x00000001811FEA80 

	// Nested types
	private enum MoveToState // TypeDefIndex: 11799
	{
		Inactive = 0,
		Moving = 1,
		Finish = 2
	}

	// Constructors
	public VCAvatarMoveToTask() {} // 0x00000001811FE950-0x00000001811FE9E0

	// Methods
	// [XID] // 0x000000018965D220-0x000000018965D240
	protected override void Tick(float inDeltaTime) {} // 0x00000001811FE6B0-0x00000001811FE950
	// [XID] // 0x00000001896F9080-0x00000001896F90A0
	public void StartMoveToTask(List<Vector3> routeList, VCMoveData.MotionFlag motionFlag) {} // 0x00000001811FE3B0-0x00000001811FE540
	// [XID] // 0x0000000189700A70-0x0000000189700A90
	public void StopCurrentMoveToTask() {} // 0x00000001811FE540-0x00000001811FE610
	// [XID] // 0x0000000189708100-0x0000000189708120
	public override void OnDisable() {} // 0x00000001811FE610-0x00000001811FE6B0
}

