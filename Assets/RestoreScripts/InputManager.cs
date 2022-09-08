/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using HedgehogTeam.EasyTouch;
using IFix.Core;
using MoleMole;
using Rewired;
using UnityEngine;
using UnityEngine.EventSystems;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class InputManager : GlobalManager, INotifyInterface // TypeDefIndex: 21022
{
    // Fields
    private bool _initialized; // 0x18
    private bool _disableInput; // 0x19
    private const float DOUBLE_BUTTON_DELAY_TIME = 0.05f; // Metadata: 0x00AFED16
    private InputDeviceType _deviceType; // 0x1C
    private uint _keySettingUID; // 0x20
    private Dictionary<string, uint> _keySettingDict; // 0x28
    private PointerEventData _simulatePointer; // 0x48
    private float _mouseSensitivity; // 0x50
    private Vector2 _changeViewScale; // 0x54
    private float _zoomCameraScale; // 0x5C
    private int _joypadSenseIndex; // 0x60
    private int _joypadFocusSenseIndex; // 0x64
    private bool _joypadInvertCameraX; // 0x68
    private bool _joypadInvertCameraY; // 0x69
    private bool _joypadInvertFocusCameraX; // 0x6A
    private bool _joypadInvertFocusCameraY; // 0x6B
    private int _mouseSenseIndex; // 0x6C
    private int _mouseFocusSenseIndex; // 0x70
    private bool _wwiseVibration; // 0x74
    private int _touchpadSenseIndex; // 0x78
    private int _touchpadFocusSenseIndex; // 0x7C
    private bool _enableTouchpadFocusAcceleration; // 0x80
    public float cameraDistanceRatio; // 0x84
    private bool _sendNavigationEvents; // 0x88
    private bool _enableDebugLog; // 0x89
    private StringComparison _comparisonType; // 0x8C
    private SaveData _saveData; // 0x90
    private EasyTouch _easyTouch; // 0x98
    private RuntimePlatform _platformCache; // 0xA0
    public static InputActionType[] keyboardActions; // 0x00
    public static InputActionType[] joypadActions; // 0x08
    private Dictionary<int, CommonActionData> _commonActionData; // 0xA8
    private Dictionary<int, TwoAxisActionData> _twoAxisActionData; // 0xB0
    private Dictionary<int, InputActionEvent> _currHandledEvents; // 0xB8
    private bool _gyroscopeEnabled; // 0xC0
    private bool _gyroAttitudeEnabled; // 0xC1
    private string _gyroAttitudeMode; // 0xC8
    private bool _gyroRotationEnabled; // 0xD0
    private bool _isRoleMoving; // 0xD1
    private float _roleMoveAngle; // 0xD4
    private float _roleMoveMold; // 0xD8
    private static VCMoveData.MotionFlag _lastMoveMoldStatus; // 0x10
    private static float _lastMold; // 0x14
    private bool _haveMoveInput; // 0xDC
    public bool _switchWalkRunByBtn; // 0xDD
    private bool _currentInWalkMode; // 0xDE
    private bool _currentLockMoveMode; // 0xDF
    private AvatarEntity _localAvatar; // 0xE0
    private VCLocalInputController _localAvatarController; // 0xE8
    private VCHumanoidMove _localAvatarMove; // 0xF0
    private bool _isRunning; // 0xF8
    private SimpleFixedBitStack _forceSlowMove; // 0x100
    private bool forceControlled; // 0x108
    private float forceAngle; // 0x10C
    private float forceMold; // 0x110
    private bool enableRotateCamera; // 0x114
    private ConfigAvatarFocus _configAvatarFocus; // 0x118
    private bool _needCheckInputDeviceUserSettings; // 0x120

    // Properties
    public RewiredWrapper inputPlugin { /* [XID] */ /* 0x0000000189A37CD0-0x0000000189A37D10 */ get; /* [XID] */ /* 0x0000000189A42350-0x0000000189A42390 */ private set; } // 0x0000000182F35440-0x0000000182F354A0 0x0000000182F35DB0-0x0000000182F35E10
    public bool inputPluginReady { /* [XID] */ /* 0x0000000189A4CA00-0x0000000189A4CA20 */ get => default; } // 0x0000000182F2F090-0x0000000182F2F180 
    public bool disableInput { /* [XID] */ /* 0x0000000189A54230-0x0000000189A54250 */ get => default; /* [XID] */ /* 0x0000000189A5BC40-0x0000000189A5BC60 */ set { } } // 0x0000000182F2E1C0-0x0000000182F2E260 0x0000000182F34AA0-0x0000000182F34B50
    public InputDeviceType inputDeviceType { /* [XID] */ /* 0x0000000189963020-0x0000000189963040 */ get => default; /* [XID] */ /* 0x0000000189A6AEF0-0x0000000189A6AF10 */ private set { } } // 0x0000000182F34D00-0x0000000182F34DA0 0x0000000182F2A7C0-0x0000000182F2A880
    public uint keySettingModiferdCounter { /* [XID] */ /* 0x0000000189A725A0-0x0000000189A725C0 */ get => default; } // 0x0000000182F346A0-0x0000000182F34740 
    public bool usingKeyboard { /* [XID] */ /* 0x00000001899764B0-0x00000001899764D0 */ get => default; } // 0x0000000182F30850-0x0000000182F30910 
    public bool usingJoypad { /* [XID] */ /* 0x0000000189758A10-0x0000000189758A30 */ get => default; } // 0x0000000182F2F6E0-0x0000000182F2F790 
    public MihoyoEventSystem eventSystem { /* [XID] */ /* 0x0000000189B29660-0x0000000189B296A0 */ get; /* [XID] */ /* 0x0000000189B33B20-0x0000000189B33B60 */ private set; } // 0x0000000182F2B090-0x0000000182F2B0F0 0x0000000182F31260-0x0000000182F312C0
    private MihoyoStandaloneInputModule eventSystemInputModule { /* [XID] */ /* 0x0000000189B3E230-0x0000000189B3E270 */ get; /* [XID] */ /* 0x0000000189B48DA0-0x0000000189B48DE0 */ set; } // 0x0000000182F2C940-0x0000000182F2C9A0 0x0000000182F2FBC0-0x0000000182F2FC20
    public MihoyoHybridInput eventSystemInput { /* [XID] */ /* 0x0000000189B533A0-0x0000000189B533E0 */ get; /* [XID] */ /* 0x0000000189B5DDE0-0x0000000189B5DE20 */ private set; } // 0x0000000182F2B030-0x0000000182F2B090 0x0000000182F27C40-0x0000000182F27CA0
    public PointerEventData simulatePointer { /* [XID] */ /* 0x0000000189B68610-0x0000000189B68630 */ get => default; } // 0x0000000182F28480-0x0000000182F28520 
    public RectTransform virtualCursor { /* [XID] */ /* 0x0000000189B76F30-0x0000000189B76F50 */ set { } } // 0x0000000182F32810-0x0000000182F32990
    public bool touchSupported { /* [XID] */ /* 0x0000000189B7E4E0-0x0000000189B7E500 */ get => default; } // 0x0000000182F367A0-0x0000000182F36870 
    public float mouseSensitivityMin { /* [XID] */ /* 0x0000000189B860D0-0x0000000189B860F0 */ get => default; } // 0x0000000182F36640-0x0000000182F366F0 
    public float mouseSensitivityMax { /* [XID] */ /* 0x0000000189B8D170-0x0000000189B8D190 */ get => default; } // 0x0000000182F366F0-0x0000000182F367A0 
    public float mouseSensitivity { /* [XID] */ /* 0x0000000189B94930-0x0000000189B94950 */ get => default; } // 0x0000000182F35FB0-0x0000000182F36060 
    private float mouseSensitivityFactor { /* [XID] */ /* 0x00000001896A9D70-0x00000001896A9D90 */ get => default; } // 0x0000000182F345E0-0x0000000182F346A0 
    public Vector2 changeViewScale { /* [XID] */ /* 0x0000000189BA3730-0x0000000189BA3750 */ get => default; } // 0x0000000182F34EB0-0x0000000182F34F60 
    public float zoomCameraScale { /* [XID] */ /* 0x0000000189BAAB00-0x0000000189BAAB20 */ get => default; } // 0x0000000182F28970-0x0000000182F28A20 
    public int joypadSenseIndex { /* [XID] */ /* 0x0000000189BB2070-0x0000000189BB2090 */ get => default; } // 0x0000000182F31D60-0x0000000182F31E00 
    public int joypadFocusSenseIndex { /* [XID] */ /* 0x0000000189BB9460-0x0000000189BB9480 */ get => default; } // 0x0000000182F28820-0x0000000182F288C0 
    public bool joypadInvertCameraX { /* [XID] */ /* 0x0000000189BC12A0-0x0000000189BC12C0 */ get => default; } // 0x0000000182F35E10-0x0000000182F35EB0 
    public bool joypadInvertCameraY { /* [XID] */ /* 0x0000000189BC8AA0-0x0000000189BC8AC0 */ get => default; } // 0x0000000182F32E10-0x0000000182F32EB0 
    public bool joypadInvertFocusCameraX { /* [XID] */ /* 0x0000000189BD0270-0x0000000189BD0290 */ get => default; } // 0x0000000182F30A00-0x0000000182F30AA0 
    public bool joypadInvertFocusCameraY { /* [XID] */ /* 0x0000000189BD78B0-0x0000000189BD78D0 */ get => default; } // 0x0000000182F2C9A0-0x0000000182F2CA40 
    public int mouseSenseIndex { /* [XID] */ /* 0x0000000189BDF400-0x0000000189BDF420 */ get => default; } // 0x0000000182F32280-0x0000000182F32320 
    public int mouseFocusSenseIndex { /* [XID] */ /* 0x00000001895EBFD0-0x00000001895EBFF0 */ get => default; } // 0x0000000182F2D430-0x0000000182F2D4D0 
    public bool WwiseVibration { /* [XID] */ /* 0x0000000189876710-0x0000000189876730 */ get => default; } // 0x0000000182F372D0-0x0000000182F37370 
    public int touchpadSenseIndex { /* [XID] */ /* 0x00000001895FACF0-0x00000001895FAD10 */ get => default; } // 0x0000000182F28D60-0x0000000182F28E00 
    public int touchpadFocusSenseIndex { /* [XID] */ /* 0x0000000189602600-0x0000000189602620 */ get => default; } // 0x0000000182F29930-0x0000000182F299D0 
    public bool enableTouchpadFocusAcceleration { /* [XID] */ /* 0x0000000189609E70-0x0000000189609E90 */ get => default; } // 0x0000000182F36AA0-0x0000000182F36B50 
    public int cameraSenseIndex { /* [XID] */ /* 0x00000001896116E0-0x0000000189611700 */ get => default; } // 0x0000000182F30F30-0x0000000182F31000 
    public int focusCameraIndex { /* [XID] */ /* 0x0000000189618FE0-0x0000000189619000 */ get => default; } // 0x0000000182F2C280-0x0000000182F2C350 
    public float cameraSensitivityScale { /* [XID] */ /* 0x00000001896204E0-0x0000000189620500 */ get => default; } // 0x0000000182F2F240-0x0000000182F2F450 
    public float focusCameraSensitivityScale { /* [XID] */ /* 0x0000000189B6AB90-0x0000000189B6ABB0 */ get => default; } // 0x0000000182F33B90-0x0000000182F33DA0 
    public bool enableDebugLog { /* [XID] */ /* 0x00000001896FFDA0-0x00000001896FFDC0 */ get => default; } // 0x0000000182F31E00-0x0000000182F31EB0 
    public Action onControllerConnected { /* [XID] */ /* 0x000000018973B690-0x000000018973B6B0 */ get => default; /* [XID] */ /* 0x0000000189743140-0x0000000189743160 */ set { } } // 0x0000000182F29EA0-0x0000000182F29FE0 0x0000000182F326C0-0x0000000182F32810
    public Action onControllerDisconnected { /* [XID] */ /* 0x000000018974ACA0-0x000000018974ACC0 */ get => default; /* [XID] */ /* 0x0000000189751D90-0x0000000189751DB0 */ set { } } // 0x0000000182F35710-0x0000000182F35850 0x0000000182F35C60-0x0000000182F35DB0
    public bool supportsGyroscope { /* [XID] */ /* 0x000000018986E2F0-0x000000018986E310 */ get => default; } // 0x0000000182F2E260-0x0000000182F2E300 
    public bool gyroscopeEnabled { /* [XID] */ /* 0x00000001898757A0-0x00000001898757C0 */ get => default; } // 0x0000000182F2CC60-0x0000000182F2CD10 
    public bool gyroAttitudeEnabled { /* [XID] */ /* 0x0000000189884230-0x0000000189884250 */ get => default; } // 0x0000000182F29430-0x0000000182F294E0 
    public string gyroAttitudeMode { /* [XID] */ /* 0x000000018988B980-0x000000018988B9A0 */ get => default; } // 0x0000000182F288C0-0x0000000182F28970 
    public Quaternion gyroAttitude { /* [XID] */ /* 0x000000018993A980-0x000000018993A9A0 */ get => default; } // 0x0000000182F34C00-0x0000000182F34D00 
    public bool gyroRotationEnabled { /* [XID] */ /* 0x000000018989A730-0x000000018989A750 */ get => default; } // 0x0000000182F31100-0x0000000182F311B0 
    public Vector3 gyroRotationRateUnbiased { /* [XID] */ /* 0x00000001898A19C0-0x00000001898A19E0 */ get => default; } // 0x0000000182F28B70-0x0000000182F28C80 
    public bool isMoving { /* [XID] */ /* 0x00000001898A9250-0x00000001898A9270 */ get => default; } // 0x0000000182F2A310-0x0000000182F2A3C0 
    public float moveAngle { /* [XID] */ /* 0x00000001898B0AE0-0x00000001898B0B00 */ get => default; } // 0x0000000182F313D0-0x0000000182F31480 
    public float moveMold { /* [XID] */ /* 0x00000001898B81A0-0x00000001898B81C0 */ get => default; } // 0x0000000182F2FB10-0x0000000182F2FBC0 
    public bool haveMoveInput { /* [XID] */ /* 0x00000001898BF8A0-0x00000001898BF8C0 */ get => default; } // 0x0000000182F35030-0x0000000182F350E0 
    public bool switchWalkRunByBtn { /* [XID] */ /* 0x00000001898C7140-0x00000001898C7160 */ get => default; } // 0x0000000182F2D4D0-0x0000000182F2D580 
    public bool currentInWalkMode { /* [XID] */ /* 0x00000001898D60B0-0x00000001898D60D0 */ get => default; /* [XID] */ /* 0x00000001898DDD00-0x00000001898DDD20 */ set { } } // 0x0000000182F2BB60-0x0000000182F2BC10 0x0000000182F27CA0-0x0000000182F27D50
    public bool currentLockMoveMode { /* [XID] */ /* 0x00000001898E5600-0x00000001898E5620 */ get => default; /* [XID] */ /* 0x00000001898ECE60-0x00000001898ECE80 */ set { } } // 0x0000000182F34B50-0x0000000182F34C00 0x0000000182F29CA0-0x0000000182F29D50
    private VCLocalInputController localAvatarController { /* [XID] */ /* 0x0000000189903AB0-0x0000000189903AD0 */ get => default; } // 0x0000000182F28520-0x0000000182F286D0 
    public bool isRunning { /* [XID] */ /* 0x0000000189912C00-0x0000000189912C20 */ get => default; } // 0x0000000182F354A0-0x0000000182F35550 
    public bool forceSlowMove { /* [XID] */ /* 0x0000000189921CE0-0x0000000189921D00 */ get => default; } // 0x0000000182F2CE60-0x0000000182F2CF20 
    public ConfigAvatarFocus configAvatarFocus { /* [XID] */ /* 0x0000000189999E50-0x0000000189999E70 */ get => default; } // 0x0000000182F29FE0-0x0000000182F2A0A0 

    // Nested types
    [Serializable]
    public class SaveData // TypeDefIndex: 21023
    {
        // Fields
        public string scriptVersion; // 0x10
        public float mouseSensitivity; // 0x18
        public int joypadSenseIndex; // 0x1C
        public int joypadFocusSenseIndex; // 0x20
        public bool joypadInvertCameraX; // 0x24
        public bool joypadInvertCameraY; // 0x25
        public bool joypadInvertFocusCameraX; // 0x26
        public bool joypadInvertFocusCameraY; // 0x27
        public int mouseSenseIndex; // 0x28
        public int mouseFocusSenseIndex; // 0x2C
        public int touchpadSenseIndex; // 0x30
        public int touchpadFocusSenseIndex; // 0x34
        public bool enableTouchpadFocusAcceleration; // 0x38
        public float lastJoypadDefaultScale; // 0x3C
        public float lastJoypadFocusScale; // 0x40
        public float lastPCDefaultScale; // 0x44
        public float lastPCFocusScale; // 0x48
        public float lastTouchDefaultScale; // 0x4C
        public float lastTouchFcousScale; // 0x50
        public bool switchWalkRunByBtn; // 0x54
        public float cameraDistanceRatio; // 0x58
        public bool wwiseVibration; // 0x5C

        // Constructors
        public SaveData() { } // 0x0000000182F47960-0x0000000182F47A40
    }

    public enum InvertCameraType // TypeDefIndex: 21024
    {
        Normal = 0,
        Focus = 1
    }

    public enum InvertCameraAxisType // TypeDefIndex: 21025
    {
        X = 0,
        Y = 1
    }

    // Constructors
    public InputManager() { } // 0x0000000182F389D0-0x0000000182F38BF0
    static InputManager() { } // 0x0000000182F388C0-0x0000000182F389D0

    // Methods
    // [XID] // 0x0000000189A7A1F0-0x0000000189A7A210
    public void IncreaseKeySettingCounter() { } // 0x0000000182F33550-0x0000000182F335F0
                                                // [XID] // 0x0000000189AC3050-0x0000000189AC3070
    public bool SyncKeySetting(string contextName) => default; // 0x0000000182F312C0-0x0000000182F313D0
                                                               // [XID] // 0x0000000189A890B0-0x0000000189A890D0
    public InputJoypadType GetConnectedJoypadType() => default; // 0x0000000182F299D0-0x0000000182F29B10
                                                                // [XID] // 0x0000000189A90890-0x0000000189A908B0
    public InputJoypadType GetCurrJoypadType() => default; // 0x0000000182F36B50-0x0000000182F36C90
                                                           // [XID] // 0x0000000189A980D0-0x0000000189A980F0
    public void UpdateFirstJoypadController() { } // 0x0000000182F351D0-0x0000000182F35310
                                                  // [XID] // 0x0000000189A9F4B0-0x0000000189A9F4D0
    public override void Init() { } // 0x0000000182F305C0-0x0000000182F30770
                                    // [XID] // 0x0000000189AA6CC0-0x0000000189AA6CE0
    public override void InitByLocalData() { } // 0x0000000182F30520-0x0000000182F305C0
                                               // [XID] // 0x0000000189AAE430-0x0000000189AAE450
    public bool OnNotify(Notify ntf) => default; // 0x0000000182F369D0-0x0000000182F36AA0
                                                 // [XID] // 0x0000000189AB5CA0-0x0000000189AB5CC0
    private void InitDeviceType() { } // 0x0000000182F34740-0x0000000182F34890
    [DebuggerHidden] // 0x0000000189ABD710-0x0000000189ABD750
                     // [XID] // 0x0000000189ABD710-0x0000000189ABD750
    private IEnumerator InitInputPlugin() => default; // 0x0000000182F27F20-0x0000000182F28030
                                                      // [XID] // 0x0000000189AC8050-0x0000000189AC8070
    public override void ReloadRes() { } // 0x0000000182F384D0-0x0000000182F38570
                                         // [XID] // 0x0000000189ACF6B0-0x0000000189ACF6D0
    public override void ClearOnLevelDestroy() { } // 0x0000000182F2A640-0x0000000182F2A7C0
                                                   // [XID] // 0x0000000189AD7460-0x0000000189AD7480
    public override void ClearOnBackHome(bool forceClear = true /* Metadata: 0x00AFED0D */) { } // 0x0000000182F2A4E0-0x0000000182F2A590
                                                                                                // [XID] // 0x0000000189ADEF50-0x0000000189ADEF70
    public override void ClearOnDisconnect() { } // 0x0000000182F2A590-0x0000000182F2A640
                                                 // [XID] // 0x0000000189AE6820-0x0000000189AE6840
    public override void Destroy() { } // 0x0000000182F2C0E0-0x0000000182F2C280
                                       // [XID] // 0x0000000189AEE180-0x0000000189AEE1A0
    public override void Tick() { } // 0x0000000182F38570-0x0000000182F388C0
                                    // [XID] // 0x0000000189AF5910-0x0000000189AF5930
    public void OnSceneLoaded() { } // 0x0000000182F28780-0x0000000182F28820
                                    // [XID] // 0x0000000189AFCD30-0x0000000189AFCD50
    public override void LateTick() { } // 0x0000000182F33990-0x0000000182F33B90
                                        // [XID] // 0x0000000189B044A0-0x0000000189B044C0
    public Sprite GetCurrControllerElementIcon(InputActionType inputAction) => default; // 0x0000000182F33130-0x0000000182F33280
                                                                                        // [XID] // 0x0000000189B0BD10-0x0000000189B0BD30
    public bool IsConfirmBackInvert() => default; // 0x0000000182F323A0-0x0000000182F324E0
                                                  // [XID] // 0x0000000189B13300-0x0000000189B13320
    public void UpdateJoypadIconDisplayType() { } // 0x0000000182F2F790-0x0000000182F2F8D0
                                                  // [XID] // 0x0000000189B6F960-0x0000000189B6F980
    public void InitOnSceneLoaded()
    {
        var eventSys = GameObject.Find("EventSystem");
        if (!eventSys)
        {
            SuperDebug.LogError("Can't find instance of EventSystem");
            System.Type[] type = new System.Type[2];
            type[0] = System.Type.GetTypeFromHandle(typeof(MihoyoEventSystem).TypeHandle);
            type[1] = System.Type.GetTypeFromHandle(typeof(MihoyoStandaloneInputModule).TypeHandle);
            eventSys = new GameObject("EventSystem", type);
        }
        eventSystem = eventSys.GetComponent<MihoyoEventSystem>();
        eventSystemInputModule = eventSys.GetComponent<MihoyoStandaloneInputModule>();
        eventSystemInput = eventSys.GetComponent<MihoyoHybridInput>();

        if (Application.platform == RuntimePlatform.PS4 || Application.platform == RuntimePlatform.PS5)
        {
            eventSystemInputModule.allowTouchInput = false;
            eventSystemInputModule.forceModuleActive = true;
        }

        if (_simulatePointer == null)
        {
            _simulatePointer = new PointerEventData(eventSystem);
            _simulatePointer.button = PointerEventData.InputButton.Left;
        }
        InitEasyTouch();
    } // 0x0000000182F361B0-0x0000000182F36640
      // [XID] // 0x000000018962F390-0x000000018962F3B0
    public bool HasConnectedJoypad() => default; // 0x0000000182F2AE80-0x0000000182F2AFD0
                                                 // [XID] // 0x0000000189636E40-0x0000000189636E60
    public void ChangeInputDeviceType(InputDeviceType deviceType) { } // 0x0000000182F31480-0x0000000182F31620
                                                                      // [XID] // 0x000000018963E380-0x000000018963E3A0
    public Vector2 GetDefaultChangeViewScale() => default; // 0x0000000182F30910-0x0000000182F30A00
                                                           // [XID] // 0x0000000189662F60-0x0000000189662F80
    private void OnDeviceTypeSet() { } // 0x0000000182F2C350-0x0000000182F2C820
                                       // [XID] // 0x000000018964D460-0x000000018964D480
    public void UpdateJoypadChangeViewScale(Vector2 scale) { } // 0x0000000182F2F180-0x0000000182F2F240
                                                               // [XID] // 0x0000000189654CE0-0x0000000189654D00
    public void SwitchInputContextToCustom(string[] customEvents, string[] customContextEvents, SimpleSafeInt32[] priorityList) { } // 0x0000000182F31850-0x0000000182F31D60
                                                                                                                                    // [XID] // 0x000000018965C230-0x000000018965C250
    public void SwitchBackInputContextFromCustom() { } // 0x0000000182F2A9F0-0x0000000182F2AE80
                                                       // [XID] // 0x0000000189663A20-0x0000000189663A40
    private void SendInputDeviceTypeChange() { } // 0x0000000182F30AA0-0x0000000182F30F30
                                                 // [XID] // 0x000000018966B280-0x000000018966B2A0
    public void ChangeMouseSensitivity(float sensitivity) { } // 0x0000000182F2F9E0-0x0000000182F2FB10
                                                              // [XID] // 0x0000000189672F20-0x0000000189672F40
    public void ChangeCameraDistance(float distance, float ratio) { } // 0x0000000182F2A240-0x0000000182F2A310
                                                                      // [XID] // 0x000000018967A570-0x000000018967A590
    public void ChangeCameraSensitivitySettingIndex(int index) { } // 0x0000000182F2E3E0-0x0000000182F2E5D0
                                                                   // [XID] // 0x0000000189681E50-0x0000000189681E70
    public void ChangeFocusCameraSensitivityIndex(int index) { } // 0x0000000182F2DD40-0x0000000182F2DE10
                                                                 // [XID] // 0x00000001896898A0-0x00000001896898C0
    public void CheckCursorState() { } // 0x0000000182F2FC20-0x0000000182F2FD80
                                       // [XID] // 0x0000000189691600-0x0000000189691620
    public void SetVirtualCursorActive(bool enable, UIVirtualCursorType cursorType = UIVirtualCursorType.Normal /* Metadata: 0x00AFED0E */) { } // 0x0000000182F33280-0x0000000182F33360
                                                                                                                                                // [XID] // 0x0000000189760750-0x0000000189760770
    public void EnableVirtualCursor(UIVirtualCursorType cursorType = UIVirtualCursorType.Normal /* Metadata: 0x00AFED12 */) { } // 0x0000000182F2E5D0-0x0000000182F2E800
                                                                                                                                // [XID] // 0x00000001896A0130-0x00000001896A0150
    public void DisableVirtualCursor() { } // 0x0000000182F36CF0-0x0000000182F36EF0
                                           // [XID] // 0x00000001896A74A0-0x00000001896A74C0
    public void DispatchInputEvent() { } // 0x0000000182F2D130-0x0000000182F2D350
                                         // [XID] // 0x00000001896AE980-0x00000001896AE9A0
    private bool CanPassDispatchInputEventPreCheck() => default; // 0x0000000182F35EB0-0x0000000182F35FB0
                                                                 // [XID] // 0x00000001896B6180-0x00000001896B61A0
    private bool CheckContextState(BaseContext context) => default; // 0x0000000182F32EB0-0x0000000182F32FC0
                                                                    // [XID] // 0x00000001896BD3E0-0x00000001896BD400
    private bool TryApplyInputEvents(BaseContext context, ref bool frameEnd) => default; // 0x0000000182F376C0-0x0000000182F37EB0
                                                                                         // [XID] // 0x00000001896C4960-0x00000001896C4980
    private void UpdateCompoundAction(InputActionType actionType, ConfigCompoundInputAction actionConfig) { } // 0x0000000182F2FE40-0x0000000182F30070
                                                                                                              // [XID] // 0x00000001896CBED0-0x00000001896CBEF0
    private bool TryApplySimpleButtonInputEvent(BaseContext context, InputActionEvent inputEvent) => default; // 0x0000000182F35850-0x0000000182F35C60
                                                                                                              // [XID] // 0x00000001896D3220-0x00000001896D3240
    private bool TryApplySimpleAxisInputEvent(BaseContext context, InputActionEvent inputEvent) => default; // 0x0000000182F31EB0-0x0000000182F32280
                                                                                                            // [XID] // 0x00000001896DADA0-0x00000001896DADC0
    private bool TryApplyInputEvent(BaseContext context, InputActionEvent inputEvent, ref TwoAxisActionData actionData) => default; // 0x0000000182F2CF20-0x0000000182F2D130
                                                                                                                                    // [XID] // 0x00000001896E2540-0x00000001896E2560
    private bool TryApplyAllPressInputEvent(BaseContext context, InputActionEvent inputEvent, ConfigCompoundInputAction compoundConfig) => default; // 0x0000000182F28030-0x0000000182F283C0
                                                                                                                                                    // [XID] // 0x00000001896E9A20-0x00000001896E9A40
    private bool CheckButtonDelayTime(InputActionType action1, InputActionType action2) => default; // 0x0000000182F28A20-0x0000000182F28B70
                                                                                                    // [XID] // 0x00000001896F0BE0-0x00000001896F0C00
    private void SetCommonActionData(InputActionType actionType, int frame, float time) { } // 0x0000000182F2DBE0-0x0000000182F2DD40
                                                                                            // [XID] // 0x00000001896F8440-0x00000001896F8460
    private bool CheckDebugTrigger() => default; // 0x0000000182F37EB0-0x0000000182F380F0
                                                 // [XID] // 0x00000001897074C0-0x00000001897074E0
    public void HandleGM(string[] args) { } // 0x0000000182F33DA0-0x0000000182F345E0
                                            // [XID] // 0x000000018970ED80-0x000000018970EDA0
    private void SetDebugFlag(string name, bool enable) { } // 0x0000000182F2F570-0x0000000182F2F6E0
                                                            // [XID] // 0x00000001897161A0-0x00000001897161C0
    private void LoadSaveData() { } // 0x0000000182F2DE10-0x0000000182F2E0D0
                                    // [XID] // 0x000000018971DC20-0x000000018971DC40
    private void UploadSaveData() { } // 0x0000000182F36EF0-0x0000000182F372D0
                                      // [XID] // 0x0000000189725100-0x0000000189725120
    private void InitEasyTouch() { } // 0x0000000182F380F0-0x0000000182F38280
                                     // [XID] // 0x000000018972C7E0-0x000000018972C800
    private bool GetEasyTouchEnabled() => default; // 0x0000000182F29B10-0x0000000182F29CA0
                                                   // [XID] // 0x0000000189733EF0-0x0000000189733F10
    private void SetEasyTouchEnabled(bool enabled) { } // 0x0000000182F2BF40-0x0000000182F2C0E0
                                                       // [XID] // 0x0000000189759420-0x0000000189759440
    public bool HasConnectedJoypadNoGC() => default; // 0x0000000182F37520-0x0000000182F376C0
                                                     // [XID] // 0x0000000189760FD0-0x0000000189760FF0
    private void CheckIfJoystickDisconnectWhenInJoystickMode() { } // 0x0000000182F33360-0x0000000182F33550
                                                                   // [XID] // 0x0000000189768360-0x0000000189768380
    public void SetMenuButtonRightConfirm(bool val) { } // 0x0000000182F34890-0x0000000182F34AA0
                                                        // [XID] // 0x000000018976FA50-0x000000018976FA70
    public void ApplyInvertAxis(ref Vector2 axisVec) { } // 0x0000000182F30770-0x0000000182F30850
                                                         // [XID] // 0x000000018998B6E0-0x000000018998B700
    public Vector2 GetFocusInvertModifier() => default; // 0x0000000182F35310-0x0000000182F35440
                                                        // [XID] // 0x000000018977E9E0-0x000000018977EA00
    public void SetFocusCamera(InvertCameraType cameraType, InvertCameraAxisType axisType, bool value) { } // 0x0000000182F35550-0x0000000182F35660
                                                                                                           // [XID] // 0x0000000189786160-0x0000000189786180
    public void SetTouchPadFocusAcceleration(bool enable) { } // 0x0000000182F2A0A0-0x0000000182F2A160
                                                              // [XID] // 0x000000018978D7F0-0x000000018978D810
    public void SetWwiseVibration(bool bVibration) { } // 0x0000000182F29820-0x0000000182F29930
                                                       // [XID] // 0x0000000189794C80-0x0000000189794CA0
    public string DumpInputManagerState() => default; // 0x0000000182F2E910-0x0000000182F2EFD0
                                                      // [XID] // 0x000000018979D1F0-0x000000018979D210
    public string GetActionDescription(InputActionType inputAction) => default; // 0x0000000182F32AD0-0x0000000182F32C50
                                                                                // [XID] // 0x00000001897A44B0-0x00000001897A44D0
    private bool GetOrAddCommonActionData(InputActionType actionType, out CommonActionData actionData)
    {
        actionData = default;
        return default;
    } // 0x0000000182F2CA40-0x0000000182F2CC60
      // [XID] // 0x00000001897ABA20-0x00000001897ABA40
    public int GetActionLastUpdateFrame(InputActionType actionType) => default; // 0x0000000182F2C820-0x0000000182F2C940
                                                                                // [XID] // 0x00000001897B3980-0x00000001897B39A0
    public void UpdateActionLastUpdateFrame(InputActionType actionType) { } // 0x0000000182F2F450-0x0000000182F2F570
                                                                            // [XID] // 0x00000001897BB790-0x00000001897BB7B0
    public bool TryGetTwoAxisActionData(InputActionType actionType, out TwoAxisActionData actionData)
    {
        actionData = default;
        return default;
    } // 0x0000000182F350E0-0x0000000182F351D0
      // [XID] // 0x00000001897C2FF0-0x00000001897C3010
    public Vector2 GetTwoAxisActionValue(InputActionType actionType) => default; // 0x0000000182F29D50-0x0000000182F29EA0
                                                                                 // [XID] // 0x00000001897CA890-0x00000001897CA8B0
    public Vector2 GetTwoAxisEventValue(InputActionEvent actionEvent) => default; // 0x0000000182F2DAA0-0x0000000182F2DBE0
                                                                                  // [XID] // 0x00000001897D1E50-0x00000001897D1E70
    public float GetOneAxisEventValue(InputActionEvent actionEvent) => default; // 0x0000000182F2D990-0x0000000182F2DAA0
                                                                                // [XID] // 0x00000001897D9CB0-0x00000001897D9CD0
    public bool GetButtonDown(InputActionType actionType) => default; // 0x0000000182F294E0-0x0000000182F29640
                                                                      // [XID] // 0x00000001897E0FE0-0x00000001897E1000
    public bool GetButtonUp(InputActionType actionType) => default; // 0x0000000182F335F0-0x0000000182F33750
                                                                    // [XID] // 0x00000001897E8710-0x00000001897E8730
    public float GetAxis(InputActionType actionType) => default; // 0x0000000182F2D7D0-0x0000000182F2D930
                                                                 // [XID] // 0x00000001897F03A0-0x00000001897F03C0
    public float GetAxisRaw(InputActionType actionType) => default; // 0x0000000182F36870-0x0000000182F369D0
                                                                    // [XID] // 0x0000000189627150-0x0000000189627170
    public List<KeyCode> GetKeyboardMouseMap(InputActionType actionType) => default; // 0x0000000182F32CB0-0x0000000182F32E10
                                                                                     // [XID] // 0x0000000189610E40-0x0000000189610E60
    public ActionElementMap GetKeyboardActionMap(InputActionType actionType) => default; // 0x0000000182F36060-0x0000000182F361B0
                                                                                         // [XID] // 0x00000001898068D0-0x00000001898068F0
    public void GetKeyboardMouseMapNoGC(InputActionType actionType, List<KeyCode> keyCodeList) { } // 0x0000000182F32FC0-0x0000000182F33130
                                                                                                   // [XID] // 0x000000018980E0B0-0x000000018980E0D0
    public void GetKeyboardActionMapNoGC(InputActionType actionType, List<KeyCode> keyCodeList) { } // 0x0000000182F2A880-0x0000000182F2A9F0
                                                                                                    // [XID] // 0x0000000189815790-0x00000001898157B0
    public List<KeyboardIconKeySprite> GetKeyboardMouseMapKeySprite(InputActionType actionType) => default; // 0x0000000182F2CD10-0x0000000182F2CE60
                                                                                                            // [XID] // 0x000000018981D180-0x000000018981D1A0
    public string GetActionKeyString(InputActionType actionType) => default; // 0x0000000182F31000-0x0000000182F31100
                                                                             // [XID] // 0x00000001898245E0-0x0000000189824600
    private void ClearHandledEvents() { } // 0x0000000182F2EFD0-0x0000000182F2F090
                                          // [XID] // 0x000000018982C0B0-0x000000018982C0D0
    private void AddHandledEvents(InputActionEvent eventData) { } // 0x0000000182F27D50-0x0000000182F27E50
                                                                  // [XID] // 0x0000000189833580-0x00000001898335A0
    public bool HasHandledEvent(InputEventType eventType) => default; // 0x0000000182F34F60-0x0000000182F35030
                                                                      // [XID] // 0x000000018983AA60-0x000000018983AA80
    public bool TryGetHandledEventByActionType(InputActionType actionType, out InputActionEvent actionEvent)
    {
        actionEvent = default;
        return default;
    } // 0x0000000182F2BC10-0x0000000182F2BF40
      // [XID] // 0x00000001898420C0-0x00000001898420E0
    public PointerEventData GetScrollData(float x, float y) => default; // 0x0000000182F2B970-0x0000000182F2BB60
                                                                        // [XID] // 0x000000018962EA10-0x000000018962EA30
    public string GetModKeyCodeUserfriendlyName(ModifierKey key) => default; // 0x0000000182F34DA0-0x0000000182F34EB0
                                                                             // [XID] // 0x0000000189B157D0-0x0000000189B157F0
    private KeyCode ModifierKeyConvertToKeyCode(ModifierKey key) => default; // 0x0000000182F28C80-0x0000000182F28D60
                                                                             // [XID] // 0x0000000189858160-0x0000000189858180
    public string GetCompoundKey(List<KeyCode> keylist) => default; // 0x0000000182F38280-0x0000000182F384D0
                                                                    // [XID] // 0x000000018965BC70-0x000000018965BC90
    public string GetKeyCodeUserfriendlyName(KeyCode keyCode) => default; // 0x0000000182F2B0F0-0x0000000182F2B970
                                                                          // [XID] // 0x0000000189636720-0x0000000189636740
    private bool TryGetKeyboardLayoutSpecialText(KeyCode keyCode, out string result)
    {
        result = default;
        return default;
    } // 0x0000000182F33750-0x0000000182F33990
      // [XID] // 0x000000018987D2F0-0x000000018987D310
    public void enableGyroscope(bool enable) { } // 0x0000000182F30070-0x0000000182F30120
                                                 // [XID] // 0x00000001898CE6D0-0x00000001898CE6F0
    public void SetSwitchWalkRunByBtn(bool b) { } // 0x0000000182F2FD80-0x0000000182F2FE40
                                                  // [XID] // 0x00000001898F4720-0x00000001898F4740
    public void SetMoveStatus(float roleMoveAngle, float roleMoveMold) { } // 0x0000000182F29640-0x0000000182F29820
                                                                           // [XID] // 0x00000001898FBFF0-0x00000001898FC010
    public void RefreshAvatarController() { } // 0x0000000182F324E0-0x0000000182F326C0
                                              // [XID] // 0x000000018990AF50-0x000000018990AF70
    private VCHumanoidMove GetLocalAvatarMove() => default; // 0x0000000182F37370-0x0000000182F37520
                                                            // [XID] // 0x000000018991A550-0x000000018991A570
    private void UpdateMoveStatus() { } // 0x0000000182F30120-0x0000000182F30520
                                        // [XID] // 0x00000001899E27E0-0x00000001899E2800
    public void SetForceSlowMove(bool forceSlow, int reason) { } // 0x0000000182F2A3C0-0x0000000182F2A4E0
                                                                 // [XID] // 0x0000000189930AC0-0x0000000189930AE0
    public bool GetForceSlowMoveByReason(int reason) => default; // 0x0000000182F27E50-0x0000000182F27F20
                                                                 // [XID] // 0x0000000189937E90-0x0000000189937EB0
    public void ForceControlMove(bool enable, float angle, float mold) { } // 0x0000000182F2E0D0-0x0000000182F2E1C0
                                                                           // [XID] // 0x000000018993F920-0x000000018993F940
    private float GetFinalMoveAngle(float inputAngle) => default; // 0x0000000182F283C0-0x0000000182F28480
                                                                  // [XID] // 0x0000000189947000-0x0000000189947020
    private float GetFinalMoveMold(float inputMold) => default; // 0x0000000182F31620-0x0000000182F31850
                                                                // [XID] // 0x000000018994E640-0x000000018994E660
    public void EnableRotateCamera(bool enable) { } // 0x0000000182F311B0-0x0000000182F31260
                                                    // [XID] // 0x0000000189955C80-0x0000000189955CA0
    public bool GetRotateCamera() => default; // 0x0000000182F286D0-0x0000000182F28780
                                              // [XID] // 0x000000018995D760-0x000000018995D780
    public void SetCameraControl(bool enable) { } // 0x0000000182F35660-0x0000000182F35710
                                                  // [XID] // 0x0000000189964DF0-0x0000000189964E10
    public void RotateCamera(Vector2 rotate) { } // 0x0000000182F32990-0x0000000182F32AD0
                                                 // [XID] // 0x000000018996C350-0x000000018996C370
    public void MoveCamera(Vector2 move) { } // 0x0000000182F2E300-0x0000000182F2E3E0
                                             // [XID] // 0x0000000189973E90-0x0000000189973EB0
    public void SetRefAnchorPosition(Vector3 pos) { } // 0x0000000182F2F8D0-0x0000000182F2F9E0
                                                      // [XID] // 0x000000018997B630-0x000000018997B650
    public void SetCameraPosition(Vector3 pos) { } // 0x0000000182F2E800-0x0000000182F2E910
                                                   // [XID] // 0x00000001899830D0-0x00000001899830F0
    public void SetClampRotatePitch(Vector2 clampVal) { } // 0x0000000182F2D350-0x0000000182F2D430
                                                          // [XID] // 0x000000018998A820-0x000000018998A840
    public void SetClampZoomScale(Vector2 clampVal) { } // 0x0000000182F2A160-0x0000000182F2A240
                                                        // [XID] // 0x000000018973E4E0-0x000000018973E500
    private void UpdateAvatarFocusConfig() { } // 0x0000000182F2D580-0x0000000182F2D7D0
                                               // [XID] // 0x00000001899A1510-0x00000001899A1530
    public void CheckInputDeviceUserSettings() { } // 0x0000000182F28E00-0x0000000182F29430
}

