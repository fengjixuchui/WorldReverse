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
	[Serializable]
	public class EntityLODPattern // TypeDefIndex: 31438
	{
		// Fields
		public string patternName; // 0x10
		public List<EntityLODQualityInfo> multiplatform; // 0x18
		private Dictionary<int, EntityLODQualityInfo> _name2Quality; // 0x20
	
		// Constructors
		public EntityLODPattern() {} // 0x00000001814A5920-0x00000001814A59D0
	
		// Methods
		// [XID] // 0x0000000189B3F6E0-0x0000000189B3F700
		public void InitPattern() {} // 0x00000001814A5720-0x00000001814A5920
		// [XID] // 0x0000000189B47080-0x0000000189B470A0
		public EntityLODQualityInfo GetQuality(int index) => default; // 0x00000001814A5610-0x00000001814A5720
	}
}
