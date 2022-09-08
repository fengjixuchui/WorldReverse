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
	public class DecoratorLoop : DecoratorCount // TypeDefIndex: 27525
	{
		// Fields
		protected bool m_bDoneWithinFrame; // 0x70
	
		// Nested types
		private class DecoratorLoopTask : DecoratorCount.DecoratorCountTask // TypeDefIndex: 27526
		{
			// Constructors
			public DecoratorLoopTask() {} // 0x0000000186D86440-0x0000000186D864A0
	
			// Methods
			public override void copyto(BehaviorTask target) {} // 0x0000000186D864A0-0x0000000186D86520
			public override void save(ISerializableNode node) {} // 0x0000000186D86650-0x0000000186D866D0
			public override void load(ISerializableNode node) {} // 0x0000000186D865A0-0x0000000186D86650
			protected override EBTStatus decorate(EBTStatus status) => default; // 0x0000000186D86520-0x0000000186D865A0
			protected override EBTStatus update(Agent pAgent, EBTStatus childStatus) => default; // 0x0000000186D866D0-0x0000000186D86840
		}
	
		// Constructors
		public DecoratorLoop() {} // 0x0000000186D86F60-0x0000000186D86FC0
	
		// Methods
		protected override void load(int version, string agentType, List<property_t> properties) {} // 0x0000000186D889F0-0x0000000186D88B60
		public int Count(Agent pAgent) => default; // 0x0000000186D86DF0-0x0000000186D86E70
		public override bool IsValid(Agent pAgent, BehaviorTask pTask) => default; // 0x0000000186D86E70-0x0000000186D86F60
		protected override BehaviorTask createTask() => default; // 0x0000000186D88940-0x0000000186D889F0
	}
}
