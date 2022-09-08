/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public abstract class DataThreadListener<TaskData, Task> : IThreadListener // TypeDefIndex: 21340
	where Task : DataThreadTask<TaskData>
{
	// Fields
	protected IThreadTask _task;
	protected Task _dataTask;
	protected bool _alive;

	// Properties
	public bool Alive { get; }

	// Constructors
	protected DataThreadListener() {}

	// Methods
	public IThreadTask GetTask() => default;
	public Task GetDataTask() => default;
	public virtual void Init(IThreadTask task) {}
	public abstract void RenderTick(int renderFront, float renderTime);
	public void Destroy(bool includeTask) {}
}

