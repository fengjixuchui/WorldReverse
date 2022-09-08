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
	public class StartCondition : Precondition // TypeDefIndex: 27543
	{
		// Fields
		protected List<Effector.EffectorConfig> m_effectors; // 0x68
		protected int m_targetId; // 0x70
	
		// Properties
		public int TargetStateId { get => default; set {} } // 0x0000000186DF5FE0-0x0000000186DF6040 0x0000000186DF6200-0x0000000186DF6260
	
		// Constructors
		public StartCondition() {} // 0x0000000186DF5EF0-0x0000000186DF5F90
	
		// Methods
		public override void ApplyEffects(Agent pAgent, Effector.EPhase phase) {} // 0x0000000186DF5CB0-0x0000000186DF5DA0
		public override bool IsValid(Agent pAgent, BehaviorTask pTask) => default; // 0x0000000186DF5DA0-0x0000000186DF5E90
		public int TargetNodeId() => default; // 0x0000000186DF5E90-0x0000000186DF5EF0
		protected override BehaviorTask createTask() => default; // 0x0000000186DF5F90-0x0000000186DF5FE0
		protected override void load(int version, string agentType, List<property_t> properties) {} // 0x0000000186DF6040-0x0000000186DF6200
	}
}
