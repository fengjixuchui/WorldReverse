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
	public class AttachAction : BehaviorNode // TypeDefIndex: 27428
	{
		// Fields
		protected ActionConfig m_ActionConfig; // 0x60
	
		// Nested types
		public class ActionConfig // TypeDefIndex: 27429
		{
			// Fields
			protected IInstanceMember m_opl; // 0x10
			protected IInstanceMember m_opr1; // 0x18
			protected IInstanceMember m_opr2; // 0x20
			public EOperatorType m_operator; // 0x28
	
			// Constructors
			protected ActionConfig() {} // 0x000000018609E900-0x000000018609E970
	
			// Methods
			public virtual bool load(List<property_t> properties) => default; // 0x000000018609E970-0x000000018609ED20
			public bool Execute(Agent pAgent) => default; // 0x000000018609E790-0x000000018609E900
		}
	
		// Constructors
		public AttachAction() {} // 0x00000001860A91C0-0x00000001860A9270
	
		// Methods
		protected override void load(int version, string agentType, List<property_t> properties) {} // 0x00000001860A92C0-0x00000001860A9370
		public override bool Evaluate(Agent pAgent) => default; // 0x00000001860A9040-0x00000001860A9100
		public virtual bool Evaluate(Agent pAgent, EBTStatus status) => default; // 0x00000001860A9100-0x00000001860A91C0
		protected override BehaviorTask createTask() => default; // 0x00000001860A9270-0x00000001860A92C0
	}
}
