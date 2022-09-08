/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using FullInspector;
using IFix.Core;
using UnityEngine;
using UnityEngine.UI;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public class MonoLevelMap : MonoSpriteProxy // TypeDefIndex: 31245
	{
		// Fields
		private const string DEFAULT_MAT_NAME = "UI_MapBack_None"; // Metadata: 0x00B120BC
		public static UnityEngine.Material _defaulMaterial; // 0x00
		public AreaFogConfig[] areaConfig; // 0x20
		public float fogAnimSpeed; // 0x28
		public float fogAreaAnimSpeed; // 0x2C
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private int _cellRectSize; // 0x30
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private int _cellSize; // 0x34
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _mapArea; // 0x38
		public Transform MapRoomAnchor; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _fogArea; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _guidArea; // 0x50
		public Animator placeNames; // 0x58
		public Animator areaNames; // 0x60
		public UnityEngine.UI.Text[] placeTextList; // 0x68
		public UnityEngine.UI.Text[] areaTextList; // 0x70
		public List<UnityEngine.UI.Text> exploreDegreeList; // 0x78
		private Dictionary<int, MapItem> id2PathDict; // 0x80
		private MapItem roomMapItem; // 0x88
		private Vector2 _viewSize; // 0x90
		private Color _curColor; // 0x98
		private Color _tarColor; // 0xA8
		private bool _needUpdateColorChange; // 0xB8
		private const float _colorChangeDuration = 1f; // Metadata: 0x00B120CF
		private float _colorChangeTime; // 0xBC
		private Dictionary<int, uint> _matResHandle; // 0xC0
		private float clearMiniMapCellScale; // 0xC8
		private float loadMiniMapCellScale; // 0xCC
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private string _terrainMatPrefix; // 0xD0
		public bool isInterior; // 0xD8
		public bool hasMultiFloor; // 0xD9
		public bool isBigWorld; // 0xDA
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private string _terrainMatName; // 0xE0
		public string roomIconName; // 0xE8
		private int _fogRGBName; // 0xF0
		private List<int> _toBeRemovedMapItemIdList; // 0xF8
		public static readonly string _interiorMapTexturePath; // 0x08
		public int _playerCurrentFloor; // 0x100
		private List<uint> _unlockedArea; // 0x108
		private const string unlockAreaPath = "ART/UI/Menus/Widget/InLevel/MapBack/BigWorld_3_7_GuideArea_Unlock"; // Metadata: 0x00B120D3
		private GameObject _guidAreaObj; // 0x110
		private uint _globalLimitImageHandle; // 0x118
		private GameObject _effectObj; // 0x120
		private AsyncJob _limitRegionLoadJob; // 0x128
		public static readonly float markPointDefaultRadius; // 0x10
		public static readonly string markPointAreaMatScaleProp; // 0x18
		public GameObject markPointArea; // 0x138
		public Dictionary<uint, GameObject> dicQuestArea; // 0x140
		public RectTransform markAreaAnchor; // 0x148
		public RectTransform markAreaAnchorMiniMap; // 0x150
		[Space] // 0x00000001898E0F50-0x00000001898E0F60
		public GameObject exploreDegreePrefab; // 0x158
		private uint _activityAsterAreaHandle; // 0x160
		private GameObject _activityAsterAreaObj; // 0x168
	
		// Properties
		public Transform MapArea { /* [XID] */ /* 0x00000001895F6220-0x00000001895F6240 */ get => default; } // 0x0000000183F9FEB0-0x0000000183F9FF50 
		public string TerrainMatPrefix { /* [XID] */ /* 0x00000001895FD560-0x00000001895FD580 */ get => default; } // 0x0000000183FA0040-0x0000000183FA0130 
		public string TerrainMatName { /* [XID] */ /* 0x0000000189604EA0-0x0000000189604EC0 */ get => default; } // 0x0000000183F9FF50-0x0000000183FA0040 
		public float cellRectSizeRatio { /* [XID] */ /* 0x000000018960C8B0-0x000000018960C8D0 */ get => default; } // 0x0000000183FA01E0-0x0000000183FA02A0 
		public Transform guidArea { /* [XID] */ /* 0x0000000189613E10-0x0000000189613E30 */ get => default; } // 0x0000000183FA02A0-0x0000000183FA0340 
		public int areaCount { /* [XID] */ /* 0x000000018961B7E0-0x000000018961B800 */ get => default; } // 0x0000000183FA0130-0x0000000183FA01E0 
	
		// Nested types
		[Serializable]
		public class AreaFogConfig // TypeDefIndex: 31246
		{
			// Fields
			public const float DEFAULT_BLEND = -1f; // Metadata: 0x00B12118
			[NotSerialized] // 0x0000000189785AC0-0x0000000189785B10
			// [Range] // 0x0000000189785AC0-0x0000000189785B10
			[ShowInInspector] // 0x0000000189785AC0-0x0000000189785B10
			public float blend; // 0x10
			public string[] blockName; // 0x18
			public string[] channnel; // 0x20
	
			// Constructors
			public AreaFogConfig() {} // 0x0000000184279BB0-0x0000000184279C20
		}
	
		// Constructors
		public MonoLevelMap() {} // 0x0000000183F9FC60-0x0000000183F9FEB0
		static MonoLevelMap() {} // 0x0000000183F9FBC0-0x0000000183F9FC60
	
		// Methods
		// [XID] // 0x0000000189622D60-0x0000000189622D80
		protected void Awake() {} // 0x0000000183F9A080-0x0000000183F9A130
		// [XID] // 0x000000018962A550-0x000000018962A570
		private void Start() {} // 0x0000000183F9F420-0x0000000183F9F4C0
		// [XID] // 0x0000000189631CD0-0x0000000189631CF0
		private UnityEngine.Material GetDefaultMat() => default; // 0x0000000183F9A570-0x0000000183F9A6F0
		// [XID] // 0x0000000189639850-0x0000000189639870
		public void SetTargetColor(Color value, bool immediately) {} // 0x0000000183F9CFE0-0x0000000183F9D0E0
		// [XID] // 0x0000000189640CC0-0x0000000189640CE0
		private void Update() {} // 0x0000000183F9F890-0x0000000183F9FBC0
		// [XID] // 0x0000000189648610-0x0000000189648630
		public void SetViewSize(Vector2 size) {} // 0x0000000183F9D0E0-0x0000000183F9D1E0
		// [XID] // 0x000000018964FD20-0x000000018964FD40
		public void ReleaseCells(List<int> idLst) {} // 0x0000000183F9C830-0x0000000183F9CA10
		// [XID] // 0x0000000189657560-0x0000000189657580
		public void ToggleMapNames(bool showNames) {} // 0x0000000183F9F4C0-0x0000000183F9F5D0
		// [XID] // 0x000000018965EC20-0x000000018965EC40
		private void cleanMiniMapCells(Vector2 pos, short beginXIndex, short beginYIndex, short endXIndex, short endYIndex) {} // 0x0000000183F9B120-0x0000000183F9B420
		// [XID] // 0x00000001896662A0-0x00000001896662C0
		private void loadMiniMapCells(short x, short y) {} // 0x0000000183F99DB0-0x0000000183F99F80
		// [XID] // 0x000000018966DA60-0x000000018966DA80
		public void ShowLevelMiniMap(Vector2 pos) {} // 0x0000000183F9E6C0-0x0000000183F9EBD0
		// [XID] // 0x0000000189675880-0x00000001896758A0
		public void ShowLevelMap(Vector2 pos) {} // 0x0000000183F9E0A0-0x0000000183F9E6C0
		// [XID] // 0x000000018967D190-0x000000018967D1B0
		public void ShowRoom() {} // 0x0000000183F9EFD0-0x0000000183F9F100
		// [XID] // 0x0000000189684840-0x0000000189684860
		public void ShowFloorData(int floor = 1 /* Metadata: 0x00B120AB */) {} // 0x0000000183F9DCF0-0x0000000183F9DF40
		// [XID] // 0x000000018968C3B0-0x000000018968C3D0
		public void ClearRoom() {} // 0x0000000183F9A4B0-0x0000000183F9A570
		// [XID] // 0x0000000189693E80-0x0000000189693EA0
		public void InitText() {} // 0x0000000183F9B880-0x0000000183F9BB70
		// [XID] // 0x000000018969B450-0x000000018969B470
		private void UnlockAreaName(uint areaIndex) {} // 0x0000000183F9B420-0x0000000183F9B7A0
		// [XID] // 0x00000001896A2B70-0x00000001896A2B90
		public UnityEngine.Material GetTerrainMaterial(int id) => default; // 0x0000000183F9AFA0-0x0000000183F9B120
		// [XID] // 0x00000001896AA010-0x00000001896AA030
		public void SetCurImageMat(Image curImage, UnityEngine.Material currMat, string terrainName) {} // 0x0000000183F9CA10-0x0000000183F9CC80
		[DebuggerHidden] // 0x00000001896B0DB0-0x00000001896B0DF0
		// [XID] // 0x00000001896B0DB0-0x00000001896B0DF0
		private IEnumerator UpdateMaterailCoroutine(UnityEngine.Material material, string channel) => default; // 0x0000000183F9A820-0x0000000183F9A920
		// [XID] // 0x00000001896BB750-0x00000001896BB770
		private void UpdateFog(Image img, AreaFogConfig config, bool needAnimation = false /* Metadata: 0x00B120AF */, float target = 1f /* Metadata: 0x00B120B0 */) {} // 0x0000000183F9A980-0x0000000183F9AFA0
		// [XID] // 0x00000001896C2BE0-0x00000001896C2C00
		public bool HasUnlockedArea() => default; // 0x0000000183F9B7A0-0x0000000183F9B880
		// [XID] // 0x00000001896CA120-0x00000001896CA140
		public void UnlockArea(uint areaIndex, bool needAnimation = false /* Metadata: 0x00B120B4 */) {} // 0x0000000183F9F5D0-0x0000000183F9F890
		// [XID] // 0x00000001896D17D0-0x00000001896D17F0
		public void OnStartUnlockAnim() {} // 0x0000000183F9C480-0x0000000183F9C590
		[DebuggerHidden] // 0x00000001896D8F70-0x00000001896D8FB0
		// [XID] // 0x00000001896D8F70-0x00000001896D8FB0
		private IEnumerator DelayPlayUnlockEffect(float delay) => default; // 0x0000000183F9BB70-0x0000000183F9BC50
		// [XID] // 0x00000001896E3600-0x00000001896E3620
		protected override void OnDestroy() {} // 0x0000000183F9BFD0-0x0000000183F9C480
		// [XID] // 0x00000001896EAA20-0x00000001896EAA40
		public void LoadLimitRegion() {} // 0x0000000183F9BD70-0x0000000183F9BFD0
		// [XID] // 0x00000001896F1D20-0x00000001896F1D40
		public bool ShowDisableLimitRegion() => default; // 0x0000000183F9D960-0x0000000183F9DCF0
		// [XID] // 0x00000001896F9750-0x00000001896F9770
		public void ClearGuidArea() {} // 0x0000000183F9A310-0x0000000183F9A4B0
		// [XID] // 0x0000000189700F60-0x0000000189700F80
		public GameObject ShowAreaMark(float radius, Vector2 levelMapPos, ColorStyle.MarkPointAreaColor markPointAreaColor, bool isOnMiniMap) => default; // 0x0000000183F9D610-0x0000000183F9D960
		// [XID] // 0x00000001897086A0-0x00000001897086C0
		public static void SetMarkPointAreaColor(GameObject markPointArea, ColorStyle.MarkPointAreaColor markPointAreaColor, bool isOnMiniMap) {} // 0x0000000183F9CC80-0x0000000183F9CFE0
		// [XID] // 0x0000000189710010-0x0000000189710030
		public GameObject ShowQuestAreaMark(uint markID, Vector2 levelMapPos, bool isOnMiniMap = false /* Metadata: 0x00B120B5 */) => default; // 0x0000000183F9ECB0-0x0000000183F9EE70
		// [XID] // 0x0000000189717390-0x00000001897173B0
		public void ShowHuntingAreaMark(uint markID, Vector2 levelMapPos, float radius, bool isOnMiniMap = false /* Metadata: 0x00B120B6 */) {} // 0x0000000183F9DF40-0x0000000183F9E0A0
		// [XID] // 0x000000018971EE10-0x000000018971EE30
		public void ShowActivityExpeditionChallengeAreaMark(uint markID, Vector2 levelMapPos, float radius, bool isOnMiniMap = false /* Metadata: 0x00B120B7 */) {} // 0x0000000183F9D300-0x0000000183F9D460
		// [XID] // 0x00000001897263B0-0x00000001897263D0
		public void ShowWidgetHintAreaMark(uint markID, Vector2 levelMapPos, bool isOnMiniMap = false /* Metadata: 0x00B120B8 */) {} // 0x0000000183F9F260-0x0000000183F9F420
		// [XID] // 0x000000018972D9B0-0x000000018972D9D0
		public void ShowActivityRegionAreaMark(uint markID, Vector2 levelMapPos, bool isOnMiniMap = false /* Metadata: 0x00B120B9 */) {} // 0x0000000183F9D460-0x0000000183F9D610
		// [XID] // 0x0000000189735130-0x0000000189735150
		public void ShowRegionAreaMark(uint markID, Vector2 levelMapPos, float radius, bool isOnMiniMap = false /* Metadata: 0x00B120BA */) {} // 0x0000000183F9EE70-0x0000000183F9EFD0
		// [XID] // 0x000000018973CBD0-0x000000018973CBF0
		public void ShowTreasureMapAreaMark(uint markID, Vector2 levelMapPos, float radius, bool isOnMiniMap = false /* Metadata: 0x00B120BB */) {} // 0x0000000183F9F100-0x0000000183F9F260
		// [XID] // 0x0000000189744130-0x0000000189744150
		private GameObject GetMarkAreaInst(bool isOnMiniMap) => default; // 0x0000000183F9A6F0-0x0000000183F9A820
		// [XID] // 0x000000018974BE50-0x000000018974BE70
		public void ShowMiniMapMarkArea(bool show) {} // 0x0000000183F9EBD0-0x0000000183F9ECB0
		// [XID] // 0x0000000189753110-0x0000000189753130
		public void ClearAllMarkArea() {} // 0x0000000183F9A260-0x0000000183F9A310
		// [XID] // 0x000000018975A480-0x000000018975A4A0
		public void RefreshExploreDegree() {} // 0x0000000183F9C590-0x0000000183F9C830
		// [XID] // 0x0000000189762160-0x0000000189762180
		public void ShowActivityAsterRegion(ulong areaPath) {} // 0x0000000183F9D1E0-0x0000000183F9D300
		// [XID] // 0x00000001897696D0-0x00000001897696F0
		public void ClearActivityAsterArea() {} // 0x0000000183F9A130-0x0000000183F9A260
	}
}
