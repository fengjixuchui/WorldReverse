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

namespace Gaia
{
	public class SpawnGrassExtension : SpawnRuleExtension // TypeDefIndex: 9317
	{
		// Fields
		// [Tooltip] // 0x00000001896F0290-0x00000001896F02C0
		public int m_grassIndex; // 0x18
		// [Range] // 0x00000001896F92B0-0x00000001896F9310
		// [Tooltip] // 0x00000001896F92B0-0x00000001896F9310
		public int m_minGrassStrenth; // 0x1C
		// [Range] // 0x0000000189705250-0x00000001897052B0
		// [Tooltip] // 0x0000000189705250-0x00000001897052B0
		public int m_maxGrassStrength; // 0x20
		// [Tooltip] // 0x0000000189711620-0x0000000189711650
		public Texture2D m_grassMask; // 0x28
		// [Tooltip] // 0x000000018971A4E0-0x000000018971A510
		public bool m_normaliseMask; // 0x30
		// [Tooltip] // 0x00000001897709D0-0x0000000189770A00
		public bool m_invertMask; // 0x31
		// [Tooltip] // 0x000000018972BF40-0x000000018972BF70
		public bool m_flipMask; // 0x32
		// [Range] // 0x000000018977F6F0-0x000000018977F740
		// [Tooltip] // 0x000000018977F6F0-0x000000018977F740
		public float m_scaleMask; // 0x34
		private UnityHeightMap m_textureHM; // 0x38
	
		// Constructors
		public SpawnGrassExtension() {} // 0x0000000186448630-0x00000001864486F0
	
		// Methods
		// [XID] // 0x0000000189741140-0x0000000189741160
		public override void Initialise() {} // 0x0000000186447D00-0x0000000186447E80
		// [XID] // 0x00000001899DBBB0-0x00000001899DBBD0
		public override bool AffectsDetails() => default; // 0x0000000186447C60-0x0000000186447D00
		// [XID] // 0x000000018965B950-0x000000018965B970
		public override void PostSpawn(SpawnRule spawnRule, ref SpawnInfo spawnInfo) {} // 0x0000000186447E80-0x00000001864484D0
	}
}
