/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AOT;

// Image 52: ZFBrowser.dll - Assembly: ZFBrowser, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5943-6607

namespace ZenFulcrum.EmbeddedBrowser
{
	public static class BrowserNative // TypeDefIndex: 5977
	{
		// Fields
		public const int DebugPort = 9849; // Metadata: 0x00ADBA8D
		public static readonly object symbolsLock; // 0x08
		public const bool UsingAPIProxy = true; // Metadata: 0x00ADBA91
		public static List<string> commandLineSwitches; // 0x10
		public static WebResources webResources; // 0x18
		private static bool isAppDomainUnloading; // 0x20
		private static string _profilePath; // 0x28
		private static IntPtr moduleHandle; // 0x30
		public static Calltype_zfb_noop zfb_noop; // 0x38
		public static Calltype_zfb_flatColorTexture zfb_flatColorTexture; // 0x40
		public static Calltype_zfb_copyToColor32 zfb_copyToColor32; // 0x48
		public static Calltype_zfb_free zfb_free; // 0x50
		public static Calltype_zfb_memcpy zfb_memcpy; // 0x58
		public static Calltype_zfb_getVersion zfb_getVersion; // 0x60
		public static Calltype_zfb_setDebugFunc zfb_setDebugFunc; // 0x68
		public static Calltype_zfb_setLocalRequestHandler zfb_setLocalRequestHandler; // 0x70
		public static Calltype_zfb_sendRequestHeaders zfb_sendRequestHeaders; // 0x78
		public static Calltype_zfb_sendRequestData zfb_sendRequestData; // 0x80
		public static Calltype_zfb_setCallbacksEnabled zfb_setCallbacksEnabled; // 0x88
		public static Calltype_zfb_destroyAllBrowsers zfb_destroyAllBrowsers; // 0x90
		public static Calltype_zfb_addCLISwitch zfb_addCLISwitch; // 0x98
		public static Calltype_zfb_init zfb_init; // 0xA0
		public static Calltype_zfb_shutdown zfb_shutdown; // 0xA8
		public static Calltype_zfb_createBrowser zfb_createBrowser; // 0xB0
		public static Calltype_zfb_numBrowsers zfb_numBrowsers; // 0xB8
		public static Calltype_zfb_destroyBrowser zfb_destroyBrowser; // 0xC0
		public static Calltype_zfb_tick zfb_tick; // 0xC8
		public static Calltype_zfb_setReadyCallback zfb_setReadyCallback; // 0xD0
		public static Calltype_zfb_resize zfb_resize; // 0xD8
		public static Calltype_zfb_setOverlay zfb_setOverlay; // 0xE0
		public static Calltype_zfb_getImage zfb_getImage; // 0xE8
		public static Calltype_zfb_registerNavStateCallback zfb_registerNavStateCallback; // 0xF0
		public static Calltype_zfb_goToURL zfb_goToURL; // 0xF8
		public static Calltype_zfb_goToHTML zfb_goToHTML; // 0x100
		public static Calltype_zfb_doNav zfb_doNav; // 0x108
		public static Calltype_zfb_setZoom zfb_setZoom; // 0x110
		public static Calltype_zfb_changeLoading zfb_changeLoading; // 0x118
		public static Calltype_zfb_showDevTools zfb_showDevTools; // 0x120
		public static Calltype_zfb_setFocused zfb_setFocused; // 0x128
		public static Calltype_zfb_mouseMove zfb_mouseMove; // 0x130
		public static Calltype_zfb_mouseButton zfb_mouseButton; // 0x138
		public static Calltype_zfb_mouseScroll zfb_mouseScroll; // 0x140
		public static Calltype_zfb_keyEvent zfb_keyEvent; // 0x148
		public static Calltype_zfb_characterEvent zfb_characterEvent; // 0x150
		public static Calltype_zfb_registerConsoleCallback zfb_registerConsoleCallback; // 0x158
		public static Calltype_zfb_evalJS zfb_evalJS; // 0x160
		public static Calltype_zfb_registerJSCallback zfb_registerJSCallback; // 0x168
		public static Calltype_zfb_registerChangeCallback zfb_registerChangeCallback; // 0x170
		public static Calltype_zfb_getMouseCursor zfb_getMouseCursor; // 0x178
		public static Calltype_zfb_getMouseCustomCursor zfb_getMouseCustomCursor; // 0x180
		public static Calltype_zfb_registerDialogCallback zfb_registerDialogCallback; // 0x188
		public static Calltype_zfb_sendDialogResults zfb_sendDialogResults; // 0x190
		public static Calltype_zfb_registerPopupCallback zfb_registerPopupCallback; // 0x198
		public static Calltype_zfb_registerContextMenuCallback zfb_registerContextMenuCallback; // 0x1A0
		public static Calltype_zfb_sendContextMenuResults zfb_sendContextMenuResults; // 0x1A8
		public static Calltype_zfb_sendCommandToFocusedFrame zfb_sendCommandToFocusedFrame; // 0x1B0
		public static Calltype_zfb_getCookies zfb_getCookies; // 0x1B8
		public static Calltype_zfb_editCookie zfb_editCookie; // 0x1C0
		public static Calltype_zfb_clearCookies zfb_clearCookies; // 0x1C8
		public static Calltype_zfb_downloadCommand zfb_downloadCommand; // 0x1D0
	
