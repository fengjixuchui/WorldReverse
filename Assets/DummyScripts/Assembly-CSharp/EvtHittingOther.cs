/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class EvtHittingOther : BaseEvent, IAutoAllocRecycle, IEvtWithOtherID, IEvtWithHitCollision, IEvtWithAttackResult // TypeDefIndex: 20123
{
	// Fields
	private uint _toID; // 0x30
	private uint[] _toIDArray; // 0x38
	private AttackResult _attackResult; // 0x40
	private AttackResult[] _attackResultArray; // 0x48

	// Properties
	public bool ignoreDoHitOther { /* [XID] */ /* 0x00000001896777C0-0x0000000189677800 */ get; /* [XID] */ /* 0x0000000189794320-0x0000000189794360 */ private set; } // 0x0000000183923200-0x0000000183923260 0x0000000183923020-0x0000000183923080
	public bool ignoreCheckCanBeHitInMP { /* [XID] */ /* 0x000000018968C9C0-0x000000018968CA00 */ get; /* [XID] */ /* 0x0000000189681FB0-0x0000000189681FF0 */ private set; } // 0x0000000183923140-0x00000001839231A0 0x0000000183923080-0x00000001839230E0

	// Constructors
	public EvtHittingOther() {} // 0x00000001839234D0-0x0000000183923540

	// Methods
	[BlackList] // 0x000000018964D560-0x000000018964D5A0
	// [XID] // 0x000000018964D560-0x000000018964D5A0
	public override void AutoAllocTypeFields() {} // 0x0000000183921EA0-0x0000000183921F40
	[BlackList] // 0x0000000189657BB0-0x0000000189657BF0
	// [XID] // 0x0000000189657BB0-0x0000000189657BF0
	public override void AutoRecycleTypeFields() {} // 0x0000000183921F40-0x0000000183922070
	[BlackList] // 0x0000000189662140-0x0000000189662180
	// [XID] // 0x0000000189662140-0x0000000189662180
	public override void ReturnToObjectPool() {} // 0x0000000183923300-0x00000001839233A0
	// [IDTag] // 0x0000000189697660-0x00000001896976A0
	// [XID] // 0x0000000189697660-0x00000001896976A0
	public void Init(uint fromID, uint toID, AttackResult attackResult, bool ignoreDoHitOther, bool ignoreCheckCanBeHitInMP) {} // 0x0000000183922320-0x0000000183922500
	// [IDTag] // 0x00000001896A1AA0-0x00000001896A1AE0
	// [XID] // 0x00000001896A1AA0-0x00000001896A1AE0
	public void Init(uint fromID, uint[] toIDList, AttackResult[] attackResults, bool ignoreDoHitOther, bool ignoreCheckCanBeHitInMP) {} // 0x0000000183922500-0x00000001839226D0
	// [XID] // 0x00000001896ABCF0-0x00000001896ABD10
	public override void Clear() {} // 0x0000000183922AD0-0x0000000183922CD0
	// [XID] // 0x00000001896B2E90-0x00000001896B2EB0
	public uint GetOtherID() => default; // 0x0000000183922CD0-0x0000000183922DB0
	// [XID] // 0x00000001896BA690-0x00000001896BA6B0
	public uint[] GetOtherIDs() => default; // 0x0000000183923260-0x0000000183923300
	// [XID] // 0x00000001896C17A0-0x00000001896C17C0
	public AttackResult.HitCollsion? GetHitCollision() => default; // 0x00000001839226D0-0x0000000183922AD0
	// [XID] // 0x00000001896C8EC0-0x00000001896C8EE0
	public AttackResult GetAttackResult() => default; // 0x0000000183922DB0-0x0000000183922FC0
	// [XID] // 0x00000001896D08C0-0x00000001896D08E0
	public AttackResult[] GetAttackResults() => default; // 0x0000000183922140-0x0000000183922320
	// [XID] // 0x00000001896D7D90-0x00000001896D7DB0
	public override string ToString() => default; // 0x00000001839233A0-0x00000001839234D0
}

