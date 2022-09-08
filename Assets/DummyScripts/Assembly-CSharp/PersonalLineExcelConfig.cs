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
public class PersonalLineExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15940
{
	// Fields
	public static Func<uint, string> getLocalizedTextHandler; // 0x00
	protected SimpleSafeUInt32 idRawNum; // 0x10
	protected uint _titleTextMapHash; // 0x14
	protected SimpleSafeUInt32 chapterIdRawNum; // 0x18
	protected SimpleSafeUInt32 startQuestIdRawNum; // 0x1C
	protected SimpleSafeUInt32 avatarIdRawNum; // 0x20
	protected SimpleSafeUInt32[] _preQuestId; // 0x28
	protected string _startTime; // 0x30
	protected uint _descTextMapHash; // 0x38
	protected SimpleSafeUInt32 sortOrderRawNum; // 0x3C

	// Properties
	public uint id { /* [XID] */ /* 0x0000000189B285F0-0x0000000189B28610 */ get => default; /* [XID] */ /* 0x0000000189B2F930-0x0000000189B2F950 */ protected set {} } // 0x0000000181961C70-0x0000000181961D40 0x0000000181960DF0-0x0000000181960ED0
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint titleTextMapHash { /* [XID] */ /* 0x0000000189B37310-0x0000000189B37330 */ get => default; /* [XID] */ /* 0x0000000189B3EB40-0x0000000189B3EB60 */ protected set {} } // 0x000000018195F570-0x000000018195F610 0x000000018195F840-0x000000018195F8F0
	public string title { /* [XID] */ /* 0x0000000189B465C0-0x0000000189B465E0 */ get => default; } // 0x0000000181961750-0x00000001819618D0 
	public uint chapterId { /* [XID] */ /* 0x0000000189B4DB60-0x0000000189B4DB80 */ get => default; /* [XID] */ /* 0x0000000189B55430-0x0000000189B55450 */ protected set {} } // 0x0000000181960A20-0x0000000181960AF0 0x000000018195F610-0x000000018195F6F0
	public uint startQuestId { /* [XID] */ /* 0x0000000189B5CDB0-0x0000000189B5CDD0 */ get => default; /* [XID] */ /* 0x0000000189B64470-0x0000000189B64490 */ protected set {} } // 0x00000001819619B0-0x0000000181961A80 0x0000000181960AF0-0x0000000181960BD0
	public uint avatarId { /* [XID] */ /* 0x0000000189B6B9B0-0x0000000189B6B9D0 */ get => default; /* [XID] */ /* 0x0000000189B731D0-0x0000000189B731F0 */ protected set {} } // 0x0000000181960950-0x0000000181960A20 0x000000018195F2C0-0x000000018195F3A0
	public SimpleSafeUInt32[] preQuestId { /* [XID] */ /* 0x0000000189B7A710-0x0000000189B7A730 */ get => default; /* [XID] */ /* 0x0000000189B81F70-0x0000000189B81F90 */ protected set {} } // 0x0000000181960BD0-0x0000000181960C70 0x0000000181961A80-0x0000000181961B30
	public string startTime { /* [XID] */ /* 0x0000000189B89710-0x0000000189B89730 */ get => default; /* [XID] */ /* 0x0000000189B90CD0-0x0000000189B90CF0 */ protected set {} } // 0x000000018195F7A0-0x000000018195F840 0x00000001819608A0-0x0000000181960950
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint descTextMapHash { /* [XID] */ /* 0x0000000189B97FE0-0x0000000189B98000 */ get => default; /* [XID] */ /* 0x0000000189B9F450-0x0000000189B9F470 */ protected set {} } // 0x00000001819616B0-0x0000000181961750 0x000000018195F6F0-0x000000018195F7A0
	public string desc { /* [XID] */ /* 0x0000000189BA6CA0-0x0000000189BA6CC0 */ get => default; } // 0x0000000181960C70-0x0000000181960DF0 
	public uint sortOrder { /* [XID] */ /* 0x0000000189BADE40-0x0000000189BADE60 */ get => default; /* [XID] */ /* 0x0000000189BB5610-0x0000000189BB5630 */ protected set {} } // 0x000000018195F8F0-0x000000018195F9C0 0x00000001819618D0-0x00000001819619B0

	// Constructors
	public PersonalLineExcelConfig() {} // 0x0000000181961DE0-0x0000000181961E40

	// Methods
	// [IDTag] // 0x0000000189BBCD60-0x0000000189BBCDA0
	// [XID] // 0x0000000189BBCD60-0x0000000189BBCDA0
	public virtual bool ParseFromLine(string line) => default; // 0x0000000181960130-0x00000001819608A0
	// [IDTag] // 0x0000000189BC7820-0x0000000189BC7860
	// [XID] // 0x0000000189BC7820-0x0000000189BC7860
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x000000018195F9C0-0x0000000181960130
	// [XID] // 0x0000000189BD23A0-0x0000000189BD23C0
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2BBB */, bool useObjectPool = false /* Metadata: 0x00AF2BBF */) => default; // 0x0000000181960ED0-0x00000001819616B0
	[BlackList] // 0x0000000189BD9960-0x0000000189BD99A0
	// [XID] // 0x0000000189BD9960-0x0000000189BD99A0
	public virtual void AutoAllocTypeFields() {} // 0x000000018195F3A0-0x000000018195F440
	[BlackList] // 0x00000001895E9570-0x00000001895E95B0
	// [XID] // 0x00000001895E9570-0x00000001895E95B0
	public virtual void AutoRecycleTypeFields() {} // 0x000000018195F440-0x000000018195F570
	[BlackList] // 0x00000001895F3CF0-0x00000001895F3D30
	// [XID] // 0x00000001895F3CF0-0x00000001895F3D30
	public virtual void ReturnToObjectPool() {} // 0x0000000181961D40-0x0000000181961DE0
	[BlackList] // 0x00000001895FE400-0x00000001895FE440
	// [XID] // 0x00000001895FE400-0x00000001895FE440
	public virtual void OnPoolAllocated() {} // 0x0000000181961BD0-0x0000000181961C70
	[BlackList] // 0x0000000189608E10-0x0000000189608E50
	// [XID] // 0x0000000189608E10-0x0000000189608E50
	public virtual void OnBeforePoolRecycled() {} // 0x0000000181961B30-0x0000000181961BD0
}

