/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired;
using Rewired.Data;
using Rewired.Interfaces;
using Rewired.Platforms;
using Rewired.Utils.Classes.Data;

// Image 49: Rewired_Windows.dll - Assembly: Rewired_Windows, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5537-5827

internal class nWJFPaVEAnZVBaejiLScyIzPghU : PlatformInputManager, INativePlatformHelper // TypeDefIndex: 5571
{
	// Fields
	private bool GBctTtambVDrGmgNSbmaIAPqDQOB; // 0x38
	private object ScaoHuMpMofBBaGWUobGOdXOUuW; // 0x40
	private IndexedDictionary<int, PlatformInputManager> sZWipCUIkBegsboAzpAHXTWLekVx; // 0x48
	private ARRucpJRKUKoSdGATgCNJjOfktn ORpudJDiNZbxKbDCuzLHUTXZHvp; // 0x50
	private Action<int, ControllerDataUpdater> OtrNTBJIBbQldvImDmKCAqMRnke; // 0x58
	private WindowsStandalonePrimaryInputSource HvbwQpLWvlHhzesvauyRQhaFsGf; // 0x60
	private bool zNuiUQNevHIfHsLnzwvAmMNDBUC; // 0x64
	private PlatformInputManager KbZxDysFPLnvPkdChDFikEdaiLpJ; // 0x68
	private Func<BridgedControllerHWInfo, HardwareJoystickMap_InputManager> lvntcpgdZsSbabccpIcfMpTzYYr; // 0x70
	private Func<int> osCAPAIYOEZodlsEwtiFRgmwudTL; // 0x78

