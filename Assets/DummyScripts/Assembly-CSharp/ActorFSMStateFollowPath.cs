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
public sealed class ActorFSMStateFollowPath : ActorFSMState, IAutoAllocRecycle // TypeDefIndex: 19935
{
	// Fields
	private LCAIBeta aiBeta; // 0x30
	private bool finalPointArrived; // 0x38
	private Vector3 moveTarget; // 0x3C
	private static float ONSPOT_RADIUS; // 0x00

	// Constructors
	public ActorFSMStateFollowPath() {} // 0x000000018136EE80-0x000000018136EEF0
	static ActorFSMStateFollowPath() {} // 0x000000018136EE20-0x000000018136EE80

	// Methods
	[BlackList] // 0x0000000189BD0440-0x0000000189BD0480
	// [XID] // 0x0000000189BD0440-0x0000000189BD0480
	public override void AutoAllocTypeFields() {} // 0x000000018136DA50-0x000000018136DAF0
	[BlackList] // 0x0000000189BDAC60-0x0000000189BDACA0
	// [XID] // 0x0000000189BDAC60-0x0000000189BDACA0
	public override void AutoRecycleTypeFields() {} // 0x000000018136DAF0-0x000000018136DBB0
	[BlackList] // 0x00000001895EA9F0-0x00000001895EAA30
	// [XID] // 0x00000001895EA9F0-0x00000001895EAA30
	public override void ReturnToObjectPool() {} // 0x000000018136ED80-0x000000018136EE20
	// [XID] // 0x00000001895F5050-0x00000001895F5070
	public void Init(NpcActor actor, ActorFSMBlackBoard board) {} // 0x000000018136DDB0-0x000000018136DF90
	// [XID] // 0x00000001895FC610-0x00000001895FC630
	public override void OnDestroy() {} // 0x000000018136DC10-0x000000018136DD50
	// [XID] // 0x0000000189603F90-0x0000000189603FB0
	public override void Reason(float deltaTime) {} // 0x000000018136DF90-0x000000018136E040
	// [XID] // 0x000000018960B8F0-0x000000018960B910
	public override void Act(float deltaTime) {} // 0x000000018136EA30-0x000000018136ED20
	// [XID] // 0x0000000189612E80-0x0000000189612EA0
	private bool IsArrived(Vector3 targetPos) => default; // 0x000000018136E310-0x000000018136E680
	// [XID] // 0x000000018961A5E0-0x000000018961A600
	private void OnMoveEnd(ScriptedMoveToInfo.ReachPointState state, int middlePointIndex) {} // 0x000000018136E960-0x000000018136EA30
	// [XID] // 0x0000000189621B40-0x0000000189621B60
	private void OnFinalPointArrived() {} // 0x000000018136E250-0x000000018136E310
	// [XID] // 0x00000001896294D0-0x00000001896294F0
	private void ProcessWalk(List<Vector3> targetRoute) {} // 0x000000018136E6E0-0x000000018136E8A0
	// [XID] // 0x0000000189630DC0-0x0000000189630DE0
	public override void DoBeforeEntering() {} // 0x000000018136E040-0x000000018136E250
	// [XID] // 0x00000001896388C0-0x00000001896388E0
	public override void DoBeforeLeaving() {} // 0x000000018136D900-0x000000018136DA50
}

