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
public class MonsterDescribeExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15847
{
	// Fields
	public static Func<uint, string> getLocalizedTextHandler; // 0x00
	protected SimpleSafeUInt32 idRawNum; // 0x10
	protected uint _nameTextMapHash; // 0x14
	protected SimpleSafeUInt32 titleIDRawNum; // 0x18
	protected SimpleSafeUInt32 specialNameLabIDRawNum; // 0x1C
	protected string _icon; // 0x20
	protected uint _descTextMapHash; // 0x28
	protected uint _lockDescTextMapHash; // 0x2C

	// Properties
	public uint id { /* [XID] */ /* 0x0000000189B6B9D0-0x0000000189B6B9F0 */ get => default; /* [XID] */ /* 0x0000000189B73230-0x0000000189B73250 */ protected set {} } // 0x0000000183927C60-0x0000000183927D30 0x00000001839270E0-0x00000001839271C0
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint nameTextMapHash { /* [XID] */ /* 0x0000000189B7A770-0x0000000189B7A790 */ get => default; /* [XID] */ /* 0x0000000189B81F90-0x0000000189B81FB0 */ protected set {} } // 0x0000000183926060-0x0000000183926100 0x00000001839279C0-0x0000000183927A70
	public string name { /* [XID] */ /* 0x000000018971A4A0-0x000000018971A4C0 */ get => default; } // 0x0000000183927D30-0x0000000183927EB0 
	public uint titleID { /* [XID] */ /* 0x0000000189B90CF0-0x0000000189B90D10 */ get => default; /* [XID] */ /* 0x0000000189B98000-0x0000000189B98020 */ protected set {} } // 0x0000000183926100-0x00000001839261D0 0x0000000183925D40-0x0000000183925E20
	public uint specialNameLabID { /* [XID] */ /* 0x0000000189B9F490-0x0000000189B9F4B0 */ get => default; /* [XID] */ /* 0x0000000189BA6CE0-0x0000000189BA6D00 */ protected set {} } // 0x00000001839271C0-0x0000000183927290 0x0000000183927000-0x00000001839270E0
	public string icon { /* [XID] */ /* 0x0000000189BADE80-0x0000000189BADEA0 */ get => default; /* [XID] */ /* 0x0000000189BB56D0-0x0000000189BB56F0 */ protected set {} } // 0x0000000183925E20-0x0000000183925EC0 0x0000000183927A70-0x0000000183927B20
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint descTextMapHash { /* [XID] */ /* 0x0000000189BBCDC0-0x0000000189BBCDE0 */ get => default; /* [XID] */ /* 0x0000000189BC4A20-0x0000000189BC4A40 */ protected set {} } // 0x0000000183927920-0x00000001839279C0 0x00000001839261D0-0x0000000183926280
	public string desc { /* [XID] */ /* 0x0000000189BCC460-0x0000000189BCC480 */ get => default; } // 0x0000000183926E80-0x0000000183927000 
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint lockDescTextMapHash { /* [XID] */ /* 0x0000000189BD3B70-0x0000000189BD3B90 */ get => default; /* [XID] */ /* 0x0000000189BDB460-0x0000000189BDB480 */ protected set {} } // 0x0000000183926DE0-0x0000000183926E80 0x0000000183926280-0x0000000183926330
	public string lockDesc { /* [XID] */ /* 0x00000001895E7D70-0x00000001895E7D90 */ get => default; } // 0x0000000183926330-0x00000001839264B0 

	// Constructors
	public MonsterDescribeExcelConfig() {} // 0x0000000183927F50-0x0000000183927FB0

	// Methods
	// [IDTag] // 0x00000001895EF6A0-0x00000001895EF6E0
	// [XID] // 0x00000001895EF6A0-0x00000001895EF6E0
	public virtual bool ParseFromLine(string line) => default; // 0x00000001839264B0-0x0000000183926950
	// [IDTag] // 0x00000001895F9DE0-0x00000001895F9E20
	// [XID] // 0x00000001895F9DE0-0x00000001895F9E20
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000183926950-0x0000000183926DE0
	// [XID] // 0x00000001896045D0-0x00000001896045F0
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2840 */, bool useObjectPool = false /* Metadata: 0x00AF2844 */) => default; // 0x0000000183927290-0x0000000183927920
	[BlackList] // 0x000000018960BE60-0x000000018960BEA0
	// [XID] // 0x000000018960BE60-0x000000018960BEA0
	public virtual void AutoAllocTypeFields() {} // 0x0000000183925EC0-0x0000000183925F60
	[BlackList] // 0x0000000189616400-0x0000000189616440
	// [XID] // 0x0000000189616400-0x0000000189616440
	public virtual void AutoRecycleTypeFields() {} // 0x0000000183925F60-0x0000000183926060
	[BlackList] // 0x0000000189620BE0-0x0000000189620C20
	// [XID] // 0x0000000189620BE0-0x0000000189620C20
	public virtual void ReturnToObjectPool() {} // 0x0000000183927EB0-0x0000000183927F50
	[BlackList] // 0x000000018962B2C0-0x000000018962B300
	// [XID] // 0x000000018962B2C0-0x000000018962B300
	public virtual void OnPoolAllocated() {} // 0x0000000183927BC0-0x0000000183927C60
	[BlackList] // 0x0000000189635E90-0x0000000189635ED0
	// [XID] // 0x0000000189635E90-0x0000000189635ED0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000183927B20-0x0000000183927BC0
}

