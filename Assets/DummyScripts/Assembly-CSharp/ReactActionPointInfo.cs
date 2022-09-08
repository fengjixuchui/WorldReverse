/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ReactActionPointInfo : MoveInfoBase, IAutoAllocRecycle // TypeDefIndex: 20227
{
	// Fields
	public ReactStatus status; // 0x10

	// Nested types
	public enum ReactStatus // TypeDefIndex: 20228
	{
		Inactive = 0,
		MoveToPoint = 1,
		TurnToCenter = 2,
		DoAction = 3,
		Interrupted = 4
	}

	// Constructors
	public ReactActionPointInfo() {} // 0x00000001824FAF90-0x00000001824FB000

	// Methods
	[BlackList] // 0x00000001897E8890-0x00000001897E88D0
	// [XID] // 0x00000001897E8890-0x00000001897E88D0
	public override void AutoAllocTypeFields() {} // 0x00000001824FA000-0x00000001824FA0A0
	[BlackList] // 0x00000001897F3650-0x00000001897F3690
	// [XID] // 0x00000001897F3650-0x00000001897F3690
	public override void AutoRecycleTypeFields() {} // 0x00000001824FA0A0-0x00000001824FA150
	[BlackList] // 0x00000001897FD980-0x00000001897FD9C0
	// [XID] // 0x00000001897FD980-0x00000001897FD9C0
	public override void ReturnToObjectPool() {} // 0x00000001824FAEF0-0x00000001824FAF90
	// [XID] // 0x0000000189808120-0x0000000189808140
	public override void Clear() {} // 0x00000001824FA350-0x00000001824FA3F0
	// [XID] // 0x000000018980FB30-0x000000018980FB50
	public override void Enter(AILocomotionHandler taskHandler, AIKnowledge aiKnowledge, LCAIManager aiManager) {} // 0x00000001824FAE10-0x00000001824FAEF0
	// [XID] // 0x0000000189817100-0x0000000189817120
	public override void Leave(AILocomotionHandler taskHandler, AIKnowledge aiKnowledge, LCAIManager aiManager) {} // 0x00000001824FAC70-0x00000001824FAD50
	// [XID] // 0x000000018981EA10-0x000000018981EA30
	public override void UpdateInternal(AILocomotionHandler taskHandler, AIKnowledge aiKnowledge, LCAIBeta lcai, LCAIManager aiManager) {} // 0x00000001824FA4A0-0x00000001824FAAF0
	// [XID] // 0x0000000189825EE0-0x0000000189825F00
	public void Interrupt() {} // 0x00000001824FA3F0-0x00000001824FA4A0
	// [XID] // 0x000000018982D5A0-0x000000018982D5C0
	private void TryTurnToCenter(AILocomotionHandler taskHandler, AIPrecombatKnowledge precombatKnowledge) {} // 0x00000001824FA150-0x00000001824FA2F0
}

