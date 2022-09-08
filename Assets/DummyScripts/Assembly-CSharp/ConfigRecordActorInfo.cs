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
public class ConfigRecordActorInfo : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18888
{
	// Fields
	private string _name; // 0x10
	private ulong _prefabHash; // 0x18
	private SimpleSafeUInt32 serialIDRawNum; // 0x20
	private RecordActorType _actorType; // 0x24

	// Properties
	public string name { /* [XID] */ /* 0x0000000189A69B30-0x0000000189A69B50 */ get => default; /* [XID] */ /* 0x0000000189A70E80-0x0000000189A70EA0 */ private set {} } // 0x00000001830D6FA0-0x00000001830D7040 0x00000001830D6170-0x00000001830D6220
	public ulong prefabHash { /* [XID] */ /* 0x0000000189A78920-0x0000000189A78940 */ get => default; /* [XID] */ /* 0x0000000189A7FD40-0x0000000189A7FD60 */ private set {} } // 0x00000001830D6F00-0x00000001830D6FA0 0x00000001830D6320-0x00000001830D63D0
	public uint serialID { /* [XID] */ /* 0x0000000189A87AE0-0x0000000189A87B00 */ get => default; /* [XID] */ /* 0x0000000189A8F290-0x0000000189A8F2B0 */ private set {} } // 0x00000001830D5530-0x00000001830D5600 0x00000001830D63D0-0x00000001830D64B0
	public RecordActorType actorType { /* [XID] */ /* 0x0000000189A967A0-0x0000000189A967C0 */ get => default; /* [XID] */ /* 0x0000000189A9DCF0-0x0000000189A9DD10 */ private set {} } // 0x00000001830D6860-0x00000001830D6900 0x00000001830D67B0-0x00000001830D6860

	// Constructors
	public ConfigRecordActorInfo() {} // 0x00000001830D70E0-0x00000001830D7140

	// Methods
	// [XID] // 0x0000000189AA5780-0x0000000189AA57A0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001830D6C80-0x00000001830D6DC0
	// [XID] // 0x0000000189AACE40-0x0000000189AACE60
	public void InitEmpty() {} // 0x00000001830D6220-0x00000001830D6320
	[BlackList] // 0x0000000189AB46B0-0x0000000189AB46F0
	// [XID] // 0x0000000189AB46B0-0x0000000189AB46F0
	public bool FromJson(JSONNode node) => default; // 0x00000001830D5DF0-0x00000001830D6170
	// [XID] // 0x0000000189ABF0D0-0x0000000189ABF0F0
	private bool InternalFromJson(JSONNode node) => default; // 0x00000001830D5090-0x00000001830D5530
	// [XID] // 0x0000000189AC6B80-0x0000000189AC6BA0
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB283 */, bool useObjectPool = false /* Metadata: 0x00AFB287 */) => default; // 0x00000001830D64B0-0x00000001830D67B0
	// [XID] // 0x0000000189ACE370-0x0000000189ACE390
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB288 */, bool useObjectPool = false /* Metadata: 0x00AFB28C */) => default; // 0x00000001830D5A50-0x00000001830D5DF0
	[BlackList] // 0x0000000189AD6120-0x0000000189AD6160
	// [XID] // 0x0000000189AD6120-0x0000000189AD6160
	public bool ToBinary(ByteArray byteArray) => default; // 0x00000001830D5600-0x00000001830D58D0
	// [XID] // 0x0000000189AE0B40-0x0000000189AE0B60
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001830D6900-0x00000001830D6C80
	[BlackList] // 0x0000000189AE8010-0x0000000189AE8050
	// [XID] // 0x0000000189AE8010-0x0000000189AE8050
	public virtual void AutoAllocTypeFields() {} // 0x00000001830D58D0-0x00000001830D5970
	[BlackList] // 0x0000000189AF2B90-0x0000000189AF2BD0
	// [XID] // 0x0000000189AF2B90-0x0000000189AF2BD0
	public virtual void AutoRecycleTypeFields() {} // 0x00000001830D5970-0x00000001830D5A50
	[BlackList] // 0x0000000189AFCF10-0x0000000189AFCF50
	// [XID] // 0x0000000189AFCF10-0x0000000189AFCF50
	public virtual void ReturnToObjectPool() {} // 0x00000001830D7040-0x00000001830D70E0
	[BlackList] // 0x0000000189B07730-0x0000000189B07770
	// [XID] // 0x0000000189B07730-0x0000000189B07770
	public virtual void OnPoolAllocated() {} // 0x00000001830D6E60-0x00000001830D6F00
	[BlackList] // 0x0000000189B12000-0x0000000189B12040
	// [XID] // 0x0000000189B12000-0x0000000189B12040
	public virtual void OnBeforePoolRecycled() {} // 0x00000001830D6DC0-0x00000001830D6E60
}

