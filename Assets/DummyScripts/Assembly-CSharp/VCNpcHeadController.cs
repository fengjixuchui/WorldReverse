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

public sealed class VCNpcHeadController : VCHumanoidHeadController // TypeDefIndex: 11920
{
	// Fields
	private Vector3? _target; // 0x280
	private float _lastTime; // 0x290
	private float _lastUpdateDirTime; // 0x294
	private Vector3 _lastTargetPos; // 0x298

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x000000018963DB70-0x000000018963DB90 */ get => default; } // 0x00000001841DD710-0x00000001841DD7B0 

	// Constructors
	public VCNpcHeadController() {} // Dummy constructor
	public VCNpcHeadController(ConfigHeadControl config) {} // 0x00000001841DD690-0x00000001841DD710

	// Methods
	// [XID] // 0x0000000189A2F810-0x0000000189A2F830
	public override void PreInit() {} // 0x00000001841DD4C0-0x00000001841DD570
	// [XID] // 0x000000018964CC00-0x000000018964CC20
	public override void SetCurTarget(BaseEntity entity) {} // 0x00000001841DD370-0x00000001841DD440
	// [XID] // 0x0000000189A3E950-0x0000000189A3E970
	public override void SetLookAt(Vector3? pos) {} // 0x00000001841DC8C0-0x00000001841DC980
	// [XID] // 0x0000000189A46040-0x0000000189A46060
	public override void StopForceSetLookAt() {} // 0x00000001841DCB70-0x00000001841DCC50
	// [XID] // 0x0000000189A4D750-0x0000000189A4D770
	protected override void OnAnimatorStateChanged(EvtAnimatorStateChanged evt) {} // 0x00000001841DD030-0x00000001841DD150
	// [XID] // 0x000000018966A910-0x000000018966A930
	private void CheckEnableHeadControl(bool enabled) {} // 0x00000001841DCA00-0x00000001841DCAF0
	// [XID] // 0x0000000189A5C900-0x0000000189A5C920
	protected override void Tick(float inDeltaTime) {} // 0x00000001841DD570-0x00000001841DD690
	// [XID] // 0x0000000189A641D0-0x0000000189A641F0
	protected override bool CheckTarget(ref TargetData target) => default; // 0x00000001841DD1B0-0x00000001841DD280
	// [XID] // 0x0000000189A6BB80-0x0000000189A6BBA0
	protected override void UpdateTargetDir(float deltaTime) {} // 0x00000001841DCDB0-0x00000001841DD030
}

