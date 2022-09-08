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

public sealed class InterLookAtTask : BaseInterTask // TypeDefIndex: 20861
{
	// Fields
	private VCHumanoidHeadController _vcHeadCtrl; // 0x38

	// Properties
	private VCHumanoidHeadController vcHeadCtrl { /* [XID] */ /* 0x00000001896E5230-0x00000001896E5250 */ get => default; } // 0x000000018203A040-0x000000018203A0E0 
	public override InteractionType dataType { /* [XID] */ /* 0x00000001896F3F20-0x00000001896F3F40 */ get => default; } // 0x0000000182039900-0x00000001820399A0 

	// Constructors
	public InterLookAtTask() {} // 0x000000018203A3D0-0x000000018203A440

	// Methods
	// [XID] // 0x00000001896D64E0-0x00000001896D6500
	public static Vector3 GenTargetPos(Vector3 pos, Vector3 euler, Vector3 targetOffset) => default; // 0x00000001820396D0-0x0000000182039900
	// [XID] // 0x00000001896DDBC0-0x00000001896DDBE0
	public override void ResetObject() {} // 0x000000018203A320-0x000000018203A3D0
	// [XID] // 0x00000001896EC760-0x00000001896EC780
	private void GenHeadCtrl(BaseEntity inteeEntity) {} // 0x000000018203A0E0-0x000000018203A2A0
	// [XID] // 0x00000001896FB7B0-0x00000001896FB7D0
	protected override void DoActionInternal(BaseInterAction interAction) {} // 0x00000001820399A0-0x000000018203A040
	// [XID] // 0x0000000189702DD0-0x0000000189702DF0
	private Vector3 GenAbsoluteTargetPos(BaseEntity inteeEntity, ConfigLookAtInterAction lookAtCfg) => default; // 0x00000001820393D0-0x0000000182039600
}

