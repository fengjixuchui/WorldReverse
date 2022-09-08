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
public class TreasureMapRegionExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15198
{
	// Fields
	protected SimpleSafeUInt32 idRawNum; // 0x10
	protected SimpleSafeUInt32 unlock_dayRawNum; // 0x14
	protected SimpleSafeUInt32 token_numRawNum; // 0x18
	protected SimpleSafeFloat[] _region_center; // 0x20
	protected SimpleSafeUInt32 region_radiusRawNum; // 0x28
	protected SimpleSafeUInt32 region_entry_idRawNum; // 0x2C
	protected SimpleSafeUInt32[] _group_list; // 0x30
	protected SimpleSafeUInt32 revise_levelRawNum; // 0x38
	protected SimpleSafeUInt32[] _spot_num_list; // 0x40
	protected SimpleSafeUInt32[] _token_num_list; // 0x48
	protected SimpleSafeUInt32[] _misc_drop_prob_list; // 0x50
	protected SimpleSafeUInt32 misc_drop_idRawNum; // 0x58
	protected SimpleSafeUInt32 mp_group_idRawNum; // 0x5C
	protected SimpleSafeUInt32[] _backup_group_list; // 0x60
	protected SimpleSafeUInt32 mp_token_thresholdRawNum; // 0x68
	protected SimpleSafeUInt32 mp_type_idRawNum; // 0x6C

	// Properties
	public uint id { /* [XID] */ /* 0x000000018981DAF0-0x000000018981DB10 */ get => default; /* [XID] */ /* 0x0000000189824F20-0x0000000189824F40 */ protected set {} } // 0x000000018321AAE0-0x000000018321ABB0 0x0000000183218D90-0x0000000183218E70
	public uint unlock_day { /* [XID] */ /* 0x000000018982C910-0x000000018982C930 */ get => default; /* [XID] */ /* 0x0000000189833E60-0x0000000189833E80 */ protected set {} } // 0x000000018321AC90-0x000000018321AD60 0x0000000183219ED0-0x0000000183219FB0
	public uint token_num { /* [XID] */ /* 0x000000018983B2E0-0x000000018983B300 */ get => default; /* [XID] */ /* 0x0000000189842BC0-0x0000000189842BE0 */ protected set {} } // 0x000000018321A3F0-0x000000018321A4C0 0x0000000183218BD0-0x0000000183218CB0
	public SimpleSafeFloat[] region_center { /* [XID] */ /* 0x0000000189849F70-0x0000000189849F90 */ get => default; /* [XID] */ /* 0x00000001898515B0-0x00000001898515D0 */ protected set {} } // 0x0000000183216010-0x00000001832160B0 0x0000000183218B20-0x0000000183218BD0
	public uint region_radius { /* [XID] */ /* 0x0000000189858BA0-0x0000000189858BC0 */ get => default; /* [XID] */ /* 0x000000018985FD30-0x000000018985FD50 */ protected set {} } // 0x000000018321A640-0x000000018321A710 0x0000000183219DF0-0x0000000183219ED0
	public uint region_entry_id { /* [XID] */ /* 0x0000000189867450-0x0000000189867470 */ get => default; /* [XID] */ /* 0x000000018986EBF0-0x000000018986EC10 */ protected set {} } // 0x0000000183215D00-0x0000000183215DD0 0x000000018321A710-0x000000018321A7F0
	public SimpleSafeUInt32[] group_list { /* [XID] */ /* 0x0000000189876080-0x00000001898760A0 */ get => default; /* [XID] */ /* 0x000000018987DCC0-0x000000018987DCE0 */ protected set {} } // 0x00000001832189D0-0x0000000183218A70 0x000000018321A060-0x000000018321A110
	public uint revise_level { /* [XID] */ /* 0x0000000189884C70-0x0000000189884C90 */ get => default; /* [XID] */ /* 0x000000018988C280-0x000000018988C2A0 */ protected set {} } // 0x000000018321A110-0x000000018321A1E0 0x00000001832160B0-0x0000000183216190
	public SimpleSafeUInt32[] spot_num_list { /* [XID] */ /* 0x0000000189893810-0x0000000189893830 */ get => default; /* [XID] */ /* 0x000000018989AF50-0x000000018989AF70 */ protected set {} } // 0x000000018321A1E0-0x000000018321A280 0x0000000183218A70-0x0000000183218B20
	public SimpleSafeUInt32[] token_num_list { /* [XID] */ /* 0x00000001898A22C0-0x00000001898A22E0 */ get => default; /* [XID] */ /* 0x00000001898A9950-0x00000001898A9970 */ protected set {} } // 0x000000018321A5A0-0x000000018321A640 0x0000000183219FB0-0x000000018321A060
	public SimpleSafeUInt32[] misc_drop_prob_list { /* [XID] */ /* 0x00000001898B1260-0x00000001898B1280 */ get => default; /* [XID] */ /* 0x00000001898B8BC0-0x00000001898B8BE0 */ protected set {} } // 0x000000018321A280-0x000000018321A320 0x0000000183219D40-0x0000000183219DF0
	public uint misc_drop_id { /* [XID] */ /* 0x00000001898C01E0-0x00000001898C0200 */ get => default; /* [XID] */ /* 0x00000001898C7B80-0x00000001898C7BA0 */ protected set {} } // 0x0000000183219C70-0x0000000183219D40 0x000000018321A4C0-0x000000018321A5A0
	public uint mp_group_id { /* [XID] */ /* 0x00000001898CF290-0x00000001898CF2B0 */ get => default; /* [XID] */ /* 0x00000001898D6B00-0x00000001898D6B20 */ protected set {} } // 0x0000000183219AF0-0x0000000183219BC0 0x000000018321A7F0-0x000000018321A8D0
	public SimpleSafeUInt32[] backup_group_list { /* [XID] */ /* 0x00000001898DE760-0x00000001898DE780 */ get => default; /* [XID] */ /* 0x00000001898E5FC0-0x00000001898E5FE0 */ protected set {} } // 0x0000000183218930-0x00000001832189D0 0x0000000183219BC0-0x0000000183219C70
	public uint mp_token_threshold { /* [XID] */ /* 0x00000001898ED8E0-0x00000001898ED900 */ get => default; /* [XID] */ /* 0x00000001898F5180-0x00000001898F51A0 */ protected set {} } // 0x000000018321A320-0x000000018321A3F0 0x000000018321ABB0-0x000000018321AC90
	public uint mp_type_id { /* [XID] */ /* 0x00000001898FC890-0x00000001898FC8B0 */ get => default; /* [XID] */ /* 0x00000001899042B0-0x00000001899042D0 */ protected set {} } // 0x000000018321A8D0-0x000000018321A9A0 0x0000000183218CB0-0x0000000183218D90

