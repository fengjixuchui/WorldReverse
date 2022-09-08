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
using Rewired.Data;
using Rewired.Data.Mapping;
using Rewired.Interfaces;
using Rewired.Platforms;
using Rewired.Utils;
using Rewired.Utils.Classes;
using Rewired.Utils.Classes.Data;
using Rewired.Utils.Classes.Utility;

// Image 39: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3466-4436

namespace Rewired
{
	public static class ReInput // TypeDefIndex: 4243
	{
		// Fields
		private static InputManager_Base slVUsRChRjTDGWipWiBmxpDDiza; // 0x00
		private static PlatformInputManager jdHrzjKbbHpmRevALLCPhhMcYEo; // 0x08
		internal static ELmeHFhAEObgGMupfccwkercFbWz fsQBYUGDBZAPIrofCevqCtlZgkl; // 0x10
		internal static GDZJmMlQvBAxDaQCuBIKYWggay uzYFVAOPCugnffcKSwcZmFfGUjB; // 0x18
		internal static aSOYcRCZqytuczbEAnlwvDhfgcsc YYmRYrIJJDlFmDKErJxqlPcJEZJ; // 0x20
		private static ControllerDataFiles SfZmyxquROdGzGebXHktAifKfcyJ; // 0x28
		private static UserData HWKwbrcCuDRNpmsHSWlFyGHxmZJ; // 0x30
		private static bool PkVqugVNIpoYIMpSDcpjdJRrnVs; // 0x38
		private static ConfigVars nsJgCtIfwJQZurQxCSnuqEVGIyJc; // 0x40
		private static UpdateLoopType uRiFqecNVABhPpjlbdnEZbQCduHT; // 0x48
		private static bool NQSAaKpVXFTtpEYlkOfJfYnAXKF; // 0x4C
		private static Platform XoBgevKuUNufHImfugJUwYrcLed; // 0x50
		private static WebplayerPlatform hfpQRTMlbWHjpKZUTBjPrNSHOMN; // 0x54
		private static EditorPlatform TAeiTQcgMAUjxnGidzESNBdrZfL; // 0x58
		private static bool TEUkumnGqcKoeDfMZAvHWiKrVAA; // 0x5C
		private static TimerAbs eVnxwPuAIqSqjdCHfLTPnQqhOuS; // 0x60
		private static EhxsPnRgLkJGhNLebiGYbKRcQisC byhxjZCTTQmKqDmFbArjjMebEEiU; // 0x68
		private static string FfmOuXPsLyiXOYRGYqCvUomXEtf; // 0x70
		private static bool KKKoRVgqJBPLeLIfqHuOawpSzDv; // 0x78
		private static bool dGPMYixxEPuanNlkfwttgKrCAJn; // 0x79
		private static bool DbIfnSeTsZrarxRvEbGnotGXYOP; // 0x7A
		private static int vVluxECgHHObLIBDngtyeEopTfz; // 0x7C
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		internal static int _id; // 0x80
		private static int BqvGDajsNHDQFimaowoHWkmtcezJ; // 0x84
		private static int xLfxhFLZjQdLUWRyswoZPONPxBz; // 0x88
		private static bool siTcmUMIEORCspmGInUXrqRhAmA; // 0x8C
		private static readonly UnityTouch VwhdbYJAGspHdCecSDipahRQBGhC; // 0x90
		private static readonly PlayerHelper nMAqgihSNTIWeKABbtKAmaICcOI; // 0x98
		private static readonly ControllerHelper bwPdHPluauISSUMbOOibuKhSRfq; // 0xA0
		private static readonly MappingHelper VQPmvtPFHSNMveDszHKjIBkUsAg; // 0xA8
		private static readonly TimeHelper LNVbxjuBfARbzvtwjPxUVnJqYoc; // 0xB0
		private static readonly ConfigHelper AUDGHcyHPPLEuDEOLcCudxKlwUE; // 0xB8
		private static nVoiynOsjugkJuOeheypUhVfWan PYgfAohzPdBiBNzCBrMUcbVtsqu; // 0xC0
		private static UserDataStore yhRlelsqiNUpDCFRMJbaNbHWeVF; // 0xC8
		private static IControllerAssigner nIhEXAJwaQdlbfpmXetDZHGNHWn; // 0xD0
		private static pYoKnCCVfqdynEXLQmjerrJzGiIh boBvGsJJUSYaUuLcYmbBJIEbOnn; // 0xD8
		private static SafeAction<ControllerStatusChangedEventArgs> HqoMbNHClYgUMifZgaYtZkeZBurd; // 0xE0
		private static SafeAction<ControllerStatusChangedEventArgs> ggujuzDBxzioqbLydtugFDEiuZGB; // 0xE8
		private static SafeAction<ControllerStatusChangedEventArgs> oitWqXclBrDGXFUqewBLImZPvIX; // 0xF0
		private static SafeAction yuiaytJpAtEVJlsDQdvCEAjxGqFh; // 0xF8
		private static SafeAction uUscfsaRRMgEUxAVSYOBdnwjUJx; // 0x100
		private static SafeAction iEjJzDzajVmJsTOlXBixkZGHcGai; // 0x108
		private static SafeAction aQUJGRByEiEXNqAtpfhnVDawYDZ; // 0x110
		private static SafeAction CwsGnWyAGEqkAcwKnlWWLMxZHzc; // 0x118
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		private static Action<bool> _ApplicationFocusChangedEvent; // 0x120
		private static Action vntQrbrkKdZWTszdWuZrMHBnpDZ; // 0x128
		private static Action<UpdateLoopType> ozcWIsacTFpNmGLAgTojfzcyonW; // 0x130
		private static Action<UpdateLoopType> qsuLbCZToKUUnPYbEKnsCsDTeel; // 0x138
		private static Action<UpdateLoopType> wLoMYBGXPwqksbsEiqdCOLTLOwH; // 0x140
		private static Action YWGdJgFpVdmvclIzdHWOMhNWTujk; // 0x148
		private static Action<bool> LaRcLjSViUcgvqFoPCLnJbJgbQrq; // 0x150
		private static Action<bool> wqttiWsvbJdLLAHkctBTBwKUJwo; // 0x158
		private static Action<bool> jRduKrAhuxzvQsgxSARkhtQWACy; // 0x160
		private static Action ZczdAdjbbuaFVNwaDpqQtCWKmBj; // 0x168
		private static Action<bool> wzLTVgfDmvVEdrlzFtHQOAGMBjS; // 0x170
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		internal static float unscaledDeltaTime; // 0x178
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		internal static float unscaledTime; // 0x17C
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		internal static float unscaledTimePrev; // 0x180
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		internal static uint currentFrame; // 0x184
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		internal static uint previousFrame; // 0x188
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		internal static uint absFrame; // 0x18C
	
