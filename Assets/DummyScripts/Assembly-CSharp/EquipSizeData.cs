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
public class EquipSizeData : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18122
{
	// Fields
	private EquipEntityType _equipType; // 0x10
	private SimpleSafeFloat putAwaySizeRawNum; // 0x14
	private SimpleSafeFloat takeOutSizeRawNum; // 0x18

	// Properties
	public EquipEntityType equipType { /* [XID] */ /* 0x00000001898DE1A0-0x00000001898DE1C0 */ get => default; /* [XID] */ /* 0x00000001898E59A0-0x00000001898E59C0 */ private set {} } // 0x0000000185463260-0x0000000185463300 0x0000000185462A80-0x0000000185462B30
	public float putAwaySize { /* [XID] */ /* 0x00000001898ED3A0-0x00000001898ED3C0 */ get => default; /* [XID] */ /* 0x00000001898F4B80-0x00000001898F4BA0 */ private set {} } // 0x00000001854638A0-0x0000000185463980 0x0000000185462B30-0x0000000185462C10
	public float takeOutSize { /* [XID] */ /* 0x00000001897781B0-0x00000001897781D0 */ get => default; /* [XID] */ /* 0x0000000189903E50-0x0000000189903E70 */ private set {} } // 0x00000001854633E0-0x00000001854634C0 0x0000000185463300-0x00000001854633E0

	// Constructors
	public EquipSizeData() {} // 0x0000000185463F50-0x0000000185464000

	// Methods
	// [XID] // 0x000000018990B3F0-0x000000018990B410
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000185463C50-0x0000000185463D70
	// [XID] // 0x00000001899130A0-0x00000001899130C0
	public void InitEmpty() {} // 0x00000001854634C0-0x00000001854635A0
	[BlackList] // 0x000000018991A870-0x000000018991A8B0
	// [XID] // 0x000000018991A870-0x000000018991A8B0
	public bool FromJson(JSONNode node) => default; // 0x0000000185462EE0-0x0000000185463260
	// [XID] // 0x0000000189924F80-0x0000000189924FA0
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000185462230-0x0000000185462620
	// [XID] // 0x000000018992C580-0x000000018992C5A0
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8BDB */, bool useObjectPool = false /* Metadata: 0x00AF8BDF */) => default; // 0x00000001854635A0-0x00000001854638A0
	// [XID] // 0x0000000189933B60-0x0000000189933B80
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8BE0 */, bool useObjectPool = false /* Metadata: 0x00AF8BE4 */) => default; // 0x0000000185462C10-0x0000000185462EE0
	[BlackList] // 0x000000018993B730-0x000000018993B770
	// [XID] // 0x000000018993B730-0x000000018993B770
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000185462620-0x00000001854628F0
	// [XID] // 0x0000000189945B40-0x0000000189945B60
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000185463980-0x0000000185463C50
	[BlackList] // 0x000000018994CF90-0x000000018994CFD0
	// [XID] // 0x000000018994CF90-0x000000018994CFD0
	public virtual void AutoAllocTypeFields() {} // 0x00000001854628F0-0x0000000185462990
	[BlackList] // 0x0000000189957820-0x0000000189957860
	// [XID] // 0x0000000189957820-0x0000000189957860
	public virtual void AutoRecycleTypeFields() {} // 0x0000000185462990-0x0000000185462A80
	[BlackList] // 0x00000001899623B0-0x00000001899623F0
	// [XID] // 0x00000001899623B0-0x00000001899623F0
	public virtual void ReturnToObjectPool() {} // 0x0000000185463EB0-0x0000000185463F50
	[BlackList] // 0x000000018996C750-0x000000018996C790
	// [XID] // 0x000000018996C750-0x000000018996C790
	public virtual void OnPoolAllocated() {} // 0x0000000185463E10-0x0000000185463EB0
	[BlackList] // 0x0000000189977140-0x0000000189977180
	// [XID] // 0x0000000189977140-0x0000000189977180
	public virtual void OnBeforePoolRecycled() {} // 0x0000000185463D70-0x0000000185463E10
}

