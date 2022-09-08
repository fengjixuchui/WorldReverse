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
public class SECTR_StreamTreeObject : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18973
{
	// Fields
	private SimpleSafeUInt32 colorIndexRawNum; // 0x10

	// Properties
	public uint colorIndex { /* [XID] */ /* 0x0000000189996C00-0x0000000189996C20 */ get => default; /* [XID] */ /* 0x000000018999E8D0-0x000000018999E8F0 */ private set {} } // 0x00000001825CFD90-0x00000001825CFE60 0x00000001825D03F0-0x00000001825D04D0

	// Constructors
	public SECTR_StreamTreeObject() {} // 0x00000001825D0D40-0x00000001825D0DA0

	// Methods
	// [XID] // 0x00000001899A6290-0x00000001899A62B0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001825D0A80-0x00000001825D0B60
	// [XID] // 0x00000001899AD8A0-0x00000001899AD8C0
	public void InitEmpty() {} // 0x00000001825D04D0-0x00000001825D05A0
	[BlackList] // 0x00000001899B5160-0x00000001899B51A0
	// [XID] // 0x00000001899B5160-0x00000001899B51A0
	public bool FromJson(JSONNode node) => default; // 0x00000001825D0070-0x00000001825D03F0
	// [XID] // 0x00000001899BFA70-0x00000001899BFA90
	private bool InternalFromJson(JSONNode node) => default; // 0x00000001825CF730-0x00000001825CF950
	// [XID] // 0x00000001899C7230-0x00000001899C7250
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB5FD */, bool useObjectPool = false /* Metadata: 0x00AFB601 */) => default; // 0x00000001825D05A0-0x00000001825D08A0
	// [XID] // 0x00000001899CE7A0-0x00000001899CE7C0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB602 */, bool useObjectPool = false /* Metadata: 0x00AFB606 */) => default; // 0x00000001825CFE60-0x00000001825D0070
	[BlackList] // 0x00000001899D5E70-0x00000001899D5EB0
	// [XID] // 0x00000001899D5E70-0x00000001899D5EB0
	public bool ToBinary(ByteArray byteArray) => default; // 0x00000001825CF950-0x00000001825CFC20
	// [XID] // 0x00000001899E03A0-0x00000001899E03C0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001825D08A0-0x00000001825D0A80
	[BlackList] // 0x00000001899E7E80-0x00000001899E7EC0
	// [XID] // 0x00000001899E7E80-0x00000001899E7EC0
	public virtual void AutoAllocTypeFields() {} // 0x00000001825CFC20-0x00000001825CFCC0
	[BlackList] // 0x00000001899F2560-0x00000001899F25A0
	// [XID] // 0x00000001899F2560-0x00000001899F25A0
	public virtual void AutoRecycleTypeFields() {} // 0x00000001825CFCC0-0x00000001825CFD90
	[BlackList] // 0x00000001899FCBF0-0x00000001899FCC30
	// [XID] // 0x00000001899FCBF0-0x00000001899FCC30
	public virtual void ReturnToObjectPool() {} // 0x00000001825D0CA0-0x00000001825D0D40
	[BlackList] // 0x0000000189A07190-0x0000000189A071D0
	// [XID] // 0x0000000189A07190-0x0000000189A071D0
	public virtual void OnPoolAllocated() {} // 0x00000001825D0C00-0x00000001825D0CA0
	[BlackList] // 0x0000000189A119E0-0x0000000189A11A20
	// [XID] // 0x0000000189A119E0-0x0000000189A11A20
	public virtual void OnBeforePoolRecycled() {} // 0x00000001825D0B60-0x00000001825D0C00
}

