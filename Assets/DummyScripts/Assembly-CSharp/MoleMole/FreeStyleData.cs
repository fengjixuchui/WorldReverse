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
	public class FreeStyleData : IRelateCustomEvent, INpcActionCondSubContainer // TypeDefIndex: 21092
	{
		// Fields
		public INpcActionCond[][] conditions; // 0x18
		public int weight; // 0x20
		public int freestyle; // 0x24
		public float time; // 0x28
		public bool isLoop; // 0x2C
		public EmotionData emotion; // 0x30
		public float bubbleRate; // 0x38
		public float bubbleDelay; // 0x3C
		public int[] bubbleGroupIds; // 0x40
	
		// Properties
		public uint dirtyFlag { get; set; } // 0x0000000181F7EE90-0x0000000181F7EEF0 0x0000000181F7F030-0x0000000181F7F090
		public bool lastCondRet { get; set; } // 0x0000000181F7EEF0-0x0000000181F7EF50 0x0000000181F7F090-0x0000000181F7F110
		public int containerWeight { /* [XID] */ /* 0x00000001899F3B70-0x00000001899F3B90 */ get => default; } // 0x0000000181F7EDF0-0x0000000181F7EE90 
		public INpcActionCond[][] conditionGroup { /* [XID] */ /* 0x00000001899FB410-0x00000001899FB430 */ get => default; } // 0x0000000181F7ED50-0x0000000181F7EDF0 
		public IEnumerable<CustomEventType> relateEvents { /* [XID] */ /* 0x0000000189A02670-0x0000000189A02690 */ get => default; } // 0x0000000181F7EF50-0x0000000181F7F030 
	
		// Constructors
		public FreeStyleData() {} // 0x0000000181F7ECE0-0x0000000181F7ED50
	}
}
