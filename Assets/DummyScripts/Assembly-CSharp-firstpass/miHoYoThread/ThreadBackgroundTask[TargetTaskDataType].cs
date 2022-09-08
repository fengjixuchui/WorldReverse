/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace miHoYoThread
{
	public class ThreadBackgroundTask<TargetTaskDataType> : ThreadTask<TargetTaskDataType> // TypeDefIndex: 9110
		where TargetTaskDataType : ITaskData, new()
	{
		// Constructors
		public ThreadBackgroundTask() {}
	
		// Methods
		public override void Init(int taskId, IGraph graph, IRunnerPool runnerPool, int groupId = 0 /* Metadata: 0x00AE52A9 */) {}
	}
}
