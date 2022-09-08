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
public class BlessingScanExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15030
{
	// Fields
	protected SimpleSafeUInt32 idRawNum; // 0x10
	protected SimpleSafeUInt32 typeIdRawNum; // 0x14
	protected BlessingScanType _scanType; // 0x18
	protected SimpleSafeUInt32 refIdRawNum; // 0x1C
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	protected BlessingPicUpConfig[] _picUpConfig; // 0x20
	protected SimpleSafeUInt32 scanDurationRawNum; // 0x28
	protected SimpleSafeUInt32 scanTimeRawNum; // 0x2C
	protected string _hitBoxesNodeName; // 0x30

	// Properties
	public uint id { /* [XID] */ /* 0x000000018972A0E0-0x000000018972A100 */ get => default; /* [XID] */ /* 0x0000000189731780-0x00000001897317A0 */ protected set {} } // 0x00000001865772C0-0x0000000186577390 0x00000001865764F0-0x00000001865765D0
	public uint typeId { /* [XID] */ /* 0x0000000189738FB0-0x0000000189738FD0 */ get => default; /* [XID] */ /* 0x0000000189740D60-0x0000000189740D80 */ protected set {} } // 0x0000000186575300-0x00000001865753D0 0x0000000186576F20-0x0000000186577000
	public BlessingScanType scanType { /* [XID] */ /* 0x00000001897482A0-0x00000001897482C0 */ get => default; /* [XID] */ /* 0x000000018974FB10-0x000000018974FB30 */ protected set {} } // 0x0000000186576670-0x0000000186576710 0x00000001865753D0-0x0000000186575480
	public uint refId { /* [XID] */ /* 0x00000001897570C0-0x00000001897570E0 */ get => default; /* [XID] */ /* 0x000000018975E710-0x000000018975E730 */ protected set {} } // 0x0000000186576E50-0x0000000186576F20 0x00000001865761C0-0x00000001865762A0
	public BlessingPicUpConfig[] picUpConfig { /* [XID] */ /* 0x0000000189765CF0-0x0000000189765D10 */ get => default; /* [XID] */ /* 0x000000018976D4E0-0x000000018976D500 */ protected set {} } // 0x00000001865770E0-0x0000000186577180 0x0000000186576370-0x0000000186576420
	public uint scanDuration { /* [XID] */ /* 0x0000000189774950-0x0000000189774970 */ get => default; /* [XID] */ /* 0x000000018977C380-0x000000018977C3A0 */ protected set {} } // 0x0000000186576420-0x00000001865764F0 0x0000000186575220-0x0000000186575300
	public uint scanTime { /* [XID] */ /* 0x0000000189783D70-0x0000000189783D90 */ get => default; /* [XID] */ /* 0x000000018978B520-0x000000018978B540 */ protected set {} } // 0x00000001865762A0-0x0000000186576370 0x0000000186577000-0x00000001865770E0
	public string hitBoxesNodeName { /* [XID] */ /* 0x00000001897929A0-0x00000001897929C0 */ get => default; /* [XID] */ /* 0x0000000189799F30-0x0000000189799F50 */ protected set {} } // 0x00000001865765D0-0x0000000186576670 0x0000000186576110-0x00000001865761C0

	// Constructors
	public BlessingScanExcelConfig() {} // 0x0000000186577430-0x0000000186577490

	// Methods
	// [IDTag] // 0x00000001897A1DE0-0x00000001897A1E20
	// [XID] // 0x00000001897A1DE0-0x00000001897A1E20
	public virtual bool ParseFromLine(string line) => default; // 0x0000000186575A60-0x0000000186576110
	// [IDTag] // 0x00000001897AC5E0-0x00000001897AC620
	// [XID] // 0x00000001897AC5E0-0x00000001897AC620
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000186575480-0x0000000186575A60
	// [XID] // 0x00000001897B7630-0x00000001897B7650
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFEE6 */, bool useObjectPool = false /* Metadata: 0x00AEFEEA */) => default; // 0x0000000186576710-0x0000000186576E50
	[BlackList] // 0x00000001897BF4F0-0x00000001897BF530
	// [XID] // 0x00000001897BF4F0-0x00000001897BF530
	public virtual void AutoAllocTypeFields() {} // 0x0000000186575050-0x00000001865750F0
	[BlackList] // 0x00000001897C9920-0x00000001897C9960
	// [XID] // 0x00000001897C9920-0x00000001897C9960
	public virtual void AutoRecycleTypeFields() {} // 0x00000001865750F0-0x0000000186575220
	[BlackList] // 0x00000001897D40A0-0x00000001897D40E0
	// [XID] // 0x00000001897D40A0-0x00000001897D40E0
	public virtual void ReturnToObjectPool() {} // 0x0000000186577390-0x0000000186577430
	[BlackList] // 0x00000001897DE730-0x00000001897DE770
	// [XID] // 0x00000001897DE730-0x00000001897DE770
	public virtual void OnPoolAllocated() {} // 0x0000000186577220-0x00000001865772C0
	[BlackList] // 0x00000001897E91D0-0x00000001897E9210
	// [XID] // 0x00000001897E91D0-0x00000001897E9210
	public virtual void OnBeforePoolRecycled() {} // 0x0000000186577180-0x0000000186577220
}

