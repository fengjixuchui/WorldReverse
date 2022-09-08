/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using AOT;
using UnityEngine;
using UnityEngine.Serialization;

// Image 52: ZFBrowser.dll - Assembly: ZFBrowser, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5943-6607

namespace ZenFulcrum.EmbeddedBrowser
{
	public class Browser : MonoBehaviour // TypeDefIndex: 5945
	{
		// Fields
		private static int lastUpdateFrame; // 0x00
		public static bool isLinear; // 0x04
		protected IBrowserUI _uiHandler; // 0x18
		protected bool uiHandlerAssigned; // 0x20
		[SerializeField] // 0x0000000189B5ED90-0x0000000189B5EDE0
		// [Tooltip] // 0x0000000189B5ED90-0x0000000189B5EDE0
		private string _url; // 0x28
		[SerializeField] // 0x0000000189B76840-0x0000000189B76890
		// [Tooltip] // 0x0000000189B76840-0x0000000189B76890
		private int _width; // 0x30
		[SerializeField] // 0x0000000189B76840-0x0000000189B76890
		// [Tooltip] // 0x0000000189B76840-0x0000000189B76890
		private int _height; // 0x34
		// [Tooltip] // 0x0000000189B80CE0-0x0000000189B80D10
		public bool generateMipmap; // 0x38
		// [FormerlySerializedAs] // 0x0000000189B8A020-0x0000000189B8A080
		// [Tooltip] // 0x0000000189B8A020-0x0000000189B8A080
		public Color32 baseColor; // 0x3C
		[SerializeField] // 0x0000000189B97060-0x0000000189B970B0
		// [Tooltip] // 0x0000000189B97060-0x0000000189B970B0
		private float _zoom; // 0x40
		[FlagsField] // 0x0000000189BAD2A0-0x0000000189BAD2F0
		// [Tooltip] // 0x0000000189BAD2A0-0x0000000189BAD2F0
		public BrowserNative.ContextMenuOrigin allowContextMenuOn; // 0x50
		[SerializeField] // 0x0000000189BB8CD0-0x0000000189BB8D20
		// [Tooltip] // 0x0000000189BB8CD0-0x0000000189BB8D20
		private NewWindowAction newWindowAction; // 0x54
		[NonSerialized]
		protected internal int browserId; // 0x70
		private int unsafeBrowserId; // 0x74
		protected bool browserIdRequested; // 0x78
		protected Texture2D texture; // 0x80
		protected bool textureIsOurs; // 0x90
		protected bool forceNextRender; // 0x91
		protected bool isPopup; // 0x92
		protected List<Action> thingsToDo; // 0x98
		protected List<Action> onloadActions; // 0xA0
		protected List<object> thingsToRemember; // 0xA8
		protected static Dictionary<int, List<object>> allThingsToRemember; // 0x08
		private int nextCallbackId; // 0xB0
		protected Dictionary<int, JSResultFunc> registeredCallbacks; // 0xB8
		public Action<int, JSONNode> onDownloadStarted; // 0x100
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public readonly BrowserFocusState focusState; // 0x128
		private BrowserInput browserInput; // 0x130
		private Browser overlay; // 0x138
		private bool skipNextLoad; // 0x140
		private bool loadPending; // 0x141
		private BrowserNavState navState; // 0x148
		private bool newWindowHandlerSet; // 0x150
		private INewWindowHandler newWindowHandler; // 0x158
		protected DialogHandler dialogHandler; // 0x160
		private Action pageReplacer; // 0x168
		private float pageReplacerPriority; // 0x170
		protected List<Action> thingsToDoClone; // 0x178
		private Color32[] colorBuffer; // 0x180
		internal static Dictionary<int, Browser> allBrowsers; // 0x20
	
		// Properties
		public static string LocalUrlPrefix { get => default; } // 0x0000000186F75470-0x0000000186F75530 
		public IBrowserUI UIHandler { get => default; set {} } // 0x0000000186F75670-0x0000000186F756D0 0x0000000186F766D0-0x0000000186F76740
		[Obsolete] // 0x000000018988B200-0x000000018988B230
		public INewWindowHandler NewWindowHandler { get; set; } // 0x0000000186F75530-0x0000000186F75590 0x0000000186F76670-0x0000000186F766D0
		public bool EnableRendering { get; set; } // 0x0000000186F751E0-0x0000000186F75240 0x0000000186F76610-0x0000000186F76670
		public bool EnableInput { get; set; } // 0x0000000186F75180-0x0000000186F751E0 0x0000000186F765B0-0x0000000186F76610
		public CookieManager CookieManager { get; private set; } // 0x0000000186F75120-0x0000000186F75180 0x0000000186F76550-0x0000000186F765B0
		public Texture2D Texture { get => default; } // 0x0000000186F75610-0x0000000186F75670 
		public bool IsReady { get => default; } // 0x0000000186F75410-0x0000000186F75470 
		public string Url { get => default; set {} } // 0x0000000186F756D0-0x0000000186F75740 0x0000000186F76740-0x0000000186F767C0
		public bool CanGoBack { get => default; } // 0x0000000186F75040-0x0000000186F750B0 
		public bool CanGoForward { get => default; } // 0x0000000186F750B0-0x0000000186F75120 
		public bool IsLoadingRaw { get => default; } // 0x0000000186F753A0-0x0000000186F75410 
		public bool IsLoaded { get => default; } // 0x0000000186F75240-0x0000000186F753A0 
		public Vector2 Size { get => default; } // 0x0000000186F75590-0x0000000186F75610 
		public float Zoom { get => default; set {} } // 0x0000000186F75740-0x0000000186F757B0 0x0000000186F767C0-0x0000000186F76950
	