		// Properties
		public static bool NativeLoaded { get; private set; } // 0x0000000186F6AB10-0x0000000186F6ABA0 0x0000000186F6ACC0-0x0000000186F6AD50
		public static bool SymbolsLoaded { get; private set; } // 0x0000000186F6AC30-0x0000000186F6ACC0 0x0000000186F6AE40-0x0000000186F6AED0
		public static string LocalUrlPrefix { get; } // 0x0000000186F6AAB0-0x0000000186F6AB10 
		public static string ProfilePath { get; set; } // 0x0000000186F6ABA0-0x0000000186F6AC30 0x0000000186F6AD50-0x0000000186F6AE40
	
		// Nested types
		// [UnmanagedFunctionPointer] // 0x000000018987C730-0x000000018987C750
		public delegate void MessageFunc(string message); // TypeDefIndex: 5978; 0x0000000186F865E0-0x0000000186F86840
	
		// [UnmanagedFunctionPointer] // 0x000000018987C730-0x000000018987C750
		public delegate void NewRequestFunc(int requestId, string url); // TypeDefIndex: 5979; 0x0000000186F87080-0x0000000186F87240
	
		// [UnmanagedFunctionPointer] // 0x000000018987C730-0x000000018987C750
		public delegate void ReadyFunc(int browserId); // TypeDefIndex: 5980; 0x0000000186F87770-0x0000000186F87900
	
		// [UnmanagedFunctionPointer] // 0x000000018987C730-0x000000018987C750
		public delegate void ConsoleFunc(int browserId, string message, string source, int line); // TypeDefIndex: 5981; 0x0000000186F841F0-0x0000000186F84430
	
		// [UnmanagedFunctionPointer] // 0x000000018987C730-0x000000018987C750
		public delegate void ForwardJSCallFunc(int browserId, int callbackId, string data, int size); // TypeDefIndex: 5982; 0x0000000186F855E0-0x0000000186F85820
	
		// [UnmanagedFunctionPointer] // 0x000000018987C730-0x000000018987C750
		public delegate void NewWindowFunc(int creatorBrowserId, int newBrowserId, IntPtr initialURL); // TypeDefIndex: 5983; 0x0000000186F87410-0x0000000186F875E0
	
		// [UnmanagedFunctionPointer] // 0x000000018987C730-0x000000018987C750
		public delegate void ChangeFunc(int browserId, ChangeType changeType, string arg1); // TypeDefIndex: 5984; 0x0000000186F82710-0x0000000186F828E0
	
		// [UnmanagedFunctionPointer] // 0x000000018987C730-0x000000018987C750
		public delegate void DisplayDialogFunc(int browserId, DialogType dialogType, IntPtr dialogText, IntPtr initialPromptText, IntPtr sourceURL); // TypeDefIndex: 5985; 0x0000000186F85170-0x0000000186F85400
	
		// [UnmanagedFunctionPointer] // 0x000000018987C730-0x000000018987C750
		public delegate void ShowContextMenuFunc(int browserId, string menuJSON, int x, int y, ContextMenuOrigin origin); // TypeDefIndex: 5986; 0x0000000186F88100-0x0000000186F88370
	
		// [UnmanagedFunctionPointer] // 0x000000018987C730-0x000000018987C750
		public delegate void GetCookieFunc(NativeCookie cookie); // TypeDefIndex: 5987; 0x0000000186F859B0-0x0000000186F85C10
	
