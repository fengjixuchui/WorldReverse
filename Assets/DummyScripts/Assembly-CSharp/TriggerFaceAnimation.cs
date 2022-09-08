/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MihoyoOptimization;
using MoleMole;
using SimpleJSON;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class TriggerFaceAnimation : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16545
{
	// Fields
	private string _faceAnimation; // 0x68

	// Properties
	public string faceAnimation { /* [XID] */ /* 0x0000000189617870-0x0000000189617890 */ get => default; /* [XID] */ /* 0x000000018961F4A0-0x000000018961F4C0 */ private set {} } // 0x0000000183A826D0-0x0000000183A82770 0x0000000183A80CF0-0x0000000183A80DA0
	protected override bool MuteAuthority { /* [XID] */ /* 0x00000001896AAA90-0x00000001896AAAB0 */ get => default; } // 0x0000000183A82410-0x0000000183A824B0 
	protected override bool MuteRemote { /* [XID] */ /* 0x00000001896B1A10-0x00000001896B1A30 */ get => default; } // 0x0000000183A81A40-0x0000000183A81AE0 

	// Constructors
	public TriggerFaceAnimation() {} // 0x0000000183A82BA0-0x0000000183A82C00

	// Methods
	// [XID] // 0x00000001896268C0-0x00000001896268E0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000183A82970-0x0000000183A82A60
	// [XID] // 0x000000018962E0D0-0x000000018962E0F0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000183A82510-0x0000000183A825F0
	// [XID] // 0x0000000189635DB0-0x0000000189635DD0
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF3EC6 */) => default; // 0x0000000183A82080-0x0000000183A82160
	// [XID] // 0x000000018963D4F0-0x000000018963D510
	public override int GetHashNum() => default; // 0x0000000183A80C20-0x0000000183A80CF0
	// [XID] // 0x0000000189644AB0-0x0000000189644AD0
	public override void InitEmpty() {} // 0x0000000183A81AE0-0x0000000183A81BB0
	[BlackList] // 0x000000018964C2B0-0x000000018964C2F0
	// [XID] // 0x000000018964C2B0-0x000000018964C2F0
	public override bool FromJson(JSONNode node) => default; // 0x0000000183A813C0-0x0000000183A81740
	// [XID] // 0x00000001896568D0-0x00000001896568F0
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000183A80440-0x0000000183A80670
	[BlackList] // 0x000000018965DFD0-0x000000018965E010
	// [XID] // 0x000000018965DFD0-0x000000018965E010
	public static new TriggerFaceAnimation ParseFromJson(JSONNode node) => default; // 0x0000000183A821C0-0x0000000183A82410
	// [XID] // 0x0000000189668A20-0x0000000189668A40
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3EC7 */, bool useObjectPool = false /* Metadata: 0x00AF3ECB */) => default; // 0x0000000183A81D80-0x0000000183A82080
	// [XID] // 0x00000001896705F0-0x0000000189670610
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3ECC */, bool useObjectPool = false /* Metadata: 0x00AF3ED0 */) => default; // 0x0000000183A80EF0-0x0000000183A81160
	// [XID] // 0x0000000189677E10-0x0000000189677E30
	public static new TriggerFaceAnimation ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3ED1 */, bool useObjectPool = false /* Metadata: 0x00AF3ED5 */) => default; // 0x0000000183A81740-0x0000000183A81960
	[BlackList] // 0x000000018967F340-0x000000018967F380
	// [XID] // 0x000000018967F340-0x000000018967F380
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000183A80670-0x0000000183A80940
	// [XID] // 0x0000000189689E50-0x0000000189689E70
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000183A82770-0x0000000183A82970
	[BlackList] // 0x0000000189691C10-0x0000000189691C50
	// [XID] // 0x0000000189691C10-0x0000000189691C50
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000183A81C90-0x0000000183A81D80
	// [XID] // 0x000000018969C180-0x000000018969C1A0
	public override bool isAlreadyHandledRecoverCase() => default; // 0x0000000183A82A60-0x0000000183A82B00
	// [XID] // 0x00000001896A35E0-0x00000001896A3600
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x0000000183A81160-0x0000000183A812C0
	[BlackList] // 0x00000001896B9410-0x00000001896B9450
	// [XID] // 0x00000001896B9410-0x00000001896B9450
	public override void AutoAllocTypeFields() {} // 0x0000000183A80940-0x0000000183A809E0
	[BlackList] // 0x00000001896C37E0-0x00000001896C3820
	// [XID] // 0x00000001896C37E0-0x00000001896C3820
	public override void AutoRecycleTypeFields() {} // 0x0000000183A809E0-0x0000000183A80A90
	[BlackList] // 0x00000001896CDEF0-0x00000001896CDF30
	// [XID] // 0x00000001896CDEF0-0x00000001896CDF30
	public override void ReturnToObjectPool() {} // 0x0000000183A82B00-0x0000000183A82BA0
}

