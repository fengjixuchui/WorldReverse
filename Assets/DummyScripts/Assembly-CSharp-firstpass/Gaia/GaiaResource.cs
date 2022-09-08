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
	public class GaiaResource : ScriptableObject // TypeDefIndex: 9283
	{
		// Fields
		[HideInInspector] // 0x000000018980D5F0-0x000000018980D640
		// [Tooltip] // 0x000000018980D5F0-0x000000018980D640
		public string m_resourcesID; // 0x18
		// [Tooltip] // 0x0000000189819B30-0x0000000189819B60
		public string m_name; // 0x20
		// [Tooltip] // 0x00000001898226F0-0x0000000189822720
		public float m_seaLevel; // 0x28
		// [Tooltip] // 0x000000018982B730-0x000000018982B760
		public float m_beachHeight; // 0x2C
		// [Tooltip] // 0x0000000189834480-0x00000001898344B0
		public float m_terrainHeight; // 0x30
		// [Tooltip] // 0x000000018983D240-0x000000018983D270
		public ResourceProtoTexture[] m_texturePrototypes; // 0x38
		// [Tooltip] // 0x0000000189845FB0-0x0000000189845FE0
		public ResourceProtoDetail[] m_detailPrototypes; // 0x40
		// [Tooltip] // 0x000000018984EF00-0x000000018984EF30
		public ResourceProtoTree[] m_treePrototypes; // 0x48
		// [Tooltip] // 0x0000000189857660-0x0000000189857690
		public ResourceProtoGameObject[] m_gameObjectPrototypes; // 0x50
	
		// Constructors
		public GaiaResource() {} // 0x00000001865979A0-0x0000000186597AF0
	
		// Methods
		// [XID] // 0x000000018977EB80-0x000000018977EBA0
		public bool SetAssetAssociations() => default; // 0x00000001865956B0-0x0000000186595990
		// [XID] // 0x0000000189867AB0-0x0000000189867AD0
		public bool AssociateAssets() => default; // 0x0000000186590370-0x0000000186590650
		// [XID] // 0x000000018986F160-0x000000018986F180
		public void DeletePrototypes() {} // 0x00000001865940C0-0x00000001865941E0
		// [XID] // 0x0000000189876630-0x0000000189876650
		public bool PrototypesMissingFromTerrain() => default; // 0x0000000186594F20-0x00000001865951A0
		// [XID] // 0x000000018987E350-0x000000018987E370
		public bool PrototypeMissingFromTerrain(GaiaConstants.SpawnerResourceType resourceType, int resourceIdx) => default; // 0x0000000186594E40-0x0000000186594F20
		// [XID] // 0x000000018974F110-0x000000018974F130
		public int PrototypeIdxInTerrain(GaiaConstants.SpawnerResourceType resourceType, int resourceIdx) => default; // 0x00000001865949D0-0x0000000186594E40
		// [XID] // 0x0000000189B7E9E0-0x0000000189B7EA00
		public bool ResourceIdxOutOfBounds(GaiaConstants.SpawnerResourceType resourceType, int resourceIdx) => default; // 0x00000001865951A0-0x00000001865952E0
		// [XID] // 0x0000000189893E00-0x0000000189893E20
		public bool ResourceIsInUnity(GaiaConstants.SpawnerResourceType resourceType, int resourceIdx) => default; // 0x00000001865952E0-0x00000001865955A0
		// [XID] // 0x00000001899CE530-0x00000001899CE550
		public void UpdatePrototypesFromTerrain() {} // 0x0000000186595D20-0x00000001865979A0
		// [XID] // 0x00000001896FFF60-0x00000001896FFF80
		private string GetUniqueName(string name, ref Dictionary<string, string> names) => default; // 0x0000000186594850-0x00000001865949D0
		// [XID] // 0x00000001898A9F80-0x00000001898A9FA0
		private void UpdateDNA(GameObject prefab, ref ResourceProtoDNA dna) {} // 0x0000000186595990-0x0000000186595D20
		// [XID] // 0x00000001898B18D0-0x00000001898B18F0
		public void ChangeHeight(float oldHeight, float newHeight) {} // 0x0000000186590650-0x0000000186590A30
		// [IDTag] // 0x00000001898B9420-0x00000001898B9460
		// [XID] // 0x00000001898B9420-0x00000001898B9460
		public void ChangeSeaLevel(float newSeaLevel) {} // 0x0000000186590A30-0x0000000186590AF0
		// [IDTag] // 0x00000001898C3730-0x00000001898C3770
		// [XID] // 0x00000001898C3730-0x00000001898C3770
		public void ChangeSeaLevel(float oldSeaLevel, float newSeaLevel) {} // 0x0000000186590AF0-0x0000000186590F40
		// [IDTag] // 0x00000001898CDE20-0x00000001898CDE60
		// [XID] // 0x00000001898CDE20-0x00000001898CDE60
		public void ApplyPrototypesToTerrain() {} // 0x000000018658FA20-0x000000018658FB20
		// [IDTag] // 0x00000001898D8730-0x00000001898D8770
		// [XID] // 0x00000001898D8730-0x00000001898D8770
		public void ApplyPrototypesToTerrain(Terrain terrain) {} // 0x000000018658FB20-0x0000000186590370
		// [IDTag] // 0x00000001898E3340-0x00000001898E3380
		// [XID] // 0x00000001898E3340-0x00000001898E3380
		public void AddMissingPrototypesToTerrain() {} // 0x000000018658F1D0-0x000000018658F2D0
		// [IDTag] // 0x00000001898EDEB0-0x00000001898EDEF0
		// [XID] // 0x00000001898EDEB0-0x00000001898EDEF0
		public void AddMissingPrototypesToTerrain(Terrain terrain) {} // 0x000000018658E670-0x000000018658F1D0
		// [IDTag] // 0x00000001898F8910-0x00000001898F8950
		// [XID] // 0x00000001898F8910-0x00000001898F8950
		public void AddPrototypeToTerrain(GaiaConstants.SpawnerResourceType resourceType, int resourceIdx) {} // 0x000000018658F2D0-0x000000018658F400
		// [IDTag] // 0x0000000189903090-0x00000001899030D0
		// [XID] // 0x0000000189903090-0x00000001899030D0
		public void AddPrototypeToTerrain(GaiaConstants.SpawnerResourceType resourceType, int resourceIdx, Terrain terrain) {} // 0x000000018658F400-0x000000018658FA20
		// [XID] // 0x000000018990D940-0x000000018990D960
		public bool ChecksTextures() => default; // 0x00000001865911D0-0x0000000186591460
		// [XID] // 0x000000018993CB30-0x000000018993CB50
		public bool ChecksProximity() => default; // 0x0000000186590F40-0x00000001865911D0
		// [IDTag] // 0x000000018991CC50-0x000000018991CC90
		// [XID] // 0x000000018991CC50-0x000000018991CC90
		public void AddGameObject(GameObject prefab) {} // 0x000000018658E470-0x000000018658E580
		// [IDTag] // 0x0000000189927280-0x00000001899272C0
		// [XID] // 0x0000000189927280-0x00000001899272C0
		public void AddGameObject(List<GameObject> prototypes) {} // 0x000000018658E580-0x000000018658E670
		// [XID] // 0x00000001899317D0-0x00000001899317F0
		public GameObject CreateCoverageTextureSpawner(float range) => default; // 0x0000000186593010-0x00000001865936B0
		// [XID] // 0x000000018978D8D0-0x000000018978D8F0
		public GameObject CreateCoverageDetailSpawner(float range) => default; // 0x0000000186592400-0x0000000186592B10
		// [XID] // 0x0000000189940690-0x00000001899406B0
		public GameObject CreateOrFindGaia() => default; // 0x0000000186593C00-0x0000000186593D00
		// [XID] // 0x0000000189947E10-0x0000000189947E30
		public GameObject CreateOrFindSessionManager() => default; // 0x0000000186593EB0-0x0000000186593FA0
		// [XID] // 0x000000018994F3C0-0x000000018994F3E0
		public SpawnerGroup CreateOrFindGroupSpawner() => default; // 0x0000000186593D00-0x0000000186593EB0
		// [XID] // 0x00000001896B1430-0x00000001896B1450
		public GameObject CreateClusteredDetailSpawner(float range) => default; // 0x0000000186591460-0x00000001865919D0
		// [XID] // 0x0000000189AC60B0-0x0000000189AC60D0
		public GameObject CreateClusteredTreeSpawner(float range) => default; // 0x0000000186591EB0-0x0000000186592400
		// [XID] // 0x0000000189965D10-0x0000000189965D30
		public GameObject CreateCoverageTreeSpawner(float range) => default; // 0x00000001865936B0-0x0000000186593C00
		// [XID] // 0x000000018996D2F0-0x000000018996D310
		public GameObject CreateCoverageGameObjectSpawner(float range) => default; // 0x0000000186592B10-0x0000000186593010
		// [XID] // 0x00000001896F85C0-0x00000001896F85E0
		public GameObject CreateClusteredGameObjectSpawner(float range) => default; // 0x00000001865919D0-0x0000000186591EB0
		// [XID] // 0x00000001897A4630-0x00000001897A4650
		public void ExportTexture() {} // 0x00000001865941E0-0x0000000186594850
		// [XID] // 0x0000000189983D90-0x0000000189983DB0
		public string SerialiseJson() => default; // 0x00000001865955A0-0x00000001865956B0
		// [XID] // 0x000000018998B7A0-0x000000018998B7C0
		public void DeSerialiseJson(string json) {} // 0x0000000186593FA0-0x00000001865940C0
	}
}
