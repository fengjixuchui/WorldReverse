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
	public class ResourceVisualiser : MonoBehaviour // TypeDefIndex: 9298
	{
		// Fields
		// [Tooltip] // 0x0000000189A566F0-0x0000000189A56720
		public GaiaResource m_resources; // 0x18
		// [Tooltip] // 0x0000000189A5FBD0-0x0000000189A5FC00
		public float m_range; // 0x20
		// [Range] // 0x0000000189A68FB0-0x0000000189A69010
		// [Tooltip] // 0x0000000189A68FB0-0x0000000189A69010
		public float m_resolution; // 0x24
		// [Range] // 0x0000000189A74A80-0x0000000189A74AE0
		// [Tooltip] // 0x0000000189A74A80-0x0000000189A74AE0
		public float m_minimumFitness; // 0x28
		// [Tooltip] // 0x0000000189A80CC0-0x0000000189A80CF0
		public LayerMask m_fitnessCollisionLayers; // 0x2C
		// [Tooltip] // 0x0000000189A89E60-0x0000000189A89E90
		public Color m_fitColour; // 0x30
		// [Tooltip] // 0x0000000189A92E60-0x0000000189A92E90
		public Color m_unfitColour; // 0x40
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public Spawner m_spawner; // 0x50
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public Vector3 m_lastHitPoint; // 0x58
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public string m_lastHitObjectname; // 0x68
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public float m_lastHitFitness; // 0x70
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public float m_lastHitHeight; // 0x74
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public float m_lastHitTerrainHeight; // 0x78
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public float m_lastHitTerrainRelativeHeight; // 0x7C
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public float m_lastHitTerrainSlope; // 0x80
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public float m_lastHitAreaSlope; // 0x84
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public bool m_lastHitWasVirgin; // 0x88
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public GaiaConstants.SpawnerResourceType m_selectedResourceType; // 0x8C
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public int m_selectedResourceIdx; // 0x90
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		private DateTime m_lastCacheUpdateDate; // 0x98
		private UnityHeightMap m_terrainHeightMap; // 0xA8
	
		// Constructors
		public ResourceVisualiser() {} // 0x0000000185A06F40-0x0000000185A07020
	
		// Methods
		// [XID] // 0x00000001899A5360-0x00000001899A5380
		private void Awake() {} // 0x0000000185A05040-0x0000000185A05100
		// [XID] // 0x0000000189B05550-0x0000000189B05570
		private void OnEnable() {} // 0x0000000185A06DC0-0x0000000185A06E60
		// [XID] // 0x0000000189818990-0x00000001898189B0
		public void Initialise() {} // 0x0000000185A05F60-0x0000000185A06140
		// [XID] // 0x0000000189B141B0-0x0000000189B141D0
		public void Visualise() {} // 0x0000000185A06E60-0x0000000185A06F40
		// [XID] // 0x0000000189B1B9C0-0x0000000189B1B9E0
		public SpawnInfo GetSpawnInfo(Vector3 location) => default; // 0x0000000185A05D60-0x0000000185A05F60
		// [XID] // 0x0000000189B22F90-0x0000000189B22FB0
		public float GetFitness(ref SpawnInfo spawnInfo) => default; // 0x0000000185A05100-0x0000000185A054B0
		// [XID] // 0x0000000189B2A640-0x0000000189B2A660
		public float GetMinFitness(ref SpawnInfo spawnInfo) => default; // 0x0000000185A05890-0x0000000185A05D60
		// [XID] // 0x0000000189B31B70-0x0000000189B31B90
		public float GetMaxScaledRadius(ref SpawnInfo spawnInfo) => default; // 0x0000000185A054B0-0x0000000185A05890
		// [XID] // 0x000000018986E3F0-0x000000018986E410
		private void OnDrawGizmosSelected() {} // 0x0000000185A06140-0x0000000185A06DC0
	}
}
