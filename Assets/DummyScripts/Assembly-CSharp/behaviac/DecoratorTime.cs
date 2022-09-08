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
	public sealed class DecoratorTime : DecoratorNode // TypeDefIndex: 27535
	{
		// Fields
		private IInstanceMember m_time; // 0x68
	
		// Nested types
		private class DecoratorTimeTask : DecoratorTask // TypeDefIndex: 27536
		{
			// Fields
			private double m_start; // 0x40
			private double m_time; // 0x48
			private long m_intStart; // 0x50
			private int m_intTime; // 0x58
	
			// Constructors
			public DecoratorTimeTask() {} // 0x0000000186D8A440-0x0000000186D8A4F0
	
			// Methods
			public override void copyto(BehaviorTask target) {} // 0x0000000186D8A4F0-0x0000000186D8A5F0
			public override void save(ISerializableNode node) {} // 0x0000000186D8A940-0x0000000186D8AB20
			public override void load(ISerializableNode node) {} // 0x0000000186D8A740-0x0000000186D8A7C0
			private double GetTime(Agent pAgent) => default; // 0x0000000186D8A390-0x0000000186D8A440
			private int GetIntTime(Agent pAgent) => default; // 0x0000000186D8A2E0-0x0000000186D8A390
			protected override bool onenter(Agent pAgent) => default; // 0x0000000186D8A7C0-0x0000000186D8A940
			protected override EBTStatus decorate(EBTStatus status) => default; // 0x0000000186D8A5F0-0x0000000186D8A740
		}
	
		// Constructors
		public DecoratorTime() {} // 0x0000000186D8AE20-0x0000000186D8AEC0
	
		// Methods
		protected override void load(int version, string agentType, List<property_t> properties) {} // 0x0000000186D8AF30-0x0000000186D8B0E0
		private double GetTime(Agent pAgent) => default; // 0x0000000186D8AC20-0x0000000186D8AE20
		private int GetIntTime(Agent pAgent) => default; // 0x0000000186D8AB20-0x0000000186D8AC20
		protected override BehaviorTask createTask() => default; // 0x0000000186D8AEC0-0x0000000186D8AF30
	}
}
