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
public class DraftExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15498
{
	// Fields
	protected SimpleSafeUInt32 idRawNum; // 0x10
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	protected DraftTransferConfig[] _transferConfig; // 0x18
	protected SimpleSafeUInt32 sceneIdRawNum; // 0x20
	protected DraftExecType _exec; // 0x24
	protected SimpleSafeUInt32 paramRawNum; // 0x28
	protected bool _enableMp; // 0x2C
	protected bool _isNeedAllAgree; // 0x2D
	protected SimpleSafeUInt32 confirmCountDownRawNum; // 0x30
	protected SimpleSafeUInt32 minPlayerCountRawNum; // 0x34
	protected bool _isNeedTwiceConfirm; // 0x38
	protected SimpleSafeUInt32 twiceConfirmCountDownRawNum; // 0x3C
	protected bool _isExecWhenCountDownOver; // 0x40

	// Properties
	public uint id { /* [XID] */ /* 0x0000000189A0D6A0-0x0000000189A0D6C0 */ get => default; /* [XID] */ /* 0x0000000189A14E80-0x0000000189A14EA0 */ protected set {} } // 0x0000000181884240-0x0000000181884310 0x0000000181882FC0-0x00000001818830A0
	public DraftTransferConfig[] transferConfig { /* [XID] */ /* 0x0000000189A1BFD0-0x0000000189A1BFF0 */ get => default; /* [XID] */ /* 0x0000000189A23860-0x0000000189A23880 */ protected set {} } // 0x0000000181882E70-0x0000000181882F10 0x0000000181881930-0x00000001818819E0
	public uint sceneId { /* [XID] */ /* 0x0000000189A2ACE0-0x0000000189A2AD00 */ get => default; /* [XID] */ /* 0x0000000189A32200-0x0000000189A32220 */ protected set {} } // 0x0000000181883150-0x0000000181883220 0x0000000181883D70-0x0000000181883E50
	public DraftExecType exec { /* [XID] */ /* 0x0000000189A39BD0-0x0000000189A39BF0 */ get => default; /* [XID] */ /* 0x0000000189A41430-0x0000000189A41450 */ protected set {} } // 0x0000000181883EF0-0x0000000181883F90 0x0000000181882DC0-0x0000000181882E70
	public uint param { /* [XID] */ /* 0x0000000189A48AF0-0x0000000189A48B10 */ get => default; /* [XID] */ /* 0x0000000189A50280-0x0000000189A502A0 */ protected set {} } // 0x00000001818844A0-0x0000000181884570 0x0000000181884310-0x00000001818843F0
	public bool enableMp { /* [XID] */ /* 0x0000000189A57850-0x0000000189A57870 */ get => default; /* [XID] */ /* 0x0000000189A5F3F0-0x0000000189A5F410 */ protected set {} } // 0x0000000181883F90-0x0000000181884030 0x00000001818830A0-0x0000000181883150
	public bool isNeedAllAgree { /* [XID] */ /* 0x0000000189A66CE0-0x0000000189A66D00 */ get => default; /* [XID] */ /* 0x0000000189A6E540-0x0000000189A6E560 */ protected set {} } // 0x0000000181883E50-0x0000000181883EF0 0x0000000181882F10-0x0000000181882FC0
	public uint confirmCountDown { /* [XID] */ /* 0x0000000189A75C30-0x0000000189A75C50 */ get => default; /* [XID] */ /* 0x0000000189A7D7F0-0x0000000189A7D810 */ protected set {} } // 0x0000000181881670-0x0000000181881740 0x0000000181881A80-0x0000000181881B60
	public uint minPlayerCount { /* [XID] */ /* 0x0000000189A84FE0-0x0000000189A85000 */ get => default; /* [XID] */ /* 0x0000000189A8C8F0-0x0000000189A8C910 */ protected set {} } // 0x0000000181883CA0-0x0000000181883D70 0x0000000181882CE0-0x0000000181882DC0
	public bool isNeedTwiceConfirm { /* [XID] */ /* 0x0000000189A93C90-0x0000000189A93CB0 */ get => default; /* [XID] */ /* 0x0000000189A9B780-0x0000000189A9B7A0 */ protected set {} } // 0x00000001818819E0-0x0000000181881A80 0x0000000181883BF0-0x0000000181883CA0
	public uint twiceConfirmCountDown { /* [XID] */ /* 0x0000000189AA2B60-0x0000000189AA2B80 */ get => default; /* [XID] */ /* 0x0000000189AAA1A0-0x0000000189AAA1C0 */ protected set {} } // 0x0000000181884030-0x0000000181884100 0x0000000181882C00-0x0000000181882CE0
	public bool isExecWhenCountDownOver { /* [XID] */ /* 0x0000000189AB1FC0-0x0000000189AB1FE0 */ get => default; /* [XID] */ /* 0x0000000189AB9210-0x0000000189AB9230 */ protected set {} } // 0x0000000181884570-0x0000000181884610 0x00000001818843F0-0x00000001818844A0

	// Constructors
	public DraftExcelConfig() {} // 0x00000001818846B0-0x0000000181884710

	// Methods
	// [IDTag] // 0x0000000189AC0DD0-0x0000000189AC0E10
	// [XID] // 0x0000000189AC0DD0-0x0000000189AC0E10
	public virtual bool ParseFromLine(string line) => default; // 0x0000000181881B60-0x0000000181882420
	// [IDTag] // 0x0000000189ACB810-0x0000000189ACB850
	// [XID] // 0x0000000189ACB810-0x0000000189ACB850
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000181882420-0x0000000181882C00
	// [XID] // 0x0000000189AD66C0-0x0000000189AD66E0
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF1C63 */, bool useObjectPool = false /* Metadata: 0x00AF1C67 */) => default; // 0x0000000181883220-0x0000000181883BF0
	[BlackList] // 0x0000000189ADDF20-0x0000000189ADDF60
	// [XID] // 0x0000000189ADDF20-0x0000000189ADDF60
	public virtual void AutoAllocTypeFields() {} // 0x0000000181881740-0x00000001818817E0
	[BlackList] // 0x0000000189AE84B0-0x0000000189AE84F0
	// [XID] // 0x0000000189AE84B0-0x0000000189AE84F0
	public virtual void AutoRecycleTypeFields() {} // 0x00000001818817E0-0x0000000181881930
	[BlackList] // 0x0000000189AF32B0-0x0000000189AF32F0
	// [XID] // 0x0000000189AF32B0-0x0000000189AF32F0
	public virtual void ReturnToObjectPool() {} // 0x0000000181884610-0x00000001818846B0
	[BlackList] // 0x0000000189AFD770-0x0000000189AFD7B0
	// [XID] // 0x0000000189AFD770-0x0000000189AFD7B0
	public virtual void OnPoolAllocated() {} // 0x00000001818841A0-0x0000000181884240
	[BlackList] // 0x0000000189B07E90-0x0000000189B07ED0
	// [XID] // 0x0000000189B07E90-0x0000000189B07ED0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000181884100-0x00000001818841A0
}

