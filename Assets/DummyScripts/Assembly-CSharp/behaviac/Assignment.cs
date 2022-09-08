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
	public class Assignment : BehaviorNode // TypeDefIndex: 27456
	{
		// Fields
		protected IInstanceMember m_opl; // 0x60
		protected IInstanceMember m_opr; // 0x68
		protected bool m_bCast; // 0x70
	
		// Nested types
		private class AssignmentTask : LeafTask // TypeDefIndex: 27457
		{
			// Constructors
			public AssignmentTask() {} // 0x00000001860A52E0-0x00000001860A5340
	
			// Methods
			public override void copyto(BehaviorTask target) {} // 0x00000001860A5340-0x00000001860A53C0
			public override void save(ISerializableNode node) {} // 0x00000001860A54F0-0x00000001860A5580
			public override void load(ISerializableNode node) {} // 0x00000001860A53C0-0x00000001860A5450
			protected override bool onenter(Agent pAgent) => default; // 0x00000001860A5450-0x00000001860A54A0
			protected override void onexit(Agent pAgent, EBTStatus s) {} // 0x00000001860A54A0-0x00000001860A54F0
			protected override EBTStatus update(Agent pAgent, EBTStatus childStatus) => default; // 0x00000001860A5580-0x00000001860A5700
		}
	
		// Constructors
		public Assignment() {} // 0x00000001860A5830-0x00000001860A58E0
	
		// Methods
		protected override void load(int version, string agentType, List<property_t> properties) {} // 0x00000001860A8DA0-0x00000001860A9040
		public override bool IsValid(Agent pAgent, BehaviorTask pTask) => default; // 0x00000001860A5700-0x00000001860A5830
		protected override BehaviorTask createTask() => default; // 0x00000001860A8CF0-0x00000001860A8DA0
	}
}
