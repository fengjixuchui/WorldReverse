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
public class ConfigLBaseMark : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18552
{
	// Fields
	private SimpleSafeInt32 priorityRawNum; // 0x10
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigVBaseMark[] _views; // 0x18

	// Properties
	public int priority { /* [XID] */ /* 0x0000000189955F00-0x0000000189955F20 */ get => default; /* [XID] */ /* 0x000000018995DA70-0x000000018995DA90 */ private set {} } // 0x0000000183911DB0-0x0000000183911E80 0x00000001839111B0-0x0000000183911290
	public ConfigVBaseMark[] views { /* [XID] */ /* 0x000000018991E1D0-0x000000018991E1F0 */ get => default; /* [XID] */ /* 0x000000018996C6D0-0x000000018996C6F0 */ private set {} } // 0x0000000183910E40-0x0000000183910EE0 0x0000000183910CC0-0x0000000183910D70

	// Constructors
	public ConfigLBaseMark() {} // 0x00000001839126E0-0x0000000183912740

	// Methods
	// [XID] // 0x0000000189974130-0x0000000189974150
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001839123F0-0x0000000183912500
	// [XID] // 0x000000018997B860-0x000000018997B880
	public virtual void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000183912080-0x0000000183912150
	// [XID] // 0x0000000189983370-0x0000000189983390
	public virtual ConfigLBaseMark Clone(bool useObjectPool = false /* Metadata: 0x00AFA3A1 */) => default; // 0x0000000183911CD0-0x0000000183911DB0
	// [XID] // 0x000000018998AB20-0x000000018998AB40
	public virtual int GetHashNum() => default; // 0x0000000183910D70-0x0000000183910E40
	// [XID] // 0x0000000189992450-0x0000000189992470
	public virtual void InitEmpty() {} // 0x00000001839117E0-0x00000001839118E0
	[BlackList] // 0x000000018999A1F0-0x000000018999A230
	// [XID] // 0x000000018999A1F0-0x000000018999A230
	public virtual bool FromJson(JSONNode node) => default; // 0x0000000183911290-0x0000000183911610
	// [XID] // 0x00000001899A4970-0x00000001899A4990
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000183910570-0x0000000183910870
	[BlackList] // 0x00000001899AC390-0x00000001899AC3D0
	// [XID] // 0x00000001899AC390-0x00000001899AC3D0
	public static ConfigLBaseMark ParseFromJson(JSONNode node) => default; // 0x0000000183911E80-0x0000000183912080
	// [XID] // 0x00000001899B6690-0x00000001899B66B0
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFA3A2 */, bool useObjectPool = false /* Metadata: 0x00AFA3A6 */) => default; // 0x00000001839119D0-0x0000000183911CD0
	// [XID] // 0x00000001899BE270-0x00000001899BE290
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFA3A7 */, bool useObjectPool = false /* Metadata: 0x00AFA3AB */) => default; // 0x0000000183910EE0-0x00000001839111B0
	// [XID] // 0x00000001899C5A70-0x00000001899C5A90
	public static ConfigLBaseMark ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFA3AC */, bool useObjectPool = false /* Metadata: 0x00AFA3B0 */) => default; // 0x0000000183911610-0x00000001839117E0
	[BlackList] // 0x00000001899CD070-0x00000001899CD0B0
	// [XID] // 0x00000001899CD070-0x00000001899CD0B0
	public virtual bool ToBinary(ByteArray byteArray) => default; // 0x0000000183910870-0x0000000183910B40
	// [XID] // 0x00000001899D7630-0x00000001899D7650
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000183912150-0x00000001839123F0
	[BlackList] // 0x00000001899DEA90-0x00000001899DEAD0
	// [XID] // 0x00000001899DEA90-0x00000001899DEAD0
	public virtual bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001839118E0-0x00000001839119D0
	[BlackList] // 0x00000001899E93E0-0x00000001899E9420
	// [XID] // 0x00000001899E93E0-0x00000001899E9420
	public virtual void AutoAllocTypeFields() {} // 0x0000000183910B40-0x0000000183910BE0
	[BlackList] // 0x00000001899F4010-0x00000001899F4050
	// [XID] // 0x00000001899F4010-0x00000001899F4050
	public virtual void AutoRecycleTypeFields() {} // 0x0000000183910BE0-0x0000000183910CC0
	[BlackList] // 0x00000001899FE3D0-0x00000001899FE410
	// [XID] // 0x00000001899FE3D0-0x00000001899FE410
	public virtual void ReturnToObjectPool() {} // 0x0000000183912640-0x00000001839126E0
	[BlackList] // 0x0000000189A088D0-0x0000000189A08910
	// [XID] // 0x0000000189A088D0-0x0000000189A08910
	public virtual void OnPoolAllocated() {} // 0x00000001839125A0-0x0000000183912640
	[BlackList] // 0x0000000189A13060-0x0000000189A130A0
	// [XID] // 0x0000000189A13060-0x0000000189A130A0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000183912500-0x00000001839125A0
}

