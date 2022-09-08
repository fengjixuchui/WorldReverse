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
public class FetterStoryExcelConfig : FetterConfig, IAutoAllocRecycle // TypeDefIndex: 15614
{
	// Fields
	public static Func<uint, string> getLocalizedTextHandler; // 0x00
	protected bool _isHiden; // 0x28
	protected uint _storyTitleTextMapHash; // 0x2C
	protected uint _storyContextTextMapHash; // 0x30
	protected uint _storyTitle2TextMapHash; // 0x34
	protected uint _storyContext2TextMapHash; // 0x38
	protected uint[] _tips; // 0x40
	protected uint _storyTitleLockedTextMapHash; // 0x48

	// Properties
	public bool isHiden { /* [XID] */ /* 0x00000001898057F0-0x0000000189805810 */ get => default; /* [XID] */ /* 0x000000018980CE50-0x000000018980CE70 */ protected set {} } // 0x00000001819DA310-0x00000001819DA3B0 0x00000001819DB8E0-0x00000001819DB990
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint storyTitleTextMapHash { /* [XID] */ /* 0x0000000189814690-0x00000001898146B0 */ get => default; /* [XID] */ /* 0x000000018981C100-0x000000018981C120 */ protected set {} } // 0x00000001819DCC20-0x00000001819DCCC0 0x00000001819DC760-0x00000001819DC810
	public string storyTitle { /* [XID] */ /* 0x0000000189823570-0x0000000189823590 */ get => default; } // 0x00000001819DD000-0x00000001819DD180 
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint storyContextTextMapHash { /* [XID] */ /* 0x000000018982AF70-0x000000018982AF90 */ get => default; /* [XID] */ /* 0x0000000189832530-0x0000000189832550 */ protected set {} } // 0x00000001819DD3B0-0x00000001819DD450 0x00000001819DCEA0-0x00000001819DCF50
	public string storyContext { /* [XID] */ /* 0x0000000189839AA0-0x0000000189839AC0 */ get => default; } // 0x00000001819DCD20-0x00000001819DCEA0 
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint storyTitle2TextMapHash { /* [XID] */ /* 0x0000000189840FA0-0x0000000189840FC0 */ get => default; /* [XID] */ /* 0x0000000189848460-0x0000000189848480 */ protected set {} } // 0x00000001819DB7A0-0x00000001819DB840 0x00000001819DD180-0x00000001819DD230
	public string storyTitle2 { /* [XID] */ /* 0x000000018984FBC0-0x000000018984FBE0 */ get => default; } // 0x00000001819DD230-0x00000001819DD3B0 
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint storyContext2TextMapHash { /* [XID] */ /* 0x0000000189857060-0x0000000189857080 */ get => default; /* [XID] */ /* 0x000000018985E190-0x000000018985E1B0 */ protected set {} } // 0x00000001819DB840-0x00000001819DB8E0 0x00000001819DB990-0x00000001819DBA40
	public string storyContext2 { /* [XID] */ /* 0x0000000189865B70-0x0000000189865B90 */ get => default; } // 0x00000001819DC460-0x00000001819DC5E0 
	public uint[] tips { /* [XID] */ /* 0x000000018986D110-0x000000018986D130 */ get => default; /* [XID] */ /* 0x0000000189874540-0x0000000189874560 */ protected set {} } // 0x00000001819DA410-0x00000001819DA4B0 0x00000001819DCF50-0x00000001819DD000
	public string[] tipsLocalized { /* [XID] */ /* 0x000000018987C100-0x000000018987C120 */ get => default; } // 0x00000001819DC8C0-0x00000001819DCC20 
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint storyTitleLockedTextMapHash { /* [XID] */ /* 0x0000000189883270-0x0000000189883290 */ get => default; /* [XID] */ /* 0x000000018988A990-0x000000018988A9B0 */ protected set {} } // 0x00000001819DD450-0x00000001819DD4F0 0x00000001819DC810-0x00000001819DC8C0
	public string storyTitleLocked { /* [XID] */ /* 0x0000000189891E80-0x0000000189891EA0 */ get => default; } // 0x00000001819DC5E0-0x00000001819DC760 

	// Constructors
	public FetterStoryExcelConfig() {} // 0x00000001819DD590-0x00000001819DD5F0

	// Methods
	// [IDTag] // 0x00000001898997B0-0x00000001898997F0
	// [XID] // 0x00000001898997B0-0x00000001898997F0
	public virtual bool ParseFromLine(string line) => default; // 0x00000001819DADB0-0x00000001819DB7A0
	// [IDTag] // 0x00000001898A3C20-0x00000001898A3C60
	// [XID] // 0x00000001898A3C20-0x00000001898A3C60
	public override bool ParseFromLine(string[] words, ref int index) => default; // 0x00000001819DA4B0-0x00000001819DADB0
	// [XID] // 0x00000001898AE3B0-0x00000001898AE3D0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF20A6 */, bool useObjectPool = false /* Metadata: 0x00AF20AA */) => default; // 0x00000001819DBB30-0x00000001819DC460
	[BlackList] // 0x00000001898B5910-0x00000001898B5950
	// [XID] // 0x00000001898B5910-0x00000001898B5950
	public override void AutoAllocTypeFields() {} // 0x00000001819DA110-0x00000001819DA1B0
	[BlackList] // 0x00000001898C01A0-0x00000001898C01E0
	// [XID] // 0x00000001898C01A0-0x00000001898C01E0
	public override void AutoRecycleTypeFields() {} // 0x00000001819DA1B0-0x00000001819DA270
	[BlackList] // 0x00000001898CAA80-0x00000001898CAAC0
	// [XID] // 0x00000001898CAA80-0x00000001898CAAC0
	public override void ReturnToObjectPool() {} // 0x00000001819DD4F0-0x00000001819DD590
}

