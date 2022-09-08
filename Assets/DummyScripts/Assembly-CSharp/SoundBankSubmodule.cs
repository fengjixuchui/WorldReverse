/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class SoundBankSubmodule : MultiThreadedSubmodule<CommandThreadSoundBankFunctionalities, WorkerThreadSoundBankFunctionalities, SharedSoundBankFunctionalities> // TypeDefIndex: 11406
{
	// Constructors
	public SoundBankSubmodule() {} // Dummy constructor
	public SoundBankSubmodule(SharedContext sharedContext, CommandThreadContext commandThreadContext, WorkerThreadContext workerThreadContext) {} // 0x000000018346DA30-0x000000018346DAC0

	// Methods
	// [XID] // 0x0000000189B1FF10-0x0000000189B1FF30
	protected override SharedSoundBankFunctionalities CreateSharedFunctionalities(SharedContext sharedContext, CommandThreadContext commandThreadContext, WorkerThreadContext workerThreadContext) => default; // 0x000000018346D940-0x000000018346DA30
	// [XID] // 0x0000000189B27640-0x0000000189B27660
	protected override CommandThreadSoundBankFunctionalities CreateCommandThreadFunctionalities(CommandThreadContext commandThreadContext, SharedSoundBankFunctionalities shared) => default; // 0x000000018346D780-0x000000018346D860
	// [XID] // 0x0000000189B2E8C0-0x0000000189B2E8E0
	protected override WorkerThreadSoundBankFunctionalities CreateWorkerThreadFunctionalities(WorkerThreadContext workerThreadContext, SharedSoundBankFunctionalities shared) => default; // 0x000000018346D860-0x000000018346D940
}

