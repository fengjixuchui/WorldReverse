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
	public class LightningFieldScript : LightningBoltPrefabScriptBase // TypeDefIndex: 9676
	{
		// Fields
		// [Header] // 0x00000001896EA800-0x00000001896EA860
		// [Tooltip] // 0x00000001896EA800-0x00000001896EA860
		public float MinimumLength; // 0x1F0
		private float minimumLengthSquared; // 0x1F4
		// [Tooltip] // 0x00000001896F7C30-0x00000001896F7C60
		public Bounds FieldBounds; // 0x1F8
		// [Tooltip] // 0x0000000189700BE0-0x0000000189700C10
		public Light Light; // 0x210
	
		// Constructors
		public LightningFieldScript() {} // 0x0000000186043020-0x0000000186043090
	
		// Methods
		// [XID] // 0x0000000189709C20-0x0000000189709C40
		private Vector3 RandomPointInBounds() => default; // 0x0000000186042A50-0x0000000186042C50
		// [XID] // 0x0000000189770750-0x0000000189770770
		protected override void Start() {} // 0x0000000186042C50-0x0000000186042D50
		// [XID] // 0x0000000189718A80-0x0000000189718AA0
		protected override void Update() {} // 0x0000000186042E90-0x0000000186043020
		// [XID] // 0x00000001897201A0-0x00000001897201C0
		public override void CreateLightningBolt(LightningBoltParameters parameters) {} // 0x0000000186042800-0x0000000186042A50
	}
}
