/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace miHoYoThread
{
	public static class TaskFactory // TypeDefIndex: 9090
	{
		// Fields
		private static int _currGroupId; // 0x00
	
		// Properties
		public static int currGroupId { /* [XID] */ /* 0x000000018972D6B0-0x000000018972D6D0 */ get; } // 0x000000018763E450-0x000000018763E520 
	
		// Constructors
		static TaskFactory() {} // 0x000000018763E3F0-0x000000018763E450
	
		// Methods
		public static TaskType CreateTask<TaskType, TaskDataType>(IGraph graph, IRunnerPool runnerPool, TaskDataType data = default)
			where TaskType : ThreadTask<TaskDataType>, new()
			where TaskDataType : ITaskData, new() => default;
		public static TaskType CreateTask<TaskType, TaskDataType>(SchedulerType schedulerType, TaskDataType data = default, int groupId = 0 /* Metadata: 0x00AE5237 */)
			where TaskType : ThreadTask<TaskDataType>, new()
			where TaskDataType : ITaskData, new() => default;
		public static TaskType CreateGlobalTask<TaskType, TaskDataType>(SchedulerGlobalType schedulerType, TaskDataType data = default)
			where TaskType : ThreadTask<TaskDataType>, new()
			where TaskDataType : ITaskData, new() => default;
		public static TaskType CreateGlobalBackgroundTask<TaskType, TaskDataType>(SchedulerBackgroundType schedulerType, TaskDataType data = default)
			where TaskType : ThreadTask<TaskDataType>, new()
			where TaskDataType : ITaskData, new() => default;
		// [XID] // 0x0000000189734E30-0x0000000189734E50
		public static void DestroyTask(ITask task) {} // 0x000000018763E2F0-0x000000018763E3F0
		public static GraphType CreateGraph<GraphType>()
			where GraphType : IGraph, new() => default;
		public static TaskMgrType CreateTaskMgr<TaskMgrType>(int threadNum)
			where TaskMgrType : ITaskMgr, new() => default;
		public static TaskDataType CreateTaskData<TaskDataType>()
			where TaskDataType : ITaskData => default;
		public static TaskDataType CreateTaskRefData<TaskDataType>()
			where TaskDataType : ITaskData, new() => default;
		public static TaskGroup<GroupNodeType> CreateTaskGroup<GroupNodeType>(int maxDataNum, IGraph graph, IRunnerPool runnerPool)
			where GroupNodeType : IGroupNode, new() => default;
		public static TaskGroup<GroupNodeType> CreateTaskGroup<GroupNodeType>(int maxDataNum, SchedulerType schedulerType)
			where GroupNodeType : IGroupNode, new() => default;
		public static GroupNodeType CreateGroupNode<GroupNodeType>(int maxDataNum, IGroup group, IGraph graph, IRunnerPool runnerPool)
			where GroupNodeType : IGroupNode, new() => default;
		public static GroupTaskType CreateGroupTask<GroupTaskType, TargetTaskDataType>(IGraph graph, IRunnerPool runnerPool, TargetTaskDataType[] datas, int groupId = 0 /* Metadata: 0x00AE523B */)
			where GroupTaskType : ThreadGroupTask<TargetTaskDataType>, new()
			where TargetTaskDataType : ITaskData, new() => default;
	}
}
