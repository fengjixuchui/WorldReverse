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
	public sealed class Selector : BehaviorNode // TypeDefIndex: 27482
	{
		// Nested types
		public class SelectorTask : CompositeTask // TypeDefIndex: 27483
		{
			// Constructors
			public SelectorTask() {} // 0x0000000186DF3B70-0x0000000186DF3BD0
	
			// Methods
			public override void copyto(BehaviorTask target) {} // 0x0000000186DF3BD0-0x0000000186DF3C50
			public override void save(ISerializableNode node) {} // 0x0000000186DF3DC0-0x0000000186DF3E40
			public override void load(ISerializableNode node) {} // 0x0000000186DF3C50-0x0000000186DF3CD0
			protected override bool onenter(Agent pAgent) => default; // 0x0000000186DF3CD0-0x0000000186DF3D30
			protected override void onexit(Agent pAgent, EBTStatus s) {} // 0x0000000186DF3D30-0x0000000186DF3DC0
			protected override EBTStatus update(Agent pAgent, EBTStatus childStatus) => default; // 0x0000000186DF3E40-0x0000000186DF3F00
		}
	
		// Constructors
		public Selector() {} // 0x0000000186DF4260-0x0000000186DF42C0
	
		// Methods
		protected override void load(int version, string agentType, List<property_t> properties) {} // 0x0000000186DF4370-0x0000000186DF4400
		public override bool IsValid(Agent pAgent, BehaviorTask pTask) => default; // 0x0000000186DF4080-0x0000000186DF4140
		public override bool Evaluate(Agent pAgent) => default; // 0x0000000186DF3F80-0x0000000186DF4080
		public EBTStatus SelectorUpdate(Agent pAgent, EBTStatus childStatus, ref int activeChildIndex, List<BehaviorTask> children) => default; // 0x0000000186DF4140-0x0000000186DF4260
		public bool CheckIfInterrupted(Agent pAgent) => default; // 0x0000000186DF3F00-0x0000000186DF3F80
		protected override BehaviorTask createTask() => default; // 0x0000000186DF42C0-0x0000000186DF4370
	}
}
