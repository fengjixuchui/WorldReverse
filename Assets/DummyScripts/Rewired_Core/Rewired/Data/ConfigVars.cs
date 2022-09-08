/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired;
using Rewired.Config;
using Rewired.Platforms;
using Rewired.Utils.Attributes;

// Image 39: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3466-4436

namespace Rewired.Data
{
	[Serializable]
	[CustomClassObfuscation] // 0x0000000189B09F50-0x0000000189B09F80
	public sealed class ConfigVars // TypeDefIndex: 3745
	{
		// Fields
		public UpdateLoopSetting updateLoop; // 0x10
		public bool alwaysUseUnityInput; // 0x14
		public WindowsStandalonePrimaryInputSource windowsStandalonePrimaryInputSource; // 0x18
		public OSXStandalonePrimaryInputSource osx_primaryInputSource; // 0x1C
		public LinuxStandalonePrimaryInputSource linux_primaryInputSource; // 0x20
		public WindowsUWPPrimaryInputSource windowsUWP_primaryInputSource; // 0x24
		public XboxOnePrimaryInputSource xboxOne_primaryInputSource; // 0x28
		public PS4PrimaryInputSource ps4_primaryInputSource; // 0x2C
		public WebGLPrimaryInputSource webGL_primaryInputSource; // 0x30
		public bool useXInput; // 0x34
		public bool useNativeMouse; // 0x35
		public bool useEnhancedDeviceSupport; // 0x36
		public bool windowsStandalone_useSteamRawInputControllerWorkaround; // 0x37
		public bool osxStandalone_useEnhancedDeviceSupport; // 0x38
		public bool android_supportUnknownGamepads; // 0x39
		public bool ps4_assignJoysticksByPS4JoyId; // 0x3A
		public bool useSteamControllerSupport; // 0x3B
		public bool logToScreen; // 0x3C
		public bool runInEditMode; // 0x3D
		public bool allowInputInEditorSceneView; // 0x3E
		public PlatformVars_WindowsStandalone platformVars_windowsStandalone; // 0x40
		public PlatformVars platformVars_linuxStandalone; // 0x48
		public PlatformVars platformVars_osxStandalone; // 0x50
		public PlatformVars platformVars_windows8Store; // 0x58
		public PlatformVars_WindowsUWP platformVars_windowsUWP; // 0x60
		public PlatformVars platformVars_iOS; // 0x68
		public PlatformVars platformVars_tvOS; // 0x70
		public PlatformVars platformVars_android; // 0x78
		public PlatformVars platformVars_ps3; // 0x80
		public PlatformVars platformVars_ps4; // 0x88
		public PlatformVars platformVars_psVita; // 0x90
		public PlatformVars platformVars_xbox360; // 0x98
		public PlatformVars platformVars_xboxOne; // 0xA0
		public PlatformVars platformVars_wii; // 0xA8
		public PlatformVars platformVars_wiiu; // 0xB0
		public PlatformVars platformVars_switch; // 0xB8
		public PlatformVars platformVars_webGL; // 0xC0
		[NonSerialized]
		private PlatformVars platformVars_unknown; // 0xC8
		public int maxJoysticksPerPlayer; // 0xD0
		public bool autoAssignJoysticks; // 0xD4
		public bool assignJoysticksToPlayingPlayersOnly; // 0xD5
		public bool distributeJoysticksEvenly; // 0xD6
		public bool reassignJoystickToPreviousOwnerOnReconnect; // 0xD7
		public DeadZone2DType defaultJoystickAxis2DDeadZoneType; // 0xD8
		public AxisSensitivity2DType defaultJoystickAxis2DSensitivityType; // 0xDC
		public AxisSensitivityType defaultAxisSensitivityType; // 0xE0
		public bool force4WayHats; // 0xE4
		public ThrottleCalibrationMode throttleCalibrationMode; // 0xE8
		public bool activateActionButtonsOnNegativeValue; // 0xEC
		public bool deferControllerConnectedEventsOnStart; // 0xED
		public LogLevelFlags logLevel; // 0xF0
		public EditorVars editorSettings; // 0xF8
		private Dictionary<int, nCQERGUrzcrcyKjDMmlzeJjQfyN> __platformVarsDict; // 0x100
		private Dictionary<int, sPUadDDBOnDoEeXIZkMHqFZyoRC> __getSetPlatformVariableDict; // 0x108
	
		// Properties
		private Dictionary<int, nCQERGUrzcrcyKjDMmlzeJjQfyN> platformVarsDict { get => default; } // 0x0000000185D57210-0x0000000185D57A50 
	
		// Nested types
		[Serializable]
		public class PlatformVars // TypeDefIndex: 3746
		{
			// Fields
			public bool disableKeyboard; // 0x10
			public bool ignoreInputWhenAppNotInFocus; // 0x11
	
			// Constructors
			public PlatformVars() {} // 0x0000000185D6B590-0x0000000185D6B600
		}
	
		[Serializable]
		public class PlatformVars_WindowsStandalone : PlatformVars // TypeDefIndex: 3747
		{
			// Fields
			public bool useNativeKeyboard; // 0x18
			public int joystickRefreshRate; // 0x1C
	
