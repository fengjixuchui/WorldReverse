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
public class Switchable : IAutoAllocRecycle // TypeDefIndex: 20336
{
	// Fields
	private bool _bigSwitch; // 0x10
	private bool _lilSwitch; // 0x11

	// Constructors
	public Switchable() {} // 0x0000000183611BE0-0x0000000183611C50

	// Methods
	[BlackList] // 0x0000000189B4BF40-0x0000000189B4BF80
	// [XID] // 0x0000000189B4BF40-0x0000000189B4BF80
	public virtual void AutoAllocTypeFields() {} // 0x0000000183611620-0x00000001836116C0
	[BlackList] // 0x0000000189B566A0-0x0000000189B566E0
	// [XID] // 0x0000000189B566A0-0x0000000189B566E0
	public virtual void AutoRecycleTypeFields() {} // 0x00000001836116C0-0x0000000183611760
	[BlackList] // 0x0000000189B60EF0-0x0000000189B60F30
	// [XID] // 0x0000000189B60EF0-0x0000000189B60F30
	public virtual void ReturnToObjectPool() {} // 0x0000000183611B40-0x0000000183611BE0
	[BlackList] // 0x0000000189B6B520-0x0000000189B6B560
	// [XID] // 0x0000000189B6B520-0x0000000189B6B560
	public virtual void OnPoolAllocated() {} // 0x0000000183611AA0-0x0000000183611B40
	[BlackList] // 0x0000000189B759D0-0x0000000189B75A10
	// [XID] // 0x0000000189B759D0-0x0000000189B75A10
	public virtual void OnBeforePoolRecycled() {} // 0x0000000183611A00-0x0000000183611AA0
	// [XID] // 0x00000001897A3C50-0x00000001897A3C70
	public void SetSwitch(bool enable) {} // 0x0000000183611950-0x0000000183611A00
	// [XID] // 0x0000000189B87980-0x0000000189B879A0
	public void Switch(bool enable) {} // 0x00000001836118A0-0x0000000183611950
	// [XID] // 0x0000000189B027C0-0x0000000189B027E0
	public bool IsActive() => default; // 0x0000000183611570-0x0000000183611620
	// [XID] // 0x0000000189855F50-0x0000000189855F70
	public bool HasSetting() => default; // 0x0000000183611800-0x00000001836118A0
	// [XID] // 0x0000000189B9D5A0-0x0000000189B9D5C0
	public void Reset() {} // 0x0000000183611760-0x0000000183611800
}

