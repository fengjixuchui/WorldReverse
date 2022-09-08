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
public class ConfigAIWanderData : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17419
{
	// Fields
	private SimpleSafeInt32 speedLevelRawNum; // 0x10
	private SimpleSafeFloat turnSpeedOverrideRawNum; // 0x14
	private SimpleSafeFloat cdMaxRawNum; // 0x18
	private SimpleSafeFloat cdMinRawNum; // 0x1C
	private SimpleSafeFloat distanceFromBornRawNum; // 0x20
	private SimpleSafeFloat distanceFromCurrentMinRawNum; // 0x24
	private SimpleSafeFloat distanceFromCurrentMaxRawNum; // 0x28
	private AIBasicMoveType _moveType; // 0x2C

	// Properties
	public int speedLevel { /* [XID] */ /* 0x00000001899B3DC0-0x00000001899B3DE0 */ get => default; /* [XID] */ /* 0x00000001899BB1F0-0x00000001899BB210 */ private set {} } // 0x00000001832C48B0-0x00000001832C4980 0x00000001832C4A60-0x00000001832C4B40
	public float turnSpeedOverride { /* [XID] */ /* 0x00000001899C2CE0-0x00000001899C2D00 */ get => default; /* [XID] */ /* 0x00000001899CA1A0-0x00000001899CA1C0 */ private set {} } // 0x00000001832C4980-0x00000001832C4A60 0x00000001832C5310-0x00000001832C53F0
	public float cdMax { /* [XID] */ /* 0x00000001899D1A00-0x00000001899D1A20 */ get => default; /* [XID] */ /* 0x00000001899D8F30-0x00000001899D8F50 */ private set {} } // 0x00000001832C5B60-0x00000001832C5C40 0x00000001832C5070-0x00000001832C5150
	public float cdMin { /* [XID] */ /* 0x00000001899E0600-0x00000001899E0620 */ get => default; /* [XID] */ /* 0x00000001899E8180-0x00000001899E81A0 */ private set {} } // 0x00000001832C59A0-0x00000001832C5A80 0x00000001832C45C0-0x00000001832C46A0
	public float distanceFromBorn { /* [XID] */ /* 0x00000001899EF690-0x00000001899EF6B0 */ get => default; /* [XID] */ /* 0x00000001899F6EF0-0x00000001899F6F10 */ private set {} } // 0x00000001832C5150-0x00000001832C5230 0x00000001832C5A80-0x00000001832C5B60
	public float distanceFromCurrentMin { /* [XID] */ /* 0x00000001899FE6D0-0x00000001899FE6F0 */ get => default; /* [XID] */ /* 0x0000000189A05EF0-0x0000000189A05F10 */ private set {} } // 0x00000001832C5230-0x00000001832C5310 0x00000001832C6730-0x00000001832C6810
	public float distanceFromCurrentMax { /* [XID] */ /* 0x0000000189A0D320-0x0000000189A0D340 */ get => default; /* [XID] */ /* 0x0000000189A14B40-0x0000000189A14B60 */ private set {} } // 0x00000001832C58C0-0x00000001832C59A0 0x00000001832C60A0-0x00000001832C6180
	public AIBasicMoveType moveType { /* [XID] */ /* 0x0000000189A1BDD0-0x0000000189A1BDF0 */ get => default; /* [XID] */ /* 0x0000000189A23600-0x0000000189A23620 */ private set {} } // 0x00000001832C5820-0x00000001832C58C0 0x00000001832C5770-0x00000001832C5820

	// Constructors
	public ConfigAIWanderData() {} // 0x00000001832C6BA0-0x00000001832C6CD0

	// Methods
	// [XID] // 0x0000000189A2A9A0-0x0000000189A2A9C0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001832C6810-0x00000001832C69C0
	// [XID] // 0x0000000189A31F40-0x0000000189A31F60
	public void InitEmpty() {} // 0x00000001832C5C40-0x00000001832C5DA0
	[BlackList] // 0x0000000189A398B0-0x0000000189A398F0
	// [XID] // 0x0000000189A398B0-0x0000000189A398F0
	public bool FromJson(JSONNode node) => default; // 0x00000001832C53F0-0x00000001832C5770
	// [XID] // 0x0000000189A441B0-0x0000000189A441D0
	private bool InternalFromJson(JSONNode node) => default; // 0x00000001832C3A30-0x00000001832C42F0
	// [XID] // 0x0000000189A4B6A0-0x0000000189A4B6C0
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6DFB */, bool useObjectPool = false /* Metadata: 0x00AF6DFF */) => default; // 0x00000001832C5DA0-0x00000001832C60A0
	// [XID] // 0x0000000189A52E00-0x0000000189A52E20
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6E00 */, bool useObjectPool = false /* Metadata: 0x00AF6E04 */) => default; // 0x00000001832C4B40-0x00000001832C5070
	[BlackList] // 0x0000000189A5A6B0-0x0000000189A5A6F0
	// [XID] // 0x0000000189A5A6B0-0x0000000189A5A6F0
	public bool ToBinary(ByteArray byteArray) => default; // 0x00000001832C42F0-0x00000001832C45C0
	// [XID] // 0x0000000189A65160-0x0000000189A65180
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001832C6180-0x00000001832C6730
	[BlackList] // 0x0000000189A6C940-0x0000000189A6C980
	// [XID] // 0x0000000189A6C940-0x0000000189A6C980
	public virtual void AutoAllocTypeFields() {} // 0x00000001832C46A0-0x00000001832C4740
	[BlackList] // 0x0000000189A77110-0x0000000189A77150
	// [XID] // 0x0000000189A77110-0x0000000189A77150
	public virtual void AutoRecycleTypeFields() {} // 0x00000001832C4740-0x00000001832C48B0
	[BlackList] // 0x0000000189A81A70-0x0000000189A81AB0
	// [XID] // 0x0000000189A81A70-0x0000000189A81AB0
	public virtual void ReturnToObjectPool() {} // 0x00000001832C6B00-0x00000001832C6BA0
	[BlackList] // 0x0000000189A8C4D0-0x0000000189A8C510
	// [XID] // 0x0000000189A8C4D0-0x0000000189A8C510
	public virtual void OnPoolAllocated() {} // 0x00000001832C6A60-0x00000001832C6B00
	[BlackList] // 0x0000000189A96AE0-0x0000000189A96B20
	// [XID] // 0x0000000189A96AE0-0x0000000189A96B20
	public virtual void OnBeforePoolRecycled() {} // 0x00000001832C69C0-0x00000001832C6A60
}

