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
	public sealed class DecoratorAlwaysFailure : DecoratorNode // TypeDefIndex: 27508
	{
		// Nested types
		private class DecoratorAlwaysFailureTask : DecoratorTask // TypeDefIndex: 27509
		{
			// Constructors
			public DecoratorAlwaysFailureTask() {} // 0x0000000186D82DF0-0x0000000186D82E90
	
			// Methods
			public override void copyto(BehaviorTask target) {} // 0x0000000186D82E90-0x0000000186D82F10
			public override void save(ISerializableNode node) {} // 0x0000000186D82FE0-0x0000000186D83060
			public override void load(ISerializableNode node) {} // 0x0000000186D82F60-0x0000000186D82FE0
			protected override EBTStatus decorate(EBTStatus status) => default; // 0x0000000186D82F10-0x0000000186D82F60
		}
	
		// Constructors
		public DecoratorAlwaysFailure() {} // 0x0000000186D83120-0x0000000186D831C0
	
		// Methods
		protected override void load(int version, string agentType, List<property_t> properties) {} // 0x0000000186D83230-0x0000000186D832C0
		public override bool IsValid(Agent pAgent, BehaviorTask pTask) => default; // 0x0000000186D83060-0x0000000186D83120
		protected override BehaviorTask createTask() => default; // 0x0000000186D831C0-0x0000000186D83230
	}
}