		// [UnmanagedFunctionPointer] // 0x000000018987C730-0x000000018987C750
		public delegate void NavStateFunc(int browserId, bool canGoBack, bool canGoForward, bool lodaing, IntPtr url); // TypeDefIndex: 5988; 0x0000000186F86C50-0x0000000186F86EE0
	
		// [UnmanagedFunctionPointer] // 0x000000018987C730-0x000000018987C750
		public delegate void WindowCallbackFunc(int windowId, IntPtr data); // TypeDefIndex: 5989; 0x0000000186F8A570-0x0000000186F8A730
	
		public enum LoadChange // TypeDefIndex: 5990
		{
			LC_STOP = 1,
			LC_RELOAD = 2,
			LC_FORCE_RELOAD = 3
		}
	
		public enum MouseButton // TypeDefIndex: 5991
		{
			MBT_LEFT = 0,
			MBT_MIDDLE = 1,
			MBT_RIGHT = 2
		}
	
		public enum ChangeType // TypeDefIndex: 5992
		{
			CHT_CURSOR = 0,
			CHT_BROWSER_CLOSE = 1,
			CHT_FETCH_FINISHED = 2,
			CHT_FETCH_FAILED = 3,
			CHT_LOAD_FINISHED = 4,
			CHT_CERT_ERROR = 5,
			CHT_SAD_TAB = 6,
			CHT_DOWNLOAD_STARTED = 7,
			CHT_DOWNLOAD_STATUS = 8,
			CHT_FOCUSED_NODE = 9,
			CHT_GET_UNIWEBVIEW_MSG = 10
		}
	
		public enum DownloadAction // TypeDefIndex: 5993
		{
			Begin = 0,
			Cancel = 1,
			Pause = 2,
			Resume = 3
		}
	
		public enum CursorType // TypeDefIndex: 5994
		{
			Pointer = 0,
			Cross = 1,
			Hand = 2,
			IBeam = 3,
			Wait = 4,
			Help = 5,
			EastResize = 6,
			NorthResize = 7,
			NorthEastResize = 8,
			NorthWestResize = 9,
			SouthResize = 10,
			SouthEastResize = 11,
			SouthWestResize = 12,
			WestResize = 13,
			NorthSouthResize = 14,
			EastWestResize = 15,
			NorthEastSouthWestResize = 16,
			NorthWestSouthEastResize = 17,
			ColumnResize = 18,
			RowResize = 19,
			MiddlePanning = 20,
			EastPanning = 21,
			NorthPanning = 22,
			NorthEastPanning = 23,
			NorthWestPanning = 24,
			SouthPanning = 25,
			SouthEastPanning = 26,
			SouthWestPanning = 27,
			WestPanning = 28,
			Move = 29,
			VerticalText = 30,
			Cell = 31,
			ContextMenu = 32,
			Alias = 33,
			Progress = 34,
			NoDrop = 35,
			Copy = 36,
			None = 37,
			NotAllowed = 38,
			ZoomIn = 39,
			ZoomOut = 40,
			Grab = 41,
			Grabbing = 42,
			Custom = 43
		}
	
		public enum DialogType // TypeDefIndex: 5995
		{
			DLT_HIDE = 0,
			DLT_ALERT = 1,
			DLT_CONFIRM = 2,
			DLT_PROMPT = 3,
			DLT_PAGE_UNLOAD = 4,
			DLT_PAGE_RELOAD = 5,
			DLT_GET_AUTH = 6
		}
	
		public enum NewWindowAction // TypeDefIndex: 5996
		{
			NWA_IGNORE = 1,
			NWA_REDIRECT = 2,
			NWA_NEW_BROWSER = 3,
			NWA_NEW_WINDOW = 4
		}
	
		[Flags] // 0x000000018990A800-0x000000018990A810
		public enum ContextMenuOrigin // TypeDefIndex: 5997
		{
			Other = 1,
			Editable = 2,
			Image = 4,
			Selection = 8
		}
	
		public enum FrameCommand // TypeDefIndex: 5998
		{
			Undo = 0,
			Redo = 1,
			Cut = 2,
			Copy = 3,
			Paste = 4,
			Delete = 5,
			SelectAll = 6,
			ViewSource = 7
		}
	
		public enum CookieAction // TypeDefIndex: 5999
		{
			Delete = 0,
			Create = 1
		}
	
