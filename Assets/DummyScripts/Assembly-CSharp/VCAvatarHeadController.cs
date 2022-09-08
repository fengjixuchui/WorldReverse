/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class VCAvatarHeadController : VCHumanoidHeadController // TypeDefIndex: 11796
{
	// Fields
	private const float ENTITY_TRIGGER_CD = 2f; // Metadata: 0x00AEABB6
	private const float LINE_CHECK_INTERVAL = 1f; // Metadata: 0x00AEABBA
	private LCTrigger _attentionTrigger; // 0x280
	private const float FAR_FAN_RANGE = 8f; // Metadata: 0x00AEABBE
	private const float FAR_FAN_HALF_ANGLE = 80f; // Metadata: 0x00AEABC2
	private const float NEAR_CIRCLE_RANGE = 2f; // Metadata: 0x00AEABC6
	private List<List<TargetData>> _targets; // 0x288
	private TargetData _forceFollowTarget; // 0x290
	private GadgetEntity dummyEntity; // 0x2C0

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x0000000189958570-0x0000000189958590 */ get => default; } // 0x0000000184FC84F0-0x0000000184FC8590 
	public bool hasTarget { /* [XID] */ /* 0x00000001895ECC00-0x00000001895ECC20 */ get => default; } // 0x0000000184FC7FA0-0x0000000184FC8050 

	// Constructors
	public VCAvatarHeadController() {} // Dummy constructor
	public VCAvatarHeadController(ConfigHeadControl config) {} // 0x0000000184FC8470-0x0000000184FC84F0

	// Methods
	// [XID] // 0x00000001895F4270-0x00000001895F4290
	public override void Init() {} // 0x0000000184FC7120-0x0000000184FC74E0
	// [XID] // 0x00000001895FBA80-0x00000001895FBAA0
	public void OnPreAnimatorInitUpdate(BaseEntity entity) {} // 0x0000000184FC5880-0x0000000184FC5970
	// [XID] // 0x0000000189603200-0x0000000189603220
	private void OnFieldEnter(BaseEntity entity) {} // 0x0000000184FC5DE0-0x0000000184FC5EF0
	// [XID] // 0x000000018960ABE0-0x000000018960AC00
	private void OnFieldExit(BaseEntity entity) {} // 0x0000000184FC5CD0-0x0000000184FC5DE0
	// [XID] // 0x00000001896121D0-0x00000001896121F0
	protected override void ClearTargets() {} // 0x0000000184FC7790-0x0000000184FC78D0
	// [XID] // 0x0000000189619B50-0x0000000189619B70
	public override void AddTarget(BaseEntity targetEntity, Transform lockPoint, TargetType type, bool becomeThreat) {} // 0x0000000184FC5970-0x0000000184FC5CD0
	// [XID] // 0x0000000189620F90-0x0000000189620FB0
	private static new EventID[] GetSelfOnEventIDsExcludingBase() => default; // 0x0000000184FC6540-0x0000000184FC6640
	// [XID] // 0x0000000189628760-0x0000000189628780
	protected override bool OnEvent(BaseEvent evt) => default; // 0x0000000184FC8230-0x0000000184FC83F0
	// [XID] // 0x0000000189630050-0x0000000189630070
	protected override bool CheckTarget(ref TargetData target) => default; // 0x0000000184FC7AE0-0x0000000184FC7D90
	// [XID] // 0x00000001899228B0-0x00000001899228D0
	private bool IsInRange(Vector3 target) => default; // 0x0000000184FC5FD0-0x0000000184FC6250
	// [XID] // 0x000000018963EF90-0x000000018963EFB0
	protected override void UpdateTarget() {} // 0x0000000184FC6640-0x0000000184FC6E80
	// [XID] // 0x00000001896468C0-0x00000001896468E0
	protected override void ForceLookForward() {} // 0x0000000184FC6FC0-0x0000000184FC70A0
	// [XID] // 0x0000000189B1E620-0x0000000189B1E640
	public override void SetCurTarget(BaseEntity entity) {} // 0x0000000184FC80B0-0x0000000184FC8190
	// [XID] // 0x0000000189B25FA0-0x0000000189B25FC0
	public override void SetLookAt(Vector3? pos) {} // 0x0000000184FC56F0-0x0000000184FC5880
	// [XID] // 0x0000000189B3BFB0-0x0000000189B3BFD0
	public override void StopForceSetLookAt() {} // 0x0000000184FC63F0-0x0000000184FC64E0
	// [XID] // 0x0000000189B43C30-0x0000000189B43C50
	protected override void UpdateTargetDir(float deltaTime) {} // 0x0000000184FC7560-0x0000000184FC7790
	// [XID] // 0x0000000189B529E0-0x0000000189B52A00
	protected override Vector3 GetLookAtPoint(ref TargetData target) => default; // 0x0000000184FC6E80-0x0000000184FC6FC0
	// [XID] // 0x0000000189B5A420-0x0000000189B5A440
	public override void Destroy() {} // 0x0000000184FC6250-0x0000000184FC63F0
	// [XID] // 0x000000018967B1A0-0x000000018967B1C0
	protected override void OnAnimatorStateChanged(EvtAnimatorStateChanged evt) {} // 0x0000000184FC78D0-0x0000000184FC7A20
}

