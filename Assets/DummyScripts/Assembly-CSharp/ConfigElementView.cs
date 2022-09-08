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
public class ConfigElementView : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17922
{
	// Fields
	private Dictionary<string, SimpleSafeInt32> _elementColorIndex; // 0x10
	private SimpleSafeUInt32 terrainGrassColorRawNum; // 0x18

	// Properties
	public Dictionary<string, SimpleSafeInt32> elementColorIndex { /* [XID] */ /* 0x0000000189AFEB70-0x0000000189AFEB90 */ get => default; /* [XID] */ /* 0x0000000189B06300-0x0000000189B06320 */ private set {} } // 0x00000001842E6D30-0x00000001842E6DD0 0x00000001842E6900-0x00000001842E69B0
	public uint terrainGrassColor { /* [XID] */ /* 0x0000000189B0DAB0-0x0000000189B0DAD0 */ get => default; /* [XID] */ /* 0x0000000189B14ED0-0x0000000189B14EF0 */ private set {} } // 0x00000001842E72B0-0x00000001842E7380 0x00000001842E6DD0-0x00000001842E6EB0

	// Constructors
	public ConfigElementView() {} // 0x00000001842E7910-0x00000001842E7970

	// Methods
	// [XID] // 0x0000000189B1C870-0x0000000189B1C890
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001842E7620-0x00000001842E7730
	// [XID] // 0x0000000189B23E20-0x0000000189B23E40
	public void InitEmpty() {} // 0x00000001842E6EB0-0x00000001842E6FB0
	[BlackList] // 0x0000000189B2B100-0x0000000189B2B140
	// [XID] // 0x0000000189B2B100-0x0000000189B2B140
	public bool FromJson(JSONNode node) => default; // 0x00000001842E69B0-0x00000001842E6D30
	// [XID] // 0x0000000189BC52A0-0x0000000189BC52C0
	private bool InternalFromJson(JSONNode node) => default; // 0x00000001842E5ED0-0x00000001842E61E0
	// [XID] // 0x000000018983D290-0x000000018983D2B0
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF821D */, bool useObjectPool = false /* Metadata: 0x00AF8221 */) => default; // 0x00000001842E6FB0-0x00000001842E72B0
	// [XID] // 0x0000000189B449D0-0x0000000189B449F0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8222 */, bool useObjectPool = false /* Metadata: 0x00AF8226 */) => default; // 0x00000001842E6630-0x00000001842E6900
	[BlackList] // 0x0000000189B4C220-0x0000000189B4C260
	// [XID] // 0x0000000189B4C220-0x0000000189B4C260
	public bool ToBinary(ByteArray byteArray) => default; // 0x00000001842E61E0-0x00000001842E64B0
	// [XID] // 0x0000000189B56A70-0x0000000189B56A90
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001842E7380-0x00000001842E7620
	[BlackList] // 0x0000000189B5E2A0-0x0000000189B5E2E0
	// [XID] // 0x0000000189B5E2A0-0x0000000189B5E2E0
	public virtual void AutoAllocTypeFields() {} // 0x00000001842E64B0-0x00000001842E6550
	[BlackList] // 0x0000000189B688C0-0x0000000189B68900
	// [XID] // 0x0000000189B688C0-0x0000000189B68900
	public virtual void AutoRecycleTypeFields() {} // 0x00000001842E6550-0x00000001842E6630
	[BlackList] // 0x0000000189B72DF0-0x0000000189B72E30
	// [XID] // 0x0000000189B72DF0-0x0000000189B72E30
	public virtual void ReturnToObjectPool() {} // 0x00000001842E7870-0x00000001842E7910
	[BlackList] // 0x0000000189B7D180-0x0000000189B7D1C0
	// [XID] // 0x0000000189B7D180-0x0000000189B7D1C0
	public virtual void OnPoolAllocated() {} // 0x00000001842E77D0-0x00000001842E7870
	[BlackList] // 0x0000000189B87C40-0x0000000189B87C80
	// [XID] // 0x0000000189B87C40-0x0000000189B87C80
	public virtual void OnBeforePoolRecycled() {} // 0x00000001842E7730-0x00000001842E77D0
}

