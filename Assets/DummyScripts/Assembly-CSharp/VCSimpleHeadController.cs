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

public abstract class VCSimpleHeadController : VCHeadController // TypeDefIndex: 11957
{
	// Fields
	protected TargetData _target; // 0x230

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x0000000189A4F0D0-0x0000000189A4F0F0 */ get; } // 0x000000018333A3A0-0x000000018333A440 

	// Constructors
	protected VCSimpleHeadController() {} // Dummy constructor
	protected VCSimpleHeadController(ConfigHeadControl config) {} // 0x000000018333A320-0x000000018333A3A0

	// Methods
	// [XID] // 0x0000000189877BA0-0x0000000189877BC0
	public override void Init() {} // 0x0000000183339B70-0x0000000183339CE0
	// [XID] // 0x000000018987F3F0-0x000000018987F410
	public override void AddTarget(BaseEntity targetEntity, Transform lockPoint, TargetType type, bool target) {} // 0x00000001833397F0-0x0000000183339900
	// [XID] // 0x0000000189886A20-0x0000000189886A40
	protected override void UpdateTarget() {} // 0x0000000183339A60-0x0000000183339B70
	// [XID] // 0x0000000189A5E2B0-0x0000000189A5E2D0
	protected override bool CheckTarget(ref TargetData target) => default; // 0x0000000183339CE0-0x0000000183339DD0
	// [XID] // 0x0000000189895260-0x0000000189895280
	protected override void LateTick(float inDeltaTime) {} // 0x0000000183339DD0-0x000000018333A210
}

