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
public class RegionSearchRegionExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15160
{
	// Fields
	protected SimpleSafeUInt32 idRawNum; // 0x10
	protected SimpleSafeFloat[] _regionCenter; // 0x18
	protected SimpleSafeFloat regionRadiusRawNum; // 0x20
	protected SimpleSafeUInt32[] _oneoffGroupList; // 0x28
	protected SimpleSafeUInt32 oneoffGroupNumRawNum; // 0x30
	protected SimpleSafeUInt32[] _recycleGroupList; // 0x38
	protected SimpleSafeUInt32 recycleGroupNumRawNum; // 0x40
	protected RegionSearchRecycleType _recycleType; // 0x44
	protected SimpleSafeUInt32 recycleParamRawNum; // 0x48

	// Properties
	public uint id { /* [XID] */ /* 0x00000001896DA090-0x00000001896DA0B0 */ get => default; /* [XID] */ /* 0x00000001896E1650-0x00000001896E1670 */ protected set {} } // 0x0000000184B7EAE0-0x0000000184B7EBB0 0x0000000184B7D900-0x0000000184B7D9E0
	public SimpleSafeFloat[] regionCenter { /* [XID] */ /* 0x00000001896E89E0-0x00000001896E8A00 */ get => default; /* [XID] */ /* 0x00000001896EFDA0-0x00000001896EFDC0 */ protected set {} } // 0x0000000184B7D860-0x0000000184B7D900 0x0000000184B7E360-0x0000000184B7E410
	public float regionRadius { /* [XID] */ /* 0x00000001896F7770-0x00000001896F7790 */ get => default; /* [XID] */ /* 0x00000001896FF1F0-0x00000001896FF210 */ protected set {} } // 0x0000000184B7D9E0-0x0000000184B7DAC0 0x0000000184B7E7E0-0x0000000184B7E8C0
	public SimpleSafeUInt32[] oneoffGroupList { /* [XID] */ /* 0x0000000189706440-0x0000000189706460 */ get => default; /* [XID] */ /* 0x000000018970DD70-0x000000018970DD90 */ protected set {} } // 0x0000000184B7BC60-0x0000000184B7BD00 0x0000000184B7E5B0-0x0000000184B7E660
	public uint oneoffGroupNum { /* [XID] */ /* 0x00000001897151D0-0x00000001897151F0 */ get => default; /* [XID] */ /* 0x000000018971CD40-0x000000018971CD60 */ protected set {} } // 0x0000000184B7E4E0-0x0000000184B7E5B0 0x0000000184B7D600-0x0000000184B7D6E0
	public SimpleSafeUInt32[] recycleGroupList { /* [XID] */ /* 0x0000000189724130-0x0000000189724150 */ get => default; /* [XID] */ /* 0x000000018972B890-0x000000018972B8B0 */ protected set {} } // 0x0000000184B7BEF0-0x0000000184B7BF90 0x0000000184B7E2B0-0x0000000184B7E360
	public uint recycleGroupNum { /* [XID] */ /* 0x0000000189733060-0x0000000189733080 */ get => default; /* [XID] */ /* 0x000000018973A730-0x000000018973A750 */ protected set {} } // 0x0000000184B7E410-0x0000000184B7E4E0 0x0000000184B7E8C0-0x0000000184B7E9A0
	public RegionSearchRecycleType recycleType { /* [XID] */ /* 0x00000001897420A0-0x00000001897420C0 */ get => default; /* [XID] */ /* 0x0000000189749B60-0x0000000189749B80 */ protected set {} } // 0x0000000184B7E660-0x0000000184B7E700 0x0000000184B7D7B0-0x0000000184B7D860
	public uint recycleParam { /* [XID] */ /* 0x0000000189750FC0-0x0000000189750FE0 */ get => default; /* [XID] */ /* 0x0000000189758490-0x00000001897584B0 */ protected set {} } // 0x0000000184B7D6E0-0x0000000184B7D7B0 0x0000000184B7E700-0x0000000184B7E7E0

	// Constructors
	public RegionSearchRegionExcelConfig() {} // 0x0000000184B7EC50-0x0000000184B7ECB0

	// Methods
	// [IDTag] // 0x000000018975FF30-0x000000018975FF70
	// [XID] // 0x000000018975FF30-0x000000018975FF70
	public virtual bool ParseFromLine(string line) => default; // 0x0000000184B7BF90-0x0000000184B7CAB0
	// [IDTag] // 0x000000018976A550-0x000000018976A590
	// [XID] // 0x000000018976A550-0x000000018976A590
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000184B7CAB0-0x0000000184B7D600
	// [XID] // 0x0000000189774930-0x0000000189774950
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF0279 */, bool useObjectPool = false /* Metadata: 0x00AF027D */) => default; // 0x0000000184B7DAC0-0x0000000184B7E2B0
	[BlackList] // 0x000000018977C300-0x000000018977C340
	// [XID] // 0x000000018977C300-0x000000018977C340
	public virtual void AutoAllocTypeFields() {} // 0x0000000184B7BD00-0x0000000184B7BDA0
	[BlackList] // 0x0000000189786B40-0x0000000189786B80
	// [XID] // 0x0000000189786B40-0x0000000189786B80
	public virtual void AutoRecycleTypeFields() {} // 0x0000000184B7BDA0-0x0000000184B7BEF0
	[BlackList] // 0x0000000189791090-0x00000001897910D0
	// [XID] // 0x0000000189791090-0x00000001897910D0
	public virtual void ReturnToObjectPool() {} // 0x0000000184B7EBB0-0x0000000184B7EC50
	[BlackList] // 0x000000018979C110-0x000000018979C150
	// [XID] // 0x000000018979C110-0x000000018979C150
	public virtual void OnPoolAllocated() {} // 0x0000000184B7EA40-0x0000000184B7EAE0
	[BlackList] // 0x00000001897A66A0-0x00000001897A66E0
	// [XID] // 0x00000001897A66A0-0x00000001897A66E0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000184B7E9A0-0x0000000184B7EA40
}

