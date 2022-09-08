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
	public sealed class DecoratorFailureUntil : DecoratorCount // TypeDefIndex: 27518
	{
		// Nested types
		private class DecoratorFailureUntilTask : DecoratorCount.DecoratorCountTask // TypeDefIndex: 27519
		{
			// Constructors
			public DecoratorFailureUntilTask() {} // 0x0000000186D84AC0-0x0000000186D84B20
	
			// Methods
			public override void copyto(BehaviorTask target) {} // 0x0000000186D84B20-0x0000000186D84BA0
			public override void save(ISerializableNode node) {} // 0x0000000186D84DB0-0x0000000186D84E30
			public override void load(ISerializableNode node) {} // 0x0000000186D84C10-0x0000000186D84CC0
			public override void onreset(Agent pAgent) {} // 0x0000000186D84D50-0x0000000186D84DB0
			protected override bool onenter(Agent pAgent) => default; // 0x0000000186D84CC0-0x0000000186D84D50
			protected override EBTStatus decorate(EBTStatus status) => default; // 0x0000000186D84BA0-0x0000000186D84C10
		}
	
		// Constructors
		public DecoratorFailureUntil() {} // 0x0000000186D84EF0-0x0000000186D84F50
	
		// Methods
		protected override void load(int version, string agentType, List<property_t> properties) {} // 0x0000000186D85000-0x0000000186D85090
		public override bool IsValid(Agent pAgent, BehaviorTask pTask) => default; // 0x0000000186D84E30-0x0000000186D84EF0
		protected override BehaviorTask createTask() => default; // 0x0000000186D84F50-0x0000000186D85000
	}
}
