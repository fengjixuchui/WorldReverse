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
	public sealed class Effector : AttachAction // TypeDefIndex: 27430
	{
		// Properties
		public EPhase Phase { get => default; set {} } // 0x0000000186D8BB70-0x0000000186D8BC80 0x0000000186D8BC80-0x0000000186D8BD90
	
		// Nested types
		public enum EPhase // TypeDefIndex: 27431
		{
			E_SUCCESS = 0,
			E_FAILURE = 1,
			E_BOTH = 2
		}
	
		public class EffectorConfig : AttachAction.ActionConfig // TypeDefIndex: 27432
		{
			// Fields
			public EPhase m_phase; // 0x30
	
			// Constructors
			public EffectorConfig() {} // 0x0000000186D8B790-0x0000000186D8B800
	
			// Methods
			public override bool load(List<property_t> properties) => default; // 0x0000000186D8B800-0x0000000186D8B9E0
		}
	
		// Constructors
		public Effector() {} // 0x0000000186D8BAA0-0x0000000186D8BB70
	
		// Methods
		public override bool IsValid(Agent pAgent, BehaviorTask pTask) => default; // 0x0000000186D8B9E0-0x0000000186D8BAA0
	}
}
