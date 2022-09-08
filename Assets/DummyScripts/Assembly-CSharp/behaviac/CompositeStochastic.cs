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
	public abstract class CompositeStochastic : BehaviorNode // TypeDefIndex: 27470
	{
		// Fields
		protected IMethod m_method; // 0x60
	
		// Nested types
		public class CompositeStochasticTask : CompositeTask // TypeDefIndex: 27471
		{
			// Fields
			protected List<int> m_set; // 0x50
	
			// Constructors
			public CompositeStochasticTask() {} // 0x0000000186D72A20-0x0000000186D72AB0
	
			// Methods
			public static float GetRandomValue(IMethod method, Agent pAgent) => default; // 0x0000000186D72920-0x0000000186D72A20
			public override void copyto(BehaviorTask target) {} // 0x0000000186D72AB0-0x0000000186D72B90
			public override void save(ISerializableNode node) {} // 0x0000000186D72FE0-0x0000000186D730F0
			public override void load(ISerializableNode node) {} // 0x0000000186D72B90-0x0000000186D72C40
			protected override bool onenter(Agent pAgent) => default; // 0x0000000186D72C40-0x0000000186D72CC0
			protected override void onexit(Agent pAgent, EBTStatus s) {} // 0x0000000186D72CC0-0x0000000186D72D50
			private void random_child(Agent pAgent) {} // 0x0000000186D72D50-0x0000000186D72FE0
		}
	
		// Constructors
		protected CompositeStochastic() {} // 0x0000000186D73260-0x0000000186D732C0
	
		// Methods
		protected override void load(int version, string agentType, List<property_t> properties) {} // 0x0000000186D732C0-0x0000000186D73420
		public bool CheckIfInterrupted(Agent pAgent) => default; // 0x0000000186D730F0-0x0000000186D73170
		public override bool IsValid(Agent pAgent, BehaviorTask pTask) => default; // 0x0000000186D73170-0x0000000186D73260
	}
}
