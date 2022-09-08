/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired.Config;
using Rewired.Data;
using Rewired.Platforms;
using Rewired.Utils.Interfaces;
using UnityEngine;

// Image 39: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3466-4436

namespace Rewired
{
	// [AddComponentMenu] // 0x000000018984EFF0-0x000000018984F060
	// [Browsable] // 0x000000018984EFF0-0x000000018984F060
	// [EditorBrowsable] // 0x000000018984EFF0-0x000000018984F060
	[ExecuteInEditMode] // 0x000000018984EFF0-0x000000018984F060
	public abstract class InputManager_Base : MonoBehaviour // TypeDefIndex: 4059
	{
		// Fields
		[CustomObfuscation] // 0x0000000189748BB0-0x0000000189748BF0
		[SerializeField] // 0x0000000189748BB0-0x0000000189748BF0
		private bool _dontDestroyOnLoad; // 0x18
		[CustomObfuscation] // 0x0000000189748BB0-0x0000000189748BF0
		[SerializeField] // 0x0000000189748BB0-0x0000000189748BF0
		private UserData _userData; // 0x20
		[CustomObfuscation] // 0x00000001898227C0-0x0000000189822800
		[SerializeField] // 0x00000001898227C0-0x0000000189822800
		private ControllerDataFiles _controllerDataFiles; // 0x28
		protected bool isCompiling; // 0x30
		[NonSerialized]
		private bool initialized; // 0x31
		[NonSerialized]
		private bool criticalError; // 0x32
		[NonSerialized]
		protected EditorPlatform editorPlatform; // 0x34
		[NonSerialized]
		protected Platform platform; // 0x38
		[NonSerialized]
		protected WebplayerPlatform webplayerPlatform; // 0x3C
		[NonSerialized]
		protected bool isEditor; // 0x40
		[NonSerialized]
		protected bool _detectedPlatformInEditor; // 0x41
		[NonSerialized]
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		protected ScriptingBackend scriptingBackend; // 0x44
		[NonSerialized]
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		protected ScriptingAPILevel scriptingAPILevel; // 0x48
		[NonSerialized]
		private bool _duplicateRIMError; // 0x4C
		private bool _isAwake; // 0x4D
	
		// Properties
		public UserData userData { get; internal set; } // 0x000000018583A0D0-0x000000018583A130 0x000000018583A2B0-0x000000018583A310
		public ControllerDataFiles dataFiles { get; } // 0x0000000185839F00-0x0000000185839F60 
		public bool runInEditMode { get; set; } // 0x000000018583A050-0x000000018583A0D0 0x000000018583A130-0x000000018583A2B0
		internal bool isRunningInEditMode { get; } // 0x0000000185839F60-0x000000018583A050 
	
		// Nested types
		private enum ExceptionPoint // TypeDefIndex: 4060
		{
			Initialization = 0,
			Update = 1,
			Destroy = 2
		}
	
		// Constructors
		protected InputManager_Base() {} // 0x0000000185839E60-0x0000000185839F00
	
		// Methods
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		private void Awake() {} // 0x0000000185836F90-0x0000000185837060
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		private void OnEnable() {} // 0x0000000185838F40-0x0000000185839060
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		private void OnDisable() {} // 0x0000000185838E80-0x0000000185838F40
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		private void OnDestroy() {} // 0x0000000185838D50-0x0000000185838E80
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		private void OnApplicationFocus(bool isFocused) {} // 0x0000000185838CB0-0x0000000185838D50
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		private void Start() {} // 0x0000000185839540-0x0000000185839680
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		private void Update() {} // 0x0000000185839D40-0x0000000185839E60
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		private void FixedUpdate() {} // 0x00000001858372D0-0x00000001858373F0
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		private void LateUpdate() {} // 0x0000000185838A90-0x0000000185838BF0
		internal void OnGUIUpdate() {} // 0x0000000185839060-0x0000000185839150
		internal void DoUpdate(UpdateLoopType updateLoopType, UpdateLoopSetting updateLoopSettingBit) {} // 0x00000001858370E0-0x00000001858372D0
		internal void TryStartRunInEditMode() {} // 0x0000000185839680-0x0000000185839B90
		internal void TryStopRunInEditMode() {} // 0x0000000185839B90-0x0000000185839C50
		private bool ManualInitialize() => default; // 0x0000000185838BF0-0x0000000185838CB0
		private void Initialize() {} // 0x00000001858381A0-0x0000000185838740
		private object InitializePlatform(ConfigVars configVars) => default; // 0x0000000185838080-0x00000001858381A0
		private List<Assembly> GetNativeAssembliesFromResources() => default; // 0x0000000185837790-0x0000000185837A30
		private List<Assembly> GetNativeAssembliesByReflection() => default; // 0x00000001858374A0-0x0000000185837790
		private byte[] GetNativeDLLBytesByReflection() => default; // 0x0000000185837A30-0x0000000185837C20
		private void AddTextAssetInResourcesToList(List<TextAsset> list, List<string> dllPaths) {} // 0x0000000185836CB0-0x0000000185836F90
		private string SetPlatformToEditorPlatform() => default; // 0x00000001858393C0-0x0000000185839540
		private bool CheckEditorPlatformMatches() => default; // 0x0000000185837060-0x00000001858370E0
		private string GetPlatformSpecificAssemblyName() => default; // 0x0000000185837C20-0x0000000185837D60
		private bool IsOnlyManagerInScene() => default; // 0x0000000185838980-0x0000000185838A90
		protected void RecompileStart() {} // 0x00000001858392D0-0x0000000185839350
		protected void RecompileEnd() {} // 0x0000000185839210-0x00000001858392D0
		protected void OnSceneLoaded() {} // 0x0000000185839150-0x0000000185839210
		private void HandleException(ExceptionPoint location, string message, Exception exception) {} // 0x0000000185837E80-0x0000000185838080
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		internal void ResetAll() {} // 0x0000000185839350-0x00000001858393C0
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		internal EditorPlatform GetEditorPlatform() => default; // 0x00000001858373F0-0x00000001858374A0
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		internal void GetSupportedEditModeControllerTypes(out bool keyboardSupported, out bool mouseSupported, out bool joystickSupported) {
			keyboardSupported = default;
			mouseSupported = default;
			joystickSupported = default;
		} // 0x0000000185837D60-0x0000000185837E80
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		internal bool IsEditModeSupported() => default; // 0x0000000185838740-0x0000000185838980
		protected abstract void OnInitialized();
		protected abstract void OnDeinitialized();
		protected abstract void DetectPlatform();
		protected abstract void CheckRecompile();
		protected abstract IExternalTools GetExternalTools();
	}
}
