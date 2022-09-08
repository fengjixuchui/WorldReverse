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
public class RoutineTypeExcelConfig : IAutoAllocRecycle // TypeDefIndex: 16078
{
	// Fields
	public static Func<uint, string> getLocalizedTextHandler; // 0x00
	protected GeneralRoutineType _routineType; // 0x10
	protected SimpleSafeUInt32 refreshNumRawNum; // 0x14
	protected SimpleSafeUInt32 rewardLimitNumRawNum; // 0x18
	protected SimpleSafeUInt32 refreshIdRawNum; // 0x1C
	protected SimpleSafeUInt32 delayUnloadTimeRawNum; // 0x20
	protected uint _nameTextMapHash; // 0x24
	protected uint _descTextMapHash; // 0x28
	protected string _icon; // 0x30

	// Properties
	public GeneralRoutineType routineType { /* [XID] */ /* 0x000000018972B750-0x000000018972B770 */ get => default; /* [XID] */ /* 0x0000000189732F40-0x0000000189732F60 */ protected set {} } // 0x00000001838DD2F0-0x00000001838DD390 0x00000001838DD510-0x00000001838DD5C0
	public uint refreshNum { /* [XID] */ /* 0x000000018973A5D0-0x000000018973A5F0 */ get => default; /* [XID] */ /* 0x0000000189741F80-0x0000000189741FA0 */ protected set {} } // 0x00000001838DE260-0x00000001838DE330 0x00000001838DE180-0x00000001838DE260
	public uint rewardLimitNum { /* [XID] */ /* 0x00000001897499C0-0x00000001897499E0 */ get => default; /* [XID] */ /* 0x0000000189750EC0-0x0000000189750EE0 */ protected set {} } // 0x00000001838DD5C0-0x00000001838DD690 0x00000001838DD690-0x00000001838DD770
	public uint refreshId { /* [XID] */ /* 0x0000000189758330-0x0000000189758350 */ get => default; /* [XID] */ /* 0x000000018975FDD0-0x000000018975FDF0 */ protected set {} } // 0x00000001838DD220-0x00000001838DD2F0 0x00000001838DD140-0x00000001838DD220
	public uint delayUnloadTime { /* [XID] */ /* 0x0000000189767440-0x0000000189767460 */ get => default; /* [XID] */ /* 0x000000018976E9E0-0x000000018976EA00 */ protected set {} } // 0x00000001838DE0B0-0x00000001838DE180 0x00000001838DC270-0x00000001838DC350
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint nameTextMapHash { /* [XID] */ /* 0x00000001897763C0-0x00000001897763E0 */ get => default; /* [XID] */ /* 0x000000018977DAE0-0x000000018977DB00 */ protected set {} } // 0x00000001838DC5A0-0x00000001838DC640 0x00000001838DDF50-0x00000001838DE000
	public string name { /* [XID] */ /* 0x00000001897852E0-0x0000000189785300 */ get => default; } // 0x00000001838DE470-0x00000001838DE5F0 
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint descTextMapHash { /* [XID] */ /* 0x000000018978C7F0-0x000000018978C810 */ get => default; /* [XID] */ /* 0x0000000189793C80-0x0000000189793CA0 */ protected set {} } // 0x00000001838DDEB0-0x00000001838DDF50 0x00000001838DC640-0x00000001838DC6F0
	public string desc { /* [XID] */ /* 0x000000018979BFF0-0x000000018979C010 */ get => default; } // 0x00000001838DD390-0x00000001838DD510 
	public string icon { /* [XID] */ /* 0x00000001897A34A0-0x00000001897A34C0 */ get => default; /* [XID] */ /* 0x00000001897AAA40-0x00000001897AAA60 */ protected set {} } // 0x00000001838DC350-0x00000001838DC3F0 0x00000001838DE000-0x00000001838DE0B0

	// Constructors
	public RoutineTypeExcelConfig() {} // 0x00000001838DE690-0x00000001838DE6F0

	// Methods
	// [IDTag] // 0x00000001897B2550-0x00000001897B2590
	// [XID] // 0x00000001897B2550-0x00000001897B2590
	public virtual bool ParseFromLine(string line) => default; // 0x00000001838DCC10-0x00000001838DD140
	// [IDTag] // 0x00000001897BDA80-0x00000001897BDAC0
	// [XID] // 0x00000001897BDA80-0x00000001897BDAC0
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x00000001838DC6F0-0x00000001838DCC10
	// [XID] // 0x00000001897C8390-0x00000001897C83B0
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2FA3 */, bool useObjectPool = false /* Metadata: 0x00AF2FA7 */) => default; // 0x00000001838DD770-0x00000001838DDEB0
	[BlackList] // 0x00000001897CF750-0x00000001897CF790
	// [XID] // 0x00000001897CF750-0x00000001897CF790
	public virtual void AutoAllocTypeFields() {} // 0x00000001838DC3F0-0x00000001838DC490
	[BlackList] // 0x00000001897DA390-0x00000001897DA3D0
	// [XID] // 0x00000001897DA390-0x00000001897DA3D0
	public virtual void AutoRecycleTypeFields() {} // 0x00000001838DC490-0x00000001838DC5A0
	[BlackList] // 0x00000001897E46F0-0x00000001897E4730
	// [XID] // 0x00000001897E46F0-0x00000001897E4730
	public virtual void ReturnToObjectPool() {} // 0x00000001838DE5F0-0x00000001838DE690
	[BlackList] // 0x00000001897EF250-0x00000001897EF290
	// [XID] // 0x00000001897EF250-0x00000001897EF290
	public virtual void OnPoolAllocated() {} // 0x00000001838DE3D0-0x00000001838DE470
	[BlackList] // 0x00000001897F9D00-0x00000001897F9D40
	// [XID] // 0x00000001897F9D00-0x00000001897F9D40
	public virtual void OnBeforePoolRecycled() {} // 0x00000001838DE330-0x00000001838DE3D0
}

