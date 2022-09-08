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
public class SetGlobalValueToOverrideMap : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16402
{
	// Fields
	private AbilityFormula _abilityFormula; // 0x68
	private bool _isFromOwner; // 0x6C
	private string _globalValueKey; // 0x70
	private string _overrideMapKey; // 0x78

	// Properties
	public AbilityFormula abilityFormula { /* [XID] */ /* 0x0000000189B9F310-0x0000000189B9F330 */ get => default; /* [XID] */ /* 0x0000000189BA6B80-0x0000000189BA6BA0 */ private set {} } // 0x0000000181D24850-0x0000000181D248F0 0x0000000181D257D0-0x0000000181D25880
	public bool isFromOwner { /* [XID] */ /* 0x0000000189BADD40-0x0000000189BADD60 */ get => default; /* [XID] */ /* 0x0000000189BB5550-0x0000000189BB5570 */ private set {} } // 0x0000000181D245D0-0x0000000181D24670 0x0000000181D25DA0-0x0000000181D25E50
	public string globalValueKey { /* [XID] */ /* 0x0000000189BBCC20-0x0000000189BBCC40 */ get => default; /* [XID] */ /* 0x0000000189BC48E0-0x0000000189BC4900 */ private set {} } // 0x0000000181D25260-0x0000000181D25300 0x0000000181D23FD0-0x0000000181D24080
	public string overrideMapKey { /* [XID] */ /* 0x0000000189BCC2E0-0x0000000189BCC300 */ get => default; /* [XID] */ /* 0x0000000189BD3970-0x0000000189BD3990 */ private set {} } // 0x0000000181D262C0-0x0000000181D26360 0x0000000181D26360-0x0000000181D26410
	protected override bool MuteAuthority { /* [XID] */ /* 0x0000000189663F00-0x0000000189663F20 */ get => default; } // 0x0000000181D25B30-0x0000000181D25BD0 
	protected override bool MuteRemote { /* [XID] */ /* 0x000000018966B620-0x000000018966B640 */ get => default; } // 0x0000000181D24FF0-0x0000000181D25090 
	protected override bool ForceForwardToServer { /* [XID] */ /* 0x0000000189673360-0x0000000189673380 */ get => default; } // 0x0000000181D23F30-0x0000000181D23FD0 

	// Constructors
	public SetGlobalValueToOverrideMap() {} // 0x0000000181D266A0-0x0000000181D26710

	// Methods
	// [XID] // 0x0000000189BDB320-0x0000000189BDB340
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000181D26410-0x0000000181D26560
	// [XID] // 0x00000001895E7C10-0x00000001895E7C30
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000181D25CA0-0x0000000181D25DA0
	// [XID] // 0x00000001895EF5A0-0x00000001895EF5C0
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF3A5A */) => default; // 0x0000000181D256F0-0x0000000181D257D0
	// [XID] // 0x00000001895F6FA0-0x00000001895F6FC0
	public override int GetHashNum() => default; // 0x0000000181D23E60-0x0000000181D23F30
	// [XID] // 0x00000001895FE340-0x00000001895FE360
	public override void InitEmpty() {} // 0x0000000181D25090-0x0000000181D25180
	[BlackList] // 0x0000000189605BF0-0x0000000189605C30
	// [XID] // 0x0000000189605BF0-0x0000000189605C30
	public override bool FromJson(JSONNode node) => default; // 0x0000000181D24970-0x0000000181D24CF0
	// [XID] // 0x00000001896105B0-0x00000001896105D0
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000181D23420-0x0000000181D238B0
	[BlackList] // 0x00000001896178B0-0x00000001896178F0
	// [XID] // 0x00000001896178B0-0x00000001896178F0
	public static new SetGlobalValueToOverrideMap ParseFromJson(JSONNode node) => default; // 0x0000000181D258E0-0x0000000181D25B30
	// [XID] // 0x00000001896221A0-0x00000001896221C0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3A5B */, bool useObjectPool = false /* Metadata: 0x00AF3A5F */) => default; // 0x0000000181D253F0-0x0000000181D256F0
	// [XID] // 0x0000000189629AF0-0x0000000189629B10
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3A60 */, bool useObjectPool = false /* Metadata: 0x00AF3A64 */) => default; // 0x0000000181D241D0-0x0000000181D245D0
	// [XID] // 0x0000000189631340-0x0000000189631360
	public static new SetGlobalValueToOverrideMap ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3A65 */, bool useObjectPool = false /* Metadata: 0x00AF3A69 */) => default; // 0x0000000181D24CF0-0x0000000181D24F10
	[BlackList] // 0x0000000189638CD0-0x0000000189638D10
	// [XID] // 0x0000000189638CD0-0x0000000189638D10
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000181D238B0-0x0000000181D23B80
	// [XID] // 0x0000000189643300-0x0000000189643320
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000181D25F30-0x0000000181D262C0
	[BlackList] // 0x000000018964A940-0x000000018964A980
	// [XID] // 0x000000018964A940-0x000000018964A980
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000181D25300-0x0000000181D253F0
	// [XID] // 0x00000001896551E0-0x0000000189655200
	public override bool isAlreadyHandledRecoverCase() => default; // 0x0000000181D26560-0x0000000181D26600
	// [XID] // 0x000000018965CA80-0x000000018965CAA0
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x0000000181D24670-0x0000000181D247D0
	[BlackList] // 0x000000018967ABA0-0x000000018967ABE0
	// [XID] // 0x000000018967ABA0-0x000000018967ABE0
	public override void AutoAllocTypeFields() {} // 0x0000000181D23B80-0x0000000181D23C20
	[BlackList] // 0x00000001896853C0-0x0000000189685400
	// [XID] // 0x00000001896853C0-0x0000000189685400
	public override void AutoRecycleTypeFields() {} // 0x0000000181D23C20-0x0000000181D23CD0
	[BlackList] // 0x0000000189690380-0x00000001896903C0
	// [XID] // 0x0000000189690380-0x00000001896903C0
	public override void ReturnToObjectPool() {} // 0x0000000181D26600-0x0000000181D266A0
}

