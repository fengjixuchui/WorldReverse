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
public class PushTipsCodexExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15319
{
	// Fields
	protected SimpleSafeUInt32 IdRawNum; // 0x10
	protected SimpleSafeUInt32 PushTipIdRawNum; // 0x14
	protected SimpleSafeUInt32 SortOrderRawNum; // 0x18
	protected bool _isDisuse; // 0x1C

	// Properties
	public uint Id { /* [XID] */ /* 0x00000001895E96F0-0x00000001895E9710 */ get => default; /* [XID] */ /* 0x00000001895F0E80-0x00000001895F0EA0 */ protected set {} } // 0x00000001839D9EA0-0x00000001839D9F70 0x00000001839DA4F0-0x00000001839DA5D0
	public uint PushTipId { /* [XID] */ /* 0x00000001895F88D0-0x00000001895F88F0 */ get => default; /* [XID] */ /* 0x00000001895FFD30-0x00000001895FFD50 */ protected set {} } // 0x00000001839D9DD0-0x00000001839D9EA0 0x00000001839DA5D0-0x00000001839DA6B0
	public uint SortOrder { /* [XID] */ /* 0x0000000189607460-0x0000000189607480 */ get => default; /* [XID] */ /* 0x000000018960EEC0-0x000000018960EEE0 */ protected set {} } // 0x00000001839D9F70-0x00000001839DA040 0x00000001839D9CF0-0x00000001839D9DD0
	public bool isDisuse { /* [XID] */ /* 0x0000000189616500-0x0000000189616520 */ get => default; /* [XID] */ /* 0x000000018961DD70-0x000000018961DD90 */ protected set {} } // 0x00000001839DA6B0-0x00000001839DA750 0x00000001839DA750-0x00000001839DA800

	// Constructors
	public PushTipsCodexExcelConfig() {} // 0x00000001839DA9E0-0x00000001839DAA40

	// Methods
	// [IDTag] // 0x0000000189625150-0x0000000189625190
	// [XID] // 0x0000000189625150-0x0000000189625190
	public virtual bool ParseFromLine(string line) => default; // 0x00000001839D9680-0x00000001839D99D0
	// [IDTag] // 0x000000018962FBA0-0x000000018962FBE0
	// [XID] // 0x000000018962FBA0-0x000000018962FBE0
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x00000001839D99D0-0x00000001839D9CF0
	// [XID] // 0x000000018963A590-0x000000018963A5B0
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF076D */, bool useObjectPool = false /* Metadata: 0x00AF0771 */) => default; // 0x00000001839DA040-0x00000001839DA4F0
	[BlackList] // 0x0000000189641CC0-0x0000000189641D00
	// [XID] // 0x0000000189641CC0-0x0000000189641D00
	public virtual void AutoAllocTypeFields() {} // 0x00000001839D94E0-0x00000001839D9580
	[BlackList] // 0x000000018964C650-0x000000018964C690
	// [XID] // 0x000000018964C650-0x000000018964C690
	public virtual void AutoRecycleTypeFields() {} // 0x00000001839D9580-0x00000001839D9680
	[BlackList] // 0x0000000189656BD0-0x0000000189656C10
	// [XID] // 0x0000000189656BD0-0x0000000189656C10
	public virtual void ReturnToObjectPool() {} // 0x00000001839DA940-0x00000001839DA9E0
	[BlackList] // 0x0000000189661170-0x00000001896611B0
	// [XID] // 0x0000000189661170-0x00000001896611B0
	public virtual void OnPoolAllocated() {} // 0x00000001839DA8A0-0x00000001839DA940
	[BlackList] // 0x000000018966B7C0-0x000000018966B800
	// [XID] // 0x000000018966B7C0-0x000000018966B800
	public virtual void OnBeforePoolRecycled() {} // 0x00000001839DA800-0x00000001839DA8A0
}