		// Events
		public event Action<string, string> onConsoleMessage;
		public event Action<Texture2D> afterResize;
		protected event BrowserNative.ReadyFunc onNativeReady;
		public event Action<JSONNode> onLoad;
		[Obsolete] // 0x0000000189893FC0-0x0000000189893FF0
		public event Action<JSONNode> onFetch;
		public event Action<JSONNode> onFetchError;
		public event Action<JSONNode> onCertError;
		public event Action onSadTab;
		public event Action onTextureUpdated;
		public event Action onNavStateChange;
		public event Action<int, JSONNode> onDownloadStatus;
		public event Action<string, bool, string> onNodeFocus;
		public event Action<JSONNode> onUniWebviewMsgReceive;
		public event Action<bool, bool> onBrowserFocus;
		public static event Action<Browser> onAnyBrowserCreated;
		public static event Action<Browser> onAnyBrowserDestroyed;
	
		// Nested types
		[Flags] // 0x000000018990A800-0x000000018990A810
		public enum NewWindowAction // TypeDefIndex: 5946
		{
			Ignore = 1,
			Redirect = 2,
			NewBrowser = 3,
			NewWindow = 4
		}
	
		public delegate void JSCallback(JSONNode args); // TypeDefIndex: 5947; 0x0000000186F85DA0-0x0000000186F86000
	
		protected delegate void JSResultFunc(JSONNode value, bool isError); // TypeDefIndex: 5948; 0x0000000186F861A0-0x0000000186F86450
	
		// Constructors
		public Browser() {} // 0x0000000186F73740-0x0000000186F742A0
		static Browser() {} // 0x0000000186F735F0-0x0000000186F73740
	
