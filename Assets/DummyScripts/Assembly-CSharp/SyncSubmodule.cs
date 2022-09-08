/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class SyncSubmodule : MultiThreadedSubmodule<CommandThreadSyncFunctionalities, WorkerThreadSyncFunctionalities, SharedSyncFunctionalities> // TypeDefIndex: 11442
{
	// Constructors
	public SyncSubmodule() {} // Dummy constructor
	public SyncSubmodule(SharedContext sharedContext, CommandThreadContext commandThreadContext, WorkerThreadContext workerThreadContext) {} // 0x00000001826C5C90-0x00000001826C5D20

	// Methods
	// [XID] // 0x0000000189A0C590-0x0000000189A0C5B0
	protected override SharedSyncFunctionalities CreateSharedFunctionalities(SharedContext sharedContext, CommandThreadContext commandThreadContext, WorkerThreadContext workerThreadContext) => default; // 0x00000001826C5BA0-0x00000001826C5C90
	// [XID] // 0x0000000189A1B180-0x0000000189A1B1A0
	protected override CommandThreadSyncFunctionalities CreateCommandThreadFunctionalities(CommandThreadContext commandThreadContext, SharedSyncFunctionalities shared) => default; // 0x00000001826C59E0-0x00000001826C5AC0
	// [XID] // 0x000000018980BC40-0x000000018980BC60
	protected override WorkerThreadSyncFunctionalities CreateWorkerThreadFunctionalities(WorkerThreadContext workerThreadContext, SharedSyncFunctionalities shared) => default; // 0x00000001826C5AC0-0x00000001826C5BA0
}

