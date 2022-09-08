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
public class H5ActivityWatcherExcelConfig : WatcherConfig, IAutoAllocRecycle // TypeDefIndex: 15695
{
	// Fields
	protected SimpleSafeUInt32 h5ActivityIdRawNum; // 0x28
	protected LogicType _condComb; // 0x2C
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	protected H5ActivityCondConfig[] _condList; // 0x30
	protected bool _isDailyRefresh; // 0x38

	// Properties
	public uint h5ActivityId { /* [XID] */ /* 0x000000018962E350-0x000000018962E370 */ get => default; /* [XID] */ /* 0x0000000189635F30-0x0000000189635F50 */ protected set {} } // 0x00000001848C8600-0x00000001848C86D0 0x00000001848C8520-0x00000001848C8600
	public LogicType condComb { /* [XID] */ /* 0x000000018963D690-0x000000018963D6B0 */ get => default; /* [XID] */ /* 0x0000000189644C10-0x0000000189644C30 */ protected set {} } // 0x00000001848C87E0-0x00000001848C8880 0x00000001848C8470-0x00000001848C8520
	public H5ActivityCondConfig[] condList { /* [XID] */ /* 0x000000018964C5F0-0x000000018964C610 */ get => default; /* [XID] */ /* 0x0000000189653B80-0x0000000189653BA0 */ protected set {} } // 0x00000001848C6BB0-0x00000001848C6C50 0x00000001848C6E80-0x00000001848C6F30
	public bool isDailyRefresh { /* [XID] */ /* 0x000000018965B450-0x000000018965B470 */ get => default; /* [XID] */ /* 0x00000001896628C0-0x00000001896628E0 */ protected set {} } // 0x00000001848C83D0-0x00000001848C8470 0x00000001848C8730-0x00000001848C87E0

	// Constructors
	public H5ActivityWatcherExcelConfig() {} // 0x00000001848C8920-0x00000001848C8980

	// Methods
	// [IDTag] // 0x000000018966A420-0x000000018966A460
	// [XID] // 0x000000018966A420-0x000000018966A460
	public virtual bool ParseFromLine(string line) => default; // 0x00000001848C6F90-0x00000001848C7600
	// [IDTag] // 0x0000000189674F90-0x0000000189674FD0
	// [XID] // 0x0000000189674F90-0x0000000189674FD0
	public override bool ParseFromLine(string[] words, ref int index) => default; // 0x00000001848C7600-0x00000001848C7BA0
	// [XID] // 0x000000018967F600-0x000000018967F620
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF234F */, bool useObjectPool = false /* Metadata: 0x00AF2353 */) => default; // 0x00000001848C7C90-0x00000001848C83D0
	[BlackList] // 0x0000000189686E50-0x0000000189686E90
	// [XID] // 0x0000000189686E50-0x0000000189686E90
	public override void AutoAllocTypeFields() {} // 0x00000001848C6C50-0x00000001848C6CF0
	[BlackList] // 0x0000000189691E30-0x0000000189691E70
	// [XID] // 0x0000000189691E30-0x0000000189691E70
	public override void AutoRecycleTypeFields() {} // 0x00000001848C6CF0-0x00000001848C6DE0
	[BlackList] // 0x000000018969C2A0-0x000000018969C2E0
	// [XID] // 0x000000018969C2A0-0x000000018969C2E0
	public override void ReturnToObjectPool() {} // 0x00000001848C8880-0x00000001848C8920
}

