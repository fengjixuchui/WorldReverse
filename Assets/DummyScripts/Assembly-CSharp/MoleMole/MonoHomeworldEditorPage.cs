/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
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
	public class MonoHomeworldEditorPage : MonoBehaviour // TypeDefIndex: 31002
	{
		// Fields
		// [Header] // 0x0000000189816AE0-0x0000000189816B20
		[SerializeField] // 0x0000000189816AE0-0x0000000189816B20
		protected MonoElementSwitch _elementSwitch; // 0x18
		// [Header] // 0x0000000189822A00-0x0000000189822A40
		[SerializeField] // 0x0000000189822A00-0x0000000189822A40
		protected Transform _grpBrowse; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		protected Transform _grpBrowseTop; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		protected Transform _grpBrowseJoypadLeft; // 0x30
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		protected UnityEngine.UI.Text _comfortLevel; // 0x38
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		protected UnityEngine.UI.Text _typeNumber; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		protected GameObject[] _costGOs; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		protected UnityEngine.UI.Text _rockeryHintText; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		protected MonoUIContainer _rotateRoutine; // 0x58
		protected UnityEngine.UI.Text _rotateModeText; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		protected Transform _grpBrowseBottom; // 0x68
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		protected Transform _optionTabParent; // 0x70
		protected List<MonoUIContainer> _optionTabs; // 0x78
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		protected Transform _subTabParent; // 0x80
		protected List<MonoUIContainer> _optionSubTabs; // 0x88
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		protected GameObject _grpBrowseInteelPanel; // 0x90
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		protected MonoSimpleReusableList _deployOptionList; // 0x98
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		protected MonoJoypadSimpleResuableListHandler _deployOptionInputHld; // 0xA0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		protected MonoGridScroller _furnitureGridScroller; // 0xA8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		protected MonoGridScroller _suiteGridScroller; // 0xB0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		protected MonoGridScroller _npcGridScroller; // 0xB8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		protected MonoGridScroller _animalGridScroller; // 0xC0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		protected GameObject _noContentTab; // 0xC8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		protected UnityEngine.UI.Text _noContentDescText; // 0xD0
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		protected MonoUIContainer _toggleRotateButton; // 0xD8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		protected MonoUIContainer _closeButton; // 0xE0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		protected MonoUIContainer _revertButton; // 0xE8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		protected MonoUIContainer _saveButton; // 0xF0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		protected MonoUIContainer _foldButton; // 0xF8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		protected MonoUIContainer _unfoldButton; // 0x100
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		protected MonoUIContainer _prevRoomButton; // 0x108
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		protected MonoUIContainer _nextRoomButton; // 0x110
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		protected UnityEngine.UI.Text _roomName; // 0x118
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		protected RectTransform _browseCursor; // 0x120
		// [Header] // 0x0000000189909430-0x0000000189909470
		[SerializeField] // 0x0000000189909430-0x0000000189909470
		protected Transform _grpDeploy; // 0x128
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		protected Transform _grpDeployRight; // 0x130
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		protected Transform _grpDeployJoypadLeft; // 0x138
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		protected GameObject[] _grpHideOnDeploying; // 0x140
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		protected UnityEngine.UI.Text _deployTitle; // 0x148
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		protected UnityEngine.UI.Text _deployDescription; // 0x150
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		protected UnityEngine.UI.Text _deployTabDesc; // 0x158
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		protected MonoUIContainer _deployCancelButton; // 0x160
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		protected MonoUIContainer _deployRecycleButton; // 0x168
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		protected MonoUIContainer _deployRotateButton; // 0x170
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		protected MonoUIContainer _deployConfirmButton; // 0x178
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		protected MonoUIContainer _deploySuiteButton; // 0x180
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private float alignMagnetRadiusInterior; // 0x188
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float alignMagnetRadiusExterior; // 0x18C
		public float alignMagnetRatio; // 0x190
		public float magnetAlignAngle; // 0x194
		public float gridSize; // 0x198
		public float gridSnapThresholdRatio; // 0x19C
		// [Header] // 0x0000000189979B60-0x0000000189979BA0
		[SerializeField] // 0x0000000189979B60-0x0000000189979BA0
		protected Transform _grpTouchController; // 0x1A0
		// [Header] // 0x0000000189985550-0x0000000189985580
		protected Transform _grpTopBar; // 0x1A8
		// [Header] // 0x000000018998E9F0-0x000000018998EA30
		[SerializeField] // 0x000000018998E9F0-0x000000018998EA30
		protected GameObject _grpAreaSwitch; // 0x1B0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		protected GameObject _areaSwitchRow; // 0x1B8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		protected MonoUIContainer _areaSwitchTabBackButton; // 0x1C0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		protected MonoUIContainer _areaSwitchTabBackBG; // 0x1C8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		protected UnityEngine.UI.Text _switchAreaTitle; // 0x1D0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		protected UnityEngine.UI.Text _switchAreaComfortText; // 0x1D8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		protected MonoGridScroller _areaScroller; // 0x1E0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		protected float _fadeSwitchArea; // 0x1E8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		protected float _fadeHoldSwitchArea; // 0x1EC
		// [Header] // 0x00000001899D6CE0-0x00000001899D6D10
		public MonoInputEasyTouch_H4 touchControl; // 0x1F0
		public MonoJoyStick_H4 moveControl; // 0x1F8
		public float zoomFadeOutTime; // 0x200
		public float rotateFadeOutTime; // 0x204
		public float moveFadeOutTime; // 0x208
		// [Header] // 0x00000001899DE360-0x00000001899DE3A0
		[SerializeField] // 0x00000001899DE360-0x00000001899DE3A0
		private float[] _rotateTimerLevel; // 0x210
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float[] _rotateScaleLevel; // 0x218
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _startDeployDeadZone; // 0x220
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _stopDeployDeadZone; // 0x224
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		protected GameObject _rotateDiscPrefabExterior; // 0x228
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		protected GameObject _rotateDiscPrefabInterior; // 0x230
		protected GameObject _rotateDisc; // 0x238
		protected GameObject _rotateCircle; // 0x240
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		protected float _rotateDiscExteriorScale; // 0x248
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		protected float _rotateDiscInteriorScale; // 0x24C
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		protected float _rotateSuiteInteriorScale; // 0x250
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		protected float _rotateSuiteExteriorScale; // 0x254
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		protected float _rotateDiscScreenOccupyRatio; // 0x258
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		protected float _rotateDiscMaxRatio; // 0x25C
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		protected float _rotateDiscFadeTime; // 0x260
		protected float minRotateDiscRatio; // 0x264
		protected float maxRotateDiscRatio; // 0x268
		protected bool _isRotateDiscExterior; // 0x26C
		// [Header] // 0x0000000189A41EA0-0x0000000189A41EE0
		[SerializeField] // 0x0000000189A41EA0-0x0000000189A41EE0
		protected Transform _settingPanel; // 0x270
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		protected UnityEngine.UI.Text _settingTitle; // 0x278
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		protected MonoReusableList _settingResuableList; // 0x280
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		protected MonoUIContainer _showSettingButton; // 0x288
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		protected MonoUIContainer _hideSettingButton; // 0x290
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		protected MonoUIContainer _hideSettingBGButton; // 0x298
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		protected float _dayTime; // 0x2A0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		protected float _nightTime; // 0x2A4
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		protected Vector2 _daytimePeriod; // 0x2A8
		protected MonoHomeworldSettingListItem _magnetTab; // 0x2B0
		protected MonoHomeworldSettingListItem _rotateTab; // 0x2B8
		protected MonoHomeworldSettingListItem _miscTab; // 0x2C0
		protected GameObject _gridMagnetSetting; // 0x2C8
		protected Toggle _gridMagnetToggle; // 0x2D0
		protected GameObject _furnitureAlignSetting; // 0x2D8
		protected Toggle _furnitureAlignToggle; // 0x2E0
		protected GameObject _standardRtateSetting; // 0x2E8
		protected Toggle _standardRotateToggle; // 0x2F0
		protected MonoToggleAnimator _standardRotateToggleMonoAnimator; // 0x2F8
		protected GameObject _randomRotateSetting; // 0x300
		protected Toggle _randomRotateToggle; // 0x308
		protected MonoToggleAnimator _randomRotateToggleMonoAnimator; // 0x310
		protected GameObject _lastRotateSetting; // 0x318
		protected Toggle _lastRotateToggle; // 0x320
		protected MonoToggleAnimator _lastRotateToggleMonoAnimator; // 0x328
		protected GameObject _dayNightSwitchSetting; // 0x330
		protected Toggle _dayNightSwitchToggle; // 0x338
		protected UnityEngine.UI.Text _dayNightText; // 0x340
		protected GameObject _resetCameraSetting; // 0x348
		protected Button _resetCameraButton; // 0x350
		protected GameObject _clearAllFurnitureSetting; // 0x358
		protected Button _clearAllFurnitureButton; // 0x360
		protected List<SettingItemHelper> _settingPanelItemList; // 0x368
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		protected MonoUIContainer _settingPageConfirmButtonPs4; // 0x370
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		protected MonoScrollRectExtention _settingPanelScrollRect; // 0x378
		protected const string GRID_PREFAB_PATH = "ART/Stages/Homeworld/Common/Feature/Homescene_Common_Feature_SelectionBox_Vo"; // Metadata: 0x00B11D32
		protected uint handle; // 0x380
		protected GameObject _gridPrefab; // 0x388
		protected Stack<GridGOData> reuseObjs; // 0x390
		protected bool _gridObjCollision; // 0x398
		protected float _magnetAlignAngle; // 0x39C
		// [Header] // 0x0000000189A99550-0x0000000189A995A0
		[SerializeField] // 0x0000000189A99550-0x0000000189A995A0
		protected UnityEngine.Material _nonColideMaterial; // 0x3A0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		protected UnityEngine.Material _collideMaterial; // 0x3A8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		protected UnityEngine.Material _nonColideMaterialHollow; // 0x3B0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		protected UnityEngine.Material _collideMaterialHollow; // 0x3B8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		protected float _placeColGridExtendRatio; // 0x3C0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		protected float _placeColGridExtendMax; // 0x3C4
		protected Dictionary<Collider, GridGOData> _gridGODict; // 0x3C8
		protected bool _isWall; // 0x3D0
		protected Transform _updateColTransform; // 0x3D8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		protected GameObject suiteDisc; // 0x3E0
		// [Header] // 0x0000000189AD2520-0x0000000189AD2570
		[SerializeField] // 0x0000000189AD2520-0x0000000189AD2570
		private GameObject _sitPointMarkerPrefab; // 0x3E8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.Material _sitPointMarkerMatBlue; // 0x3F0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.Material _sitPointMarkerMatRed; // 0x3F8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Vector3 _sitPointVerifyCenter; // 0x400
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Vector3 _sitPointVerifySize; // 0x40C
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _sitPointMarkerScale; // 0x418
		private Stack<GameObject> _sitPointMarkerPool; // 0x420
		private List<GameObject> _activeSitPoints; // 0x428
		private Stack<List<GameObject>> _entitySitPointListPool; // 0x430
		private List<List<GameObject>> _activeEntitySitPointLists; // 0x438
		private Dictionary<GadgetEntity, List<GameObject>> _entity2SitPointMarkDict; // 0x440
		// [Header] // 0x0000000189B04030-0x0000000189B04070
		[SerializeField] // 0x0000000189B04030-0x0000000189B04070
		protected GameObject _anchorMarker; // 0x448
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		protected float _anchorMarkerSizeExterior; // 0x450
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		protected float _anchorMarkerSizeInterior; // 0x454
	
		// Properties
		public Transform grpBrowse { /* [XID] */ /* 0x0000000189B1EB40-0x0000000189B1EB60 */ get => default; } // 0x0000000184B71D10-0x0000000184B71DB0 
		public Transform grpBrowseTop { /* [XID] */ /* 0x0000000189B26430-0x0000000189B26450 */ get => default; } // 0x0000000184B71C70-0x0000000184B71D10 
		public Transform grpBrowseJoypadLeft { /* [XID] */ /* 0x0000000189B2D6B0-0x0000000189B2D6D0 */ get => default; } // 0x0000000184B71BD0-0x0000000184B71C70 
		public UnityEngine.UI.Text comfortLevel { /* [XID] */ /* 0x0000000189B34B80-0x0000000189B34BA0 */ get => default; } // 0x0000000184B70790-0x0000000184B70830 
		public UnityEngine.UI.Text _typeNumer { /* [XID] */ /* 0x0000000189B3C390-0x0000000189B3C3B0 */ get => default; } // 0x0000000184B70040-0x0000000184B700E0 
		public GameObject[] costGOs { /* [XID] */ /* 0x0000000189B44000-0x0000000189B44020 */ get => default; } // 0x0000000184B70830-0x0000000184B708D0 
		public UnityEngine.UI.Text rockeryHintText { /* [XID] */ /* 0x0000000189B4B700-0x0000000189B4B720 */ get => default; } // 0x0000000184B73180-0x0000000184B73220 
		public UnityEngine.UI.Text rotateModeText { /* [XID] */ /* 0x0000000189B52D70-0x0000000189B52D90 */ get => default; } // 0x0000000184B732D0-0x0000000184B733C0 
		public Transform grpBrowseBottom { /* [XID] */ /* 0x0000000189B5A700-0x0000000189B5A720 */ get => default; } // 0x0000000184B71A80-0x0000000184B71B20 
		public List<MonoUIContainer> optionTabs { /* [XID] */ /* 0x0000000189B61BF0-0x0000000189B61C10 */ get => default; } // 0x0000000184B72B30-0x0000000184B72D20 
		public List<MonoUIContainer> optionSubTabs { /* [XID] */ /* 0x0000000189B69880-0x0000000189B698A0 */ get => default; } // 0x0000000184B72920-0x0000000184B72B30 
		public GameObject grpBrowseInteePanel { /* [XID] */ /* 0x0000000189B70E60-0x0000000189B70E80 */ get => default; } // 0x0000000184B71B20-0x0000000184B71BD0 
		public MonoSimpleReusableList deployOptionList { /* [XID] */ /* 0x0000000189B78410-0x0000000189B78430 */ get => default; } // 0x0000000184B70F70-0x0000000184B71020 
		public MonoJoypadSimpleResuableListHandler deployOptionInputHld { /* [XID] */ /* 0x0000000189B7F8D0-0x0000000189B7F8F0 */ get => default; } // 0x0000000184B70EC0-0x0000000184B70F70 
		public MonoGridScroller furnitureGridScroller { /* [XID] */ /* 0x0000000189B87420-0x0000000189B87440 */ get => default; } // 0x0000000184B71870-0x0000000184B71920 
		public MonoGridScroller suiteGridScroller { /* [XID] */ /* 0x0000000189B8E4F0-0x0000000189B8E510 */ get => default; } // 0x0000000184B73ED0-0x0000000184B73F80 
		public MonoGridScroller npcGridScroller { /* [XID] */ /* 0x0000000189B959B0-0x0000000189B959D0 */ get => default; } // 0x0000000184B72870-0x0000000184B72920 
		public MonoGridScroller animalGridScroller { /* [XID] */ /* 0x0000000189B9CF50-0x0000000189B9CF70 */ get => default; } // 0x0000000184B701E0-0x0000000184B70290 
		public GameObject noContentTab { /* [XID] */ /* 0x0000000189BA4870-0x0000000189BA4890 */ get => default; } // 0x0000000184B727C0-0x0000000184B72870 
		public UnityEngine.UI.Text noContentDescText { /* [XID] */ /* 0x0000000189BABB90-0x0000000189BABBB0 */ get => default; } // 0x0000000184B72710-0x0000000184B727C0 
		public Button toggleRotateButton { /* [XID] */ /* 0x0000000189BB3280-0x0000000189BB32A0 */ get => default; } // 0x0000000184B740E0-0x0000000184B741C0 
		public Button closeButton { /* [XID] */ /* 0x0000000189BBA860-0x0000000189BBA880 */ get => default; } // 0x0000000184B706D0-0x0000000184B70790 
		public Button revertButton { /* [XID] */ /* 0x0000000189BC2880-0x0000000189BC28A0 */ get => default; } // 0x0000000184B730A0-0x0000000184B73180 
		public Button saveButton { /* [XID] */ /* 0x0000000189BC9FE0-0x0000000189BCA000 */ get => default; } // 0x0000000184B73520-0x0000000184B73600 
		public Button foldButton { /* [XID] */ /* 0x0000000189BD16B0-0x0000000189BD16D0 */ get => default; } // 0x0000000184B71700-0x0000000184B717C0 
		public Button unfoldButton { /* [XID] */ /* 0x0000000189BD8CA0-0x0000000189BD8CC0 */ get => default; } // 0x0000000184B741C0-0x0000000184B74280 
		public Button prevRoomButton { /* [XID] */ /* 0x00000001895E5880-0x00000001895E58A0 */ get => default; } // 0x0000000184B72D20-0x0000000184B72DE0 
		public Button nextRoomButton { /* [XID] */ /* 0x00000001895ED1D0-0x00000001895ED1F0 */ get => default; } // 0x0000000184B725A0-0x0000000184B72660 
		public UnityEngine.UI.Text roomName { /* [XID] */ /* 0x00000001895F4850-0x00000001895F4870 */ get => default; } // 0x0000000184B73220-0x0000000184B732D0 
		public RectTransform browseCursor { /* [XID] */ /* 0x00000001895FBFC0-0x00000001895FBFE0 */ get => default; } // 0x0000000184B70570-0x0000000184B70620 
		public Transform grpDeploy { /* [XID] */ /* 0x0000000189603A00-0x0000000189603A20 */ get => default; } // 0x0000000184B71F10-0x0000000184B71FC0 
		public Transform grpDeployRight { /* [XID] */ /* 0x000000018960B360-0x000000018960B380 */ get => default; } // 0x0000000184B71E60-0x0000000184B71F10 
		public Transform grpDeployJoypadLeft { /* [XID] */ /* 0x0000000189612710-0x0000000189612730 */ get => default; } // 0x0000000184B71DB0-0x0000000184B71E60 
		public GameObject[] grpHideOnDeploying { /* [XID] */ /* 0x000000018961A030-0x000000018961A050 */ get => default; } // 0x0000000184B71FC0-0x0000000184B72070 
		public UnityEngine.UI.Text deployTitle { /* [XID] */ /* 0x0000000189621570-0x0000000189621590 */ get => default; } // 0x0000000184B714F0-0x0000000184B715A0 
		public UnityEngine.UI.Text deployDescription { /* [XID] */ /* 0x0000000189628E80-0x0000000189628EA0 */ get => default; } // 0x0000000184B70E10-0x0000000184B70EC0 
		public UnityEngine.UI.Text deployTabDesc { /* [XID] */ /* 0x0000000189630800-0x0000000189630820 */ get => default; } // 0x0000000184B71440-0x0000000184B714F0 
		public Button deployCancelButton { /* [XID] */ /* 0x00000001896382A0-0x00000001896382C0 */ get => default; } // 0x0000000184B70B90-0x0000000184B70C70 
		public Button deployRecycleButton { /* [XID] */ /* 0x000000018963F680-0x000000018963F6A0 */ get => default; } // 0x0000000184B710E0-0x0000000184B711C0 
		public GameObject deployRecycleButtonObj { /* [XID] */ /* 0x0000000189646E40-0x0000000189646E60 */ get => default; } // 0x0000000184B71020-0x0000000184B710E0 
		public Button deployRotateButton { /* [XID] */ /* 0x000000018964E5B0-0x000000018964E5D0 */ get => default; } // 0x0000000184B711C0-0x0000000184B712A0 
		public Transform deployConfirmTransform { /* [XID] */ /* 0x0000000189655DE0-0x0000000189655E00 */ get => default; } // 0x0000000184B70D50-0x0000000184B70E10 
		public Button deployConfirmButton { /* [XID] */ /* 0x000000018965D5A0-0x000000018965D5C0 */ get => default; } // 0x0000000184B70C70-0x0000000184B70D50 
		public Transform deploySuiteTransform { /* [XID] */ /* 0x0000000189664CC0-0x0000000189664CE0 */ get => default; } // 0x0000000184B71380-0x0000000184B71440 
		public Button deploySuiteButton { /* [XID] */ /* 0x000000018966C2C0-0x000000018966C2E0 */ get => default; } // 0x0000000184B712A0-0x0000000184B71380 
		public float alignMangetRadius { /* [XID] */ /* 0x0000000189674140-0x0000000189674160 */ get => default; } // 0x0000000184B700E0-0x0000000184B701E0 
		public Transform grpTouchController { /* [XID] */ /* 0x000000018967B980-0x000000018967B9A0 */ get => default; } // 0x0000000184B72120-0x0000000184B721D0 
		public Transform grpTopBar { /* [XID] */ /* 0x0000000189683090-0x00000001896830B0 */ get => default; } // 0x0000000184B72070-0x0000000184B72120 
		public GameObject grpAreaSwitch { /* [XID] */ /* 0x000000018968AB00-0x000000018968AB20 */ get => default; } // 0x0000000184B719D0-0x0000000184B71A80 
		public GameObject areaSwitchRow { /* [XID] */ /* 0x0000000189692860-0x0000000189692880 */ get => default; } // 0x0000000184B70340-0x0000000184B703F0 
		public Button showAreaSwitchTabBtn { /* [XID] */ /* 0x0000000189699BE0-0x0000000189699C00 */ get => default; } // 0x0000000184B73A20-0x0000000184B73B50 
		public Button areaSwitchTabBackButton { /* [XID] */ /* 0x00000001896A1300-0x00000001896A1320 */ get => default; } // 0x0000000184B704B0-0x0000000184B70570 
		public Button areaSwitchTabBackBackBG { /* [XID] */ /* 0x00000001896A8770-0x00000001896A8790 */ get => default; } // 0x0000000184B703F0-0x0000000184B704B0 
		public UnityEngine.UI.Text switchAreaTitle { /* [XID] */ /* 0x00000001896AF900-0x00000001896AF920 */ get => default; } // 0x0000000184B74030-0x0000000184B740E0 
		public UnityEngine.UI.Text switchAreaComfortText { /* [XID] */ /* 0x00000001896B7270-0x00000001896B7290 */ get => default; } // 0x0000000184B73F80-0x0000000184B74030 
		public MonoGridScroller areaScroller { /* [XID] */ /* 0x00000001896BE3C0-0x00000001896BE3E0 */ get => default; } // 0x0000000184B70290-0x0000000184B70340 
		public float fadeSwitchArea { /* [XID] */ /* 0x00000001896C5C30-0x00000001896C5C50 */ get => default; } // 0x0000000184B71650-0x0000000184B71700 
		public float fadeHoldSwitchArea { /* [XID] */ /* 0x00000001896CD3A0-0x00000001896CD3C0 */ get => default; } // 0x0000000184B715A0-0x0000000184B71650 
		public float[] rotateTimerLevel { /* [XID] */ /* 0x00000001896D47D0-0x00000001896D47F0 */ get => default; } // 0x0000000184B73470-0x0000000184B73520 
		public float[] rotateScaleLevel { /* [XID] */ /* 0x00000001896DBE70-0x00000001896DBE90 */ get => default; } // 0x0000000184B733C0-0x0000000184B73470 
		public float startDeployDeadZone { /* [XID] */ /* 0x00000001896E3640-0x00000001896E3660 */ get => default; } // 0x0000000184B73D70-0x0000000184B73E20 
		public float stopDeployDeadZone { /* [XID] */ /* 0x00000001896EAA60-0x00000001896EAA80 */ get => default; } // 0x0000000184B73E20-0x0000000184B73ED0 
		public float rateDiscFadeTime { /* [XID] */ /* 0x00000001896F1D60-0x00000001896F1D80 */ get => default; } // 0x0000000184B72F40-0x0000000184B72FF0 
		protected GameObject rotateDisc { /* [XID] */ /* 0x00000001896F97B0-0x00000001896F97D0 */ get => default; } // 0x0000000184B6BCB0-0x0000000184B6BDA0 
		public Transform settingPanel { /* [XID] */ /* 0x000000018972DA10-0x000000018972DA30 */ get => default; } // 0x0000000184B73810-0x0000000184B738C0 
		public UnityEngine.UI.Text settingTitle { /* [XID] */ /* 0x0000000189735190-0x00000001897351B0 */ get => default; } // 0x0000000184B73970-0x0000000184B73A20 
		public MonoReusableList settingResuableList { /* [XID] */ /* 0x000000018973CC10-0x000000018973CC30 */ get => default; } // 0x0000000184B738C0-0x0000000184B73970 
		public Button showSettingButton { /* [XID] */ /* 0x0000000189744190-0x00000001897441B0 */ get => default; } // 0x0000000184B73B50-0x0000000184B73C10 
		public Button hideSettingButton { /* [XID] */ /* 0x000000018974BE70-0x000000018974BE90 */ get => default; } // 0x0000000184B72290-0x0000000184B72350 
		public Button hideSettingBGButton { /* [XID] */ /* 0x0000000189753150-0x0000000189753170 */ get => default; } // 0x0000000184B721D0-0x0000000184B72290 
		public float dayTime { /* [XID] */ /* 0x000000018975A4C0-0x000000018975A4E0 */ get => default; } // 0x0000000184B70A30-0x0000000184B70AE0 
		public float nightTime { /* [XID] */ /* 0x00000001897621C0-0x00000001897621E0 */ get => default; } // 0x0000000184B72660-0x0000000184B72710 
		public Vector2 daytimePeriod { /* [XID] */ /* 0x0000000189769730-0x0000000189769750 */ get => default; } // 0x0000000184B70AE0-0x0000000184B70B90 
		public Toggle gridMagnetToggle { /* [XID] */ /* 0x0000000189770D30-0x0000000189770D50 */ get => default; } // 0x0000000184B71920-0x0000000184B719D0 
		public Toggle furnitureAlignToggle { /* [XID] */ /* 0x00000001897786C0-0x00000001897786E0 */ get => default; } // 0x0000000184B717C0-0x0000000184B71870 
		public Toggle standardRotateToggle { /* [XID] */ /* 0x000000018977FC20-0x000000018977FC40 */ get => default; } // 0x0000000184B73CC0-0x0000000184B73D70 
		public MonoToggleAnimator standardRotateToggleMonoAnimator { /* [XID] */ /* 0x0000000189787500-0x0000000189787520 */ get => default; } // 0x0000000184B73C10-0x0000000184B73CC0 
		public Toggle randomRotateToggle { /* [XID] */ /* 0x000000018978EAD0-0x000000018978EAF0 */ get => default; } // 0x0000000184B72E90-0x0000000184B72F40 
		public MonoToggleAnimator randomRotateToggleMonoAnimator { /* [XID] */ /* 0x0000000189796250-0x0000000189796270 */ get => default; } // 0x0000000184B72DE0-0x0000000184B72E90 
		public Toggle lastRotateToggle { /* [XID] */ /* 0x000000018979E390-0x000000018979E3B0 */ get => default; } // 0x0000000184B72400-0x0000000184B724B0 
		public MonoToggleAnimator lastRotateToggleMonoAnimator { /* [XID] */ /* 0x00000001897A5B10-0x00000001897A5B30 */ get => default; } // 0x0000000184B72350-0x0000000184B72400 
		public Toggle dayNightSwitchToggle { /* [XID] */ /* 0x00000001897AD080-0x00000001897AD0A0 */ get => default; } // 0x0000000184B708D0-0x0000000184B70980 
		public UnityEngine.UI.Text dayNightText { /* [XID] */ /* 0x00000001897B50B0-0x00000001897B50D0 */ get => default; } // 0x0000000184B70980-0x0000000184B70A30 
		public Button resetCameraButton { /* [XID] */ /* 0x00000001897BCCE0-0x00000001897BCD00 */ get => default; } // 0x0000000184B72FF0-0x0000000184B730A0 
		public Button clearAllFurnitureButton { /* [XID] */ /* 0x00000001897C4060-0x00000001897C4080 */ get => default; } // 0x0000000184B70620-0x0000000184B706D0 
		public List<SettingItemHelper> settingPanelItemList { /* [XID] */ /* 0x00000001897CB920-0x00000001897CB940 */ get => default; } // 0x0000000184B736B0-0x0000000184B73760 
		public MonoUIContainer settingPageConfirmButtonPs4 { /* [XID] */ /* 0x00000001897D3210-0x00000001897D3230 */ get => default; } // 0x0000000184B73600-0x0000000184B736B0 
		public MonoScrollRectExtention settingPanelScrollRect { /* [XID] */ /* 0x00000001897DAC90-0x00000001897DACB0 */ get => default; } // 0x0000000184B73760-0x0000000184B73810 
		public float magnetAlighDot { /* [XID] */ /* 0x000000018980F430-0x000000018980F450 */ get => default; } // 0x0000000184B724B0-0x0000000184B725A0 
	
		// Nested types
		public class GridGOData // TypeDefIndex: 31003
		{
			// Fields
			public GameObject gridGO; // 0x10
			public bool isCollide; // 0x18
			public bool isHollow; // 0x19
	
			// Constructors
			public GridGOData() {} // Dummy constructor
			public GridGOData(GameObject gridGO, bool isHollow) {} // 0x0000000184B5BA40-0x0000000184B5BAF0
		}
	
		public struct SettingItemHelper // TypeDefIndex: 31004
		{
			// Fields
			public Button selectButton; // 0x00
			public Component actionComponent; // 0x08
			public uint confirmButtonText; // 0x10
		}
	
		// Constructors
		public MonoHomeworldEditorPage() {} // 0x0000000184B6FC30-0x0000000184B70040
	
		// Methods
		// [XID] // 0x0000000189700FC0-0x0000000189700FE0
		public void InitRotateDisc() {} // 0x0000000184B6ADB0-0x0000000184B6B070
		// [XID] // 0x0000000189708700-0x0000000189708720
		public void SetRotateDiscActive(bool active, bool alignCameraForward = true /* Metadata: 0x00B11D26 */, bool showCircle = false /* Metadata: 0x00B11D27 */) {} // 0x0000000184B6C8C0-0x0000000184B6CA30
		// [XID] // 0x0000000189710070-0x0000000189710090
		private void ClearRotateDisc() {} // 0x0000000184B6A1D0-0x0000000184B6A330
		// [XID] // 0x00000001897173F0-0x0000000189717410
		public void UpdateRotateDiscForward() {} // 0x0000000184B6EE70-0x0000000184B6F160
		// [XID] // 0x000000018971EE70-0x000000018971EE90
		public void UpdateRotateDiscScale(CameraEntity cameraEntity) {} // 0x0000000184B6F160-0x0000000184B6F520
		// [XID] // 0x0000000189726410-0x0000000189726430
		public void SetRotateCircleActive(bool active) {} // 0x0000000184B6C7B0-0x0000000184B6C8C0
		// [XID] // 0x00000001897E2380-0x00000001897E23A0
		public void SetupSettingTab() {} // 0x0000000184B6E090-0x0000000184B6E6C0
		// [XID] // 0x00000001897E9AF0-0x00000001897E9B10
		protected void DelaySetupSetting() {} // 0x0000000184B6B070-0x0000000184B6B7D0
		// [XID] // 0x00000001897F17B0-0x00000001897F17D0
		private void BuildJotPadSettingMap() {} // 0x0000000184B6B7D0-0x0000000184B6BCB0
		// [XID] // 0x00000001897F8E80-0x00000001897F8EA0
		private void Awake() {} // 0x0000000184B6A0F0-0x0000000184B6A1D0
		// [XID] // 0x00000001898004B0-0x00000001898004D0
		private void OnDestroy() {} // 0x0000000184B6C0C0-0x0000000184B6C190
		// [XID] // 0x0000000189807B30-0x0000000189807B50
		public void SetDebugText(string text) {} // 0x0000000184B6C700-0x0000000184B6C7B0
		// [XID] // 0x0000000189816AC0-0x0000000189816AE0
		protected GridGOData GetGridFromStack(bool isHollow) => default; // 0x0000000184B6BDA0-0x0000000184B6BF10
		// [XID] // 0x000000018981E390-0x000000018981E3B0
		public void SetupCollisionGridForMonoPlaceCol(MonoHomeworldPlaceCol monoPlaceCol, bool isWall = false /* Metadata: 0x00B11D28 */, bool updateRotateDisc = true /* Metadata: 0x00B11D29 */, bool isHollow = false /* Metadata: 0x00B11D2A */) {} // 0x0000000184B6DBE0-0x0000000184B6DDC0
		// [XID] // 0x0000000189825820-0x0000000189825840
		public void SetupCollisionGridForCollider(Collider gridCollider, ColliderType colliderType, bool isWall = false /* Metadata: 0x00B11D2B */, bool updateRotateDisc = true /* Metadata: 0x00B11D2C */, bool isHollow = false /* Metadata: 0x00B11D2D */) {} // 0x0000000184B6CD90-0x0000000184B6DBE0
		// [XID] // 0x000000018982CFE0-0x000000018982D000
		public void UpdateRotateDisc(Transform colTransform, float discSize, bool isWall, bool isSuite = false /* Metadata: 0x00B11D2E */) {} // 0x0000000184B6F520-0x0000000184B6F8A0
		// [XID] // 0x00000001898347C0-0x00000001898347E0
		public void SetCollisionGridForFurniture(FurnitureDataInternal furnitureData, bool isCollide, bool forceRefresh = false /* Metadata: 0x00B11D2F */, bool updateSitPoint = true /* Metadata: 0x00B11D30 */) {} // 0x0000000184B6C310-0x0000000184B6C4E0
		// [XID] // 0x000000018983BE10-0x000000018983BE30
		public void SetCollisionGridState(Collider gridCollider, bool isCollide, bool forceRefresh = false /* Metadata: 0x00B11D31 */) {} // 0x0000000184B6C4E0-0x0000000184B6C700
		// [XID] // 0x0000000189843460-0x0000000189843480
		public void ClearCollisionGrid() {} // 0x0000000184B6A540-0x0000000184B6A840
		// [XID] // 0x000000018984A980-0x000000018984A9A0
		public void SetCameraRotateEnable(bool pitch, bool yaw, HomeworldEditCameraSetting setting) {} // 0x0000000184B6C190-0x0000000184B6C310
		// [XID] // 0x0000000189851D80-0x0000000189851DA0
		public void SetupFurnitureSuiteDisc(FurnitureSuiteDataInternal suiteData) {} // 0x0000000184B6DDC0-0x0000000184B6E090
		// [XID] // 0x0000000189859600-0x0000000189859620
		public void ClearFurnitureSuiteDisc() {} // 0x0000000184B6A840-0x0000000184B6A940
		// [XID] // 0x0000000189860740-0x0000000189860760
		private GameObject GetSitPointMarker() => default; // 0x0000000184B6BF10-0x0000000184B6C0C0
		// [XID] // 0x0000000189867E50-0x0000000189867E70
		private List<GameObject> GetEntitySitPointMarkerList() => default; // 0x0000000184B6AC90-0x0000000184B6ADB0
		// [XID] // 0x000000018986F3B0-0x000000018986F3D0
		public void SetupSitPointMarker(FurnitureDataInternal furnitureData) {} // 0x0000000184B6E6C0-0x0000000184B6ED10
		// [XID] // 0x00000001898769E0-0x0000000189876A00
		public void UpdateSitPointMarker(FurnitureDataInternal furnitureData) {} // 0x0000000184B6F8A0-0x0000000184B6FC30
		// [XID] // 0x000000018987E500-0x000000018987E520
		public void ClearSitPointMarker() {} // 0x0000000184B6A940-0x0000000184B6AC90
		// [XID] // 0x00000001898858B0-0x00000001898858D0
		public void SetupAnchorPointerMarker(bool active, Vector3 position, Quaternion rotation, bool exterior) {} // 0x0000000184B6CA30-0x0000000184B6CD90
		// [XID] // 0x000000018988CBA0-0x000000018988CBC0
		public void ClearAnchorPointerMarker() {} // 0x0000000184B6A400-0x0000000184B6A540
		// [XID] // 0x0000000189894270-0x0000000189894290
		public void UpdateAnchorPointerMarker(bool active, Vector3 position) {} // 0x0000000184B6ED10-0x0000000184B6EE70
		// [XID] // 0x000000018989B7E0-0x000000018989B800
		public void Clear3DUI() {} // 0x0000000184B6A330-0x0000000184B6A400
	}
}
