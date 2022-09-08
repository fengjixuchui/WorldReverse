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

public class ControlPart // TypeDefIndex: 32196
{
	// Fields
	public ConfigControlPart config; // 0x10
	public BaseEntity _entity; // 0x18
	public ControlPartTargetType targetType; // 0x20
	public Transform rootTrans; // 0x28
	protected Transform _centerTrans; // 0x30
	protected Vector3 _centerForward; // 0x38
	protected Vector3 _targetForward; // 0x44
	public Vector3? targetPoint; // 0x50
	protected Vector3 _calcedEular; // 0x60
	protected Vector3 _fwdAxialFix; // 0x6C

	// Properties
	public bool isEnabled { /* [XID] */ /* 0x00000001896C5A60-0x00000001896C5AA0 */ get; /* [XID] */ /* 0x00000001896D01C0-0x00000001896D0200 */ protected set; } // 0x0000000182B74E20-0x0000000182B74E80 0x0000000182B74170-0x0000000182B741D0

	// Constructors
	public ControlPart() {} // 0x0000000182B75350-0x0000000182B753C0

	// Methods
	// [XID] // 0x00000001896DA760-0x00000001896DA780
	public virtual void Init() {} // 0x0000000182B74270-0x0000000182B744D0
	// [XID] // 0x0000000189A733C0-0x0000000189A733E0
	public virtual void Tick() {} // 0x0000000182B744D0-0x0000000182B74570
	// [XID] // 0x0000000189AB6BB0-0x0000000189AB6BD0
	public void LateTick(float deltaTime) {} // 0x0000000182B74E80-0x0000000182B75060
	// [XID] // 0x00000001896F06C0-0x00000001896F06E0
	public virtual void Destory() {} // 0x0000000182B741D0-0x0000000182B74270
	// [XID] // 0x00000001899B7160-0x00000001899B7180
	public virtual void SetEnabled(bool enable) {} // 0x0000000182B74570-0x0000000182B746C0
	// [XID] // 0x0000000189919A80-0x0000000189919AA0
	private void CenterPoint() {} // 0x0000000182B75060-0x0000000182B75350
	// [XID] // 0x0000000189706DC0-0x0000000189706DE0
	protected virtual void LookToPoint() {} // 0x0000000182B74860-0x0000000182B74AA0
	// [XID] // 0x000000018970E6A0-0x000000018970E6C0
	protected void CalcDoRotate() {} // 0x0000000182B74AA0-0x0000000182B74E20
	// [XID] // 0x0000000189A3EAB0-0x0000000189A3EAD0
	protected virtual void DoRotate(float degreesDelta) {} // 0x0000000182B746C0-0x0000000182B74860
}

