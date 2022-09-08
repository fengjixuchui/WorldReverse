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
	public class Compute : BehaviorNode // TypeDefIndex: 27458
	{
		// Fields
		protected IInstanceMember m_opl; // 0x60
		protected IInstanceMember m_opr1; // 0x68
		protected IInstanceMember m_opr2; // 0x70
		protected EOperatorType m_operator; // 0x78
	
		// Nested types
		private class ComputeTask : LeafTask // TypeDefIndex: 27459
		{
			// Constructors
			public ComputeTask() {} // 0x0000000186D73BD0-0x0000000186D73C30
	
			// Methods
			public override void copyto(BehaviorTask target) {} // 0x0000000186D73C30-0x0000000186D73CB0
			public override void save(ISerializableNode node) {} // 0x0000000186D73DD0-0x0000000186D73E50
			public override void load(ISerializableNode node) {} // 0x0000000186D73CB0-0x0000000186D73D30
			protected override bool onenter(Agent pAgent) => default; // 0x0000000186D73D30-0x0000000186D73D80
			protected override void onexit(Agent pAgent, EBTStatus s) {} // 0x0000000186D73D80-0x0000000186D73DD0
			protected override EBTStatus update(Agent pAgent, EBTStatus childStatus) => default; // 0x0000000186D73E50-0x0000000186D73FA0
		}
	
		// Constructors
		public Compute() {} // 0x0000000186D75570-0x0000000186D755E0
	
		// Methods
		protected override void load(int version, string agentType, List<property_t> properties) {} // 0x0000000186D76810-0x0000000186D76B50
		public override bool IsValid(Agent pAgent, BehaviorTask pTask) => default; // 0x0000000186D75480-0x0000000186D75570
		protected override BehaviorTask createTask() => default; // 0x0000000186D76760-0x0000000186D76810
	}
}
