/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;
using UnityEngine;
using UnityEngine.Events;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class MapManager : InLevelManager // TypeDefIndex: 20959
{
	// Fields
	private MapScriptData _curLimitRegion; // 0x10
	private string _curLimitRegionName; // 0x18
	private bool _isCurActivityLimitRegion; // 0x20
	private bool _isCurHomeworldLimitRegion; // 0x21
	private Coroutine _curDestroyLimitRegionCoroutine; // 0x28
	private Dictionary<string, MapScriptData> _regions; // 0x30
	private Dictionary<string, uint> _regionHandles; // 0x38
	private Dictionary<string, ConfigPolygonArea> _polygonLimitRegions; // 0x40
	private ConfigPolygonArea _curPolygonLimitRegion; // 0x48
	private string _curPolygonLimitRegionName; // 0x50
	public GameObject mapObj; // 0x58
	public MonoLevelMapUI monoLevelMapUI; // 0x60
	private const string MAP_PREFAB_PATH = "ART/UI/UIScene/LevelMapUIManager"; // Metadata: 0x00AFE6FE
	private const string MAP_PREFAB_PATH_INTERIOR = "ART/UI/UIScene/LevelMapUIManagerInterior"; // Metadata: 0x00AFE722
	private const string MAP_PREFAB_PATH_EXTERIOR = "ART/UI/UIScene/LevelMapUIManagerExterior"; // Metadata: 0x00AFE74E
	private uint _mapContainerHandle; // 0x68
	public uint levelSceneID; // 0x6C
	public uint currSceneID; // 0x70
	private SceneScriptData _sceneDataInMap; // 0x78
	public MapScriptData mapData; // 0x80
	private string _currMapPrefabPath; // 0x88
	private bool _forceCurrentScene; // 0x90
	private uint _mapSceneIDSelected; // 0x94
	private bool DebugNewmap; // 0x98
	public string currMapString; // 0xA0
	public RectTransform currParent; // 0xA8
	public GameObject mapGameObjectInst; // 0xB0
	private uint _mapImageHandle; // 0xB8
	public MonoLevelMap levelMap; // 0xC0
	public float mainPageCheckDistance; // 0xC8
	private ColorState _currState; // 0xCC

	// Properties
	public MapScriptData curLimitRegion { /* [XID] */ /* 0x00000001899F3BB0-0x00000001899F3BD0 */ get => default; } // 0x00000001825564C0-0x0000000182556560 
	public ConfigPolygonArea curPolygonLimitRegion { /* [XID] */ /* 0x00000001899FB470-0x00000001899FB490 */ get => default; } // 0x0000000182554860-0x0000000182554900 

	// Nested types
	public enum ColorState // TypeDefIndex: 20960
	{
		None = 0,
		Morning = 1,
		Day = 2,
		Afternoon = 3,
		Night = 4,
		BadWeather = 5
	}

	// Constructors
	public MapManager() {} // 0x00000001825573F0-0x0000000182557550

	// Methods
	// [XID] // 0x00000001899E4CC0-0x00000001899E4CE0
	public override void Init() {} // 0x0000000182555DC0-0x0000000182555E60
	// [XID] // 0x00000001899EC190-0x00000001899EC1B0
	public override void Destroy() {} // 0x0000000182554260-0x0000000182554310
	// [XID] // 0x0000000189A026D0-0x0000000189A026F0
	private bool IsValidScene() => default; // 0x0000000182557060-0x0000000182557260
	// [XID] // 0x0000000189A09EA0-0x0000000189A09EC0
	private bool CheckNeedLimitRegion() => default; // 0x0000000182557260-0x00000001825573F0
	// [XID] // 0x0000000189A11700-0x0000000189A11720
	private void InitLimitRegion() {} // 0x0000000182556390-0x00000001825564C0
	// [XID] // 0x0000000189A18A70-0x0000000189A18A90
	public void OnLimitRegionChanged() {} // 0x00000001825546E0-0x0000000182554860
	// [XID] // 0x0000000189A20130-0x0000000189A20150
	private bool CreateLimitRegion(string name) => default; // 0x0000000182554A90-0x0000000182554F30
	// [XID] // 0x0000000189A274A0-0x0000000189A274C0
	private void DestroyLimitRegion(string name) {} // 0x0000000182556D70-0x0000000182557060
	[DebuggerHidden] // 0x0000000189A2ECE0-0x0000000189A2ED20
	// [XID] // 0x0000000189A2ECE0-0x0000000189A2ED20
	private IEnumerator DestroyLimitRegionCoroutine(string name, InLevelMapPageContext mapContext) => default; // 0x0000000182556560-0x00000001825566A0
	// [XID] // 0x0000000189A39410-0x0000000189A39430
	private void DestroyLimitRegionImpl(string name) {} // 0x0000000182556220-0x0000000182556390
	// [XID] // 0x0000000189A40BD0-0x0000000189A40BF0
	private void InitRegionWeight(string name, MapScriptData region) {} // 0x0000000182555210-0x0000000182555360
	// [XID] // 0x0000000189A48230-0x0000000189A48250
	public float GetLimitRegionDis(Vector3 pos, float radius) => default; // 0x0000000182555C20-0x0000000182555DC0
	// [XID] // 0x0000000189A4FAE0-0x0000000189A4FB00
	public Vector3 CheckNeedTrans(Vector3 pos, float offset) => default; // 0x0000000182553F40-0x0000000182554260
	// [XID] // 0x0000000189A57090-0x0000000189A570B0
	public bool IsInLimitRegion(Vector3 pos) => default; // 0x0000000182556C10-0x0000000182556D70
	// [XID] // 0x0000000189A5EC30-0x0000000189A5EC50
	private void ClearLimitRegion() {} // 0x0000000182554F30-0x0000000182555210
	// [XID] // 0x0000000189A66370-0x0000000189A66390
	public Vector2 UIPosToLevelPos(Vector2 uiPos) => default; // 0x0000000182553A10-0x0000000182553C20
	// [XID] // 0x0000000189A6DAC0-0x0000000189A6DAE0
	public Vector2 LevelPosToUIPos(Vector2 levelPos) => default; // 0x00000001825568C0-0x0000000182556AE0
	// [XID] // 0x0000000189A751F0-0x0000000189A75210
	public Vector2 LevelToUIScale() => default; // 0x0000000182554900-0x0000000182554A90
	// [XID] // 0x0000000189A7CE70-0x0000000189A7CE90
	public void LoadMapPrefab(UnityAction maploadedCallback) {} // 0x0000000182555950-0x0000000182555C20
	// [XID] // 0x0000000189A84760-0x0000000189A84780
	public void ToggleShowMap(bool toggle = false /* Metadata: 0x00AFE6F4 */) {} // 0x0000000182553C20-0x0000000182553D30
	// [XID] // 0x0000000189A8C0A0-0x0000000189A8C0C0
	public void ClearMap() {} // 0x0000000182555360-0x00000001825554F0
	// [IDTag] // 0x0000000189A93510-0x0000000189A93550
	// [XID] // 0x0000000189A93510-0x0000000189A93550
	public void RefreshMapData(bool needForceCurrentScene, uint mapSceneID = 3 /* Metadata: 0x00AFE6F5 */) {} // 0x0000000182554600-0x00000001825546E0
	// [IDTag] // 0x0000000189A9DB50-0x0000000189A9DB90
	// [XID] // 0x0000000189A9DB50-0x0000000189A9DB90
	private void RefreshMapData() {} // 0x0000000182554310-0x0000000182554600
	// [XID] // 0x0000000189AA8080-0x0000000189AA80A0
	public void InitMapData(bool needForceCurrentScene = true /* Metadata: 0x00AFE6F9 */, uint mapSceneID = 3 /* Metadata: 0x00AFE6FA */) {} // 0x0000000182556AE0-0x0000000182556C10
	// [XID] // 0x0000000189AAFC90-0x0000000189AAFCB0
	public void GetMapImage(UnityAction callback, RectTransform parent) {} // 0x00000001825554F0-0x0000000182555950
	// [XID] // 0x0000000189AB73D0-0x0000000189AB73F0
	private void CheckUnlock() {} // 0x00000001825566A0-0x00000001825568C0
	// [XID] // 0x0000000189ABEE30-0x0000000189ABEE50
	private void OnLoadMapImage() {} // 0x0000000182553D30-0x0000000182553F40
	// [XID] // 0x0000000189AC6950-0x0000000189AC6970
	public void UpdateColorFilter(bool reset, bool immediately) {} // 0x0000000182555E60-0x0000000182556220
}

