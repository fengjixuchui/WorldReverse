/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using miHoYoThread;
using MoleMole;
using MoleMole.AsyncNetwork;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class SocketMgrTask : ThreadBackgroundTask<SocketMgrTaskData> // TypeDefIndex: 26573
{
	// Fields
	private const string _taskName = "SocketMgr"; // Metadata: 0x00B0C539
	private SyncContext _serverContext; // 0x48
	private AsyncExecutorQueue _autoTestJobQueue; // 0x50

	// Properties
	public override string taskName { /* [XID] */ /* 0x0000000189846770-0x0000000189846790 */ get => default; } // 0x00000001815562D0-0x0000000181556380 

	// Constructors
	public SocketMgrTask() {} // 0x0000000181556260-0x00000001815562D0

	// Methods
	// [XID] // 0x000000018984DD00-0x000000018984DD20
	public override void BindTarget(object target) {} // 0x0000000181555D70-0x0000000181555E80
	// [XID] // 0x0000000189854E20-0x0000000189854E40
	public override void Execute() {} // 0x0000000181555F50-0x0000000181556070
	// [XID] // 0x000000018985C5C0-0x000000018985C5E0
	protected override void OnDestroy() {} // 0x00000001815561B0-0x0000000181556260
	// [XID] // 0x0000000189863F40-0x0000000189863F60
	public void QueueAutoTestJob(IAsyncExecutor ae) {} // 0x00000001815560F0-0x00000001815561B0
}

