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

[RecycleType] // 0x00000001898422C0-0x00000001898422E0
public class ActorFSMSystem : IAutoAllocRecycle // TypeDefIndex: 19944
{
	// Fields
	// [PooledField] // 0x00000001897FDA20-0x00000001897FDA40
	private List<ActorFSMState> states; // 0x10
	private ActorFSMStateID currentStateID; // 0x18
	private ActorFSMState currentState; // 0x20

	// Properties
	public ActorFSMStateID CurrentStateID { /* [XID] */ /* 0x00000001898E8A20-0x00000001898E8A40 */ get => default; } // 0x0000000183C2DEF0-0x0000000183C2DF90 
	public ActorFSMState CurrentState { /* [XID] */ /* 0x00000001898F0180-0x00000001898F01A0 */ get => default; } // 0x0000000183C2EBE0-0x0000000183C2EC80 

	// Constructors
	public ActorFSMSystem() {} // 0x0000000183C2EE60-0x0000000183C2EEC0

	// Methods
	[BlackList] // 0x00000001898C8B20-0x00000001898C8B60
	// [XID] // 0x00000001898C8B20-0x00000001898C8B60
	public virtual void AutoAllocTypeFields() {} // 0x0000000183C2DD70-0x0000000183C2DE40
	[BlackList] // 0x00000001898D3070-0x00000001898D30B0
	// [XID] // 0x00000001898D3070-0x00000001898D30B0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000183C2DE40-0x0000000183C2DEF0
	[BlackList] // 0x00000001898DDEC0-0x00000001898DDF00
	// [XID] // 0x00000001898DDEC0-0x00000001898DDF00
	public virtual void ReturnToObjectPool() {} // 0x0000000183C2EDC0-0x0000000183C2EE60
	// [XID] // 0x00000001898F7BD0-0x00000001898F7BF0
	public virtual void OnPoolAllocated() {} // 0x0000000183C2ED20-0x0000000183C2EDC0
	// [XID] // 0x00000001898FF190-0x00000001898FF1B0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000183C2EC80-0x0000000183C2ED20
	// [XID] // 0x0000000189906910-0x0000000189906930
	public void AddState(ActorFSMState s) {} // 0x0000000183C2E880-0x0000000183C2EBE0
	// [XID] // 0x000000018990E430-0x000000018990E450
	public void DeleteState(ActorFSMStateID id) {} // 0x0000000183C2E560-0x0000000183C2E880
	// [XID] // 0x0000000189915B00-0x0000000189915B20
	public void DeleteAllState() {} // 0x0000000183C2E160-0x0000000183C2E350
	// [XID] // 0x000000018991D4D0-0x000000018991D4F0
	public void PerformTransition(ActorFSMTransition trans) {} // 0x0000000183C2E350-0x0000000183C2E560
	// [XID] // 0x0000000189924DA0-0x0000000189924DC0
	public void ForceSetCurState(ActorFSMStateID stateID) {} // 0x0000000183C2DF90-0x0000000183C2E160
}

