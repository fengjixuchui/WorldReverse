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

[RecycleType] // 0x00000001898422C0-0x00000001898422E0
public abstract class MoveInfoBase : IAutoAllocRecycle // TypeDefIndex: 20215
{
	// Fields
	protected const float INTERNAL_COOLDOWN_BY_FAIL = 1f; // Metadata: 0x00AFD3BA

	// Constructors
	protected MoveInfoBase() {} // 0x000000018120E550-0x000000018120E5B0

	// Methods
	[BlackList] // 0x00000001896D1E00-0x00000001896D1E40
	// [XID] // 0x00000001896D1E00-0x00000001896D1E40
	public virtual void AutoAllocTypeFields() {} // 0x000000018120DF50-0x000000018120DFF0
	[BlackList] // 0x00000001896DC480-0x00000001896DC4C0
	// [XID] // 0x00000001896DC480-0x00000001896DC4C0
	public virtual void AutoRecycleTypeFields() {} // 0x000000018120DFF0-0x000000018120E090
	[BlackList] // 0x00000001896E69C0-0x00000001896E6A00
	// [XID] // 0x00000001896E69C0-0x00000001896E6A00
	public virtual void ReturnToObjectPool() {} // 0x000000018120E4B0-0x000000018120E550
	// [XID] // 0x0000000189BBD4B0-0x0000000189BBD4D0
	public void UpdateMoveInfo(AILocomotionHandler taskHandler, AIKnowledge aiKnowledge, LCAIBeta lcai, LCAIManager aiManager) {} // 0x000000018120DE30-0x000000018120DF50
	public abstract void UpdateInternal(AILocomotionHandler taskHandler, AIKnowledge aiKnowledge, LCAIBeta lcai, LCAIManager aiManager);
	// [XID] // 0x00000001896F85C0-0x00000001896F85E0
	public virtual void Enter(AILocomotionHandler taskHandler, AIKnowledge aiKnowledge, LCAIManager aiManager) {} // 0x000000018120E2A0-0x000000018120E370
	// [XID] // 0x000000018996D2F0-0x000000018996D310
	public virtual void Leave(AILocomotionHandler taskHandler, AIKnowledge aiKnowledge, LCAIManager aiManager) {} // 0x000000018120E130-0x000000018120E200
	// [XID] // 0x00000001897075E0-0x0000000189707600
	public virtual void OnPoseChanged() {} // 0x000000018120E200-0x000000018120E2A0
	// [XID] // 0x000000018970EEC0-0x000000018970EEE0
	public virtual void OnPoolAllocated() {} // 0x000000018120E410-0x000000018120E4B0
	// [XID] // 0x0000000189716340-0x0000000189716360
	public virtual void Clear() {} // 0x000000018120E090-0x000000018120E130
	// [XID] // 0x000000018971DD80-0x000000018971DDA0
	public virtual void OnBeforePoolRecycled() {} // 0x000000018120E370-0x000000018120E410
}

