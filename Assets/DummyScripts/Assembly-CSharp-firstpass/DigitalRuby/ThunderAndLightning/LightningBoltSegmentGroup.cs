/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace DigitalRuby.ThunderAndLightning
{
	public class LightningBoltSegmentGroup // TypeDefIndex: 9632
	{
		// Fields
		public float LineWidth; // 0x10
		public int StartIndex; // 0x14
		public int Generation; // 0x18
		public float Delay; // 0x1C
		public float PeakStart; // 0x20
		public float PeakEnd; // 0x24
		public float LifeTime; // 0x28
		public float EndWidthMultiplier; // 0x2C
		public Color32 Color; // 0x30
		public readonly List<LightningBoltSegment> Segments; // 0x38
	
		// Properties
		public int SegmentCount { /* [XID] */ /* 0x0000000189786220-0x0000000189786240 */ get => default; } // 0x00000001860408F0-0x0000000186040AC0 
	
		// Constructors
		public LightningBoltSegmentGroup() {} // 0x0000000186040860-0x00000001860408F0
	
		// Methods
		// [XID] // 0x00000001898E8040-0x00000001898E8060
		public void Reset() {} // 0x00000001860407A0-0x0000000186040860
	}
}