		// Methods
		protected void Awake() {} // 0x0000000186F6B0B0-0x0000000186F6B430
		public void WhenReady(Action callback) {} // 0x0000000186F72DF0-0x0000000186F73050
		public void RunOnMainThread(Action callback) {} // 0x0000000186F70F20-0x0000000186F71010
		public void WhenLoaded(Action callback) {} // 0x0000000186F72D60-0x0000000186F72DF0
		internal void RequestNativeBrowser(int newBrowserId = 0 /* Metadata: 0x00ADBA33 */) {} // 0x0000000186F70140-0x0000000186F70BC0
		protected void OnItemChange(BrowserNative.ChangeType type, string arg1) {} // 0x0000000186F6EDA0-0x0000000186F6F430
		protected void CreateDialogHandler() {} // 0x0000000186F6CD40-0x0000000186F6CE50
		protected void CheckSanity() {} // 0x0000000186F6CC50-0x0000000186F6CD40
		internal bool DeferUnready(Action ifNotReady) => default; // 0x0000000186F6CE50-0x0000000186F6CEE0
		protected void OnDisable() {} // 0x0000000186F6ED50-0x0000000186F6EDA0
		protected void OnDestroy() {} // 0x0000000186F6EB40-0x0000000186F6ED50
		public void LoadURL(string url, bool force) {} // 0x0000000186F6E780-0x0000000186F6EA40
		public void LoadHTML(string html, string url = null) {} // 0x0000000186F6E500-0x0000000186F6E780
		public void SetNewWindowHandler(NewWindowAction action, INewWindowHandler newWindowHandler) {} // 0x0000000186F71180-0x0000000186F71490
		public void SendFrameCommand(BrowserNative.FrameCommand command) {} // 0x0000000186F71010-0x0000000186F71180
		public void QueuePageReplacer(Action replacePage, float priority) {} // 0x0000000186F6F860-0x0000000186F6F8F0
		public void GoBack() {} // 0x0000000186F6E040-0x0000000186F6E140
		public void GoForward() {} // 0x0000000186F6E140-0x0000000186F6E240
		public void Stop() {} // 0x0000000186F71A10-0x0000000186F71B10
		public void Reload(bool force = false /* Metadata: 0x00ADBA37 */) {} // 0x0000000186F6FC30-0x0000000186F6FD90
		public void ShowDevTools(bool show = true /* Metadata: 0x00ADBA38 */) {} // 0x0000000186F71890-0x0000000186F71A10
		protected void _Resize(Texture2D newTexture, bool newTextureIsOurs) {} // 0x0000000186F731F0-0x0000000186F735F0
		public void Resize(int width, int height) {} // 0x0000000186F70C70-0x0000000186F70F20
		public void Resize(Texture2D newTexture) {} // 0x0000000186F70BC0-0x0000000186F70C70
		public IPromise<JSONNode> EvalJS(string script, string scriptURL = "scripted command" /* Metadata: 0x00ADBA39 */) => default; // 0x0000000186F6D920-0x0000000186F6DE10
		public IPromise<JSONNode> EvalJSDirectly(string script, string scriptURL = "scripted command" /* Metadata: 0x00ADBA4D */) => default; // 0x0000000186F6D480-0x0000000186F6D920
		public IPromise<JSONNode> EvalJSCSP(string script, string scriptURL = "scripted command" /* Metadata: 0x00ADBA61 */) => default; // 0x0000000186F6CFC0-0x0000000186F6D480
		protected void _EvalJS(string script, string scriptURL) {} // 0x0000000186F73050-0x0000000186F73120
		public IPromise<JSONNode> CallFunction(string name, params /* 0x000000018989F6F0-0x000000018989F700 */ JSONNode[] arguments) => default; // 0x0000000186F6CA60-0x0000000186F6CC50
		public void RegisterFunction(string name, JSCallback callback) {} // 0x0000000186F6F8F0-0x0000000186F6FC30
		protected void ProcessCallbacks() {} // 0x0000000186F6F5D0-0x0000000186F6F860
		protected void Update() {} // 0x0000000186F72CB0-0x0000000186F72D60
		protected void LateUpdate() {} // 0x0000000186F6E310-0x0000000186F6E500
		protected void Render() {} // 0x0000000186F6FD90-0x0000000186F70140
		public void SetOverlay(Browser overlayBrowser) {} // 0x0000000186F71490-0x0000000186F71890
		protected void HandleInput() {} // 0x0000000186F6E240-0x0000000186F6E310
		protected void OnApplicationFocus(bool focus) {} // 0x0000000186F6EA40-0x0000000186F6EAC0
		protected void OnApplicationPause(bool paused) {} // 0x0000000186F6EAC0-0x0000000186F6EB40
		public void UpdateCursor() {} // 0x0000000186F728F0-0x0000000186F72CB0
		public void DownloadCommand(int downloadId, BrowserNative.DownloadAction action, string fileName = null) {} // 0x0000000186F6CEE0-0x0000000186F6CFC0
		public void TypeText(string text) {} // 0x0000000186F71B10-0x0000000186F71C40
		public void PressKey(KeyCode key, KeyAction action = KeyAction.PressAndRelease /* Metadata: 0x00ADBA75 */) {} // 0x0000000186F6F430-0x0000000186F6F5D0
		internal void _RaiseFocusEvent(bool mouseIsFocused, bool keyboardIsFocused) {} // 0x0000000186F73120-0x0000000186F731F0
		private static Browser GetBrowser(int browserId) => default; // 0x0000000186F6DE10-0x0000000186F6E040
		// [MonoPInvokeCallback] // 0x000000018977F8C0-0x000000018977F910
		private static void CB_ForwardJSCallFunc(int browserId, int callbackId, string data, int size) {} // 0x0000000186F6BEE0-0x0000000186F6C110
		// [MonoPInvokeCallback] // 0x000000018978BA90-0x000000018978BAE0
		private static void CB_ChangeFunc(int browserId, BrowserNative.ChangeType changeType, string arg1) {} // 0x0000000186F6B430-0x0000000186F6BA50
		// [MonoPInvokeCallback] // 0x0000000189797940-0x0000000189797990
		private static void CB_DisplayDialogFunc(int browserId, BrowserNative.DialogType dialogType, IntPtr textPtr, IntPtr promptTextPtr, IntPtr sourceURL) {} // 0x0000000186F6BC90-0x0000000186F6BEE0
		// [MonoPInvokeCallback] // 0x00000001897A3D10-0x00000001897A3D60
		private static void CB_ShowContextMenuFunc(int browserId, string json, int x, int y, BrowserNative.ContextMenuOrigin origin) {} // 0x0000000186F6C7B0-0x0000000186F6CA60
		// [MonoPInvokeCallback] // 0x00000001897AFE70-0x00000001897AFEC0
		private static void CB_ConsoleFunc(int browserId, string message, string source, int line) {} // 0x0000000186F6BA50-0x0000000186F6BC90
		// [MonoPInvokeCallback] // 0x00000001897BCA60-0x00000001897BCAB0
		private static void CB_ReadyFunc(int browserId) {} // 0x0000000186F6C590-0x0000000186F6C7B0
		// [MonoPInvokeCallback] // 0x00000001897C8B90-0x00000001897C8BE0
		private static void CB_NavStateFunc(int browserId, bool canGoBack, bool canGoForward, bool lodaing, IntPtr urlRaw) {} // 0x0000000186F6C110-0x0000000186F6C360
		// [MonoPInvokeCallback] // 0x00000001897D47F0-0x00000001897D4840
		private static void CB_NewWindowFunc(int creatorBrowserId, int newBrowserId, IntPtr urlPtr) {} // 0x0000000186F6C360-0x0000000186F6C590
	}
}
