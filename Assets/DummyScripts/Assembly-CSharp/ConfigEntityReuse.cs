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
public class ConfigEntityReuse : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18051
{
	// Fields
	private SimpleSafeUInt32 configIdRawNum; // 0x10
	private SimpleSafeFloat destroyTimeRawNum; // 0x14
	private SimpleSafeUInt32 maxEntityCountRawNum; // 0x18

	// Properties
	public uint configId { /* [XID] */ /* 0x0000000189A17490-0x0000000189A174B0 */ get => default; /* [XID] */ /* 0x0000000189A1EBF0-0x0000000189A1EC10 */ private set {} } // 0x00000001841C13F0-0x00000001841C14C0 0x00000001841C1990-0x00000001841C1A70
	public float destroyTime { /* [XID] */ /* 0x0000000189A262A0-0x0000000189A262C0 */ get => default; /* [XID] */ /* 0x0000000189A2D590-0x0000000189A2D5B0 */ private set {} } // 0x00000001841C0A80-0x00000001841C0B60 0x00000001841C0F90-0x00000001841C1070
	public uint maxEntityCount { /* [XID] */ /* 0x0000000189A35010-0x0000000189A35030 */ get => default; /* [XID] */ /* 0x0000000189A3C470-0x0000000189A3C490 */ private set {} } // 0x00000001841C15C0-0x00000001841C1690 0x00000001841C0B60-0x00000001841C0C40

	// Constructors
	public ConfigEntityReuse() {} // 0x00000001841C20A0-0x00000001841C2100

	// Methods
	// [XID] // 0x0000000189A44010-0x0000000189A44030
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001841C1DA0-0x00000001841C1EC0
	// [XID] // 0x0000000189A4B580-0x0000000189A4B5A0
	public void InitEmpty() {} // 0x00000001841C14C0-0x00000001841C15C0
	[BlackList] // 0x0000000189A52C00-0x0000000189A52C40
	// [XID] // 0x0000000189A52C00-0x0000000189A52C40
	public bool FromJson(JSONNode node) => default; // 0x00000001841C1070-0x00000001841C13F0
	// [XID] // 0x0000000189A5D780-0x0000000189A5D7A0
	private bool InternalFromJson(JSONNode node) => default; // 0x00000001841C01B0-0x00000001841C0600
	// [XID] // 0x0000000189A64FE0-0x0000000189A65000
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF87F1 */, bool useObjectPool = false /* Metadata: 0x00AF87F5 */) => default; // 0x00000001841C1690-0x00000001841C1990
	// [XID] // 0x0000000189A6C760-0x0000000189A6C780
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF87F6 */, bool useObjectPool = false /* Metadata: 0x00AF87FA */) => default; // 0x00000001841C0C40-0x00000001841C0F90
	[BlackList] // 0x0000000189A74050-0x0000000189A74090
	// [XID] // 0x0000000189A74050-0x0000000189A74090
	public bool ToBinary(ByteArray byteArray) => default; // 0x00000001841C0600-0x00000001841C08D0
	// [XID] // 0x0000000189A7EA00-0x0000000189A7EA20
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001841C1A70-0x00000001841C1DA0
	[BlackList] // 0x0000000189A86230-0x0000000189A86270
	// [XID] // 0x0000000189A86230-0x0000000189A86270
	public virtual void AutoAllocTypeFields() {} // 0x00000001841C08D0-0x00000001841C0970
	[BlackList] // 0x0000000189A90CF0-0x0000000189A90D30
	// [XID] // 0x0000000189A90CF0-0x0000000189A90D30
	public virtual void AutoRecycleTypeFields() {} // 0x00000001841C0970-0x00000001841C0A80
	[BlackList] // 0x0000000189A9B400-0x0000000189A9B440
	// [XID] // 0x0000000189A9B400-0x0000000189A9B440
	public virtual void ReturnToObjectPool() {} // 0x00000001841C2000-0x00000001841C20A0
	[BlackList] // 0x0000000189AA58A0-0x0000000189AA58E0
	// [XID] // 0x0000000189AA58A0-0x0000000189AA58E0
	public virtual void OnPoolAllocated() {} // 0x00000001841C1F60-0x00000001841C2000
	[BlackList] // 0x0000000189AB0060-0x0000000189AB00A0
	// [XID] // 0x0000000189AB0060-0x0000000189AB00A0
	public virtual void OnBeforePoolRecycled() {} // 0x00000001841C1EC0-0x00000001841C1F60
}

