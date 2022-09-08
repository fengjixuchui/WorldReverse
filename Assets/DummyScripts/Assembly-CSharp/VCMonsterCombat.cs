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

public sealed class VCMonsterCombat : VCCharacterCombat // TypeDefIndex: 11902
{
	// Fields
	private VCBillboard _vcBillBoard; // 0x220

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x00000001898F8720-0x00000001898F8740 */ get => default; } // 0x00000001842F0630-0x00000001842F06D0 

	// Constructors
	public VCMonsterCombat() {} // 0x00000001842F05C0-0x00000001842F0630

	// Methods
	// [XID] // 0x0000000189B38F70-0x0000000189B38F90
	public override void Init() {} // 0x00000001842EFF40-0x00000001842F0000
	// [XID] // 0x0000000189B40B50-0x0000000189B40B70
	public override void Destroy() {} // 0x00000001842EFAC0-0x00000001842EFB70
	// [XID] // 0x0000000189B48390-0x0000000189B483B0
	protected override bool IsInDamageAnimationValidState() => default; // 0x00000001842F0180-0x00000001842F0230
	// [XID] // 0x0000000189916880-0x00000001899168A0
	public override void ChangeHP(float HP, float maxHP) {} // 0x00000001842F0380-0x00000001842F05C0
	// [XID] // 0x000000018991E050-0x000000018991E070
	public override void ChangeLevel(int level, int lastLevel, DataPropOp state = DataPropOp.Change /* Metadata: 0x00AEAE70 */) {} // 0x00000001842EF890-0x00000001842EFAC0
	// [XID] // 0x0000000189925920-0x0000000189925940
	protected override void HitAir(Vector3 retreatDir) {} // 0x00000001842EFB70-0x00000001842EFC60
	// [XID] // 0x000000018992CDF0-0x000000018992CE10
	protected override void DamgeRetreat(Vector3 retreatDir) {} // 0x00000001842EFC60-0x00000001842EFD50
	// [XID] // 0x00000001899342E0-0x0000000189934300
	public override void Die(uint killerID) {} // 0x00000001842EFDF0-0x00000001842EFF40
}

