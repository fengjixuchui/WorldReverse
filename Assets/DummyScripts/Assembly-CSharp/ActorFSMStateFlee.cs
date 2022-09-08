/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MihoyoOptimization;
using MoleMole;
using UnityEngine;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898422C0-0x00000001898422E0
public sealed class ActorFSMStateFlee : ActorFSMState, IAutoAllocRecycle // TypeDefIndex: 19934
{
	// Fields
	private static float FLEE_START_DELAY; // 0x00
	private NormalTimer timer; // 0x30
	private TrafficPathQueryPattern _curTrafficPattern; // 0x38

	// Constructors
	public ActorFSMStateFlee() {} // 0x0000000182C6BB50-0x0000000182C6BBB0
	static ActorFSMStateFlee() {} // 0x0000000182C6BAF0-0x0000000182C6BB50

	// Methods
	[BlackList] // 0x0000000189B75A70-0x0000000189B75AB0
	// [XID] // 0x0000000189B75A70-0x0000000189B75AB0
	public override void AutoAllocTypeFields() {} // 0x0000000182C6AC60-0x0000000182C6AD00
	[BlackList] // 0x0000000189B7FEB0-0x0000000189B7FEF0
	// [XID] // 0x0000000189B7FEB0-0x0000000189B7FEF0
	public override void AutoRecycleTypeFields() {} // 0x0000000182C6AD00-0x0000000182C6ADB0
	[BlackList] // 0x0000000189B8A630-0x0000000189B8A670
	// [XID] // 0x0000000189B8A630-0x0000000189B8A670
	public override void ReturnToObjectPool() {} // 0x0000000182C6BA50-0x0000000182C6BAF0
	// [XID] // 0x0000000189B94A30-0x0000000189B94A50
	public void Init(NpcActor actor, ActorFSMBlackBoard board) {} // 0x0000000182C6B3E0-0x0000000182C6B500
	// [XID] // 0x0000000189B9C100-0x0000000189B9C120
	public override void OnBeforePoolRecycled() {} // 0x0000000182C6B8F0-0x0000000182C6B9F0
	// [XID] // 0x0000000189BA3850-0x0000000189BA3870
	public override void Reason(float deltaTime) {} // 0x0000000182C6B500-0x0000000182C6B5B0
	// [XID] // 0x0000000189BAAC40-0x0000000189BAAC60
	public override void Act(float deltaTime) {} // 0x0000000182C6B7C0-0x0000000182C6B8F0
	// [XID] // 0x0000000189BB2230-0x0000000189BB2250
	private void StartFlee() {} // 0x0000000182C6AF60-0x0000000182C6B3E0
	// [XID] // 0x0000000189BB9600-0x0000000189BB9620
	private void OnFindTrafficPathResult(bool result, List<Vector3> resultPath) {} // 0x0000000182C6ADB0-0x0000000182C6AF00
	// [XID] // 0x0000000189BC1540-0x0000000189BC1560
	public override void DoBeforeEntering() {} // 0x0000000182C6B5B0-0x0000000182C6B6A0
}

