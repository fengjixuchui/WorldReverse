/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class EventSubmodule : MultiThreadedSubmodule<CommandThreadEventFunctionalities, WorkerThreadEventFunctionalities, SharedEventFunctionalities> // TypeDefIndex: 11306
{
	// Constructors
	public EventSubmodule() {} // Dummy constructor
	public EventSubmodule(SharedContext sharedContext, CommandThreadContext commandThreadContext, WorkerThreadContext workerThreadContext) {} // 0x0000000182964FE0-0x0000000182965070

	// Methods
	// [XID] // 0x00000001899E4330-0x00000001899E4350
	protected override SharedEventFunctionalities CreateSharedFunctionalities(SharedContext sharedContext, CommandThreadContext commandThreadContext, WorkerThreadContext workerThreadContext) => default; // 0x0000000182964EF0-0x0000000182964FE0
	// [XID] // 0x00000001899F33A0-0x00000001899F33C0
	protected override CommandThreadEventFunctionalities CreateCommandThreadFunctionalities(CommandThreadContext commandThreadContext, SharedEventFunctionalities shared) => default; // 0x0000000182964D30-0x0000000182964E10
	// [XID] // 0x00000001899FAB30-0x00000001899FAB50
	protected override WorkerThreadEventFunctionalities CreateWorkerThreadFunctionalities(WorkerThreadContext workerThreadContext, SharedEventFunctionalities shared) => default; // 0x0000000182964E10-0x0000000182964EF0
}