		// Properties
		private static nVoiynOsjugkJuOeheypUhVfWan unityInputBuffer { get; } // 0x0000000185562740-0x0000000185562840 
		public static PlayerHelper players { get; } // 0x0000000185561DF0-0x0000000185561F10 
		public static ControllerHelper controllers { get; } // 0x0000000185560D30-0x0000000185560E50 
		public static MappingHelper mapping { get; } // 0x0000000185561CD0-0x0000000185561DF0 
		public static TimeHelper time { get; } // 0x0000000185562620-0x0000000185562740 
		public static IUserDataStore userDataStore { get; } // 0x0000000185562920-0x0000000185562A40 
		public static ConfigHelper configuration { get; } // 0x0000000185560B80-0x0000000185560CA0 
		public static string programVersion { get; } // 0x0000000185562050-0x0000000185562420 
		public static bool usingUnityInput { get; } // 0x0000000185562A40-0x0000000185562AD0 
		public static bool unityJoystickIdentificationRequired { get; } // 0x0000000185562840-0x0000000185562920 
		public static bool isReady { get; } // 0x0000000185561910-0x00000001855619A0 
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		internal static int id { get; } // 0x0000000185561220-0x00000001855612B0 
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		internal static UpdateLoopType currentUpdateLoop { get; } // 0x0000000185560FE0-0x0000000185561070 
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		internal static ConfigVars configVars { get; } // 0x0000000185560AF0-0x0000000185560B80 
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		internal static UserData UserData { get; } // 0x00000001855606F0-0x0000000185560780 
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		internal static Platform currentPlatform { get; } // 0x0000000185560E50-0x0000000185560EE0 
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		internal static WebplayerPlatform webplayerPlatform { get; } // 0x0000000185562AD0-0x0000000185562B60 
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		internal static EditorPlatform editorPlatform { get; } // 0x0000000185561190-0x0000000185561220 
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		internal static bool checkNeverPressed { get; } // 0x0000000185560870-0x0000000185560AF0 
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		internal static bool isEditor { get; } // 0x0000000185561880-0x0000000185561910 
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		internal static Guid defaultHardwareJoystickMapGuid { get; } // 0x0000000185561070-0x0000000185561190 
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		internal static bool isRunningInEditMode { get; } // 0x00000001855619A0-0x0000000185561A30 
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		internal static bool isEditorPaused { get; } // 0x00000001855617E0-0x0000000185561880 
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		internal static float realTime { get; } // 0x0000000185562420-0x0000000185562500 
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		internal static int currentUnityFrame { get; } // 0x0000000185560EE0-0x0000000185560FE0 
		private static bool isEditorGameViewFocused { get; } // 0x00000001855616A0-0x00000001855617E0 
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		internal static bool isAllowedEditorWindowFocused { get; } // 0x0000000185561550-0x00000001855616A0 
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		internal static bool isUnityEditorFocused { get; } // 0x0000000185561A30-0x0000000185561B20 
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		internal static bool isWindowsStandaloneWebplayerOrEditorPlatform { get; } // 0x0000000185561B20-0x0000000185561CD0 
		private static bool inputAllowed { get; } // 0x00000001855612B0-0x0000000185561550 
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		internal static bool applicationRunInBackground { get; } // 0x0000000185560780-0x0000000185560870 
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		internal static InputManager_Base rewiredInputManager { get; } // 0x0000000185562500-0x0000000185562590 
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		internal static PlatformInputManager primaryInputManager { get; } // 0x0000000185561F10-0x0000000185562050 
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		internal static IControllerAssigner controllerAssigner { get; set; } // 0x0000000185560CA0-0x0000000185560D30 0x0000000185566160-0x00000001855661F0
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		internal static int timeScalePauseChangedCount { get; } // 0x0000000185562590-0x0000000185562620 
	
