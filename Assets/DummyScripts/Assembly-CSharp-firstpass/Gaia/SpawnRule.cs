/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using Gaia.FullSerializer;
using IFix.Core;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace Gaia
{
	[Serializable]
	public class SpawnRule // TypeDefIndex: 9320
	{
		// Fields
		public string m_name; // 0x10
		public bool m_useExtendedSpawn; // 0x18
		public float m_minViableFitness; // 0x1C
		public float m_failureRate; // 0x20
		public ulong m_maxInstances; // 0x28
		public bool m_ignoreMaxInstances; // 0x30
		public float m_minDirection; // 0x34
		public float m_maxDirection; // 0x38
		public GaiaConstants.SpawnerResourceType m_resourceType; // 0x3C
		public int m_resourceIdx; // 0x40
		[fsIgnore] // 0x00000001898A5BB0-0x00000001898A5BC0
		public int m_resourceIdxPhysical; // 0x44
		[fsIgnore] // 0x00000001898A5BB0-0x00000001898A5BC0
		public Transform m_spawnParent; // 0x48
		[fsIgnore] // 0x00000001898A5BB0-0x00000001898A5BC0
		public string m_colliderName; // 0x50
		public GaiaConstants.NoiseType m_noiseMask; // 0x58
		public float m_noiseMaskSeed; // 0x5C
		public int m_noiseMaskOctaves; // 0x60
		public float m_noiseMaskPersistence; // 0x64
		public float m_noiseMaskFrequency; // 0x68
		public float m_noiseMaskLacunarity; // 0x6C
		public float m_noiseZoom; // 0x70
		public float m_noiseStrength; // 0x74
		public bool m_noiseInvert; // 0x78
		private FractalGenerator m_noiseGenerator; // 0x80
		public bool m_isActive; // 0x88
		public bool m_isFoldedOut; // 0x89
		public ulong m_currInstanceCnt; // 0x90
		public ulong m_activeInstanceCnt; // 0x98
		public ulong m_inactiveInstanceCnt; // 0xA0
		private ResourceVisualiser m_rv; // 0xA8
	
		// Constructors
		public SpawnRule() {} // 0x000000018644E950-0x000000018644EA40
	
		// Methods
		// [XID] // 0x00000001897B7AF0-0x00000001897B7B10
		public void Initialise(Spawner spawner) {} // 0x000000018644AFF0-0x000000018644BEA0
		// [XID] // 0x0000000189BB0B90-0x0000000189BB0BB0
		public bool ResourceIsInUnity(Spawner spawner) => default; // 0x000000018644C220-0x000000018644C300
		// [XID] // 0x00000001899A30F0-0x00000001899A3110
		public bool ResourceIsLoadedInTerrain(Spawner spawner) => default; // 0x000000018644C300-0x000000018644C3E0
		// [XID] // 0x00000001897CE750-0x00000001897CE770
		public void AddResourceToTerrain(Spawner spawner) {} // 0x0000000186449060-0x0000000186449130
		// [XID] // 0x000000018975C8F0-0x000000018975C910
		public float GetFitness(ref SpawnInfo spawnInfo) => default; // 0x0000000186449FC0-0x000000018644A770
		// [XID] // 0x0000000189AA3D20-0x0000000189AA3D40
		public float GetRadius(ref SpawnInfo spawnInfo) => default; // 0x000000018644AB50-0x000000018644ADA0
		// [XID] // 0x00000001897E4F30-0x00000001897E4F50
		public float GetMaxScaledRadius(ref SpawnInfo spawnInfo) => default; // 0x000000018644A770-0x000000018644AB50
		// [XID] // 0x0000000189A35A00-0x0000000189A35A20
		public float GetSeedThrowRange(ref SpawnInfo spawnInfo) => default; // 0x000000018644ADA0-0x000000018644AFF0
		// [XID] // 0x00000001897F4400-0x00000001897F4420
		public void Spawn(ref SpawnInfo spawnInfo) {} // 0x000000018644C3E0-0x000000018644E950
		// [XID] // 0x00000001897FBE90-0x00000001897FBEB0
		public bool CacheHeightMaps(Spawner spawner) => default; // 0x00000001864497F0-0x00000001864498A0
		// [XID] // 0x0000000189803290-0x00000001898032B0
		public bool CacheTextures(Spawner spawner) => default; // 0x0000000186449B00-0x0000000186449FC0
		// [XID] // 0x0000000189725640-0x0000000189725660
		public bool CacheDetails(Spawner spawner) => default; // 0x0000000186449130-0x00000001864497F0
		// [XID] // 0x0000000189BA93C0-0x0000000189BA93E0
		public bool CacheProximity(Spawner spawner) => default; // 0x00000001864498A0-0x0000000186449B00
		// [XID] // 0x0000000189765810-0x0000000189765830
		public void AddProximityTags(Spawner spawner, ref List<string> tagList) {} // 0x0000000186448DF0-0x0000000186449060
		// [XID] // 0x0000000189AAB2B0-0x0000000189AAB2D0
		public bool IsInsideResourceVisualiser(Vector3 worldPosition) => default; // 0x000000018644BEA0-0x000000018644C150
		// [XID] // 0x0000000189828860-0x0000000189828880
		private void PaintTerrainGrass(SpawnInfo spawnInfo, bool hasCached, float gaiaDetailDensity) {} // 0x000000018644C150-0x000000018644C220
	}
}
