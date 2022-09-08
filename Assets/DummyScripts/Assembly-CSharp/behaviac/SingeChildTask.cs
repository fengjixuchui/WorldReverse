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
	public class SingeChildTask : BranchTask // TypeDefIndex: 27451
	{
		// Fields
		protected BehaviorTask m_root; // 0x38
	
		// Constructors
		protected SingeChildTask() {} // 0x0000000186DF5470-0x0000000186DF54E0
	
		// Methods
		public override void traverse(bool childFirst, NodeHandler_t handler, Agent pAgent, object user_data) {} // 0x0000000186DF57A0-0x0000000186DF5900
		public override void Init(BehaviorNode node) {} // 0x0000000186DF53B0-0x0000000186DF5470
		public override void copyto(BehaviorTask target) {} // 0x0000000186DF5570-0x0000000186DF56A0
		public override void save(ISerializableNode node) {} // 0x0000000186DF5720-0x0000000186DF57A0
		public override void load(ISerializableNode node) {} // 0x0000000186DF56A0-0x0000000186DF5720
		protected override EBTStatus update(Agent pAgent, EBTStatus childStatus) => default; // 0x0000000186DF5900-0x0000000186DF5990
		protected override void addChild(BehaviorTask pBehavior) {} // 0x0000000186DF54E0-0x0000000186DF5570
	}
}
