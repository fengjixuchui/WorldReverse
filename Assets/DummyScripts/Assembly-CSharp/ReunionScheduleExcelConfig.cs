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
public class ReunionScheduleExcelConfig : IAutoAllocRecycle // TypeDefIndex: 16054
{
	// Fields
	protected SimpleSafeUInt32 idRawNum; // 0x10
	protected SimpleSafeUInt32 activateLevelRawNum; // 0x14
	protected SimpleSafeUInt32 firstGiftRewardIdRawNum; // 0x18
	protected SimpleSafeUInt32 dailySignInIdRawNum; // 0x1C
	protected SimpleSafeUInt32 reunionMissionIdRawNum; // 0x20
	protected SimpleSafeUInt32 reunionPrivilegeIdRawNum; // 0x24

	// Properties
	public uint id { /* [XID] */ /* 0x0000000189936D50-0x0000000189936D70 */ get => default; /* [XID] */ /* 0x000000018993E910-0x000000018993E930 */ protected set {} } // 0x0000000182E9EE60-0x0000000182E9EF30 0x0000000182E9E2E0-0x0000000182E9E3C0
	public uint activateLevel { /* [XID] */ /* 0x0000000189945F40-0x0000000189945F60 */ get => default; /* [XID] */ /* 0x000000018994D450-0x000000018994D470 */ protected set {} } // 0x0000000182E9E060-0x0000000182E9E130 0x0000000182E9D660-0x0000000182E9D740
	public uint firstGiftRewardId { /* [XID] */ /* 0x0000000189954B20-0x0000000189954B40 */ get => default; /* [XID] */ /* 0x000000018995C320-0x000000018995C340 */ protected set {} } // 0x0000000182E9E130-0x0000000182E9E200 0x0000000182E9EA80-0x0000000182E9EB60
	public uint dailySignInId { /* [XID] */ /* 0x0000000189963D60-0x0000000189963D80 */ get => default; /* [XID] */ /* 0x000000018996B2D0-0x000000018996B2F0 */ protected set {} } // 0x0000000182E9E9B0-0x0000000182E9EA80 0x0000000182E9EC40-0x0000000182E9ED20
	public uint reunionMissionId { /* [XID] */ /* 0x0000000189972D90-0x0000000189972DB0 */ get => default; /* [XID] */ /* 0x000000018997A670-0x000000018997A690 */ protected set {} } // 0x0000000182E9D590-0x0000000182E9D660 0x0000000182E9EB60-0x0000000182E9EC40
	public uint reunionPrivilegeId { /* [XID] */ /* 0x0000000189982040-0x0000000189982060 */ get => default; /* [XID] */ /* 0x00000001899898C0-0x00000001899898E0 */ protected set {} } // 0x0000000182E9DF90-0x0000000182E9E060 0x0000000182E9E200-0x0000000182E9E2E0

	// Constructors
	public ReunionScheduleExcelConfig() {} // 0x0000000182E9EFD0-0x0000000182E9F030

	// Methods
	// [IDTag] // 0x00000001899910F0-0x0000000189991130
	// [XID] // 0x00000001899910F0-0x0000000189991130
	public virtual bool ParseFromLine(string line) => default; // 0x0000000182E9D740-0x0000000182E9DB80
	// [IDTag] // 0x000000018999BBE0-0x000000018999BC20
	// [XID] // 0x000000018999BBE0-0x000000018999BC20
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000182E9DB80-0x0000000182E9DF90
	// [XID] // 0x00000001899A6690-0x00000001899A66B0
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2F07 */, bool useObjectPool = false /* Metadata: 0x00AF2F0B */) => default; // 0x0000000182E9E3C0-0x0000000182E9E9B0
	[BlackList] // 0x00000001899ADE00-0x00000001899ADE40
	// [XID] // 0x00000001899ADE00-0x00000001899ADE40
	public virtual void AutoAllocTypeFields() {} // 0x0000000182E9D3C0-0x0000000182E9D460
	[BlackList] // 0x00000001899B82F0-0x00000001899B8330
	// [XID] // 0x00000001899B82F0-0x00000001899B8330
	public virtual void AutoRecycleTypeFields() {} // 0x0000000182E9D460-0x0000000182E9D590
	[BlackList] // 0x00000001899C3060-0x00000001899C30A0
	// [XID] // 0x00000001899C3060-0x00000001899C30A0
	public virtual void ReturnToObjectPool() {} // 0x0000000182E9EF30-0x0000000182E9EFD0
	[BlackList] // 0x00000001899CD630-0x00000001899CD670
	// [XID] // 0x00000001899CD630-0x00000001899CD670
	public virtual void OnPoolAllocated() {} // 0x0000000182E9EDC0-0x0000000182E9EE60
	[BlackList] // 0x00000001899D7AB0-0x00000001899D7AF0
	// [XID] // 0x00000001899D7AB0-0x00000001899D7AF0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000182E9ED20-0x0000000182E9EDC0
}

