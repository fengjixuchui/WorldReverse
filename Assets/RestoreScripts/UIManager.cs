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
using UnityEngine.Scripting;
using UnityEngine.UI;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class UIManager : GlobalManager // TypeDefIndex: 21353
{
    // Fields
    private LinkedList<BaseContext> _inputContextList; // 0x10
    private HashSet<BaseContext> _inputContextSet; // 0x18
    private PCCursorMode _currCursorMode; // 0x20
    public UIPlatformConfig platformConfig; // 0x28
    public uint _curProfileHandle; // 0x30
    private Canvas _sceneCanvas; // 0x38
    private Camera _uiCamera; // 0x40
    private Stack<BasePageContext> _pageContextStack; // 0x48
    private List<BaseDialogContext> _rootDialogContextList; // 0x50
    private List<BaseWidgetContext> _widgetContextList; // 0x58
    private List<BaseContext> _tickContextList; // 0x60
    private List<BaseContext> _lateTickContextList; // 0x68
    private List<BaseDialogContext> _cacheDialogContextList; // 0x70
    private Dictionary<int, DoublyList<UIShowCache>> _cachedLockingContexts; // 0x78
    public Dictionary<int, int> _lockPriorityCounts; // 0x80
    public UIShowPriority _curLockPriority; // 0x88
    private Dictionary<System.Type, BaseContextData> _contextDatas; // 0x90
    private Dictionary<uint, AnnounceData> _announceDatas; // 0x98
    private ViewCache _pageViewCache; // 0xA0
    private ViewCache _dialogViewCache; // 0xA8
    private ViewCache _widgetViewCache; // 0xB0
    private int _showingContext; // 0xB8
    private Dictionary<string, HandleItem> _pathHandleDic; // 0xC0
    private MonoBaseCanvas _levelCanvas; // 0xD0
    private CameraClearFlags _curClearFlag; // 0xD8
    private FixedStack<bool> _isUICameraEnableStack; // 0xE0
    private bool _needRefreshUICameraEnable; // 0xE8
    private bool _enableJoypadVirtualCursor; // 0xE9
    private bool _isWindowsPotrait; // 0xEA
    private List<string> _uiResolitions; // 0xF0
    private int _canvasSizeLevel; // 0xF8
    private Vector2 _currReferenceResolution; // 0xFC
    private List<Resolution> _windowResolutions; // 0x108
    private int _currWindowResIndex; // 0x110
    public UnityAction OnResolutionChanged; // 0x118
    private static Dictionary<System.Type, UIMetaInfo> _metaInfos; // 0x00
    private bool _hideUI; // 0x124
    private SaveData _saveData; // 0x128
    private const string ROOT_CANVAS_PREFAB_PATH = "EmbededRes/ART/UI/RootCanvas"; // Metadata: 0x00AFF50C
    private uint _rootCanvasPrefabHandle; // 0x130
    private GameObject _rootCanvasPrefab; // 0x138
    private MonoBaseCanvas _rootCanvasInstance; // 0x140
    private bool _isMobilePlatform; // 0x148
    private List<BaseGroupContext> _groupContextList; // 0x150
    private BaseGroupContext _curGroupContext; // 0x158
    private TipsDialogContext _normalMessageDialog; // 0x160
    private InfoTextDialogContext _infoDialogContext; // 0x168
    private InfoTextDialogContext _rootInfoDialogContext; // 0x170
    private InfoTextDialogContext _infoDialogContextWithoutBlockInput; // 0x178
    public const string CONFIG_PATH = "Data/UI/UIPreloadConfig"; // Metadata: 0x00AFF52C
    private List<uint> _preloadResHandled; // 0x180
    private Dictionary<int, AsyncJob> _preloadResJob; // 0x188
    private FixedStack<bool> _isResAsyncLoadStack; // 0x190
    private FixedStack<bool> _isUIIconAsyncLoadStack; // 0x198
    private ShopType _curOpenMallType; // 0x1A0
    private const int MAX_SAVE_ORDER_COUNT = 20; // Metadata: 0x00AFF547
    private List<uint> _filterDataList; // 0x1A8
    private HashSet<uint> _showingOrderSet; // 0x1B0
    private Dictionary<NewbieDialogContext, RectTransform> _allMaskTransDict; // 0x1B8
    public const string SCENEUISETUP_PREFAB_PATH = "ART/UI/UIScene/SceneUISetup"; // Metadata: 0x00AFF54B
    private GameObject _sceneUIObj; // 0x1C0
    public InputCurtainDialogContext _inputCurtain; // 0x1C8
    public CurtainDialogContext _curtain; // 0x1D0
    private WaitingRspWidgetContext _connectingWidgetContext; // 0x1D8
    private HashSet<int> _connectingWidgetTagSet; // 0x1E0
    private const string DEFAULT_CURSOR_PATH = "EmbededRes/Build/Others/Cursor"; // Metadata: 0x00AFF56A
    private const string DEFAULT_MAP_CURSOR_PATH = "EmbededRes/Build/Others/MapCursor"; // Metadata: 0x00AFF58C
    private GameObject _cursorPrefab; // 0x1E8
    private GameObject _mapCursorPrefab; // 0x1F0
    private uint _cursorHandle; // 0x1F8
    private uint _mapCursorHandle; // 0x1FC
    private Transform _virtualCursor; // 0x200
    private Transform _virtualMapCursor; // 0x208
    private UIVirtualCursorType _cursorType; // 0x210
    private bool _virtualCursorVisible; // 0x214
    private int currentEffectPatternId; // 0x21C
    private StaminaType _staminaType; // 0x220
    private int _selectedCharIndex; // 0x224
    private ulong _selectedAvatarId; // 0x228
    private const string DISPLAY_SAFE_AREA_INDICATOR_PREFAB_PATH = "ART/UI/Menus/Widget/DisplaySafeAreaIndicator"; // Metadata: 0x00AFF5B1
    private uint _displaySafeAreaIndicatorPrefabHandle; // 0x230
    private GameObject _displaySafeAreaIndicatorPrefab; // 0x238
    private GameObject _displaySafeAreaIndicatorInstance; // 0x240
    private LoadingDialogType _loadingDialogType; // 0x248
    private LoadingSituationType _loadingSituationType; // 0x24C
    private LoadingSituationType _loadingPicType; // 0x250
    private uint _loadingCfgID; // 0x254
    private string[] _loadingDialogTextMapId; // 0x258
    private float _loadingDialogTextShowTime; // 0x260
    private string _mpLoadingText; // 0x268
    private BaseLoadingDialogContext _loadingContext; // 0x270
    private uint _maskHandle; // 0x278
    private GameObject _maskCanvas; // 0x280
    private const string _maskPrefabPath = "ART/UI/EmbededUI/MaskCanvas"; // Metadata: 0x00AFF5E1
    private bool _reinitClearing; // 0x288
    private Dictionary<uint, object> _cachedGeneralInteeNotify; // 0x290
    private Coroutine _coMainUICheck; // 0x298
    private Dictionary<string, MonoLikingBar> _likingBars; // 0x2A0
    private GameObject _likingBarPrefab; // 0x2A8
    private FixType miniMapFixType; // 0x2B0
    private CharacterSelectPageContext characterSelectPageContext; // 0x2B8
    private List<Notify> _cachedUINotifyList; // 0x2C0
    private RuntimeInfoViewDialogContext _runtimeViewDlg; // 0x2C8
    private HashSet<UIBanType> _uiBanSet; // 0x2D0

    // Properties
    public LinkedList<BaseContext> inputContextList { /* [XID] */ /* 0x00000001896C48C0-0x00000001896C48E0 */ get => default; } // 0x00000001812AA830-0x00000001812AA8D0 
    public Canvas SceneCanvas { /* [XID] */ /* 0x0000000189A2E410-0x0000000189A2E430 */ get => default; /* [XID] */ /* 0x0000000189707480-0x00000001897074A0 */ private set { } } // 0x000000018129E2A0-0x000000018129E3F0 0x00000001812B6A20-0x00000001812B6AD0
    public Camera uiCamera { /* [XID] */ /* 0x000000018970ED40-0x000000018970ED60 */ get => default; /* [XID] */ /* 0x0000000189716140-0x0000000189716160 */ private set { } } // 0x00000001812A9150-0x00000001812A91F0 0x00000001812A3FA0-0x00000001812A4050
    public Dictionary<uint, AnnounceData> announceDatas { /* [XID] */ /* 0x000000018971DBA0-0x000000018971DBC0 */ get => default; } // 0x00000001812AAA60-0x00000001812AAB10 
    public BasePageContext CurrentPageContext { /* [XID] */ /* 0x00000001898C6850-0x00000001898C6870 */ get => default; } // 0x00000001812B1B10-0x00000001812B1BF0 
    public List<BaseDialogContext> rootDialogList { /* [XID] */ /* 0x000000018979F7F0-0x000000018979F810 */ get => default; } // 0x00000001812AB490-0x00000001812AB530 
    public List<BaseWidgetContext> widgetList { /* [XID] */ /* 0x00000001897A6CC0-0x00000001897A6CE0 */ get => default; } // 0x00000001812ADED0-0x00000001812ADF70 
    public CanvasScaler canvasScaler { /* [XID] */ /* 0x00000001897D07F0-0x00000001897D0830 */ get; /* [XID] */ /* 0x00000001897DB210-0x00000001897DB250 */ set; } // 0x00000001812B5A50-0x00000001812B5AB0 0x00000001812B7160-0x00000001812B71D0
    public MonoBaseCanvas levelCanvas { /* [XID] */ /* 0x00000001897E58C0-0x00000001897E58E0 */ get => default; } // 0x00000001812A1520-0x00000001812A15D0 
    public List<string> uiResolutionOptions { /* [XID] */ /* 0x000000018995BC20-0x000000018995BC40 */ get => default; } // 0x00000001812A1E50-0x00000001812A1F00 
    public int canvasSizeLevel { /* [XID] */ /* 0x00000001899637A0-0x00000001899637C0 */ get => default; /* [XID] */ /* 0x000000018996ABE0-0x000000018996AC00 */ set { } } // 0x00000001812A1670-0x00000001812A1710 0x00000001812AB110-0x00000001812AB280
    private Vector2 initialReferenceResolution { /* [XID] */ /* 0x0000000189996AA0-0x0000000189996AC0 */ get => default; } // 0x00000001812A35A0-0x00000001812A3730 
    public List<Resolution> windowResolutions { /* [XID] */ /* 0x000000018999E5F0-0x000000018999E610 */ get => default; } // 0x000000018129E3F0-0x000000018129E4A0 
    public int currWindowResolutionIndex { /* [XID] */ /* 0x00000001899A5FF0-0x00000001899A6010 */ get => default; } // 0x00000001812A0A60-0x00000001812A0B00 
    private LayoutVersion initLayoutVersion { /* [XID] */ /* 0x00000001899E1C90-0x00000001899E1CB0 */ get => default; } // 0x00000001812ABB00-0x00000001812ABC30 
    public LayoutVersion layoutVersion { /* [XID] */ /* 0x00000001899E9070-0x00000001899E90B0 */ get; /* [XID] */ /* 0x00000001899F3B30-0x00000001899F3B70 */ private set; } // 0x00000001812B5BF0-0x00000001812B5C50 0x00000001812B5D60-0x00000001812B5DD0
    private TipsDialogContext normalMessageDialog { /* [XID] */ /* 0x0000000189AC7FB0-0x0000000189AC7FD0 */ get => default; } // 0x00000001812AE580-0x00000001812AE670 
    public InfoTextDialogContext infoDialogContext { /* [XID] */ /* 0x0000000189B96E20-0x0000000189B96E40 */ get => default; } // 0x00000001812A7630-0x00000001812A7720 
    public InfoTextDialogContext rootInfoDialogContext { /* [XID] */ /* 0x00000001897870F0-0x0000000189787110 */ get => default; } // 0x000000018129DFD0-0x000000018129E130 
    public InfoTextDialogContext infoDialogContextWithoutBlockInput { /* [XID] */ /* 0x0000000189B11DA0-0x0000000189B11DC0 */ get => default; } // 0x00000001812AD480-0x00000001812AD580 
    public bool isUISceneEnable { /* [XID] */ /* 0x0000000189BB0A50-0x0000000189BB0A70 */ get => default; } // 0x00000001812A08A0-0x00000001812A09B0 
    public Transform virtualCursor { /* [XID] */ /* 0x0000000189626200-0x0000000189626220 */ get => default; } // 0x00000001812B6AD0-0x00000001812B6B90 
    public Texture2D cursorTexture { /* [XID] */ /* 0x000000018986D920-0x000000018986D940 */ get => default; } // 0x00000001812AEAD0-0x00000001812AEBD0 
    public Texture2D homeCursorTexture { /* [XID] */ /* 0x00000001896532E0-0x0000000189653300 */ get => default; } // 0x00000001812A59C0-0x00000001812A5AC0 
    public ActionPanelType actionPanelType { /* [XID] */ /* 0x0000000189662000-0x0000000189662040 */ get; /* [XID] */ /* 0x000000018966C800-0x000000018966C840 */ set; } // 0x00000001812AA8D0-0x00000001812AA930 0x00000001812AB280-0x00000001812AB2F0
    public StaminaType staminaType { /* [XID] */ /* 0x000000018968E330-0x000000018968E350 */ get => default; /* [XID] */ /* 0x0000000189695BF0-0x0000000189695C10 */ set { } } // 0x00000001812B22C0-0x00000001812B2360 0x00000001812A7720-0x00000001812A7800
    public float DisplaySafeAreaRatio { /* [XID] */ /* 0x00000001896D7CB0-0x00000001896D7CD0 */ get => default; } // 0x000000018129E590-0x000000018129E640 
    public LoadingDialogType loadingDialogType { /* [XID] */ /* 0x00000001896EDE90-0x00000001896EDEB0 */ get => default; /* [XID] */ /* 0x00000001897D46F0-0x00000001897D4710 */ set { } } // 0x00000001812AEBD0-0x00000001812AEC70 0x00000001812A34F0-0x00000001812A35A0
    public LoadingSituationType loadingSituationType { /* [XID] */ /* 0x00000001896FCEF0-0x00000001896FCF10 */ get => default; /* [XID] */ /* 0x00000001896F56D0-0x00000001896F56F0 */ set { } } // 0x00000001812A21C0-0x00000001812A2260 0x00000001812A09B0-0x00000001812A0A60
    public LoadingSituationType loadingPicType { /* [XID] */ /* 0x000000018970BBD0-0x000000018970BBF0 */ get => default; /* [XID] */ /* 0x0000000189704340-0x0000000189704360 */ set { } } // 0x00000001812A54F0-0x00000001812A5590 0x00000001812A4050-0x00000001812A4100
    public uint loadingCfgID { /* [XID] */ /* 0x0000000189713440-0x0000000189713460 */ set { } } // 0x000000018129EB30-0x000000018129EBE0
    public string[] loadingDialogTextMapId { /* [XID] */ /* 0x0000000189809050-0x0000000189809070 */ get => default; /* [XID] */ /* 0x000000018971ACE0-0x000000018971AD00 */ set { } } // 0x00000001812A4100-0x00000001812A41B0 0x00000001812A0C30-0x00000001812A0CE0
    public float loadingDialogTextShowTime { /* [XID] */ /* 0x0000000189730F00-0x0000000189730F20 */ get => default; /* [XID] */ /* 0x0000000189729710-0x0000000189729730 */ set { } } // 0x00000001812B78C0-0x00000001812B7970 0x00000001812AA020-0x00000001812AA0D0
    public bool IsReInitClearing { /* [XID] */ /* 0x00000001898311E0-0x0000000189831200 */ get => default; } // 0x00000001812A1CF0-0x00000001812A1DA0 
    public FixType MiniMapFixType { /* [XID] */ /* 0x00000001897F4AF0-0x00000001897F4B10 */ get => default; /* [XID] */ /* 0x00000001897ED390-0x00000001897ED3B0 */ set { } } // 0x000000018129F8F0-0x000000018129F990 0x00000001812AEF70-0x00000001812AF0B0

    // Nested types
    private class HandleItem : IReusable // TypeDefIndex: 21354
    {
        // Properties
        public uint handle { /* [XID] */ /* 0x00000001898E0D70-0x00000001898E0DB0 */ get; /* [XID] */ /* 0x00000001898EB770-0x00000001898EB7B0 */ set; } // 0x000000018153D500-0x000000018153D560 0x000000018153D4A0-0x000000018153D500
        public int count { /* [XID] */ /* 0x00000001898F6120-0x00000001898F6160 */ get; /* [XID] */ /* 0x0000000189900A50-0x0000000189900A90 */ set; } // 0x000000018153D560-0x000000018153D5C0 0x000000018153D440-0x000000018153D4A0

        // Nested types
        public class Spawner : ISpawner<HandleItem> // TypeDefIndex: 21355
        {
            // Constructors
            public Spawner() { } // 0x000000018153D2D0-0x000000018153D330

            // Methods
            // [XID] // 0x0000000189912BA0-0x0000000189912BC0
            public HandleItem Spawn() => default; // 0x000000018153D1D0-0x000000018153D2D0
        }

        // Constructors
        public HandleItem() { } // 0x000000018153D5C0-0x000000018153D620

        // Methods
        // [XID] // 0x000000018990AF30-0x000000018990AF50
        public void BeforeRecycle() { } // 0x000000018153D330-0x000000018153D440
    }

    public enum UICameraEnableType // TypeDefIndex: 21356
    {
        Default = 0,
        TimeLine = 1,
        Hide = 2,
        Count = 3
    }

    [Serializable]
    public class SaveData // TypeDefIndex: 21357
    {
        // Fields
        public int currWindowResolutionIndex; // 0x10

        // Constructors
        public SaveData() { } // 0x000000018156BF00-0x000000018156CA40
    }

    public enum AsyncLoadType // TypeDefIndex: 21358
    {
        Default = 0,
        UIPage = 1,
        Load = 2,
        Count = 3
    }

    public enum DisconnectHintType // TypeDefIndex: 21359
    {
        Cutscene = 0,
        TeamPage = 1,
        Dungeon = 2,
        Disconnect = 3,
        BuyGachaItem = 4,
        Pay = 5,
        Download = 6
    }

    public enum LoadingDialogType // TypeDefIndex: 21360
    {
        Default = 0,
        Quest = 1,
        ChangeStage = 2,
        FirstEnter = 3,
        MPLoading = 4
    }

    public enum LoadingSituationType // TypeDefIndex: 21361
    {
        Default = 0,
        GoToMengdeCity = 1,
        GoToMengdeField = 2,
        GoToLiyueCity = 3,
        GoToLiyueField = 4,
        EnterQuestDungeon = 5,
        EnterDailyDungeon = 6,
        EnterTower = 7,
        EnterRoom = 8,
        Login = 9,
        Logout = 10,
        Revival = 11,
        GoToDragonSpine = 12,
        GoToHomeWorld = 13
    }

    public enum FixType // TypeDefIndex: 21362
    {
        FixSight = 0,
        FixDirection = 1
    }

    public enum UIBanType // TypeDefIndex: 21363
    {
        None = 0,
        Team = 1,
        QuickWidget = 2,
        Time = 3,
        Bag = 4,
        Kick = 5
    }

    // Constructors
    private UIManager() { } // 0x00000001812B7F30-0x00000001812B85E0
    static UIManager() { } // 0x00000001812B7EA0-0x00000001812B7F30

    // Methods
    // [XID] // 0x00000001896CBE50-0x00000001896CBE70
    public void AddToInputContextList(BaseContext context) { } // 0x00000001812ABEC0-0x00000001812AC0D0
                                                               // [XID] // 0x0000000189883970-0x0000000189883990
    public void RemoveFromInputContextList(BaseContext context) { } // 0x00000001812A6910-0x00000001812A6A40
                                                                    // [XID] // 0x000000018987C8B0-0x000000018987C8D0
    private bool CompareContextLayer(BaseContext contextX, BaseContext contextY) => default; // 0x00000001812AB800-0x00000001812AB8F0
                                                                                             // [XID] // 0x00000001896E2500-0x00000001896E2520
    public void RefreshCurrCursorMode() { } // 0x00000001812B41F0-0x00000001812B4430
                                            // [XID] // 0x00000001896E9A00-0x00000001896E9A20
    public PCCursorMode GetCurrCursorMode() => default; // 0x00000001812AFA20-0x00000001812AFAC0
                                                        // [XID] // 0x000000018985E910-0x000000018985E930
    public void SetCurrCursorMode(PCCursorMode mode) { } // 0x00000001812AB3D0-0x00000001812AB490
                                                         // [XID] // 0x00000001898660D0-0x00000001898660F0
    public void RefreshCursorShow() { } // 0x00000001812B2520-0x00000001812B2680
                                        // [XID] // 0x000000018973B630-0x000000018973B650
    private void InitViewCache() { } // 0x00000001812A23B0-0x00000001812A2520
                                     // [XID] // 0x00000001897430E0-0x0000000189743100
    private bool InOherPage() => default; // 0x00000001812A1F00-0x00000001812A2000
                                          // [XID] // 0x000000018974AC40-0x000000018974AC60
    public void InitConfig(string configName) { } // 0x00000001812B02D0-0x00000001812B0550
                                                  // [IDTag] // 0x0000000189751CD0-0x0000000189751D10
                                                  // [XID] // 0x0000000189751CD0-0x0000000189751D10
    public override void Init() { } // 0x00000001812AC180-0x00000001812AC410
                                    // [XID] // 0x000000018975C250-0x000000018975C270
    public override void InitByLocalData() { } // 0x00000001812AC0D0-0x00000001812AC180
                                               // [IDTag] // 0x0000000189763C00-0x0000000189763C40
                                               // [XID] // 0x0000000189763C00-0x0000000189763C40
    public void Init(GlobalVars.WorldType worldType, bool isReInit = false /* Metadata: 0x00AFF4CC */)
    {
        InitUICamera();
        BasePageContext content = null;
        switch (worldType)
        {
            case GlobalVars.WorldType.Home:
                content = new LoginMainPageContext();
                ShowPage(content, true, UIShowPriority.Init);
                break;
            case GlobalVars.WorldType.RagdollScene:
            case GlobalVars.WorldType.MoveTestScene:
            case GlobalVars.WorldType.DevLevel:
                content = new InLevelMainPageContext();
                ShowPage(content, true, UIShowPriority.Init);
                break;
            case GlobalVars.WorldType.BundleDownload:
                content = new BundleDownloadPageContext();
                ShowPage(content, true, UIShowPriority.Init);
                break;
        }
        ResetInput();
        if (Singleton<InputManager>.Instance != null)
            Singleton<InputManager>.Instance.InitOnSceneLoaded();
        _reinitClearing = false;
        FireCachedInteeAppearNotify();
        UnlockUI(UIShowPriority.Init, true);
        UpdateByCameraChange();
        CheckMallOnInit(isReInit);
        FireAllNotifyInCachedNotifyList();
    } // 0x00000001812A6D60-0x00000001812A6F80
      // [XID] // 0x000000018976E100-0x000000018976E120
    public override void Tick()
    {
        foreach (var context in _tickContextList)
        {
            context.Tick();
        }
        if (uiCamera && _needRefreshUICameraEnable)
        {
            uiCamera.enabled = _isUICameraEnableStack.value;
            _needRefreshUICameraEnable = false;
        }
        CheckAndBlockTouch();
    } // 0x00000001812B7B50-0x00000001812B7EA0
      // [XID] // 0x0000000189775940-0x0000000189775960
    public override void LateTick()
    {
        foreach (var context in _lateTickContextList)
        {
            context.LateTick();
        }
    } // 0x00000001812B0C10-0x00000001812B0DA0
      // [XID] // 0x000000018977D1C0-0x000000018977D1E0
    public override void Destroy() { } // 0x00000001812A41B0-0x00000001812A42F0
                                       // [XID] // 0x0000000189784B80-0x0000000189784BA0
    public override void ClearOnLevelDestroy() { } // 0x00000001812A2C00-0x00000001812A2F20
                                                   // [XID] // 0x000000018978C110-0x000000018978C130
    public override void ClearOnDisconnect() { } // 0x00000001812A2980-0x00000001812A2C00
                                                 // [XID] // 0x0000000189793640-0x0000000189793660
    public override void ClearOnBackHome(bool forceClear = true /* Metadata: 0x00AFF4CD */) { } // 0x00000001812A28B0-0x00000001812A2980
                                                                                                // [XID] // 0x000000018979B870-0x000000018979B890
    public override void ReloadRes() { } // 0x00000001812B7A80-0x00000001812B7B50
                                         // [XID] // 0x00000001897A2C60-0x00000001897A2C80
    public AsyncJob GetUIInstance(string path, UnityAction<GameObject, uint> callback) => default; // 0x000000018129F650-0x000000018129F8F0
                                                                                                   // [XID] // 0x000000018964F910-0x000000018964F930
    public void Abort(string path, bool cacheLast = false /* Metadata: 0x00AFF4CE */) { } // 0x00000001812AFE70-0x00000001812B0060
                                                                                          // [XID] // 0x00000001897B1CD0-0x00000001897B1CF0
    public void RecycleUIInstance(string path, GameObject uiInstance, bool cacheLast = false /* Metadata: 0x00AFF4CF */, bool lightRecycle = false /* Metadata: 0x00AFF4D0 */, bool useGameObjectPool = true /* Metadata: 0x00AFF4D1 */) { } // 0x00000001812A9D10-0x00000001812AA020
                                                                                                                                                                                                                                             // [XID] // 0x00000001897B9750-0x00000001897B9770
    public void ClearUIInstance() { } // 0x00000001812A8C40-0x00000001812A8E80
    public T AllocateContextData<T>()
        where T : BaseContextData, new() => default;
    public T GetContextData<T>()
        where T : BaseContextData => default;
    public void DeallocateContextData<T>(ref T data)
        where T : BaseContextData
    { }
    // [XID] // 0x00000001897C1780-0x00000001897C17A0
    private void DataClearOnLevelDestroy() { } // 0x00000001812B5EF0-0x00000001812B61B0
                                               // [XID] // 0x00000001897C91E0-0x00000001897C9200
    private void DataClearOnBackHomeDestroy() { } // 0x000000018129E750-0x000000018129EA10
                                                  // [XID] // 0x00000001897ED3B0-0x00000001897ED3D0
    public void InitUICamera() { } // 0x00000001812ADF70-0x00000001812AE350
                                   // [XID] // 0x00000001897F4B10-0x00000001897F4B30
    private bool HasEnableRenderCamera() => default; // 0x00000001812A0600-0x00000001812A08A0
                                                     // [XID] // 0x00000001897FC600-0x00000001897FC620
    private bool HasEnableMapCamera() => default; // 0x00000001812AB5F0-0x00000001812AB800
                                                  // [XID] // 0x0000000189803B30-0x0000000189803B50
    private bool HasEnableUI3DCamera() => default; // 0x00000001812A7F80-0x00000001812A8190
                                                   // [XID] // 0x000000018980AFF0-0x000000018980B010
    public void UpdateByCameraChange() { } // 0x00000001812B1370-0x00000001812B14A0
                                           // [XID] // 0x0000000189812680-0x00000001898126A0
    private void InitUICameraStack() { } // 0x00000001812AC4E0-0x00000001812AC690
                                         // [XID] // 0x000000018981A2E0-0x000000018981A300
    public void EnableUICamera(bool enable, UICameraEnableType type) { } // 0x00000001812AE880-0x00000001812AE980
                                                                         // [XID] // 0x00000001896EED80-0x00000001896EEDA0
    private void ResetInput() { } // 0x00000001812A2260-0x00000001812A23B0
                                  // [XID] // 0x0000000189828F80-0x0000000189828FA0
    public void ForceClearAll() { } // 0x00000001812AD580-0x00000001812AD670
                                    // [XID] // 0x00000001896E76C0-0x00000001896E76E0
    public void ReInit() { } // 0x00000001812A9830-0x00000001812A99C0
                             // [XID] // 0x0000000189996160-0x0000000189996180
    private void CheckMidPkgDownload() { } // 0x00000001812AA930-0x00000001812AAA60
                                           // [XID] // 0x000000018983F2D0-0x000000018983F2F0
    public void RefreshCurrentPage() { } // 0x00000001812AED80-0x00000001812AEF70
                                         // [XID] // 0x0000000189846910-0x0000000189846930
    private void Clear(bool clearAlwaysCache, bool forceClearall = false /* Metadata: 0x00AFF4D2 */) { } // 0x00000001812A7800-0x00000001812A7D40
    public T GetPageContext<T>()
        where T : BaseContext => default;
    public int GetPageContextNum<T>()
        where T : BaseContext => default;
    // [XID] // 0x000000018984DE80-0x000000018984DEA0
    public int GetShowingContext() => default; // 0x00000001812A5740-0x00000001812A57E0
                                               // [XID] // 0x0000000189854F30-0x0000000189854F50
    public void LoadInstancedView(BaseContext context, Action<GameObject> onLoadResult, bool anyncLoad = true /* Metadata: 0x00AFF4D3 */) { } // 0x00000001812A3E50-0x00000001812A3FA0
                                                                                                                                              // [XID] // 0x000000018985C6D0-0x000000018985C6F0
    public void LoadInstancedViewByObj(BaseContext context, Action<GameObject> onLoadResult, GameObject obj) { } // 0x00000001812A6810-0x00000001812A6910
                                                                                                                 // [XID] // 0x0000000189864050-0x0000000189864070
    public void ReleaseInstancedView(BaseContext context) { } // 0x00000001812A0090-0x00000001812A0200
                                                              // [XID] // 0x00000001897E98A0-0x00000001897E98C0
    public void ReleaseInstancedViewWithoutObj(BaseContext context) { } // 0x00000001812AE350-0x00000001812AE4C0
                                                                        // [XID] // 0x0000000189872770-0x0000000189872790
    public void ClearViewCache(bool includeAlwaysCache = false /* Metadata: 0x00AFF4D4 */) { } // 0x00000001812AFD10-0x00000001812AFE70
                                                                                               // [XID] // 0x000000018987A390-0x000000018987A3B0
    public void ResetViewCache(bool markAlreadyDontDestroyOnLoad) { } // 0x00000001812A03D0-0x00000001812A04D0
                                                                      // [XID] // 0x0000000189881520-0x0000000189881540
    public void MountContextView(BaseContext context) { } // 0x00000001812AF490-0x00000001812AF740
                                                          // [XID] // 0x0000000189888A80-0x0000000189888AA0
    private Transform GetViewParent(BaseContext context) => default; // 0x00000001812B6CF0-0x00000001812B6DC0
                                                                     // [XID] // 0x000000018988FE60-0x000000018988FE80
    public Transform GetCanvasMountPoint(CanvasType canvasType, int layerOrder) => default; // 0x00000001812ACAE0-0x00000001812ACD40
                                                                                            // [XID] // 0x00000001898973A0-0x00000001898973C0
    public BaseDialogContext GetDialogByName(string name) => default; // 0x00000001812B0130-0x00000001812B02D0
    public T GetDialog<T>()
        where T : BaseDialogContext => default;
    public T GetWidget<T>()
        where T : BaseWidgetContext => default;
    // [XID] // 0x000000018989E8A0-0x000000018989E8C0
    public BaseDialogContext GetActiveDialog() => default; // 0x00000001812B2360-0x00000001812B2520
                                                           // [XID] // 0x00000001898A63E0-0x00000001898A6400
    public void LockUI(UIShowPriority mode) { } // 0x00000001812B7660-0x00000001812B77A0
                                                // [XID] // 0x00000001898ADA50-0x00000001898ADA70
    public void UnlockUI(UIShowPriority mode, bool force = false /* Metadata: 0x00AFF4D5 */) { } // 0x00000001812B3310-0x00000001812B3530
                                                                                                 // [XID] // 0x00000001898B4EE0-0x00000001898B4F00
    private void PopCachedContextList(DoublyList<UIShowCache> lst) { } // 0x00000001812AE980-0x00000001812AEAD0
                                                                       // [XID] // 0x00000001898BC9F0-0x00000001898BCA10
    private void CacheInputContext(BaseContext context, UIShowPriority mode) { } // 0x00000001812A0200-0x00000001812A03D0
                                                                                 // [XID] // 0x00000001896F1830-0x00000001896F1850
    public bool ShowPage(BasePageContext context, bool fadeOut = true /* Metadata: 0x00AFF4D6 */, UIShowPriority mode = UIShowPriority.None /* Metadata: 0x00AFF4D7 */)
    {
        bool flag = false;
        if (context != null)
        {
            if (_curLockPriority > mode)
            {
                CacheInputContext(context, mode);
                flag = false;
            }
            else
            {
                if (SuperDebug.IsSwitchOn(SuperDebug.UI))
                {
                    SuperDebug.Log(SuperDebug.UI, "ShowPage: {0} fadeOut: {1}" + context.config.contextName + fadeOut);
                }
            }
            if (context == CurrentPageContext)
            {
                context.Init();
            }
            else
            {
                if (_pageContextStack.Contains(context))
                {
                    SuperDebug.Log(SuperDebug.UI, "PageStack中已包含" + context.config.contextName);
                }
                _pageContextStack.Push(context);
                if (CurrentPageContext != null)
                {
                    if (fadeOut) CurrentPageContext.Hide();
                    else CurrentPageContext.SetActive(false);
                }
                else
                {
                    context.Init();
                }
                if (_cacheDialogContextList.Count > 0)
                {
                    foreach (var cache in _cacheDialogContextList)
                    {
                        cache.SetPageContext(context);
                        cache.Init();
                    }
                    _cacheDialogContextList.Clear();
                }
            }
            Singleton<AudioManager>.Instance.ui.PostOpenPageEvent(context.config.contextName);
            flag = true;
        }
        else
        {
            flag = false;
            SuperDebug.VeryImportantError("ShowPage page is null!", ErrorLevel.Medium, ErrorCategory.UI);
        }
        return flag;
    } // 0x00000001812B4800-0x00000001812B4CC0
      // [XID] // 0x00000001898CB810-0x00000001898CB830
    public bool ShowDialog(BaseDialogContext dialogContext, UIShowPriority mode = UIShowPriority.None /* Metadata: 0x00AFF4DB */) => default; // 0x00000001812B2F20-0x00000001812B3100
                                                                                                                                              // [XID] // 0x00000001898D2F30-0x00000001898D2F50
    public bool ShowWidget(BaseWidgetContext widget, UIShowPriority mode = UIShowPriority.None /* Metadata: 0x00AFF4DF */) => default; // 0x00000001812A2520-0x00000001812A2760
                                                                                                                                       // [XID] // 0x00000001898DA8C0-0x00000001898DA8E0
    public bool ShowSubPage(BaseSubPageContext subPage, UIShowPriority mode = UIShowPriority.None /* Metadata: 0x00AFF4E3 */) => default; // 0x00000001812A1BF0-0x00000001812A1CF0
                                                                                                                                          // [XID] // 0x00000001898E26C0-0x00000001898E26E0
    public bool ShowContext(BaseContext context, UIShowPriority mode) => default; // 0x00000001812A2F20-0x00000001812A3190
                                                                                  // [XID] // 0x00000001898EA1B0-0x00000001898EA1D0
    public void CloseContext(BaseContext context) { } // 0x00000001812A9A40-0x00000001812A9C90
                                                      // [XID] // 0x00000001898F19F0-0x00000001898F1A10
    public void ForceBackToFirstPage() { } // 0x000000018129EA10-0x000000018129EB30
                                           // [XID] // 0x00000001898F9130-0x00000001898F9150
    public int GetPageCount() => default; // 0x00000001812A6750-0x00000001812A6810
                                          // [XID] // 0x0000000189900A90-0x0000000189900AB0
    public bool BackPage(string pageName = null) => default; // 0x00000001812AC690-0x00000001812ACAE0
                                                             // [XID] // 0x0000000189908250-0x0000000189908270
    public void TryShowPeekPage() { } // 0x00000001812B2680-0x00000001812B2770
                                      // [IDTag] // 0x000000018990FA30-0x000000018990FA70
                                      // [XID] // 0x000000018990FA30-0x000000018990FA70
    public void Remove(BaseDialogContext dlg) { } // 0x00000001812AA300-0x00000001812AA470
                                                  // [IDTag] // 0x000000018991A4B0-0x000000018991A4F0
                                                  // [XID] // 0x000000018991A4B0-0x000000018991A4F0
    public void Remove(BaseWidgetContext widget) { } // 0x00000001812AA470-0x00000001812AA5C0
                                                     // [XID] // 0x0000000189924C40-0x0000000189924C60
    private void CheckRootCanvas() { } // 0x00000001812A53B0-0x00000001812A54F0
                                       // [IDTag] // 0x000000018992C100-0x000000018992C140
                                       // [XID] // 0x000000018992C100-0x000000018992C140
    public void Remove(BasePageContext page) { } // 0x00000001812AA220-0x00000001812AA300
                                                 // [XID] // 0x00000001899365B0-0x00000001899365D0
    private bool GetCurrentPageAnyncLoad() => default; // 0x00000001812B61B0-0x00000001812B6280
                                                       // [XID] // 0x000000018993E010-0x000000018993E030
    public void OnContextActiveChanged() { } // 0x00000001812A8410-0x00000001812A86E0
                                             // [XID] // 0x0000000189724840-0x0000000189724860
    private void CheckContext(BaseContext context, ref bool needClearInputState, ref bool affectClimateLen, ref bool showClimateLen, ref bool climateChangeImmediate) { } // 0x00000001812B1870-0x00000001812B1A30
                                                                                                                                                                          // [XID] // 0x000000018994CBB0-0x000000018994CBD0
    public static bool IsPS4Layout() => default; // 0x00000001812A5260-0x00000001812A53B0
                                                 // [XID] // 0x00000001899542F0-0x0000000189954310
    public static bool IsMobileJoystickLayout() => default; // 0x00000001812A6B20-0x00000001812A6C50
                                                            // [IDTag] // 0x0000000189972810-0x0000000189972850
                                                            // [XID] // 0x0000000189972810-0x0000000189972850
    private static void SetCanvasSize(MonoBaseCanvas canvas, Vector2 resolution) { } // 0x00000001812AD670-0x00000001812AD7C0
                                                                                     // [IDTag] // 0x000000018997C6B0-0x000000018997C6F0
                                                                                     // [XID] // 0x000000018997C6B0-0x000000018997C6F0
    private void SetCanvasSize(Vector2 resolution) { } // 0x00000001812AD7C0-0x00000001812ADAF0
                                                       // [XID] // 0x0000000189987450-0x0000000189987470
    public void ResetLevelCanvas() { } // 0x00000001812B53C0-0x00000001812B54C0
                                       // [XID] // 0x000000018998F020-0x000000018998F040
    private void InitReferenceResolution() { } // 0x00000001812B08C0-0x00000001812B0970
                                               // [XID] // 0x00000001899AD600-0x00000001899AD620
    private void InitWindowResolutions() { } // 0x000000018129F990-0x000000018129FD10
                                             // [XID] // 0x00000001899B4E60-0x00000001899B4E80
    private void OnWindowsDisplayChanged(bool isRotated) { } // 0x00000001812AFAC0-0x00000001812AFB90
                                                             // [XID] // 0x00000001899BC5D0-0x00000001899BC5F0
    private int CompareResolution(Resolution resA, Resolution resB) => default; // 0x00000001812A5640-0x00000001812A5740
                                                                                // [XID] // 0x00000001899C3F20-0x00000001899C3F40
    private bool IsScreenPotrait() => default; // 0x00000001812B54C0-0x00000001812B5570
                                               // [XID] // 0x00000001899CB750-0x00000001899CB770
    public void AdapetResolutionBySetting(int midMem, int lowMem, int midDpi, int lowDpi, bool fullscreen) { } // 0x00000001812B5030-0x00000001812B53C0
                                                                                                               // [XID] // 0x00000001899D2B70-0x00000001899D2B90
    private void SetResolutionWithFirstMatchDpi(int dpi, bool fullscreen) { } // 0x000000018129EE80-0x000000018129F3D0
                                                                              // [XID] // 0x00000001899DA1C0-0x00000001899DA1E0
    public void UpdateWindowResolution(int index) { } // 0x00000001812B4CC0-0x00000001812B4F50
                                                      // [XID] // 0x000000018997C190-0x000000018997C1B0
    public void ChangeLayoutVersion(LayoutVersion version) { } // 0x00000001812B5570-0x00000001812B5790
                                                               // [XID] // 0x0000000189A058F0-0x0000000189A05910
    public void ChangeLayoutVersionSimply(LayoutVersion version) { } // 0x00000001812B06E0-0x00000001812B07E0
                                                                     // [XID] // 0x00000001897C2700-0x00000001897C2720
    public static UIMetaInfo FillMetaInfo(System.Type curType, System.Type baseType) => default; // 0x00000001812B6B90-0x00000001812B6CF0
                                                                                                 // [XID] // 0x0000000189A144C0-0x0000000189A144E0
    public static bool HasMetaInfo(System.Type t) => default; // 0x00000001812A3400-0x00000001812A34F0
                                                              // [XID] // 0x0000000189A1B770-0x0000000189A1B790
    public static void AddMetaInfo(System.Type t, UIMetaInfo metaInfo) { } // 0x00000001812B1D20-0x00000001812B1E20
                                                                           // [XID] // 0x00000001897BAA70-0x00000001897BAA90
    public static UIMetaInfo GetMetaInfo(System.Type t) => default; // 0x00000001812AF200-0x00000001812AF300
                                                                    // [XID] // 0x0000000189A2A340-0x0000000189A2A360
    public static void ClearMeta() { } // 0x00000001812B4F50-0x00000001812B5030
                                       // [XID] // 0x0000000189B3ACD0-0x0000000189B3ACF0
    private void AddTickContext(BaseContext context) { } // 0x000000018129E640-0x000000018129E750
                                                         // [XID] // 0x00000001897F14A0-0x00000001897F14C0
    private void RemoveTickContext(BaseContext context) { } // 0x00000001812AEC70-0x00000001812AED80
                                                            // [XID] // 0x0000000189A40AB0-0x0000000189A40AD0
    public void HideUI() { } // 0x00000001812B6DC0-0x00000001812B7160
                             // [XID] // 0x0000000189A48150-0x0000000189A48170
    private void HideCanvas(GameObject gameObject) { } // 0x00000001812A6460-0x00000001812A65C0
                                                       // [XID] // 0x0000000189A4FA20-0x0000000189A4FA40
    public void CancelHideUI() { } // 0x00000001812A3930-0x00000001812A3CD0
                                   // [XID] // 0x0000000189A56FD0-0x0000000189A56FF0
    private void ShowCanvas(GameObject gameObject) { } // 0x00000001812ACD40-0x00000001812ACE90
                                                       // [XID] // 0x0000000189A5EBD0-0x0000000189A5EBF0
    public void ToggleUI() { } // 0x00000001812B07E0-0x00000001812B08C0
                               // [XID] // 0x0000000189A662D0-0x0000000189A662F0
    private void InitSaveData() { } // 0x00000001812A1070-0x00000001812A1170
                                    // [XID] // 0x0000000189A6DA20-0x0000000189A6DA40
    private void UploadSaveData() { } // 0x00000001812B6780-0x00000001812B6880
                                      // [XID] // 0x0000000189A75170-0x0000000189A75190
    private void LoadMiniMapFixTypeFromLocalData() { } // 0x00000001812ABA10-0x00000001812ABB00
                                                       // [XID] // 0x0000000189A7CDD0-0x0000000189A7CDF0
    private void CreateRootCanvas() { } // 0x00000001812B3100-0x00000001812B3310
                                        // [XID] // 0x0000000189A846A0-0x0000000189A846C0
    private void DestroyRootCanvas() { } // 0x00000001812ACF60-0x00000001812AD140
                                         // [XID] // 0x0000000189A8C000-0x0000000189A8C020
    private void CheckAndBlockTouch() { } // 0x00000001812B1FE0-0x00000001812B2190
                                          // [XID] // 0x0000000189A934B0-0x0000000189A934D0
    public BaseGroupContext CreateGroup(BaseGroupContext group) => default; // 0x00000001812A3310-0x00000001812A3400
                                                                            // [XID] // 0x0000000189A9AFA0-0x0000000189A9AFC0
    private BaseGroupContext GroupHasPage(BasePageContext context) => default; // 0x00000001812B4080-0x00000001812B41F0
                                                                               // [XID] // 0x0000000189AA2330-0x0000000189AA2350
    public void OnGroupDisconnect() { } // 0x00000001812A2760-0x00000001812A28B0
                                        // [XID] // 0x0000000189AA9860-0x0000000189AA9880
    public void PageSetActive(BasePageContext page, bool enable) { } // 0x00000001812A3190-0x00000001812A3310
                                                                     // [XID] // 0x0000000189AB1660-0x0000000189AB1680
    public void DestroyPageContext(BasePageContext pageContext) { } // 0x00000001812AF910-0x00000001812AFA20
                                                                    // [XID] // 0x0000000189AB89E0-0x0000000189AB8A00
    public void ClearGroups() { } // 0x00000001812A73D0-0x00000001812A7490
                                  // [XID] // 0x0000000189AC05D0-0x0000000189AC05F0
    private void DestroyAllMessageContextForce() { } // 0x00000001812A74F0-0x00000001812A7630
                                                     // [IDTag] // 0x0000000189ACF630-0x0000000189ACF670
                                                     // [XID] // 0x0000000189ACF630-0x0000000189ACF670
    public void TryShowNormalMessage(string content, Color bgColor, bool showBackground) { } // 0x00000001812A0F10-0x00000001812A1070
                                                                                             // [IDTag] // 0x0000000189ADA480-0x0000000189ADA4C0
                                                                                             // [XID] // 0x0000000189ADA480-0x0000000189ADA4C0
    public void TryShowNormalMessage(string content) { } // 0x00000001812A0E10-0x00000001812A0F10
                                                         // [XID] // 0x0000000189AE4F80-0x0000000189AE4FA0
    public void TryShowInLevelMessage(string content, bool needMap = false /* Metadata: 0x00AFF4E7 */, bool isShowBackground = false /* Metadata: 0x00AFF4E8 */) { } // 0x00000001812A1170-0x00000001812A13A0
                                                                                                                                                                     // [XID] // 0x0000000189AEC5C0-0x0000000189AEC5E0
    private void CheckInlevelMessageShow() { } // 0x00000001812B6600-0x00000001812B6780
                                               // [XID] // 0x0000000189AFB840-0x0000000189AFB860
    public void TryShowInfoMessage(string content, bool discardIfDuplicated = false /* Metadata: 0x00AFF4E9 */, UIShowPriority priority = UIShowPriority.Normal /* Metadata: 0x00AFF4EA */, Action releaseCallback = null) { } // 0x00000001812A5AC0-0x00000001812A5C30
                                                                                                                                                                                                                               // [XID] // 0x0000000189B0A640-0x0000000189B0A660
    public void TryShowRootInfoMessage(string content, bool discardIfDuplicated = false /* Metadata: 0x00AFF4EE */, UIShowPriority priority = UIShowPriority.Error /* Metadata: 0x00AFF4EF */) { } // 0x00000001812B5AB0-0x00000001812B5BF0
                                                                                                                                                                                                   // [XID] // 0x0000000189B18FD0-0x0000000189B18FF0
    public void TryShowInfoMessageWithoutBlockInput(string content, bool discardIfDuplicated = false /* Metadata: 0x00AFF4F3 */, UIShowPriority priority = UIShowPriority.Normal /* Metadata: 0x00AFF4F4 */) { } // 0x00000001812A96F0-0x00000001812A9830
                                                                                                                                                                                                                 // [XID] // 0x0000000189B206D0-0x0000000189B206F0
    public string DumpUIManagerState() => default; // 0x00000001812B0DA0-0x00000001812B1160
                                                   // [XID] // 0x0000000189B27DD0-0x0000000189B27DF0
    public void DumpContextUIModuleState() { } // 0x00000001812B3530-0x00000001812B3E00
    [DebuggerHidden] // 0x0000000189B2F0F0-0x0000000189B2F130
                     // [XID] // 0x0000000189B2F0F0-0x0000000189B2F130
    public IEnumerator PreloadRes(Action<float> progressFunc) => default; // 0x00000001812B2E40-0x00000001812B2F20
                                                                          // [XID] // 0x0000000189B39B70-0x0000000189B39B90
    private void LoadCallBack(int index, ulong hash, bool loadSucceeded, uint handle, GameObject asset) { } // 0x00000001812A8B10-0x00000001812A8C40
                                                                                                            // [XID] // 0x0000000189B41390-0x0000000189B413B0
    private void DismissPreloadRes() { } // 0x00000001812B2AF0-0x00000001812B2E40
                                         // [XID] // 0x0000000189B48D20-0x0000000189B48D40
    private void InitAyncLoad() { } // 0x00000001812A3CD0-0x00000001812A3E50
                                    // [XID] // 0x0000000189B50440-0x0000000189B50460
    public void EnableAsyncLoad(bool enable, AsyncLoadType type) { } // 0x00000001812A13A0-0x00000001812A1520
                                                                     // [XID] // 0x0000000189B57C30-0x0000000189B57C50
    public void EnableIconAsyncLoad(bool enable, AsyncLoadType type) { } // 0x000000018129E130-0x000000018129E2A0
                                                                         // [XID] // 0x0000000189B5F660-0x0000000189B5F680
    public void SetOpenMallType(ShopType type) { } // 0x00000001812A1DA0-0x00000001812A1E50
                                                   // [XID] // 0x0000000189B66D80-0x0000000189B66DA0
    private Dictionary<uint, bool> GetLocalDataDisplayOrder() => default; // 0x000000018129FFA0-0x00000001812A0090
                                                                          // [XID] // 0x0000000189B6E0E0-0x0000000189B6E100
    private void CheckMallOnInit(bool isReInit) { } // 0x00000001812A6F80-0x00000001812A7140
                                                    // [XID] // 0x0000000189B758B0-0x0000000189B758D0
    private void ClearMallOnGobackHome() { } // 0x00000001812B6880-0x00000001812B6920
                                             // [XID] // 0x0000000189B7CD50-0x0000000189B7CD70
    public void RecieveOrder(uint orderId) { } // 0x00000001812A20C0-0x00000001812A21C0
                                               // [XID] // 0x0000000189B84BF0-0x0000000189B84C10
    public bool ShouldDisplay(uint orderId) => default; // 0x00000001812AF300-0x00000001812AF430
                                                        // [XID] // 0x0000000189B8B9A0-0x0000000189B8B9C0
    public void DisplayedRecieveOrder(uint orderId) { } // 0x00000001812A82B0-0x00000001812A8410
                                                        // [XID] // 0x0000000189B93190-0x0000000189B931B0
    private void SaveMallData(bool forceSave) { } // 0x00000001812B77A0-0x00000001812B78C0
                                                  // [XID] // 0x0000000189B9A6E0-0x0000000189B9A700
    private void FilterMallData() { } // 0x00000001812B7290-0x00000001812B7570
                                      // [XID] // 0x0000000189BA1ED0-0x0000000189BA1EF0
    public Dictionary<NewbieDialogContext, RectTransform> GetAllMastTransDict() => default; // 0x00000001812B0970-0x00000001812B0A20
                                                                                            // [XID] // 0x0000000189BA92C0-0x0000000189BA92E0
    public void SetNewbieMaskTrans(NewbieDialogContext context, RectTransform trans) { } // 0x00000001812A0CE0-0x00000001812A0E10
                                                                                         // [XID] // 0x0000000189BB7D60-0x0000000189BB7D80
    public MonoSceneUISetup GetSceneUISetup() => default; // 0x00000001812B7970-0x00000001812B7A80
                                                          // [XID] // 0x0000000189BBF430-0x0000000189BBF450
    public void CreateUIScene() { } // 0x00000001812AE4C0-0x00000001812AE580
                                    // [XID] // 0x0000000189BC6FF0-0x0000000189BC7010
    public void DestroyUIScene() { } // 0x00000001812A15D0-0x00000001812A1670
                                     // [XID] // 0x0000000189BCED20-0x0000000189BCED40
    private void CreateCharacterViewScene() { } // 0x00000001812A3730-0x00000001812A38D0
                                                // [XID] // 0x0000000189BD6080-0x0000000189BD60A0
    public void DestroyCharacterViewScene() { } // 0x00000001812A7140-0x00000001812A7290
                                                // [XID] // 0x00000001896F6760-0x00000001896F6780
    public void EnableInput(bool playerInput, bool clearCurInputState = false /* Metadata: 0x00AFF4F8 */, bool ignoreTouch = false /* Metadata: 0x00AFF4F9 */) { } // 0x000000018129EBE0-0x000000018129EE80
                                                                                                                                                                   // [XID] // 0x000000018965D2C0-0x000000018965D2E0
    public void ClearCurInputState() { } // 0x00000001812ACE90-0x00000001812ACF60
                                         // [XID] // 0x00000001895F1D30-0x00000001895F1D50
    public void EnableCurtain(bool inOrOut, bool toDisable, bool destroyDialog, float duration = -1f /* Metadata: 0x00AFF4FA */, Action callback = null, Color? fillColor = default) { } // 0x00000001812A7D40-0x00000001812A7F80
                                                                                                                                                                                         // [XID] // 0x00000001895F96B0-0x00000001895F96D0
    public void ShowMaskHintByType(DisconnectHintType type) { } // 0x00000001812B1760-0x00000001812B1870
                                                                // [XID] // 0x0000000189600DA0-0x0000000189600DC0
    public void TryCloseMaskHintByType(DisconnectHintType type) { } // 0x00000001812B1BF0-0x00000001812B1D20
                                                                    // [XID] // 0x0000000189608710-0x0000000189608730
    public void TestPackageRsp(ushort rspId) { } // 0x00000001812A04D0-0x00000001812A0600
                                                 // [XID] // 0x000000018960FF30-0x000000018960FF50
    private void TryCloseMaskHint() { } // 0x00000001812B1A30-0x00000001812B1B10
                                        // [XID] // 0x0000000189617290-0x00000001896172B0
    public void TryShowWaitingRspWidget(ushort rspId, Action<Packet> onRspCallback = null) { } // 0x000000018129E4A0-0x000000018129E590
                                                                                               // [XID] // 0x000000018961EE80-0x000000018961EEA0
    private void TryShowConnectWaitWidget() { } // 0x00000001812B0A20-0x00000001812B0B20
                                                // [XID] // 0x0000000189A61150-0x0000000189A61170
    public void EnableVirtualCursor(UIVirtualCursorType cursorType = UIVirtualCursorType.Normal /* Metadata: 0x00AFF4FE */) { } // 0x00000001812A9360-0x00000001812A96F0
                                                                                                                                // [XID] // 0x00000001896357D0-0x00000001896357F0
    public void UpdateVirtualCursorPosition(Vector2 screenPosition) { } // 0x00000001812ABC30-0x00000001812ABEC0
                                                                        // [XID] // 0x0000000189AF8090-0x0000000189AF80B0
    public void DisableVirtualCursor() { } // 0x00000001812B6530-0x00000001812B6600
                                           // [XID] // 0x0000000189A95CF0-0x0000000189A95D10
    public void SetVirtualCursorVisible(bool visible) { } // 0x00000001812B1160-0x00000001812B1260
                                                          // [XID] // 0x000000018965AB70-0x000000018965AB90
    public ActionPanelType GetInitActionPanelType() => default; // 0x00000001812B3E00-0x00000001812B3F30
                                                                // [XID] // 0x0000000189677600-0x0000000189677620
    public void ShowEffect(EffectType type) { } // 0x00000001812B0550-0x00000001812B06E0
                                                // [XID] // 0x000000018967EBE0-0x000000018967EC00
    public void CloseEffect(EffectType type) { } // 0x00000001812B5C50-0x00000001812B5D60
                                                 // [XID] // 0x00000001896864D0-0x00000001896864F0
    public void SetBillboardsActive(bool active, BillboardManager.BillboardHideType type = BillboardManager.BillboardHideType.Default /* Metadata: 0x00AFF502 */) { } // 0x00000001812A7290-0x00000001812A73D0
                                                                                                                                                                      // [XID] // 0x000000018969D360-0x000000018969D380
    public ulong GetSelectedAvatarGuid() => default; // 0x00000001812AA5C0-0x00000001812AA670
                                                     // [XID] // 0x00000001896A4420-0x00000001896A4440
    public AvatarDataItem GetSelectedAvatarDataItem() => default; // 0x00000001812A58D0-0x00000001812A59C0
                                                                  // [XID] // 0x00000001896ABC10-0x00000001896ABC30
    public void SelectAvatar(ulong avatarGuid, bool inTeam = true /* Metadata: 0x00AFF506 */) { } // 0x00000001812B5790-0x00000001812B5950
                                                                                                  // [XID] // 0x00000001896B2D50-0x00000001896B2D70
    public void SelectAvatarForAvatarPreview(ulong avatarGuid, List<ulong> avatarList) { } // 0x00000001812B1610-0x00000001812B1760
                                                                                           // [XID] // 0x00000001896BA470-0x00000001896BA490
    public void SelectDefaultAvatar() { } // 0x00000001812A65C0-0x00000001812A6750
                                          // [XID] // 0x00000001896C16C0-0x00000001896C16E0
    public void ToggleDisplaySafeAreaIndicator() { } // 0x00000001812A6C50-0x00000001812A6D60
                                                     // [XID] // 0x00000001896C8DE0-0x00000001896C8E00
    private void ShowDisplaySafeAreaIndicator() { } // 0x00000001812A8E80-0x00000001812A9060
                                                    // [XID] // 0x00000001896D07A0-0x00000001896D07C0
    private void CloseDisplaySafeAreaIndicator() { } // 0x00000001812A6A40-0x00000001812A6B20
                                                     // [XID] // 0x00000001896DF580-0x00000001896DF5A0
    public void DestroyDisplaySafeAreaIndicator() { } // 0x00000001812A91F0-0x00000001812A9360
                                                      // [XID] // 0x000000018988C990-0x000000018988C9B0
    public Color GetLoadingDialogBgColor() => default; // 0x00000001812A9060-0x00000001812A9150
                                                       // [XID] // 0x0000000189740510-0x0000000189740530
    public void TryShowMPLoadingDialog(string text) { } // 0x00000001812AB530-0x00000001812AB5F0
                                                        // [XID] // 0x0000000189747890-0x00000001897478B0
    public void TryCloseMPLoadingDialog() { } // 0x00000001812A57E0-0x00000001812A58D0
                                              // [XID] // 0x000000018974F030-0x000000018974F050
    public void ShowEmbededLoadingDialog(Action callback) { } // 0x00000001812AFB90-0x00000001812AFCB0
                                                              // [XID] // 0x0000000189756760-0x0000000189756780
    public InLevelBaseLoadingDialogContext GetGotoProgressDialog(EnterType enterType, Vector3 targetPos) => default; // 0x00000001812A86E0-0x00000001812A8910
                                                                                                                     // [XID] // 0x000000018975DB70-0x000000018975DB90
    private LoadingSituationType CheckLoadingSituationType(Vector3 targetPos) => default; // 0x00000001812B6280-0x00000001812B64D0
                                                                                          // [XID] // 0x0000000189801B80-0x0000000189801BA0
    public void ShowLoadingDialog(Action callback) { } // 0x00000001812B2770-0x00000001812B2AF0
                                                       // [XID] // 0x000000018976CC40-0x000000018976CC60
    public void SetLoadingSituationType(PlayerEnterSceneNotify notify) { } // 0x00000001812AD140-0x00000001812AD480
                                                                           // [XID] // 0x00000001898593F0-0x0000000189859410
    public void MaskPage(bool show) { } // 0x00000001812B4430-0x00000001812B4800
                                        // [XID] // 0x000000018977B7C0-0x000000018977B7E0
    private void ShowLoadingPageNext(Action callback) { } // 0x00000001812B14A0-0x00000001812B1610
                                                          // [XID] // 0x00000001897F2D00-0x00000001897F2D20
    public void ShowLoadingPage(Action callback) { } // 0x000000018129FDD0-0x000000018129FFA0
                                                     // [XID] // 0x0000000189791EC0-0x0000000189791EE0
    public void CacheGeneralInteeAppearNotify(object body) { } // 0x00000001812AE670-0x00000001812AE800
                                                               // [XID] // 0x0000000189799590-0x00000001897995B0
    public void RemoveGeneralInteeAppearNotify(object body) { } // 0x00000001812AF740-0x00000001812AF910
                                                                // [XID] // 0x00000001897A1460-0x00000001897A1480
    private void FireCachedInteeAppearNotify() { } // 0x00000001812AAB10-0x00000001812AAE80
                                                   // [XID] // 0x00000001897A8BC0-0x00000001897A8BE0
    private void ClearCachedInteeAppearNotify() { } // 0x000000018129FD10-0x000000018129FDD0
                                                    // [XID] // 0x00000001897B04E0-0x00000001897B0500
    public void TempFixStartMainUICheck() { } // 0x00000001812A0B00-0x00000001812A0C30
                                              // [XID] // 0x00000001897B82E0-0x00000001897B8300
    private void TempFixDoCheck() { } // 0x000000018129F500-0x000000018129F650
                                      // [XID] // 0x00000001897C0340-0x00000001897C0360
    public void TempFixStopMainUICheck() { } // 0x00000001812B2190-0x00000001812B22C0
                                             // [XID] // 0x00000001897C7B70-0x00000001897C7B90
    public MonoLikingBar GetLikingBarInstance(string key, Transform initParent) => default; // 0x00000001812A6190-0x00000001812A6460
                                                                                            // [XID] // 0x00000001897CEE30-0x00000001897CEE50
    public void UnregisterLikingBarInstance(string key) { } // 0x00000001812B3F30-0x00000001812B4080
                                                            // [XID] // 0x00000001897D6600-0x00000001897D6620
    private void InitLikingBar() { } // 0x00000001812AC410-0x00000001812AC4E0
                                     // [XID] // 0x00000001897DDE10-0x00000001897DDE30
    private void ReloadLikingBarRes() { } // 0x00000001812B5DD0-0x00000001812B5EF0
                                          // [XID] // 0x00000001897E58A0-0x00000001897E58C0
    private void ClearLikingBar() { } // 0x00000001812AAE80-0x00000001812AB110
                                      // [XID] // 0x00000001897FC5E0-0x00000001897FC600
    public string GetFixTypeText(FixType fixType) => default; // 0x00000001812B0B20-0x00000001812B0C10
                                                              // [XID] // 0x0000000189803B10-0x0000000189803B30
    public void TryShowBornVideo() { } // 0x00000001812A1710-0x00000001812A1BF0
                                       // [XID] // 0x000000018980AFD0-0x000000018980AFF0
    public void TryShowSelectPageContextCallBack() { } // 0x00000001812A8910-0x00000001812A8B10
                                                       // [XID] // 0x0000000189812660-0x0000000189812680
    public void TryShowSelectPageContext() { } // 0x00000001812AA0D0-0x00000001812AA220
                                               // [XID] // 0x000000018981A2C0-0x000000018981A2E0
    public void TryShowFullScreenBlackBoard(bool bShow) { } // 0x00000001812B1E20-0x00000001812B1FE0
                                                            // [XID] // 0x00000001898219D0-0x00000001898219F0
    public void TryHideSelectPageContext() { } // 0x00000001812A5590-0x00000001812A5640
                                               // [XID] // 0x0000000189828F60-0x0000000189828F80
    public void AddToCachedUINotifyList(Notify ntf) { } // 0x00000001812B7570-0x00000001812B7660
                                                        // [XID] // 0x0000000189830450-0x0000000189830470
    public void FireAllNotifyInCachedNotifyList() { } // 0x00000001812AA670-0x00000001812AA830
                                                      // [XID] // 0x0000000189837B50-0x0000000189837B70
    public void EnableRTTView() { } // 0x00000001812AB2F0-0x00000001812AB3D0
                                    // [XID] // 0x000000018983F2B0-0x000000018983F2D0
    public void DisableRTTView() { } // 0x00000001812A2000-0x00000001812A20C0
                                     // [XID] // 0x00000001898468F0-0x0000000189846910
    private string GetBaseContextState(BaseContext dlg) => default; // 0x00000001812ADAF0-0x00000001812ADED0
                                                                    // [XID] // 0x000000018984DE60-0x000000018984DE80
    private string GetPageState(BasePageContext page, bool withDialog = false /* Metadata: 0x00AFF507 */) => default; // 0x00000001812A5C30-0x00000001812A6190
    [Preserve] // 0x0000000189854EF0-0x0000000189854F30
               // [XID] // 0x0000000189854EF0-0x0000000189854F30
    public override string Dump(string tag) => default; // 0x00000001812A42F0-0x00000001812A5260
                                                        // [XID] // 0x000000018985F1B0-0x000000018985F1D0
    public void ReportCurrentInfo(string head = "" /* Metadata: 0x00AFF508 */) { } // 0x00000001812AB8F0-0x00000001812ABA10
                                                                                   // [XID] // 0x00000001898669D0-0x00000001898669F0
    public void ToggleDebugMenuDialog() { } // 0x00000001812AF0B0-0x00000001812AF200
                                            // [XID] // 0x000000018986E290-0x000000018986E2B0
    public void HandleGM(string[] args) { } // 0x00000001812B1260-0x00000001812B1370
                                            // [XID] // 0x0000000189875740-0x0000000189875760
    public void ToggleTeamName() { } // 0x00000001812B71D0-0x00000001812B7290
                                     // [XID] // 0x000000018987D290-0x000000018987D2B0
    public void BanUI(UIBanType type, bool ban) { } // 0x00000001812B6920-0x00000001812B6A20
                                                    // [XID] // 0x00000001898841D0-0x00000001898841F0
    public bool IsUIBan(UIBanType type) => default; // 0x00000001812B0060-0x00000001812B0130
                                                    // [XID] // 0x000000018988B900-0x000000018988B920
    public bool TryCheckUIBan(UIBanType type) => default; // 0x00000001812B5950-0x00000001812B5A50
}

