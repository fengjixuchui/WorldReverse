/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class MusicSubmodule : MultiThreadedSubmodule<CommandThreadMusicFunctionalities, WorkerThreadMusicFunctionalities, SharedMusicFunctionalities> // TypeDefIndex: 11385
{
	// Constructors
	public MusicSubmodule() {} // Dummy constructor
	public MusicSubmodule(SharedContext sharedContext, CommandThreadContext commandThreadContext, WorkerThreadContext workerThreadContext) {} // 0x00000001843C27C0-0x00000001843C2850

	// Methods
	// [XID] // 0x000000018988C760-0x000000018988C780
	protected override SharedMusicFunctionalities CreateSharedFunctionalities(SharedContext sharedContext, CommandThreadContext commandThreadContext, WorkerThreadContext workerThreadContext) => default; // 0x00000001843C26D0-0x00000001843C27C0
	// [XID] // 0x0000000189893CB0-0x0000000189893CD0
	protected override CommandThreadMusicFunctionalities CreateCommandThreadFunctionalities(CommandThreadContext commandThreadContext, SharedMusicFunctionalities shared) => default; // 0x00000001843C2510-0x00000001843C25F0
	// [XID] // 0x000000018989B3F0-0x000000018989B410
	protected override WorkerThreadMusicFunctionalities CreateWorkerThreadFunctionalities(WorkerThreadContext workerThreadContext, SharedMusicFunctionalities shared) => default; // 0x00000001843C25F0-0x00000001843C26D0
}

