/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace miHoYoEmotion
{
	public class SequenceBakeData : ScriptableObject // TypeDefIndex: 8506
	{
		// Properties
		public virtual BakeData phonemeBakeData { /* [XID] */ /* 0x0000000189B885E0-0x0000000189B88600 */ get => default; /* [XID] */ /* 0x0000000189B78010-0x0000000189B78030 */ set {} } // 0x000000018726A3F0-0x000000018726A490 0x000000018726A540-0x000000018726A5F0
		public virtual BakeData emotionBakeData { /* [XID] */ /* 0x0000000189B795F0-0x0000000189B79610 */ get => default; /* [XID] */ /* 0x000000018977AA40-0x000000018977AA60 */ set {} } // 0x000000018726A350-0x000000018726A3F0 0x000000018726A490-0x000000018726A540
	
		// Nested types
		[Serializable]
		public class BakeData // TypeDefIndex: 8507
		{
			// Fields
			public float length; // 0x10
			public TransitionType transitionType; // 0x14
			public string lastShape; // 0x18
	
			// Constructors
			public BakeData() {} // 0x000000018724CC00-0x000000018724CC70
		}
	
		// Constructors
		public SequenceBakeData() {} // 0x000000018726A2F0-0x000000018726A350
	}
}
