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
	public sealed class Sequence : BehaviorNode // TypeDefIndex: 27490
	{
		// Nested types
		public class SequenceTask : CompositeTask // TypeDefIndex: 27491
		{
			// Constructors
			public SequenceTask() {} // 0x0000000186DF4B20-0x0000000186DF4B80
	
			// Methods
			public override void copyto(BehaviorTask target) {} // 0x0000000186DF4B80-0x0000000186DF4C00
			public override void save(ISerializableNode node) {} // 0x0000000186DF4D70-0x0000000186DF4DF0
			public override void load(ISerializableNode node) {} // 0x0000000186DF4C00-0x0000000186DF4C80
			protected override bool onenter(Agent pAgent) => default; // 0x0000000186DF4C80-0x0000000186DF4CE0
			protected override void onexit(Agent pAgent, EBTStatus s) {} // 0x0000000186DF4CE0-0x0000000186DF4D70
			protected override EBTStatus update(Agent pAgent, EBTStatus childStatus) => default; // 0x0000000186DF4DF0-0x0000000186DF4EB0
		}
	
		// Constructors
		public Sequence() {} // 0x0000000186DF5210-0x0000000186DF5270
	
		// Methods
		protected override void load(int version, string agentType, List<property_t> properties) {} // 0x0000000186DF5320-0x0000000186DF53B0
		public override bool IsValid(Agent pAgent, BehaviorTask pTask) => default; // 0x0000000186DF5030-0x0000000186DF50F0
		public override bool Evaluate(Agent pAgent) => default; // 0x0000000186DF4F30-0x0000000186DF5030
		public EBTStatus SequenceUpdate(Agent pAgent, EBTStatus childStatus, ref int activeChildIndex, List<BehaviorTask> children) => default; // 0x0000000186DF50F0-0x0000000186DF5210
		public bool CheckIfInterrupted(Agent pAgent) => default; // 0x0000000186DF4EB0-0x0000000186DF4F30
		protected override BehaviorTask createTask() => default; // 0x0000000186DF5270-0x0000000186DF5320
	}
}
