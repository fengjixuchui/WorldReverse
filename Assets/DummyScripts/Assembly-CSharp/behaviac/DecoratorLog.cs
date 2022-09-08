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
	public sealed class DecoratorLog : DecoratorNode // TypeDefIndex: 27523
	{
		// Fields
		private string m_message; // 0x68
	
		// Nested types
		private class DecoratorLogTask : DecoratorTask // TypeDefIndex: 27524
		{
			// Constructors
			public DecoratorLogTask() {} // 0x0000000186D85E90-0x0000000186D85F30
	
			// Methods
			public override void copyto(BehaviorTask target) {} // 0x0000000186D85F30-0x0000000186D85FB0
			public override void save(ISerializableNode node) {} // 0x0000000186D860C0-0x0000000186D86140
			public override void load(ISerializableNode node) {} // 0x0000000186D86040-0x0000000186D860C0
			protected override EBTStatus decorate(EBTStatus status) => default; // 0x0000000186D85FB0-0x0000000186D86040
		}
	
		// Constructors
		public DecoratorLog() {} // 0x0000000186D86200-0x0000000186D862A0
	
		// Methods
		protected override void load(int version, string agentType, List<property_t> properties) {} // 0x0000000186D86310-0x0000000186D86440
		public override bool IsValid(Agent pAgent, BehaviorTask pTask) => default; // 0x0000000186D86140-0x0000000186D86200
		protected override BehaviorTask createTask() => default; // 0x0000000186D862A0-0x0000000186D86310
	}
}
