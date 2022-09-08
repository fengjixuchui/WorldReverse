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
public class UnlockSkill : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16615
{
	// Fields
	private SimpleSafeUInt32 skillIDRawNum; // 0x68

	// Properties
	public uint skillID { /* [XID] */ /* 0x00000001895EDC70-0x00000001895EDC90 */ get => default; /* [XID] */ /* 0x00000001895F54F0-0x00000001895F5510 */ private set {} } // 0x0000000182C28A70-0x0000000182C28B40 0x0000000182C29930-0x0000000182C29A10
	protected override bool MuteAuthority { /* [XID] */ /* 0x0000000189680F20-0x0000000189680F40 */ get => default; } // 0x0000000182C29470-0x0000000182C29510 
	protected override bool MuteRemote { /* [XID] */ /* 0x0000000189688920-0x0000000189688940 */ get => default; } // 0x0000000182C289D0-0x0000000182C28A70 

	// Constructors
	public UnlockSkill() {} // 0x0000000182C29C40-0x0000000182C29CA0

	// Methods
	// [XID] // 0x00000001895FCA50-0x00000001895FCA70
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000182C29A10-0x0000000182C29B00
	// [XID] // 0x0000000189604470-0x0000000189604490
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000182C29570-0x0000000182C29620
	// [XID] // 0x000000018960BD60-0x000000018960BD80
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF40EA */) => default; // 0x0000000182C290E0-0x0000000182C291C0
	// [XID] // 0x0000000189613300-0x0000000189613320
	public override int GetHashNum() => default; // 0x0000000182C27C60-0x0000000182C27D30
	// [XID] // 0x000000018961AB60-0x000000018961AB80
	public override void InitEmpty() {} // 0x0000000182C28B40-0x0000000182C28C10
	[BlackList] // 0x0000000189622140-0x0000000189622180
	// [XID] // 0x0000000189622140-0x0000000189622180
	public override bool FromJson(JSONNode node) => default; // 0x0000000182C28350-0x0000000182C286D0
	// [XID] // 0x000000018962C7B0-0x000000018962C7D0
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000182C27420-0x0000000182C27680
	[BlackList] // 0x0000000189634490-0x00000001896344D0
	// [XID] // 0x0000000189634490-0x00000001896344D0
	public static new UnlockSkill ParseFromJson(JSONNode node) => default; // 0x0000000182C29220-0x0000000182C29470
	// [XID] // 0x000000018963EAA0-0x000000018963EAC0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF40EB */, bool useObjectPool = false /* Metadata: 0x00AF40EF */) => default; // 0x0000000182C28DE0-0x0000000182C290E0
	// [XID] // 0x0000000189646200-0x0000000189646220
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF40F0 */, bool useObjectPool = false /* Metadata: 0x00AF40F4 */) => default; // 0x0000000182C27E80-0x0000000182C280F0
	// [XID] // 0x000000018964DA00-0x000000018964DA20
	public static new UnlockSkill ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF40F5 */, bool useObjectPool = false /* Metadata: 0x00AF40F9 */) => default; // 0x0000000182C286D0-0x0000000182C288F0
	[BlackList] // 0x0000000189655180-0x00000001896551C0
	// [XID] // 0x0000000189655180-0x00000001896551C0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000182C27680-0x0000000182C27950
	// [XID] // 0x000000018965F760-0x000000018965F780
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000182C29700-0x0000000182C29930
	[BlackList] // 0x00000001896671D0-0x0000000189667210
	// [XID] // 0x00000001896671D0-0x0000000189667210
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000182C28CF0-0x0000000182C28DE0
	// [XID] // 0x0000000189671F20-0x0000000189671F40
	public override bool isAlreadyHandledRecoverCase() => default; // 0x0000000182C29B00-0x0000000182C29BA0
	// [XID] // 0x00000001896797B0-0x00000001896797D0
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x0000000182C280F0-0x0000000182C28250
	[BlackList] // 0x0000000189690320-0x0000000189690360
	// [XID] // 0x0000000189690320-0x0000000189690360
	public override void AutoAllocTypeFields() {} // 0x0000000182C27950-0x0000000182C279F0
	[BlackList] // 0x000000018969A750-0x000000018969A790
	// [XID] // 0x000000018969A750-0x000000018969A790
	public override void AutoRecycleTypeFields() {} // 0x0000000182C279F0-0x0000000182C27AD0
	[BlackList] // 0x00000001896A4B20-0x00000001896A4B60
	// [XID] // 0x00000001896A4B20-0x00000001896A4B60
	public override void ReturnToObjectPool() {} // 0x0000000182C29BA0-0x0000000182C29C40
}

