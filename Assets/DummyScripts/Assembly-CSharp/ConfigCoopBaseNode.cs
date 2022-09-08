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
public class ConfigCoopBaseNode : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17747
{
	// Fields
	private uint _coopNodeId; // 0x10
	private CoopNodeType _coopNodeType; // 0x14
	private uint[] _nextNodeArray; // 0x18

	// Properties
	public uint coopNodeId { /* [XID] */ /* 0x000000018999D130-0x000000018999D150 */ get => default; /* [XID] */ /* 0x00000001899A4A90-0x00000001899A4AB0 */ private set {} } // 0x000000018452AF50-0x000000018452AFF0 0x000000018452B4D0-0x000000018452B580
	public CoopNodeType coopNodeType { /* [XID] */ /* 0x00000001899AC550-0x00000001899AC570 */ get => default; /* [XID] */ /* 0x00000001899B3D00-0x00000001899B3D20 */ private set {} } // 0x000000018452BC00-0x000000018452BCA0 0x000000018452C760-0x000000018452C810
	public uint[] nextNodeArray { /* [XID] */ /* 0x00000001899BB150-0x00000001899BB170 */ get => default; /* [XID] */ /* 0x00000001899C2B60-0x00000001899C2B80 */ private set {} } // 0x000000018452BCA0-0x000000018452BD40 0x000000018452BF10-0x000000018452BFC0

	// Constructors
	public ConfigCoopBaseNode() {} // 0x000000018452CED0-0x000000018452CF30

	// Methods
	// [XID] // 0x00000001899CA120-0x00000001899CA140
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018452CBD0-0x000000018452CCF0
	// [XID] // 0x00000001899D1960-0x00000001899D1980
	public virtual void ForeachRefTypeMember(Action<object> callback) {} // 0x000000018452C810-0x000000018452C8E0
	// [XID] // 0x00000001899D8EB0-0x00000001899D8ED0
	public virtual ConfigCoopBaseNode Clone(bool useObjectPool = false /* Metadata: 0x00AF7AC5 */) => default; // 0x000000018452C480-0x000000018452C560
	// [XID] // 0x00000001899E04C0-0x00000001899E04E0
	public virtual int GetHashNum() => default; // 0x000000018452B400-0x000000018452B4D0
	// [XID] // 0x00000001899E8060-0x00000001899E8080
	public virtual void InitEmpty() {} // 0x000000018452BFC0-0x000000018452C090
	[BlackList] // 0x00000001899EF550-0x00000001899EF590
	// [XID] // 0x00000001899EF550-0x00000001899EF590
	public virtual bool FromJson(JSONNode node) => default; // 0x000000018452B880-0x000000018452BC00
	// [XID] // 0x00000001899F9D50-0x00000001899F9D70
	private bool InternalFromJson(JSONNode node) => default; // 0x000000018452ABD0-0x000000018452AF50
	[BlackList] // 0x0000000189A010D0-0x0000000189A01110
	// [XID] // 0x0000000189A010D0-0x0000000189A01110
	public static ConfigCoopBaseNode ParseFromJson(JSONNode node) => default; // 0x000000018452C560-0x000000018452C760
	// [XID] // 0x0000000189A0B9B0-0x0000000189A0B9D0
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7AC6 */, bool useObjectPool = false /* Metadata: 0x00AF7ACA */) => default; // 0x000000018452C180-0x000000018452C480
	// [XID] // 0x0000000189A13240-0x0000000189A13260
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7ACB */, bool useObjectPool = false /* Metadata: 0x00AF7ACF */) => default; // 0x000000018452B580-0x000000018452B880
	// [XID] // 0x0000000189A1A470-0x0000000189A1A490
	public static ConfigCoopBaseNode ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7AD0 */, bool useObjectPool = false /* Metadata: 0x00AF7AD4 */) => default; // 0x000000018452BD40-0x000000018452BF10
	[BlackList] // 0x0000000189A21B50-0x0000000189A21B90
	// [XID] // 0x0000000189A21B50-0x0000000189A21B90
	public virtual bool ToBinary(ByteArray byteArray) => default; // 0x000000018452AFF0-0x000000018452B2C0
	// [XID] // 0x0000000189A2BFD0-0x0000000189A2BFF0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018452C8E0-0x000000018452CBD0
	[BlackList] // 0x0000000189A336A0-0x0000000189A336E0
	// [XID] // 0x0000000189A336A0-0x0000000189A336E0
	public virtual bool SuperToBinary(ByteArray byteArray) => default; // 0x000000018452C090-0x000000018452C180
	[BlackList] // 0x0000000189A3E050-0x0000000189A3E090
	// [XID] // 0x0000000189A3E050-0x0000000189A3E090
	public virtual void AutoAllocTypeFields() {} // 0x000000018452B2C0-0x000000018452B360
	[BlackList] // 0x0000000189A48730-0x0000000189A48770
	// [XID] // 0x0000000189A48730-0x0000000189A48770
	public virtual void AutoRecycleTypeFields() {} // 0x000000018452B360-0x000000018452B400
	[BlackList] // 0x0000000189A52CC0-0x0000000189A52D00
	// [XID] // 0x0000000189A52CC0-0x0000000189A52D00
	public virtual void ReturnToObjectPool() {} // 0x000000018452CE30-0x000000018452CED0
	[BlackList] // 0x0000000189A5D960-0x0000000189A5D9A0
	// [XID] // 0x0000000189A5D960-0x0000000189A5D9A0
	public virtual void OnPoolAllocated() {} // 0x000000018452CD90-0x000000018452CE30
	[BlackList] // 0x0000000189A684B0-0x0000000189A684F0
	// [XID] // 0x0000000189A684B0-0x0000000189A684F0
	public virtual void OnBeforePoolRecycled() {} // 0x000000018452CCF0-0x000000018452CD90
}

