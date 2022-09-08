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
	public sealed class CAgentMethodVoid : CAgentMethodVoidBase // TypeDefIndex: 27303
	{
		// Fields
		private FunctionPointer _fp; // 0x18
	
		// Nested types
		public delegate void FunctionPointer(Agent a); // TypeDefIndex: 27304; 0x0000000186D8D010-0x0000000186D8D270
	
		// Constructors
		public CAgentMethodVoid() {} // Dummy constructor
		public CAgentMethodVoid(FunctionPointer f) {} // 0x0000000186D6CFF0-0x0000000186D6D0B0
		public CAgentMethodVoid(CAgentMethodVoid rhs) {} // 0x0000000186D6D0B0-0x0000000186D6D140
	
		// Methods
		public override IMethod Clone() => default; // 0x0000000186D6CE00-0x0000000186D6CE80
		public override void Load(string instance, string[] paramStrs) {} // 0x0000000186D6CE80-0x0000000186D6CEE0
		public override void Run(Agent self) {} // 0x0000000186D6CEE0-0x0000000186D6CFA0
		public override void SetTaskParams(Agent self, BehaviorTreeTask treeTask) {} // 0x0000000186D6CFA0-0x0000000186D6CFF0
	}
}
