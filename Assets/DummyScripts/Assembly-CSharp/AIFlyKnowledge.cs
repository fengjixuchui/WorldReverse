/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MihoyoOptimization;
using MoleMole;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public sealed class AIFlyKnowledge : Switchable, IAutoAllocRecycle // TypeDefIndex: 19953
{
	// Fields
	public List<int> floatingPoses; // 0x18
	public bool inFly; // 0x20

	// Constructors
	public AIFlyKnowledge() {} // 0x00000001849AA400-0x00000001849AA470

	// Methods
	[BlackList] // 0x0000000189B1ABE0-0x0000000189B1AC20
	// [XID] // 0x0000000189B1ABE0-0x0000000189B1AC20
	public override void AutoAllocTypeFields() {} // 0x00000001849AA030-0x00000001849AA0D0
	[BlackList] // 0x0000000189B251A0-0x0000000189B251E0
	// [XID] // 0x0000000189B251A0-0x0000000189B251E0
	public override void AutoRecycleTypeFields() {} // 0x00000001849AA0D0-0x00000001849AA180
	[BlackList] // 0x0000000189B2F270-0x0000000189B2F2B0
	// [XID] // 0x0000000189B2F270-0x0000000189B2F2B0
	public override void ReturnToObjectPool() {} // 0x00000001849AA360-0x00000001849AA400
	// [XID] // 0x00000001897FE7D0-0x00000001897FE7F0
	public void ReInitByConfigID(BaseEntity.ReInitReason reason) {} // 0x00000001849AA2A0-0x00000001849AA360
	// [XID] // 0x00000001897E7DD0-0x00000001897E7DF0
	public void InitFly(ConfigAIFlySetting flyConfig, ConfigAIMove moveSetting, AIKnowledge knowledge, VCBaseMove moveComponent) {} // 0x00000001849A9E90-0x00000001849AA030
}

