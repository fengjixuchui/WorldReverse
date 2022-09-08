/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class VoiceSubmodule : MultiThreadedSubmodule<CommandThreadVoiceFunctionalities, WorkerThreadVoiceFunctionalities, SharedVoiceFunctionalities> // TypeDefIndex: 11465
{
	// Constructors
	public VoiceSubmodule() {} // Dummy constructor
	public VoiceSubmodule(SharedContext sharedContext, CommandThreadContext commandThreadContext, WorkerThreadContext workerThreadContext) {} // 0x0000000183C1A340-0x0000000183C1A3D0

	// Methods
	// [XID] // 0x0000000189741040-0x0000000189741060
	protected override SharedVoiceFunctionalities CreateSharedFunctionalities(SharedContext sharedContext, CommandThreadContext commandThreadContext, WorkerThreadContext workerThreadContext) => default; // 0x0000000183C1A250-0x0000000183C1A340
	// [XID] // 0x0000000189748850-0x0000000189748870
	protected override CommandThreadVoiceFunctionalities CreateCommandThreadFunctionalities(CommandThreadContext commandThreadContext, SharedVoiceFunctionalities shared) => default; // 0x0000000183C1A090-0x0000000183C1A170
	// [XID] // 0x000000018974FDD0-0x000000018974FDF0
	protected override WorkerThreadVoiceFunctionalities CreateWorkerThreadFunctionalities(WorkerThreadContext workerThreadContext, SharedVoiceFunctionalities shared) => default; // 0x0000000183C1A170-0x0000000183C1A250
}

