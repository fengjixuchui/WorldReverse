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
public class AIActionControlState : IAutoAllocRecycle // TypeDefIndex: 19945
{
	// Fields
	public bool isPrepared; // 0x10
	public AISkillInfo skill; // 0x18
	public SkillStatus status; // 0x20
	public float querySkillDiscardTick; // 0x24
	public int currentStateID; // 0x28

	// Constructors
	public AIActionControlState() {} // 0x00000001840332F0-0x0000000184033360

	// Methods
	[BlackList] // 0x0000000189933860-0x00000001899338A0
	// [XID] // 0x0000000189933860-0x00000001899338A0
	public virtual void AutoAllocTypeFields() {} // 0x0000000184032F10-0x0000000184032FB0
	[BlackList] // 0x000000018993E270-0x000000018993E2B0
	// [XID] // 0x000000018993E270-0x000000018993E2B0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000184032FB0-0x0000000184033060
	[BlackList] // 0x0000000189948780-0x00000001899487C0
	// [XID] // 0x0000000189948780-0x00000001899487C0
	public virtual void ReturnToObjectPool() {} // 0x0000000184033250-0x00000001840332F0
	[BlackList] // 0x0000000189953030-0x0000000189953070
	// [XID] // 0x0000000189953030-0x0000000189953070
	public virtual void OnPoolAllocated() {} // 0x00000001840331B0-0x0000000184033250
	[BlackList] // 0x000000018995D890-0x000000018995D8D0
	// [XID] // 0x000000018995D890-0x000000018995D8D0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000184033110-0x00000001840331B0
	// [XID] // 0x0000000189967FA0-0x0000000189967FC0
	public void Reset() {} // 0x0000000184033060-0x0000000184033110
}

