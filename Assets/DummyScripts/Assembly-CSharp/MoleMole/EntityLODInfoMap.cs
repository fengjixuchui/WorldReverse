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
	public sealed class EntityLODInfoMap : ScriptableObjectUseFiEdit // TypeDefIndex: 31443
	{
		// Fields
		public List<EntityLODInfo> lodFinInfos; // 0x18
		[NonSerialized]
		private Dictionary<uint, EntityLODInfo> _name2LodFinInfo; // 0x20
	
		// Constructors
		public EntityLODInfoMap() {} // 0x00000001814A5500-0x00000001814A55B0
	
		// Methods
		// [XID] // 0x0000000189B73B90-0x0000000189B73BB0
		public void Init() {} // 0x00000001814A50B0-0x00000001814A5250
		// [XID] // 0x0000000189B7B1A0-0x0000000189B7B1C0
		public void Clear() {} // 0x00000001814A5250-0x00000001814A5300
		// [XID] // 0x0000000189B82B50-0x0000000189B82B70
		public EntityLODInfo GetEntityInfoByConfigID(uint configID) => default; // 0x00000001814A5300-0x00000001814A53F0
		// [XID] // 0x0000000189B8A180-0x0000000189B8A1A0
		public bool RefreshFinInfo(EntityLODInfo info) => default; // 0x00000001814A53F0-0x00000001814A5500
	}
}
