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
	public class TaskGroup<GroupNodeType> : IGroup // TypeDefIndex: 9015
		where GroupNodeType : IGroupNode, new()
	{
		// Fields
		private int _groupId;
		private List<IGroupNode> _groupNodes;
		private bool _dirty;
		private int _maxDataNum;
		private IGraph _graph;
		private IRunnerPool _runnerPool;
		private List<INode> _nodes;
	
		// Properties
		public int groupId { get => default; }
	
		// Constructors
		public TaskGroup() {}
	
		// Methods
		public void Init(int id, int maxDataNum, IGraph graph, IRunnerPool runnerPool) {}
		public void Init(int id, int maxDataNum, IGraph graph, IRunnerPool runnerPool, GroupNodeType node) {}
		public IGroupNode GetValidNode() => default;
		public IGroupNode GetNodeByIndex(int index) => default;
		public List<INode> GetNodes() => default;
		public void SwitchRunnerPool(IRunnerPool runnerPool) {}
		public bool Balence() => default;
		public void Precede(INode node) {}
		public void Precede(IGroup group) {}
		public void Destroy() {}
	}
}
