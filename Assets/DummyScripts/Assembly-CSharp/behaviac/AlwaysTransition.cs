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
	internal sealed class AlwaysTransition : Transition // TypeDefIndex: 27539
	{
		// Fields
		private ETransitionPhase m_transitionPhase; // 0x78
	
		// Properties
		public ETransitionPhase TransitionPhase { get => default; set {} } // 0x00000001860A4600-0x00000001860A4660 0x00000001860A4890-0x00000001860A48F0
	
		// Nested types
		public enum ETransitionPhase // TypeDefIndex: 27540
		{
			ETP_Always = 0,
			ETP_Success = 1,
			ETP_Failure = 2,
			ETP_Exit = 3
		}
	
		// Constructors
		public AlwaysTransition() {} // 0x00000001860A4540-0x00000001860A45B0
	
		// Methods
		protected override void load(int version, string agentType, List<property_t> properties) {} // 0x00000001860A4660-0x00000001860A4890
		public override bool IsValid(Agent pAgent, BehaviorTask pTask) => default; // 0x00000001860A4440-0x00000001860A4540
		protected override BehaviorTask createTask() => default; // 0x00000001860A45B0-0x00000001860A4600
		public override bool Evaluate(Agent pAgent, EBTStatus status) => default; // 0x00000001860A43B0-0x00000001860A4440
	}
}
