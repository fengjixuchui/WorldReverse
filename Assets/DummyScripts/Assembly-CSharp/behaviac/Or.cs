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
	public sealed class Or : ConditionBase // TypeDefIndex: 27504
	{
		// Nested types
		private class OrTask : Selector.SelectorTask // TypeDefIndex: 27505
		{
			// Constructors
			public OrTask() {} // 0x0000000186DED930-0x0000000186DED9D0
	
			// Methods
			public override void copyto(BehaviorTask target) {} // 0x0000000186DED9D0-0x0000000186DEDA80
			public override void save(ISerializableNode node) {} // 0x0000000186DEDB30-0x0000000186DEDBE0
			public override void load(ISerializableNode node) {} // 0x0000000186DEDA80-0x0000000186DEDB30
			protected override EBTStatus update(Agent pAgent, EBTStatus childStatus) => default; // 0x0000000186DEDBE0-0x0000000186DEDCE0
		}
	
		// Constructors
		public Or() {} // 0x0000000186DEDEA0-0x0000000186DEDF00
	
		// Methods
		protected override void load(int version, string agentType, List<property_t> properties) {} // 0x0000000186DEDF70-0x0000000186DEE000
		public override bool IsValid(Agent pAgent, BehaviorTask pTask) => default; // 0x0000000186DEDDE0-0x0000000186DEDEA0
		public override bool Evaluate(Agent pAgent) => default; // 0x0000000186DEDCE0-0x0000000186DEDDE0
		protected override BehaviorTask createTask() => default; // 0x0000000186DEDF00-0x0000000186DEDF70
	}
}
