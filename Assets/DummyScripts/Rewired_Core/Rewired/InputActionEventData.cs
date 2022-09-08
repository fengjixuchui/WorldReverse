/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Image 39: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3466-4436

namespace Rewired
{
	public struct InputActionEventData // TypeDefIndex: 3477
	{
		// Fields
		private pEQcyInzaqspNDwmuMYGrewsNaQ AiYMrYvHfmgGTECLagDHCliIfUw; // 0x00
		private InputActionEventType ETdYAeWExySaEFQlWEwhFEMGwsh; // 0x08
		public readonly int playerId; // 0x0C
		public readonly int actionId; // 0x10
		public readonly UpdateLoopType updateLoop; // 0x14
	
		// Properties
		internal InputActionEventType eventType { set {} } // 0x0000000185833780-0x0000000185833890
	
		// Constructors
		internal InputActionEventData(pEQcyInzaqspNDwmuMYGrewsNaQ vc, int playerId, int actionId, UpdateLoopType updateLoop) : this() {
			AiYMrYvHfmgGTECLagDHCliIfUw = default;
			ETdYAeWExySaEFQlWEwhFEMGwsh = default;
			this.playerId = default;
			this.actionId = default;
			this.updateLoop = default;
		} // 0x0000000185833710-0x0000000185833780
	}
}
