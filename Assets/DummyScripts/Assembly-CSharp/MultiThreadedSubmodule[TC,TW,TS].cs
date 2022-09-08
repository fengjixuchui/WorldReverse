/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public abstract class MultiThreadedSubmodule<TC, TW, TS> : Submodule // TypeDefIndex: 11326
	where TC : CommandThreadFunctionalities<TS>
	where TW : WorkerThreadFunctionalities<TS>
	where TS : SharedFunctionalities
{
	// Fields
	private readonly TC _commandThread;
	private readonly TW _workerThread;

	// Properties
	public TC commandThread { get; }
	public TW workerThread { get; }

	// Constructors
	protected MultiThreadedSubmodule() {} // Dummy constructor
	public MultiThreadedSubmodule(SharedContext sharedContext, CommandThreadContext commandThreadContext, WorkerThreadContext workerThreadContext) {}

	// Methods
	public override void CommandInit() {}
	public override void CommandTick(float deltaTime) {}
	public override void CommandEnterHomeWorld(bool firstTime) {}
	public override void CommandExitHomeWorld() {}
	public override void CommandExitGameWorld() {}
	public override void CommandCreateLevel() {}
	public override void CommandEnterLevel() {}
	public override void CommandExitLevel() {}
	public override void CommandDestroy() {}
	public void WorkerInit() {}
	public void WorkerTick(TimeSpan deltaTime) {}
	public void WorkerDestroy() {}
	protected abstract TS CreateSharedFunctionalities(SharedContext sharedContext, CommandThreadContext commandThreadContext, WorkerThreadContext workerThreadContext);
	protected abstract TC CreateCommandThreadFunctionalities(CommandThreadContext commandThreadContext, TS shared);
	protected abstract TW CreateWorkerThreadFunctionalities(WorkerThreadContext workerThreadContext, TS shared);
}

