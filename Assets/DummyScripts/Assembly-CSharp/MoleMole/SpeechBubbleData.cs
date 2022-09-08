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
	public class SpeechBubbleData : IRelateCustomEvent, INpcActionCondSubContainer // TypeDefIndex: 21093
	{
		// Fields
		public INpcActionCond[][] conditions; // 0x18
		public int weight; // 0x20
		public uint initDialog; // 0x24
	
		// Properties
		public uint dirtyFlag { get; set; } // 0x0000000182B16C20-0x0000000182B16C80 0x0000000182B16DC0-0x0000000182B16E20
		public bool lastCondRet { get; set; } // 0x0000000182B16C80-0x0000000182B16CE0 0x0000000182B16E20-0x0000000182B16E80
		public int containerWeight { /* [XID] */ /* 0x0000000189A3C080-0x0000000189A3C0A0 */ get => default; } // 0x0000000182B16B80-0x0000000182B16C20 
		public INpcActionCond[][] conditionGroup { /* [XID] */ /* 0x0000000189A43D10-0x0000000189A43D30 */ get => default; } // 0x0000000182B16AE0-0x0000000182B16B80 
		public IEnumerable<CustomEventType> relateEvents { /* [XID] */ /* 0x0000000189A4B180-0x0000000189A4B1A0 */ get => default; } // 0x0000000182B16CE0-0x0000000182B16DC0 
	
		// Constructors
		public SpeechBubbleData() {} // 0x0000000182B16A80-0x0000000182B16AE0
	}
}
