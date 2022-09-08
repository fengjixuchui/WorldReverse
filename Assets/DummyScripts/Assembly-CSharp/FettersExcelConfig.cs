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
public class FettersExcelConfig : FetterConfig, IAutoAllocRecycle // TypeDefIndex: 14867
{
	// Fields
	public static Func<uint, string> getLocalizedTextHandler; // 0x00
	protected bool _isHiden; // 0x28
	protected string _desc; // 0x30
	protected uint[] _tips; // 0x38
	protected uint _voice_titleTextMapHash; // 0x40
	protected string _voice_file; // 0x48
	protected uint _voice_file_textTextMapHash; // 0x50
	protected uint _voice_title_lockedTextMapHash; // 0x54

	// Properties
	public bool isHiden { /* [XID] */ /* 0x0000000189AB7D20-0x0000000189AB7D40 */ get => default; /* [XID] */ /* 0x0000000189ABF7F0-0x0000000189ABF810 */ protected set {} } // 0x00000001819F8BB0-0x00000001819F8C50 0x00000001819FA3A0-0x00000001819FA450
	public string desc { /* [XID] */ /* 0x0000000189AC71E0-0x0000000189AC7200 */ get => default; /* [XID] */ /* 0x0000000189ACE8F0-0x0000000189ACE910 */ protected set {} } // 0x00000001819FA450-0x00000001819FA4F0 0x00000001819FB930-0x00000001819FB9E0
	public uint[] tips { /* [XID] */ /* 0x0000000189AD67A0-0x0000000189AD67C0 */ get => default; /* [XID] */ /* 0x0000000189ADE120-0x0000000189ADE140 */ protected set {} } // 0x00000001819F8CB0-0x00000001819F8D50 0x00000001819FB4D0-0x00000001819FB580
	public string[] tipsLocalized { /* [XID] */ /* 0x0000000189AE5B40-0x0000000189AE5B60 */ get => default; } // 0x00000001819FB070-0x00000001819FB3D0 
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint voice_titleTextMapHash { /* [XID] */ /* 0x0000000189AECFE0-0x0000000189AED000 */ get => default; /* [XID] */ /* 0x0000000189AF4930-0x0000000189AF4950 */ protected set {} } // 0x00000001819F8B10-0x00000001819F8BB0 0x00000001819FB880-0x00000001819FB930
	public string voice_title { /* [XID] */ /* 0x0000000189AFBF40-0x0000000189AFBF60 */ get => default; } // 0x00000001819FA220-0x00000001819FA3A0 
	public string voice_file { /* [XID] */ /* 0x0000000189B03870-0x0000000189B03890 */ get => default; /* [XID] */ /* 0x0000000189B0AF00-0x0000000189B0AF20 */ protected set {} } // 0x00000001819FA020-0x00000001819FA0C0 0x00000001819FA170-0x00000001819FA220
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint voice_file_textTextMapHash { /* [XID] */ /* 0x0000000189B127C0-0x0000000189B127E0 */ get => default; /* [XID] */ /* 0x0000000189B19B30-0x0000000189B19B50 */ protected set {} } // 0x00000001819FB3D0-0x00000001819FB470 0x00000001819FA0C0-0x00000001819FA170
	public string voice_file_text { /* [XID] */ /* 0x0000000189B210F0-0x0000000189B21110 */ get => default; } // 0x00000001819FB580-0x00000001819FB700 
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint voice_title_lockedTextMapHash { /* [XID] */ /* 0x0000000189B28850-0x0000000189B28870 */ get => default; /* [XID] */ /* 0x0000000189B2FBB0-0x0000000189B2FBD0 */ protected set {} } // 0x00000001819FAFD0-0x00000001819FB070 0x00000001819F8860-0x00000001819F8910
	public string voice_title_locked { /* [XID] */ /* 0x0000000189B375B0-0x0000000189B375D0 */ get => default; } // 0x00000001819FB700-0x00000001819FB880 

	// Constructors
	public FettersExcelConfig() {} // 0x00000001819FBA80-0x00000001819FBAE0

	// Methods
	// [XID] // 0x0000000189AB06C0-0x0000000189AB06E0
	public string getUnlockConditionString() => default; // 0x00000001819FA5E0-0x00000001819FA690
	// [IDTag] // 0x0000000189B3EE40-0x0000000189B3EE80
	// [XID] // 0x0000000189B3EE40-0x0000000189B3EE80
	public virtual bool ParseFromLine(string line) => default; // 0x00000001819F9640-0x00000001819FA020
	// [IDTag] // 0x0000000189B49940-0x0000000189B49980
	// [XID] // 0x0000000189B49940-0x0000000189B49980
	public override bool ParseFromLine(string[] words, ref int index) => default; // 0x00000001819F8D50-0x00000001819F9640
	// [XID] // 0x0000000189B53E80-0x0000000189B53EA0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEF848 */, bool useObjectPool = false /* Metadata: 0x00AEF84C */) => default; // 0x00000001819FA690-0x00000001819FAFD0
	[BlackList] // 0x0000000189B5B7D0-0x0000000189B5B810
	// [XID] // 0x0000000189B5B7D0-0x0000000189B5B810
	public override void AutoAllocTypeFields() {} // 0x00000001819F8910-0x00000001819F89B0
	[BlackList] // 0x0000000189B65E40-0x0000000189B65E80
	// [XID] // 0x0000000189B65E40-0x0000000189B65E80
	public override void AutoRecycleTypeFields() {} // 0x00000001819F89B0-0x00000001819F8A70
	[BlackList] // 0x0000000189B704A0-0x0000000189B704E0
	// [XID] // 0x0000000189B704A0-0x0000000189B704E0
	public override void ReturnToObjectPool() {} // 0x00000001819FB9E0-0x00000001819FBA80
}

