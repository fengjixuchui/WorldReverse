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
	public class NpcActionDayNightCondition : INpcActionCond // TypeDefIndex: 21083
	{
		// Fields
		public const int DAILY_CONDITION_ALLDAY = 0; // Metadata: 0x00AFEDD7
		public const int DAILY_CONDITION_DAY = 1; // Metadata: 0x00AFEDDB
		public const int DAILY_CONDITION_NIGHT = 2; // Metadata: 0x00AFEDDF
		private static CustomEventType[] _relateEvents; // 0x00
		public int daily; // 0x10
	
		// Properties
		public IEnumerable<CustomEventType> relateEvents { /* [XID] */ /* 0x00000001899755B0-0x00000001899755D0 */ get => default; } // 0x00000001824B1AF0-0x00000001824B1BC0 
	
		// Constructors
		public NpcActionDayNightCondition() {} // 0x00000001824B1A90-0x00000001824B1AF0
		static NpcActionDayNightCondition() {} // 0x00000001824B1A10-0x00000001824B1A90
	
		// Methods
		// [XID] // 0x000000018997C750-0x000000018997C770
		public bool IsValid() => default; // 0x00000001824B1910-0x00000001824B1A10
	}
}
