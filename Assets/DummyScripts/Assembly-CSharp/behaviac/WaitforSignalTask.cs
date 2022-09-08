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
	internal sealed class WaitforSignalTask : SingeChildTask // TypeDefIndex: 27467
	{
		// Fields
		private bool m_bTriggered; // 0x40
	
		// Constructors
		public WaitforSignalTask() {} // 0x0000000186E070A0-0x0000000186E07150
	
		// Methods
		public override void copyto(BehaviorTask target) {} // 0x0000000186E07150-0x0000000186E07200
		public override void save(ISerializableNode node) {} // 0x0000000186E072F0-0x0000000186E073E0
		protected override bool onenter(Agent pAgent) => default; // 0x0000000186E07200-0x0000000186E07260
		protected override void onexit(Agent pAgent, EBTStatus s) {} // 0x0000000186E07260-0x0000000186E072F0
		protected override EBTStatus update(Agent pAgent, EBTStatus childStatus) => default; // 0x0000000186E073E0-0x0000000186E07510
	}
}
