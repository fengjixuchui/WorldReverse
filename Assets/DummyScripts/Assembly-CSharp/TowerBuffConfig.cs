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
public class TowerBuffConfig : IAutoAllocRecycle // TypeDefIndex: 16198
{
	// Fields
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	protected TowerBuff[] _towerBuffList; // 0x10

	// Properties
	public TowerBuff[] towerBuffList { /* [XID] */ /* 0x00000001895FB590-0x00000001895FB5B0 */ get => default; /* [XID] */ /* 0x0000000189602CD0-0x0000000189602CF0 */ protected set {} } // 0x00000001850D3770-0x00000001850D3810 0x00000001850D3460-0x00000001850D3510

	// Constructors
	public TowerBuffConfig() {} // 0x00000001850D3C10-0x00000001850D3C70

	// Methods
	// [XID] // 0x000000018960A610-0x000000018960A630
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x00000001850D3650-0x00000001850D3770
	// [XID] // 0x0000000189611D80-0x0000000189611DA0
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF33ED */, bool useObjectPool = false /* Metadata: 0x00AF33F1 */) => default; // 0x00000001850D3810-0x00000001850D3A30
	[BlackList] // 0x0000000189619660-0x00000001896196A0
	// [XID] // 0x0000000189619660-0x00000001896196A0
	public virtual void AutoAllocTypeFields() {} // 0x00000001850D3510-0x00000001850D35B0
	[BlackList] // 0x0000000189623980-0x00000001896239C0
	// [XID] // 0x0000000189623980-0x00000001896239C0
	public virtual void AutoRecycleTypeFields() {} // 0x00000001850D35B0-0x00000001850D3650
	[BlackList] // 0x000000018962E210-0x000000018962E250
	// [XID] // 0x000000018962E210-0x000000018962E250
	public virtual void ReturnToObjectPool() {} // 0x00000001850D3B70-0x00000001850D3C10
	[BlackList] // 0x0000000189638DF0-0x0000000189638E30
	// [XID] // 0x0000000189638DF0-0x0000000189638E30
	public virtual void OnPoolAllocated() {} // 0x00000001850D3AD0-0x00000001850D3B70
	[BlackList] // 0x00000001896433E0-0x0000000189643420
	// [XID] // 0x00000001896433E0-0x0000000189643420
	public virtual void OnBeforePoolRecycled() {} // 0x00000001850D3A30-0x00000001850D3AD0
}

