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
public class ReputationLevelExcelConfig : IAutoAllocRecycle // TypeDefIndex: 14903
{
	// Fields
	public static Func<uint, string> getLocalizedTextHandler; // 0x00
	protected SimpleSafeUInt32 idRawNum; // 0x10
	protected SimpleSafeUInt32 levelRawNum; // 0x14
	protected SimpleSafeUInt32 cityIdRawNum; // 0x18
	protected uint _levelNameTextMapHash; // 0x1C
	protected SimpleSafeUInt32 nextLevelExpRawNum; // 0x20
	protected SimpleSafeUInt32 rewardIdRawNum; // 0x24
	protected SimpleSafeUInt32 requestGroupIdRawNum; // 0x28
	protected SimpleSafeUInt32 requestNumRawNum; // 0x2C
	protected SimpleSafeUInt32 requestAcceptNumRawNum; // 0x30
	protected SimpleSafeUInt32 functionIdRawNum; // 0x34

	// Properties
	public uint id { /* [XID] */ /* 0x0000000189B8AC90-0x0000000189B8ACB0 */ get => default; /* [XID] */ /* 0x0000000189B92320-0x0000000189B92340 */ protected set {} } // 0x00000001819D9F40-0x00000001819DA010 0x00000001819D8EC0-0x00000001819D8FA0
	public uint level { /* [XID] */ /* 0x0000000189B998E0-0x0000000189B99900 */ get => default; /* [XID] */ /* 0x0000000189BA0E90-0x0000000189BA0EB0 */ protected set {} } // 0x00000001819D99D0-0x00000001819D9AA0 0x00000001819D98F0-0x00000001819D99D0
	public uint cityId { /* [XID] */ /* 0x0000000189BA8530-0x0000000189BA8550 */ get => default; /* [XID] */ /* 0x0000000189BAF9C0-0x0000000189BAF9E0 */ protected set {} } // 0x00000001819D9D30-0x00000001819D9E00 0x00000001819D88F0-0x00000001819D89D0
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint levelNameTextMapHash { /* [XID] */ /* 0x0000000189BB6FD0-0x0000000189BB6FF0 */ get => default; /* [XID] */ /* 0x0000000189BBE5B0-0x0000000189BBE5D0 */ protected set {} } // 0x00000001819D7720-0x00000001819D77C0 0x00000001819D8C60-0x00000001819D8D10
	public string levelName { /* [XID] */ /* 0x0000000189BC62C0-0x0000000189BC62E0 */ get => default; } // 0x00000001819D7960-0x00000001819D7AE0 
	public uint nextLevelExp { /* [XID] */ /* 0x0000000189BCDF00-0x0000000189BCDF20 */ get => default; /* [XID] */ /* 0x0000000189BD5370-0x0000000189BD5390 */ protected set {} } // 0x00000001819D7890-0x00000001819D7960 0x00000001819D9B80-0x00000001819D9C60
	public uint rewardId { /* [XID] */ /* 0x0000000189BDCF80-0x0000000189BDCFA0 */ get => default; /* [XID] */ /* 0x00000001895E9830-0x00000001895E9850 */ protected set {} } // 0x00000001819D9820-0x00000001819D98F0 0x00000001819D7430-0x00000001819D7510
	public uint requestGroupId { /* [XID] */ /* 0x00000001895F0F40-0x00000001895F0F60 */ get => default; /* [XID] */ /* 0x00000001895F8A10-0x00000001895F8A30 */ protected set {} } // 0x00000001819D9C60-0x00000001819D9D30 0x00000001819D8AB0-0x00000001819D8B90
	public uint requestNum { /* [XID] */ /* 0x00000001895FFE10-0x00000001895FFE30 */ get => default; /* [XID] */ /* 0x0000000189607560-0x0000000189607580 */ protected set {} } // 0x00000001819D8DF0-0x00000001819D8EC0 0x00000001819D89D0-0x00000001819D8AB0
	public uint requestAcceptNum { /* [XID] */ /* 0x000000018960F020-0x000000018960F040 */ get => default; /* [XID] */ /* 0x00000001896166A0-0x00000001896166C0 */ protected set {} } // 0x00000001819D77C0-0x00000001819D7890 0x00000001819D9AA0-0x00000001819D9B80
	public uint functionId { /* [XID] */ /* 0x000000018961DEF0-0x000000018961DF10 */ get => default; /* [XID] */ /* 0x0000000189625350-0x0000000189625370 */ protected set {} } // 0x00000001819D8B90-0x00000001819D8C60 0x00000001819D8D10-0x00000001819D8DF0

	// Constructors
	public ReputationLevelExcelConfig() {} // 0x00000001819DA0B0-0x00000001819DA110

	// Methods
	// [XID] // 0x0000000189B83B20-0x0000000189B83B40
	public bool IsMaxLevel() => default; // 0x00000001819D86E0-0x00000001819D88F0
	// [IDTag] // 0x000000018962CAD0-0x000000018962CB10
	// [XID] // 0x000000018962CAD0-0x000000018962CB10
	public virtual bool ParseFromLine(string line) => default; // 0x00000001819D80E0-0x00000001819D86E0
	// [IDTag] // 0x0000000189637900-0x0000000189637940
	// [XID] // 0x0000000189637900-0x0000000189637940
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x00000001819D7AE0-0x00000001819D80E0
	// [XID] // 0x0000000189641DE0-0x0000000189641E00
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEF96F */, bool useObjectPool = false /* Metadata: 0x00AEF973 */) => default; // 0x00000001819D8FA0-0x00000001819D9820
	[BlackList] // 0x0000000189649640-0x0000000189649680
	// [XID] // 0x0000000189649640-0x0000000189649680
	public virtual void AutoAllocTypeFields() {} // 0x00000001819D7510-0x00000001819D75B0
	[BlackList] // 0x0000000189653C80-0x0000000189653CC0
	// [XID] // 0x0000000189653C80-0x0000000189653CC0
	public virtual void AutoRecycleTypeFields() {} // 0x00000001819D75B0-0x00000001819D7720
	[BlackList] // 0x000000018965E450-0x000000018965E490
	// [XID] // 0x000000018965E450-0x000000018965E490
	public virtual void ReturnToObjectPool() {} // 0x00000001819DA010-0x00000001819DA0B0
	[BlackList] // 0x0000000189668D80-0x0000000189668DC0
	// [XID] // 0x0000000189668D80-0x0000000189668DC0
	public virtual void OnPoolAllocated() {} // 0x00000001819D9EA0-0x00000001819D9F40
	[BlackList] // 0x0000000189673640-0x0000000189673680
	// [XID] // 0x0000000189673640-0x0000000189673680
	public virtual void OnBeforePoolRecycled() {} // 0x00000001819D9E00-0x00000001819D9EA0
}

