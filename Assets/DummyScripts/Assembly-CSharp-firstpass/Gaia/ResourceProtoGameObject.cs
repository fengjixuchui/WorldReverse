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

namespace Gaia
{
	[Serializable]
	public class ResourceProtoGameObject // TypeDefIndex: 9291
	{
		// Fields
		// [Tooltip] // 0x0000000189916A80-0x0000000189916AB0
		public string m_name; // 0x10
		// [Tooltip] // 0x0000000189869350-0x0000000189869380
		public ResourceProtoGameObjectInstance[] m_instances; // 0x18
		// [Tooltip] // 0x0000000189872010-0x0000000189872040
		public ResourceProtoDNA m_dna; // 0x20
		// [Tooltip] // 0x00000001899883B0-0x00000001899883E0
		public SpawnCritera[] m_spawnCriteria; // 0x28
		// [Tooltip] // 0x0000000189A1B030-0x0000000189A1B060
		public SpawnRuleExtension[] m_spawnExtensions; // 0x30
	
		// Constructors
		public ResourceProtoGameObject() {} // 0x0000000185A03510-0x0000000185A035F0
	
		// Methods
		// [XID] // 0x00000001898C5950-0x00000001898C5970
		public void Initialise(Spawner spawner) {} // 0x0000000185A03370-0x0000000185A03470
		// [XID] // 0x0000000189890E80-0x0000000189890EA0
		public bool HasActiveCriteria() => default; // 0x0000000185A03260-0x0000000185A03370
		// [XID] // 0x00000001898983E0-0x0000000189898400
		public bool SetAssetAssociations() => default; // 0x0000000185A03470-0x0000000185A03510
		// [XID] // 0x0000000189A9E850-0x0000000189A9E870
		public bool AssociateAssets() => default; // 0x0000000185A02F40-0x0000000185A02FE0
		// [XID] // 0x00000001895EC4D0-0x00000001895EC4F0
		public bool ChecksTextures() => default; // 0x0000000185A03120-0x0000000185A03260
		// [XID] // 0x00000001898AEBB0-0x00000001898AEBD0
		public bool ChecksProximity() => default; // 0x0000000185A02FE0-0x0000000185A03120
		// [XID] // 0x00000001898B5DD0-0x00000001898B5DF0
		public void AddTags(ref List<string> tagList) {} // 0x0000000185A02D20-0x0000000185A02F40
	}
}