	// Properties
	bool pvtdRHkZIdLmRuETybLvtPgmZiX { get => default; } // 0x0000000183E99950-0x0000000183E99A50 
	[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
	public override PlatformInputManager primaryInputManager { get => default; } // 0x0000000183E9AA30-0x0000000183E9AA90 
	[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
	public override IInputSource inputSource { get => default; } // 0x0000000183E9A9B0-0x0000000183E9AA30 
	[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
	public override InputSource inputSourceType { get => default; } // 0x0000000183E9A930-0x0000000183E9A9B0 

	// Nested types
	private class ARRucpJRKUKoSdGATgCNJjOfktn // TypeDefIndex: 5572
	{
		// Fields
		private List<OfWFqNGnpgKllEUZyCakcMZEYDQB> ETKdVHGzAHrBEHOveosWyulSJCY; // 0x10
		private List<OfWFqNGnpgKllEUZyCakcMZEYDQB> ekywolUbzMUKlzPKgGxbGKKvGVjB; // 0x18

		// Nested types
		private class OfWFqNGnpgKllEUZyCakcMZEYDQB // TypeDefIndex: 5573
		{
			// Fields
			public int KbfeRbzvruWiJePSeNvnucdAIpaa; // 0x10
			public int uDkwQcXcrzYWBtuasJBXMAbjLxg; // 0x14
			public int bhcorCpMDigwrANbPyxcozuALLI; // 0x18
			public InputSource GopNkYanAGUkOmQwUJuTJxkowKA; // 0x1C

			// Constructors
			public OfWFqNGnpgKllEUZyCakcMZEYDQB() {} // Dummy constructor
			public OfWFqNGnpgKllEUZyCakcMZEYDQB(int mapperId, int managerId, int id, InputSource source) {} // 0x0000000183E85850-0x0000000183E858F0

			// Methods
			public void OKHZGFMfxtklwLbZuCziRQFTDNac(int param_0000b087) {} // 0x0000000183E85720-0x0000000183E85780
			public hugBQjWsvPGLoXyvlxWTxnhoGCB SaKAccbdUMjLTbVoIiHDJZFPDTI() => default; // 0x0000000183E85780-0x0000000183E85850
			public static int mHvWMBkaDocYeuAguvlFsMCvjCf(OfWFqNGnpgKllEUZyCakcMZEYDQB param_0000b088, OfWFqNGnpgKllEUZyCakcMZEYDQB param_0000b089) => default; // 0x0000000183E858F0-0x0000000183E85990
		}

		public struct hugBQjWsvPGLoXyvlxWTxnhoGCB // TypeDefIndex: 5574
		{
			// Fields
			public int KbfeRbzvruWiJePSeNvnucdAIpaa; // 0x00
			public int uDkwQcXcrzYWBtuasJBXMAbjLxg; // 0x04
			public InputSource GopNkYanAGUkOmQwUJuTJxkowKA; // 0x08

			// Constructors
			public hugBQjWsvPGLoXyvlxWTxnhoGCB(int mapperId, int managerId, InputSource source) {
				KbfeRbzvruWiJePSeNvnucdAIpaa = default;
				uDkwQcXcrzYWBtuasJBXMAbjLxg = default;
				GopNkYanAGUkOmQwUJuTJxkowKA = default;
			} // 0x0000000183E98500-0x0000000183E98830
		}

		public enum RNjCJjtqhaADDEkPlZxyCjIZPqW // TypeDefIndex: 5575
		{
			OPrDnVhLcontoTptCznHaDrwNsAh = 0,
			xqyuuQSofyjoJulEXgAcFSYaDtu = 1
		}

		// Constructors
		public ARRucpJRKUKoSdGATgCNJjOfktn() {} // 0x0000000183E7FFA0-0x0000000183E80050

		// Methods
		public void THjMgpRqkzsiJWNJfkDjpONSJZu(BridgedController param_0000b074) {} // 0x0000000183E7F520-0x0000000183E7FB60
		public void wZoRTCniYGUlYCHRtxHNmxSLryr(ControllerDisconnectedEventArgs param_0000b075) {} // 0x0000000183E80150-0x0000000183E80270
		public void YFDRilQqmwEqtrRKfdFRFiCygbmW(int param_0000b076, int param_0000b077) {} // 0x0000000183E7FDD0-0x0000000183E7FFA0
		public int QfvcPTCkQKNaHrLDCOXTjZcrUbW(int param_0000b078, RNjCJjtqhaADDEkPlZxyCjIZPqW param_0000b079) => default; // 0x0000000183E7ED80-0x0000000183E7EFA0
		public int QfvcPTCkQKNaHrLDCOXTjZcrUbW(int param_0000b07a, InputSource param_0000b07b, RNjCJjtqhaADDEkPlZxyCjIZPqW param_0000b07c) => default; // 0x0000000183E7EFA0-0x0000000183E7F210
		public hugBQjWsvPGLoXyvlxWTxnhoGCB SaKAccbdUMjLTbVoIiHDJZFPDTI(int param_0000b07d, RNjCJjtqhaADDEkPlZxyCjIZPqW param_0000b07e) => default; // 0x0000000183E7F210-0x0000000183E7F520
		public int rqethfbsSWgvZeeAlkeMCErUAJVJ(int param_0000b07f, InputSource param_0000b080, RNjCJjtqhaADDEkPlZxyCjIZPqW param_0000b081) => default; // 0x0000000183E80050-0x0000000183E80150
		private int TbmwCthcnUohisaEvRQrIaIfyqz(int param_0000b082) => default; // 0x0000000183E7FB60-0x0000000183E7FC60
		private int TbmwCthcnUohisaEvRQrIaIfyqz() => default; // 0x0000000183E7FC60-0x0000000183E7FDD0
	}

	private class MVRGhtGnRlGvAeigHxrfgjCVzMAh : IInputManagerJoystickPublic // TypeDefIndex: 5576
	{
		// Fields
		private IInputManagerJoystickPublic kYVEkOHTXBhxnrAeWMuOTcRgNeH; // 0x10
		private int wYDIziyzWuiIHNegEDxTahMFRWS; // 0x18

		// Properties
		public int OHBcezjWhuCjOisuXXaxDLGlnPLC { get => default; } // 0x0000000183E854B0-0x0000000183E85530 
		public int WFUXmhRBckCbDRHpRAGmaMtCKor { get => default; } // 0x0000000183E85250-0x0000000183E852B0 
		public string UsaJBsMndDsVKbxcIGPPHpRVHEz { get => default; } // 0x0000000183E853B0-0x0000000183E85430 
		public long? yKTvfVojaXNAYZRXYpwFyxpcYNY { get => default; } // 0x0000000183E85530-0x0000000183E85630 
		public int NMaEvvhIbwgYobDmtufKAmzCxpwo { get => default; } // 0x0000000183E85630-0x0000000183E856B0 
		public Guid AptpRPzwmRXfndEyzaGRSilWIbv { get => default; } // 0x0000000183E852B0-0x0000000183E853B0 
		public Guid ecVBZmEHkutyRlUhQuGXIREeIZkP { get => default; } // 0x0000000183E85430-0x0000000183E854B0 
		public Controller.Extension EguyDwvLgpcJcfiEjCPMKoJsloj { get => default; } // 0x0000000183E851D0-0x0000000183E85250 

		// Constructors
		public MVRGhtGnRlGvAeigHxrfgjCVzMAh() {} // Dummy constructor
		public MVRGhtGnRlGvAeigHxrfgjCVzMAh(IInputManagerJoystickPublic sourceJoystick, int bridgeJoystickId) {} // 0x0000000183E85150-0x0000000183E851D0

		// Methods
		public void SetVibration(float amount, int motorIndex) {} // 0x0000000183E85030-0x0000000183E850D0
		public void StopVibration() {} // 0x0000000183E850D0-0x0000000183E85150
	}

	// Constructors
	public nWJFPaVEAnZVBaejiLScyIzPghU() {} // Dummy constructor
	public nWJFPaVEAnZVBaejiLScyIzPghU(ConfigVars configVars, Func<BridgedControllerHWInfo, HardwareJoystickMap_InputManager> getHardwareJoystickMap_InputManager, Func<int> getNewJoystickId) {} // 0x0000000183E9A0D0-0x0000000183E9A5E0

	// Methods
	private bool bAVNDtkqezUuZHjvzCILasTCWAbU(ConfigVars param_0000b062, kBhxdgWKVLsDoSoTBIFSYguIohE param_0000b063) => default; // 0x0000000183E9A5E0-0x0000000183E9A930
	private bool HYcmOvfCAgBjMWSsnjNXMAqiCSH(ConfigVars param_0000b064, kBhxdgWKVLsDoSoTBIFSYguIohE param_0000b065) => default; // 0x0000000183E98B70-0x0000000183E98D70
	private bool UIbmlZGokZHnZLfLtHxELklZHgPB(ConfigVars param_0000b066, kBhxdgWKVLsDoSoTBIFSYguIohE param_0000b067) => default; // 0x0000000183E99C10-0x0000000183E99E40
	private bool LfpiwBhSrvZSHbyDQmKrMiwRKycl(ConfigVars param_0000b068, bool param_0000b069) => default; // 0x0000000183E98F90-0x0000000183E99670
	[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
	public override void Initialize() {} // 0x0000000183E98D70-0x0000000183E98E90
	public override void Update(UpdateLoopType currentUpdateLoop) {} // 0x0000000183E99FD0-0x0000000183E9A0D0
	[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
	public override void OnDestroy() {} // 0x0000000183E99770-0x0000000183E99950
	[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
	public override Action<int, ControllerDataUpdater> GetInputDataUpdateDelegate() => default; // 0x0000000183E988D0-0x0000000183E98930
	[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
	public override void UpdateControllerData(int controllerId, ControllerDataUpdater data) {} // 0x0000000183E99E40-0x0000000183E99FD0
	[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
	public override void SystemDeviceConnected() {} // 0x0000000183E99B70-0x0000000183E99BC0
	[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
	public override void SystemDeviceDisconnected() {} // 0x0000000183E99BC0-0x0000000183E99C10
	[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
	public override void SetUnityJoystickId(int joystickId, int unityJoystickId) {} // 0x0000000183E99B20-0x0000000183E99B70
	[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
	public override IUnifiedMouseSource GetUnifiedMouseSource() => default; // 0x0000000183E98A60-0x0000000183E98B70
	[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
	public override IUnifiedKeyboardSource GetUnifiedKeyboardSource() => default; // 0x0000000183E98930-0x0000000183E98A60
	private void RzVkjckBjWKrizPraYLaXjSQeHO(BridgedController param_0000b06f) {} // 0x0000000183E99A50-0x0000000183E99B20
	private void msYtOZfUSWceIVqDuEmlhduflmJ(ControllerDisconnectedEventArgs param_0000b070) {} // 0x0000000183E9ADB0-0x0000000183E9AE80
	private void LKSYLFJpHwNdqWMWKHvYwTxufRi(EventArgs param_0000b071) {} // 0x0000000183E98E90-0x0000000183E98F90
	private void NThIGvXIPnHeOJoeuEquYrSCJKpg(EventArgs param_0000b072) {} // 0x0000000183E99670-0x0000000183E99770
	private void iUNPQhnLnJrHhPivHqDZWmcEqeu(UpdateControllerInfoEventArgs param_0000b073) {} // 0x0000000183E9AA90-0x0000000183E9ADB0
}

