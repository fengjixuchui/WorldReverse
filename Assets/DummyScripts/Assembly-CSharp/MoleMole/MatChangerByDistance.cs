/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	[Serializable]
	public sealed class MatChangerByDistance : RatioChangerByDistance // TypeDefIndex: 19700
	{
		// Fields
		public Renderer renderer; // 0x28
		public string[] textureProperty; // 0x30
		public string[] floatProperty; // 0x38
		private Dictionary<int, Vector2> _textureTilingProperties; // 0x40
		private Dictionary<int, float> _floatProperties; // 0x48
	
		// Constructors
		public MatChangerByDistance() {} // Dummy constructor
		public MatChangerByDistance(BaseEntity entity, ConfigMatLinearChangedByDistance config) {} // 0x0000000184F1C1A0-0x0000000184F1C320
	
		// Methods
		// [XID] // 0x00000001899C8600-0x00000001899C8620
		public override void Init() {} // 0x0000000184F1B9B0-0x0000000184F1BCC0
		// [XID] // 0x00000001899D0070-0x00000001899D0090
		public override void Destroy() {} // 0x0000000184F1B5E0-0x0000000184F1B9B0
		// [XID] // 0x00000001899D7470-0x00000001899D7490
		protected override void OnRatioChanged(float ratio) {} // 0x0000000184F1BD20-0x0000000184F1C120
	}
}
