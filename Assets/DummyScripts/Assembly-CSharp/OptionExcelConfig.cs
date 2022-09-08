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
public class OptionExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15665
{
	// Fields
	public static Func<uint, string> getLocalizedTextHandler; // 0x00
	protected SimpleSafeUInt32 idRawNum; // 0x10
	protected uint _contentTextMapHash; // 0x14
	protected string _inteeIconName; // 0x18
	protected bool _gusetInteeButtonShow; // 0x20
	protected bool _cancelOnlineMatch; // 0x21

	// Properties
	public uint id { /* [XID] */ /* 0x00000001896C51F0-0x00000001896C5210 */ get => default; /* [XID] */ /* 0x00000001896CC7F0-0x00000001896CC810 */ protected set {} } // 0x00000001851A0AB0-0x00000001851A0B80 0x000000018519FE80-0x000000018519FF60
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint contentTextMapHash { /* [XID] */ /* 0x00000001896D3AE0-0x00000001896D3B00 */ get => default; /* [XID] */ /* 0x00000001896DB500-0x00000001896DB520 */ protected set {} } // 0x00000001851A0780-0x00000001851A0820 0x000000018519FF60-0x00000001851A0010
	public string content { /* [XID] */ /* 0x00000001896E2C60-0x00000001896E2C80 */ get => default; } // 0x00000001851A0600-0x00000001851A0780 
	public string inteeIconName { /* [XID] */ /* 0x000000018988DC70-0x000000018988DC90 */ get => default; /* [XID] */ /* 0x00000001896F1260-0x00000001896F1280 */ protected set {} } // 0x00000001851A0010-0x00000001851A00B0 0x000000018519F3A0-0x000000018519F450
	public bool gusetInteeButtonShow { /* [XID] */ /* 0x00000001896F8C00-0x00000001896F8C20 */ get => default; /* [XID] */ /* 0x0000000189700400-0x0000000189700420 */ protected set {} } // 0x00000001851A0820-0x00000001851A08C0 0x000000018519FDD0-0x000000018519FE80
	public bool cancelOnlineMatch { /* [XID] */ /* 0x0000000189911FD0-0x0000000189911FF0 */ get => default; /* [XID] */ /* 0x000000018970F720-0x000000018970F740 */ protected set {} } // 0x000000018519F5D0-0x000000018519F670 0x00000001851A08C0-0x00000001851A0970

	// Constructors
	public OptionExcelConfig() {} // 0x00000001851A0C20-0x00000001851A0C80

	// Methods
	// [IDTag] // 0x0000000189716A00-0x0000000189716A40
	// [XID] // 0x0000000189716A00-0x0000000189716A40
	public virtual bool ParseFromLine(string line) => default; // 0x000000018519FA10-0x000000018519FDD0
	// [IDTag] // 0x00000001897212F0-0x0000000189721330
	// [XID] // 0x00000001897212F0-0x0000000189721330
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x000000018519F670-0x000000018519FA10
	// [XID] // 0x000000018972B7D0-0x000000018972B7F0
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2242 */, bool useObjectPool = false /* Metadata: 0x00AF2246 */) => default; // 0x00000001851A00B0-0x00000001851A0600
	[BlackList] // 0x0000000189732F80-0x0000000189732FC0
	// [XID] // 0x0000000189732F80-0x0000000189732FC0
	public virtual void AutoAllocTypeFields() {} // 0x000000018519F450-0x000000018519F4F0
	[BlackList] // 0x000000018973DC50-0x000000018973DC90
	// [XID] // 0x000000018973DC50-0x000000018973DC90
	public virtual void AutoRecycleTypeFields() {} // 0x000000018519F4F0-0x000000018519F5D0
	[BlackList] // 0x0000000189748160-0x00000001897481A0
	// [XID] // 0x0000000189748160-0x00000001897481A0
	public virtual void ReturnToObjectPool() {} // 0x00000001851A0B80-0x00000001851A0C20
	[BlackList] // 0x0000000189752630-0x0000000189752670
	// [XID] // 0x0000000189752630-0x0000000189752670
	public virtual void OnPoolAllocated() {} // 0x00000001851A0A10-0x00000001851A0AB0
	[BlackList] // 0x000000018975CC30-0x000000018975CC70
	// [XID] // 0x000000018975CC30-0x000000018975CC70
	public virtual void OnBeforePoolRecycled() {} // 0x00000001851A0970-0x00000001851A0A10
}

