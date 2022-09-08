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
	public interface IGraph : IDestroy // TypeDefIndex: 8999
	{
		// Properties
		int priority { get; }
		int schedulerType { get; }
	
		// Methods
		void SetPriority(int priority);
		void SetSchedulerType(int stype);
		void Collect();
		void Start();
		void StartMainThreadTask();
		void Flush();
		void SetDirty();
		void AddNode(INode node);
		void RemoveNode(INode node);
		void AddGroup(IGroup group);
		void RemoveGroup(IGroup group);
		void SwitchRunnerPool(IRunnerPool runnerPool);
		void SwitchMultiThread(bool isMultiThread);
		bool IsFinished();
		void OnPause();
		void OnResume();
	}
}
