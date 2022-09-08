/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;
using UnityEngine.UI;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public class MonoMapMark : MonoSpriteProxy // TypeDefIndex: 31135
	{
		// Fields
		private const string DUNGEONICON_LABEL_PREFAB_ROOT = "ART/UI/Menus/Widget/Dungeon/DungeonIcon_Label"; // Metadata: 0x00B11F08
		private const string DUNGEONICON_TIPS_PREFAB_ROOT = "ART/UI/Menus/Widget/Dungeon/DungeonIcon_Tips"; // Metadata: 0x00B11F39
		private const string PS4_ONLINEID_PREFAB_ROOT = "ART/UI/Menus/Widget/MarkPoint_OnlineID"; // Metadata: 0x00B11F69
		// [Header] // 0x00000001898CE070-0x00000001898CE0C0
		[ReadOnly] // 0x00000001898CE070-0x00000001898CE0C0
		[SerializeField] // 0x00000001898CE070-0x00000001898CE0C0
		private MarkType _markType; // 0x20
		[ReadOnly] // 0x00000001898DD750-0x00000001898DD780
		[SerializeField] // 0x00000001898DD750-0x00000001898DD780
		private MarkIconType _iconType; // 0x24
		[ReadOnly] // 0x00000001898DD750-0x00000001898DD780
		[SerializeField] // 0x00000001898DD750-0x00000001898DD780
		private MarkOrder _markOrder; // 0x28
		[ReadOnly] // 0x00000001898DD750-0x00000001898DD780
		[SerializeField] // 0x00000001898DD750-0x00000001898DD780
		private uint _identifier; // 0x2C
		[ReadOnly] // 0x00000001898DD750-0x00000001898DD780
		[SerializeField] // 0x00000001898DD750-0x00000001898DD780
		public MarkVisibilityType realRadarVisibility; // 0x30
		[ReadOnly] // 0x00000001899274D0-0x0000000189927500
		[SerializeField] // 0x00000001899274D0-0x0000000189927500
		public MarkVisibilityType realMapVisibility; // 0x34
		[ReadOnly] // 0x00000001899274D0-0x0000000189927500
		[SerializeField] // 0x00000001899274D0-0x0000000189927500
		public string markerName; // 0x38
		[ReadOnly] // 0x00000001898DD750-0x00000001898DD780
		[SerializeField] // 0x00000001898DD750-0x00000001898DD780
		private bool _alwaysShow; // 0x40
		[ReadOnly] // 0x00000001899274D0-0x0000000189927500
		[SerializeField] // 0x00000001899274D0-0x0000000189927500
		public bool showHeight; // 0x41
		[ReadOnly] // 0x00000001899274D0-0x0000000189927500
		[SerializeField] // 0x00000001899274D0-0x0000000189927500
		public float height; // 0x44
		[ReadOnly] // 0x00000001898DD750-0x00000001898DD780
		[SerializeField] // 0x00000001898DD750-0x00000001898DD780
		public bool isHide; // 0x48
		[ReadOnly] // 0x00000001898DD750-0x00000001898DD780
		[SerializeField] // 0x00000001898DD750-0x00000001898DD780
		public bool hideIcon; // 0x49
		// [Header] // 0x0000000189951260-0x00000001899512E0
		[SerializeField] // 0x0000000189951260-0x00000001899512E0
		[Space] // 0x0000000189951260-0x00000001899512E0
		// [Tooltip] // 0x0000000189951260-0x00000001899512E0
		private Button _actionButton; // 0x50
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private RectTransform _pointGrp; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _icon; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIEffect _effect; // 0x68
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIEffect _unlockEffect; // 0x70
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _defaultEffectObj; // 0x78
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _customEffectObj; // 0x80
		[SerializeField] // 0x0000000189994D70-0x0000000189994DB0
		// [Tooltip] // 0x0000000189994D70-0x0000000189994DB0
		private RectTransform _selectedGrp; // 0x88
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private MonoPrefabPlugin _effectPrefabs; // 0x90
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoAsyncPrefabPlugin _asyncPrefabs; // 0x98
		[Space] // 0x00000001898E0F50-0x00000001898E0F60
		private GameObject _areaGrp; // 0xA0
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private RectTransform _levelGrp; // 0xA8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _levelLabel; // 0xB0
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private UnityEngine.Material[] _materials; // 0xB8
		public GameObject markPointArea; // 0xC0
		private RectTransform _rectTrans; // 0xC8
		private Vector2 _levelMapPos; // 0xD0
		public ConfigMarkIcon config; // 0xD8
		private uint _dungeonIconLabelHandle; // 0x120
		private GameObject _dungeonIconLabel; // 0x128
		private uint _dungeonIconTipsHandle; // 0x130
		private GameObject _dungeonIconTips; // 0x138
		private bool _up; // 0x140
		private string _currEffectName; // 0x148
		private ParticleSystem _currEffect; // 0x150
		public float markAreaRadius; // 0x158
		private ColorStyle.MarkPointAreaColor _markPointAreaColor; // 0x15C
		[NonSerialized]
		public RectTransform layerParent; // 0x180
		private bool _inLayer; // 0x188
		private int _layer; // 0x18C
		private uint? _appearAudio; // 0x190
		private uint _configEffectHandle; // 0x198
		private GameObject _configEffectIns; // 0x1A0
		private const string MARK_POINT_COMPLETE_PREFAB_PATH = "ART/UI/Menus/Widget/MarkPoint_Complete"; // Metadata: 0x00B11F93
		private GameObject _completeIcon; // 0x1A8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _dungeonIconLabelRoot; // 0x1B0
		private GameObject _bossGrp; // 0x1B8
		private Image _bossIcon; // 0x1C0
		private Image _bossIconNoBG; // 0x1C8
		private Transform _bossIconRoot; // 0x1D0
		private Transform _bossIconRootNoBG; // 0x1D8
		private Transform _bossEffect; // 0x1E0
		public string imgPath; // 0x1E8
	
		// Properties
		public RectTransform rectTrans { /* [XID] */ /* 0x00000001899DCA90-0x00000001899DCAB0 */ get => default; } // 0x0000000184932F50-0x0000000184933000 
		public MarkType markType { /* [XID] */ /* 0x00000001899E46D0-0x00000001899E46F0 */ get => default; /* [XID] */ /* 0x00000001899EB9C0-0x00000001899EB9E0 */ set {} } // 0x0000000184932DF0-0x0000000184932E90 0x0000000184933FB0-0x0000000184934060
		public bool isArea { /* [XID] */ /* 0x00000001899F34B0-0x00000001899F34D0 */ get => default; } // 0x0000000184932A60-0x0000000184932C00 
		public bool raycastTarget { /* [XID] */ /* 0x00000001899FAE70-0x00000001899FAE90 */ get => default; /* [XID] */ /* 0x0000000189A020C0-0x0000000189A020E0 */ set {} } // 0x0000000184932E90-0x0000000184932F50 0x00000001849341C0-0x0000000184934290
		public uint identifier { /* [XID] */ /* 0x0000000189A098B0-0x0000000189A098D0 */ get => default; /* [XID] */ /* 0x0000000189A11010-0x0000000189A11030 */ set {} } // 0x0000000184932910-0x00000001849329B0 0x00000001849338B0-0x0000000184933960
		public Button actionButton { /* [XID] */ /* 0x0000000189A183C0-0x0000000189A183E0 */ get => default; } // 0x00000001849323F0-0x0000000184932490 
		public Vector2 levelMapPos { /* [XID] */ /* 0x0000000189A1FA70-0x0000000189A1FA90 */ get => default; /* [XID] */ /* 0x0000000189A26E30-0x0000000189A26E50 */ set {} } // 0x0000000184932CA0-0x0000000184932D50 0x0000000184933D80-0x0000000184933E30
		public MarkOrder markOrder { /* [XID] */ /* 0x0000000189A35FC0-0x0000000189A35FE0 */ get => default; /* [XID] */ /* 0x0000000189A2E670-0x0000000189A2E690 */ set {} } // 0x0000000184932D50-0x0000000184932DF0 0x0000000184933F00-0x0000000184933FB0
		public bool showEffect { /* [XID] */ /* 0x0000000189A88A60-0x0000000189A88A80 */ get => default; /* [XID] */ /* 0x0000000189A81020-0x0000000189A81040 */ set {} } // 0x00000001849330C0-0x0000000184933180 0x00000001849346C0-0x00000001849347C0
		public bool showUnlockEffect { /* [XID] */ /* 0x0000000189A90230-0x0000000189A90250 */ set {} } // 0x00000001849348A0-0x00000001849349A0
		public uint materialIndex { /* [XID] */ /* 0x0000000189A97A20-0x0000000189A97A40 */ set {} } // 0x0000000184934060-0x00000001849341C0
		public MarkIconType iconType { /* [XID] */ /* 0x0000000189AA66F0-0x0000000189AA6710 */ get => default; /* [XID] */ /* 0x0000000189A9EDC0-0x0000000189A9EDE0 */ set {} } // 0x00000001849327C0-0x0000000184932860 0x0000000184933740-0x00000001849337F0
		public bool selected { /* [XID] */ /* 0x0000000189AADD40-0x0000000189AADD60 */ set {} } // 0x0000000184934290-0x00000001849343B0
		public Color effectColor { /* [XID] */ /* 0x0000000189AB56D0-0x0000000189AB56F0 */ set {} } // 0x00000001849333A0-0x0000000184933480
		public Sprite icon { /* [XID] */ /* 0x0000000189ABD0D0-0x0000000189ABD0F0 */ get => default; /* [XID] */ /* 0x0000000189AC4B60-0x0000000189AC4B80 */ set {} } // 0x0000000184932860-0x0000000184932910 0x00000001849337F0-0x00000001849338B0
		public string effectName { /* [XID] */ /* 0x0000000189ACC1E0-0x0000000189ACC200 */ set {} } // 0x0000000184933480-0x0000000184933740
		public bool showLevelGroup { /* [XID] */ /* 0x0000000189B08700-0x0000000189B08720 */ set {} } // 0x00000001849347C0-0x00000001849348A0
		public string levelText { /* [XID] */ /* 0x0000000189B10040-0x0000000189B10060 */ set {} } // 0x0000000184933E30-0x0000000184933F00
		public bool inLayer { /* [XID] */ /* 0x0000000189B171A0-0x0000000189B171C0 */ get => default; /* [XID] */ /* 0x0000000189B1EB00-0x0000000189B1EB20 */ set {} } // 0x00000001849329B0-0x0000000184932A60 0x0000000184933960-0x0000000184933A10
		public int layer { /* [XID] */ /* 0x0000000189B263F0-0x0000000189B26410 */ get => default; /* [XID] */ /* 0x0000000189B2D670-0x0000000189B2D690 */ set {} } // 0x0000000184932C00-0x0000000184932CA0 0x0000000184933CD0-0x0000000184933D80
		public bool alwaysShow { /* [XID] */ /* 0x0000000189B34B40-0x0000000189B34B60 */ get => default; /* [XID] */ /* 0x0000000189B3C350-0x0000000189B3C370 */ set {} } // 0x0000000184932490-0x0000000184932530 0x0000000184933180-0x0000000184933230
		public bool showCompleteIcon { /* [XID] */ /* 0x0000000189B61BB0-0x0000000189B61BD0 */ set {} } // 0x0000000184934490-0x00000001849346C0
		public GameObject dungeonIconTips { /* [XID] */ /* 0x0000000189B70E20-0x0000000189B70E40 */ get => default; } // 0x0000000184932710-0x00000001849327C0 
		public bool isToBeExplored { /* [XID] */ /* 0x0000000189B873E0-0x0000000189B87400 */ set {} } // 0x0000000184933A10-0x0000000184933CD0
		public Sprite bossIcon { /* [XID] */ /* 0x0000000189BC9FC0-0x0000000189BC9FE0 */ get => default; /* [XID] */ /* 0x0000000189BD1690-0x0000000189BD16B0 */ set {} } // 0x0000000184932530-0x0000000184932710 0x0000000184933230-0x00000001849333A0
		public bool showBossEffect { /* [XID] */ /* 0x00000001895E5820-0x00000001895E5840 */ get => default; /* [XID] */ /* 0x0000000189BD8C80-0x0000000189BD8CA0 */ set {} } // 0x0000000184933000-0x00000001849330C0 0x00000001849343B0-0x0000000184934490
	
		// Constructors
		public MonoMapMark() {} // 0x0000000184932260-0x00000001849323F0
	
		// Methods
		// [XID] // 0x0000000189A3D5C0-0x0000000189A3D5E0
		public void SetImageWithMarkInfo(Image icon) {} // 0x0000000184930000-0x0000000184930320
		// [XID] // 0x0000000189A44C90-0x0000000189A44CB0
		public void Init(MarkType markType, uint markID, MarkIconType iconType) {} // 0x000000018492EC60-0x000000018492EF40
		// [XID] // 0x0000000189A4C4E0-0x0000000189A4C500
		private void SetCustomEffect(MarkType markType, MarkIconType iconType) {} // 0x000000018492EB30-0x000000018492EC60
		// [XID] // 0x0000000189A53C40-0x0000000189A53C60
		private void OnGetMarkHeight(RectTransform rectTrans) {} // 0x000000018492E590-0x000000018492E690
		// [XID] // 0x0000000189A5B690-0x0000000189A5B6B0
		public void SetShowHeight(bool show, bool up) {} // 0x0000000184930430-0x00000001849305E0
		// [XID] // 0x0000000189A62CE0-0x0000000189A62D00
		private void InitRadarHintMark(uint markID, MarkIconType iconType) {} // 0x000000018492E8C0-0x000000018492EB30
		// [XID] // 0x0000000189A6A890-0x0000000189A6A8B0
		public void UpdateIcon(MarkIconType iconType) {} // 0x0000000184931C70-0x0000000184931E30
		// [XID] // 0x0000000189A71F20-0x0000000189A71F40
		public void UpdateQuestIcon(uint markID, MarkIconType iconType) {} // 0x0000000184931E30-0x00000001849320F0
		// [XID] // 0x0000000189A79B80-0x0000000189A79BA0
		public void SetColorGray(bool setGray) {} // 0x000000018492F7B0-0x000000018492F990
		// [XID] // 0x0000000189AD3CC0-0x0000000189AD3CE0
		public void PlayEffect() {} // 0x000000018492F690-0x000000018492F7B0
		// [XID] // 0x0000000189ADB7A0-0x0000000189ADB7C0
		public void ShowPoint() {} // 0x0000000184930D40-0x0000000184930E50
		// [XID] // 0x0000000189AE3060-0x0000000189AE3080
		public void HideAll() {} // 0x000000018492E7B0-0x000000018492E8C0
		// [XID] // 0x0000000189AEAA10-0x0000000189AEAA30
		public void ShowArea() {} // 0x0000000184930A20-0x0000000184930B30
		// [XID] // 0x0000000189AF2300-0x0000000189AF2320
		private void CheckCreateMarkArea() {} // 0x000000018492EF40-0x000000018492F550
		// [XID] // 0x0000000189AF9C60-0x0000000189AF9C80
		public void SetMiniMapMarkArea(float radius, ColorStyle.MarkPointAreaColor markPointAreaColor) {} // 0x0000000184930320-0x0000000184930430
		// [XID] // 0x0000000189B01170-0x0000000189B01190
		public void TryDestroyMarkArea() {} // 0x0000000184931980-0x0000000184931AA0
		// [XID] // 0x0000000189B43FC0-0x0000000189B43FE0
		public void UpdateAppearAudio(string audioName) {} // 0x0000000184931B40-0x0000000184931C70
		// [XID] // 0x0000000189B4B6C0-0x0000000189B4B6E0
		public void UpdateViewOnEnterSight() {} // 0x00000001849320F0-0x0000000184932260
		// [XID] // 0x0000000189B52D30-0x0000000189B52D50
		public void TryCreateConfigEffect() {} // 0x0000000184931160-0x0000000184931420
		// [XID] // 0x0000000189B5A6C0-0x0000000189B5A6E0
		public void TryDestroyConfigEffect() {} // 0x0000000184931560-0x00000001849316C0
		// [XID] // 0x0000000189B69840-0x0000000189B69860
		protected override void OnDestroy() {} // 0x000000018492F550-0x000000018492F690
		// [XID] // 0x0000000189B783D0-0x0000000189B783F0
		public void SetDailyDungeonTips() {} // 0x000000018492F990-0x000000018492FDD0
		// [XID] // 0x0000000189B7F890-0x0000000189B7F8B0
		public void SetTowerDungeonTips() {} // 0x00000001849305E0-0x0000000184930A20
		// [XID] // 0x0000000189B8E4B0-0x0000000189B8E4D0
		public void SetElementChallengeLabel() {} // 0x000000018492FDD0-0x0000000184930000
		// [XID] // 0x0000000189B95970-0x0000000189B95990
		public void TryDestroyDungeonLabel() {} // 0x00000001849316C0-0x0000000184931820
		// [XID] // 0x0000000189B9CF10-0x0000000189B9CF30
		public void TryDestroyDungeonTips() {} // 0x0000000184931820-0x0000000184931980
		// [XID] // 0x0000000189BA4810-0x0000000189BA4830
		public void TryCreateBossGroup(GameObject prefab) {} // 0x0000000184930F00-0x0000000184931160
		// [XID] // 0x0000000189BABB70-0x0000000189BABB90
		public void TryDestroyBossGroup() {} // 0x0000000184931420-0x0000000184931560
		// [XID] // 0x0000000189BB3260-0x0000000189BB3280
		public void ShowBossGrp() {} // 0x0000000184930C30-0x0000000184930D40
		// [XID] // 0x0000000189BBA840-0x0000000189BBA860
		public void ShowBossGrpBG(bool bShow) {} // 0x0000000184930B30-0x0000000184930C30
		// [XID] // 0x0000000189BC2860-0x0000000189BC2880
		public Image GetBossIcon(bool withBG) => default; // 0x000000018492E6F0-0x000000018492E7B0
		// [XID] // 0x00000001895ED170-0x00000001895ED190
		public void TryCreatPS4OnlineId(string id) {} // 0x0000000184930E50-0x0000000184930F00
		// [XID] // 0x00000001895F47F0-0x00000001895F4810
		public void TryDestroyPS4OnlineId() {} // 0x0000000184931AA0-0x0000000184931B40
	}
}