		public struct ZFBInitialSettings // TypeDefIndex: 6000
		{
			// Fields
			public string cefPath; // 0x00
			public string localePath; // 0x08
			public string subprocessFile; // 0x10
			public string userAgent; // 0x18
			public string logFile; // 0x20
			public string profilePath; // 0x28
			public int debugPort; // 0x30
			public int multiThreadedMessageLoop; // 0x34
		}
	
		public struct ZFBSettings // TypeDefIndex: 6001
		{
			// Fields
			public int bgR; // 0x00
			public int bgG; // 0x04
			public int bgB; // 0x08
			public int bgA; // 0x0C
			public int offscreen; // 0x10
		}
	
		public struct RenderData // TypeDefIndex: 6002
		{
			// Fields
			public IntPtr pixels; // 0x00
			public int w; // 0x08
			public int h; // 0x0C
		}
	
		public class NativeCookie // TypeDefIndex: 6003
		{
			// Fields
			public string name; // 0x10
			public string value; // 0x18
			public string domain; // 0x20
			public string path; // 0x28
			public string creation; // 0x30
			public string lastAccess; // 0x38
			public string expires; // 0x40
			public byte secure; // 0x48
			public byte httpOnly; // 0x49
	
			// Constructors
			public NativeCookie() {} // 0x0000000186F868C0-0x0000000186F86AC0
		}
	
		public delegate void Calltype_zfb_noop(); // TypeDefIndex: 6004; 0x0000000186F7D0A0-0x0000000186F7D200
	
		public delegate IntPtr Calltype_zfb_flatColorTexture(int pixelCount, int r, int g, int b, int a); // TypeDefIndex: 6005; 0x0000000186F79770-0x0000000186F799E0
	
		public delegate void Calltype_zfb_copyToColor32(IntPtr src, IntPtr dest, int pixelCount); // TypeDefIndex: 6006; 0x0000000186F77AF0-0x0000000186F77CC0
	
		public delegate void Calltype_zfb_free(IntPtr mem); // TypeDefIndex: 6007; 0x0000000186F79B70-0x0000000186F79D00
	
		public delegate void Calltype_zfb_memcpy(IntPtr dst, IntPtr src, int size); // TypeDefIndex: 6008; 0x0000000186F7C1B0-0x0000000186F7C380
	
		public delegate IntPtr Calltype_zfb_getVersion(); // TypeDefIndex: 6009; 0x0000000186F7AF20-0x0000000186F7B090
	
		public delegate void Calltype_zfb_setDebugFunc(MessageFunc debugFunc); // TypeDefIndex: 6010; 0x0000000186F80820-0x0000000186F80A80
	
		public delegate void Calltype_zfb_setLocalRequestHandler(NewRequestFunc requestFunc); // TypeDefIndex: 6011; 0x0000000186F80F80-0x0000000186F811E0
	
		public delegate void Calltype_zfb_sendRequestHeaders(int requestId, int responseLength, string headersJSON); // TypeDefIndex: 6012; 0x0000000186F801A0-0x0000000186F80370
	
		public delegate void Calltype_zfb_sendRequestData(int requestId, IntPtr data, int dataSize); // TypeDefIndex: 6013; 0x0000000186F7FE10-0x0000000186F7FFE0
	
		public delegate void Calltype_zfb_setCallbacksEnabled(bool enabled); // TypeDefIndex: 6014; 0x0000000186F80500-0x0000000186F80690
	
		public delegate void Calltype_zfb_destroyAllBrowsers(); // TypeDefIndex: 6015; 0x0000000186F78220-0x0000000186F78380
	
		public delegate void Calltype_zfb_addCLISwitch(string value); // TypeDefIndex: 6016; 0x0000000186F76C90-0x0000000186F76EF0
	
		public delegate bool Calltype_zfb_init(ZFBInitialSettings settings); // TypeDefIndex: 6017; 0x0000000186F7B970-0x0000000186F7BC30
	
		public delegate void Calltype_zfb_shutdown(); // TypeDefIndex: 6018; 0x0000000186F82110-0x0000000186F82270
	
		public delegate int Calltype_zfb_createBrowser(ZFBSettings settings); // TypeDefIndex: 6019; 0x0000000186F77E80-0x0000000186F780A0
	
		public delegate int Calltype_zfb_numBrowsers(); // TypeDefIndex: 6020; 0x0000000186F7D3A0-0x0000000186F7D510
	
