/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace behaviac
{
	internal sealed class WithPreconditionTask : Sequence.SequenceTask // TypeDefIndex: 27495
	{
		// Properties
		public BehaviorTask PreconditionNode { get => default; } // 0x0000000186E07A00-0x0000000186E07A80 
		public BehaviorTask ActionNode { get => default; } // 0x0000000186E07980-0x0000000186E07A00 
	
		// Constructors
		public WithPreconditionTask() {} // 0x0000000186E077B0-0x0000000186E07850
	
		// Methods
		protected override void addChild(BehaviorTask pBehavior) {} // 0x0000000186E07850-0x0000000186E078D0
		public override void copyto(BehaviorTask target) {} // 0x0000000186E078D0-0x0000000186E07980
		public override void save(ISerializableNode node) {} // 0x0000000186E07C00-0x0000000186E07CB0
		public override void load(ISerializableNode node) {} // 0x0000000186E07A80-0x0000000186E07B30
		protected override bool onenter(Agent pAgent) => default; // 0x0000000186E07B30-0x0000000186E07BA0
		protected override void onexit(Agent pAgent, EBTStatus s) {} // 0x0000000186E07BA0-0x0000000186E07C00
		protected override EBTStatus update_current(Agent pAgent, EBTStatus childStatus) => default; // 0x0000000186E07CB0-0x0000000186E07D40
		protected override EBTStatus update(Agent pAgent, EBTStatus childStatus) => default; // 0x0000000186E07D40-0x0000000186E07DB0
	}
}