		// Events
		public static event Action<ControllerStatusChangedEventArgs> ControllerConnectedEvent;
		public static event Action<ControllerStatusChangedEventArgs> ControllerPreDisconnectEvent;
		public static event Action<ControllerStatusChangedEventArgs> ControllerDisconnectedEvent;
		public static event Action InputSourceUpdateEvent;
		public static event Action EditorRecompileEvent;
		public static event Action ShutDownEvent;
		public static event Action InitializedEvent;
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		internal static event Action<bool> ApplicationFocusChangedEvent;
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		internal static event Action EarlyUpdateEvent;
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		internal static event Action<UpdateLoopType> BeforeTimeManagerUpdateEvent;
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		internal static event Action<UpdateLoopType> UpdateStartedEvent;
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		internal static event Action<UpdateLoopType> UpdateEndedEvent;
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		internal static event Action<bool> ApplicationIsFullScreenChangedEvent;
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		internal static event Action<bool> TimeScalePauseChangedEvent;
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		internal static event Action<bool> EditorPauseChangedEvent;
	
		// Nested types
		// [Browsable] // 0x00000001897BFBF0-0x00000001897BFC30
		// [EditorBrowsable] // 0x00000001897BFBF0-0x00000001897BFC30
		public sealed class ConfigHelper : CodeHelper // TypeDefIndex: 4244
		{
			// Fields
			private static ConfigHelper muFkkiEUnsHdAMTJRFCFrPnztKW; // 0x00
	
			// Properties
			internal static ConfigHelper Instance { get => default; } // 0x000000018554ED90-0x000000018554EE20 
			public bool alwaysUseUnityInput { get => default; } // 0x000000018554EE20-0x000000018554EF00 
			public bool disableNativeInput { get => default; } // 0x000000018554EFE0-0x000000018554F050 
			public bool ignoreInputWhenAppNotInFocus { get => default; } // 0x000000018554F050-0x000000018554F140 
			public bool autoAssignJoysticks { get => default; set {} } // 0x000000018554EF00-0x000000018554EFE0 0x000000018554F140-0x000000018554F280
	
			// Constructors
			private ConfigHelper() {} // 0x000000018554ECF0-0x000000018554ED90
		}
	
		// [Browsable] // 0x00000001897BFBF0-0x00000001897BFC30
		// [EditorBrowsable] // 0x00000001897BFBF0-0x00000001897BFC30
		public sealed class ControllerHelper : CodeHelper // TypeDefIndex: 4245
		{
			// Fields
			private static ControllerHelper muFkkiEUnsHdAMTJRFCFrPnztKW; // 0x00
			public readonly PollingHelper polling; // 0x10
			public readonly ConflictCheckingHelper conflictChecking; // 0x18
	
			// Properties
			internal static ControllerHelper Instance { get => default; } // 0x0000000185550B80-0x0000000185550C10 
			public Mouse Mouse { get => default; } // 0x0000000185550DC0-0x0000000185550E90 
			public Keyboard Keyboard { get => default; } // 0x0000000185550CF0-0x0000000185550DC0 
			public int joystickCount { get => default; } // 0x0000000185550F60-0x0000000185551030 
			public IList<Joystick> Joysticks { get => default; } // 0x0000000185550C10-0x0000000185550CF0 
			public int customControllerCount { get => default; } // 0x0000000185550E90-0x0000000185550F60 
			public IList<CustomController> CustomControllers { get => default; } // 0x0000000185550AA0-0x0000000185550B80 
	
			// Nested types
			// [Browsable] // 0x00000001897BFBF0-0x00000001897BFC30
			// [EditorBrowsable] // 0x00000001897BFBF0-0x00000001897BFC30
			public sealed class PollingHelper : CodeHelper // TypeDefIndex: 4246
			{
				// Fields
				private static PollingHelper muFkkiEUnsHdAMTJRFCFrPnztKW; // 0x00
	
				// Properties
				internal static PollingHelper Instance { get => default; } // 0x000000018555AAB0-0x000000018555AB40 
	
				// Constructors
				private PollingHelper() {} // 0x000000018555AA10-0x000000018555AAB0
	
