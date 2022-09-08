/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace Sony.PS4.Dialog
{
	public class Ime // TypeDefIndex: 9731
	{
		// Properties
		public static bool IsDialogOpen { /* [XID] */ /* 0x0000000189AA3000-0x0000000189AA3020 */ get => default; } // 0x000000018673B020-0x000000018673B0C0 
	
		// Events
		public static event Messages.EventHandler OnGotIMEDialogResult;
	
		// Nested types
		public enum EnterLabel // TypeDefIndex: 9732
		{
			DEFAULT = 0,
			SEND = 1,
			LABEL_SEARCH = 2,
			LABEL_GO = 3
		}
	
		public enum InputMethod // TypeDefIndex: 9733
		{
			DEFAULT = 0
		}
	
		public enum Type // TypeDefIndex: 9734
		{
			DEFAULT = 0,
			BASIC_LATIN = 1,
			URL = 2,
			MAIL = 3,
			NUMBER = 4
		}
	
		public enum HorizontalAlignment // TypeDefIndex: 9735
		{
			LEFT = 0,
			CENTER = 1,
			RIGHT = 2
		}
	
		public enum VerticalAlignment // TypeDefIndex: 9736
		{
			TOP = 0,
			CENTER = 1,
			BOTTOM = 2
		}
	
		public enum PanelPriority // TypeDefIndex: 9737
		{
			DEFAULT = 0,
			ALPHABET = 1,
			SYMBOL = 2,
			ACCENT = 3
		}
	
		[Flags] // 0x000000018990A800-0x000000018990A810
		public enum FlagsSupportedLanguages : long // TypeDefIndex: 9738
		{
			LANGUAGE_DANISH = 1,
			LANGUAGE_GERMAN = 2,
			LANGUAGE_ENGLISH_US = 4,
			LANGUAGE_SPANISH = 8,
			LANGUAGE_FRENCH = 16,
			LANGUAGE_ITALIAN = 32,
			LANGUAGE_DUTCH = 64,
			LANGUAGE_NORWEGIAN = 128,
			LANGUAGE_POLISH = 256,
			LANGUAGE_PORTUGUESE_PT = 512,
			LANGUAGE_RUSSIAN = 1024,
			LANGUAGE_FINNISH = 2048,
			LANGUAGE_SWEDISH = 4096,
			LANGUAGE_JAPANESE = 8192,
			LANGUAGE_KOREAN = 16384,
			LANGUAGE_SIMPLIFIED_CHINESE = 32768,
			LANGUAGE_TRADITIONAL_CHINESE = 65536,
			LANGUAGE_PORTUGUESE_BR = 131072,
			LANGUAGE_ENGLISH_GB = 262144,
			LANGUAGE_TURKISH = 524288,
			LANGUAGE_SPANISH_LA = 1048576
		}
	
		[Flags] // 0x000000018990A800-0x000000018990A810
		public enum Option // TypeDefIndex: 9739
		{
			DEFAULT = 0,
			MULTILINE = 1,
			NO_AUTO_CAPITALIZATION = 2,
			PASSWORD = 4,
			LANGUAGES_FORCED = 8,
			EXT_KEYBOARD = 16,
			NO_LEARNING = 32,
			FIXED_POSITION = 64,
			DISABLE_COPY_PASTE = 128,
			DISABLE_RESUME = 256,
			DISABLE_AUTO_SPACE = 512
		}
	
		[Flags] // 0x000000018990A800-0x000000018990A810
		public enum ExtOption // TypeDefIndex: 9740
		{
			DEFAULT = 0,
			SET_COLOR = 1,
			SET_PRIORITY = 2,
			PRIORITY_SHIFT = 4,
			PRIORITY_FULL_WIDTH = 8,
			PRIORITY_FIXED_PANEL = 16,
			DISABLE_POINTER = 64,
			ENABLE_ADDITIONAL_DICTIONARY = 128,
			DISABLE_STARTUP_SE = 256,
			DISABLE_LIST_FOR_EXT_KEYBOARD = 512,
			HIDE_KEYPANEL_IF_EXT_KEYBOARD = 1024,
			INIT_EXT_KEYBOARD_MODE = 2048,
			ENABLE_ACCESSIBILITY = 4096,
			ACCESSIBILITY_PANEL_FORCED = 8192
		}
	
		public class SceImeDialogParam // TypeDefIndex: 9741
		{
			// Fields
			public uint userId; // 0x10
			public Sony.PS4.Dialog.Ime.Type type; // 0x14
			public FlagsSupportedLanguages supportedLanguages; // 0x18
			public EnterLabel enterLabel; // 0x20
			public InputMethod inputMethod; // 0x24
			public IntPtr _filter; // 0x28
			public Option option; // 0x30
			public uint maxTextLength; // 0x34
			private IntPtr _inputTextBuffer; // 0x38
			public float posx; // 0x40
			public float posy; // 0x44
			public HorizontalAlignment horizontalAlignment; // 0x48
			public VerticalAlignment verticalAlignment; // 0x4C
			private IntPtr _placeholder; // 0x50
			private IntPtr _title; // 0x58
			private byte r0; // 0x60
			private byte r1; // 0x00
			private byte r2; // 0x00
			private byte r3; // 0x00
			private byte r4; // 0x00
			private byte r5; // 0x00
			private byte r6; // 0x00
			private byte r7; // 0x00
			private byte r8; // 0x00
			private byte r9; // 0x00
			private byte r10; // 0x00
			private byte r11; // 0x00
			private byte r12; // 0x00
			private byte r13; // 0x00
			private byte r14; // 0x00
			private byte r15; // 0x00
	
			// Properties
			public string title { /* [XID] */ /* 0x0000000189980B10-0x0000000189980B30 */ get => default; /* [XID] */ /* 0x0000000189988390-0x00000001899883B0 */ set {} } // 0x000000018674ED30-0x000000018674EE00 0x000000018674EFC0-0x000000018674F260
			public string inputTextBuffer { /* [XID] */ /* 0x000000018998FE00-0x000000018998FE20 */ get => default; /* [XID] */ /* 0x0000000189B6EE90-0x0000000189B6EEB0 */ set {} } // 0x000000018674EB90-0x000000018674EC60 0x000000018674EE00-0x000000018674EEE0
			public string placeholder { /* [XID] */ /* 0x0000000189619B30-0x0000000189619B50 */ get => default; /* [XID] */ /* 0x0000000189B94050-0x0000000189B94070 */ set {} } // 0x000000018674EC60-0x000000018674ED30 0x000000018674EEE0-0x000000018674EFC0
	
			// Constructors
			public SceImeDialogParam() {} // 0x000000018674EAF0-0x000000018674EB90
	
			// Methods
			~SceImeDialogParam() {} // 0x000000018674EA00-0x000000018674EAF0
		}
	
		public struct SceImeColor // TypeDefIndex: 9742
		{
			// Fields
			public byte r; // 0x00
			public byte g; // 0x01
			public byte b; // 0x02
			public byte a; // 0x03
		}
	
		public class SceImeParamExtended // TypeDefIndex: 9743
		{
			// Fields
			public ExtOption option; // 0x10
			public SceImeColor colorBase; // 0x14
			public SceImeColor colorLine; // 0x18
			public SceImeColor colorTextField; // 0x1C
			public SceImeColor colorPreedit; // 0x20
			public SceImeColor colorButtonDefault; // 0x24
			public SceImeColor colorButtonFunction; // 0x28
			public SceImeColor colorButtonSymbol; // 0x2C
			public SceImeColor colorText; // 0x30
			public SceImeColor colorSpecial; // 0x34
			public PanelPriority priority; // 0x38
			private uint padding; // 0x3C
			private IntPtr _additionalDictionaryPath; // 0x40
			public IntPtr _extKeyboardFilter; // 0x48
			public uint disableDevice; // 0x50
			public uint extKeyboardMode; // 0x54
	
			// Properties
			public string additionalDictionaryPath { /* [XID] */ /* 0x0000000189BA2D50-0x0000000189BA2D70 */ get => default; /* [XID] */ /* 0x00000001899B5B80-0x00000001899B5BA0 */ set {} } // 0x000000018674F3A0-0x000000018674F470 0x000000018674F470-0x000000018674F6C0
	
			// Constructors
			public SceImeParamExtended() {} // 0x000000018674F330-0x000000018674F3A0
	
			// Methods
			~SceImeParamExtended() {} // 0x000000018674F260-0x000000018674F330
		}
	
		public enum EnumImeDialogResult // TypeDefIndex: 9744
		{
			RESULT_OK = 0,
			RESULT_USER_CANCELED = 1,
			RESULT_ABORTED = 2
		}
	
		public enum EnumImeDialogResultButton // TypeDefIndex: 9745
		{
			BUTTON_NONE = 0,
			BUTTON_CLOSE = 1,
			BUTTON_ENTER = 2
		}
	
		public struct ImeDialogResult // TypeDefIndex: 9746
		{
			// Fields
			public EnumImeDialogResult result; // 0x00
			public EnumImeDialogResultButton button; // 0x04
			private IntPtr _text; // 0x08
	
			// Properties
			public string text { /* [XID] */ /* 0x00000001896364A0-0x00000001896364C0 */ get => default; } // 0x000000018673A1C0-0x000000018673A1D0 
		}
	
		// Constructors
		public Ime() {} // 0x000000018673AEA0-0x000000018673AF00
	
		// Methods
		private static extern int PrxImeDialogInitialise(); // 0x000000018673A8A0-0x000000018673A980
		private static extern void PrxImeDialogUpdate(); // 0x000000018673AD20-0x000000018673AE00
		private static extern bool PrxImeDialogIsDialogOpen(); // 0x000000018673A980-0x000000018673AA60
		private static extern bool PrxImeDialogOpen(SceImeDialogParam parameters, SceImeParamExtended extended); // 0x000000018673AA60-0x000000018673AD20
		private static extern bool PrxImeDialogGetResult(out ImeDialogResult result); // 0x000000018673A7A0-0x000000018673A8A0
		private static extern bool PrxCommonDialogHasMessage(); // 0x000000018673A5E0-0x000000018673A6C0
		private static extern bool PrxCommonDialogGetFirstMessage(out Messages.PluginMessage msg); // 0x000000018673A4E0-0x000000018673A5E0
		private static extern bool PrxCommonDialogRemoveFirstMessage(); // 0x000000018673A6C0-0x000000018673A7A0
		// [XID] // 0x0000000189944D30-0x0000000189944D50
		public static bool Open(SceImeDialogParam Imeparams, SceImeParamExtended extended) => default; // 0x000000018673A340-0x000000018673A400
		// [XID] // 0x000000018994C410-0x000000018994C430
		public static ImeDialogResult GetResult() => default; // 0x000000018673A1D0-0x000000018673A2A0
		// [XID] // 0x0000000189953A60-0x0000000189953A80
		public static void ProcessMessage(Messages.PluginMessage msg) {} // 0x000000018673A400-0x000000018673A4E0
		// [XID] // 0x0000000189B3A980-0x0000000189B3A9A0
		public static void Initialise() {} // 0x000000018673A2A0-0x000000018673A340
		// [XID] // 0x0000000189962F60-0x0000000189962F80
		public static void Update() {} // 0x000000018673AE00-0x000000018673AEA0
	}
}
