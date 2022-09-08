/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class SpatialSubmodule : MultiThreadedSubmodule<CommandThreadSpatialFunctionalities, WorkerThreadSpatialFunctionalities, SharedSpatialFunctionalities> // TypeDefIndex: 11421
{
	// Constructors
	public SpatialSubmodule() {} // Dummy constructor
	public SpatialSubmodule(SharedContext sharedContext, CommandThreadContext commandThreadContext, WorkerThreadContext workerThreadContext) {} // 0x0000000181826590-0x0000000181826620

	// Methods
	// [XID] // 0x00000001898F5690-0x00000001898F56B0
	protected override CommandThreadSpatialFunctionalities CreateCommandThreadFunctionalities(CommandThreadContext commandThreadContext, SharedSpatialFunctionalities shared) => default; // 0x00000001818262E0-0x00000001818263C0
	// [XID] // 0x0000000189603620-0x0000000189603640
	protected override SharedSpatialFunctionalities CreateSharedFunctionalities(SharedContext sharedContext, CommandThreadContext commandThreadContext, WorkerThreadContext workerThreadContext) => default; // 0x00000001818264A0-0x0000000181826590
	// [XID] // 0x000000018960B0A0-0x000000018960B0C0
	protected override WorkerThreadSpatialFunctionalities CreateWorkerThreadFunctionalities(WorkerThreadContext workerThreadContext, SharedSpatialFunctionalities shared) => default; // 0x00000001818263C0-0x00000001818264A0
}

