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
	public sealed class DecoratorSuccessUntil : DecoratorCount // TypeDefIndex: 27533
	{
		// Nested types
		private class DecoratorSuccessUntilTask : DecoratorCount.DecoratorCountTask // TypeDefIndex: 27534
		{
			// Constructors
			public DecoratorSuccessUntilTask() {} // 0x0000000186D89AD0-0x0000000186D89B30
	
			// Methods
			public override void copyto(BehaviorTask target) {} // 0x0000000186D89B30-0x0000000186D89BB0
			public override void save(ISerializableNode node) {} // 0x0000000186D89DC0-0x0000000186D89E40
			public override void load(ISerializableNode node) {} // 0x0000000186D89C20-0x0000000186D89CD0
			public override void onreset(Agent pAgent) {} // 0x0000000186D89D60-0x0000000186D89DC0
			protected override bool onenter(Agent pAgent) => default; // 0x0000000186D89CD0-0x0000000186D89D60
			protected override EBTStatus decorate(EBTStatus status) => default; // 0x0000000186D89BB0-0x0000000186D89C20
		}
	
		// Constructors
		public DecoratorSuccessUntil() {} // 0x0000000186D89F00-0x0000000186D89F60
	
		// Methods
		protected override void load(int version, string agentType, List<property_t> properties) {} // 0x0000000186D8A010-0x0000000186D8A0A0
		public override bool IsValid(Agent pAgent, BehaviorTask pTask) => default; // 0x0000000186D89E40-0x0000000186D89F00
		protected override BehaviorTask createTask() => default; // 0x0000000186D89F60-0x0000000186D8A010
	}
}
