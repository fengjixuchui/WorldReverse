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
public class CoopPointExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15463
{
	// Fields
	public static Func<uint, string> getLocalizedTextHandler; // 0x00
	protected SimpleSafeUInt32 idRawNum; // 0x10
	protected SimpleSafeUInt32 chapterIdRawNum; // 0x14
	protected CoopPointType _type; // 0x18
	protected SimpleSafeUInt32 acceptQuestRawNum; // 0x1C
	protected SimpleSafeUInt32[] _postPointList; // 0x20
	protected uint _pointNameTextMapHash; // 0x28
	protected uint _pointDecTextMapHash; // 0x2C
	protected SimpleSafeUInt32 pointPosIdRawNum; // 0x30
	protected byte _photoMaleHashPre; // 0x34
	protected uint _photoMaleHashSuffix; // 0x38
	protected byte _photoFemaleHashPre; // 0x3C
	protected uint _photoFemaleHashSuffix; // 0x40

	// Properties
	public uint id { /* [XID] */ /* 0x0000000189B18300-0x0000000189B18320 */ get => default; /* [XID] */ /* 0x0000000189B1FA20-0x0000000189B1FA40 */ protected set {} } // 0x00000001817EB7E0-0x00000001817EB8B0 0x00000001817EA580-0x00000001817EA660
	public uint chapterId { /* [XID] */ /* 0x0000000189B271E0-0x0000000189B27200 */ get => default; /* [XID] */ /* 0x0000000189B2E370-0x0000000189B2E390 */ protected set {} } // 0x00000001817EA060-0x00000001817EA130 0x00000001817E8A90-0x00000001817E8B70
	public CoopPointType type { /* [XID] */ /* 0x0000000189B35860-0x0000000189B35880 */ get => default; /* [XID] */ /* 0x0000000189B3D020-0x0000000189B3D040 */ protected set {} } // 0x00000001817EB8B0-0x00000001817EB950 0x00000001817EB550-0x00000001817EB600
	public uint acceptQuest { /* [XID] */ /* 0x0000000189B44E90-0x0000000189B44EB0 */ get => default; /* [XID] */ /* 0x0000000189B4C640-0x0000000189B4C660 */ protected set {} } // 0x00000001817EB270-0x00000001817EB340 0x00000001817EA700-0x00000001817EA7E0
	public SimpleSafeUInt32[] postPointList { /* [XID] */ /* 0x0000000189B53CE0-0x0000000189B53D00 */ get => default; /* [XID] */ /* 0x0000000189B5B5F0-0x0000000189B5B610 */ protected set {} } // 0x00000001817E9FC0-0x00000001817EA060 0x00000001817EA350-0x00000001817EA400
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint pointNameTextMapHash { /* [XID] */ /* 0x0000000189B62A60-0x0000000189B62A80 */ get => default; /* [XID] */ /* 0x0000000189B6A550-0x0000000189B6A570 */ protected set {} } // 0x00000001817EB600-0x00000001817EB6A0 0x00000001817E8C20-0x00000001817E8CD0
	public string pointName { /* [XID] */ /* 0x0000000189B71C50-0x0000000189B71C70 */ get => default; } // 0x00000001817E8840-0x00000001817E89C0 
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint pointDecTextMapHash { /* [XID] */ /* 0x0000000189B79000-0x0000000189B79020 */ get => default; /* [XID] */ /* 0x0000000189B80530-0x0000000189B80550 */ protected set {} } // 0x00000001817E8CD0-0x00000001817E8D70 0x00000001817E8B70-0x00000001817E8C20
	public string pointDec { /* [XID] */ /* 0x0000000189B88100-0x0000000189B88120 */ get => default; } // 0x00000001817EA400-0x00000001817EA580 
	public uint pointPosId { /* [XID] */ /* 0x0000000189B8F370-0x0000000189B8F390 */ get => default; /* [XID] */ /* 0x0000000189B967D0-0x0000000189B967F0 */ protected set {} } // 0x00000001817EA280-0x00000001817EA350 0x00000001817E9EE0-0x00000001817E9FC0
	public byte photoMaleHashPre { /* [XID] */ /* 0x0000000189B9DCE0-0x0000000189B9DD00 */ get => default; /* [XID] */ /* 0x0000000189BA5650-0x0000000189BA5670 */ protected set {} } // 0x00000001817EB4B0-0x00000001817EB550 0x00000001817EB1C0-0x00000001817EB270
	public uint photoMaleHashSuffix { /* [XID] */ /* 0x0000000189BAC8D0-0x0000000189BAC8F0 */ get => default; /* [XID] */ /* 0x0000000189BB40D0-0x0000000189BB40F0 */ protected set {} } // 0x00000001817EA130-0x00000001817EA1D0 0x00000001817EA1D0-0x00000001817EA280
	public ulong photoMaleHash { /* [XID] */ /* 0x0000000189BBB7D0-0x0000000189BBB7F0 */ get => default; } // 0x00000001817E89C0-0x00000001817E8A90 
	public byte photoFemaleHashPre { /* [XID] */ /* 0x0000000189BC3610-0x0000000189BC3630 */ get => default; /* [XID] */ /* 0x0000000189BCAE30-0x0000000189BCAE50 */ protected set {} } // 0x00000001817EB410-0x00000001817EB4B0 0x00000001817EB110-0x00000001817EB1C0
	public uint photoFemaleHashSuffix { /* [XID] */ /* 0x0000000189BD2480-0x0000000189BD24A0 */ get => default; /* [XID] */ /* 0x0000000189BD9A20-0x0000000189BD9A40 */ protected set {} } // 0x00000001817EA660-0x00000001817EA700 0x00000001817E8D70-0x00000001817E8E20
	public ulong photoFemaleHash { /* [XID] */ /* 0x00000001895E64B0-0x00000001895E64D0 */ get => default; } // 0x00000001817EB340-0x00000001817EB410 

