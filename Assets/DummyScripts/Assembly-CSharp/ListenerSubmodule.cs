/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ListenerSubmodule : MultiThreadedSubmodule<CommandThreadListenerFunctionalities, WorkerThreadListenerFunctionalities, SharedListenerFunctionalities> // TypeDefIndex: 11322
{
	// Constructors
	public ListenerSubmodule() {} // Dummy constructor
	public ListenerSubmodule(SharedContext sharedContext, CommandThreadContext commandThreadContext, WorkerThreadContext workerThreadContext) {} // 0x0000000183FBE5E0-0x0000000183FBE670

	// Methods
	// [XID] // 0x000000018976C4D0-0x000000018976C4F0
	protected override SharedListenerFunctionalities CreateSharedFunctionalities(SharedContext sharedContext, CommandThreadContext commandThreadContext, WorkerThreadContext workerThreadContext) => default; // 0x0000000183FBE4F0-0x0000000183FBE5E0
	// [XID] // 0x0000000189773AA0-0x0000000189773AC0
	protected override CommandThreadListenerFunctionalities CreateCommandThreadFunctionalities(CommandThreadContext commandThreadContext, SharedListenerFunctionalities shared) => default; // 0x0000000183FBE330-0x0000000183FBE410
	// [XID] // 0x00000001897FA5E0-0x00000001897FA600
	protected override WorkerThreadListenerFunctionalities CreateWorkerThreadFunctionalities(WorkerThreadContext workerThreadContext, SharedListenerFunctionalities shared) => default; // 0x0000000183FBE410-0x0000000183FBE4F0
}

