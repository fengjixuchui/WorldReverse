/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class QuestSubmodule : MultiThreadedSubmodule<CommandThreadQuestFunctionalities, WorkerThreadQuestFunctionalities, SharedQuestFunctionalities> // TypeDefIndex: 11396
{
	// Constructors
	public QuestSubmodule() {} // Dummy constructor
	public QuestSubmodule(SharedContext sharedContext, CommandThreadContext commandThreadContext, WorkerThreadContext workerThreadContext) {} // 0x000000018351F190-0x000000018351F220

	// Methods
	// [XID] // 0x00000001899F31A0-0x00000001899F31C0
	protected override SharedQuestFunctionalities CreateSharedFunctionalities(SharedContext sharedContext, CommandThreadContext commandThreadContext, WorkerThreadContext workerThreadContext) => default; // 0x000000018351F0A0-0x000000018351F190
	// [XID] // 0x00000001899002F0-0x0000000189900310
	protected override CommandThreadQuestFunctionalities CreateCommandThreadFunctionalities(CommandThreadContext commandThreadContext, SharedQuestFunctionalities shared) => default; // 0x000000018351EEE0-0x000000018351EFC0
	// [XID] // 0x00000001899079B0-0x00000001899079D0
	protected override WorkerThreadQuestFunctionalities CreateWorkerThreadFunctionalities(WorkerThreadContext workerThreadContext, SharedQuestFunctionalities shared) => default; // 0x000000018351EFC0-0x000000018351F0A0
}

