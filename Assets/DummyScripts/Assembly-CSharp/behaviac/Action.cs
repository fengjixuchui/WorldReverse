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
	public class Action : BehaviorNode // TypeDefIndex: 27454
	{
		// Fields
		protected IMethod m_method; // 0x60
		protected IMethod m_resultFunctor; // 0x68
		protected EBTStatus m_resultOption; // 0x70
	
		// Nested types
		private class ActionTask : LeafTask // TypeDefIndex: 27455
		{
			// Constructors
			public ActionTask() {} // 0x0000000185A4AA00-0x0000000185A4AA60
	
			// Methods
			public override void copyto(BehaviorTask target) {} // 0x0000000185A4AA60-0x0000000185A4AAE0
			public override void save(ISerializableNode node) {} // 0x0000000185A4AC00-0x0000000185A4AC80
			public override void load(ISerializableNode node) {} // 0x0000000185A4AAE0-0x0000000185A4AB60
			protected override bool onenter(Agent pAgent) => default; // 0x0000000185A4AB60-0x0000000185A4ABB0
			protected override void onexit(Agent pAgent, EBTStatus s) {} // 0x0000000185A4ABB0-0x0000000185A4AC00
			protected override EBTStatus update(Agent pAgent, EBTStatus childStatus) => default; // 0x0000000185A4AC80-0x0000000185A4AD70
		}
	
		// Constructors
		public Action() {} // 0x0000000185A4AFC0-0x0000000185A4B030
	
		// Methods
		protected override void load(int version, string agentType, List<property_t> properties) {} // 0x0000000185A5D570-0x0000000185A5D8B0
		public override bool IsValid(Agent pAgent, BehaviorTask pTask) => default; // 0x0000000185A4AED0-0x0000000185A4AFC0
		public EBTStatus Execute(Agent pAgent, EBTStatus childStatus) => default; // 0x0000000185A4AD70-0x0000000185A4AED0
		protected override BehaviorTask createTask() => default; // 0x0000000185A5D4C0-0x0000000185A5D570
	}
}
