/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace InControl
{
	public static class InputManager // TypeDefIndex: 7642
	{
		// Fields
		public static readonly VersionInfo Version; // 0x00
		private static readonly List<InputDeviceManager> deviceManagers; // 0x50
		private static readonly Dictionary<System.Type, InputDeviceManager> deviceManagerTable; // 0x58
		private static readonly List<InputDevice> devices; // 0x60
		private static InputDevice activeDevice; // 0x68
		private static readonly List<InputDevice> activeDevices; // 0x70
		private static readonly List<PlayerActionSet> playerActionSets; // 0x78
		public static ReadOnlyCollection<InputDevice> Devices; // 0x80
		public static ReadOnlyCollection<InputDevice> ActiveDevices; // 0x88
		private static bool applicationIsFocused; // 0xA0
		private static float initialTime; // 0xA4
		private static float currentTime; // 0xA8
		private static float lastUpdateTime; // 0xAC
		private static ulong currentTick; // 0xB0
		private static VersionInfo? unityVersion; // 0xB8
		private static bool enabled; // 0xCC
	
		// Properties
		public static bool CommandWasPressed { /* [XID] */ /* 0x0000000189973710-0x0000000189973750 */ get; /* [XID] */ /* 0x000000018997D7D0-0x000000018997D810 */ private set; } // 0x00000001870D9CB0-0x00000001870D9D40 0x00000001870DB430-0x00000001870DB4C0
		public static bool InvertYAxis { /* [XID] */ /* 0x0000000189988440-0x0000000189988480 */ get; /* [XID] */ /* 0x0000000189993350-0x0000000189993390 */ set; } // 0x00000001870DA090-0x00000001870DA120 0x00000001870DB7D0-0x00000001870DB860
		public static bool IsSetup { /* [XID] */ /* 0x000000018999DC40-0x000000018999DC80 */ get; /* [XID] */ /* 0x00000001899A8740-0x00000001899A8780 */ private set; } // 0x00000001870DA120-0x00000001870DA1B0 0x00000001870DB860-0x00000001870DB8F0
		internal static string Platform { /* [XID] */ /* 0x00000001899B3210-0x00000001899B3250 */ get; /* [XID] */ /* 0x00000001899BD4F0-0x00000001899BD530 */ private set; } // 0x00000001870DA420-0x00000001870DA4B0 0x00000001870DBAA0-0x00000001870DBB30
		[Obsolete] // 0x0000000189B96FD0-0x0000000189B97000
		public static bool MenuWasPressed { /* [XID] */ /* 0x00000001899C7DD0-0x00000001899C7DF0 */ get; } // 0x00000001870DA1B0-0x00000001870DA270 
		public static bool AnyKeyIsPressed { /* [XID] */ /* 0x0000000189AADB90-0x0000000189AADBB0 */ get; } // 0x00000001870D9B20-0x00000001870D9CB0 
		public static InputDevice ActiveDevice { /* [XID] */ /* 0x0000000189A69CB0-0x0000000189A69CD0 */ get; /* [XID] */ /* 0x0000000189B1E560-0x0000000189B1E580 */ private set; } // 0x00000001870D9A20-0x00000001870D9B20 0x00000001870DB330-0x00000001870DB430
		public static bool Enabled { /* [XID] */ /* 0x0000000189AC4960-0x0000000189AC4980 */ get; /* [XID] */ /* 0x0000000189ACBF80-0x0000000189ACBFA0 */ set; } // 0x00000001870D9FC0-0x00000001870DA090 0x00000001870DB670-0x00000001870DB7D0
		public static bool SuspendInBackground { /* [XID] */ /* 0x0000000189AD38D0-0x0000000189AD3910 */ get; /* [XID] */ /* 0x0000000189ADE760-0x0000000189ADE7A0 */ internal set; } // 0x00000001870DA4B0-0x00000001870DA540 0x00000001870DBB30-0x00000001870DBBC0
		public static bool EnableNativeInput { /* [XID] */ /* 0x0000000189AE8C30-0x0000000189AE8C70 */ get; /* [XID] */ /* 0x0000000189AF3990-0x0000000189AF39D0 */ internal set; } // 0x00000001870D9EA0-0x00000001870D9F30 0x00000001870DB550-0x00000001870DB5E0
		public static bool EnableXInput { /* [XID] */ /* 0x0000000189AFDD90-0x0000000189AFDDD0 */ get; /* [XID] */ /* 0x0000000189B084C0-0x0000000189B08500 */ internal set; } // 0x00000001870D9F30-0x00000001870D9FC0 0x00000001870DB5E0-0x00000001870DB670
		public static uint XInputUpdateRate { get; /* [XID] */ /* 0x0000000189B1A170-0x0000000189B1A1B0 */ internal set; } // 0x00000001870DA7A0-0x00000001870DA830 0x00000001870DBC50-0x00000001870DBE40
		public static uint XInputBufferSize { get; /* [XID] */ /* 0x0000000189B2BCC0-0x0000000189B2BD00 */ internal set; } // 0x00000001870DA710-0x00000001870DA7A0 0x00000001870DBBC0-0x00000001870DBC50
		public static bool NativeInputEnableXInput { get; /* [XID] */ /* 0x0000000189B3D830-0x0000000189B3D870 */ internal set; } // 0x00000001870DA270-0x00000001870DA300 0x00000001870DB8F0-0x00000001870DB980
		public static bool NativeInputPreventSleep { get; /* [XID] */ /* 0x0000000189B4FC90-0x0000000189B4FCD0 */ internal set; } // 0x00000001870DA300-0x00000001870DA390 0x00000001870DB980-0x00000001870DBA10
		public static uint NativeInputUpdateRate { get; /* [XID] */ /* 0x0000000189B61A20-0x0000000189B61A60 */ internal set; } // 0x00000001870DA390-0x00000001870DA420 0x00000001870DBA10-0x00000001870DBAA0
		public static bool EnableICade { get; /* [XID] */ /* 0x0000000189703A60-0x0000000189703AA0 */ internal set; } // 0x00000001870D9E10-0x00000001870D9EA0 0x00000001870DB4C0-0x00000001870DB550
		internal static VersionInfo UnityVersion { /* [XID] */ /* 0x0000000189B7DDA0-0x0000000189B7DDC0 */ get; } // 0x00000001870DA540-0x00000001870DA710 
		public static ulong CurrentTick { /* [XID] */ /* 0x0000000189673B40-0x0000000189673B60 */ get; } // 0x00000001870D9D40-0x00000001870D9E10 
	
		// Events
		public static event Action OnSetup;
		public static event Action<ulong, float> OnUpdate;
		public static event Action OnReset;
		public static event Action<InputDevice> OnDeviceAttached;
		public static event Action<InputDevice> OnDeviceDetached;
		public static event Action<InputDevice> OnActiveDeviceChanged;
		internal static event Action<ulong, float> OnUpdateDevices;
		internal static event Action<ulong, float> OnCommitDevices;
	
		// Constructors
		static InputManager() {} // 0x00000001870D8D70-0x00000001870D8F20
	
		// Methods
		[Obsolete] // 0x00000001899CF780-0x00000001899CF7D0
		// [XID] // 0x00000001899CF780-0x00000001899CF7D0
		public static void Setup() {} // 0x00000001870D7DB0-0x00000001870D7E70
		// [XID] // 0x00000001897C7FD0-0x00000001897C7FF0
		internal static bool SetupInternal() => default; // 0x00000001870D7960-0x00000001870D7DB0
		[Obsolete] // 0x00000001899E29F0-0x00000001899E2A40
		// [XID] // 0x00000001899E29F0-0x00000001899E2A40
		public static void Reset() {} // 0x00000001870D76E0-0x00000001870D77A0
		// [XID] // 0x00000001899EE940-0x00000001899EE960
		internal static void ResetInternal() {} // 0x00000001870D74E0-0x00000001870D76E0
		[Obsolete] // 0x00000001899F6190-0x00000001899F61E0
		// [XID] // 0x00000001899F6190-0x00000001899F61E0
		public static void Update() {} // 0x00000001870D8CB0-0x00000001870D8D70
		// [XID] // 0x0000000189A01CE0-0x0000000189A01D00
		internal static void UpdateInternal() {} // 0x00000001870D8760-0x00000001870D8B20
		// [XID] // 0x0000000189A09670-0x0000000189A09690
		public static void Reload() {} // 0x00000001870D7420-0x00000001870D74E0
		// [XID] // 0x00000001898D5A20-0x00000001898D5A40
		private static void AssertIsSetup() {} // 0x00000001870D5DD0-0x00000001870D5EC0
		// [XID] // 0x0000000189986990-0x00000001899869B0
		private static void SetZeroTickOnAllControls() {} // 0x00000001870D77A0-0x00000001870D7960
		// [XID] // 0x0000000189A1F860-0x0000000189A1F880
		public static void ClearInputState() {} // 0x00000001870D6340-0x00000001870D65E0
		// [XID] // 0x0000000189A26CC0-0x0000000189A26CE0
		internal static void OnApplicationFocus(bool focusState) {} // 0x00000001870D70B0-0x00000001870D7200
		// [XID] // 0x0000000189A2E430-0x0000000189A2E450
		internal static void OnApplicationPause(bool pauseState) {} // 0x00000001870D7200-0x00000001870D72A0
		// [XID] // 0x000000018996FFC0-0x000000018996FFE0
		internal static void OnApplicationQuit() {} // 0x00000001870D72A0-0x00000001870D7360
		// [XID] // 0x00000001899599F0-0x0000000189959A10
		internal static void OnLevelWasLoaded() {} // 0x00000001870D7360-0x00000001870D7420
		// [XID] // 0x0000000189A44B40-0x0000000189A44B60
		public static void AddDeviceManager(InputDeviceManager deviceManager) {} // 0x00000001870D5B80-0x00000001870D5DD0
		public static void AddDeviceManager<T>()
			where T : InputDeviceManager, new() {}
		public static T GetDeviceManager<T>()
			where T : InputDeviceManager => default;
		public static bool HasDeviceManager<T>()
			where T : InputDeviceManager => default;
		// [XID] // 0x0000000189A4C2A0-0x0000000189A4C2C0
		private static void UpdateCurrentTime() {} // 0x00000001870D81E0-0x00000001870D83A0
		// [XID] // 0x0000000189A53A30-0x0000000189A53A50
		private static void UpdateDeviceManagers(float deltaTime) {} // 0x00000001870D83A0-0x00000001870D8540
		// [XID] // 0x0000000189A5B100-0x0000000189A5B120
		private static void DestroyDeviceManagers() {} // 0x00000001870D6840-0x00000001870D6A30
		// [XID] // 0x0000000189A62980-0x0000000189A629A0
		private static void DestroyDevices() {} // 0x00000001870D6A30-0x00000001870D6C30
		// [XID] // 0x0000000189A6A700-0x0000000189A6A720
		private static void UpdateDevices(float deltaTime) {} // 0x00000001870D8540-0x00000001870D8760
		// [XID] // 0x0000000189A71C10-0x0000000189A71C30
		private static void CommitDevices(float deltaTime) {} // 0x00000001870D65E0-0x00000001870D6840
		// [XID] // 0x0000000189A795B0-0x0000000189A795D0
		private static void UpdateActiveDevice() {} // 0x00000001870D7F90-0x00000001870D81E0
		// [XID] // 0x0000000189A80DF0-0x0000000189A80E10
		public static void AttachDevice(InputDevice inputDevice) {} // 0x00000001870D5EC0-0x00000001870D6200
		// [XID] // 0x0000000189A886A0-0x0000000189A886C0
		public static void DetachDevice(InputDevice inputDevice) {} // 0x00000001870D6C30-0x00000001870D6E90
		// [XID] // 0x00000001897941E0-0x0000000189794200
		public static void HideDevicesWithProfile(System.Type type) {} // 0x00000001870D6F80-0x00000001870D70B0
		// [XID] // 0x0000000189A978B0-0x0000000189A978D0
		internal static void AttachPlayerActionSet(PlayerActionSet playerActionSet) {} // 0x00000001870D6200-0x00000001870D6340
		// [XID] // 0x0000000189A2C980-0x0000000189A2C9A0
		internal static void DetachPlayerActionSet(PlayerActionSet playerActionSet) {} // 0x00000001870D6E90-0x00000001870D6F80
		// [XID] // 0x0000000189AA65C0-0x0000000189AA65E0
		internal static void UpdatePlayerActionSets(float deltaTime) {} // 0x00000001870D8B20-0x00000001870D8CB0
	}
}
