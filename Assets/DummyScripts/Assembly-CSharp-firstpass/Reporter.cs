/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

public class Reporter : MonoBehaviour // TypeDefIndex: 8029
{
	// Fields
	private static Reporter _instance; // 0x00
	public int numOfRecentLogs; // 0x18
	public int numOfRecentWarnings; // 0x1C
	public int numOfRecentErrors; // 0x20
	private List<Sample> samples; // 0x28
	private GraphicRaycaster _uguiRaycaster; // 0x30
	private List<Log> logs; // 0x38
	private List<Log> collapsedLogs; // 0x40
	private List<Log> currentLog; // 0x48
	private MultiKeyDictionary<string, string, Log> logsDic; // 0x50
	private Dictionary<string, string> cachedString; // 0x58
	[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
	public bool show; // 0x60
	private bool collapse; // 0x61
	private bool clearOnNewSceneLoaded; // 0x62
	public Func<string, bool> consoleCommandMethod; // 0x68
	private bool showTime; // 0x70
	private bool showScene; // 0x71
	private bool showMemory; // 0x72
	private bool showFps; // 0x73
	private bool showGraph; // 0x74
	public bool isIPhoneX; // 0x75
	private bool showLog; // 0x76
	private bool showWarning; // 0x77
	private bool showError; // 0x78
	private int numOfLogs; // 0x7C
	private int numOfLogsWarning; // 0x80
	private int numOfLogsError; // 0x84
	private int numOfCollapsedLogs; // 0x88
	private int numOfCollapsedLogsWarning; // 0x8C
	private int numOfCollapsedLogsError; // 0x90
	private float recentTime; // 0x94
	private bool showClearOnNewSceneLoadedButton; // 0x98
	private bool showTimeButton; // 0x99
	private bool showSceneButton; // 0x9A
	private bool showMemButton; // 0x9B
	private bool showFpsButton; // 0x9C
	private bool showSearchText; // 0x9D
	private string buildDate; // 0xA0
	private string logDate; // 0xA8
	private float logsMemUsage; // 0xB0
	private float graphMemUsage; // 0xB4
	private float gcTotalMemory; // 0xB8
	public string UserData; // 0xC0
	public float fps; // 0xC8
	public string fpsText; // 0xD0
	private ReportView currentView; // 0xD8
	private static bool created; // 0x08
	public Images images; // 0xE0
	public GameObject datapathBrowser; // 0xE8
	private GUIContent clearContent; // 0xF0
	private GUIContent collapseContent; // 0xF8
	private GUIContent clearOnNewSceneContent; // 0x100
	private GUIContent showTimeContent; // 0x108
	private GUIContent showSceneContent; // 0x110
	private GUIContent userContent; // 0x118
	private GUIContent showMemoryContent; // 0x120
	private GUIContent softwareContent; // 0x128
	private GUIContent dateContent; // 0x130
	private GUIContent showFpsContent; // 0x138
	private GUIContent infoContent; // 0x140
	private GUIContent browserContent; // 0x148
	private GUIContent searchContent; // 0x150
	private GUIContent closeContent; // 0x158
	private GUIContent buildFromContent; // 0x160
	private GUIContent systemInfoContent; // 0x168
	private GUIContent graphicsInfoContent; // 0x170
	private GUIContent backContent; // 0x178
	private GUIContent logContent; // 0x180
	private GUIContent warningContent; // 0x188
	private GUIContent errorContent; // 0x190
	private GUIStyle barStyle; // 0x198
	private GUIStyle buttonActiveStyle; // 0x1A0
	private GUIStyle nonStyle; // 0x1A8
	private GUIStyle lowerLeftFontStyle; // 0x1B0
	private GUIStyle backStyle; // 0x1B8
	private GUIStyle evenLogStyle; // 0x1C0
	private GUIStyle oddLogStyle; // 0x1C8
	private GUIStyle logButtonStyle; // 0x1D0
	private GUIStyle selectedLogStyle; // 0x1D8
	private GUIStyle selectedLogFontStyle; // 0x1E0
	private GUIStyle stackLabelStyle; // 0x1E8
	private GUIStyle scrollerStyle; // 0x1F0
	private GUIStyle searchStyle; // 0x1F8
	private GUIStyle sliderBackStyle; // 0x200
	private GUIStyle sliderThumbStyle; // 0x208
	private GUISkin toolbarScrollerSkin; // 0x210
	private GUISkin logScrollerSkin; // 0x218
	private GUISkin graphScrollerSkin; // 0x220
	private string filterText; // 0x228
	public Vector2 size; // 0x230
	public float maxSize; // 0x238
	public int numOfCircleToShow; // 0x23C
	private static string[] scenes; // 0x10
	private string currentScene; // 0x240
	private string deviceModel; // 0x248
	private string deviceType; // 0x250
	private string deviceName; // 0x258
	private string graphicsMemorySize; // 0x260
	private string maxTextureSize; // 0x268
	private string systemMemorySize; // 0x270
	private bool Initialized; // 0x278
	private Rect screenRect; // 0x27C
	private Rect toolBarRect; // 0x28C
	private Rect logsRect; // 0x29C
	private Rect stackRect; // 0x2AC
	private Rect graphRect; // 0x2BC
	private Rect graphMinRect; // 0x2CC
	private Rect graphMaxRect; // 0x2DC
	private Rect buttomRect; // 0x2EC
	private Vector2 stackRectTopLeft; // 0x2FC
	private Rect detailRect; // 0x304
	private Vector2 scrollPosition; // 0x314
	private Vector2 scrollPosition2; // 0x31C
	private Vector2 toolbarScrollPosition; // 0x324
	private Log selectedLog; // 0x330
	private float toolbarOldDrag; // 0x338
	private float oldDrag; // 0x33C
	private float oldDrag2; // 0x340
	private float oldDrag3; // 0x344
	private int startIndex; // 0x348
	private Rect countRect; // 0x34C
	private Rect timeRect; // 0x35C
	private Rect timeLabelRect; // 0x36C
	private Rect sceneRect; // 0x37C
	private Rect sceneLabelRect; // 0x38C
	private Rect memoryRect; // 0x39C
	private Rect memoryLabelRect; // 0x3AC
	private Rect fpsRect; // 0x3BC
	private Rect fpsLabelRect; // 0x3CC
	private GUIContent tempContent; // 0x3E0
	private Vector2 infoScrollPosition; // 0x3E8
	private Vector2 oldInfoDrag; // 0x3F0
	private string _consoleCmdStr; // 0x3F8
	private Rect tempRect; // 0x400
	private float graphSize; // 0x410
	private int startFrame; // 0x414
	private int currentFrame; // 0x418
	private Vector3 tempVector1; // 0x41C
	private Vector3 tempVector2; // 0x428
	private Vector2 graphScrollerPos; // 0x434
	private float maxFpsValue; // 0x43C
	private float minFpsValue; // 0x440
	private float maxMemoryValue; // 0x444
	private float minMemoryValue; // 0x448
	private float lastClickTime; // 0x44C
	private Vector2 startPos; // 0x450
	private Vector2 downPos; // 0x458
	private Vector2 mousePosition; // 0x460
	private const int requiredFrames = 10; // Metadata: 0x00ADF439
	private const float updateInterval = 0.25f; // Metadata: 0x00ADF43D
	private List<Log> threadedLogs; // 0x468

	// Properties
	public float TotalMemUsage { get => default; } // 0x00000001862D5740-0x00000001862D57B0 

	// Nested types
	public enum _LogType // TypeDefIndex: 8030
	{
		Error = 0,
		Assert = 1,
		Warning = 2,
		Log = 3,
		Exception = 4
	}

	public class Sample // TypeDefIndex: 8031
	{
		// Fields
		public float time; // 0x10
		public byte loadedScene; // 0x14
		public float memory; // 0x18
		public float fps; // 0x1C
		public string fpsText; // 0x20

		// Constructors
		public Sample() {} // 0x00000001862D70D0-0x00000001862D7130

		// Methods
		public static float MemSize() => default; // 0x00000001862D7070-0x00000001862D70D0
		public string GetSceneName() => default; // 0x00000001862D6FB0-0x00000001862D7070
	}

	public class Log // TypeDefIndex: 8032
	{
		// Fields
		public int count; // 0x10
		public _LogType logType; // 0x14
		public string condition; // 0x18
		public string stacktrace; // 0x20
		public int sampleId; // 0x28

		// Constructors
		public Log() {} // 0x00000001862C8FC0-0x00000001862C9030

		// Methods
		public Log CreateCopy() => default; // 0x00000001862C8E50-0x00000001862C8F10
		public float GetMemoryUsage() => default; // 0x00000001862C8F10-0x00000001862C8FC0
	}

	private enum ReportView // TypeDefIndex: 8033
	{
		None = 0,
		Logs = 1,
		Info = 2,
		Snapshot = 3
	}

	private enum DetailView // TypeDefIndex: 8034
	{
		None = 0,
		StackTrace = 1,
		Graph = 2
	}

	// Constructors
	public Reporter() {} // 0x00000001862D00A0-0x00000001862D0330
	static Reporter() {} // 0x00000001862D0040-0x00000001862D00A0

	// Methods
	public static Reporter GetInstance() => default; // 0x00000001862CE8E0-0x00000001862CE970
	private void Awake() {} // 0x00000001862CA9C0-0x00000001862CAA60
	private void OnDestroy() {} // 0x00000001862CF560-0x00000001862CF5F0
	private void RegisterLogCallback() {} // 0x00000001862CFAC0-0x00000001862CFB60
	private void OnEnable() {} // 0x00000001862CF640-0x00000001862CF6D0
	private void OnDisable() {} // 0x00000001862CF5F0-0x00000001862CF640
	private void addSample() {} // 0x00000001862D0330-0x00000001862D04F0
	public void Initialize() {} // 0x00000001862CE970-0x00000001862CF4C0
	private void initializeStyle() {} // 0x00000001862D57B0-0x00000001862D6BA0
	private void Start() {} // 0x00000001862CFB60-0x00000001862CFC10
	private void clear() {} // 0x00000001862D09C0-0x00000001862D0AF0
	private void calculateCurrentLog() {} // 0x00000001862D04F0-0x00000001862D08E0
	private void DrawInfo() {} // 0x00000001862CAC90-0x00000001862CD0D0
	private void drawInfo_enableDisableToolBarButtons() {} // 0x00000001862D1E10-0x00000001862D29B0
	private void DrawReport() {} // 0x00000001862CE470-0x00000001862CE8E0
	private void drawToolBar() {} // 0x00000001862D3330-0x00000001862D5260
	private void DrawLogs() {} // 0x00000001862CD0D0-0x00000001862CE470
	private void drawGraph() {} // 0x00000001862D0B80-0x00000001862D1E10
	private void drawStack() {} // 0x00000001862D29B0-0x00000001862D3330
	public void OnGUIDraw() {} // 0x00000001862CF6D0-0x00000001862CF9A0
	private bool isGestureDone() => default; // 0x00000001862D6D70-0x00000001862D6EE0
	private bool isDoubleClickDone() => default; // 0x00000001862D6BA0-0x00000001862D6D70
	private Vector2 getDownPos() => default; // 0x00000001862D5260-0x00000001862D54D0
	private Vector2 getDrag() => default; // 0x00000001862D54D0-0x00000001862D5740
	private void calculateStartIndex() {} // 0x00000001862D08E0-0x00000001862D09C0
	private void doShow() {} // 0x00000001862D0AF0-0x00000001862D0B80
	private void Update() {} // 0x00000001862CFC10-0x00000001862D0040
	private void CaptureLog(string condition, string stacktrace, LogType type) {} // 0x00000001862CABD0-0x00000001862CAC90
	private void AddLog(string condition, string stacktrace, LogType type) {} // 0x00000001862CA2B0-0x00000001862CA9C0
	private void CaptureLogThread(string condition, string stacktrace, LogType type) {} // 0x00000001862CAA60-0x00000001862CABD0
	private void OnSceneLoaded(Scene scene, LoadSceneMode mode) {} // 0x00000001862CF9A0-0x00000001862CFAC0
	private void OnApplicationQuit() {} // 0x00000001862CF510-0x00000001862CF560
	private static bool IsIPhoneX() => default; // 0x00000001862CF4C0-0x00000001862CF510
	[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
	private IEnumerator readInfo() => default; // 0x00000001862D6EE0-0x00000001862D6FB0
}

