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
public class AIRangeSelector : IAutoAllocRecycle // TypeDefIndex: 19970
{
	// Fields
	public float min; // 0x10
	public float max; // 0x14

	// Constructors
	public AIRangeSelector() {} // 0x0000000184597C30-0x0000000184597CA0

	// Methods
	[BlackList] // 0x000000018964A450-0x000000018964A490
	// [XID] // 0x000000018964A450-0x000000018964A490
	public virtual void AutoAllocTypeFields() {} // 0x0000000184597770-0x0000000184597810
	[BlackList] // 0x0000000189654E00-0x0000000189654E40
	// [XID] // 0x0000000189654E00-0x0000000189654E40
	public virtual void AutoRecycleTypeFields() {} // 0x0000000184597810-0x00000001845978B0
	[BlackList] // 0x000000018965F2C0-0x000000018965F300
	// [XID] // 0x000000018965F2C0-0x000000018965F300
	public virtual void ReturnToObjectPool() {} // 0x0000000184597B90-0x0000000184597C30
	[BlackList] // 0x0000000189669D00-0x0000000189669D40
	// [XID] // 0x0000000189669D00-0x0000000189669D40
	public virtual void OnPoolAllocated() {} // 0x0000000184597A20-0x0000000184597AC0
	[BlackList] // 0x0000000189674790-0x00000001896747D0
	// [XID] // 0x0000000189674790-0x00000001896747D0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000184597980-0x0000000184597A20
	// [XID] // 0x000000018967ED40-0x000000018967ED60
	public void InitRange(float pMin, float pMax) {} // 0x00000001845978B0-0x0000000184597980
	// [XID] // 0x0000000189686670-0x0000000189686690
	public int CheckRange(float dist) => default; // 0x0000000184597AC0-0x0000000184597B90
}

