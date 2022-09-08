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
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class TrialAvatarExcelConfig : IAutoAllocRecycle // TypeDefIndex: 16240
{
	// Fields
	protected SimpleSafeUInt32 trialAvatarIdRawNum; // 0x10
	protected SimpleSafeUInt32[] _trialAvatarParamList; // 0x18
	protected SimpleSafeUInt32[] _trialWeaponParamList; // 0x20
	protected SimpleSafeUInt32 trialSkillDepotIdRawNum; // 0x28
	protected bool _isDynamicLevel; // 0x2C

	// Properties
	public uint trialAvatarId { /* [XID] */ /* 0x00000001898FE020-0x00000001898FE040 */ get => default; /* [XID] */ /* 0x0000000189905800-0x0000000189905820 */ protected set {} } // 0x0000000184963D80-0x0000000184963E50 0x0000000184963E50-0x0000000184963F30
	public SimpleSafeUInt32[] trialAvatarParamList { /* [XID] */ /* 0x000000018990D110-0x000000018990D130 */ get => default; /* [XID] */ /* 0x0000000189914860-0x0000000189914880 */ protected set {} } // 0x0000000184963CE0-0x0000000184963D80 0x0000000184962210-0x00000001849622C0
	public SimpleSafeUInt32[] trialWeaponParamList { /* [XID] */ /* 0x000000018991C4A0-0x000000018991C4C0 */ get => default; /* [XID] */ /* 0x0000000189923BE0-0x0000000189923C00 */ protected set {} } // 0x00000001849633D0-0x0000000184963470 0x0000000184963470-0x0000000184963520
	public uint trialSkillDepotId { /* [XID] */ /* 0x000000018992B220-0x000000018992B240 */ get => default; /* [XID] */ /* 0x0000000189932880-0x00000001899328A0 */ protected set {} } // 0x00000001849636B0-0x0000000184963780 0x0000000184963520-0x0000000184963600
	public bool isDynamicLevel { /* [XID] */ /* 0x000000018993A2D0-0x000000018993A2F0 */ get => default; /* [XID] */ /* 0x0000000189941380-0x00000001899413A0 */ protected set {} } // 0x0000000184963330-0x00000001849633D0 0x0000000184963600-0x00000001849636B0

	// Constructors
	public TrialAvatarExcelConfig() {} // 0x0000000184964110-0x0000000184964170

	// Methods
	// [IDTag] // 0x0000000189948F40-0x0000000189948F80
	// [XID] // 0x0000000189948F40-0x0000000189948F80
	public virtual bool ParseFromLine(string line) => default; // 0x0000000184962450-0x0000000184962BD0
	// [IDTag] // 0x00000001899534B0-0x00000001899534F0
	// [XID] // 0x00000001899534B0-0x00000001899534F0
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000184962BD0-0x0000000184963330
	// [XID] // 0x000000018995DDD0-0x000000018995DDF0
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3546 */, bool useObjectPool = false /* Metadata: 0x00AF354A */) => default; // 0x0000000184963780-0x0000000184963CE0
	[BlackList] // 0x00000001899655D0-0x0000000189965610
	// [XID] // 0x00000001899655D0-0x0000000189965610
	public virtual void AutoAllocTypeFields() {} // 0x00000001849622C0-0x0000000184962360
	[BlackList] // 0x000000018996F900-0x000000018996F940
	// [XID] // 0x000000018996F900-0x000000018996F940
	public virtual void AutoRecycleTypeFields() {} // 0x0000000184962360-0x0000000184962450
	[BlackList] // 0x000000018997A610-0x000000018997A650
	// [XID] // 0x000000018997A610-0x000000018997A650
	public virtual void ReturnToObjectPool() {} // 0x0000000184964070-0x0000000184964110
	[BlackList] // 0x0000000189984A90-0x0000000189984AD0
	// [XID] // 0x0000000189984A90-0x0000000189984AD0
	public virtual void OnPoolAllocated() {} // 0x0000000184963FD0-0x0000000184964070
	[BlackList] // 0x000000018998F700-0x000000018998F740
	// [XID] // 0x000000018998F700-0x000000018998F740
	public virtual void OnBeforePoolRecycled() {} // 0x0000000184963F30-0x0000000184963FD0
}

