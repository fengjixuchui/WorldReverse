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

public sealed class GoToTask : LocoBaseTask // TypeDefIndex: 20482
{
	// Fields
	private GoToTaskState _innerState; // 0x68
	private bool _scripted; // 0x6C
	private PathQueryTask _pathQuery; // 0x70
	private bool _useNavMesh; // 0x78
	private bool _spacial; // 0x79
	private bool _spacialRoll; // 0x7A
	private float _getCloseDistance; // 0x7C
	private float _stayCloseOverTime; // 0x80
	private bool _isInCloseDistance; // 0x84
	private float _enterCloseDistanceTime; // 0x88
	private bool _exactlyMove; // 0x8C

	// Nested types
	private enum GoToTaskState // TypeDefIndex: 20483
	{
		QueryPathfinder = 0,
		WaitPathfinder = 1,
		Moving = 2
	}

	// Constructors
	public GoToTask() {} // 0x00000001830E4940-0x00000001830E4A00

	// Methods
	// [XID] // 0x00000001896F3FA0-0x00000001896F3FC0
	public override void Deallocate() {} // 0x00000001830E3330-0x00000001830E33D0
	// [XID] // 0x00000001896FB870-0x00000001896FB890
	public void Init(AIKnowledge knowledge, bool useNavMesh, AILocomotionHandler.ParamGoTo param) {} // 0x00000001830E45F0-0x00000001830E4770
	// [XID] // 0x0000000189702E50-0x0000000189702E70
	public override bool NeedPathfinder() => default; // 0x00000001830E48A0-0x00000001830E4940
	// [XID] // 0x000000018970A500-0x000000018970A520
	public override void ShowPath() {} // 0x00000001830E33D0-0x00000001830E3500
	// [XID] // 0x0000000189712010-0x0000000189712030
	public override void RefreshTask(AILocomotionHandler handler, Vector3 positoin) {} // 0x00000001830E4770-0x00000001830E48A0
	// [XID] // 0x00000001897195B0-0x00000001897195D0
	public override void UpdateLoco(AILocomotionHandler handler, AITransform currentTransform, ref LocoTaskState state, float deltaTime) {} // 0x00000001830E3500-0x00000001830E45F0
}

