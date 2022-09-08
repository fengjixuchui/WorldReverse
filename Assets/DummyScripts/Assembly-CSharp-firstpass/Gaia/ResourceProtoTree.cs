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
	public class ResourceProtoTree // TypeDefIndex: 9296
	{
		// Fields
		// [Tooltip] // 0x0000000189916A80-0x0000000189916AB0
		public string m_name; // 0x10
		// [Tooltip] // 0x0000000189757600-0x0000000189757630
		public GameObject m_desktopPrefab; // 0x18
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public string m_desktopPrefabFileName; // 0x20
		// [Tooltip] // 0x0000000189767970-0x00000001897679A0
		public GameObject m_mobilePrefab; // 0x28
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public string m_mobilePrefabFileName; // 0x30
		// [Tooltip] // 0x00000001899F1720-0x00000001899F1750
		public float m_bendFactor; // 0x38
		// [Tooltip] // 0x00000001899FAA00-0x00000001899FAA30
		public Color m_healthyColour; // 0x3C
		// [Tooltip] // 0x0000000189A037A0-0x0000000189A037D0
		public Color m_dryColour; // 0x4C
		// [Tooltip] // 0x00000001898D8700-0x00000001898D8730
		public ResourceProtoDNA m_dna; // 0x60
		// [Tooltip] // 0x00000001899883B0-0x00000001899883E0
		public SpawnCritera[] m_spawnCriteria; // 0x68
		// [Tooltip] // 0x0000000189A1B030-0x0000000189A1B060
		public SpawnRuleExtension[] m_spawnExtensions; // 0x70
	
		// Constructors
		public ResourceProtoTree() {} // 0x0000000185A04F70-0x0000000185A05040
	
		// Methods
		// [XID] // 0x00000001896CB390-0x00000001896CB3B0
		public void Initialise(Spawner spawner) {} // 0x0000000185A04DD0-0x0000000185A04ED0
		// [XID] // 0x0000000189A29BA0-0x0000000189A29BC0
		public bool HasActiveCriteria() => default; // 0x0000000185A04CC0-0x0000000185A04DD0
		// [XID] // 0x0000000189A310A0-0x0000000189A310C0
		public bool SetAssetAssociations() => default; // 0x0000000185A04ED0-0x0000000185A04F70
		// [XID] // 0x0000000189A38C90-0x0000000189A38CB0
		public bool AssociateAssets() => default; // 0x0000000185A049A0-0x0000000185A04A40
		// [XID] // 0x0000000189A40280-0x0000000189A402A0
		public bool ChecksTextures() => default; // 0x0000000185A04B80-0x0000000185A04CC0
		// [XID] // 0x0000000189A47990-0x0000000189A479B0
		public bool ChecksProximity() => default; // 0x0000000185A04A40-0x0000000185A04B80
		// [XID] // 0x0000000189B84CD0-0x0000000189B84CF0
		public void AddTags(ref List<string> tagList) {} // 0x0000000185A04780-0x0000000185A049A0
	}
}
