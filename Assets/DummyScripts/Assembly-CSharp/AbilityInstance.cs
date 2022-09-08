/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class AbilityInstance : IAbilityExecute // TypeDefIndex: 20577
{
	// Fields
	private int _index; // 0x10
	protected Ability _ability; // 0x18
	protected AbilityContext _abilityContext; // 0x20
	protected AbilityComponentProxy _abilityProxy; // 0x28
	protected List<AbilityTask> _asyncTasks; // 0x30
	protected List<AbilityTask> _activeAsyncTasks; // 0x38
	protected List<AbilityTask> _finishedAsyncTasks; // 0x40
	protected List<AbilityTask> _syncTasks; // 0x48
	protected List<AbilityTask> _activeSyncTasks; // 0x50
	protected List<AbilityTask> _finishedSyncTasks; // 0x58
	private bool _isSingleInstance; // 0x60
	private bool _isActive; // 0x61
	private bool _isPending; // 0x62

	// Properties
	public int index { /* [XID] */ /* 0x0000000189B2C670-0x0000000189B2C690 */ get => default; /* [XID] */ /* 0x0000000189B33BE0-0x0000000189B33C00 */ set {} } // 0x0000000183E5A9D0-0x0000000183E5AA70 0x0000000183E5AB10-0x0000000183E5ABC0
	public bool isSingleInstance { /* [XID] */ /* 0x0000000189B51E20-0x0000000189B51E40 */ get => default; } // 0x0000000183E59E10-0x0000000183E59EB0 
	public bool isActive { /* [XID] */ /* 0x0000000189B59680-0x0000000189B596A0 */ get => default; } // 0x0000000183E5B320-0x0000000183E5B3C0 
	public bool isPending { /* [XID] */ /* 0x0000000189B60ED0-0x0000000189B60EF0 */ get => default; } // 0x0000000183E5B0A0-0x0000000183E5B140 

	// Constructors
	public AbilityInstance() {} // 0x0000000183E5B4D0-0x0000000183E5B650

	// Methods
	// [XID] // 0x0000000189B3B4B0-0x0000000189B3B4D0
	public void Collect() {} // 0x0000000183E59500-0x0000000183E595A0
	// [XID] // 0x0000000189B42D50-0x0000000189B42D70
	public void Execute() {} // 0x0000000183E59460-0x0000000183E59500
	// [XID] // 0x0000000189B4A6F0-0x0000000189B4A710
	public void Flush() {} // 0x0000000183E5AA70-0x0000000183E5AB10
	// [XID] // 0x0000000189B68690-0x0000000189B686B0
	public void Init(AbilityContext abilityContext, AbilityComponentProxy proxy) {} // 0x0000000183E59D20-0x0000000183E59E10
	// [XID] // 0x0000000189B6FA20-0x0000000189B6FA40
	public void Active() {} // 0x0000000183E5ABC0-0x0000000183E5AC70
	// [XID] // 0x0000000189B76FB0-0x0000000189B76FD0
	public void Pend() {} // 0x0000000183E5A370-0x0000000183E5A410
	// [XID] // 0x0000000189B7E5C0-0x0000000189B7E5E0
	public void Clear() {} // 0x0000000183E5A0A0-0x0000000183E5A2D0
	// [XID] // 0x0000000189B861D0-0x0000000189B861F0
	public void Destroy() {} // 0x0000000183E595A0-0x0000000183E59770
	// [XID] // 0x0000000189B8D270-0x0000000189B8D290
	private void ReleaseTasks(List<AbilityTask> tasks) {} // 0x0000000183E5AC70-0x0000000183E5AD80
	// [XID] // 0x0000000189B949D0-0x0000000189B949F0
	private void InitTasks() {} // 0x0000000183E59EB0-0x0000000183E5A0A0
	// [XID] // 0x0000000189B9C080-0x0000000189B9C0A0
	private void ActiveTasks(AbilityContext abilityContext) {} // 0x0000000183E59A30-0x0000000183E59C00
	// [XID] // 0x0000000189BA3810-0x0000000189BA3830
	public void PreUpdate() {} // 0x0000000183E5A4C0-0x0000000183E5A580
	// [XID] // 0x0000000189BAAB80-0x0000000189BAABA0
	private void UpdateContext() {} // 0x0000000183E5A410-0x0000000183E5A4C0
	// [XID] // 0x0000000189BB2150-0x0000000189BB2170
	public bool HasAsyncTasks() => default; // 0x0000000183E5B3C0-0x0000000183E5B4D0
	// [XID] // 0x0000000189BB9540-0x0000000189BB9560
	public bool HasSyncTasks() => default; // 0x0000000183E5A580-0x0000000183E5A690
	// [XID] // 0x0000000189BC1380-0x0000000189BC13A0
	public bool IsDone() => default; // 0x0000000183E5A730-0x0000000183E5A830
	// [XID] // 0x0000000189BC8C00-0x0000000189BC8C20
	private bool IsTasksDone(List<AbilityTask> inTasks, List<AbilityTask> inActiveTasks, List<AbilityTask> inFinishedTasks) => default; // 0x0000000183E5B140-0x0000000183E5B280
	// [XID] // 0x0000000189BD03E0-0x0000000189BD0400
	public void AsyncUpdate() {} // 0x0000000183E5A8D0-0x0000000183E5A9D0
	// [XID] // 0x0000000189BD7950-0x0000000189BD7970
	public void SyncUpdate() {} // 0x0000000183E59930-0x0000000183E59A30
	// [XID] // 0x0000000189BDF4A0-0x0000000189BDF4C0
	public void FlushUpdate() {} // 0x0000000183E592D0-0x0000000183E593A0
	// [XID] // 0x00000001895EC050-0x00000001895EC070
	public void FinishAbility() {} // 0x0000000183E59770-0x0000000183E59810
	// [XID] // 0x00000001895F3470-0x00000001895F3490
	public void InterruptAbility() {} // 0x0000000183E5A690-0x0000000183E5A730
	// [XID] // 0x00000001895FADB0-0x00000001895FADD0
	public void BranchAbility() {} // 0x0000000183E5A830-0x0000000183E5A8D0
	// [XID] // 0x0000000189602680-0x00000001896026A0
	public Ability GetAbility() => default; // 0x0000000183E5B280-0x0000000183E5B320
	// [XID] // 0x00000001899A2530-0x00000001899A2550
	public AbilityContext GetContext() => default; // 0x0000000183E5A2D0-0x0000000183E5A370
	// [XID] // 0x00000001896117A0-0x00000001896117C0
	protected void InternalUpdateTasks(List<AbilityTask> inTasks, List<AbilityTask> inActiveTasks, List<AbilityTask> inFinishedTasks, float currentTime, float deltaTime) {} // 0x0000000183E5AD80-0x0000000183E5B0A0
	// [XID] // 0x0000000189619060-0x0000000189619080
	protected void InternalStopRunningTasks(EAbilityTaskResult reason, bool resetLoop) {} // 0x0000000183E593A0-0x0000000183E59460
	// [XID] // 0x0000000189620560-0x0000000189620580
	protected void InternalPreUpdateTasks(List<AbilityTask> inActiveTasks) {} // 0x0000000183E59810-0x0000000183E59930
	// [XID] // 0x00000001896279F0-0x0000000189627A10
	protected void InternalFlushUpdateTasks(List<AbilityTask> inActiveTasks) {} // 0x0000000183E59C00-0x0000000183E59D20
}

