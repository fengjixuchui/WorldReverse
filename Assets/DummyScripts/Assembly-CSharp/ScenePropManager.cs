/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ScenePropManager : InLevelManager, IWorldShiftAgent // TypeDefIndex: 20995
{
	// Fields
	public ScenePropEffectConfigs _scenePropEffectConfigs; // 0x10
	private uint _scenePropEffectConfigsHandle; // 0x18
	public SceneChairConfigs _sceneChairConfigs; // 0x20
	private uint _sceneChairConfigsHandle; // 0x28
	public SceneBushConfigs _sceneBushConfigs; // 0x30
	private uint _sceneBushConfigsHandle; // 0x38
	public SceneTreeConfigs _sceneTreeConfigs; // 0x40
	private uint _sceneTreeConfigsHandle; // 0x48
	private Dictionary<int, ZOrderCollection<ZOrder96, Vector3, ICombatSceneProp>> _treeBushCollection; // 0x50
	private List<ICombatSceneProp> _treeBushList; // 0x58
	private Dictionary<int, Vector3> _treeBushId2Pos; // 0x60
	private Vector3 _rangeQueryLen; // 0x68
	private Dictionary<int, ICombatSceneProp> _scenePropDict; // 0x78
	private Dictionary<int, TreeType> _treeTypeDict; // 0x80
	private List<MonoEnviroLight> _pointLights; // 0x88
	private List<MonoEnviroCityLight> _cityLights; // 0x90
	private Vector3 _lastSectorPos; // 0x98
	private const int MAX_TREE_NUM = 512; // Metadata: 0x00AFEC35
	private TreeLeafInfo[] _treeLeafInfos; // 0xA8
	private int _treeLeafNum; // 0xB0
	private MaterialPropertyBlock _mpb; // 0xB8
	private Camera _mainCam; // 0xC0
	private List<UnityEngine.Material> _leafDitherMaterials; // 0xC8
	private Dictionary<int, Vector3[]> _shakeAnims; // 0xD0
	private List<ICombatSceneProp> _playingScenePropShakes; // 0xD8
	private List<IChair> _chairs; // 0xE0
	private const int IterateRoundsPerSecond = 7; // Metadata: 0x00AFEC39
	public GameObject iceBlockRoot; // 0xE8
	public GameObject _surfaceMeshObjectRoot; // 0xF0

	// Properties
	public ScenePropEffectConfigs scenePropEffectConfigs { /* [XID] */ /* 0x0000000189810FB0-0x0000000189810FD0 */ get => default; } // 0x0000000181CAD4F0-0x0000000181CAD6A0 
	public SceneChairConfigs sceneChairConfigs { /* [XID] */ /* 0x0000000189818B50-0x0000000189818B70 */ get => default; } // 0x0000000181CAB170-0x0000000181CAB320 
	public SceneBushConfigs sceneBushConfigs { /* [XID] */ /* 0x0000000189820370-0x0000000189820390 */ get => default; } // 0x0000000181CA9A70-0x0000000181CA9C20 
	public SceneTreeConfigs sceneTreeConfigs { /* [XID] */ /* 0x00000001898279F0-0x0000000189827A10 */ get => default; } // 0x0000000181CAF4D0-0x0000000181CAF680 
	public GameObject surfaceMeshObject { /* [XID] */ /* 0x00000001899952B0-0x00000001899952D0 */ get => default; } // 0x0000000181CAA320-0x0000000181CAA440 
	public GameObject surfaceMeshObjectRoot { /* [XID] */ /* 0x000000018999CD70-0x000000018999CD90 */ get => default; } // 0x0000000181CAA5F0-0x0000000181CAA760 

	// Nested types
	private class KeyExtractor : ZOrderCollection<ZOrder96, Vector3, ICombatSceneProp> // TypeDefIndex: 20996
	{
		// Constructors
		public KeyExtractor() {} // 0x0000000181CC0720-0x0000000181CC0780

		// Methods
		// [XID] // 0x00000001899B3860-0x00000001899B3880
		public Vector3 ExtractKey(ICombatSceneProp data) => default; // 0x0000000181CC05A0-0x0000000181CC0720
	}

	public struct TreeLeafInfo // TypeDefIndex: 20997
	{
		// Fields
		public Vector3 pos; // 0x00
		public bool isInitial; // 0x0C
		public MonoTreeLeaf treeLeafComponent; // 0x10

		// Constructors
		public TreeLeafInfo(MonoTreeLeaf tf) {
			pos = default;
			isInitial = default;
			treeLeafComponent = default;
		} // 0x0000000181CC0570-0x0000000181CC05A0
	}

	// Constructors
	public ScenePropManager() {} // 0x0000000181CAFBA0-0x0000000181CAFE30

	// Methods
	// [XID] // 0x000000018982EC10-0x000000018982EC30
	private void InitConfigs() {} // 0x0000000181CAEEA0-0x0000000181CAEF80
	// [XID] // 0x00000001898365B0-0x00000001898365D0
	private void ClearConfigs() {} // 0x0000000181CAD6A0-0x0000000181CAD7C0
	// [XID] // 0x000000018983D9A0-0x000000018983D9C0
	public void InitSceneTreeConfigs(string name = "SceneTreeConfigs" /* Metadata: 0x00AFEBDC */) {} // 0x0000000181CAD190-0x0000000181CAD340
	// [XID] // 0x0000000189845210-0x0000000189845230
	public void InitSceneChairConfigs(string name = "SceneChairConfigs" /* Metadata: 0x00AFEBF0 */) {} // 0x0000000181CA93F0-0x0000000181CA95A0
	// [XID] // 0x000000018984C6E0-0x000000018984C700
	public void InitSceneBushConfigs(string name = "SceneBushConfigs" /* Metadata: 0x00AFEC05 */) {} // 0x0000000181CAD340-0x0000000181CAD4F0
	// [XID] // 0x0000000189853760-0x0000000189853780
	public void InitScenePropEffectConfigs(string name = "ScenePropEffectConfigs" /* Metadata: 0x00AFEC19 */) {} // 0x0000000181CAA440-0x0000000181CAA5F0
	// [XID] // 0x000000018985B210-0x000000018985B230
	public override void Init() {} // 0x0000000181CAC8C0-0x0000000181CACA10
	// [XID] // 0x0000000189862750-0x0000000189862770
	private void InitTreeBushCollection() {} // 0x0000000181CAEF80-0x0000000181CAF160
	// [XID] // 0x0000000189869B20-0x0000000189869B40
	public void ClearTreeBushCollection() {} // 0x0000000181CAE270-0x0000000181CAE450
	// [XID] // 0x0000000189870EA0-0x0000000189870EC0
	public override void Tick() {} // 0x0000000181CAFA40-0x0000000181CAFBA0
	// [XID] // 0x0000000189878850-0x0000000189878870
	public override void Destroy() {} // 0x0000000181CAA930-0x0000000181CAAA30
	// [XID] // 0x000000018987FE00-0x000000018987FE20
	public void AddSceneProp(ISceneProp prop) {} // 0x0000000181CABDE0-0x0000000181CABFB0
	// [XID] // 0x0000000189887400-0x0000000189887420
	public void RemoveSceneProp(ISceneProp prop) {} // 0x0000000181CAA760-0x0000000181CAA930
	// [XID] // 0x000000018988E580-0x000000018988E5A0
	private void AddCombatSceneProp(ICombatSceneProp obj) {} // 0x0000000181CA8ED0-0x0000000181CA9250
	// [XID] // 0x0000000189895BE0-0x0000000189895C00
	private void RemoveCombatSceneProp(ICombatSceneProp obj) {} // 0x0000000181CA9D60-0x0000000181CA9F40
	// [XID] // 0x000000018989D220-0x000000018989D240
	public int GetScenePropRange(Vector3 center, float size, ScenePropBoxInfo[] buffer, uint maxCount, ScenePropType type) => default; // 0x0000000181CAD7C0-0x0000000181CAE270
	// [XID] // 0x00000001898A4B80-0x00000001898A4BA0
	private void InitTreeExcelConfig() {} // 0x0000000181CAE450-0x0000000181CAE6A0
	// [XID] // 0x00000001898AC040-0x00000001898AC060
	private void ReleaseTreeExcelConfig() {} // 0x0000000181CA9F40-0x0000000181CAA000
	// [XID] // 0x00000001898B3760-0x00000001898B3780
	public bool GetTreeTypeByPattern(string pattern, out TreeType treeType) {
		treeType = default;
		return default;
	} // 0x0000000181CAAEA0-0x0000000181CAAFB0
	// [XID] // 0x00000001898BB530-0x00000001898BB550
	private void AddTree(ICombatSceneProp obj) {} // 0x0000000181CAF250-0x0000000181CAF300
	// [XID] // 0x00000001898C27E0-0x00000001898C2800
	private void RemoveTree(ICombatSceneProp obj) {} // 0x0000000181CA9340-0x0000000181CA93F0
	// [XID] // 0x0000000189BAA2C0-0x0000000189BAA2E0
	public int GetTreeRange(Vector3 center, float size, ScenePropBoxInfo[] buffer, uint maxCount) => default; // 0x0000000181CAAC20-0x0000000181CAAD60
	// [XID] // 0x00000001898D1950-0x00000001898D1970
	public ICombatSceneProp GetSceneTree(int instanceId) => default; // 0x0000000181CA9250-0x0000000181CA9340
	// [XID] // 0x00000001898D9150-0x00000001898D9170
	private void AddBush(ICombatSceneProp obj) {} // 0x0000000181CACA10-0x0000000181CACAC0
	// [XID] // 0x00000001898E0DF0-0x00000001898E0E10
	private void RemoveBush(ICombatSceneProp obj) {} // 0x0000000181CAAA30-0x0000000181CAAAE0
	// [XID] // 0x00000001898E88E0-0x00000001898E8900
	public int GetBushRange(Vector3 center, float size, ScenePropBoxInfo[] buffer, uint maxCount) => default; // 0x0000000181CAAD60-0x0000000181CAAEA0
	// [XID] // 0x00000001898F0000-0x00000001898F0020
	public ICombatSceneProp GetSceneBush(int instanceId) => default; // 0x0000000181CAF160-0x0000000181CAF250
	// [XID] // 0x00000001898F78D0-0x00000001898F78F0
	private void AddLight(MonoEnviroLight obj) {} // 0x0000000181CAB940-0x0000000181CABA30
	// [XID] // 0x00000001898FEF70-0x00000001898FEF90
	private void RemoveLight(MonoEnviroLight obj) {} // 0x0000000181CAB750-0x0000000181CAB840
	// [XID] // 0x0000000189906770-0x0000000189906790
	public void EnableAllPointLights(bool enable) {} // 0x0000000181CA9920-0x0000000181CA9A70
	// [XID] // 0x000000018990E230-0x000000018990E250
	private void TickCityLights() {} // 0x0000000181CAF300-0x0000000181CAF4D0
	// [XID] // 0x00000001899159A0-0x00000001899159C0
	public void CheckAllCityLightDistance(Vector3 pos) {} // 0x0000000181CAED30-0x0000000181CAEEA0
	// [XID] // 0x000000018991D330-0x000000018991D350
	private void AddCityLight(MonoEnviroCityLight obj) {} // 0x0000000181CAAAE0-0x0000000181CAAC20
	// [XID] // 0x0000000189924CC0-0x0000000189924CE0
	private void RemoveCityLight(MonoEnviroCityLight obj) {} // 0x0000000181CA9C20-0x0000000181CA9D60
	// [XID] // 0x000000018992C1C0-0x000000018992C1E0
	private void AddTreeLeaf(MonoTreeLeaf treeLeaf) {} // 0x0000000181CACE10-0x0000000181CAD0C0
	// [XID] // 0x0000000189933640-0x0000000189933660
	private void RemoveTreeLeaf(MonoTreeLeaf treeLeaf) {} // 0x0000000181CABA30-0x0000000181CABDE0
	// [XID] // 0x000000018993B2F0-0x000000018993B310
	public void SetTreeLeafDirty(int idx) {} // 0x0000000181CAC560-0x0000000181CAC650
	// [XID] // 0x00000001899423E0-0x0000000189942400
	public void TickTreeLeaf() {} // 0x0000000181CAE6A0-0x0000000181CAED30
	// [XID] // 0x0000000189949D00-0x0000000189949D20
	private void InitScenePropShake() {} // 0x0000000181CABFB0-0x0000000181CAC560
	// [XID] // 0x00000001899518E0-0x0000000189951900
	public Vector3[] GetAnimationByMaterial(int material) => default; // 0x0000000181CAB840-0x0000000181CAB940
	// [XID] // 0x0000000189958E10-0x0000000189958E30
	public void RegisterScenePropShake(ICombatSceneProp shake) {} // 0x0000000181CAC650-0x0000000181CAC790
	// [XID] // 0x00000001899604E0-0x0000000189960500
	private void TickScenePropShake() {} // 0x0000000181CAA0D0-0x0000000181CAA320
	// [XID] // 0x0000000189967EA0-0x0000000189967EC0
	private void AddChair(IChair chair) {} // 0x0000000181CAA000-0x0000000181CAA0D0
	// [XID] // 0x000000018996F100-0x000000018996F120
	private void RemoveChair(IChair chair) {} // 0x0000000181CAD0C0-0x0000000181CAD190
	// [XID] // 0x0000000189976C50-0x0000000189976C70
	private void TickChair() {} // 0x0000000181CAB010-0x0000000181CAB170
	// [XID] // 0x00000001899C7CD0-0x00000001899C7CF0
	public void IterateSittableSitPoint(Vector3 position, ref int iterateIndex, out IChair iterateSittableChair, out SceneChairConfig.SitDownData iterateSittableSitData) {
		iterateSittableChair = default;
		iterateSittableSitData = default;
	} // 0x0000000181CA95A0-0x0000000181CA9920
	// [XID] // 0x0000000189B515A0-0x0000000189B515C0
	public void GetNearestSitPoint(Vector3 position, SceneChairConfig.SitDirection? direction, out IChair chair, out SceneChairConfig.SitDownData sitData, bool ignoreInteeDistance = true /* Metadata: 0x00AFEC33 */, bool ignoreOccupied = true /* Metadata: 0x00AFEC34 */) {
		chair = default;
		sitData = default;
	} // 0x0000000181CAB320-0x0000000181CAB750
	// [XID] // 0x000000018998D820-0x000000018998D840
	public void GetChairAndSitDownDataFromPos(Vector3 position, long id, out IChair chair, out SceneChairConfig.SitDownData sitData) {
		chair = default;
		sitData = default;
	} // 0x0000000181CACAC0-0x0000000181CACE10
	// [XID] // 0x00000001899A4610-0x00000001899A4630
	private void InitRoots() {} // 0x0000000181CAC790-0x0000000181CAC8C0
	// [XID] // 0x00000001899ABFF0-0x00000001899AC010
	public bool ShiftWorld(Vector3 newShift, Vector3 oldShift) => default; // 0x0000000181CAF680-0x0000000181CAFA40
}

