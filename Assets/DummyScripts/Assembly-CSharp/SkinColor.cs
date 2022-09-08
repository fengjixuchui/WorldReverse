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
public class SkinColor : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 19002
{
	// Fields
	private string _renderer; // 0x10
	private SimpleSafeInt32 indexRawNum; // 0x18
	private SimpleSafeInt32 channelRawNum; // 0x1C
	private string _color; // 0x20

	// Properties
	public string renderer { /* [XID] */ /* 0x00000001896A52D0-0x00000001896A52F0 */ get => default; /* [XID] */ /* 0x000000018995EFF0-0x000000018995F010 */ private set {} } // 0x000000018479BF40-0x000000018479BFE0 0x000000018479BFE0-0x000000018479C090
	public int index { /* [XID] */ /* 0x0000000189966830-0x0000000189966850 */ get => default; /* [XID] */ /* 0x000000018996DCA0-0x000000018996DCC0 */ private set {} } // 0x000000018479CA60-0x000000018479CB30 0x000000018479CE30-0x000000018479CF10
	public int channel { /* [XID] */ /* 0x00000001896B3E50-0x00000001896B3E70 */ get => default; /* [XID] */ /* 0x000000018997C950-0x000000018997C970 */ private set {} } // 0x000000018479C460-0x000000018479C530 0x000000018479B530-0x000000018479B610
	public string color { /* [XID] */ /* 0x000000018969E1A0-0x000000018969E1C0 */ get => default; /* [XID] */ /* 0x000000018998C190-0x000000018998C1B0 */ private set {} } // 0x000000018479C9C0-0x000000018479CA60 0x000000018479D2C0-0x000000018479D370

	// Constructors
	public SkinColor() {} // 0x000000018479D690-0x000000018479D700

	// Methods
	// [XID] // 0x0000000189993ED0-0x0000000189993EF0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018479D370-0x000000018479D4B0
	// [XID] // 0x000000018999B720-0x000000018999B740
	public void InitEmpty() {} // 0x000000018479C8B0-0x000000018479C9C0
	[BlackList] // 0x00000001899A2E10-0x00000001899A2E50
	// [XID] // 0x00000001899A2E10-0x00000001899A2E50
	public bool FromJson(JSONNode node) => default; // 0x000000018479C530-0x000000018479C8B0
	// [XID] // 0x00000001899AD880-0x00000001899AD8A0
	private bool InternalFromJson(JSONNode node) => default; // 0x000000018479B610-0x000000018479BAE0
	// [XID] // 0x00000001899B5140-0x00000001899B5160
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB6F9 */, bool useObjectPool = false /* Metadata: 0x00AFB6FD */) => default; // 0x000000018479CB30-0x000000018479CE30
	// [XID] // 0x00000001899BC7D0-0x00000001899BC7F0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB6FE */, bool useObjectPool = false /* Metadata: 0x00AFB702 */) => default; // 0x000000018479C090-0x000000018479C460
	[BlackList] // 0x00000001899C41A0-0x00000001899C41E0
	// [XID] // 0x00000001899C41A0-0x00000001899C41E0
	public bool ToBinary(ByteArray byteArray) => default; // 0x000000018479BAE0-0x000000018479BDB0
	// [XID] // 0x00000001899CE780-0x00000001899CE7A0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018479CF10-0x000000018479D2C0
	[BlackList] // 0x00000001899D5E10-0x00000001899D5E50
	// [XID] // 0x00000001899D5E10-0x00000001899D5E50
	public virtual void AutoAllocTypeFields() {} // 0x000000018479BDB0-0x000000018479BE50
	[BlackList] // 0x00000001899E0360-0x00000001899E03A0
	// [XID] // 0x00000001899E0360-0x00000001899E03A0
	public virtual void AutoRecycleTypeFields() {} // 0x000000018479BE50-0x000000018479BF40
	[BlackList] // 0x00000001899EAA00-0x00000001899EAA40
	// [XID] // 0x00000001899EAA00-0x00000001899EAA40
	public virtual void ReturnToObjectPool() {} // 0x000000018479D5F0-0x000000018479D690
	[BlackList] // 0x00000001899F5550-0x00000001899F5590
	// [XID] // 0x00000001899F5550-0x00000001899F5590
	public virtual void OnPoolAllocated() {} // 0x000000018479D550-0x000000018479D5F0
	[BlackList] // 0x00000001899FF920-0x00000001899FF960
	// [XID] // 0x00000001899FF920-0x00000001899FF960
	public virtual void OnBeforePoolRecycled() {} // 0x000000018479D4B0-0x000000018479D550
}

