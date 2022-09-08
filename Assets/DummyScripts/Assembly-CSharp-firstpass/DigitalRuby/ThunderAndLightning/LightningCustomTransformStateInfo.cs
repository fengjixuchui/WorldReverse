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
	public class LightningCustomTransformStateInfo // TypeDefIndex: 9628
	{
		// Fields
		public Vector3 BoltStartPosition; // 0x14
		public Vector3 BoltEndPosition; // 0x20
		public Transform Transform; // 0x30
		public Transform StartTransform; // 0x38
		public Transform EndTransform; // 0x40
		public object UserInfo; // 0x48
		private static readonly List<LightningCustomTransformStateInfo> cache; // 0x00
	
		// Properties
		public LightningCustomTransformState State { /* [XID] */ /* 0x0000000189789F30-0x0000000189789F70 */ get; /* [XID] */ /* 0x0000000189794320-0x0000000189794360 */ set; } // 0x0000000186042740-0x00000001860427A0 0x00000001860427A0-0x0000000186042800
	
		// Constructors
		public LightningCustomTransformStateInfo() {} // 0x00000001860426E0-0x0000000186042740
		static LightningCustomTransformStateInfo() {} // 0x0000000186042650-0x00000001860426E0
	
		// Methods
		// [XID] // 0x00000001898A9310-0x00000001898A9330
		public static LightningCustomTransformStateInfo GetOrCreateStateInfo() => default; // 0x0000000186042390-0x0000000186042550
		// [XID] // 0x00000001898B0B60-0x00000001898B0B80
		public static void ReturnStateInfoToCache(LightningCustomTransformStateInfo info) {} // 0x0000000186042550-0x0000000186042650
	}
}
