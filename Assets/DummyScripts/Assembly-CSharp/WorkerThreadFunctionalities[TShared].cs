/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public abstract class WorkerThreadFunctionalities<TShared> // TypeDefIndex: 11467
	where TShared : SharedFunctionalities
{
	// Fields
	private readonly TShared _shared;
	private readonly WorkerThreadContext _context;

	// Properties
	protected WorkerThreadContext context { get; }
	protected TShared shared { get; }

	// Constructors
	protected WorkerThreadFunctionalities() {} // Dummy constructor
	public WorkerThreadFunctionalities(WorkerThreadContext context, TShared shared) {}

	// Methods
	public abstract void Init();
	public abstract void Tick(TimeSpan deltaTime);
	public abstract void Destroy();
}

