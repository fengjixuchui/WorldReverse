/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using miHoYoThread;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public static class TaskConfigFactory // TypeDefIndex: 26651
{
	// Methods
	public static TaskType CreateTask<TaskType, TaskDataType>(TaskDataType data = default)
		where TaskType : ThreadTask<TaskDataType>, new()
		where TaskDataType : ITaskData, new() => default;
	public static TaskGroup<GroupNodeType> CreateTaskGroup<GroupNodeType>()
		where GroupNodeType : IGroupNode, new() => default;
}

