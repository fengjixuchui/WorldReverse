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
public class HuntingRefreshExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15744
{
	// Fields
	protected SimpleSafeUInt32 idRawNum; // 0x10
	protected SimpleSafeUInt32 cityIdRawNum; // 0x14
	protected HuntingOfferDifficultyType _difficulty; // 0x18
	protected SimpleSafeUInt32 regionIdRawNum; // 0x1C
	protected SimpleSafeUInt32 finishRewardIdRawNum; // 0x20

	// Properties
	public uint id { /* [XID] */ /* 0x0000000189753E60-0x0000000189753E80 */ get => default; /* [XID] */ /* 0x000000018975B3A0-0x000000018975B3C0 */ protected set {} } // 0x000000018347F3A0-0x000000018347F470 0x000000018347E9E0-0x000000018347EAC0
	public uint cityId { /* [XID] */ /* 0x0000000189762D30-0x0000000189762D50 */ get => default; /* [XID] */ /* 0x000000018976A350-0x000000018976A370 */ protected set {} } // 0x000000018347F190-0x000000018347F260 0x000000018347E830-0x000000018347E910
	public HuntingOfferDifficultyType difficulty { /* [XID] */ /* 0x0000000189771BB0-0x0000000189771BD0 */ get => default; /* [XID] */ /* 0x0000000189779360-0x0000000189779380 */ protected set {} } // 0x000000018347F0F0-0x000000018347F190 0x000000018347F550-0x000000018347F600
	public uint regionId { /* [XID] */ /* 0x0000000189780B60-0x0000000189780B80 */ get => default; /* [XID] */ /* 0x0000000189788160-0x0000000189788180 */ protected set {} } // 0x000000018347E910-0x000000018347E9E0 0x000000018347F470-0x000000018347F550
	public uint finishRewardId { /* [XID] */ /* 0x000000018978F760-0x000000018978F780 */ get => default; /* [XID] */ /* 0x0000000189796F70-0x0000000189796F90 */ protected set {} } // 0x000000018347DE20-0x000000018347DEF0 0x000000018347F010-0x000000018347F0F0

	// Constructors
	public HuntingRefreshExcelConfig() {} // 0x000000018347F6A0-0x000000018347F700

	// Methods
	// [IDTag] // 0x000000018979EFB0-0x000000018979EFF0
	// [XID] // 0x000000018979EFB0-0x000000018979EFF0
	public virtual bool ParseFromLine(string line) => default; // 0x000000018347E450-0x000000018347E830
	// [IDTag] // 0x00000001897A9500-0x00000001897A9540
	// [XID] // 0x00000001897A9500-0x00000001897A9540
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x000000018347E0A0-0x000000018347E450
	// [XID] // 0x00000001897B4470-0x00000001897B4490
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF24D6 */, bool useObjectPool = false /* Metadata: 0x00AF24DA */) => default; // 0x000000018347EAC0-0x000000018347F010
	[BlackList] // 0x00000001897BC170-0x00000001897BC1B0
	// [XID] // 0x00000001897BC170-0x00000001897BC1B0
	public virtual void AutoAllocTypeFields() {} // 0x000000018347DEF0-0x000000018347DF90
	[BlackList] // 0x00000001897C6A40-0x00000001897C6A80
	// [XID] // 0x00000001897C6A40-0x00000001897C6A80
	public virtual void AutoRecycleTypeFields() {} // 0x000000018347DF90-0x000000018347E0A0
	[BlackList] // 0x00000001897D0F50-0x00000001897D0F90
	// [XID] // 0x00000001897D0F50-0x00000001897D0F90
	public virtual void ReturnToObjectPool() {} // 0x000000018347F600-0x000000018347F6A0
	[BlackList] // 0x00000001897DB890-0x00000001897DB8D0
	// [XID] // 0x00000001897DB890-0x00000001897DB8D0
	public virtual void OnPoolAllocated() {} // 0x000000018347F300-0x000000018347F3A0
	[BlackList] // 0x00000001897E61B0-0x00000001897E61F0
	// [XID] // 0x00000001897E61B0-0x00000001897E61F0
	public virtual void OnBeforePoolRecycled() {} // 0x000000018347F260-0x000000018347F300
}

