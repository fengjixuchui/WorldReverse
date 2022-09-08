/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace behaviac
{
	public sealed class BehaviorTreeTask : SingeChildTask // TypeDefIndex: 27453
	{
		// Fields
		private Dictionary<uint, IInstantiatedVariable> m_localVars; // 0x40
		private BehaviorTreeTask m_excutingTreeTask; // 0x48
		private EBTStatus m_endStatus; // 0x50
		private List<BehaviorTask> m_states; // 0x58
	
		// Properties
		public Dictionary<uint, IInstantiatedVariable> LocalVars { get => default; } // 0x00000001860B4830-0x00000001860B4890 
	
		// Constructors
		public BehaviorTreeTask() {} // 0x00000001860B46B0-0x00000001860B4750
	
		// Methods
		internal void SetVariable<VariableType>(string variableName, VariableType value) {}
		internal void AddVariables(Dictionary<uint, IInstantiatedVariable> vars) {} // 0x00000001860B3F70-0x00000001860B4100
		public override void Init(BehaviorNode node) {} // 0x00000001860B4450-0x00000001860B4560
		public override void Clear() {} // 0x00000001860B4100-0x00000001860B4210
		public void SetRootTask(BehaviorTask pRoot) {} // 0x00000001860B4630-0x00000001860B46B0
		public void CopyTo(BehaviorTreeTask target) {} // 0x00000001860B4210-0x00000001860B4290
		public void Save(ISerializableNode node) {} // 0x00000001860B45E0-0x00000001860B4630
		public void Load(ISerializableNode node) {} // 0x00000001860B4560-0x00000001860B45E0
		public string GetName() => default; // 0x00000001860B4390-0x00000001860B4450
		public void setEndStatus(EBTStatus status) {} // 0x00000001860B4A80-0x00000001860B4AE0
		public EBTStatus resume(Agent pAgent, EBTStatus status) => default; // 0x00000001860B49F0-0x00000001860B4A80
		protected override bool onenter(Agent pAgent) => default; // 0x00000001860B4890-0x00000001860B4920
		protected override void onexit(Agent pAgent, EBTStatus s) {} // 0x00000001860B4920-0x00000001860B49F0
		public BehaviorTask GetChildById(int nodeId) => default; // 0x00000001860B4290-0x00000001860B4390
		protected override EBTStatus update_current(Agent pAgent, EBTStatus childStatus) => default; // 0x00000001860B4AE0-0x00000001860B4C20
		private void end(Agent pAgent, EBTStatus status) {} // 0x00000001860B4750-0x00000001860B4830
		protected override EBTStatus update(Agent pAgent, EBTStatus childStatus) => default; // 0x00000001860B4C20-0x00000001860B4CD0
	}
}
