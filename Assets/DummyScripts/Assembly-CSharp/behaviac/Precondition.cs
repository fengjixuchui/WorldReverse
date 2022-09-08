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
	public class Precondition : AttachAction // TypeDefIndex: 27434
	{
		// Properties
		public EPhase Phase { get => default; set {} } // 0x0000000186DF00B0-0x0000000186DF01C0 0x0000000186DF02E0-0x0000000186DF03F0
		public bool IsAnd { get => default; set {} } // 0x0000000186DEFFA0-0x0000000186DF00B0 0x0000000186DF01C0-0x0000000186DF02E0
	
		// Nested types
		public enum EPhase // TypeDefIndex: 27435
		{
			E_ENTER = 0,
			E_UPDATE = 1,
			E_BOTH = 2
		}
	
		public class PreconditionConfig : AttachAction.ActionConfig // TypeDefIndex: 27436
		{
			// Fields
			public EPhase m_phase; // 0x30
			public bool m_bAnd; // 0x34
	
			// Constructors
			public PreconditionConfig() {} // 0x0000000186DEF980-0x0000000186DEF9F0
	
			// Methods
			public override bool load(List<property_t> properties) => default; // 0x0000000186DEF9F0-0x0000000186DEFCA0
		}
	
		// Constructors
		public Precondition() {} // 0x0000000186DEFD90-0x0000000186DEFE60
	
		// Methods
		public override bool IsValid(Agent pAgent, BehaviorTask pTask) => default; // 0x0000000186DEFCA0-0x0000000186DEFD90
	}
}