	// Constructors
	public TreasureMapRegionExcelConfig() {} // 0x000000018321AE00-0x000000018321AE60

	// Methods
	// [IDTag] // 0x000000018990B990-0x000000018990B9D0
	// [XID] // 0x000000018990B990-0x000000018990B9D0
	public virtual bool ParseFromLine(string line) => default; // 0x0000000183216190-0x0000000183217530
	// [IDTag] // 0x0000000189916360-0x00000001899163A0
	// [XID] // 0x0000000189916360-0x00000001899163A0
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000183217530-0x0000000183218930
	// [XID] // 0x0000000189920A90-0x0000000189920AB0
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF0395 */, bool useObjectPool = false /* Metadata: 0x00AF0399 */) => default; // 0x0000000183218E70-0x0000000183219AF0
	[BlackList] // 0x0000000189928470-0x00000001899284B0
	// [XID] // 0x0000000189928470-0x00000001899284B0
	public virtual void AutoAllocTypeFields() {} // 0x0000000183215DD0-0x0000000183215E70
	[BlackList] // 0x0000000189932AA0-0x0000000189932AE0
	// [XID] // 0x0000000189932AA0-0x0000000189932AE0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000183215E70-0x0000000183216010
	[BlackList] // 0x000000018993D270-0x000000018993D2B0
	// [XID] // 0x000000018993D270-0x000000018993D2B0
	public virtual void ReturnToObjectPool() {} // 0x000000018321AD60-0x000000018321AE00
	[BlackList] // 0x0000000189947620-0x0000000189947660
	// [XID] // 0x0000000189947620-0x0000000189947660
	public virtual void OnPoolAllocated() {} // 0x000000018321AA40-0x000000018321AAE0
	[BlackList] // 0x0000000189952050-0x0000000189952090
	// [XID] // 0x0000000189952050-0x0000000189952090
	public virtual void OnBeforePoolRecycled() {} // 0x000000018321A9A0-0x000000018321AA40
}

