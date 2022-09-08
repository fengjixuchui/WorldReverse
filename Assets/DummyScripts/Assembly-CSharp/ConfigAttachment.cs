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
public class ConfigAttachment : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18038
{
	// Fields
	private string _slotName; // 0x10
	private string _attachPath; // 0x18

	// Properties
	public string slotName { /* [XID] */ /* 0x00000001899698E0-0x0000000189969900 */ get => default; /* [XID] */ /* 0x0000000189971600-0x0000000189971620 */ private set {} } // 0x0000000184A04F60-0x0000000184A05000 0x0000000184A04BD0-0x0000000184A04C80
	public string attachPath { /* [XID] */ /* 0x0000000189779A00-0x0000000189779A20 */ get => default; /* [XID] */ /* 0x0000000189980080-0x00000001899800A0 */ private set {} } // 0x0000000184A04C80-0x0000000184A04D20 0x0000000184A04B20-0x0000000184A04BD0

	// Constructors
	public ConfigAttachment() {} // 0x0000000184A052F0-0x0000000184A05350

	// Methods
	// [XID] // 0x0000000189987830-0x0000000189987850
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000184A05000-0x0000000184A05110
	// [XID] // 0x000000018998F460-0x000000018998F480
	public void InitEmpty() {} // 0x0000000184A04740-0x0000000184A04820
	[BlackList] // 0x0000000189996E00-0x0000000189996E40
	// [XID] // 0x0000000189996E00-0x0000000189996E40
	public bool FromJson(JSONNode node) => default; // 0x0000000184A043C0-0x0000000184A04740
	// [XID] // 0x00000001899A1970-0x00000001899A1990
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000184A03A20-0x0000000184A03CF0
	// [XID] // 0x00000001899A9220-0x00000001899A9240
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8779 */, bool useObjectPool = false /* Metadata: 0x00AF877D */) => default; // 0x0000000184A04820-0x0000000184A04B20
	// [XID] // 0x00000001899B0D10-0x00000001899B0D30
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF877E */, bool useObjectPool = false /* Metadata: 0x00AF8782 */) => default; // 0x0000000184A04100-0x0000000184A043C0
	[BlackList] // 0x00000001899B7F30-0x00000001899B7F70
	// [XID] // 0x00000001899B7F30-0x00000001899B7F70
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000184A03CF0-0x0000000184A03FC0
	// [XID] // 0x00000001899C2A20-0x00000001899C2A40
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000184A04D20-0x0000000184A04F60
	[BlackList] // 0x00000001899CA0C0-0x00000001899CA100
	// [XID] // 0x00000001899CA0C0-0x00000001899CA100
	public virtual void AutoAllocTypeFields() {} // 0x0000000184A03FC0-0x0000000184A04060
	[BlackList] // 0x00000001899D46F0-0x00000001899D4730
	// [XID] // 0x00000001899D46F0-0x00000001899D4730
	public virtual void AutoRecycleTypeFields() {} // 0x0000000184A04060-0x0000000184A04100
	[BlackList] // 0x00000001899DEB50-0x00000001899DEB90
	// [XID] // 0x00000001899DEB50-0x00000001899DEB90
	public virtual void ReturnToObjectPool() {} // 0x0000000184A05250-0x0000000184A052F0
	[BlackList] // 0x00000001899E9560-0x00000001899E95A0
	// [XID] // 0x00000001899E9560-0x00000001899E95A0
	public virtual void OnPoolAllocated() {} // 0x0000000184A051B0-0x0000000184A05250
	[BlackList] // 0x00000001899F4210-0x00000001899F4250
	// [XID] // 0x00000001899F4210-0x00000001899F4250
	public virtual void OnBeforePoolRecycled() {} // 0x0000000184A05110-0x0000000184A051B0
}

