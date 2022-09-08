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
public class ExpeditionActivityMarkerExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15089
{
	// Fields
	protected SimpleSafeUInt32 idRawNum; // 0x10
	protected SimpleSafeFloat posXRawNum; // 0x14
	protected SimpleSafeFloat posYRawNum; // 0x18
	protected byte _pictureHashPre; // 0x1C
	protected uint _pictureHashSuffix; // 0x20

	// Properties
	public uint id { /* [XID] */ /* 0x0000000189721350-0x0000000189721370 */ get => default; /* [XID] */ /* 0x0000000189728970-0x0000000189728990 */ protected set {} } // 0x00000001849B2570-0x00000001849B2640 0x00000001849B1B30-0x00000001849B1C10
	public float posX { /* [XID] */ /* 0x0000000189730140-0x0000000189730160 */ get => default; /* [XID] */ /* 0x0000000189737AC0-0x0000000189737AE0 */ protected set {} } // 0x00000001849B2120-0x00000001849B2200 0x00000001849B11C0-0x00000001849B12A0
	public float posY { /* [XID] */ /* 0x000000018973F640-0x000000018973F660 */ get => default; /* [XID] */ /* 0x00000001897469C0-0x00000001897469E0 */ protected set {} } // 0x00000001849B1980-0x00000001849B1A60 0x00000001849B2200-0x00000001849B22E0
	public byte pictureHashPre { /* [XID] */ /* 0x000000018974E3B0-0x000000018974E3D0 */ get => default; /* [XID] */ /* 0x0000000189755A10-0x0000000189755A30 */ protected set {} } // 0x00000001849B1120-0x00000001849B11C0 0x00000001849B0EB0-0x00000001849B0F60
	public uint pictureHashSuffix { /* [XID] */ /* 0x000000018975CD30-0x000000018975CD50 */ get => default; /* [XID] */ /* 0x00000001897644A0-0x00000001897644C0 */ protected set {} } // 0x00000001849B2390-0x00000001849B2430 0x00000001849B22E0-0x00000001849B2390
	public ulong pictureHash { /* [XID] */ /* 0x000000018976BE60-0x000000018976BE80 */ get => default; } // 0x00000001849B1A60-0x00000001849B1B30 

	// Constructors
	public ExpeditionActivityMarkerExcelConfig() {} // 0x00000001849B26E0-0x00000001849B2740

	// Methods
	// [IDTag] // 0x0000000189773320-0x0000000189773360
	// [XID] // 0x0000000189773320-0x0000000189773360
	public virtual bool ParseFromLine(string line) => default; // 0x00000001849B15F0-0x00000001849B1980
	// [IDTag] // 0x000000018977DBC0-0x000000018977DC00
	// [XID] // 0x000000018977DBC0-0x000000018977DC00
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x00000001849B12A0-0x00000001849B15F0
	// [XID] // 0x0000000189788240-0x0000000189788260
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF0085 */, bool useObjectPool = false /* Metadata: 0x00AF0089 */) => default; // 0x00000001849B1C10-0x00000001849B2120
	[BlackList] // 0x000000018978F800-0x000000018978F840
	// [XID] // 0x000000018978F800-0x000000018978F840
	public virtual void AutoAllocTypeFields() {} // 0x00000001849B0F60-0x00000001849B1000
	[BlackList] // 0x0000000189799EB0-0x0000000189799EF0
	// [XID] // 0x0000000189799EB0-0x0000000189799EF0
	public virtual void AutoRecycleTypeFields() {} // 0x00000001849B1000-0x00000001849B1120
	[BlackList] // 0x00000001897A5050-0x00000001897A5090
	// [XID] // 0x00000001897A5050-0x00000001897A5090
	public virtual void ReturnToObjectPool() {} // 0x00000001849B2640-0x00000001849B26E0
	[BlackList] // 0x00000001897AF730-0x00000001897AF770
	// [XID] // 0x00000001897AF730-0x00000001897AF770
	public virtual void OnPoolAllocated() {} // 0x00000001849B24D0-0x00000001849B2570
	[BlackList] // 0x00000001897B9FB0-0x00000001897B9FF0
	// [XID] // 0x00000001897B9FB0-0x00000001897B9FF0
	public virtual void OnBeforePoolRecycled() {} // 0x00000001849B2430-0x00000001849B24D0
}

