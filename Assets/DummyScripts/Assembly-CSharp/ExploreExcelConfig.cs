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
public class ExploreExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15599
{
	// Fields
	protected SimpleSafeUInt32 materialIDRawNum; // 0x10
	protected SimpleSafeUInt32 expRawNum; // 0x14

	// Properties
	public uint materialID { /* [XID] */ /* 0x00000001896673F0-0x0000000189667410 */ get => default; /* [XID] */ /* 0x000000018966EC00-0x000000018966EC20 */ protected set {} } // 0x00000001825B0F40-0x00000001825B1010 0x00000001825B08F0-0x00000001825B09D0
	public uint exp { /* [XID] */ /* 0x0000000189676620-0x0000000189676640 */ get => default; /* [XID] */ /* 0x000000018967DDE0-0x000000018967DE00 */ protected set {} } // 0x00000001825B1370-0x00000001825B1440 0x00000001825B0E60-0x00000001825B0F40

	// Constructors
	public ExploreExcelConfig() {} // 0x00000001825B1620-0x00000001825B16A0

	// Methods
	// [IDTag] // 0x0000000189685500-0x0000000189685540
	// [XID] // 0x0000000189685500-0x0000000189685540
	public virtual bool ParseFromLine(string line) => default; // 0x00000001825B09D0-0x00000001825B0C40
	// [IDTag] // 0x0000000189690500-0x0000000189690540
	// [XID] // 0x0000000189690500-0x0000000189690540
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x00000001825B0C40-0x00000001825B0E60
	// [XID] // 0x000000018969A930-0x000000018969A950
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF202E */, bool useObjectPool = false /* Metadata: 0x00AF2032 */) => default; // 0x00000001825B1010-0x00000001825B1370
	[BlackList] // 0x00000001896A2300-0x00000001896A2340
	// [XID] // 0x00000001896A2300-0x00000001896A2340
	public virtual void AutoAllocTypeFields() {} // 0x00000001825B0770-0x00000001825B0810
	[BlackList] // 0x00000001896AC4B0-0x00000001896AC4F0
	// [XID] // 0x00000001896AC4B0-0x00000001896AC4F0
	public virtual void AutoRecycleTypeFields() {} // 0x00000001825B0810-0x00000001825B08F0
	[BlackList] // 0x00000001896B6740-0x00000001896B6780
	// [XID] // 0x00000001896B6740-0x00000001896B6780
	public virtual void ReturnToObjectPool() {} // 0x00000001825B1580-0x00000001825B1620
	[BlackList] // 0x00000001896C0A00-0x00000001896C0A40
	// [XID] // 0x00000001896C0A00-0x00000001896C0A40
	public virtual void OnPoolAllocated() {} // 0x00000001825B14E0-0x00000001825B1580
	[BlackList] // 0x00000001896CAE90-0x00000001896CAED0
	// [XID] // 0x00000001896CAE90-0x00000001896CAED0
	public virtual void OnBeforePoolRecycled() {} // 0x00000001825B1440-0x00000001825B14E0
}

