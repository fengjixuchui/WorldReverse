/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace miHoYoThread
{
	public interface ITask : IDestroy // TypeDefIndex: 9078
	{
		// Properties
		int taskId { get; }
		int taskGroupId { get; }
		INode node { get; }
		bool isValid { get; }
		bool isDestroied { get; }
		bool forceMainThread { get; }
		int numSuccessors { get; }
		int numDependents { get; }
		string taskName { get; }
	
		// Methods
		ITask Precede(ITask task);
		ITask Precede(IGroup group);
		ITask Precede(List<ITask> tasks);
		ITask Gather(ITask task);
		ITask Gather(List<ITask> tasks);
		void Execute();
		void Collect();
		void Flush();
		void OnPause();
		void OnResume();
		void Inject(int index, int dataId);
		void BindData(ITaskData data);
		int GetDataHandler();
		void WriteData();
		void BindTarget(object target);
	}
}
