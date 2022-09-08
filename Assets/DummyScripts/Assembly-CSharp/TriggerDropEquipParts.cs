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
public class TriggerDropEquipParts : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16513
{
	// Fields
	private bool _dropAll; // 0x68
	private string[] _equipParts; // 0x70

	// Properties
	public bool dropAll { /* [XID] */ /* 0x0000000189AEE960-0x0000000189AEE980 */ get => default; /* [XID] */ /* 0x0000000189AF5F70-0x0000000189AF5F90 */ private set {} } // 0x00000001829D5260-0x00000001829D5300 0x00000001829D2E20-0x00000001829D2ED0
	public string[] equipParts { /* [XID] */ /* 0x0000000189AFD470-0x0000000189AFD490 */ get => default; /* [XID] */ /* 0x0000000189B04C60-0x0000000189B04C80 */ private set {} } // 0x00000001829D54B0-0x00000001829D5550 0x00000001829D3F60-0x00000001829D4010
	protected override bool MuteAuthority { /* [XID] */ /* 0x0000000189B8F110-0x0000000189B8F130 */ get => default; } // 0x00000001829D4CE0-0x00000001829D4D80 
	protected override bool MuteRemote { /* [XID] */ /* 0x0000000189B96600-0x0000000189B96620 */ get => default; } // 0x00000001829D4310-0x00000001829D43B0 

	// Constructors
	public TriggerDropEquipParts() {} // 0x00000001829D55F0-0x00000001829D5650

	// Methods
	// [XID] // 0x0000000189B0C450-0x0000000189B0C470
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001829D5300-0x00000001829D5410
	// [XID] // 0x0000000189B139F0-0x0000000189B13A10
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001829D4DE0-0x00000001829D4EC0
	// [XID] // 0x0000000189B1B080-0x0000000189B1B0A0
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF3DC6 */) => default; // 0x00000001829D4950-0x00000001829D4A30
	// [XID] // 0x0000000189B227F0-0x0000000189B22810
	public override int GetHashNum() => default; // 0x00000001829D3480-0x00000001829D3550
	// [XID] // 0x0000000189B29D40-0x0000000189B29D60
	public override void InitEmpty() {} // 0x00000001829D43B0-0x00000001829D4480
	[BlackList] // 0x0000000189B312D0-0x0000000189B31310
	// [XID] // 0x0000000189B312D0-0x0000000189B31310
	public override bool FromJson(JSONNode node) => default; // 0x00000001829D3BE0-0x00000001829D3F60
	// [XID] // 0x0000000189B3B970-0x0000000189B3B990
	private new bool InternalFromJson(JSONNode node) => default; // 0x00000001829D2B30-0x00000001829D2E20
	[BlackList] // 0x0000000189B433B0-0x0000000189B433F0
	// [XID] // 0x0000000189B433B0-0x0000000189B433F0
	public static new TriggerDropEquipParts ParseFromJson(JSONNode node) => default; // 0x00000001829D4A90-0x00000001829D4CE0
	// [XID] // 0x0000000189B4DA80-0x0000000189B4DAA0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3DC7 */, bool useObjectPool = false /* Metadata: 0x00AF3DCB */) => default; // 0x00000001829D4650-0x00000001829D4950
	// [XID] // 0x0000000189B552F0-0x0000000189B55310
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3DCC */, bool useObjectPool = false /* Metadata: 0x00AF3DD0 */) => default; // 0x00000001829D36A0-0x00000001829D3980
	// [XID] // 0x0000000189B5CCB0-0x0000000189B5CCD0
	public static new TriggerDropEquipParts ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3DD1 */, bool useObjectPool = false /* Metadata: 0x00AF3DD5 */) => default; // 0x00000001829D4010-0x00000001829D4230
	[BlackList] // 0x0000000189B642D0-0x0000000189B64310
	// [XID] // 0x0000000189B642D0-0x0000000189B64310
	public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001829D2ED0-0x00000001829D31A0
	// [XID] // 0x0000000189B6E7C0-0x0000000189B6E7E0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001829D4FA0-0x00000001829D5260
	[BlackList] // 0x0000000189B76030-0x0000000189B76070
	// [XID] // 0x0000000189B76030-0x0000000189B76070
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001829D4560-0x00000001829D4650
	// [XID] // 0x0000000189B80430-0x0000000189B80450
	public override bool isAlreadyHandledRecoverCase() => default; // 0x00000001829D5410-0x00000001829D54B0
	// [XID] // 0x0000000189B87F20-0x0000000189B87F40
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x00000001829D3980-0x00000001829D3AE0
	[BlackList] // 0x0000000189B9DA80-0x0000000189B9DAC0
	// [XID] // 0x0000000189B9DA80-0x0000000189B9DAC0
	public override void AutoAllocTypeFields() {} // 0x00000001829D31A0-0x00000001829D3240
	[BlackList] // 0x0000000189BA8230-0x0000000189BA8270
	// [XID] // 0x0000000189BA8230-0x0000000189BA8270
	public override void AutoRecycleTypeFields() {} // 0x00000001829D3240-0x00000001829D32F0
	[BlackList] // 0x0000000189BB27D0-0x0000000189BB2810
	// [XID] // 0x0000000189BB27D0-0x0000000189BB2810
	public override void ReturnToObjectPool() {} // 0x00000001829D5550-0x00000001829D55F0
}

