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
public class AISkillGroupCDInfo : IAutoAllocRecycle // TypeDefIndex: 19974
{
	// Fields
	public int groupID; // 0x10
	public float groupCDTime; // 0x14
	public float nextCDTick; // 0x18

	// Constructors
	public AISkillGroupCDInfo() {} // 0x000000018140D870-0x000000018140D8F0

	// Methods
	[BlackList] // 0x0000000189732820-0x0000000189732860
	// [XID] // 0x0000000189732820-0x0000000189732860
	public virtual void AutoAllocTypeFields() {} // 0x000000018140D470-0x000000018140D510
	[BlackList] // 0x000000018973D2F0-0x000000018973D330
	// [XID] // 0x000000018973D2F0-0x000000018973D330
	public virtual void AutoRecycleTypeFields() {} // 0x000000018140D510-0x000000018140D5C0
	[BlackList] // 0x00000001897479B0-0x00000001897479F0
	// [XID] // 0x00000001897479B0-0x00000001897479F0
	public virtual void ReturnToObjectPool() {} // 0x000000018140D7D0-0x000000018140D870
	[BlackList] // 0x0000000189751F30-0x0000000189751F70
	// [XID] // 0x0000000189751F30-0x0000000189751F70
	public virtual void OnPoolAllocated() {} // 0x000000018140D730-0x000000018140D7D0
	[BlackList] // 0x000000018975C410-0x000000018975C450
	// [XID] // 0x000000018975C410-0x000000018975C450
	public virtual void OnBeforePoolRecycled() {} // 0x000000018140D690-0x000000018140D730
	// [XID] // 0x0000000189766CE0-0x0000000189766D00
	public void InitGroupCDInfo(int id, float cdTime) {} // 0x000000018140D5C0-0x000000018140D690
}

