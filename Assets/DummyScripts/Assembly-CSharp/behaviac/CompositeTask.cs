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
	public class CompositeTask : BranchTask // TypeDefIndex: 27450
	{
		// Fields
		protected bool m_bIgnoreChildren; // 0x38
		protected List<BehaviorTask> m_children; // 0x40
		protected int m_activeChildIndex; // 0x48
		protected const int InvalidChildIndex = -1; // Metadata: 0x00B0C9D9
	
		// Constructors
		protected CompositeTask() {} // 0x0000000186D73600-0x0000000186D736A0
	
		// Methods
		public override void traverse(bool childFirst, NodeHandler_t handler, Agent pAgent, object user_data) {} // 0x0000000186D739B0-0x0000000186D73BD0
		public override void Init(BehaviorNode node) {} // 0x0000000186D73520-0x0000000186D73600
		public override void copyto(BehaviorTask target) {} // 0x0000000186D73740-0x0000000186D738B0
		public override void save(ISerializableNode node) {} // 0x0000000186D73930-0x0000000186D739B0
		public override void load(ISerializableNode node) {} // 0x0000000186D738B0-0x0000000186D73930
		protected override void addChild(BehaviorTask pBehavior) {} // 0x0000000186D736A0-0x0000000186D73740
		protected BehaviorTask GetChildById(int nodeId) => default; // 0x0000000186D73420-0x0000000186D73520
	}
}
