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
	public class CAgentMethodVoid<P1, P2, P3, P4> : CAgentMethodVoidBase // TypeDefIndex: 27311
	{
		// Fields
		private FunctionPointer _fp;
		private IInstanceMember _p1;
		private IInstanceMember _p2;
		private IInstanceMember _p3;
		private IInstanceMember _p4;
	
		// Nested types
		public delegate void FunctionPointer(Agent a, P1 p1, P2 p2, P3 p3, P4 p4); // TypeDefIndex: 27312; 0x00000000-0x00000000
	
		// Constructors
		public CAgentMethodVoid() {} // Dummy constructor
		public CAgentMethodVoid(FunctionPointer f, IInstanceMember p1, IInstanceMember p2, IInstanceMember p3, IInstanceMember p4) {}
		public CAgentMethodVoid(CAgentMethodVoid<P1, P2, P3, P4> rhs) {}
	
		// Methods
		public override IMethod Clone() => default;
		public override void Load(string instance, string[] paramStrs) {}
		public override void Run(Agent self) {}
		public override void SetTaskParams(Agent self, BehaviorTreeTask treeTask) {}
	}
}
