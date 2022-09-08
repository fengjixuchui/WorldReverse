/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace MoleMole
{
	public class AsyncExecutorQueue // TypeDefIndex: 7428
	{
		// Fields
		private LockFreeQueue _jobQueue; // 0x10
	
		// Constructors
		public AsyncExecutorQueue() {} // 0x00000001868EC170-0x00000001868EC200
	
		// Methods
		// [XID] // 0x00000001896E6080-0x00000001896E60A0
		public void QueueJob(IAsyncExecutor inJob) {} // 0x00000001868EC0A0-0x00000001868EC170
		// [XID] // 0x0000000189A5CA00-0x0000000189A5CA20
		public bool ExecuteNext() => default; // 0x00000001868EBFA0-0x00000001868EC0A0
		// [XID] // 0x00000001896F4F00-0x00000001896F4F20
		public void ExecuteAll(int maxExecuteCount = 100 /* Metadata: 0x00ADE9BC */) {} // 0x00000001868EBEC0-0x00000001868EBFA0
	}
}
