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

public sealed class VCMonsterHeadController : VCHumanoidHeadController // TypeDefIndex: 11907
{
	// Fields
	private TargetData _target; // 0x280
	private LCBaseCombat _combat; // 0x2B0
	private float _lastCheckTime; // 0x2B8

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x00000001899F30C0-0x00000001899F30E0 */ get => default; } // 0x0000000183A9BB20-0x0000000183A9BBC0 

	// Constructors
	public VCMonsterHeadController() {} // Dummy constructor
	public VCMonsterHeadController(ConfigHeadControl config) {} // 0x0000000183A9BAA0-0x0000000183A9BB20

	// Methods
	// [XID] // 0x00000001899FA770-0x00000001899FA790
	public override void PreInit() {} // 0x0000000183A9B810-0x0000000183A9B8F0
	// [XID] // 0x0000000189621070-0x0000000189621090
	public override void Init() {} // 0x0000000183A9B480-0x0000000183A9B540
	// [XID] // 0x0000000189A09470-0x0000000189A09490
	protected override void Tick(float inDeltaTime) {} // 0x0000000183A9B8F0-0x0000000183A9BAA0
	// [XID] // 0x0000000189A108C0-0x0000000189A108E0
	public override void AddTarget(BaseEntity targetEntity, Transform lockPoint, TargetType type, bool target) {} // 0x0000000183A9ABD0-0x0000000183A9ACE0
	// [XID] // 0x0000000189A17F70-0x0000000189A17F90
	protected override void UpdateTarget() {} // 0x0000000183A9B370-0x0000000183A9B480
	// [XID] // 0x0000000189661640-0x0000000189661660
	protected override bool CheckTarget(ref TargetData target) => default; // 0x0000000183A9B600-0x0000000183A9B700
	// [XID] // 0x0000000189669270-0x0000000189669290
	protected override void CheckRotDegree() {} // 0x0000000183A9ADC0-0x0000000183A9B2F0
}

