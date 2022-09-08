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
public class RegionSearchCondExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15158
{
	// Fields
	public static Func<uint, string> getLocalizedTextHandler; // 0x00
	protected SimpleSafeUInt32 idRawNum; // 0x10
	protected uint _searchNameTextMapHash; // 0x14
	protected uint _searchDescTextMapHash; // 0x18
	protected uint _searchMapDescTextMapHash; // 0x1C
	protected SimpleSafeUInt32 groupIdRawNum; // 0x20
	protected LogicType _logicType; // 0x24
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	protected RegionSearchCond[] _cond; // 0x28
	protected SimpleSafeUInt32[] _regionList; // 0x30
	protected SimpleSafeUInt32 rewardIdRawNum; // 0x38
	protected SimpleSafeUInt32 totalProgressRawNum; // 0x3C
	protected SimpleSafeUInt32 reminderIdRawNum; // 0x40

	// Properties
	public uint id { /* [XID] */ /* 0x0000000189B2FAD0-0x0000000189B2FAF0 */ get => default; /* [XID] */ /* 0x0000000189B374B0-0x0000000189B374D0 */ protected set {} } // 0x0000000184854980-0x0000000184854A50 0x0000000184853480-0x0000000184853560
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint searchNameTextMapHash { /* [XID] */ /* 0x0000000189B3ED20-0x0000000189B3ED40 */ get => default; /* [XID] */ /* 0x0000000189B467E0-0x0000000189B46800 */ protected set {} } // 0x0000000184853340-0x00000001848533E0 0x0000000184854B30-0x0000000184854BE0
	public string searchName { /* [XID] */ /* 0x0000000189B4DD20-0x0000000189B4DD40 */ get => default; } // 0x0000000184852FA0-0x0000000184853120 
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint searchDescTextMapHash { /* [XID] */ /* 0x0000000189B555D0-0x0000000189B555F0 */ get => default; /* [XID] */ /* 0x0000000189B5CED0-0x0000000189B5CEF0 */ protected set {} } // 0x00000001848531F0-0x0000000184853290 0x0000000184851A40-0x0000000184851AF0
	public string searchDesc { /* [XID] */ /* 0x0000000189B64590-0x0000000189B645B0 */ get => default; } // 0x0000000184854550-0x00000001848546D0 
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint searchMapDescTextMapHash { /* [XID] */ /* 0x0000000189B6BA90-0x0000000189B6BAB0 */ get => default; /* [XID] */ /* 0x0000000189B73370-0x0000000189B73390 */ protected set {} } // 0x0000000184853F50-0x0000000184853FF0 0x0000000184853290-0x0000000184853340
	public string searchMapDesc { /* [XID] */ /* 0x0000000189B7A8B0-0x0000000189B7A8D0 */ get => default; } // 0x0000000184854090-0x0000000184854210 
	public uint groupId { /* [XID] */ /* 0x0000000189B820B0-0x0000000189B820D0 */ get => default; /* [XID] */ /* 0x0000000189B89870-0x0000000189B89890 */ protected set {} } // 0x00000001848543A0-0x0000000184854470 0x0000000184854470-0x0000000184854550
	public LogicType logicType { /* [XID] */ /* 0x0000000189B90E50-0x0000000189B90E70 */ get => default; /* [XID] */ /* 0x0000000189B98180-0x0000000189B981A0 */ protected set {} } // 0x00000001848546D0-0x0000000184854770 0x0000000184854210-0x00000001848542C0
	public RegionSearchCond[] cond { /* [XID] */ /* 0x0000000189B9F630-0x0000000189B9F650 */ get => default; /* [XID] */ /* 0x0000000189BA6E40-0x0000000189BA6E60 */ protected set {} } // 0x0000000184853FF0-0x0000000184854090 0x0000000184851AF0-0x0000000184851BA0
	public SimpleSafeUInt32[] regionList { /* [XID] */ /* 0x0000000189BADF80-0x0000000189BADFA0 */ get => default; /* [XID] */ /* 0x0000000189BB5850-0x0000000189BB5870 */ protected set {} } // 0x00000001848533E0-0x0000000184853480 0x0000000184851BA0-0x0000000184851C50
	public uint rewardId { /* [XID] */ /* 0x0000000189BBCF20-0x0000000189BBCF40 */ get => default; /* [XID] */ /* 0x0000000189BC4B80-0x0000000189BC4BA0 */ protected set {} } // 0x0000000184853E80-0x0000000184853F50 0x0000000184851780-0x0000000184851860
	public uint totalProgress { /* [XID] */ /* 0x0000000189BCC5C0-0x0000000189BCC5E0 */ get => default; /* [XID] */ /* 0x0000000189BD3CB0-0x0000000189BD3CD0 */ protected set {} } // 0x0000000184854770-0x0000000184854840 0x0000000184854A50-0x0000000184854B30
	public uint reminderId { /* [XID] */ /* 0x0000000189BDB540-0x0000000189BDB560 */ get => default; /* [XID] */ /* 0x00000001895E7EB0-0x00000001895E7ED0 */ protected set {} } // 0x0000000184853120-0x00000001848531F0 0x00000001848542C0-0x00000001848543A0

	// Constructors
	public RegionSearchCondExcelConfig() {} // 0x0000000184854C80-0x0000000184854CE0

	// Methods
	// [IDTag] // 0x00000001895EF800-0x00000001895EF840
	// [XID] // 0x00000001895EF800-0x00000001895EF840
	public virtual bool ParseFromLine(string line) => default; // 0x0000000184851C50-0x0000000184852660
	// [IDTag] // 0x00000001895F9F00-0x00000001895F9F40
	// [XID] // 0x00000001895F9F00-0x00000001895F9F40
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000184852660-0x0000000184852FA0
	// [XID] // 0x0000000189604670-0x0000000189604690
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF026A */, bool useObjectPool = false /* Metadata: 0x00AF026E */) => default; // 0x0000000184853560-0x0000000184853E80
	[BlackList] // 0x000000018960BFA0-0x000000018960BFE0
	// [XID] // 0x000000018960BFA0-0x000000018960BFE0
	public virtual void AutoAllocTypeFields() {} // 0x0000000184851860-0x0000000184851900
	[BlackList] // 0x0000000189616560-0x00000001896165A0
	// [XID] // 0x0000000189616560-0x00000001896165A0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000184851900-0x0000000184851A40
	[BlackList] // 0x0000000189620C80-0x0000000189620CC0
	// [XID] // 0x0000000189620C80-0x0000000189620CC0
	public virtual void ReturnToObjectPool() {} // 0x0000000184854BE0-0x0000000184854C80
	[BlackList] // 0x000000018962B3A0-0x000000018962B3E0
	// [XID] // 0x000000018962B3A0-0x000000018962B3E0
	public virtual void OnPoolAllocated() {} // 0x00000001848548E0-0x0000000184854980
	[BlackList] // 0x0000000189635FD0-0x0000000189636010
	// [XID] // 0x0000000189635FD0-0x0000000189636010
	public virtual void OnBeforePoolRecycled() {} // 0x0000000184854840-0x00000001848548E0
}