				// Methods
				public IEnumerable<ControllerPollingInfo> PollControllerForAllElementsDown(ControllerType controllerType, int controllerId) => default; // 0x000000018555A560-0x000000018555A6B0
				public IEnumerable<ControllerPollingInfo> PollControllerForAllButtonsDown(ControllerType controllerType, int controllerId) => default; // 0x000000018555A410-0x000000018555A560
				public IEnumerable<ControllerPollingInfo> PollControllerForAllAxes(ControllerType controllerType, int controllerId) => default; // 0x000000018555A2A0-0x000000018555A410
				private IEnumerable<ControllerPollingInfo> LmaAZmigKSKzeRdhfpRcpQoLEam(int param_00008da1) => default; // 0x000000018555A1E0-0x000000018555A2A0
				private IEnumerable<ControllerPollingInfo> SYgSdpphkaZENwexNJvseczkiYQ(int param_00008da2) => default; // 0x000000018555A740-0x000000018555A800
				private IEnumerable<ControllerPollingInfo> WhpDbcKIUTTzCrpOKBZEvSYhKeHC(int param_00008da3) => default; // 0x000000018555A8A0-0x000000018555A970
				private IEnumerable<ControllerPollingInfo> QBcgdYdqwsLotCArKVfGzZsRCKD() => default; // 0x000000018555A6B0-0x000000018555A740
				private IEnumerable<ControllerPollingInfo> TUrfKiUifMozUtgDHYzvZgHvzIw() => default; // 0x000000018555A800-0x000000018555A8A0
				private IEnumerable<ControllerPollingInfo> YxKFHoPCWDOhrAoZxeOqaaLGcrXM() => default; // 0x000000018555A970-0x000000018555AA10
				private IEnumerable<ControllerPollingInfo> IyFFzGFhfcLDjpFDRMcEectHWpgg() => default; // 0x000000018555A150-0x000000018555A1E0
				private IEnumerable<ControllerPollingInfo> BKJAXvDbuTnvWelHGsnFSuKqpXEc(int param_00008da4) => default; // 0x0000000185559FE0-0x000000018555A0A0
				private IEnumerable<ControllerPollingInfo> AtqrGKflGhvGEBYGxAVIkJNoaPsK(int param_00008da5) => default; // 0x0000000185559EF0-0x0000000185559FE0
				private IEnumerable<ControllerPollingInfo> DAFLFoRFTmdXiAbpHJuGOlBavlVu(int param_00008da6) => default; // 0x000000018555A0A0-0x000000018555A150
			}
	
			// [Browsable] // 0x0000000189AC1770-0x0000000189AC17B0
			// [EditorBrowsable] // 0x0000000189AC1770-0x0000000189AC17B0
			public sealed class ConflictCheckingHelper : CodeHelper // TypeDefIndex: 4247
			{
				// Fields
				private static ConflictCheckingHelper muFkkiEUnsHdAMTJRFCFrPnztKW; // 0x00
	
				// Properties
				internal static ConflictCheckingHelper Instance { get => default; } // 0x000000018554F320-0x000000018554F3B0 
	
				// Constructors
				private ConflictCheckingHelper() {} // 0x000000018554F280-0x000000018554F320
			}
	
			// Constructors
			private ControllerHelper() {} // 0x00000001855509E0-0x0000000185550AA0
	
			// Methods
			public Controller GetController(ControllerType controllerType, int controllerId) => default; // 0x000000018554F8D0-0x000000018554F9D0
			public Controller GetController(ControllerIdentifier controllerIdentifier) => default; // 0x000000018554F7D0-0x000000018554F8D0
			public bool IsControllerAssigned(ControllerType controllerType, int controllerId) => default; // 0x000000018554FFD0-0x00000001855500C0
			public bool IsControllerAssignedToPlayer(ControllerType controllerType, int controllerId, int playerId) => default; // 0x000000018554FED0-0x000000018554FFD0
			public void RemoveControllerFromAllPlayers(ControllerType controllerType, int controllerId, bool includeSystemPlayer = true /* Metadata: 0x00AC4D85 */) {} // 0x0000000185550460-0x0000000185550580
			public Joystick GetJoystick(int joystickId) => default; // 0x000000018554FAB0-0x000000018554FB90
			public Joystick[] GetJoysticks() => default; // 0x000000018554FB90-0x000000018554FC30
			public bool IsJoystickAssigned(Joystick joystick) => default; // 0x00000001855502A0-0x0000000185550380
			public bool IsJoystickAssigned(int joystickId) => default; // 0x0000000185550380-0x0000000185550460
			public bool IsJoystickAssignedToPlayer(int joystickId, int playerId) => default; // 0x00000001855501B0-0x00000001855502A0
			public void RemoveJoystickFromAllPlayers(Joystick joystick, bool includeSystemPlayer = true /* Metadata: 0x00AC4D86 */) {} // 0x0000000185550660-0x0000000185550760
			public int GetUnityJoystickIdFromAnyButtonOrAxisPress(float axisThreshold, bool positiveAxesOnly) => default; // 0x000000018554FC30-0x000000018554FED0
			public void SetUnityJoystickId(int joystickId, int unityJoystickId) {} // 0x0000000185550840-0x00000001855509E0
			public bool SetUnityJoystickIdFromAnyButtonOrAxisPress(int joystickId, float axisThreshold, bool positiveAxesOnly) => default; // 0x0000000185550760-0x0000000185550840
			public CustomController GetCustomController(int customControllerId) => default; // 0x000000018554F9D0-0x000000018554FAB0
			public bool IsCustomControllerAssignedToPlayer(int customControllerId, int playerId) => default; // 0x00000001855500C0-0x00000001855501B0
			public void RemoveCustomControllerFromAllPlayers(CustomController customController, bool includeSystemPlayer = true /* Metadata: 0x00AC4D87 */) {} // 0x0000000185550580-0x0000000185550660
			public CustomController CreateCustomController(int sourceControllerId) => default; // 0x000000018554F5F0-0x000000018554F6D0
			public bool DestroyCustomController(CustomController customController) => default; // 0x000000018554F6D0-0x000000018554F7D0
			public bool AutoAssignJoystick(Joystick joystick) => default; // 0x000000018554F3B0-0x000000018554F4E0
			public void AutoAssignJoysticks() {} // 0x000000018554F4E0-0x000000018554F5F0
		}
	
