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
using UnityEngine;
using UnityEngine.UI;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public class SceneAssetsTest : MonoBehaviour // TypeDefIndex: 31769
	{
		// Fields
		private const string AREA_FOLDER = "ART/Stages/Area"; // Metadata: 0x00B13544
		private const string COMMON_FOLDER = "ART/Stages/Common"; // Metadata: 0x00B13557
		private const string GADGET_FOLDER = "ART/Stages/Property"; // Metadata: 0x00B1356C
		private const string DUNGEON_FOLDER = "ART/Stages/Level"; // Metadata: 0x00B13583
		private const string INDOOR_FOLDER = "ART/Stages/Indoor"; // Metadata: 0x00B13597
		private const string DYNAMIC_GADGET_FOLDER = "ART/Others/Gadget/Dynamic"; // Metadata: 0x00B135AC
		private const string STATIC_GADGET_FOLDER = "ART/Others/Gadget/Static"; // Metadata: 0x00B135C9
		private const string RUNTIME_ASSET_PATH_PATTERN = "Assets/MoleRes/Rel/SRes/{0}.prefab"; // Metadata: 0x00B135E5
		private const string LABEL_NAME = "LabelText"; // Metadata: 0x00B1360B
		private const float REGION_X_BASE = -5000f; // Metadata: 0x00B13618
		private const float REGION_Z_BASE = -5000f; // Metadata: 0x00B1361C
		private static readonly Dictionary<string, string> REPLACE_PATTERN; // 0x00
		private readonly Dictionary<RegionKey, Vector3> _regionPosition; // 0x18
		public Dropdown areaDropdown; // 0x20
		public Dropdown typeDropdown; // 0x28
		public Toggle textSwitch; // 0x30
		private Dictionary<RegionKey, List<AssetValue>> _assets; // 0x38
		private Dictionary<string, SECTR_BaseObject> _streamingObjects; // 0x40
		public Toggle showOnlySwitch; // 0x48
		public Toggle vertexColorSwitch; // 0x50
		private const string HIDE_BUTTONS_NAME = "HideButton"; // Metadata: 0x00B13620
		private const string HIDE_BUTTON_TEXT = "\u9690\uFFFD"; // Metadata: 0x00B1362E
		private const string SHOW_BUTTON_TEXT = "\u663E\uFFFD"; // Metadata: 0x00B1363E
		public Button hideButton; // 0x58
		private bool _hidden; // 0x60
		private Dictionary<int, UnityEngine.Material> _assetMaterials; // 0x68
		private const string VERTEX_COLOR_SHADER = "miHoYo/Debug/VertexColor"; // Metadata: 0x00B1364E
		private const string BLEND_STONE_LOD2_SHADER = "miHoYo/Terrain/BlendStoneLOD2 New"; // Metadata: 0x00B1366A
		private const string BLEND_STONE_LOD2_PURE_COLOR_SHADER = "miHoYo/Debug/BlendStone"; // Metadata: 0x00B1368F
		private UnityEngine.Material _vertexColorMaterial; // 0x70
		public Slider areaGapSlider; // 0x78
		public Slider objectGapSlider; // 0x80
		public Button refreshGapButton; // 0x88
		private float _areaGap; // 0x90
		private float _objectGap; // 0x94
		private const string AREA_GAP_DESC = "\u533A\uFFFD"; // Metadata: 0x00B136AA
		private const string OBJECT_GAP_DESC = "\u7269\uFFFD"; // Metadata: 0x00B136BA
		private const float SLIDER_MULTIPLIER = 100f; // Metadata: 0x00B136CA
	
		// Properties
		public int areaGap { /* [XID] */ /* 0x00000001895F90D0-0x00000001895F90F0 */ get => default; } // 0x0000000184FF15F0-0x0000000184FF16D0 
		public float objectGap { /* [XID] */ /* 0x0000000189600680-0x00000001896006A0 */ get => default; } // 0x0000000184FF16D0-0x0000000184FF17C0 
	
		// Nested types
		public struct Range // TypeDefIndex: 31770
		{
			// Fields
			public float height; // 0x00
			public float width; // 0x04
	
			// Constructors
			public Range(float width, float height) {
				this.height = default;
				this.width = default;
			} // 0x0000000184EDC9F0-0x0000000184EDCA70
		}
	
		private struct RegionKey // TypeDefIndex: 31771
		{
			// Fields
			public string areaName; // 0x00
			public string typeName; // 0x08
	
			// Methods
			// [XID] // 0x00000001896F6B20-0x00000001896F6B40
			public override int GetHashCode() => default; // 0x0000000184EDC860-0x0000000184EDC960
			// [XID] // 0x00000001896FE370-0x00000001896FE390
			public override string ToString() => default; // 0x0000000184EDC960-0x0000000184EDC9F0
		}
	
		private class AssetValue // TypeDefIndex: 31772
		{
			// Fields
			public string name; // 0x10
			public bool isLod; // 0x18
			public string runTimePath; // 0x20
			public Bounds bounds; // 0x28
			public Vector3 position; // 0x40
	
			// Constructors
			public AssetValue() {} // 0x0000000184EDD860-0x0000000184EDD8C0
	
			// Methods
			// [XID] // 0x0000000189705540-0x0000000189705560
			public SECTR_StreamObject ToStreamObject() => default; // 0x0000000184EDD5D0-0x0000000184EDD860
		}
	
		// Constructors
		public SceneAssetsTest() {} // 0x0000000184FF1530-0x0000000184FF15F0
		static SceneAssetsTest() {} // 0x0000000184FF1460-0x0000000184FF1530
	
		// Methods
		// [XID] // 0x0000000189B278C0-0x0000000189B278E0
		private void Awake() {} // 0x0000000184FEB180-0x0000000184FEB410
		// [XID] // 0x0000000189B2EBD0-0x0000000189B2EBF0
		private void InitializeHideButton() {} // 0x0000000184FEB410-0x0000000184FEB510
		// [XID] // 0x0000000189B36410-0x0000000189B36430
		private void OnHideButton() {} // 0x0000000184FEFBD0-0x0000000184FEFC90
		// [XID] // 0x0000000189B3DC10-0x0000000189B3DC30
		private void SwitchHideButtonText() {} // 0x0000000184FEBBB0-0x0000000184FEBCA0
		// [XID] // 0x0000000189B45990-0x0000000189B459B0
		private void HideOrShowButton() {} // 0x0000000184FF0220-0x0000000184FF0410
		[DebuggerHidden] // 0x0000000189B4CDF0-0x0000000189B4CE30
		// [XID] // 0x0000000189B4CDF0-0x0000000189B4CE30
		private IEnumerable<GameObject> EnumOperationButton() => default; // 0x0000000184FEDB30-0x0000000184FEDC00
		// [XID] // 0x0000000189B57680-0x0000000189B576A0
		private GameObject GetCanvasGameObject() => default; // 0x0000000184FEC810-0x0000000184FEC920
		// [XID] // 0x0000000189B5EFB0-0x0000000189B5EFD0
		private void InitializeShowOnlySwitch() {} // 0x0000000184FED340-0x0000000184FED480
		// [XID] // 0x0000000189B66600-0x0000000189B66620
		private void InitializeTextSwitch() {} // 0x0000000184FEAE00-0x0000000184FEAF10
		// [XID] // 0x0000000189B6DBA0-0x0000000189B6DBC0
		public void ExtendPlane() {} // 0x0000000184FEC920-0x0000000184FECB00
		// [XID] // 0x0000000189B751F0-0x0000000189B75210
		private void CloseWorldShift() {} // 0x0000000184FEDC00-0x0000000184FEDCE0
		// [XID] // 0x0000000189B7C640-0x0000000189B7C660
		private GameObject GetPlane() => default; // 0x0000000184FEC110-0x0000000184FEC240
		// [XID] // 0x0000000189B84460-0x0000000189B84480
		private void OnTextSwitch(Toggle toggle, bool value) {} // 0x0000000184FEB510-0x0000000184FEB7D0
		// [XID] // 0x0000000189B8B310-0x0000000189B8B330
		private void OnShowOnlySwitch(Toggle toggle, bool value) {} // 0x0000000184FEBFD0-0x0000000184FEC090
		// [XID] // 0x0000000189B92A80-0x0000000189B92AA0
		private void InitializeVertexColorSwitch() {} // 0x0000000184FEF1A0-0x0000000184FEF2E0
		// [XID] // 0x0000000189B99FE0-0x0000000189B9A000
		private void OnVertexColorSwitch(Toggle toggle, bool value) {} // 0x0000000184FEFB10-0x0000000184FEFBD0
		// [XID] // 0x0000000189BA1700-0x0000000189BA1720
		private void ShowVertexColorForVLod2() {} // 0x0000000184FF0050-0x0000000184FF00F0
		// [XID] // 0x0000000189BA8B30-0x0000000189BA8B50
		private void CancelVertexColorForVLod2() {} // 0x0000000184FEBF30-0x0000000184FEBFD0
		// [XID] // 0x0000000189BB0250-0x0000000189BB0270
		private bool IsGameObjectWithVLod2(GameObject go) => default; // 0x0000000184FEEB00-0x0000000184FEED70
		// [XID] // 0x0000000189BB76C0-0x0000000189BB76E0
		private bool IsMaterialVLod2(UnityEngine.Material mat) => default; // 0x0000000184FF12E0-0x0000000184FF1400
		// [XID] // 0x0000000189BBED60-0x0000000189BBED80
		private bool IsGameObjectWithStoneBlendLod2(GameObject go) => default; // 0x0000000184FEAF10-0x0000000184FEB180
		// [XID] // 0x0000000189BC69B0-0x0000000189BC69D0
		private bool IsMaterialBlendStoneLod2(UnityEngine.Material mat) => default; // 0x0000000184FEED70-0x0000000184FEEE80
		// [XID] // 0x0000000189BCE700-0x0000000189BCE720
		private UnityEngine.Material GetBlendStonePureColorMaterial(UnityEngine.Material mat) => default; // 0x0000000184FEFF50-0x0000000184FF0050
		// [XID] // 0x0000000189BD59A0-0x0000000189BD59C0
		private UnityEngine.Material GetNormalVertexColorMaterial() => default; // 0x0000000184FEF6E0-0x0000000184FEF800
		// [XID] // 0x0000000189BDD580-0x0000000189BDD5A0
		private UnityEngine.Material GetVertexColorMaterial(UnityEngine.Material mat) => default; // 0x0000000184FEAD30-0x0000000184FEAE00
		// [XID] // 0x00000001895EA130-0x00000001895EA150
		private void ReplaceGameObjectWithVertexColor(GameObject go) {} // 0x0000000184FEF800-0x0000000184FEFB10
		// [XID] // 0x00000001895F1620-0x00000001895F1640
		private void RestoreGameObjectMaterial(GameObject go) {} // 0x0000000184FEC530-0x0000000184FEC810
		// [XID] // 0x0000000189607F90-0x0000000189607FB0
		private void InitializeGapSliders() {} // 0x0000000184FF00F0-0x0000000184FF0220
		// [XID] // 0x000000018960F960-0x000000018960F980
		private Dictionary<RegionKey, List<AssetValue>> CollectAssets() => default; // 0x0000000184FECB00-0x0000000184FED110
		// [XID] // 0x0000000189616B70-0x0000000189616B90
		private static void AddAsset(Dictionary<RegionKey, List<AssetValue>> dict, AssetValue asset) {} // 0x0000000184FEF420-0x0000000184FEF6E0
		// [XID] // 0x000000018961E760-0x000000018961E780
		private static RegionKey? GetRegionKey(string path) => default; // 0x0000000184FF0410-0x0000000184FF09B0
		// [XID] // 0x0000000189625B40-0x0000000189625B60
		private static RegionKey GetAreaAssetKey(string path) => default; // 0x0000000184FF0AC0-0x0000000184FF0E70
		// [XID] // 0x000000018962D420-0x000000018962D440
		private static RegionKey GetCommonAssetTypeName(string path) => default; // 0x0000000184FEF2E0-0x0000000184FEF420
		// [XID] // 0x0000000189634FB0-0x0000000189634FD0
		private static RegionKey GetIndoorAssetKey(string path) => default; // 0x0000000184FED110-0x0000000184FED340
		// [XID] // 0x000000018963C600-0x000000018963C620
		private static RegionKey GetGadgetAssetKey(string path) => default; // 0x0000000184FEE9A0-0x0000000184FEEAA0
		// [XID] // 0x0000000189643D90-0x0000000189643DB0
		private static RegionKey GetDynamicGadgetAssetKey(string path) => default; // 0x0000000184FF09B0-0x0000000184FF0AC0
		// [XID] // 0x000000018964B4D0-0x000000018964B4F0
		private static RegionKey GetStaticGadgetAssetKey(string path) => default; // 0x0000000184FF0E70-0x0000000184FF0F80
		// [XID] // 0x0000000189652D00-0x0000000189652D20
		private static RegionKey? GetDungeonAssetKey(string path) => default; // 0x0000000184FEEF30-0x0000000184FEF1A0
		// [IDTag] // 0x000000018965A380-0x000000018965A3C0
		// [XID] // 0x000000018965A380-0x000000018965A3C0
		private void SetPosition(Dictionary<RegionKey, List<AssetValue>> assets) {} // 0x0000000184FEDEB0-0x0000000184FEE920
		// [XID] // 0x0000000189664BE0-0x0000000189664C00
		private Dictionary<RegionKey, Range> GetRegionRange(Dictionary<RegionKey, List<AssetValue>> assets) => default; // 0x0000000184FEC240-0x0000000184FEC4B0
		// [XID] // 0x000000018966C150-0x000000018966C170
		private Range GetAssetsRange(IEnumerable<AssetValue> assets) => default; // 0x0000000184FEB7D0-0x0000000184FEBBB0
		// [IDTag] // 0x0000000189674030-0x0000000189674070
		// [XID] // 0x0000000189674030-0x0000000189674070
		private static void SetPosition(AssetValue asset, float x, float z) {} // 0x0000000184FEDCE0-0x0000000184FEDEB0
		// [XID] // 0x000000018967E610-0x000000018967E630
		private void AddTextHint(RegionKey region, Vector3 position) {} // 0x0000000184FF0FE0-0x0000000184FF12E0
		// [XID] // 0x0000000189685E60-0x0000000189685E80
		private void LoadAssets(Dictionary<RegionKey, List<AssetValue>> assets) {} // 0x0000000184FED480-0x0000000184FED840
		// [XID] // 0x000000018968DC90-0x000000018968DCB0
		private Transform GetContainer(RegionKey region) => default; // 0x0000000184FEBD00-0x0000000184FEBF30
		// [XID] // 0x00000001896955E0-0x0000000189695600
		private void UpdateTypeListView() {} // 0x0000000184FED840-0x0000000184FEDB30
		// [XID] // 0x000000018969CC70-0x000000018969CC90
		public void MoveToRegion() {} // 0x0000000184FEFC90-0x0000000184FEFF50
	}
}
