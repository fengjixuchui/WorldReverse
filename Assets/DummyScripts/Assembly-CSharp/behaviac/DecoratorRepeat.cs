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
	public sealed class DecoratorRepeat : DecoratorCount // TypeDefIndex: 27531
	{
		// Nested types
		private class DecoratorRepeatTask : DecoratorCount.DecoratorCountTask // TypeDefIndex: 27532
		{
			// Constructors
			public DecoratorRepeatTask() {} // 0x0000000186D89430-0x0000000186D89490
	
			// Methods
			public override void copyto(BehaviorTask target) {} // 0x0000000186D89490-0x0000000186D89510
			public override void save(ISerializableNode node) {} // 0x0000000186D89610-0x0000000186D89690
			public override void load(ISerializableNode node) {} // 0x0000000186D89560-0x0000000186D89610
			protected override EBTStatus decorate(EBTStatus status) => default; // 0x0000000186D89510-0x0000000186D89560
			protected override EBTStatus update(Agent pAgent, EBTStatus childStatus) => default; // 0x0000000186D89690-0x0000000186D897F0
		}
	
		// Constructors
		public DecoratorRepeat() {} // 0x0000000186D89930-0x0000000186D89990
	
		// Methods
		protected override void load(int version, string agentType, List<property_t> properties) {} // 0x0000000186D89A40-0x0000000186D89AD0
		public int Count(Agent pAgent) => default; // 0x0000000186D897F0-0x0000000186D89870
		public override bool IsValid(Agent pAgent, BehaviorTask pTask) => default; // 0x0000000186D89870-0x0000000186D89930
		protected override BehaviorTask createTask() => default; // 0x0000000186D89990-0x0000000186D89A40
	}
}