		// [Browsable] // 0x00000001897BFBF0-0x00000001897BFC30
		// [EditorBrowsable] // 0x00000001897BFBF0-0x00000001897BFC30
		public sealed class MappingHelper : CodeHelper // TypeDefIndex: 4248
		{
			// Fields
			private static MappingHelper muFkkiEUnsHdAMTJRFCFrPnztKW; // 0x00
	
			// Properties
			internal static MappingHelper Instance { get => default; } // 0x00000001855558C0-0x0000000185555950 
			public IList<InputMapCategory> MapCategories { get => default; } // 0x0000000185555B10-0x0000000185555BF0 
			public IEnumerable<InputMapCategory> UserAssignableMapCategories { get => default; } // 0x0000000185555CD0-0x0000000185555DB0 
			public IList<InputCategory> ActionCategories { get => default; } // 0x0000000185555620-0x0000000185555700 
			public IList<InputLayout> JoystickLayouts { get => default; } // 0x0000000185555950-0x0000000185555A30 
			public IList<InputLayout> KeyboardLayouts { get => default; } // 0x0000000185555A30-0x0000000185555B10 
			public IList<InputLayout> MouseLayouts { get => default; } // 0x0000000185555BF0-0x0000000185555CD0 
			public IList<InputLayout> CustomControllerLayouts { get => default; } // 0x00000001855557E0-0x00000001855558C0 
			public IList<InputAction> Actions { get => default; } // 0x0000000185555700-0x00000001855557E0 
	
			// Constructors
			private MappingHelper() {} // 0x0000000185555580-0x0000000185555620
	
			// Methods
			public InputMapCategory GetMapCategory(int mapCategoryId) => default; // 0x0000000185555160-0x0000000185555240
			public int GetMapCategoryId(string name) => default; // 0x0000000185555080-0x0000000185555160
			public InputCategory GetActionCategory(string name) => default; // 0x0000000185553E90-0x0000000185553F70
			public InputLayout GetLayout(ControllerType controllerType, int layoutId) => default; // 0x0000000185554E20-0x0000000185555080
			public int GetLayoutId(ControllerType controllerType, string name) => default; // 0x0000000185554BE0-0x0000000185554E20
			public IList<InputLayout> MapLayouts(ControllerType controllerType) => default; // 0x0000000185555390-0x00000001855554D0
			public InputAction GetAction(int actionId) => default; // 0x0000000185554130-0x0000000185554210
			public InputAction GetAction(string name) => default; // 0x0000000185554050-0x0000000185554130
			public int GetActionId(string name) => default; // 0x0000000185553F70-0x0000000185554050
			public IEnumerable<InputAction> ActionsInCategory(string mapCategoryName) => default; // 0x0000000185553CC0-0x0000000185553DB0
			public IEnumerable<InputAction> ActionsInCategory(int mapCategoryId) => default; // 0x0000000185553DB0-0x0000000185553E90
			public IList<InputBehavior> GetInputBehaviors(int playerId) => default; // 0x0000000185554800-0x00000001855548E0
			public InputBehavior GetInputBehavior(int playerId, int behaviorId) => default; // 0x0000000185554710-0x0000000185554800
			internal InputBehavior PDLBpiYomVdxEiynPbsrqAsfQgD(int param_00008db7) => default; // 0x00000001855554D0-0x0000000185555580
			public ControllerMap GetControllerMapInstance(Controller controller, int mapCategoryId, int layoutId) => default; // 0x00000001855542F0-0x00000001855544D0
			public JoystickMap GetJoystickMapInstance(Joystick joystick, int mapCategoryId, int layoutId) => default; // 0x00000001855548E0-0x0000000185554A60
			public KeyboardMap GetKeyboardMapInstance(int mapCategoryId, int layoutId) => default; // 0x0000000185554A60-0x0000000185554BE0
			public MouseMap GetMouseMapInstance(int mapCategoryId, int layoutId) => default; // 0x0000000185555240-0x0000000185555390
			public CustomControllerMap GetCustomControllerMapInstance(CustomController customController, int mapCategoryId, int layoutId) => default; // 0x00000001855545B0-0x0000000185554710
			public ControllerMapLayoutManager.RuleSet GetControllerMapLayoutManagerRuleSetInstance(int id) => default; // 0x00000001855544D0-0x00000001855545B0
			public ControllerMapEnabler.RuleSet GetControllerMapEnablerRuleSetInstance(int id) => default; // 0x0000000185554210-0x00000001855542F0
		}
	
