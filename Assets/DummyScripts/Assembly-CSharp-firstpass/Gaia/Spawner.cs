/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
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
	[ExecuteInEditMode] // 0x00000001897B1BA0-0x00000001897B1BB0
	public class Spawner : MonoBehaviour // TypeDefIndex: 9310
	{
		// Fields
		[fsIgnore] // 0x00000001898A5BB0-0x00000001898A5BC0
		public GaiaResource m_resources; // 0x18
		public string m_resourcesPath; // 0x20
		public string m_spawnerID; // 0x28
		public GaiaConstants.OperationMode m_mode; // 0x30
		public int m_seed; // 0x34
		public GaiaConstants.SpawnerShape m_spawnerShape; // 0x38
		public GaiaConstants.SpawnerRuleSelector m_spawnRuleSelector; // 0x3C
		public GaiaConstants.SpawnerLocation m_spawnLocationAlgorithm; // 0x40
		public GaiaConstants.SpawnerLocationCheckType m_spawnLocationCheckType; // 0x44
		public float m_locationIncrement; // 0x48
		public float m_maxJitteredLocationOffsetPct; // 0x4C
		public int m_locationChecksPerInt; // 0x50
		public int m_maxRandomClusterSize; // 0x54
		public float m_spawnRange; // 0x58
		public AnimationCurve m_spawnFitnessAttenuator; // 0x60
		public GaiaConstants.ImageFitnessFilterMode m_areaMaskMode; // 0x68
		public bool m_enableColliderCacheAtRuntime; // 0x6C
		public Texture2D m_imageMask; // 0x70
		public bool m_imageMaskInvert; // 0x78
		public bool m_imageMaskNormalise; // 0x79
		public bool m_imageMaskFlip; // 0x7A
		public int m_imageMaskSmoothIterations; // 0x7C
		[fsIgnore] // 0x00000001898A5BB0-0x00000001898A5BC0
		public HeightMap m_imageMaskHM; // 0x80
		private FractalGenerator m_noiseGenerator; // 0x88
		public float m_noiseMaskSeed; // 0x90
		public int m_noiseMaskOctaves; // 0x94
		public float m_noiseMaskPersistence; // 0x98
		public float m_noiseMaskFrequency; // 0x9C
		public float m_noiseMaskLacunarity; // 0xA0
		public float m_noiseZoom; // 0xA4
		public bool m_noiseInvert; // 0xA8
		public float m_spawnInterval; // 0xAC
		public string m_triggerTags; // 0xB0
		public float m_triggerRange; // 0xB8
		public List<SpawnRule> m_spawnerRules; // 0xC0
		public LayerMask m_spawnCollisionLayers; // 0xC8
		public int m_spawnColliderLayer; // 0xCC
		public bool m_showGizmos; // 0xD0
		public bool m_showDebug; // 0xD1
		public bool m_showStatistics; // 0xD2
		public bool m_showTerrainHelper; // 0xD3
		public XorshiftPlus m_rndGenerator; // 0xD8
		private XorshiftPlus m_rndSubGenerator; // 0xE0
		private bool m_cacheDetails; // 0xE8
		private Dictionary<int, List<HeightMap>> m_detailMapCache; // 0xF0
		private bool m_cacheTextures; // 0xF8
		private Dictionary<int, List<HeightMap>> m_textureMapCache; // 0x100
		private bool m_cacheTags; // 0x108
		private Dictionary<string, Quadtree<GameObject>> m_taggedGameObjectCache; // 0x110
		private bool m_cacheHeightMaps; // 0x118
		private bool m_heightMapDirty; // 0x119
		private Dictionary<int, UnityHeightMap> m_heightMapCache; // 0x120
		private Dictionary<string, HeightMap> m_stampCache; // 0x128
		[fsIgnore] // 0x00000001898A5BB0-0x00000001898A5BC0
		public GameObject m_areaBoundsColliderCache; // 0x130
		[fsIgnore] // 0x00000001898A5BB0-0x00000001898A5BC0
		public GameObject m_goColliderCache; // 0x138
		[fsIgnore] // 0x00000001898A5BB0-0x00000001898A5BC0
		public GameObject m_goParentGameObject; // 0x140
		private bool m_cancelSpawn; // 0x148
		public int m_totalRuleCnt; // 0x14C
		public int m_activeRuleCnt; // 0x150
		public int m_inactiveRuleCnt; // 0x154
		public ulong m_maxInstanceCnt; // 0x158
		public ulong m_activeInstanceCnt; // 0x160
		public ulong m_inactiveInstanceCnt; // 0x168
		public ulong m_totalInstanceCnt; // 0x170
		private float m_terrainHeight; // 0x178
		private float m_checkDistance; // 0x17C
		private RaycastHit m_checkHitInfo; // 0x180
		public IEnumerator m_updateCoroutine; // 0x1C0
		public float m_updateTimeAllowed; // 0x1C8
		public float m_spawnProgress; // 0x1CC
		public bool m_spawnComplete; // 0x1D0
		public Bounds m_spawnerBounds; // 0x1D4
		private bool m_isTextureSpawner; // 0x1EC
		private bool m_isDetailSpawner; // 0x1ED
		private bool m_isTreeSpawnwer; // 0x1EE
		private bool m_isGameObjectSpawner; // 0x1EF
		private bool m_fitToTerrainPending; // 0x1F0
	
		// Nested types
		private class SpawnLocation // TypeDefIndex: 9311
		{
			// Fields
			public Vector3 m_location; // 0x10
			public float m_seedDistance; // 0x1C
	
			// Constructors
			public SpawnLocation() {} // 0x0000000186448760-0x00000001864487C0
		}
	
		// Constructors
		public Spawner() {} // 0x0000000185A1C500-0x0000000185A1C970
	
		// Methods
		// [XID] // 0x00000001899993F0-0x0000000189999410
		public void OnCreateNewSpawner() {} // 0x0000000185A18FC0-0x0000000185A19070
		// [XID] // 0x00000001899A0D10-0x00000001899A0D30
		public bool IsGrassSpawner() => default; // 0x0000000185A17ED0-0x0000000185A17F80
		// [XID] // 0x00000001899A8640-0x00000001899A8660
		private void OnEnable() {} // 0x0000000185A19760-0x0000000185A19880
		// [XID] // 0x0000000189B8E0C0-0x0000000189B8E0E0
		private void OnDisable() {} // 0x0000000185A19070-0x0000000185A19110
		// [XID] // 0x0000000189A4E250-0x0000000189A4E270
		public void StartEditorUpdates() {} // 0x0000000185A1BAA0-0x0000000185A1BB40
		// [XID] // 0x0000000189B95520-0x0000000189B95540
		public void StopEditorUpdates() {} // 0x0000000185A1BD70-0x0000000185A1BE10
		// [XID] // 0x0000000189B9CBB0-0x0000000189B9CBD0
		private void EditorUpdate() {} // 0x0000000185A15570-0x0000000185A15630
		// [XID] // 0x00000001899CDC90-0x00000001899CDCB0
		private void Start() {} // 0x0000000185A1BB40-0x0000000185A1BD70
		// [XID] // 0x00000001899D5280-0x00000001899D52A0
		public void Initialise() {} // 0x0000000185A16F80-0x0000000185A17AA0
		// [XID] // 0x000000018996B0B0-0x000000018996B0D0
		private void PreSpawnInitialise() {} // 0x0000000185A19920-0x0000000185A199C0
		// [XID] // 0x00000001898A3150-0x00000001898A3170
		public void SetUpSpawnerTypeFlags() {} // 0x0000000185A1B6D0-0x0000000185A1B9A0
		// [XID] // 0x0000000189957A80-0x0000000189957AA0
		public void AssociateAssets() {} // 0x0000000185A10410-0x0000000185A10580
		// [XID] // 0x00000001899F32A0-0x00000001899F32C0
		public int[] GetMissingResources() => default; // 0x0000000185A16460-0x0000000185A16620
		// [XID] // 0x00000001899FA9E0-0x00000001899FAA00
		public void AddResourcesToTerrain(int[] rules) {} // 0x0000000185A0FFB0-0x0000000185A10150
		// [XID] // 0x0000000189A01B60-0x0000000189A01B80
		private void ForceSpawnAllGrass() {} // 0x0000000185A159B0-0x0000000185A15A50
		// [XID] // 0x0000000189A09580-0x0000000189A095A0
		private void PostSpawn() {} // 0x0000000185A19880-0x0000000185A19920
		// [XID] // 0x0000000189A10B90-0x0000000189A10BB0
		public bool IsTextureSpawner() => default; // 0x0000000185A18030-0x0000000185A180E0
		// [XID] // 0x00000001897C61D0-0x00000001897C61F0
		public bool IsDetailSpawner() => default; // 0x0000000185A17AA0-0x0000000185A17B50
		// [XID] // 0x0000000189A1F7B0-0x0000000189A1F7D0
		public bool IsTreeSpawner() => default; // 0x0000000185A180E0-0x0000000185A18190
		// [XID] // 0x0000000189810E80-0x0000000189810EA0
		public bool IsGameObjectSpawner() => default; // 0x0000000185A17E20-0x0000000185A17ED0
		// [XID] // 0x0000000189AD4960-0x0000000189AD4980
		public void ResetSpawner() {} // 0x0000000185A19A90-0x0000000185A19B30
		// [XID] // 0x0000000189A35B40-0x0000000189A35B60
		public void CancelSpawn() {} // 0x0000000185A11540-0x0000000185A115F0
		// [XID] // 0x0000000189ADB190-0x0000000189ADB1B0
		public bool IsSpawning() => default; // 0x0000000185A17F80-0x0000000185A18030
		// [XID] // 0x0000000189A44A80-0x0000000189A44AA0
		private bool CanSpawnInstances() => default; // 0x0000000185A11400-0x0000000185A11540
		// [XID] // 0x00000001897166A0-0x00000001897166C0
		public void RunSpawnerIteration() {} // 0x0000000185A19CD0-0x0000000185A1A520
		[DebuggerHidden] // 0x0000000189A53950-0x0000000189A53990
		// [XID] // 0x0000000189A53950-0x0000000189A53990
		public IEnumerator RunRandomSpawnerIteration() => default; // 0x0000000185A19C00-0x0000000185A19CD0
		[DebuggerHidden] // 0x0000000189A5E3E0-0x0000000189A5E420
		// [XID] // 0x0000000189A5E3E0-0x0000000189A5E420
		public IEnumerator RunAreaSpawnerIteration() => default; // 0x0000000185A19B30-0x0000000185A19C00
		// [XID] // 0x0000000189BAB870-0x0000000189BAB890
		public void GroundToTerrain() {} // 0x0000000185A16CA0-0x0000000185A16F80
		// [XID] // 0x0000000189A70350-0x0000000189A70370
		public void FitToTerrain() {} // 0x0000000185A15630-0x0000000185A158B0
		// [XID] // 0x0000000189A77BC0-0x0000000189A77BE0
		public bool IsFitToTerrain() => default; // 0x0000000185A17B50-0x0000000185A17E20
		// [XID] // 0x0000000189A7F120-0x0000000189A7F140
		public bool LoadImageMask() => default; // 0x0000000185A18190-0x0000000185A18FC0
		// [IDTag] // 0x0000000189A86C80-0x0000000189A86CC0
		// [XID] // 0x0000000189A86C80-0x0000000189A86CC0
		public void CreateSpawnCaches() {} // 0x0000000185A142B0-0x0000000185A146A0
		// [IDTag] // 0x0000000189A916C0-0x0000000189A91700
		// [XID] // 0x0000000189A916C0-0x0000000189A91700
		public void CreateSpawnCaches(GaiaConstants.SpawnerResourceType resourceType, int resourceIdx) {} // 0x0000000185A146A0-0x0000000185A14D50
		// [XID] // 0x0000000189A9BD70-0x0000000189A9BD90
		public void DeleteSpawnCaches(bool flushDirty = false /* Metadata: 0x00AE574F */, bool saveTextureToTerrainBeforeDelete = true /* Metadata: 0x00AE5750 */) {} // 0x0000000185A150C0-0x0000000185A15400
		// [XID] // 0x0000000189AA3300-0x0000000189AA3320
		public bool TryExecuteRule(ref SpawnRule rule, ref SpawnInfo spawnInfo) => default; // 0x0000000185A1BE10-0x0000000185A1C2E0
		// [XID] // 0x0000000189AAA740-0x0000000189AAA760
		public bool CheckLocation(Vector3 locationWU, ref SpawnInfo spawnInfo) => default; // 0x0000000185A13350-0x0000000185A14130
		// [XID] // 0x00000001899B0A50-0x00000001899B0A70
		public bool CheckLocationBounds(ref SpawnInfo spawnInfo, float distance) => default; // 0x0000000185A115F0-0x0000000185A13350
		// [XID] // 0x0000000189827A30-0x0000000189827A50
		public void UpdateCounters() {} // 0x0000000185A1C2E0-0x0000000185A1C500
		// [XID] // 0x0000000189AC16A0-0x0000000189AC16C0
		private void OnDrawGizmosSelected() {} // 0x0000000185A19110-0x0000000185A19760
		// [XID] // 0x000000018973F200-0x000000018973F220
		public void CacheTextureMapsFromTerrain(int terrainID) {} // 0x0000000185A11050-0x0000000185A11400
		// [XID] // 0x0000000189A97450-0x0000000189A97470
		public List<HeightMap> GetTextureMaps(int terrainID) => default; // 0x0000000185A16BB0-0x0000000185A16CA0
		// [XID] // 0x000000018995AA50-0x000000018995AA70
		public void SaveTextureMapsToTerrain(int terrainID) {} // 0x0000000185A1AF80-0x0000000185A1B480
		// [XID] // 0x0000000189BBA1C0-0x0000000189BBA1E0
		public void DeleteTextureMapCache() {} // 0x0000000185A154A0-0x0000000185A15570
		// [XID] // 0x0000000189B850D0-0x0000000189B850F0
		public void SetTextureMapsDirty() {} // 0x0000000185A1B630-0x0000000185A1B6D0
		// [XID] // 0x0000000189AEF3B0-0x0000000189AEF3D0
		public void CacheDetailMapsFromTerrain(int terrainID) {} // 0x0000000185A10580-0x0000000185A108A0
		// [XID] // 0x0000000189884290-0x00000001898842B0
		public void SaveDetailMapsToTerrain(int terrainID) {} // 0x0000000185A1A520-0x0000000185A1AD40
		// [XID] // 0x0000000189AFDD30-0x0000000189AFDD50
		public List<HeightMap> GetDetailMaps(int terrainID) => default; // 0x0000000185A16280-0x0000000185A16370
		// [XID] // 0x0000000189B05530-0x0000000189B05550
		public HeightMap GetDetailMap(int terrainID, int detailIndex) => default; // 0x0000000185A16140-0x0000000185A16280
		// [XID] // 0x00000001898847B0-0x00000001898847D0
		public void DeleteDetailMapCache() {} // 0x0000000185A14F20-0x0000000185A14FF0
		// [XID] // 0x000000018995C140-0x000000018995C160
		public void AddToSession(GaiaOperation.OperationType opType, string opName) {} // 0x0000000185A10150-0x0000000185A10410
		// [XID] // 0x00000001898C76C0-0x00000001898C76E0
		public string SerialiseJson() => default; // 0x0000000185A1B480-0x0000000185A1B590
		// [XID] // 0x0000000189948CC0-0x0000000189948CE0
		public void DeSerialiseJson(string json) {} // 0x0000000185A14D50-0x0000000185A14F20
		// [XID] // 0x0000000189B2A620-0x0000000189B2A640
		public void FlattenTerrain() {} // 0x0000000185A158B0-0x0000000185A159B0
		// [XID] // 0x0000000189B31B50-0x0000000189B31B70
		public void SmoothTerrain() {} // 0x0000000185A1B9A0-0x0000000185A1BAA0
		// [XID] // 0x0000000189799690-0x00000001897996B0
		public void ClearTrees() {} // 0x0000000185A141F0-0x0000000185A142B0
		// [XID] // 0x0000000189B40C30-0x0000000189B40C50
		public void ClearDetails() {} // 0x0000000185A14130-0x0000000185A141F0
		// [XID] // 0x00000001896B4E30-0x00000001896B4E50
		public void CacheHeightMapFromTerrain(int terrainID) {} // 0x0000000185A108A0-0x0000000185A10A90
		// [XID] // 0x0000000189825EE0-0x0000000189825F00
		public UnityHeightMap GetHeightMap(int terrainID) => default; // 0x0000000185A16370-0x0000000185A16460
		// [XID] // 0x0000000189B57340-0x0000000189B57360
		public void SaveHeightMapToTerrain(int terrainID) {} // 0x0000000185A1AD40-0x0000000185A1AF80
		// [XID] // 0x0000000189B5ED50-0x0000000189B5ED70
		public void DeleteHeightMapCache() {} // 0x0000000185A14FF0-0x0000000185A150C0
		// [XID] // 0x00000001895F42D0-0x00000001895F42F0
		public void SetHeightMapsDirty() {} // 0x0000000185A1B590-0x0000000185A1B630
		// [XID] // 0x0000000189A03FE0-0x0000000189A04000
		public void CacheStamps(List<string> stampList) {} // 0x0000000185A10A90-0x0000000185A10BA0
		// [XID] // 0x00000001898930D0-0x00000001898930F0
		private void CacheTaggedGameObjectsFromScene(List<string> tagList) {} // 0x0000000185A10BA0-0x0000000185A11050
		// [XID] // 0x000000018988BA40-0x000000018988BA60
		private void DeleteTagCache() {} // 0x0000000185A15400-0x0000000185A154A0
		// [XID] // 0x0000000189B84220-0x0000000189B84240
		public List<GameObject> GetNearbyObjects(List<string> tagList, Rect area) => default; // 0x0000000185A16620-0x0000000185A168E0
		// [IDTag] // 0x0000000189B8B030-0x0000000189B8B070
		// [XID] // 0x0000000189B8B030-0x0000000189B8B070
		public GameObject GetClosestObject(List<string> tagList, Rect area) => default; // 0x0000000185A15A50-0x0000000185A15E10
		// [IDTag] // 0x0000000189B95800-0x0000000189B95840
		// [XID] // 0x0000000189B95800-0x0000000189B95840
		public GameObject GetClosestObject(string tag, Rect area) => default; // 0x0000000185A15E10-0x0000000185A16140
		// [XID] // 0x00000001899B4610-0x00000001899B4630
		public void ResetRandomGenertor() {} // 0x0000000185A199C0-0x0000000185A19A90
		// [XID] // 0x0000000189A17FB0-0x0000000189A17FD0
		public int GetRandomInt(int min, int max) => default; // 0x0000000185A169C0-0x0000000185A16AA0
		// [XID] // 0x0000000189BAE630-0x0000000189BAE650
		public float GetRandomFloat(float min, float max) => default; // 0x0000000185A168E0-0x0000000185A169C0
		// [XID] // 0x0000000189BB5E90-0x0000000189BB5EB0
		public Vector3 GetRandomV3(float range) => default; // 0x0000000185A16AA0-0x0000000185A16BB0
	}
}
