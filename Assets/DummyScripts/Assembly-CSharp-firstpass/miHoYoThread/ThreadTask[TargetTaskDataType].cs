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
	public class ThreadTask<TargetTaskDataType> : ITask // TypeDefIndex: 9109
		where TargetTaskDataType : ITaskData, new()
	{
		// Fields
		private const string INVALID_TASK_NAME = "InvalidTask"; // Metadata: 0x00AE529A
		protected int _taskId;
		protected int _taskGroupId;
		protected INode _node;
		protected bool _isDestroied;
		protected int _dataType;
		private bool _forceMainThread;
		protected TargetTaskDataType _taskData;
		protected int _taskDataHandler;
		protected List<int> _injectDatas;
	
		// Properties
		public virtual string taskName { get => default; }
		public int taskId { get => default; }
		public int taskGroupId { get => default; }
		public INode node { get => default; }
		public virtual bool isValid { get => default; }
		public virtual bool isDestroied { get => default; }
		public int dataType { get => default; }
		public virtual bool forceMainThread { get => default; }
		public int numSuccessors { get => default; }
		public int numDependents { get => default; }
	
		// Constructors
		public ThreadTask() {}
	
		// Methods
		public virtual void Init(int taskId, IGraph graph, IRunnerPool runnerPool, int groupId = 0 /* Metadata: 0x00AE5296 */) {}
		protected virtual void InitInternal() {}
		public ITask Precede(ITask task) => default;
		public ITask Precede(IGroup group) => default;
		public ITask Precede(List<ITask> tasks) => default;
		private void PrecedeInternal(ITask task) {}
		public ITask Gather(ITask task) => default;
		public ITask Gather(List<ITask> tasks) => default;
		private void GatherInternal(ITask task) {}
		public virtual void Collect() {}
		public virtual void Execute() {}
		public virtual void Flush() {}
		public virtual void OnPause() {}
		public virtual void OnResume() {}
		public void Inject(int index, int dataId) {}
		protected int ReadInjectDataIndex(int index) => default;
		public void BindData(ITaskData data) {}
		public int GetDataHandler() => default;
		public void WriteData() {}
		public virtual void BindTarget(object target) {}
		public virtual void Destroy() {}
		protected virtual void OnDestroy() {}
	}
}