		// [Browsable] // 0x0000000189AC1770-0x0000000189AC17B0
		// [EditorBrowsable] // 0x0000000189AC1770-0x0000000189AC17B0
		public sealed class PlayerHelper : CodeHelper // TypeDefIndex: 4249
		{
			// Fields
			private static PlayerHelper muFkkiEUnsHdAMTJRFCFrPnztKW; // 0x00
	
			// Properties
			internal static PlayerHelper Instance { get => default; } // 0x0000000185559790-0x0000000185559820 
			public int playerCount { get => default; } // 0x0000000185559AA0-0x0000000185559D40 
			public int allPlayerCount { get => default; } // 0x00000001855599D0-0x0000000185559AA0 
			public IList<Player> Players { get => default; } // 0x0000000185559820-0x0000000185559900 
			public IList<Player> AllPlayers { get => default; } // 0x00000001855596B0-0x0000000185559790 
			public Player SystemPlayer { get => default; } // 0x0000000185559900-0x00000001855599D0 
	
			// Constructors
			private PlayerHelper() {} // 0x0000000185559610-0x00000001855596B0
	
			// Methods
			public IList<Player> GetPlayers(bool includeSystemPlayer = false /* Metadata: 0x00AC4D88 */) => default; // 0x0000000185559410-0x0000000185559540
			public Player GetPlayer(int playerId) => default; // 0x0000000185559330-0x0000000185559410
			public Player GetSystemPlayer() => default; // 0x0000000185559540-0x0000000185559610
		}
	
		// [Browsable] // 0x0000000189AC1770-0x0000000189AC17B0
		// [EditorBrowsable] // 0x0000000189AC1770-0x0000000189AC17B0
		public sealed class TimeHelper : CodeHelper // TypeDefIndex: 4250
		{
			// Fields
			private static TimeHelper muFkkiEUnsHdAMTJRFCFrPnztKW; // 0x00
	
			// Properties
			internal static TimeHelper Instance { get => default; } // 0x0000000185574280-0x0000000185574310 
			public uint currentFrame { get => default; } // 0x0000000185574310-0x00000001855743E0 
	
			// Constructors
			private TimeHelper() {} // 0x00000001855741E0-0x0000000185574280
		}
	
		private class EhxsPnRgLkJGhNLebiGYbKRcQisC // TypeDefIndex: 4251
		{
			// Fields
			private StopwatchBase YnBnDKQzhCdRVEiGZZWcKvTjviq; // 0x10
			private float DlcCoZkGqoGypBZJvuzpJgyLUQQ; // 0x18
			private PEhdvMmUUQFgTimkBZtyvdkTkaP xXeNJfMPHnbgrmrmtEOqQyvMFTV; // 0x20
			private ADictionary<int, PEhdvMmUUQFgTimkBZtyvdkTkaP> QetjGnDEtDPSEcIQErMZqiGQOiZW; // 0x28
			private uint nGMvBhZElUQpCwHTNGYODdJvBEzh; // 0x30
	
			// Properties
			public float LWGCTRGkBxOSmSVZeVZykIIycjqe { get => default; } // 0x0000000185551A80-0x0000000185551B10 
			public uint guebJEeuIIBmQDaVIDUbCtSyEDzN { get => default; } // 0x00000001855519D0-0x0000000185551A80 
	
			// Nested types
			private class PEhdvMmUUQFgTimkBZtyvdkTkaP // TypeDefIndex: 4252
			{
				// Fields
				public readonly UpdateLoopType uZqPISCyPgGPOetNKiFUKtuJqjV; // 0x10
				private float unwgQSnePmeOsXbHPocojQIZGLM; // 0x14
				private float wGaGzOSVHEeUGehUFFhEJemcsBD; // 0x18
				private float FtnAbdJXGXeezDMRWayldslYfCSO; // 0x1C
				private float iWpvHOnbLFlrKVsDoRBJraRtavF; // 0x20
				private uint geqTkVWeHSclULzUsqTDwVoQmfu; // 0x24
				private uint lTDkbefPylKXAYNBPzGwuOtgyUV; // 0x28
				private float AbCBxbmbcgBtrEzVCJgroRaBcGg; // 0x2C
				private float zdmHgZpCwAdmfHodYfWlDOCqbWY; // 0x30
	
				// Properties
				public uint guebJEeuIIBmQDaVIDUbCtSyEDzN { get => default; } // 0x00000001855592D0-0x0000000185559330 
	
				// Constructors
				public PEhdvMmUUQFgTimkBZtyvdkTkaP() {} // Dummy constructor
				public PEhdvMmUUQFgTimkBZtyvdkTkaP(UpdateLoopType updateLoop) {} // 0x0000000185559240-0x00000001855592D0
	
				// Methods
				public void UZSQFwoMfSAzsmmSKmseCCiJWWD() {} // 0x0000000185559020-0x0000000185559240
			}
	
