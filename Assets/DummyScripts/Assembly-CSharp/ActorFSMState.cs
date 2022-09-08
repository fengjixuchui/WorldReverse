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
public abstract class ActorFSMState : IAutoAllocRecycle // TypeDefIndex: 19933
{
	// Fields
	// [PooledField] // 0x00000001897FDA20-0x00000001897FDA40
	protected Dictionary<ActorFSMTransition, ActorFSMStateID> map; // 0x10
	protected ActorFSMStateID stateID; // 0x18
	protected NpcActor owner; // 0x20
	protected ActorFSMBlackBoard blackBoard; // 0x28

	// Properties
	public ActorFSMStateID ID { /* [XID] */ /* 0x0000000189AEFCC0-0x0000000189AEFCE0 */ get; } // 0x00000001834E36E0-0x00000001834E3780 
	public virtual bool IgnoreIntervalTick { /* [XID] */ /* 0x0000000189AF7200-0x0000000189AF7220 */ get; } // 0x00000001834E3820-0x00000001834E38C0 

	// Constructors
	protected ActorFSMState() {} // 0x00000001834E4450-0x00000001834E44C0

	// Methods
	[BlackList] // 0x0000000189ACF8B0-0x0000000189ACF8F0
	// [XID] // 0x0000000189ACF8B0-0x0000000189ACF8F0
	public virtual void AutoAllocTypeFields() {} // 0x00000001834E3040-0x00000001834E3110
	[BlackList] // 0x0000000189ADA5E0-0x0000000189ADA620
	// [XID] // 0x0000000189ADA5E0-0x0000000189ADA620
	public virtual void AutoRecycleTypeFields() {} // 0x00000001834E3110-0x00000001834E31D0
	[BlackList] // 0x0000000189AE5160-0x0000000189AE51A0
	// [XID] // 0x0000000189AE5160-0x0000000189AE51A0
	public virtual void ReturnToObjectPool() {} // 0x00000001834E43B0-0x00000001834E4450
	// [XID] // 0x0000000189AFE830-0x0000000189AFE850
	public virtual void OnPoolAllocated() {} // 0x00000001834E4310-0x00000001834E43B0
	// [XID] // 0x0000000189B060E0-0x0000000189B06100
	public virtual void OnBeforePoolRecycled() {} // 0x00000001834E4270-0x00000001834E4310
	// [XID] // 0x0000000189B0D7F0-0x0000000189B0D810
	public void AddTransition(ActorFSMTransition trans, ActorFSMStateID id) {} // 0x00000001834E38C0-0x00000001834E3C40
	// [XID] // 0x0000000189B14CB0-0x0000000189B14CD0
	public void DeleteTransition(ActorFSMTransition trans) {} // 0x00000001834E3C40-0x00000001834E4020
	// [XID] // 0x0000000189B1C5F0-0x0000000189B1C610
	public virtual ActorFSMStateID GetOutputState(ActorFSMTransition trans) => default; // 0x00000001834E40E0-0x00000001834E41D0
	// [XID] // 0x0000000189B23B40-0x0000000189B23B60
	public ActorFSMTransition GetOutputTransition(ActorFSMStateID stateID) => default; // 0x00000001834E34F0-0x00000001834E36E0
	// [XID] // 0x0000000189B2AE60-0x0000000189B2AE80
	public virtual void DoBeforeEntering() {} // 0x00000001834E3450-0x00000001834E34F0
	// [XID] // 0x0000000189B32420-0x0000000189B32440
	public virtual void DoBeforeLeaving() {} // 0x00000001834E2FA0-0x00000001834E3040
	public abstract void Reason(float deltaTime);
	public abstract void Act(float deltaTime);
	// [XID] // 0x0000000189B39D10-0x0000000189B39D30
	public virtual void OnDestroy() {} // 0x00000001834E31D0-0x00000001834E3270
	// [XID] // 0x0000000189B41610-0x0000000189B41630
	public virtual void OnResetFreeStyleTrigger() {} // 0x00000001834E3310-0x00000001834E33B0
	// [XID] // 0x0000000189B48FE0-0x0000000189B49000
	public virtual void OnBlackBloardRefresh() {} // 0x00000001834E33B0-0x00000001834E3450
	// [XID] // 0x0000000189B505A0-0x0000000189B505C0
	public virtual void PerformResetState() {} // 0x00000001834E3270-0x00000001834E3310
	// [XID] // 0x0000000189B57EF0-0x0000000189B57F10
	public virtual void OnShow() {} // 0x00000001834E3780-0x00000001834E3820
	// [XID] // 0x0000000189B5F890-0x0000000189B5F8B0
	public virtual void OnHide() {} // 0x00000001834E41D0-0x00000001834E4270
	// [XID] // 0x0000000189B66FA0-0x0000000189B66FC0
	public virtual void OnEntityRuntimeIdChange(uint oldId, uint newId) {} // 0x00000001834E4020-0x00000001834E40E0
}

