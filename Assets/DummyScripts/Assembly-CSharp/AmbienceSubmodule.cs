/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class AmbienceSubmodule : MultiThreadedSubmodule<CommandThreadAmbienceFunctionalities, WorkerThreadAmbienceFunctionalities, SharedAmbienceFunctionalities> // TypeDefIndex: 11225
{
	// Constructors
	public AmbienceSubmodule() {} // Dummy constructor
	public AmbienceSubmodule(SharedContext sharedContext, CommandThreadContext commandThreadContext, WorkerThreadContext workerThreadContext) {} // 0x0000000180E50500-0x0000000180E50590

	// Methods
	// [XID] // 0x000000018967FCF0-0x000000018967FD10
	protected override SharedAmbienceFunctionalities CreateSharedFunctionalities(SharedContext sharedContext, CommandThreadContext commandThreadContext, WorkerThreadContext workerThreadContext) => default; // 0x0000000180E50410-0x0000000180E50500
	// [XID] // 0x0000000189687340-0x0000000189687360
	protected override CommandThreadAmbienceFunctionalities CreateCommandThreadFunctionalities(CommandThreadContext commandThreadContext, SharedAmbienceFunctionalities shared) => default; // 0x0000000180E50250-0x0000000180E50330
	// [XID] // 0x00000001899D3BD0-0x00000001899D3BF0
	protected override WorkerThreadAmbienceFunctionalities CreateWorkerThreadFunctionalities(WorkerThreadContext workerThreadContext, SharedAmbienceFunctionalities shared) => default; // 0x0000000180E50330-0x0000000180E50410
}

