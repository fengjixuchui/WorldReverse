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
	public interface INode : IDestroy // TypeDefIndex: 9003
	{
		// Properties
		int nodeId { get; }
		int nodeGroupId { get; }
		int nodeType { get; }
		bool isValid { get; }
		int jobHandler { get; }
		ITask task { get; }
		IGraph graph { get; }
		bool forceMainThread { get; }
		int numSuccessors { get; }
		int numDependents { get; }
		int numRunningDependents { get; }
		string profilerName { get; }
	
		// Methods
		bool CheckValid();
		void SetToBeRemove();
		bool isToBeRemove();
		void BatchDependents();
		bool OnDecrementRunningDependent(int jobHandler);
		void CheckRunnableSuccessors();
		void AddDependents(INode node);
		void Precede(INode node);
		void Precede(IGroup node);
		bool IsExecuted();
		void Execute();
		void Reset();
		bool IsSpawned();
		void Spawn();
		void SpawnBatch();
		void StartNodeOnFreeRunner();
		void StartNodeOnMainThreadRunner();
		void SwitchRunnerPool(IRunnerPool runnerPool);
		void Collect();
		void Flush();
		void OnPause();
		void OnResume();
		void SetNodeGeneration(INodeGeneration nodeGen);
	}
}
