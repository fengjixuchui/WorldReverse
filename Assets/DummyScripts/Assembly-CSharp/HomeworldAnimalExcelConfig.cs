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
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class HomeworldAnimalExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15712
{
	// Fields
	protected SimpleSafeUInt32 furnitureIDRawNum; // 0x10
	protected SimpleSafeUInt32 monsterIDRawNum; // 0x14
	protected SimpleSafeUInt32 isRebirthRawNum; // 0x18
	protected SimpleSafeUInt32 rebirthCDRawNum; // 0x1C

	// Properties
	public uint furnitureID { /* [XID] */ /* 0x0000000189626A00-0x0000000189626A20 */ get => default; /* [XID] */ /* 0x000000018962E330-0x000000018962E350 */ protected set {} } // 0x0000000183095260-0x0000000183095330 0x0000000183095180-0x0000000183095260
	public uint monsterID { /* [XID] */ /* 0x0000000189635F10-0x0000000189635F30 */ get => default; /* [XID] */ /* 0x000000018963D670-0x000000018963D690 */ protected set {} } // 0x0000000183095B50-0x0000000183095C20 0x0000000183095CF0-0x0000000183095DD0
	public uint isRebirth { /* [XID] */ /* 0x0000000189644BF0-0x0000000189644C10 */ get => default; /* [XID] */ /* 0x000000018964C5D0-0x000000018964C5F0 */ protected set {} } // 0x0000000183095C20-0x0000000183095CF0 0x0000000183096430-0x0000000183096510
	public uint rebirthCD { /* [XID] */ /* 0x0000000189653B60-0x0000000189653B80 */ get => default; /* [XID] */ /* 0x000000018965B430-0x000000018965B450 */ protected set {} } // 0x0000000183096360-0x0000000183096430 0x0000000183096280-0x0000000183096360

	// Constructors
	public HomeworldAnimalExcelConfig() {} // 0x00000001830966F0-0x0000000183096750

	// Methods
	// [IDTag] // 0x0000000189662880-0x00000001896628C0
	// [XID] // 0x0000000189662880-0x00000001896628C0
	public virtual bool ParseFromLine(string line) => default; // 0x00000001830954E0-0x0000000183095830
	// [IDTag] // 0x000000018966D060-0x000000018966D0A0
	// [XID] // 0x000000018966D060-0x000000018966D0A0
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000183095830-0x0000000183095B50
	// [XID] // 0x0000000189677F10-0x0000000189677F30
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF23F0 */, bool useObjectPool = false /* Metadata: 0x00AF23F4 */) => default; // 0x0000000183095DD0-0x0000000183096280
	[BlackList] // 0x000000018967F5C0-0x000000018967F600
	// [XID] // 0x000000018967F5C0-0x000000018967F600
	public virtual void AutoAllocTypeFields() {} // 0x0000000183095330-0x00000001830953D0
	[BlackList] // 0x000000018968A090-0x000000018968A0D0
	// [XID] // 0x000000018968A090-0x000000018968A0D0
	public virtual void AutoRecycleTypeFields() {} // 0x00000001830953D0-0x00000001830954E0
	[BlackList] // 0x0000000189694B20-0x0000000189694B60
	// [XID] // 0x0000000189694B20-0x0000000189694B60
	public virtual void ReturnToObjectPool() {} // 0x0000000183096650-0x00000001830966F0
	[BlackList] // 0x000000018969F010-0x000000018969F050
	// [XID] // 0x000000018969F010-0x000000018969F050
	public virtual void OnPoolAllocated() {} // 0x00000001830965B0-0x0000000183096650
	[BlackList] // 0x00000001896A9500-0x00000001896A9540
	// [XID] // 0x00000001896A9500-0x00000001896A9540
	public virtual void OnBeforePoolRecycled() {} // 0x0000000183096510-0x00000001830965B0
}

