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
public class SetAvatarCanShakeOff : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16689
{
	// Fields
	private bool _canShakeOff; // 0x68

	// Properties
	public bool canShakeOff { /* [XID] */ /* 0x00000001896280D0-0x00000001896280F0 */ get => default; /* [XID] */ /* 0x000000018962F920-0x000000018962F940 */ private set {} } // 0x00000001821600F0-0x0000000182160190 0x00000001821606D0-0x0000000182160780
	protected override bool MuteAuthority { /* [XID] */ /* 0x00000001896BAD30-0x00000001896BAD50 */ get => default; } // 0x0000000182160520-0x00000001821605C0 
	protected override bool MuteRemote { /* [XID] */ /* 0x00000001896C1E60-0x00000001896C1E80 */ get => default; } // 0x000000018215FAD0-0x000000018215FB70 

	// Constructors
	public SetAvatarCanShakeOff() {} // 0x0000000182160C90-0x0000000182160CF0

	// Methods
	// [XID] // 0x00000001896374C0-0x00000001896374E0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000182160A60-0x0000000182160B50
	// [XID] // 0x000000018963EA80-0x000000018963EAA0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000182160620-0x00000001821606D0
	// [XID] // 0x00000001896461E0-0x0000000189646200
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF432E */) => default; // 0x0000000182160190-0x0000000182160270
	// [XID] // 0x000000018964D9E0-0x000000018964DA00
	public override int GetHashNum() => default; // 0x000000018215EDA0-0x000000018215EE70
	// [XID] // 0x0000000189655160-0x0000000189655180
	public override void InitEmpty() {} // 0x000000018215FB70-0x000000018215FC10
	[BlackList] // 0x000000018965CA20-0x000000018965CA60
	// [XID] // 0x000000018965CA20-0x000000018965CA60
	public override bool FromJson(JSONNode node) => default; // 0x000000018215F450-0x000000018215F7D0
	// [XID] // 0x00000001896671B0-0x00000001896671D0
	private new bool InternalFromJson(JSONNode node) => default; // 0x000000018215E5F0-0x000000018215E7F0
	[BlackList] // 0x000000018966E980-0x000000018966E9C0
	// [XID] // 0x000000018966E980-0x000000018966E9C0
	public static new SetAvatarCanShakeOff ParseFromJson(JSONNode node) => default; // 0x00000001821602D0-0x0000000182160520
	// [XID] // 0x0000000189679770-0x0000000189679790
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF432F */, bool useObjectPool = false /* Metadata: 0x00AF4333 */) => default; // 0x000000018215FDF0-0x00000001821600F0
	// [XID] // 0x0000000189680EE0-0x0000000189680F00
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF4334 */, bool useObjectPool = false /* Metadata: 0x00AF4338 */) => default; // 0x000000018215EFC0-0x000000018215F1F0
	// [XID] // 0x00000001896888C0-0x00000001896888E0
	public static new SetAvatarCanShakeOff ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF4339 */, bool useObjectPool = false /* Metadata: 0x00AF433D */) => default; // 0x000000018215F7D0-0x000000018215F9F0
	[BlackList] // 0x00000001896902E0-0x0000000189690320
	// [XID] // 0x00000001896902E0-0x0000000189690320
	public override bool ToBinary(ByteArray byteArray) => default; // 0x000000018215E7F0-0x000000018215EAC0
	// [XID] // 0x000000018969A6F0-0x000000018969A710
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000182160860-0x0000000182160A60
	[BlackList] // 0x00000001896A20A0-0x00000001896A20E0
	// [XID] // 0x00000001896A20A0-0x00000001896A20E0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x000000018215FCF0-0x000000018215FDF0
	// [XID] // 0x00000001896AC310-0x00000001896AC330
	public override bool isAlreadyHandledRecoverCase() => default; // 0x0000000182160B50-0x0000000182160BF0
	// [XID] // 0x00000001896B3610-0x00000001896B3630
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x000000018215F1F0-0x000000018215F350
	[BlackList] // 0x00000001896C9490-0x00000001896C94D0
	// [XID] // 0x00000001896C9490-0x00000001896C94D0
	public override void AutoAllocTypeFields() {} // 0x000000018215EAC0-0x000000018215EB60
	[BlackList] // 0x00000001896D3860-0x00000001896D38A0
	// [XID] // 0x00000001896D3860-0x00000001896D38A0
	public override void AutoRecycleTypeFields() {} // 0x000000018215EB60-0x000000018215EC10
	[BlackList] // 0x00000001896DE1E0-0x00000001896DE220
	// [XID] // 0x00000001896DE1E0-0x00000001896DE220
	public override void ReturnToObjectPool() {} // 0x0000000182160BF0-0x0000000182160C90
}

