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

namespace DigitalRuby.ThunderAndLightning
{
	public class LightningBoltPathScript : LightningBoltPathScriptBase // TypeDefIndex: 9654
	{
		// Fields
		// [Range] // 0x000000018970FDB0-0x000000018970FE10
		// [Tooltip] // 0x000000018970FDB0-0x000000018970FE10
		public float Speed; // 0x200
		// [SingleLineClamp] // 0x000000018971BC50-0x000000018971BCA0
		public RangeOfFloats SpeedIntervalRange; // 0x204
		// [Tooltip] // 0x0000000189724710-0x0000000189724740
		public bool Repeat; // 0x20C
		private float nextInterval; // 0x210
		private int nextIndex; // 0x214
		private Vector3? lastPoint; // 0x218
	
		// Constructors
		public LightningBoltPathScript() {} // 0x000000018603AB10-0x000000018603ABB0
	
		// Methods
		// [XID] // 0x000000018972D5F0-0x000000018972D610
		public override void CreateLightningBolt(LightningBoltParameters parameters) {} // 0x000000018603A580-0x000000018603A9D0
		// [XID] // 0x0000000189734DD0-0x0000000189734DF0
		public void Reset() {} // 0x000000018603A9D0-0x000000018603AA90
	}
}
