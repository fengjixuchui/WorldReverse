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
public class DummyAction : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16803
{
	// Fields
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigAbilityAction[] _actionList; // 0x68

	// Properties
	public ConfigAbilityAction[] actionList { /* [XID] */ /* 0x0000000189908930-0x0000000189908950 */ get => default; /* [XID] */ /* 0x000000018990FF30-0x000000018990FF50 */ private set {} } // 0x000000018354A850-0x000000018354A8F0 0x000000018354A580-0x000000018354A630

	// Constructors
	public DummyAction() {} // 0x000000018354BE30-0x000000018354BE90

	// Methods
	// [XID] // 0x0000000189917AE0-0x0000000189917B00
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018354BCA0-0x000000018354BD90
	// [XID] // 0x000000018991F020-0x000000018991F040
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x000000018354B8A0-0x000000018354B980
	// [XID] // 0x0000000189926AC0-0x0000000189926AE0
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF46CE */) => default; // 0x000000018354B4B0-0x000000018354B590
	// [XID] // 0x000000018992E0B0-0x000000018992E0D0
	public override int GetHashNum() => default; // 0x000000018354A160-0x000000018354A230
	// [XID] // 0x0000000189935470-0x0000000189935490
	public override void InitEmpty() {} // 0x000000018354AF00-0x000000018354AFD0
	[BlackList] // 0x000000018993CFF0-0x000000018993D030
	// [XID] // 0x000000018993CFF0-0x000000018993D030
	public override bool FromJson(JSONNode node) => default; // 0x000000018354A8F0-0x000000018354AC70
	// [XID] // 0x0000000189947480-0x00000001899474A0
	private new bool InternalFromJson(JSONNode node) => default; // 0x00000001835499F0-0x0000000183549C20
	[BlackList] // 0x000000018994EC00-0x000000018994EC40
	// [XID] // 0x000000018994EC00-0x000000018994EC40
	public static new DummyAction ParseFromJson(JSONNode node) => default; // 0x000000018354B5F0-0x000000018354B840
	// [XID] // 0x0000000189959310-0x0000000189959330
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF46CF */, bool useObjectPool = false /* Metadata: 0x00AF46D3 */) => default; // 0x000000018354B1B0-0x000000018354B4B0
	// [XID] // 0x0000000189960B60-0x0000000189960B80
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF46D4 */, bool useObjectPool = false /* Metadata: 0x00AF46D8 */) => default; // 0x000000018354A310-0x000000018354A580
	// [XID] // 0x0000000189968300-0x0000000189968320
	public static new DummyAction ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF46D9 */, bool useObjectPool = false /* Metadata: 0x00AF46DD */) => default; // 0x000000018354AC70-0x000000018354AE90
	[BlackList] // 0x000000018996F7E0-0x000000018996F820
	// [XID] // 0x000000018996F7E0-0x000000018996F820
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000183549C20-0x0000000183549EF0
	// [XID] // 0x000000018997A590-0x000000018997A5B0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018354BA60-0x000000018354BCA0
	[BlackList] // 0x0000000189981E80-0x0000000189981EC0
	// [XID] // 0x0000000189981E80-0x0000000189981EC0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x000000018354B0B0-0x000000018354B1B0
	// [XID] // 0x000000018998C550-0x000000018998C570
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x000000018354A630-0x000000018354A750
	[BlackList] // 0x0000000189994250-0x0000000189994290
	// [XID] // 0x0000000189994250-0x0000000189994290
	public override void AutoAllocTypeFields() {} // 0x0000000183549EF0-0x0000000183549F90
	[BlackList] // 0x000000018999EB70-0x000000018999EBB0
	// [XID] // 0x000000018999EB70-0x000000018999EBB0
	public override void AutoRecycleTypeFields() {} // 0x0000000183549F90-0x000000018354A040
	[BlackList] // 0x00000001899A93E0-0x00000001899A9420
	// [XID] // 0x00000001899A93E0-0x00000001899A9420
	public override void ReturnToObjectPool() {} // 0x000000018354BD90-0x000000018354BE30
}

