/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using MoleMole;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class InterSystem<TaskType> : IInterSystem // TypeDefIndex: 20851
	where TaskType : BaseInterTask, new()
{
	// Fields
	protected static SimpleObjectPool<TaskType> _pool;
	protected List<TaskType> _tasks;

	// Constructors
	public InterSystem() {}
	static InterSystem() {}

	// Methods
	public virtual void DoAction(BaseInterAction interAction) {}
	public void DoClear() {}
	protected virtual void CheckTask() {}
	public void Tick() {}
	public void OnEvent(BaseEvent evt) {}
	public void ForceFinish() {}
	public virtual void Reset() {}
}

