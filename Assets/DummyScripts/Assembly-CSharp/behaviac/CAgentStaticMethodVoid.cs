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
	public sealed class CAgentStaticMethodVoid : CAgentMethodVoidBase // TypeDefIndex: 27333
	{
		// Fields
		private FunctionPointer _fp; // 0x18
	
		// Nested types
		public delegate void FunctionPointer(); // TypeDefIndex: 27334; 0x0000000186D8CEB0-0x0000000186D8D010
	
		// Constructors
		public CAgentStaticMethodVoid() {} // Dummy constructor
		public CAgentStaticMethodVoid(FunctionPointer f) {} // 0x0000000186D6D370-0x0000000186D6D430
		public CAgentStaticMethodVoid(CAgentStaticMethodVoid rhs) {} // 0x0000000186D6D2E0-0x0000000186D6D370
	
		// Methods
		public override IMethod Clone() => default; // 0x0000000186D6D140-0x0000000186D6D1C0
		public override void Load(string instance, string[] paramStrs) {} // 0x0000000186D6D1C0-0x0000000186D6D220
		public override void Run(Agent self) {} // 0x0000000186D6D220-0x0000000186D6D290
		public override void SetTaskParams(Agent self, BehaviorTreeTask treeTask) {} // 0x0000000186D6D290-0x0000000186D6D2E0
	}
}
