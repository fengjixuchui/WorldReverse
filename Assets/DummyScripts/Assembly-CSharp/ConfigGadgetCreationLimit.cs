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
public class ConfigGadgetCreationLimit : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18114
{
	// Fields
	private string _tag; // 0x10
	private SimpleSafeUInt32[] _gadgetIDs; // 0x18
	private SimpleSafeUInt32 maxValueRawNum; // 0x20

	// Properties
	public string tag { /* [XID] */ /* 0x000000018985B510-0x000000018985B530 */ get => default; /* [XID] */ /* 0x0000000189862A90-0x0000000189862AB0 */ private set {} } // 0x000000018417E730-0x000000018417E7D0 0x000000018417D8A0-0x000000018417D950
	public SimpleSafeUInt32[] gadgetIDs { /* [XID] */ /* 0x0000000189869EC0-0x0000000189869EE0 */ get => default; /* [XID] */ /* 0x00000001898712D0-0x00000001898712F0 */ private set {} } // 0x000000018417E690-0x000000018417E730 0x000000018417DA30-0x000000018417DAE0
	public uint maxValue { /* [XID] */ /* 0x0000000189878CD0-0x0000000189878CF0 */ get => default; /* [XID] */ /* 0x0000000189880280-0x00000001898802A0 */ private set {} } // 0x000000018417E1B0-0x000000018417E280 0x000000018417D950-0x000000018417DA30

	// Constructors
	public ConfigGadgetCreationLimit() {} // 0x000000018417EDF0-0x000000018417EE50

	// Methods
	// [XID] // 0x00000001898877C0-0x00000001898877E0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018417EAF0-0x000000018417EC10
	// [XID] // 0x000000018988EB20-0x000000018988EB40
	public void InitEmpty() {} // 0x000000018417E280-0x000000018417E390
	[BlackList] // 0x0000000189895F60-0x0000000189895FA0
	// [XID] // 0x0000000189895F60-0x0000000189895FA0
	public bool FromJson(JSONNode node) => default; // 0x000000018417DE30-0x000000018417E1B0
	// [XID] // 0x00000001898A04B0-0x00000001898A04D0
	private bool InternalFromJson(JSONNode node) => default; // 0x000000018417D060-0x000000018417D450
	// [XID] // 0x00000001898A7C10-0x00000001898A7C30
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8B8B */, bool useObjectPool = false /* Metadata: 0x00AF8B8F */) => default; // 0x000000018417E390-0x000000018417E690
	// [XID] // 0x00000001898AF790-0x00000001898AF7B0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8B90 */, bool useObjectPool = false /* Metadata: 0x00AF8B94 */) => default; // 0x000000018417DAE0-0x000000018417DE30
	[BlackList] // 0x00000001898B6C90-0x00000001898B6CD0
	// [XID] // 0x00000001898B6C90-0x00000001898B6CD0
	public bool ToBinary(ByteArray byteArray) => default; // 0x000000018417D450-0x000000018417D720
	// [XID] // 0x00000001898C14C0-0x00000001898C14E0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018417E7D0-0x000000018417EAF0
	[BlackList] // 0x00000001898C8DE0-0x00000001898C8E20
	// [XID] // 0x00000001898C8DE0-0x00000001898C8E20
	public virtual void AutoAllocTypeFields() {} // 0x000000018417D720-0x000000018417D7C0
	[BlackList] // 0x00000001898D3330-0x00000001898D3370
	// [XID] // 0x00000001898D3330-0x00000001898D3370
	public virtual void AutoRecycleTypeFields() {} // 0x000000018417D7C0-0x000000018417D8A0
	[BlackList] // 0x00000001898DE1C0-0x00000001898DE200
	// [XID] // 0x00000001898DE1C0-0x00000001898DE200
	public virtual void ReturnToObjectPool() {} // 0x000000018417ED50-0x000000018417EDF0
	[BlackList] // 0x00000001898E8BE0-0x00000001898E8C20
	// [XID] // 0x00000001898E8BE0-0x00000001898E8C20
	public virtual void OnPoolAllocated() {} // 0x000000018417ECB0-0x000000018417ED50
	[BlackList] // 0x00000001898F3400-0x00000001898F3440
	// [XID] // 0x00000001898F3400-0x00000001898F3440
	public virtual void OnBeforePoolRecycled() {} // 0x000000018417EC10-0x000000018417ECB0
}

