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
public class CompoundExcelConfig : IAutoAllocRecycle // TypeDefIndex: 14855
{
	// Fields
	public static Func<uint, string> getLocalizedTextHandler; // 0x00
	protected SimpleSafeUInt32 idRawNum; // 0x10
	protected uint _nameTextMapHash; // 0x14
	protected SimpleSafeUInt32 rankLevelRawNum; // 0x18
	protected CompoundType _type; // 0x1C
	protected bool _isDefaultUnlocked; // 0x20
	protected SimpleSafeUInt32 costTimeRawNum; // 0x24
	protected SimpleSafeUInt32 queueSizeRawNum; // 0x28
	protected IdCountConfig[] _inputVec; // 0x30
	protected IdCountConfig[] _outputVec; // 0x38
	protected string _icon; // 0x40
	protected uint _descTextMapHash; // 0x48

	// Properties
	public uint id { /* [XID] */ /* 0x0000000189B5B850-0x0000000189B5B870 */ get => default; /* [XID] */ /* 0x0000000189B62C80-0x0000000189B62CA0 */ protected set {} } // 0x0000000181D65C30-0x0000000181D65D00 0x0000000181D646A0-0x0000000181D64780
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint nameTextMapHash { /* [XID] */ /* 0x0000000189B6A6D0-0x0000000189B6A6F0 */ get => default; /* [XID] */ /* 0x0000000189B71E70-0x0000000189B71E90 */ protected set {} } // 0x0000000181D62FD0-0x0000000181D63070 0x0000000181D65230-0x0000000181D652E0
	public string name { /* [XID] */ /* 0x0000000189B79280-0x0000000189B792A0 */ get => default; } // 0x0000000181D65DA0-0x0000000181D65F20 
	public uint rankLevel { /* [XID] */ /* 0x0000000189B806B0-0x0000000189B806D0 */ get => default; /* [XID] */ /* 0x0000000189B88200-0x0000000189B88220 */ protected set {} } // 0x0000000181D643A0-0x0000000181D64470 0x0000000181D642C0-0x0000000181D643A0
	public CompoundType type { /* [XID] */ /* 0x0000000189B8F4D0-0x0000000189B8F4F0 */ get => default; /* [XID] */ /* 0x0000000189B96950-0x0000000189B96970 */ protected set {} } // 0x0000000181D65D00-0x0000000181D65DA0 0x0000000181D65610-0x0000000181D656C0
	public bool isDefaultUnlocked { /* [XID] */ /* 0x0000000189B9DEE0-0x0000000189B9DF00 */ get => default; /* [XID] */ /* 0x0000000189BA5850-0x0000000189BA5870 */ protected set {} } // 0x0000000181D64220-0x0000000181D642C0 0x0000000181D656C0-0x0000000181D65770
	public uint costTime { /* [XID] */ /* 0x0000000189BACA90-0x0000000189BACAB0 */ get => default; /* [XID] */ /* 0x0000000189BB4310-0x0000000189BB4330 */ protected set {} } // 0x0000000181D652E0-0x0000000181D653B0 0x0000000181D65150-0x0000000181D65230
	public uint queueSize { /* [XID] */ /* 0x0000000189BBB910-0x0000000189BBB930 */ get => default; /* [XID] */ /* 0x0000000189BC37B0-0x0000000189BC37D0 */ protected set {} } // 0x0000000181D653B0-0x0000000181D65480 0x0000000181D65480-0x0000000181D65560
	public IdCountConfig[] inputVec { /* [XID] */ /* 0x0000000189BCAF70-0x0000000189BCAF90 */ get => default; /* [XID] */ /* 0x0000000189BD2640-0x0000000189BD2660 */ protected set {} } // 0x0000000181D63120-0x0000000181D631C0 0x0000000181D659A0-0x0000000181D65A50
	public IdCountConfig[] outputVec { /* [XID] */ /* 0x0000000189BD9B80-0x0000000189BD9BA0 */ get => default; /* [XID] */ /* 0x00000001895E65D0-0x00000001895E65F0 */ protected set {} } // 0x0000000181D65A50-0x0000000181D65AF0 0x0000000181D645F0-0x0000000181D646A0
	public string icon { /* [XID] */ /* 0x00000001895EE0D0-0x00000001895EE0F0 */ get => default; /* [XID] */ /* 0x00000001895F5830-0x00000001895F5850 */ protected set {} } // 0x0000000181D62D70-0x0000000181D62E10 0x0000000181D65560-0x0000000181D65610
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint descTextMapHash { /* [XID] */ /* 0x00000001895FCDF0-0x00000001895FCE10 */ get => default; /* [XID] */ /* 0x00000001896048B0-0x00000001896048D0 */ protected set {} } // 0x0000000181D650B0-0x0000000181D65150 0x0000000181D63070-0x0000000181D63120
	public string desc { /* [XID] */ /* 0x000000018960C080-0x000000018960C0A0 */ get => default; } // 0x0000000181D64470-0x0000000181D645F0 

	// Constructors
	public CompoundExcelConfig() {} // 0x0000000181D65FC0-0x0000000181D66020

	// Methods
	// [XID] // 0x0000000189B53EC0-0x0000000189B53EE0
	public static uint CheckCompoundMaxNum(uint compoundId) => default; // 0x0000000181D65770-0x0000000181D659A0
	// [IDTag] // 0x0000000189613620-0x0000000189613660
	// [XID] // 0x0000000189613620-0x0000000189613660
	public virtual bool ParseFromLine(string line) => default; // 0x0000000181D63980-0x0000000181D64220
	// [IDTag] // 0x000000018961DF50-0x000000018961DF90
	// [XID] // 0x000000018961DF50-0x000000018961DF90
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000181D631C0-0x0000000181D63980
	// [XID] // 0x00000001896283F0-0x0000000189628410
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEF7E0 */, bool useObjectPool = false /* Metadata: 0x00AEF7E4 */) => default; // 0x0000000181D64780-0x0000000181D650B0
	[BlackList] // 0x000000018962FD00-0x000000018962FD40
	// [XID] // 0x000000018962FD00-0x000000018962FD40
	public virtual void AutoAllocTypeFields() {} // 0x0000000181D62E10-0x0000000181D62EB0
	[BlackList] // 0x000000018963A690-0x000000018963A6D0
	// [XID] // 0x000000018963A690-0x000000018963A6D0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000181D62EB0-0x0000000181D62FD0
	[BlackList] // 0x0000000189644D10-0x0000000189644D50
	// [XID] // 0x0000000189644D10-0x0000000189644D50
	public virtual void ReturnToObjectPool() {} // 0x0000000181D65F20-0x0000000181D65FC0
	[BlackList] // 0x000000018964F340-0x000000018964F380
	// [XID] // 0x000000018964F340-0x000000018964F380
	public virtual void OnPoolAllocated() {} // 0x0000000181D65B90-0x0000000181D65C30
	[BlackList] // 0x0000000189659B50-0x0000000189659B90
	// [XID] // 0x0000000189659B50-0x0000000189659B90
	public virtual void OnBeforePoolRecycled() {} // 0x0000000181D65AF0-0x0000000181D65B90
}

