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
public class AICombatKnowledge : IAutoAllocRecycle // TypeDefIndex: 19949
{
	// Fields
	public ConfigAICombatSetting config; // 0x10
	public ConfigAICombatPhase currentPhase; // 0x18

	// Constructors
	public AICombatKnowledge() {} // 0x00000001834E81D0-0x00000001834E8230

	// Methods
	[BlackList] // 0x0000000189A118A0-0x0000000189A118E0
	// [XID] // 0x0000000189A118A0-0x0000000189A118E0
	public virtual void AutoAllocTypeFields() {} // 0x00000001834E7970-0x00000001834E7A10
	[BlackList] // 0x0000000189A1B9D0-0x0000000189A1BA10
	// [XID] // 0x0000000189A1B9D0-0x0000000189A1BA10
	public virtual void AutoRecycleTypeFields() {} // 0x00000001834E7A10-0x00000001834E7AB0
	[BlackList] // 0x0000000189A26030-0x0000000189A26070
	// [XID] // 0x0000000189A26030-0x0000000189A26070
	public virtual void ReturnToObjectPool() {} // 0x00000001834E8130-0x00000001834E81D0
	[BlackList] // 0x0000000189A30410-0x0000000189A30450
	// [XID] // 0x0000000189A30410-0x0000000189A30450
	public virtual void OnPoolAllocated() {} // 0x00000001834E7CB0-0x00000001834E7D50
	[BlackList] // 0x0000000189A3AB60-0x0000000189A3ABA0
	// [XID] // 0x0000000189A3AB60-0x0000000189A3ABA0
	public virtual void OnBeforePoolRecycled() {} // 0x00000001834E7C10-0x00000001834E7CB0
	// [XID] // 0x0000000189A45450-0x0000000189A45470
	public void ReInitByConfigID(BaseEntity.ReInitReason reason) {} // 0x00000001834E7B60-0x00000001834E7C10
	// [XID] // 0x0000000189A4CAC0-0x0000000189A4CAE0
	public void InitCombat(ConfigAICombatSetting combatSetting) {} // 0x00000001834E7AB0-0x00000001834E7B60
	// [XID] // 0x0000000189A54330-0x0000000189A54350
	public void UpdatePhase(int poseID, LCAIBeta lcai) {} // 0x00000001834E7D50-0x00000001834E8130
}

