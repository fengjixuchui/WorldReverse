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
	public sealed class EntityLODConfig : ScriptableObjectUseFiEdit // TypeDefIndex: 31442
	{
		// Fields
		public List<EntityLODPattern> lodPatterns; // 0x18
		[NonSerialized]
		private Dictionary<int, EntityLODPattern> _type2LodPattern; // 0x20
	
		// Constructors
		public EntityLODConfig() {} // 0x00000001814A5000-0x00000001814A50B0
	
		// Methods
		// [XID] // 0x0000000189B4E780-0x0000000189B4E7A0
		public void Init() {} // 0x00000001814A4A50-0x00000001814A4C60
		// [XID] // 0x0000000189B55FE0-0x0000000189B56000
		public void Clear() {} // 0x00000001814A4C60-0x00000001814A4D10
		// [XID] // 0x0000000189B5D8C0-0x0000000189B5D8E0
		public EntityLODPattern GetPattern(int nameHash) => default; // 0x00000001814A4F10-0x00000001814A5000
		// [XID] // 0x0000000189B64E40-0x0000000189B64E60
		public EntityLODPattern GetDefaultPattern() => default; // 0x00000001814A4D10-0x00000001814A4DD0
		// [XID] // 0x0000000189B6C460-0x0000000189B6C480
		public bool RefreshLODPattern(EntityLODPattern info) => default; // 0x00000001814A4DD0-0x00000001814A4F10
	}
}