			private static class AVHklAFuFUwCuXXctuhbWlOXyYc // TypeDefIndex: 4253
			{
				// Properties
				public static StopwatchBase WnDTafDnukaBExALXKrIZmvleoB { get; } // 0x000000018554E840-0x000000018554E930 
			}
	
			// Constructors
			public EhxsPnRgLkJGhNLebiGYbKRcQisC() {} // 0x0000000185551950-0x00000001855519D0
	
			// Methods
			public void QKQqmYzrJRcHvrgQkDkYyDOslGG() {} // 0x0000000185551790-0x0000000185551800
			public void EEGiMNPSMElaPgKQdmScoWLedfb() {} // 0x0000000185551420-0x0000000185551790
			public void UZSQFwoMfSAzsmmSKmseCCiJWWD(UpdateLoopType param_00008dc9) {} // 0x0000000185551800-0x0000000185551950
		}
	
		// [Browsable] // 0x00000001897BFBF0-0x00000001897BFC30
		// [EditorBrowsable] // 0x00000001897BFBF0-0x00000001897BFC30
		public sealed class UnityTouch : CodeHelper // TypeDefIndex: 4254
		{
			// Fields
			private static UnityTouch muFkkiEUnsHdAMTJRFCFrPnztKW; // 0x00
	
			// Properties
			internal static UnityTouch Instance { get => default; } // 0x0000000185574B90-0x0000000185574C20 
	
			// Constructors
			private UnityTouch() {} // 0x0000000185574AF0-0x0000000185574B90
		}
	
		internal class pYoKnCCVfqdynEXLQmjerrJzGiIh // TypeDefIndex: 4255
		{
			// Fields
			public readonly ValueWatcher<bool> bJapzHksrSKqatCVpdSUJVOFzgkf; // 0x10
			public readonly ValueWatcher<bool> rkMyiSJCrEZgYxAnjXzNqPoPmCC; // 0x18
			public readonly ValueWatcher<bool> EqsKYJrgzfkdoyPqgDjUNxUXSnb; // 0x20
			public readonly ValueWatcher<float> BQJHdWatcmMaoTVinhliSIFKncn; // 0x28
			public readonly ValueWatcher<string> vcMaKVKsPSGEibJzuaIhEyChSBsI; // 0x30
			public readonly ValueWatcher<bool> XReSKUwXUYFNLYvngWoHmqhvqLV; // 0x38
			private int eAVMdlGjFWURgZyTGbSFWWOiqf; // 0x40
			private readonly ValueWatcher[] bTyzTgydMIyPOTRNCMJDsFnTBxZ; // 0x48
	
			// Properties
			public int RdYremdAEszGNymRcrAGzSYvgDX { get => default; } // 0x00000001855780D0-0x0000000185578130 
	
			// Constructors
			public pYoKnCCVfqdynEXLQmjerrJzGiIh() {} // 0x0000000185577B00-0x0000000185578030
	
			// Methods
			public void UZSQFwoMfSAzsmmSKmseCCiJWWD() {} // 0x0000000185577A00-0x0000000185577B00
			public void JBUJYqkBSdjOUTpqLXKBOxBQzIF() {} // 0x00000001855777C0-0x00000001855778B0
		}
	
		// Constructors
		static ReInput() {} // 0x000000018555ED20-0x000000018555F810
	
