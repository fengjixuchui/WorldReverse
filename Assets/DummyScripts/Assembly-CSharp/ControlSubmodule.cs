/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ControlSubmodule : MultiThreadedSubmodule<CommandThreadControlFunctionalities, WorkerThreadControlFunctionalities, SharedControlFunctionalities> // TypeDefIndex: 11266
{
	// Constructors
	public ControlSubmodule() {} // Dummy constructor
	public ControlSubmodule(SharedContext sharedContext, CommandThreadContext commandThreadContext, WorkerThreadContext workerThreadContext) {} // 0x0000000182FC3E50-0x0000000182FC3EE0

	// Methods
	// [XID] // 0x0000000189A181F0-0x0000000189A18210
	protected override SharedControlFunctionalities CreateSharedFunctionalities(SharedContext sharedContext, CommandThreadContext commandThreadContext, WorkerThreadContext workerThreadContext) => default; // 0x0000000182FC3D60-0x0000000182FC3E50
	// [XID] // 0x000000018991F690-0x000000018991F6B0
	protected override CommandThreadControlFunctionalities CreateCommandThreadFunctionalities(CommandThreadContext commandThreadContext, SharedControlFunctionalities shared) => default; // 0x0000000182FC3BA0-0x0000000182FC3C80
	// [XID] // 0x0000000189927160-0x0000000189927180
	protected override WorkerThreadControlFunctionalities CreateWorkerThreadFunctionalities(WorkerThreadContext workerThreadContext, SharedControlFunctionalities shared) => default; // 0x0000000182FC3C80-0x0000000182FC3D60
}

