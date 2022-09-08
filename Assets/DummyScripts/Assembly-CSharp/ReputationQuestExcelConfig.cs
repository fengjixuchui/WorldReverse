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
public class ReputationQuestExcelConfig : IAutoAllocRecycle // TypeDefIndex: 16044
{
	// Fields
	public static Func<uint, string> getLocalizedTextHandler; // 0x00
	protected SimpleSafeUInt32 ParentQuestIdRawNum; // 0x10
	protected SimpleSafeUInt32 cityIdRawNum; // 0x14
	protected SimpleSafeUInt32 rewardIdRawNum; // 0x18
	protected string _iconName; // 0x20
	protected uint _titleTextMapHash; // 0x28
	protected SimpleSafeUInt32 orderRawNum; // 0x2C

	// Properties
	public uint ParentQuestId { /* [XID] */ /* 0x0000000189936D70-0x0000000189936D90 */ get => default; /* [XID] */ /* 0x000000018993E930-0x000000018993E950 */ protected set {} } // 0x0000000184759A50-0x0000000184759B20 0x0000000184759CE0-0x0000000184759DC0
	public uint cityId { /* [XID] */ /* 0x0000000189945F60-0x0000000189945F80 */ get => default; /* [XID] */ /* 0x000000018994D470-0x000000018994D490 */ protected set {} } // 0x000000018475A6A0-0x000000018475A770 0x0000000184759B20-0x0000000184759C00
	public uint rewardId { /* [XID] */ /* 0x0000000189954B40-0x0000000189954B60 */ get => default; /* [XID] */ /* 0x000000018995C340-0x000000018995C360 */ protected set {} } // 0x000000018475A3B0-0x000000018475A480 0x0000000184758D50-0x0000000184758E30
	public string iconName { /* [XID] */ /* 0x0000000189963D80-0x0000000189963DA0 */ get => default; /* [XID] */ /* 0x000000018996B2F0-0x000000018996B310 */ protected set {} } // 0x000000018475A600-0x000000018475A6A0 0x000000018475A8B0-0x000000018475A960
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint titleTextMapHash { /* [XID] */ /* 0x0000000189972DB0-0x0000000189972DD0 */ get => default; /* [XID] */ /* 0x000000018997A690-0x000000018997A6B0 */ protected set {} } // 0x0000000184758FE0-0x0000000184759080 0x0000000184759150-0x0000000184759200
	public string title { /* [XID] */ /* 0x0000000189982060-0x0000000189982080 */ get => default; } // 0x000000018475A480-0x000000018475A600 
	public uint order { /* [XID] */ /* 0x00000001899898E0-0x0000000189989900 */ get => default; /* [XID] */ /* 0x0000000189991130-0x0000000189991150 */ protected set {} } // 0x0000000184759080-0x0000000184759150 0x0000000184759C00-0x0000000184759CE0

	// Constructors
	public ReputationQuestExcelConfig() {} // 0x000000018475AA00-0x000000018475AA60

	// Methods
	// [IDTag] // 0x0000000189998BB0-0x0000000189998BF0
	// [XID] // 0x0000000189998BB0-0x0000000189998BF0
	public virtual bool ParseFromLine(string line) => default; // 0x0000000184759620-0x0000000184759A50
	// [IDTag] // 0x00000001899A33B0-0x00000001899A33F0
	// [XID] // 0x00000001899A33B0-0x00000001899A33F0
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000184759200-0x0000000184759620
	// [XID] // 0x00000001899ADE40-0x00000001899ADE60
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2EC4 */, bool useObjectPool = false /* Metadata: 0x00AF2EC8 */) => default; // 0x0000000184759DC0-0x000000018475A3B0
	[BlackList] // 0x00000001899B55C0-0x00000001899B5600
	// [XID] // 0x00000001899B55C0-0x00000001899B5600
	public virtual void AutoAllocTypeFields() {} // 0x0000000184758E30-0x0000000184758ED0
	[BlackList] // 0x00000001899BFDD0-0x00000001899BFE10
	// [XID] // 0x00000001899BFDD0-0x00000001899BFE10
	public virtual void AutoRecycleTypeFields() {} // 0x0000000184758ED0-0x0000000184758FE0
	[BlackList] // 0x00000001899CA440-0x00000001899CA480
	// [XID] // 0x00000001899CA440-0x00000001899CA480
	public virtual void ReturnToObjectPool() {} // 0x000000018475A960-0x000000018475AA00
	[BlackList] // 0x00000001899D4AB0-0x00000001899D4AF0
	// [XID] // 0x00000001899D4AB0-0x00000001899D4AF0
	public virtual void OnPoolAllocated() {} // 0x000000018475A810-0x000000018475A8B0
	[BlackList] // 0x00000001899DEF30-0x00000001899DEF70
	// [XID] // 0x00000001899DEF30-0x00000001899DEF70
	public virtual void OnBeforePoolRecycled() {} // 0x000000018475A770-0x000000018475A810
}

