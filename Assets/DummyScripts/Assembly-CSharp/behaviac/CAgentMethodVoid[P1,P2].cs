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
	public class CAgentMethodVoid<P1, P2> : CAgentMethodVoidBase // TypeDefIndex: 27307
	{
		// Fields
		private FunctionPointer _fp;
		private IInstanceMember _p1;
		private IInstanceMember _p2;
	
		// Nested types
		public delegate void FunctionPointer(Agent a, P1 p1, P2 p2); // TypeDefIndex: 27308; 0x00000000-0x00000000
	
		// Constructors
		public CAgentMethodVoid() {} // Dummy constructor
		public CAgentMethodVoid(FunctionPointer f) {}
		public CAgentMethodVoid(CAgentMethodVoid<P1, P2> rhs) {}
	
		// Methods
		public override IMethod Clone() => default;
		public override void Load(string instance, string[] paramStrs) {}
		public override void Run(Agent self) {}
		public override void SetTaskParams(Agent self, BehaviorTreeTask treeTask) {}
	}
}
