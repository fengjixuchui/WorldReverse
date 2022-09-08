/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class EngineSubmodule : MultiThreadedSubmodule<CommandThreadEngineFunctionalities, WorkerThreadEngineFunctionalities, SharedEngineFunctionalities> // TypeDefIndex: 11277
{
	// Constructors
	public EngineSubmodule() {} // Dummy constructor
	public EngineSubmodule(SharedContext sharedContext, CommandThreadContext commandThreadContext, WorkerThreadContext workerThreadContext) {} // 0x0000000181E2BE70-0x0000000181E2BF00

	// Methods
	// [XID] // 0x0000000189B7F3E0-0x0000000189B7F400
	protected override SharedEngineFunctionalities CreateSharedFunctionalities(SharedContext sharedContext, CommandThreadContext commandThreadContext, WorkerThreadContext workerThreadContext) => default; // 0x0000000181E2BD80-0x0000000181E2BE70
	// [XID] // 0x0000000189B14290-0x0000000189B142B0
	protected override CommandThreadEngineFunctionalities CreateCommandThreadFunctionalities(CommandThreadContext commandThreadContext, SharedEngineFunctionalities shared) => default; // 0x0000000181E2BBC0-0x0000000181E2BCA0
	// [XID] // 0x0000000189B33220-0x0000000189B33240
	protected override WorkerThreadEngineFunctionalities CreateWorkerThreadFunctionalities(WorkerThreadContext workerThreadContext, SharedEngineFunctionalities shared) => default; // 0x0000000181E2BCA0-0x0000000181E2BD80
}

