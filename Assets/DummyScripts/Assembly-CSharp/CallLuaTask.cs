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
public class CallLuaTask : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16741
{
	// Fields
	private string _targetAlias; // 0x68
	private SimpleSafeInt32 valueIntRawNum; // 0x70
	private SimpleSafeFloat valueFloatRawNum; // 0x74
	private string _valueString; // 0x78

	// Properties
	public string targetAlias { /* [XID] */ /* 0x0000000189951DD0-0x0000000189951DF0 */ get => default; /* [XID] */ /* 0x0000000189959330-0x0000000189959350 */ private set {} } // 0x0000000184B98EA0-0x0000000184B98F40 0x0000000184B96EF0-0x0000000184B96FA0
	public int valueInt { /* [XID] */ /* 0x0000000189960B80-0x0000000189960BA0 */ get => default; /* [XID] */ /* 0x0000000189968320-0x0000000189968340 */ private set {} } // 0x0000000184B97150-0x0000000184B97220 0x0000000184B97220-0x0000000184B97300
	public float valueFloat { /* [XID] */ /* 0x000000018996F820-0x000000018996F840 */ get => default; /* [XID] */ /* 0x00000001899774C0-0x00000001899774E0 */ private set {} } // 0x0000000184B98080-0x0000000184B98160 0x0000000184B97070-0x0000000184B97150
	public string valueString { /* [XID] */ /* 0x000000018997E820-0x000000018997E840 */ get => default; /* [XID] */ /* 0x0000000189986250-0x0000000189986270 */ private set {} } // 0x0000000184B96190-0x0000000184B96230 0x0000000184B97DB0-0x0000000184B97E60
	protected override bool MuteAuthority { /* [XID] */ /* 0x0000000189A11D80-0x0000000189A11DA0 */ get => default; } // 0x0000000184B98CA0-0x0000000184B98D40 
	protected override bool MuteRemote { /* [XID] */ /* 0x0000000189A19010-0x0000000189A19030 */ get => default; } // 0x0000000184B98240-0x0000000184B982E0 

	// Constructors
	public CallLuaTask() {} // 0x0000000184B99680-0x0000000184B996E0

	// Methods
	// [XID] // 0x000000018998DE60-0x000000018998DE80
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000184B993F0-0x0000000184B99540
	// [XID] // 0x0000000189995930-0x0000000189995950
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000184B98DA0-0x0000000184B98EA0
	// [XID] // 0x000000018999D250-0x000000018999D270
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF44CE */) => default; // 0x0000000184B98910-0x0000000184B989F0
	// [XID] // 0x00000001899A4C10-0x00000001899A4C30
	public override int GetHashNum() => default; // 0x0000000184B96E20-0x0000000184B96EF0
	// [XID] // 0x00000001899AC790-0x00000001899AC7B0
	public override void InitEmpty() {} // 0x0000000184B982E0-0x0000000184B98430
	[BlackList] // 0x00000001899B3EC0-0x00000001899B3F00
	// [XID] // 0x00000001899B3EC0-0x00000001899B3F00
	public override bool FromJson(JSONNode node) => default; // 0x0000000184B97A30-0x0000000184B97DB0
	// [XID] // 0x00000001899BE590-0x00000001899BE5B0
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000184B962B0-0x0000000184B96800
	[BlackList] // 0x00000001899C5D50-0x00000001899C5D90
	// [XID] // 0x00000001899C5D50-0x00000001899C5D90
	public static new CallLuaTask ParseFromJson(JSONNode node) => default; // 0x0000000184B98A50-0x0000000184B98CA0
	// [XID] // 0x00000001899D04D0-0x00000001899D04F0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF44CF */, bool useObjectPool = false /* Metadata: 0x00AF44D3 */) => default; // 0x0000000184B98610-0x0000000184B98910
	// [XID] // 0x00000001899D7970-0x00000001899D7990
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF44D4 */, bool useObjectPool = false /* Metadata: 0x00AF44D8 */) => default; // 0x0000000184B97380-0x0000000184B977D0
	// [XID] // 0x00000001899DEE30-0x00000001899DEE50
	public static new CallLuaTask ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF44D9 */, bool useObjectPool = false /* Metadata: 0x00AF44DD */) => default; // 0x0000000184B97E60-0x0000000184B98080
	[BlackList] // 0x00000001899E69F0-0x00000001899E6A30
	// [XID] // 0x00000001899E69F0-0x00000001899E6A30
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000184B96800-0x0000000184B96AD0
	// [XID] // 0x00000001899F0EB0-0x00000001899F0ED0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000184B99020-0x0000000184B993F0
	[BlackList] // 0x00000001899F8790-0x00000001899F87D0
	// [XID] // 0x00000001899F8790-0x00000001899F87D0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000184B98510-0x0000000184B98610
	// [XID] // 0x0000000189A02E50-0x0000000189A02E70
	public override bool isAlreadyHandledRecoverCase() => default; // 0x0000000184B99540-0x0000000184B995E0
	// [XID] // 0x0000000189A0A4A0-0x0000000189A0A4C0
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x0000000184B977D0-0x0000000184B97930
	[BlackList] // 0x0000000189A20790-0x0000000189A207D0
	// [XID] // 0x0000000189A20790-0x0000000189A207D0
	public override void AutoAllocTypeFields() {} // 0x0000000184B96AD0-0x0000000184B96B70
	[BlackList] // 0x0000000189A2AAE0-0x0000000189A2AB20
	// [XID] // 0x0000000189A2AAE0-0x0000000189A2AB20
	public override void AutoRecycleTypeFields() {} // 0x0000000184B96B70-0x0000000184B96C90
	[BlackList] // 0x0000000189A35310-0x0000000189A35350
	// [XID] // 0x0000000189A35310-0x0000000189A35350
	public override void ReturnToObjectPool() {} // 0x0000000184B995E0-0x0000000184B99680
}

