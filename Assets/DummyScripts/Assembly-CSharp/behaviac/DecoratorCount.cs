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
	public abstract class DecoratorCount : DecoratorNode // TypeDefIndex: 27514
	{
		// Fields
		protected IInstanceMember m_count; // 0x68
	
		// Nested types
		protected abstract class DecoratorCountTask : DecoratorTask // TypeDefIndex: 27515
		{
			// Fields
			protected int m_n; // 0x40
	
			// Constructors
			protected DecoratorCountTask() {} // 0x0000000186D844A0-0x0000000186D84540
	
			// Methods
			public override void copyto(BehaviorTask target) {} // 0x0000000186D84540-0x0000000186D84620
			public override void save(ISerializableNode node) {} // 0x0000000186D84730-0x0000000186D84800
			public override void load(ISerializableNode node) {} // 0x0000000186D84620-0x0000000186D846A0
			protected override bool onenter(Agent pAgent) => default; // 0x0000000186D846A0-0x0000000186D84730
			public int GetCount(Agent pAgent) => default; // 0x0000000186D843C0-0x0000000186D844A0
		}
	
		// Constructors
		protected DecoratorCount() {} // 0x0000000186D848C0-0x0000000186D84960
	
		// Methods
		protected override void load(int version, string agentType, List<property_t> properties) {} // 0x0000000186D84960-0x0000000186D84AC0
		protected virtual int GetCount(Agent pAgent) => default; // 0x0000000186D84800-0x0000000186D848C0
	}
}
