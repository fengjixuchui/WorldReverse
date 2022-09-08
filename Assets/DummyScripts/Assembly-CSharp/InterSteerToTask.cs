/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;
using MoleMole.Config;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class InterSteerToTask : BaseInterTask // TypeDefIndex: 20859
{
	// Fields
	private Vector3 _originSteer; // 0x38
	private Vector3 _steerTarget; // 0x44
	private VCBaseMove _moveComponent; // 0x50
	private LCAIBeta _ai; // 0x58
	private bool _forceSteer; // 0x60
	private bool _useSteerAnim; // 0x61

	// Properties
	public override InteractionType dataType { /* [XID] */ /* 0x0000000189666970-0x0000000189666990 */ get => default; } // 0x000000018321ECC0-0x000000018321ED60 

	// Constructors
	public InterSteerToTask() {} // 0x0000000183220000-0x00000001832200D0

	// Methods
	// [XID] // 0x0000000189657A90-0x0000000189657AB0
	public override void ResetObject() {} // 0x000000018321FEF0-0x0000000183220000
	// [XID] // 0x000000018965F1C0-0x000000018965F1E0
	public void InitOriginSteer(BaseEntity entity, InteeShareTaskData shareData, bool force = false /* Metadata: 0x00AFE6DE */) {} // 0x000000018321E700-0x000000018321E810
	// [XID] // 0x000000018966E070-0x000000018966E090
	private bool GenSteerDir(BaseEntity inteeEntity, BaseEntity interEntity, ConfigSteerInterAction cfg, out Vector3 dir) {
		dir = default;
		return default;
	} // 0x000000018321F110-0x000000018321FB50
	// [XID] // 0x0000000189675EE0-0x0000000189675F00
	private void StopSteer() {} // 0x000000018321FBD0-0x000000018321FC90
	// [XID] // 0x000000018967D780-0x000000018967D7A0
	protected override void DoActionInternal(BaseInterAction interAction) {} // 0x000000018321ED60-0x000000018321F110
	// [XID] // 0x0000000189684D80-0x0000000189684DA0
	public override void Tick() {} // 0x000000018321E810-0x000000018321E8B0
	// [XID] // 0x000000018968C8A0-0x000000018968C8C0
	private void TickSteer() {} // 0x000000018321E910-0x000000018321EC50
	// [XID] // 0x00000001896943D0-0x00000001896943F0
	private void Steer(BaseEntity inteeEntity, Vector3 steerTarget) {} // 0x000000018321E580-0x000000018321E6A0
	// [XID] // 0x000000018969B970-0x000000018969B990
	private void PlaySteerAnimation(BaseEntity inteeEntity, Vector3 dir, bool interrupt) {} // 0x000000018321FC90-0x000000018321FEF0
}