	// Constructors
	public CoopPointExcelConfig() {} // 0x00000001817EB9F0-0x00000001817EBA50

	// Methods
	// [IDTag] // 0x00000001895EDEF0-0x00000001895EDF30
	// [XID] // 0x00000001895EDEF0-0x00000001895EDF30
	public virtual bool ParseFromLine(string line) => default; // 0x00000001817E8E20-0x00000001817E9680
	// [IDTag] // 0x00000001895F8830-0x00000001895F8870
	// [XID] // 0x00000001895F8830-0x00000001895F8870
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x00000001817E9680-0x00000001817E9EE0
	// [XID] // 0x0000000189602DB0-0x0000000189602DD0
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF1B31 */, bool useObjectPool = false /* Metadata: 0x00AF1B35 */) => default; // 0x00000001817EA7E0-0x00000001817EB110
	[BlackList] // 0x000000018960A7B0-0x000000018960A7F0
	// [XID] // 0x000000018960A7B0-0x000000018960A7F0
	public virtual void AutoAllocTypeFields() {} // 0x00000001817E8680-0x00000001817E8720
	[BlackList] // 0x0000000189614EC0-0x0000000189614F00
	// [XID] // 0x0000000189614EC0-0x0000000189614F00
	public virtual void AutoRecycleTypeFields() {} // 0x00000001817E8720-0x00000001817E8840
	[BlackList] // 0x000000018961F6C0-0x000000018961F700
	// [XID] // 0x000000018961F6C0-0x000000018961F700
	public virtual void ReturnToObjectPool() {} // 0x00000001817EB950-0x00000001817EB9F0
	[BlackList] // 0x0000000189629C70-0x0000000189629CB0
	// [XID] // 0x0000000189629C70-0x0000000189629CB0
	public virtual void OnPoolAllocated() {} // 0x00000001817EB740-0x00000001817EB7E0
	[BlackList] // 0x00000001896346D0-0x0000000189634710
	// [XID] // 0x00000001896346D0-0x0000000189634710
	public virtual void OnBeforePoolRecycled() {} // 0x00000001817EB6A0-0x00000001817EB740
}

