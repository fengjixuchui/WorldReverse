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
	public sealed class DecoratorNot : DecoratorNode // TypeDefIndex: 27529
	{
		// Nested types
		private class DecoratorNotTask : DecoratorTask // TypeDefIndex: 27530
		{
			// Constructors
			public DecoratorNotTask() {} // 0x0000000186D88E80-0x0000000186D88F20
	
			// Methods
			public override void copyto(BehaviorTask target) {} // 0x0000000186D88F20-0x0000000186D88FA0
			public override void save(ISerializableNode node) {} // 0x0000000186D890A0-0x0000000186D89120
			public override void load(ISerializableNode node) {} // 0x0000000186D89020-0x0000000186D890A0
			protected override EBTStatus decorate(EBTStatus status) => default; // 0x0000000186D88FA0-0x0000000186D89020
		}
	
		// Constructors
		public DecoratorNot() {} // 0x0000000186D89290-0x0000000186D89330
	
		// Methods
		protected override void load(int version, string agentType, List<property_t> properties) {} // 0x0000000186D893A0-0x0000000186D89430
		public override bool IsValid(Agent pAgent, BehaviorTask pTask) => default; // 0x0000000186D891D0-0x0000000186D89290
		public override bool Evaluate(Agent pAgent) => default; // 0x0000000186D89120-0x0000000186D891D0
		protected override BehaviorTask createTask() => default; // 0x0000000186D89330-0x0000000186D893A0
	}
}
