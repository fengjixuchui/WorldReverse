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
public class FireMonsterBeingHitAfterImage : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16383
{
	// Fields
	private SimpleSafeUInt32 effectIndexRawNum; // 0x68

	// Properties
	public uint effectIndex { /* [XID] */ /* 0x00000001896D6BE0-0x00000001896D6C00 */ get => default; /* [XID] */ /* 0x00000001896DE2C0-0x00000001896DE2E0 */ private set {} } // 0x0000000184EA4D90-0x0000000184EA4E60 0x0000000184EA6080-0x0000000184EA6160
	protected override bool MuteAuthority { /* [XID] */ /* 0x00000001897616D0-0x00000001897616F0 */ get => default; } // 0x0000000184EA63B0-0x0000000184EA6450 
	protected override bool MuteRemote { /* [XID] */ /* 0x0000000189768A00-0x0000000189768A20 */ get => default; } // 0x0000000184EA5900-0x0000000184EA59A0 

	// Constructors
	public FireMonsterBeingHitAfterImage() {} // 0x0000000184EA6A00-0x0000000184EA6A90

	// Methods
	// [XID] // 0x00000001896E57D0-0x00000001896E57F0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000184EA6870-0x0000000184EA6960
	// [XID] // 0x00000001896ECE60-0x00000001896ECE80
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000184EA64B0-0x0000000184EA6560
	// [XID] // 0x00000001896F46A0-0x00000001896F46C0
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF39BC */) => default; // 0x0000000184EA5F40-0x0000000184EA6020
	// [XID] // 0x00000001896FBED0-0x00000001896FBEF0
	public override int GetHashNum() => default; // 0x0000000184EA4B70-0x0000000184EA4C40
	// [XID] // 0x00000001897033D0-0x00000001897033F0
	public override void InitEmpty() {} // 0x0000000184EA59A0-0x0000000184EA5A70
	[BlackList] // 0x000000018970AAC0-0x000000018970AB00
	// [XID] // 0x000000018970AAC0-0x000000018970AB00
	public override bool FromJson(JSONNode node) => default; // 0x0000000184EA52F0-0x0000000184EA5670
	// [XID] // 0x0000000189714FB0-0x0000000189714FD0
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000184EA4360-0x0000000184EA45A0
	[BlackList] // 0x000000018971CA80-0x000000018971CAC0
	// [XID] // 0x000000018971CA80-0x000000018971CAC0
	public static new FireMonsterBeingHitAfterImage ParseFromJson(JSONNode node) => default; // 0x0000000184EA6160-0x0000000184EA63B0
	// [XID] // 0x0000000189727160-0x0000000189727180
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF39BD */, bool useObjectPool = false /* Metadata: 0x00AF39C1 */) => default; // 0x0000000184EA5C40-0x0000000184EA5F40
	// [XID] // 0x000000018972E730-0x000000018972E750
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF39C2 */, bool useObjectPool = false /* Metadata: 0x00AF39C6 */) => default; // 0x0000000184EA4E60-0x0000000184EA5090
	// [XID] // 0x0000000189735EC0-0x0000000189735EE0
	public static new FireMonsterBeingHitAfterImage ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF39C7 */, bool useObjectPool = false /* Metadata: 0x00AF39CB */) => default; // 0x0000000184EA5670-0x0000000184EA5890
	[BlackList] // 0x000000018973DA70-0x000000018973DAB0
	// [XID] // 0x000000018973DA70-0x000000018973DAB0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000184EA45A0-0x0000000184EA4870
	// [XID] // 0x00000001897480C0-0x00000001897480E0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000184EA6640-0x0000000184EA6870
	[BlackList] // 0x000000018974F890-0x000000018974F8D0
	// [XID] // 0x000000018974F890-0x000000018974F8D0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000184EA5B50-0x0000000184EA5C40
	// [XID] // 0x0000000189759A80-0x0000000189759AA0
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x0000000184EA5090-0x0000000184EA51F0
	[BlackList] // 0x0000000189770130-0x0000000189770170
	// [XID] // 0x0000000189770130-0x0000000189770170
	public override void AutoAllocTypeFields() {} // 0x0000000184EA4870-0x0000000184EA4910
	[BlackList] // 0x000000018977A780-0x000000018977A7C0
	// [XID] // 0x000000018977A780-0x000000018977A7C0
	public override void AutoRecycleTypeFields() {} // 0x0000000184EA4910-0x0000000184EA49E0
	[BlackList] // 0x00000001897851C0-0x0000000189785200
	// [XID] // 0x00000001897851C0-0x0000000189785200
	public override void ReturnToObjectPool() {} // 0x0000000184EA6960-0x0000000184EA6A00
}