		public delegate void Calltype_zfb_destroyBrowser(int id); // TypeDefIndex: 6021; 0x0000000186F78510-0x0000000186F786A0
	
		public delegate void Calltype_zfb_tick(); // TypeDefIndex: 6022; 0x0000000186F823F0-0x0000000186F82550
	
		public delegate void Calltype_zfb_setReadyCallback(int id, ReadyFunc cb); // TypeDefIndex: 6023; 0x0000000186F816F0-0x0000000186F818B0
	
		public delegate void Calltype_zfb_resize(int id, int w, int h); // TypeDefIndex: 6024; 0x0000000186F7EF70-0x0000000186F7F140
	
		public delegate void Calltype_zfb_setOverlay(int browserId, int overlayBrowserId); // TypeDefIndex: 6025; 0x0000000186F81390-0x0000000186F81550
	
		public delegate RenderData Calltype_zfb_getImage(int id, bool forceDirty); // TypeDefIndex: 6026; 0x0000000186F7A240-0x0000000186F7A490
	
		public delegate void Calltype_zfb_registerNavStateCallback(int id, NavStateFunc callback); // TypeDefIndex: 6027; 0x0000000186F7E790-0x0000000186F7E950
	
		public delegate void Calltype_zfb_goToURL(int id, string url, bool force); // TypeDefIndex: 6028; 0x0000000186F7B5D0-0x0000000186F7B7B0
	
		public delegate void Calltype_zfb_goToHTML(int id, string html, string url); // TypeDefIndex: 6029; 0x0000000186F7B240-0x0000000186F7B410
	
		public delegate void Calltype_zfb_doNav(int id, int direction); // TypeDefIndex: 6030; 0x0000000186F78850-0x0000000186F78A10
	
		public delegate void Calltype_zfb_setZoom(int id, double zoom); // TypeDefIndex: 6031; 0x0000000186F81A60-0x0000000186F81C20
	
		public delegate void Calltype_zfb_changeLoading(int id, LoadChange what); // TypeDefIndex: 6032; 0x0000000186F770A0-0x0000000186F77260
	
		public delegate void Calltype_zfb_showDevTools(int id, bool show); // TypeDefIndex: 6033; 0x0000000186F81DD0-0x0000000186F81F90
	
		public delegate void Calltype_zfb_setFocused(int id, bool focused); // TypeDefIndex: 6034; 0x0000000186F80C30-0x0000000186F80DF0
	
		public delegate void Calltype_zfb_mouseMove(int id, float x, float y); // TypeDefIndex: 6035; 0x0000000186F7C980-0x0000000186F7CB80
	
		public delegate void Calltype_zfb_mouseButton(int id, MouseButton button, bool down, int clickCount); // TypeDefIndex: 6036; 0x0000000186F7C570-0x0000000186F7C7B0
	
		public delegate void Calltype_zfb_mouseScroll(int id, int deltaX, int deltaY); // TypeDefIndex: 6037; 0x0000000186F7CD50-0x0000000186F7CF20
	
		public delegate void Calltype_zfb_keyEvent(int id, bool down, int windowsKeyCode); // TypeDefIndex: 6038; 0x0000000186F7BE00-0x0000000186F7BFE0
	
		public delegate void Calltype_zfb_characterEvent(int id, int character, int windowsKeyCode); // TypeDefIndex: 6039; 0x0000000186F77430-0x0000000186F77600
	
		public delegate void Calltype_zfb_registerConsoleCallback(int id, ConsoleFunc callback); // TypeDefIndex: 6040; 0x0000000186F7DA10-0x0000000186F7DBD0
	
		public delegate void Calltype_zfb_evalJS(int id, string script, string scriptURL); // TypeDefIndex: 6041; 0x0000000186F79370-0x0000000186F79540
	
		public delegate void Calltype_zfb_registerJSCallback(int id, ForwardJSCallFunc cb); // TypeDefIndex: 6042; 0x0000000186F7E430-0x0000000186F7E5F0
	
		public delegate void Calltype_zfb_registerChangeCallback(int id, ChangeFunc cb); // TypeDefIndex: 6043; 0x0000000186F7D6B0-0x0000000186F7D870
	
		public delegate CursorType Calltype_zfb_getMouseCursor(int id, out int width, out int height); // TypeDefIndex: 6044; 0x0000000186F7A6A0-0x0000000186F7A880
	
