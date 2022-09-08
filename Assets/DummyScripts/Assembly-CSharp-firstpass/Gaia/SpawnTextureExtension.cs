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
	public class SpawnTextureExtension : SpawnRuleExtension // TypeDefIndex: 9318
	{
		// Fields
		// [Tooltip] // 0x00000001897575D0-0x0000000189757600
		public int m_textureIndex; // 0x18
		// [Tooltip] // 0x0000000189760620-0x0000000189760650
		public Texture2D m_textureMask; // 0x20
		// [Tooltip] // 0x000000018971A4E0-0x000000018971A510
		public bool m_normaliseMask; // 0x28
		// [Tooltip] // 0x00000001897709D0-0x0000000189770A00
		public bool m_invertMask; // 0x29
		// [Tooltip] // 0x000000018972BF40-0x000000018972BF70
		public bool m_flipMask; // 0x2A
		// [Range] // 0x000000018977F6F0-0x000000018977F740
		// [Tooltip] // 0x000000018977F6F0-0x000000018977F740
		public float m_scaleMask; // 0x2C
		private UnityHeightMap m_textureHM; // 0x30
	
		// Constructors
		public SpawnTextureExtension() {} // 0x000000018644F4A0-0x000000018644F560
	
		// Methods
		// [XID] // 0x000000018966A870-0x000000018966A890
		public override void Initialise() {} // 0x000000018644EAE0-0x000000018644EC60
		// [XID] // 0x0000000189791740-0x0000000189791760
		public override bool AffectsTextures() => default; // 0x000000018644EA40-0x000000018644EAE0
		// [XID] // 0x0000000189A6F3E0-0x0000000189A6F400
		public override void PostSpawn(SpawnRule spawnRule, ref SpawnInfo spawnInfo) {} // 0x000000018644EC60-0x000000018644F340
	}
}
