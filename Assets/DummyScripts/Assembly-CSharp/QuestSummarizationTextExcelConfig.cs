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
using Newtonsoft.Json;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class QuestSummarizationTextExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15323
{
	// Fields
	public static Func<uint, string> getLocalizedTextHandler; // 0x00
	protected SimpleSafeUInt32 IdRawNum; // 0x10
	protected uint _DescTextMapHash; // 0x14

	// Properties
	public uint Id { /* [XID] */ /* 0x00000001898ACAC0-0x00000001898ACAE0 */ get => default; /* [XID] */ /* 0x00000001898B3F40-0x00000001898B3F60 */ protected set {} } // 0x0000000181356BA0-0x0000000181356C70 0x0000000181356FD0-0x00000001813570B0
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint DescTextMapHash { /* [XID] */ /* 0x00000001898BBC10-0x00000001898BBC30 */ get => default; /* [XID] */ /* 0x00000001898C3120-0x00000001898C3140 */ protected set {} } // 0x0000000181356500-0x00000001813565A0 0x0000000181357230-0x00000001813572E0
	public string Desc { /* [XID] */ /* 0x00000001898CAB00-0x00000001898CAB20 */ get => default; } // 0x00000001813570B0-0x0000000181357230 

	// Constructors
	public QuestSummarizationTextExcelConfig() {} // 0x00000001813574C0-0x0000000181357520

	// Methods
	// [IDTag] // 0x00000001898D21B0-0x00000001898D21F0
	// [XID] // 0x00000001898D21B0-0x00000001898D21F0
	public virtual bool ParseFromLine(string line) => default; // 0x0000000181356930-0x0000000181356BA0
	// [IDTag] // 0x00000001898DCB90-0x00000001898DCBD0
	// [XID] // 0x00000001898DCB90-0x00000001898DCBD0
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000181356710-0x0000000181356930
	// [XID] // 0x00000001898E7AB0-0x00000001898E7AD0
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF078B */, bool useObjectPool = false /* Metadata: 0x00AF078F */) => default; // 0x0000000181356C70-0x0000000181356FD0
	[BlackList] // 0x00000001898EF160-0x00000001898EF1A0
	// [XID] // 0x00000001898EF160-0x00000001898EF1A0
	public virtual void AutoAllocTypeFields() {} // 0x00000001813565A0-0x0000000181356640
	[BlackList] // 0x00000001898F9970-0x00000001898F99B0
	// [XID] // 0x00000001898F9970-0x00000001898F99B0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000181356640-0x0000000181356710
	[BlackList] // 0x0000000189904230-0x0000000189904270
	// [XID] // 0x0000000189904230-0x0000000189904270
	public virtual void ReturnToObjectPool() {} // 0x0000000181357420-0x00000001813574C0
	[BlackList] // 0x000000018990EBB0-0x000000018990EBF0
	// [XID] // 0x000000018990EBB0-0x000000018990EBF0
	public virtual void OnPoolAllocated() {} // 0x0000000181357380-0x0000000181357420
	[BlackList] // 0x00000001899194C0-0x0000000189919500
	// [XID] // 0x00000001899194C0-0x0000000189919500
	public virtual void OnBeforePoolRecycled() {} // 0x00000001813572E0-0x0000000181357380
}