		// Methods
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		internal static bool IsInputAllowed(ControllerType controllerType) => default; // 0x000000018555C970-0x000000018555CB30
		internal static void YJaAHaimrHWIfKrgfWxeihnqrcza(InputManager_Base param_00008d52, Func<ConfigVars, object> param_00008d53, ConfigVars param_00008d54, ControllerDataFiles param_00008d55, UserData param_00008d56) {} // 0x000000018555DD80-0x000000018555ED20
		internal static void HTeWiJSswgFIFVAtPBCSclhPFDl() {} // 0x000000018555BEA0-0x000000018555C2C0
		internal static void mHzPvDIYDGoChNcnPSzgyYaRzPK(UpdateLoopType param_00008d57) {} // 0x0000000185564E80-0x0000000185564F90
		private static void MfqtTKMJYKxULLKLXLloixpfsqd(UpdateLoopType param_00008d58) {} // 0x000000018555CF50-0x000000018555D120
		private static void mkckTroaLWabcNXFfBuucaAwbSlp() {} // 0x0000000185564F90-0x00000001855650E0
		internal static void UZSQFwoMfSAzsmmSKmseCCiJWWD(UpdateLoopType param_00008d59) {} // 0x000000018555D700-0x000000018555DCF0
		internal static void SAOvBBbpeoGAhEwYskaoZLmoMij() {} // 0x000000018555D120-0x000000018555D1F0
		internal static void unwXDbTGcreCTKEOFdJSrnMHNGeK() {} // 0x00000001855661F0-0x0000000185566490
		internal static void CNeIVVuWULdFyKFIYCKvjGpjiyJy() {} // 0x000000018555AFB0-0x000000018555B080
		internal static void EDMLfpLtLFmhqzkIkCmkCoWTnga(bool param_00008d5a) {} // 0x000000018555B320-0x000000018555B490
		internal static void EgYgUWpmpSSstJYXGSMKUkAFAed() {} // 0x000000018555B7F0-0x000000018555B920
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		internal static HardwareJoystickMap_InputManager GetHardwareJoystickMap_InputManager(BridgedControllerHWInfo bridgedController) => default; // 0x000000018555BD50-0x000000018555BE00
		internal static HardwareJoystickMap KMGdcXDLnbZuPYvzFIqeDgBsQnv(Guid param_00008d5c) => default; // 0x000000018555CC10-0x000000018555CCC0
		internal static HardwareJoystickTemplateMap GQIAEUrSKudAJFshKLEiDynhHAON(Guid param_00008d5d) => default; // 0x000000018555BBA0-0x000000018555BC50
		internal static IList<HardwareJoystickTemplateMap> oKiFpADtDgRKbCjxFcbRklAzcrvC(Guid param_00008d5e) => default; // 0x00000001855650E0-0x00000001855654F0
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		internal static int GetNewJoystickId() => default; // 0x000000018555BE00-0x000000018555BEA0
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		internal static void HandleCallbackException(string source, Exception exception) {} // 0x000000018555C2C0-0x000000018555C500
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		internal static void HandleExternalInterfaceException(string source, Exception exception) {} // 0x000000018555C500-0x000000018555C790
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		internal static void CheckRewiredVersionCompatibility() {} // 0x000000018555B200-0x000000018555B320
		internal static float aYzppXbiwhRevgRvHlcJJfkjnTD() => default; // 0x000000018555F810-0x000000018555F8D0
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		internal static bool CheckInitialized() => default; // 0x000000018555B080-0x000000018555B130
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		internal static bool CheckInitialized(int reInputId) => default; // 0x000000018555B130-0x000000018555B200
		private static void SRmblXnsFVNikIygzWSLnnYKyUa() {} // 0x000000018555D280-0x000000018555D3D0
		private static void joMHNyzTHwbdiENllpwCAmGeGCt() {} // 0x0000000185562E10-0x0000000185563890
		private static void AlDeMuQZTTTXPcyefOlYwtDjppQ() {} // 0x000000018555AD90-0x000000018555AF20
		private static void oRdMvvHeXoBVjiPOAZrrkCGwKZc() {} // 0x00000001855654F0-0x0000000185565560
		private static void TfIrAJAexbdMuUiwCoHoYlpGvUd(BridgedController param_00008d64) {} // 0x000000018555D3D0-0x000000018555D700
		private static void iLVcRqRvCtyLIeebWiNxuHKxGis(ControllerDisconnectedEventArgs param_00008d65) {} // 0x0000000185562C10-0x0000000185562E10
		private static void alCUyUtvfUaetHJyrcbCIiXFfQsz(ControllerStatusChangedEventArgs param_00008d66) {} // 0x00000001855604D0-0x00000001855605B0
		private static void HeGvTzrqFcKtPqKMHFQVjwREaxuH(ControllerStatusChangedEventArgs param_00008d67) {} // 0x000000018555C790-0x000000018555C890
		private static void GRnmfKVMCbfRJfmKODrTuOsjjHY(ControllerStatusChangedEventArgs param_00008d68) {} // 0x000000018555BC50-0x000000018555BD50
		private static void cFCMwAHKZmlcjcqpdfsPHDXUvUN(UpdateControllerInfoEventArgs param_00008d69) {} // 0x00000001855605B0-0x0000000185560660
		private static void EyzHgLRlWvcWTAWdkRJsusIxnhij(bool param_00008d6a) {} // 0x000000018555B9B0-0x000000018555BAC0
		private static void HfwYfRoxmRwUdwadectDCKAldT(bool param_00008d6b) {} // 0x000000018555C890-0x000000018555C970
		private static void LjKkXyiBGXooLPkKXInbbrJJuRG(bool param_00008d6c) {} // 0x000000018555CCC0-0x000000018555CDA0
		private static void xLRaVbExgLBPjYoZAVMldSQFzrv(bool param_00008d6d) {} // 0x0000000185566800-0x00000001855668F0
		private static void wNLcewivNtYwCyizGFbOEPbANGl() {} // 0x0000000185566490-0x0000000185566770
		private static void zlTamOIVGxORQadPEUGfkxjPgox() {} // 0x00000001855668F0-0x0000000185566C60
		private static void JdScRajqhDdTAtUtpPJWbsXkjTEZ(bool param_00008d6e) {} // 0x000000018555CB30-0x000000018555CC10
		private static void lZCArPkLoSgJaEkxbPbqcntMgGtG(Func<ConfigVars, object> param_00008d6f) {} // 0x0000000185563890-0x0000000185564E80
		private static void FxmltkFMOBJxuWoQGhhMyNVSEOq() {} // 0x000000018555BAC0-0x000000018555BBA0
		private static void EYObgztApnHauLDkTATuAqqDpKf() {} // 0x000000018555B490-0x000000018555B7F0
	}
}
