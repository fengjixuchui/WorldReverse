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
	public sealed class DecoratorLoopUntil : DecoratorCount // TypeDefIndex: 27527
	{
		// Fields
		private bool m_until; // 0x70
	
		// Nested types
		private class DecoratorLoopUntilTask : DecoratorCount.DecoratorCountTask // TypeDefIndex: 27528
		{
			// Constructors
			public DecoratorLoopUntilTask() {} // 0x0000000186D86840-0x0000000186D868A0
	
			// Methods
			public override void copyto(BehaviorTask target) {} // 0x0000000186D868A0-0x0000000186D86920
			public override void save(ISerializableNode node) {} // 0x0000000186D86AA0-0x0000000186D86B20
			public override void load(ISerializableNode node) {} // 0x0000000186D869F0-0x0000000186D86AA0
			protected override EBTStatus decorate(EBTStatus status) => default; // 0x0000000186D86920-0x0000000186D869F0
		}
	
		// Constructors
		public DecoratorLoopUntil() {} // 0x0000000186D86B20-0x0000000186D86B90
	
		// Methods
		protected override void load(int version, string agentType, List<property_t> properties) {} // 0x0000000186D86C40-0x0000000186D86DF0
		protected override BehaviorTask createTask() => default; // 0x0000000186D86B90-0x0000000186D86C40
	}
}
