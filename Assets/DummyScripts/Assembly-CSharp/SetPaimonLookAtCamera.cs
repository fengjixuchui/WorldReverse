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
public class SetPaimonLookAtCamera : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16631
{
	// Fields
	private PaimonRequestFrom _from; // 0x68
	private bool _lookat; // 0x6C
	private SimpleSafeFloat minTimeRawNum; // 0x70
	private SimpleSafeFloat maxTimeRawNum; // 0x74

	// Properties
	public PaimonRequestFrom from { /* [XID] */ /* 0x00000001896268A0-0x00000001896268C0 */ get => default; /* [XID] */ /* 0x000000018962E0B0-0x000000018962E0D0 */ private set {} } // 0x000000018224A4F0-0x000000018224A590 0x000000018224A850-0x000000018224A900
	public bool lookat { /* [XID] */ /* 0x0000000189635D50-0x0000000189635D70 */ get => default; /* [XID] */ /* 0x000000018963D4D0-0x000000018963D4F0 */ private set {} } // 0x0000000182249510-0x00000001822495B0 0x000000018224B300-0x000000018224B3B0
	public float minTime { /* [XID] */ /* 0x0000000189644A90-0x0000000189644AB0 */ get => default; /* [XID] */ /* 0x000000018964C290-0x000000018964C2B0 */ private set {} } // 0x000000018224AD40-0x000000018224AE20 0x000000018224AE20-0x000000018224AF00
	public float maxTime { /* [XID] */ /* 0x0000000189653980-0x00000001896539A0 */ get => default; /* [XID] */ /* 0x000000018965B250-0x000000018965B270 */ private set {} } // 0x0000000182249B90-0x0000000182249C70 0x000000018224A410-0x000000018224A4F0
	protected override bool MuteAuthority { /* [XID] */ /* 0x00000001896E5710-0x00000001896E5730 */ get => default; } // 0x000000018224B150-0x000000018224B1F0 
	protected override bool MuteRemote { /* [XID] */ /* 0x00000001896ECDE0-0x00000001896ECE00 */ get => default; } // 0x000000018224A370-0x000000018224A410 

	// Constructors
	public SetPaimonLookAtCamera() {} // 0x000000018224BAC0-0x000000018224BB20

	// Methods
	// [XID] // 0x00000001896626E0-0x0000000189662700
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018224B830-0x000000018224B980
	// [XID] // 0x000000018966A2A0-0x000000018966A2C0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x000000018224B250-0x000000018224B300
	// [XID] // 0x0000000189671F00-0x0000000189671F20
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF416A */) => default; // 0x000000018224AC00-0x000000018224ACE0
	// [XID] // 0x0000000189679790-0x00000001896797B0
	public override int GetHashNum() => default; // 0x00000001822492F0-0x00000001822493C0
	// [XID] // 0x0000000189680F00-0x0000000189680F20
	public override void InitEmpty() {} // 0x000000018224A590-0x000000018224A670
	[BlackList] // 0x00000001896888E0-0x0000000189688920
	// [XID] // 0x00000001896888E0-0x0000000189688920
	public override bool FromJson(JSONNode node) => default; // 0x0000000182249CF0-0x000000018224A070
	// [XID] // 0x0000000189693440-0x0000000189693460
	private new bool InternalFromJson(JSONNode node) => default; // 0x00000001822487C0-0x0000000182248CF0
	[BlackList] // 0x000000018969A710-0x000000018969A750
	// [XID] // 0x000000018969A710-0x000000018969A750
	public static new SetPaimonLookAtCamera ParseFromJson(JSONNode node) => default; // 0x000000018224AF00-0x000000018224B150
	// [XID] // 0x00000001896A4B00-0x00000001896A4B20
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF416B */, bool useObjectPool = false /* Metadata: 0x00AF416F */) => default; // 0x000000018224A900-0x000000018224AC00
	// [XID] // 0x00000001896AC330-0x00000001896AC350
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF4170 */, bool useObjectPool = false /* Metadata: 0x00AF4174 */) => default; // 0x00000001822495B0-0x00000001822499B0
	// [XID] // 0x00000001896B3630-0x00000001896B3650
	public static new SetPaimonLookAtCamera ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF4175 */, bool useObjectPool = false /* Metadata: 0x00AF4179 */) => default; // 0x000000018224A070-0x000000018224A290
	[BlackList] // 0x00000001896BAD50-0x00000001896BAD90
	// [XID] // 0x00000001896BAD50-0x00000001896BAD90
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000182248CF0-0x0000000182248FC0
	// [XID] // 0x00000001896C5010-0x00000001896C5030
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018224B490-0x000000018224B830
	[BlackList] // 0x00000001896CC5D0-0x00000001896CC610
	// [XID] // 0x00000001896CC5D0-0x00000001896CC610
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x000000018224A750-0x000000018224A850
	// [XID] // 0x00000001896D6B60-0x00000001896D6B80
	public override bool isAlreadyHandledRecoverCase() => default; // 0x000000018224B980-0x000000018224BA20
	// [XID] // 0x00000001896DE220-0x00000001896DE240
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x00000001822499B0-0x0000000182249B10
	[BlackList] // 0x00000001896F45A0-0x00000001896F45E0
	// [XID] // 0x00000001896F45A0-0x00000001896F45E0
	public override void AutoAllocTypeFields() {} // 0x0000000182248FC0-0x0000000182249060
	[BlackList] // 0x00000001896FEF70-0x00000001896FEFB0
	// [XID] // 0x00000001896FEF70-0x00000001896FEFB0
	public override void AutoRecycleTypeFields() {} // 0x0000000182249060-0x0000000182249160
	[BlackList] // 0x00000001897094A0-0x00000001897094E0
	// [XID] // 0x00000001897094A0-0x00000001897094E0
	public override void ReturnToObjectPool() {} // 0x000000018224BA20-0x000000018224BAC0
}

