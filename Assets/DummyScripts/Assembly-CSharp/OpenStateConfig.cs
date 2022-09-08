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
public class OpenStateConfig : IAutoAllocRecycle // TypeDefIndex: 15934
{
	// Fields
	protected SimpleSafeUInt32 idRawNum; // 0x10
	protected bool _defaultState; // 0x14
	protected bool _allowClientOpen; // 0x15
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	protected OpenStateCond[] _cond; // 0x18
	protected SimpleSafeUInt32 system_open_ui_idRawNum; // 0x20

	// Properties
	public uint id { /* [XID] */ /* 0x00000001898BBAB0-0x00000001898BBAD0 */ get => default; /* [XID] */ /* 0x00000001898C3000-0x00000001898C3020 */ protected set {} } // 0x0000000184C290A0-0x0000000184C29170 0x0000000184C28730-0x0000000184C28810
	public bool defaultState { /* [XID] */ /* 0x00000001898CA960-0x00000001898CA980 */ get => default; /* [XID] */ /* 0x00000001898D2050-0x00000001898D2070 */ protected set {} } // 0x0000000184C27890-0x0000000184C27930 0x0000000184C28D60-0x0000000184C28E10
	public bool allowClientOpen { /* [XID] */ /* 0x00000001898D9930-0x00000001898D9950 */ get => default; /* [XID] */ /* 0x00000001898E1650-0x00000001898E1670 */ protected set {} } // 0x0000000184C27AC0-0x0000000184C27B60 0x0000000184C28EB0-0x0000000184C28F60
	public OpenStateCond[] cond { /* [XID] */ /* 0x00000001898E9120-0x00000001898E9140 */ get => default; /* [XID] */ /* 0x00000001898F08E0-0x00000001898F0900 */ protected set {} } // 0x0000000184C28E10-0x0000000184C28EB0 0x0000000184C27B60-0x0000000184C27C10
	public uint system_open_ui_id { /* [XID] */ /* 0x00000001898F8250-0x00000001898F8270 */ get => default; /* [XID] */ /* 0x00000001898FF8B0-0x00000001898FF8D0 */ protected set {} } // 0x0000000184C27C10-0x0000000184C27CE0 0x0000000184C28650-0x0000000184C28730

	// Constructors
	public OpenStateConfig() {} // 0x0000000184C29210-0x0000000184C29270

	// Methods
	// [IDTag] // 0x0000000189907090-0x00000001899070D0
	// [XID] // 0x0000000189907090-0x00000001899070D0
	public virtual bool ParseFromLine(string line) => default; // 0x0000000184C28140-0x0000000184C28650
	// [IDTag] // 0x0000000189911880-0x00000001899118C0
	// [XID] // 0x0000000189911880-0x00000001899118C0
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000184C27CE0-0x0000000184C28140
	// [XID] // 0x000000018991C520-0x000000018991C540
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2B95 */, bool useObjectPool = false /* Metadata: 0x00AF2B99 */) => default; // 0x0000000184C28810-0x0000000184C28D60
	[BlackList] // 0x0000000189923CC0-0x0000000189923D00
	// [XID] // 0x0000000189923CC0-0x0000000189923D00
	public virtual void AutoAllocTypeFields() {} // 0x0000000184C27930-0x0000000184C279D0
	[BlackList] // 0x000000018992E290-0x000000018992E2D0
	// [XID] // 0x000000018992E290-0x000000018992E2D0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000184C279D0-0x0000000184C27AC0
	[BlackList] // 0x00000001899385D0-0x0000000189938610
	// [XID] // 0x00000001899385D0-0x0000000189938610
	public virtual void ReturnToObjectPool() {} // 0x0000000184C29170-0x0000000184C29210
	[BlackList] // 0x0000000189942C70-0x0000000189942CB0
	// [XID] // 0x0000000189942C70-0x0000000189942CB0
	public virtual void OnPoolAllocated() {} // 0x0000000184C29000-0x0000000184C290A0
	[BlackList] // 0x000000018994D4D0-0x000000018994D510
	// [XID] // 0x000000018994D4D0-0x000000018994D510
	public virtual void OnBeforePoolRecycled() {} // 0x0000000184C28F60-0x0000000184C29000
}

