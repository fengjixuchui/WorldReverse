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

public class VCGadgetCombat : VCHitableCombat // TypeDefIndex: 11868
{
	// Fields
	protected VCBaseMove _moveComponent; // 0x1C0
	private VCBillboard _vcBillboard; // 0x1C8
	private EntityTimer _dieDelayTimer; // 0x1D0

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x0000000189AE5EC0-0x0000000189AE5EE0 */ get => default; } // 0x0000000181C53CD0-0x0000000181C53D70 

	// Constructors
	public VCGadgetCombat() {} // 0x0000000181C53C50-0x0000000181C53CD0

	// Methods
	// [XID] // 0x0000000189AED2F0-0x0000000189AED310
	public override void PreInit() {} // 0x0000000181C53AA0-0x0000000181C53B50
	// [XID] // 0x00000001899CC3B0-0x00000001899CC3D0
	public override void Init() {} // 0x0000000181C53070-0x0000000181C53160
	// [XID] // 0x0000000189AFC2C0-0x0000000189AFC2E0
	public override void OnEntityReady() {} // 0x0000000181C53740-0x0000000181C53860
	// [XID] // 0x000000018964F850-0x000000018964F870
	protected override void Tick(float inDeltaTime) {} // 0x0000000181C53B50-0x0000000181C53C50
	// [XID] // 0x000000018967CCA0-0x000000018967CCC0
	public override void Destroy() {} // 0x0000000181C528A0-0x0000000181C52980
	// [XID] // 0x0000000189B03D10-0x0000000189B03D30
	public override void Clear(BaseEntity.ClearReason clearReason) {} // 0x0000000181C52680-0x0000000181C52770
	// [XID] // 0x0000000189684380-0x00000001896843A0
	protected override void DamgeRetreat(Vector3 retreatDir) {} // 0x0000000181C52B00-0x0000000181C52C00
	// [XID] // 0x00000001896F3590-0x00000001896F35B0
	protected override void HitAir(Vector3 retreatDir) {} // 0x0000000181C52980-0x0000000181C52A80
	// [XID] // 0x0000000189B28BE0-0x0000000189B28C00
	protected override bool ShouldRemoveIfDieEnd() => default; // 0x0000000181C52770-0x0000000181C528A0
	// [XID] // 0x0000000189B30090-0x0000000189B300B0
	public override void Die(uint killerID) {} // 0x0000000181C52EC0-0x0000000181C53070
	// [XID] // 0x00000001896E49F0-0x00000001896E4A10
	protected override void DieEnd() {} // 0x0000000181C53340-0x0000000181C53590
	// [XID] // 0x0000000189B3F210-0x0000000189B3F230
	public override void StartDieEnd(bool immediately, DieStateFlag dieStateFlag) {} // 0x0000000181C52C00-0x0000000181C52EC0
	// [XID] // 0x0000000189B46A80-0x0000000189B46AA0
	protected void RealDieEnd() {} // 0x0000000181C523D0-0x0000000181C524C0
	// [XID] // 0x00000001896BF700-0x00000001896BF720
	public override void ChangeHP(float HP, float maxHP) {} // 0x0000000181C53860-0x0000000181C53AA0
}

