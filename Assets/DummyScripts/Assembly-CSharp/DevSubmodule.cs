/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class DevSubmodule : MultiThreadedSubmodule<CommandThreadDevFunctionalities, WorkerThreadDevFunctionalities, SharedDevFunctionalities> // TypeDefIndex: 11270
{
	// Constructors
	public DevSubmodule() {} // Dummy constructor
	public DevSubmodule(SharedContext sharedContext, CommandThreadContext commandThreadContext, WorkerThreadContext workerThreadContext) {} // 0x0000000184650C50-0x0000000184650CE0

	// Methods
	// [XID] // 0x0000000189A53A50-0x0000000189A53A70
	protected override SharedDevFunctionalities CreateSharedFunctionalities(SharedContext sharedContext, CommandThreadContext commandThreadContext, WorkerThreadContext workerThreadContext) => default; // 0x0000000184650B60-0x0000000184650C50
	// [XID] // 0x0000000189A5B140-0x0000000189A5B160
	protected override CommandThreadDevFunctionalities CreateCommandThreadFunctionalities(CommandThreadContext commandThreadContext, SharedDevFunctionalities shared) => default; // 0x00000001846509A0-0x0000000184650A80
	// [XID] // 0x0000000189A71C50-0x0000000189A71C70
	protected override WorkerThreadDevFunctionalities CreateWorkerThreadFunctionalities(WorkerThreadContext workerThreadContext, SharedDevFunctionalities shared) => default; // 0x0000000184650A80-0x0000000184650B60
}