		public delegate void Calltype_zfb_getMouseCustomCursor(int id, IntPtr buffer, int width, int height, out int hotX, out int hotY); // TypeDefIndex: 6045; 0x0000000186F7AAB0-0x0000000186F7AD80
	
		public delegate void Calltype_zfb_registerDialogCallback(int id, DisplayDialogFunc cb); // TypeDefIndex: 6046; 0x0000000186F7E0D0-0x0000000186F7E290
	
		public delegate void Calltype_zfb_sendDialogResults(int id, bool affirmed, string text1, string text2); // TypeDefIndex: 6047; 0x0000000186F7F9F0-0x0000000186F7FC40
	
		public delegate void Calltype_zfb_registerPopupCallback(int id, NewWindowAction windowAction, ZFBSettings baseSettings, NewWindowFunc cb); // TypeDefIndex: 6048; 0x0000000186F7EB30-0x0000000186F7EDA0
	
		public delegate void Calltype_zfb_registerContextMenuCallback(int id, ShowContextMenuFunc cb); // TypeDefIndex: 6049; 0x0000000186F7DD70-0x0000000186F7DF30
	
		public delegate void Calltype_zfb_sendContextMenuResults(int id, int commandId); // TypeDefIndex: 6050; 0x0000000186F7F660-0x0000000186F7F820
	
		public delegate void Calltype_zfb_sendCommandToFocusedFrame(int id, FrameCommand command); // TypeDefIndex: 6051; 0x0000000186F7F2F0-0x0000000186F7F4B0
	
		public delegate void Calltype_zfb_getCookies(int id, GetCookieFunc cb); // TypeDefIndex: 6052; 0x0000000186F79EA0-0x0000000186F7A060
	
		public delegate void Calltype_zfb_editCookie(int id, NativeCookie cookie, CookieAction action); // TypeDefIndex: 6053; 0x0000000186F78FF0-0x0000000186F791C0
	
		public delegate void Calltype_zfb_clearCookies(int id); // TypeDefIndex: 6054; 0x0000000186F77790-0x0000000186F77920
	
		public delegate void Calltype_zfb_downloadCommand(int id, int downloadId, DownloadAction command, string fileName); // TypeDefIndex: 6055; 0x0000000186F78BF0-0x0000000186F78E30
	
		// Constructors
		static BrowserNative() {} // 0x0000000186F6A970-0x0000000186F6AAB0
	
		// Methods
		// [MonoPInvokeCallback] // 0x00000001899EEA00-0x00000001899EEA50
		private static void LogCallback(string message) {} // 0x0000000186F6A3F0-0x0000000186F6A4B0
		public static void LoadSymbols() {} // 0x0000000186F6A2C0-0x0000000186F6A3F0
		public static void LoadNative() {} // 0x0000000186F69A30-0x0000000186F6A2C0
		private static void FixProcessPermissions(FileLocations.CEFDirs dirs) {} // 0x0000000186F69050-0x0000000186F690E0
		private static void HandLoadSymbols(string binariesPath) {} // 0x0000000186F69650-0x0000000186F69930
		private static void ClearSymbols() {} // 0x0000000186F68D10-0x0000000186F68E90
		private static string GetLibError() => default; // 0x0000000186F69470-0x0000000186F69540
		private static IntPtr OpenLib(string name) => default; // 0x0000000186F6A570-0x0000000186F6A710
		private static void CloseLib() {} // 0x0000000186F68E90-0x0000000186F69050
		private static IntPtr GetFunc(IntPtr libHandle, string fnName) => default; // 0x0000000186F691D0-0x0000000186F69470
		private static extern IntPtr LoadLibraryW(string lpFileName); // 0x0000000186F69930-0x0000000186F69A30
		private static extern IntPtr GetProcAddress(IntPtr hModule, string procName); // 0x0000000186F69540-0x0000000186F69650
		private static extern bool FreeLibrary(IntPtr hModule); // 0x0000000186F690E0-0x0000000186F691D0
		// [MonoPInvokeCallback] // 0x00000001899FABD0-0x00000001899FAC20
		private static void NewRequestCallback(int requestId, string url) {} // 0x0000000186F6A4B0-0x0000000186F6A570
		public static void UnloadNative() {} // 0x0000000186F6A7A0-0x0000000186F6A970
	}
}
