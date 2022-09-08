/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public class AdvDailyAction : IRelateCustomEvent, INpcActionCondContainer // TypeDefIndex: 21095
	{
		// Fields
		public INpcActionCond[][] conditions; // 0x18
		public int priority; // 0x20
		public IPointType point; // 0x28
		public FreeStyleData[] freeStyleList; // 0x30
		public bool canGreet; // 0x38
	
		// Properties
		public uint dirtyFlag { get; set; } // 0x0000000184E78AD0-0x0000000184E78B30 0x0000000184E78CB0-0x0000000184E78D10
		public bool lastCondRet { get; set; } // 0x0000000184E78B30-0x0000000184E78B90 0x0000000184E78D10-0x0000000184E78D70
		public INpcActionCond[][] conditionGroup { /* [XID] */ /* 0x0000000189A85DF0-0x0000000189A85E10 */ get => default; } // 0x0000000184E78A30-0x0000000184E78AD0 
		public IEnumerable<CustomEventType> relateEvents { /* [XID] */ /* 0x0000000189A8D6D0-0x0000000189A8D6F0 */ get => default; } // 0x0000000184E78B90-0x0000000184E78CB0 
	
		// Constructors
		public AdvDailyAction() {} // 0x0000000184E789D0-0x0000000184E78A30
	}
}
