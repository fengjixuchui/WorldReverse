/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
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
public class ConfigHomePlaceColPath : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18343
{
	// Fields
	private Dictionary<string, SimpleSafeUInt32[]> _placeColPath; // 0x10

	// Properties
	public Dictionary<string, SimpleSafeUInt32[]> placeColPath { /* [XID] */ /* 0x00000001896868D0-0x00000001896868F0 */ get => default; /* [XID] */ /* 0x000000018968E6F0-0x000000018968E710 */ private set {} } // 0x000000018316D870-0x000000018316D910 0x000000018316D5A0-0x000000018316D650

	// Constructors
	public ConfigHomePlaceColPath() {} // 0x000000018316D9B0-0x000000018316DA10

	// Methods
	// [XID] // 0x0000000189696170-0x0000000189696190
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018316D650-0x000000018316D730
	// [XID] // 0x000000018969D830-0x000000018969D850
	public void InitEmpty() {} // 0x000000018316CFE0-0x000000018316D0B0
	[BlackList] // 0x00000001896A4840-0x00000001896A4880
	// [XID] // 0x00000001896A4840-0x00000001896A4880
	public bool FromJson(JSONNode node) => default; // 0x000000018316CC60-0x000000018316CFE0
	// [XID] // 0x00000001896AED30-0x00000001896AED50
	private bool InternalFromJson(JSONNode node) => default; // 0x000000018316C460-0x000000018316C640
	// [XID] // 0x00000001896B6440-0x00000001896B6460
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF94C7 */, bool useObjectPool = false /* Metadata: 0x00AF94CB */) => default; // 0x000000018316D0B0-0x000000018316D3B0
	// [XID] // 0x00000001896BD6C0-0x00000001896BD6E0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF94CC */, bool useObjectPool = false /* Metadata: 0x00AF94D0 */) => default; // 0x000000018316CA50-0x000000018316CC60
	[BlackList] // 0x00000001896C4D70-0x00000001896C4DB0
	// [XID] // 0x00000001896C4D70-0x00000001896C4DB0
	public bool ToBinary(ByteArray byteArray) => default; // 0x000000018316C640-0x000000018316C910
	// [XID] // 0x00000001896CF630-0x00000001896CF650
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018316D3B0-0x000000018316D5A0
	[BlackList] // 0x00000001896D6840-0x00000001896D6880
	// [XID] // 0x00000001896D6840-0x00000001896D6880
	public virtual void AutoAllocTypeFields() {} // 0x000000018316C910-0x000000018316C9B0
	[BlackList] // 0x00000001896E0FF0-0x00000001896E1030
	// [XID] // 0x00000001896E0FF0-0x00000001896E1030
	public virtual void AutoRecycleTypeFields() {} // 0x000000018316C9B0-0x000000018316CA50
	[BlackList] // 0x00000001896EB3A0-0x00000001896EB3E0
	// [XID] // 0x00000001896EB3A0-0x00000001896EB3E0
	public virtual void ReturnToObjectPool() {} // 0x000000018316D910-0x000000018316D9B0
	[BlackList] // 0x00000001896F5A40-0x00000001896F5A80
	// [XID] // 0x00000001896F5A40-0x00000001896F5A80
	public virtual void OnPoolAllocated() {} // 0x000000018316D7D0-0x000000018316D870
	[BlackList] // 0x0000000189700060-0x00000001897000A0
	// [XID] // 0x0000000189700060-0x00000001897000A0
	public virtual void OnBeforePoolRecycled() {} // 0x000000018316D730-0x000000018316D7D0
}

