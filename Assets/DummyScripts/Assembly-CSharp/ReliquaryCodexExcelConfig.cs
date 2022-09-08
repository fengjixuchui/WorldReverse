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
public class ReliquaryCodexExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15311
{
	// Fields
	protected SimpleSafeUInt32 IdRawNum; // 0x10
	protected SimpleSafeUInt32 suitIdRawNum; // 0x14
	protected SimpleSafeUInt32 levelRawNum; // 0x18
	protected SimpleSafeUInt32 cupIdRawNum; // 0x1C
	protected SimpleSafeUInt32 leatherIdRawNum; // 0x20
	protected SimpleSafeUInt32 capIdRawNum; // 0x24
	protected SimpleSafeUInt32 flowerIdRawNum; // 0x28
	protected SimpleSafeUInt32 sandIdRawNum; // 0x2C
	protected SimpleSafeUInt32 SortOrderRawNum; // 0x30
	protected bool _isDisuse; // 0x34
	protected bool _showOnlyUnlocked; // 0x35

	// Properties
	public uint Id { /* [XID] */ /* 0x000000018965B4B0-0x000000018965B4D0 */ get => default; /* [XID] */ /* 0x00000001896628E0-0x0000000189662900 */ protected set {} } // 0x00000001830B3910-0x00000001830B39E0 0x00000001830B4810-0x00000001830B48F0
	public uint suitId { /* [XID] */ /* 0x000000018966A460-0x000000018966A480 */ get => default; /* [XID] */ /* 0x00000001896720C0-0x00000001896720E0 */ protected set {} } // 0x00000001830B3AB0-0x00000001830B3B80 0x00000001830B49D0-0x00000001830B4AB0
	public uint level { /* [XID] */ /* 0x0000000189679950-0x0000000189679970 */ get => default; /* [XID] */ /* 0x0000000189681060-0x0000000189681080 */ protected set {} } // 0x00000001830B4580-0x00000001830B4650 0x00000001830B44A0-0x00000001830B4580
	public uint cupId { /* [XID] */ /* 0x0000000189688B40-0x0000000189688B60 */ get => default; /* [XID] */ /* 0x00000001896905C0-0x00000001896905E0 */ protected set {} } // 0x00000001830B4B50-0x00000001830B4C20 0x00000001830B48F0-0x00000001830B49D0
	public uint leatherId { /* [XID] */ /* 0x0000000189697E00-0x0000000189697E20 */ get => default; /* [XID] */ /* 0x000000018969F0B0-0x000000018969F0D0 */ protected set {} } // 0x00000001830B2770-0x00000001830B2840 0x00000001830B4730-0x00000001830B4810
	public uint capId { /* [XID] */ /* 0x00000001896A6550-0x00000001896A6570 */ get => default; /* [XID] */ /* 0x00000001896ADA50-0x00000001896ADA70 */ protected set {} } // 0x00000001830B3680-0x00000001830B3750 0x00000001830B3830-0x00000001830B3910
	public uint flowerId { /* [XID] */ /* 0x00000001896B52B0-0x00000001896B52D0 */ get => default; /* [XID] */ /* 0x00000001896BC440-0x00000001896BC460 */ protected set {} } // 0x00000001830B4C20-0x00000001830B4CF0 0x00000001830B2480-0x00000001830B2560
	public uint sandId { /* [XID] */ /* 0x00000001896C3AE0-0x00000001896C3B00 */ get => default; /* [XID] */ /* 0x00000001896CAFD0-0x00000001896CAFF0 */ protected set {} } // 0x00000001830B23B0-0x00000001830B2480 0x00000001830B4650-0x00000001830B4730
	public uint SortOrder { /* [XID] */ /* 0x00000001896D2560-0x00000001896D2580 */ get => default; /* [XID] */ /* 0x00000001896D9FD0-0x00000001896D9FF0 */ protected set {} } // 0x00000001830B39E0-0x00000001830B3AB0 0x00000001830B3750-0x00000001830B3830
	public bool isDisuse { /* [XID] */ /* 0x00000001896E15B0-0x00000001896E15D0 */ get => default; /* [XID] */ /* 0x00000001896E8940-0x00000001896E8960 */ protected set {} } // 0x00000001830B4AB0-0x00000001830B4B50 0x00000001830B4CF0-0x00000001830B4DA0
	public bool showOnlyUnlocked { /* [XID] */ /* 0x00000001896EFD40-0x00000001896EFD60 */ get => default; /* [XID] */ /* 0x00000001896F7710-0x00000001896F7730 */ protected set {} } // 0x00000001830B2840-0x00000001830B28E0 0x00000001830B28E0-0x00000001830B2990

	// Constructors
	public ReliquaryCodexExcelConfig() {} // 0x00000001830B4F80-0x00000001830B4FE0

	// Methods
	// [IDTag] // 0x00000001896FF170-0x00000001896FF1B0
	// [XID] // 0x00000001896FF170-0x00000001896FF1B0
	public virtual bool ParseFromLine(string line) => default; // 0x00000001830B3010-0x00000001830B3680
	// [IDTag] // 0x0000000189709680-0x00000001897096C0
	// [XID] // 0x0000000189709680-0x00000001897096C0
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x00000001830B2990-0x00000001830B3010
	// [XID] // 0x0000000189713DC0-0x0000000189713DE0
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF0731 */, bool useObjectPool = false /* Metadata: 0x00AF0735 */) => default; // 0x00000001830B3B80-0x00000001830B44A0
	[BlackList] // 0x000000018971B5E0-0x000000018971B620
	// [XID] // 0x000000018971B5E0-0x000000018971B620
	public virtual void AutoAllocTypeFields() {} // 0x00000001830B2560-0x00000001830B2600
	[BlackList] // 0x0000000189725A60-0x0000000189725AA0
	// [XID] // 0x0000000189725A60-0x0000000189725AA0
	public virtual void AutoRecycleTypeFields() {} // 0x00000001830B2600-0x00000001830B2770
	[BlackList] // 0x00000001897300C0-0x0000000189730100
	// [XID] // 0x00000001897300C0-0x0000000189730100
	public virtual void ReturnToObjectPool() {} // 0x00000001830B4EE0-0x00000001830B4F80
	[BlackList] // 0x000000018973A690-0x000000018973A6D0
	// [XID] // 0x000000018973A690-0x000000018973A6D0
	public virtual void OnPoolAllocated() {} // 0x00000001830B4E40-0x00000001830B4EE0
	[BlackList] // 0x0000000189745110-0x0000000189745150
	// [XID] // 0x0000000189745110-0x0000000189745150
	public virtual void OnBeforePoolRecycled() {} // 0x00000001830B4DA0-0x00000001830B4E40
}

