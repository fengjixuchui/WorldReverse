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
	public class ThreadGroupTask<TargetTaskDataType> : IGroupTask // TypeDefIndex: 9106
		where TargetTaskDataType : ITaskData, new()
	{
		// Fields
		private const string INVALID_TASK_NAME = "InvalidTask"; // Metadata: 0x00AE527F
		protected TargetTaskDataType[] _datas;
		private int _taskId;
		private int _taskGroupId;
		protected INode _node;
		private bool _isValid;
		protected bool _isDestroied;
		protected List<int> _injectDatas;
	
		// Properties
		public virtual string taskName { get => default; }
		public int taskId { get => default; }
		public int taskGroupId { get => default; }
		public INode node { get => default; }
		public virtual bool isValid { get => default; }
		public virtual bool isDestroied { get => default; }
		public bool forceMainThread { get => default; }
		public int numSuccessors { get => default; }
		public int numDependents { get => default; }
	
		// Constructors
		public ThreadGroupTask() {}
	
		// Methods
		public virtual void UpdateValid(bool value) {}
		public virtual void Init(int taskId, IGraph graph, IRunnerPool runnerPool, int groupId) {}
		public void InitData(TargetTaskDataType[] datas) {}
		public ITask Precede(ITask task) => default;
		public ITask Precede(IGroup group) => default;
		public ITask Precede(List<ITask> tasks) => default;
		private void PrecedeInternal(ITask task) {}
		public ITask Gather(ITask task) => default;
		public ITask Gather(List<ITask> tasks) => default;
		private void GatherInternal(ITask task) {}
		public void Collect() {}
		protected virtual void PreCollect() {}
		protected virtual void CollectInternal(int index) {}
		public void Execute() {}
		protected virtual void PreExecute() {}
		protected virtual void ExecuteInternal(int index) {}
		protected void WriteInnerData(int index, ref TargetTaskDataType data) {}
		public void Flush() {}
		protected virtual void FlushInternal(int index) {}
		public void OnPause() {}
		protected virtual void OnPauseInternal(int index) {}
		public void OnResume() {}
		protected virtual void OnResumeInternal(int index) {}
		public void Inject(int index, int dataId) {}
		protected int ReadInjectDataIndex(int index) => default;
		public void BindData(ITaskData data) {}
		public int GetDataHandler() => default;
		public void WriteData() {}
		public virtual void BindTarget(object target) {}
		public void Destroy() {}
		protected virtual void OnDestroy() {}
	}
}
