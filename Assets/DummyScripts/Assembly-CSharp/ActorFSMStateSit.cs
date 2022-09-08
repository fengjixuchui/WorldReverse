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
public sealed class ActorFSMStateSit : ActorFSMState, IAutoAllocRecycle // TypeDefIndex: 19940
{
	// Fields
	private const float performDurationMin = 5f; // Metadata: 0x00AFD0F6
	private const float performStandupDuration = 2f; // Metadata: 0x00AFD0FA
	private const float sitRetryDuration = 2f; // Metadata: 0x00AFD0FE
	private IChair myChair; // 0x30
	private int myChairIndex; // 0x38
	public const float sitDistanceMax = 2f; // Metadata: 0x00AFD102
	private const float sitDistanceMin = 0.005f; // Metadata: 0x00AFD106
	private const float sitEnteringSpeed = 3f; // Metadata: 0x00AFD10A
	private Vector3 sitPosition; // 0x3C
	private Quaternion sitRotation; // 0x48
	private bool _setGroundFollow; // 0x58
	private NormalTimer timer; // 0x60
	private static Vector3 sitColOffset; // 0x00
	// [PooledField] // 0x00000001897FDA20-0x00000001897FDA40
	private Dictionary<CapsuleCollider, Vector3> originalColliderCenter; // 0x68
	private static int[] _sitLoopStateNameHash; // 0x10
	private SubState subState; // 0x70
	private int curPerformId; // 0x74

	// Nested types
	private enum SubState // TypeDefIndex: 19941
	{
		None = 0,
		SitRetry = 1,
		PerformSitting = 2,
		SittingWithTime = 3,
		Sitting = 4,
		StandingUp = 5
	}

	// Constructors
	public ActorFSMStateSit() {} // 0x00000001833928C0-0x0000000183392930
	static ActorFSMStateSit() {} // 0x0000000183392790-0x00000001833928C0

	// Methods
	[BlackList] // 0x0000000189775B40-0x0000000189775B80
	// [XID] // 0x0000000189775B40-0x0000000189775B80
	public override void AutoAllocTypeFields() {} // 0x000000018338F500-0x000000018338F5D0
	[BlackList] // 0x0000000189780260-0x00000001897802A0
	// [XID] // 0x0000000189780260-0x00000001897802A0
	public override void AutoRecycleTypeFields() {} // 0x000000018338F5D0-0x000000018338F6D0
	[BlackList] // 0x000000018978AA00-0x000000018978AA40
	// [XID] // 0x000000018978AA00-0x000000018978AA40
	public override void ReturnToObjectPool() {} // 0x00000001833926F0-0x0000000183392790
	// [XID] // 0x0000000189794F00-0x0000000189794F20
	public void Init(NpcActor actor, ActorFSMBlackBoard board) {} // 0x0000000183390B90-0x0000000183390DA0
	// [XID] // 0x000000018979D3D0-0x000000018979D3F0
	public override void OnBeforePoolRecycled() {} // 0x0000000183392190-0x0000000183392270
	// [XID] // 0x00000001897A4650-0x00000001897A4670
	public override void Reason(float deltaTime) {} // 0x0000000183390EB0-0x00000001833910E0
	// [XID] // 0x00000001897ABB60-0x00000001897ABB80
	public void TryStandUp() {} // 0x0000000183390A80-0x0000000183390B90
	// [XID] // 0x00000001897B3B80-0x00000001897B3BA0
	private bool IsSitFreeStyle(int performAnimID) => default; // 0x000000018338F3F0-0x000000018338F500
	// [XID] // 0x00000001897BB950-0x00000001897BB970
	public override void Act(float deltaTime) {} // 0x0000000183391AE0-0x0000000183392130
	// [XID] // 0x00000001897C3230-0x00000001897C3250
	private int GetPerformAnimID() => default; // 0x0000000183391490-0x00000001833915E0
	// [XID] // 0x00000001897CAA10-0x00000001897CAA30
	private float GetSitPerformingTime() => default; // 0x00000001833904A0-0x00000001833905A0
	// [XID] // 0x00000001897D1FF0-0x00000001897D2010
	private bool ShouldSitOnGround(int performAnimID) => default; // 0x0000000183390DA0-0x0000000183390EB0
	// [XID] // 0x00000001897D9E70-0x00000001897D9E90
	private void TrySit() {} // 0x0000000183390060-0x0000000183390140
	// [XID] // 0x00000001897E1140-0x00000001897E1160
	private void EnterSiting() {} // 0x0000000183391190-0x00000001833912A0
	// [XID] // 0x00000001897E8970-0x00000001897E8990
	public override void DoBeforeEntering() {} // 0x00000001833910E0-0x0000000183391190
	// [XID] // 0x00000001897F0540-0x00000001897F0560
	public override void DoBeforeLeaving() {} // 0x000000018338F310-0x000000018338F3F0
	// [XID] // 0x00000001897F7CB0-0x00000001897F7CD0
	private bool IsCanPerformSitting() => default; // 0x00000001833905A0-0x0000000183390730
	// [XID] // 0x00000001897FF330-0x00000001897FF350
	private bool PerformSit(int performAnimID) => default; // 0x000000018338F6D0-0x000000018338FF40
	// [XID] // 0x0000000189806AF0-0x0000000189806B10
	private void PerformStandup() {} // 0x0000000183390790-0x0000000183390A80
	// [XID] // 0x000000018980E230-0x000000018980E250
	private void AdjustColliderPosition(bool useSitCol) {} // 0x00000001833922D0-0x00000001833926F0
	// [XID] // 0x0000000189815990-0x00000001898159B0
	public override void OnDestroy() {} // 0x0000000183390140-0x00000001833904A0
	// [XID] // 0x000000018981D2E0-0x000000018981D300
	public override void OnHide() {} // 0x0000000183391A30-0x0000000183391AE0
	// [XID] // 0x00000001898247C0-0x00000001898247E0
	public override void OnShow() {} // 0x00000001833912A0-0x0000000183391350
	// [XID] // 0x000000018982C290-0x000000018982C2B0
	public override void OnEntityRuntimeIdChange(uint oldId, uint newId) {} // 0x00000001833917A0-0x00000001833918F0
	// [XID] // 0x0000000189833720-0x0000000189833740
	private void SetSit(bool isSit) {} // 0x0000000183391660-0x00000001833917A0
	// [XID] // 0x000000018983AC60-0x000000018983AC80
	public override ActorFSMStateID GetOutputState(ActorFSMTransition trans) => default; // 0x00000001833918F0-0x00000001833919D0
}