			// Constructors
			public PlatformVars_WindowsStandalone() {} // 0x0000000185D6B430-0x0000000185D6B4E0
		}
	
		[Serializable]
		public class PlatformVars_WindowsUWP : PlatformVars // TypeDefIndex: 3748
		{
			// Fields
			public bool useGamepadAPI; // 0x18
			public bool useHIDAPI; // 0x19
	
			// Constructors
			public PlatformVars_WindowsUWP() {} // 0x0000000185D6B4E0-0x0000000185D6B590
		}
	
		[Serializable]
		public sealed class EditorVars // TypeDefIndex: 3749
		{
			// Fields
			public bool exportConsts_useParentClass; // 0x10
			public string exportConsts_parentClassName; // 0x18
			public bool exportConsts_useNamespace; // 0x20
			public string exportConsts_namespace; // 0x28
			public bool exportConsts_actions; // 0x30
			public string exportConsts_actionsClassName; // 0x38
			public bool exportConsts_actionsIncludeActionCategory; // 0x40
			public bool exportConsts_actionsCreateClassesForActionCategories; // 0x41
			public bool exportConsts_mapCategories; // 0x42
			public string exportConsts_mapCategoriesClassName; // 0x48
			public bool exportConsts_layouts; // 0x50
			public string exportConsts_layoutsClassName; // 0x58
			public bool exportConsts_players; // 0x60
			public string exportConsts_playersClassName; // 0x68
			public bool exportConsts_inputBehaviors; // 0x70
			public string exportConsts_inputBehaviorsClassName; // 0x78
			public bool exportConsts_customControllers; // 0x80
			public string exportConsts_customControllersClassName; // 0x88
			public string exportConsts_customControllersAxesClassName; // 0x90
			public string exportConsts_customControllersButtonsClassName; // 0x98
			public bool exportConsts_layoutManagerRuleSets; // 0xA0
			public string exportConsts_layoutManagerRuleSetsClassName; // 0xA8
			public bool exportConsts_mapEnablerRuleSets; // 0xB0
			public string exportConsts_mapEnablerRuleSetsClassName; // 0xB8
			public bool exportConsts_allCapsConstantNames; // 0xC0
	
			// Constructors
			public EditorVars() {} // 0x0000000185D6A8E0-0x0000000185D6AA00
		}
	
		private class nCQERGUrzcrcyKjDMmlzeJjQfyN // TypeDefIndex: 3750
		{
			// Fields
			public Func<PlatformVars> pekIqGKewZQlfVvmIEPZUQHzyKP; // 0x10
			public string HskGFjQUrrVkhvDfnvNgTepSgyQ; // 0x18
	
			// Constructors
			public nCQERGUrzcrcyKjDMmlzeJjQfyN() {} // Dummy constructor
			public nCQERGUrzcrcyKjDMmlzeJjQfyN(Func<PlatformVars> getDelegate, string dataPath) {} // 0x0000000185D769E0-0x0000000185D76A70
		}
	
		private class sPUadDDBOnDoEeXIZkMHqFZyoRC // TypeDefIndex: 3751
		{
			// Fields
			public Func<Platform, object> pekIqGKewZQlfVvmIEPZUQHzyKP; // 0x10
			public Action<Platform, object> pLJrcGqhmHayIxGgHvEIFaxfmKD; // 0x18
	
			// Constructors
			public sPUadDDBOnDoEeXIZkMHqFZyoRC() {} // Dummy constructor
		}
	
		// Constructors
		[Preserve] // 0x0000000189803330-0x0000000189803340
		public ConfigVars() {} // 0x0000000185D57160-0x0000000185D57210
	
		// Methods
		internal bool DoesPlatformUseFallback(Platform platform, WebplayerPlatform webplayerPlatform, bool isEditor) => default; // 0x0000000185D54710-0x0000000185D54890
		internal bool DoesPlatformUseSDL2(Platform platform, WebplayerPlatform webplayerPlatform, bool isEditor) => default; // 0x0000000185D54890-0x0000000185D54980
		internal string GetDebugConfigSettings() => default; // 0x0000000185D54980-0x0000000185D56090
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		internal PlatformVars GetPlatformVars(Platform platform) => default; // 0x0000000185D56590-0x0000000185D566E0
		internal bool GetPlatformVar_disableKeyboard() => default; // 0x0000000185D56090-0x0000000185D56110
		internal bool GetPlatformVar_ignoreInputWhenAppNotInFocus() => default; // 0x0000000185D56110-0x0000000185D56190
		internal bool GetPlatformVar_useNativeMouse() => default; // 0x0000000185D563C0-0x0000000185D56470
		internal bool GetPlatformVar_useNativeKeyboard() => default; // 0x0000000185D562A0-0x0000000185D563C0
		internal int GetPlatformVar_joystickRefreshRate() => default; // 0x0000000185D56190-0x0000000185D562A0
		private PlatformVars GetPlatformVars() => default; // 0x0000000185D56470-0x0000000185D56590
		private T GetOrCreatePlatformVars<T>(ref T var)
			where T : PlatformVars, new() => default;
		internal bool IsEditModeInputSupported(ControllerType controllerType, EditorPlatform editorPlatform) => default; // 0x0000000185D566E0-0x0000000185D56870
	}
}
