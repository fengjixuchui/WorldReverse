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
using Rewired.Data.Mapping;
using Rewired.Interfaces;
using Rewired.Platforms.Custom;

// Image 39: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3466-4436

namespace Rewired.InputManagers
{
	[CustomClassObfuscation] // 0x0000000189699A10-0x0000000189699A60
	[CustomObfuscation] // 0x0000000189699A10-0x0000000189699A60
	internal class CustomInputManager : PlatformInputManager // TypeDefIndex: 4093
	{
		// Fields
		private List<hwJtYWPMGvWQzlewoWRSkOkcSeW> AVRtfMRpOzQlHvmKXxpZoBGaQUn; // 0x38
		private int xrSChNBBhEWHvkeIhZBjNmkdZsmA; // 0x40
		private NIOXrqHRlxHlUMLPLEvYiqbHqqY VYIiPbQDTfmyzeeKLOEXjAUgGAe; // 0x48
		private UpdateLoopType xFKjhyBYBeaXHwQfmSuqSKfAFpj; // 0x50
		private Action<int, ControllerDataUpdater> EpczCkvPPKAdjiQfdfFMvZxBJnNl; // 0x58
		private PlatformInputManager SUAsPHGFrajzPXFANEuqbUoeMlU; // 0x60
		private CustomInputSource LIUEXihIfwBszLMEBQZCkixZlBNJ; // 0x68
		private bool LDAcgYOFyYXGHPLDHfJvYGEiUNl; // 0x70
		private Func<BridgedControllerHWInfo, HardwareJoystickMap_InputManager> brkuSOIQTXGziCshBbHdBPqhLfY; // 0x78
		private Func<int> wHXHOjgCCjfwhXpVEAfBjzTabcoI; // 0x80
	
		// Properties
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		public override PlatformInputManager primaryInputManager { get => default; } // 0x00000001858224A0-0x0000000185822500 
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		public override IInputSource inputSource { get => default; } // 0x0000000185822450-0x00000001858224A0 
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		public override InputSource inputSourceType { get => default; } // 0x00000001858223D0-0x0000000185822450 
	
		// Nested types
		private class hwJtYWPMGvWQzlewoWRSkOkcSeW : IInputManagerJoystick // TypeDefIndex: 4094
		{
			// Fields
			private readonly InputSource CpNbHtCijSICCnUFhUdnSnuZaCd; // 0x10
			private readonly CustomInputSource LIUEXihIfwBszLMEBQZCkixZlBNJ; // 0x18
			private readonly Controller.Extension RlhCPmWdFbcKPPhKmYBnLApskyE; // 0x20
			private int TcKoYfigmhWFfimOKaOKeTOPnAQ; // 0x28
			private int QovxBPKLdqHelKEcdGLoDhrEJtsP; // 0x2C
			private long? JJkBjQCiHgwWIGHDBEAYPgCRjNJZ; // 0x30
			private int YAsnSUHUHZSXPqVPdYXTHFQokii; // 0x40
			public Guid ReLSneGtMGimyQaICDlebjstllEH; // 0x44
			public string HWvaGjNRcIhWnCcVIEFLqoJYRNaT; // 0x58
			public string pccpuiYVhbzFZAkrQDaoogDJfQI; // 0x60
			private int TwhUkSEboxGPsJgqbpmupSCMcvva; // 0x68
			private int SgYwVaEgtCZiUkgVDcTwJWbyDTtb; // 0x6C
			private float[] TEOYPaJNdnEWbgWRoihqYehIhMK; // 0x70
			private bool[] pcgUSJiXRsTNqMrGSyukNhNuJeO; // 0x78
			private HardwareJoystickMap_InputManager RCNejcvnZtMAmgendVbiwgNYmdD; // 0x80
			public CustomInputSource.Joystick qLQcDJQUVrdpzmenxwkmEnDiEkr; // 0x88
			private bool BvBiBtBhorGlOOqcvDhVgnidONSn; // 0x90
			private Func<BridgedControllerHWInfo, HardwareJoystickMap_InputManager> brkuSOIQTXGziCshBbHdBPqhLfY; // 0x98
	
			// Properties
			public int iseCLQKKKNFGEzGoUHhRwvJfUWj { get => default; } // 0x00000001858450F0-0x0000000185845160 
			public int bfRBSyiMEnqYkaJuaERXkSDgrMIl { get => default; } // 0x0000000185845080-0x00000001858450F0 
			[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
			public int rewiredId { get => default; set {} } // 0x00000001858454C0-0x0000000185845520 0x0000000185845650-0x00000001858456B0
			[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
			public int inputManagerId { get => default; set {} } // 0x0000000185845160-0x00000001858451C0 0x00000001858455F0-0x0000000185845650
			[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
			public string name { get => default; } // 0x0000000185845330-0x0000000185845440 
			[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
			public long? systemId { get => default; } // 0x0000000185845520-0x0000000185845590 
			[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
			public int unityId { get => default; } // 0x0000000185845590-0x00000001858455F0 
			[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
			public Guid instanceGuid { get => default; } // 0x00000001858451C0-0x0000000185845330 
			[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
			public Guid persistentGuid { get => default; } // 0x0000000185845440-0x00000001858454C0 
			[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
			public Controller.Extension extension { get => default; } // 0x0000000185845020-0x0000000185845080 
	
			// Constructors
			public hwJtYWPMGvWQzlewoWRSkOkcSeW() {} // Dummy constructor
			public hwJtYWPMGvWQzlewoWRSkOkcSeW(CustomInputSource customInputSource, long? systemJoystickId, int unityJoystickId, CustomInputSource.Joystick joystick, InputSource inputSource, Controller.Extension controllerExtension, Func<BridgedControllerHWInfo, HardwareJoystickMap_InputManager> getHardwareJoystickMap_InputManager) {} // 0x0000000185844820-0x0000000185844AA0
	
			// Methods
			[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
			public void SetVibration(float amount, int motorIndex) {} // 0x0000000185844110-0x0000000185844160
			[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
			public void StopVibration() {} // 0x0000000185844160-0x00000001858441B0
			public void HrCUbqPxwDZdLCwtaDJbCdJebrq() {} // 0x0000000185843D10-0x0000000185843D90
			[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
			public void Update() {} // 0x0000000185844390-0x0000000185844420
			public int CGvNMgTtJKByfBoLCudPLkyvgkV(hwJtYWPMGvWQzlewoWRSkOkcSeW param_00008836) => default; // 0x0000000185843750-0x0000000185843900
			private void azaIOTDxGZMNUjlkOgiJDaxzXhfj(BridgedControllerHWInfo param_00008837) {} // 0x0000000185844AA0-0x0000000185844B60
			private void azaIOTDxGZMNUjlkOgiJDaxzXhfj(BridgedController param_00008838) {} // 0x0000000185844B60-0x0000000185844CA0
			[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
			public void FillData(ControllerDataUpdater dataUpdater) {} // 0x0000000185843900-0x0000000185843B70
			public BridgedControllerHWInfo JBMvgOBJziXYPUQkaqihlBPPMXw() => default; // 0x0000000185843D90-0x0000000185843ED0
			[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
			public BridgedController ToBridgedController() => default; // 0x0000000185844270-0x0000000185844300
			[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
			public ControllerDisconnectedEventArgs ToControllerDisconnectedEventArgs() => default; // 0x0000000185844300-0x0000000185844390
			private void ACWFShdsqMXYShMhIOVlhqSySfj() {} // 0x0000000185843450-0x0000000185843750
			private void bWqXMuWKIQJCfsxGeWCQkichWXy() {} // 0x0000000185844CA0-0x0000000185844F80
			private bool uzIVkYjEcCOqJgyQjMKkDXWAHmv(HardwareJoystickMap.Platform_Custom.Button param_0000883a) => default; // 0x00000001858456B0-0x00000001858457C0
			private float MZBONfLuZbixRkBmJqUhwMoksCq(HardwareJoystickMap.Platform_Custom.Axis param_0000883b) => default; // 0x0000000185843F70-0x0000000185844110
			private float MZBONfLuZbixRkBmJqUhwMoksCq(int param_0000883c) => default; // 0x0000000185843ED0-0x0000000185843F70
			private bool uzIVkYjEcCOqJgyQjMKkDXWAHmv(int param_0000883d) => default; // 0x00000001858457C0-0x0000000185845850
			private void TiLfIVyvvCkOyWkDMxfDMSbgDnI() {} // 0x00000001858441B0-0x0000000185844270
			private string ZrEWBQNwcFIqvIYkQITbufsXcXR() => default; // 0x0000000185844420-0x0000000185844820
			public static int cDhwtjWQhSyIsxMLQDmPyGiSilw(hwJtYWPMGvWQzlewoWRSkOkcSeW param_0000883e, hwJtYWPMGvWQzlewoWRSkOkcSeW param_0000883f) => default; // 0x0000000185844F80-0x0000000185845020
			public static int HfjbDlQkUgfXzKVWUYDQEmjeIIYF(hwJtYWPMGvWQzlewoWRSkOkcSeW param_00008840, hwJtYWPMGvWQzlewoWRSkOkcSeW param_00008841) => default; // 0x0000000185843B70-0x0000000185843D10
		}
	
		private class NIOXrqHRlxHlUMLPLEvYiqbHqqY // TypeDefIndex: 4095
		{
			// Fields
			private List<iGzxVnYmiJOurfvDweKkwKhmTCJ> rokTPxsNitEbJnvAHMxvBQpZKze; // 0x10
	
			// Nested types
			public enum igFlsUZdiaAWHzaPiGtekcNHjYY // TypeDefIndex: 4096
			{
				fyLkgCmTpqIuMAMCxJOMkArnGwx = 0,
				DVvUbKVHsTUhKpitpaArZixJgbT = 1
			}
	
			public class iGzxVnYmiJOurfvDweKkwKhmTCJ // TypeDefIndex: 4097
			{
				// Fields
				public int YZYerWLyrZezITIzzsjvGpplKQw; // 0x10
				public long? epEMcgGdkeNUGkKEiGsNlqGuKTx; // 0x18
				public string KrSAaeDrfQehorfbrYOtierIUgu; // 0x28
				public int GWoLlqegGvGyTtMNhZYqvtRENGv; // 0x30
				public int SgYwVaEgtCZiUkgVDcTwJWbyDTtb; // 0x34
				public int TwhUkSEboxGPsJgqbpmupSCMcvva; // 0x38
	
				// Constructors
				public iGzxVnYmiJOurfvDweKkwKhmTCJ() {} // Dummy constructor
				public iGzxVnYmiJOurfvDweKkwKhmTCJ(int rewiredId, long? systemId, string systemControllerName, int lastInputManagerId, int buttonCount, int axisCount) {} // 0x0000000185845AF0-0x0000000185845BB0
	
				// Methods
				public bool CGvNMgTtJKByfBoLCudPLkyvgkV(hwJtYWPMGvWQzlewoWRSkOkcSeW param_0000884d, igFlsUZdiaAWHzaPiGtekcNHjYY param_0000884e) => default; // 0x0000000185845850-0x0000000185845AF0
			}
	
			// Constructors
			public NIOXrqHRlxHlUMLPLEvYiqbHqqY() {} // 0x000000018583D220-0x000000018583D2B0
	
			// Methods
			public void hGoGXvVewDdznIUDiLVJVGFrUsD(hwJtYWPMGvWQzlewoWRSkOkcSeW param_00008842) {} // 0x000000018583D2B0-0x000000018583DA50
			public iGzxVnYmiJOurfvDweKkwKhmTCJ OlRyGPawIBmfpGbjKDHJQXdzfaeG(hwJtYWPMGvWQzlewoWRSkOkcSeW param_00008843, igFlsUZdiaAWHzaPiGtekcNHjYY param_00008844) => default; // 0x000000018583D0E0-0x000000018583D220
			private void BfoPnOzEfehguKuapcNsLLRRhsb(int param_00008845, int param_00008846) {} // 0x000000018583CF70-0x000000018583D0E0
		}
	
		// Constructors
		public CustomInputManager() {} // Dummy constructor
		public CustomInputManager(CustomInputSource customInputSource, UpdateLoopSetting updateLoopSetting, Func<BridgedControllerHWInfo, HardwareJoystickMap_InputManager> getHardwareJoystickMap_InputManager, Func<int> getNewJoystickId) {} // 0x0000000185822230-0x00000001858223D0
	
		// Methods
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		public override void Initialize() {} // 0x0000000185820FA0-0x0000000185821060
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		public override void Update(UpdateLoopType updateLoop) {} // 0x0000000185822060-0x0000000185822170
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		public override void OnDestroy() {} // 0x00000001858214F0-0x0000000185821560
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		public override Action<int, ControllerDataUpdater> GetInputDataUpdateDelegate() => default; // 0x0000000185820EA0-0x0000000185820F00
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		public override void UpdateControllerData(int inputManagerId, ControllerDataUpdater data) {} // 0x0000000185821EC0-0x0000000185822060
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		public override void SystemDeviceConnected() {} // 0x0000000185821D90-0x0000000185821E00
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		public override void SystemDeviceDisconnected() {} // 0x0000000185821E00-0x0000000185821EC0
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		public override void SetUnityJoystickId(int joystickId, int unityJoystickIndex) {} // 0x0000000185821C20-0x0000000185821C70
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		public override IUnifiedMouseSource GetUnifiedMouseSource() => default; // 0x0000000185820F50-0x0000000185820FA0
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		public override IUnifiedKeyboardSource GetUnifiedKeyboardSource() => default; // 0x0000000185820F00-0x0000000185820F50
		private void MBWbLtwiramKtsVixhpKLRHaVam(CustomInputSource.Joystick[] param_00008811) {} // 0x0000000185821060-0x00000001858214F0
		private void njzLgbngHRtFtusDoWSXPlqSohr() {} // 0x0000000185822E40-0x0000000185822F00
		private void SAHmPdomeKmRmWDMHYyWboYkaxQ(int param_00008812, int param_00008813, List<hwJtYWPMGvWQzlewoWRSkOkcSeW> param_00008814, List<hwJtYWPMGvWQzlewoWRSkOkcSeW> param_00008815) {} // 0x0000000185821560-0x0000000185821970
		private bool tdJERshKrZupAABGOtPFZhjIApQ(List<hwJtYWPMGvWQzlewoWRSkOkcSeW> param_00008816, int param_00008817) => default; // 0x0000000185823050-0x00000001858231A0
		private int lthALbyMafUeFUSoDiwZaXONIhC(List<hwJtYWPMGvWQzlewoWRSkOkcSeW> param_00008818) => default; // 0x0000000185822C40-0x0000000185822E40
		private bool reYntWceOkPUZwwqHtuPFEoKbLb(List<hwJtYWPMGvWQzlewoWRSkOkcSeW> param_00008819, int param_0000881a) => default; // 0x0000000185822F00-0x0000000185823050
		private void CJTiCwRYBKtdCjdVGCYyAKtmlkc(int param_0000881b, List<hwJtYWPMGvWQzlewoWRSkOkcSeW> param_0000881c, int param_0000881d, List<hwJtYWPMGvWQzlewoWRSkOkcSeW> param_0000881e, NIOXrqHRlxHlUMLPLEvYiqbHqqY.igFlsUZdiaAWHzaPiGtekcNHjYY param_0000881f) {} // 0x00000001858207B0-0x0000000185820BD0
		private void SWJVUJtNevBpHELnpTBupupzivbg(int param_00008820, List<hwJtYWPMGvWQzlewoWRSkOkcSeW> param_00008821, NIOXrqHRlxHlUMLPLEvYiqbHqqY.igFlsUZdiaAWHzaPiGtekcNHjYY param_00008822) {} // 0x0000000185821970-0x0000000185821C20
		private void YUdSTENKKNoVxApSKeakGqiLoBfc() {} // 0x0000000185822170-0x0000000185822230
		private bool hXJLHlYsxiqopPvGhwftUXQBvzA(CustomInputSource.Joystick[] param_00008823) => default; // 0x0000000185822500-0x0000000185822B80
		private void DtOBegFLamhBKwlmzaaiccPahGxz(List<hwJtYWPMGvWQzlewoWRSkOkcSeW> param_00008824, List<hwJtYWPMGvWQzlewoWRSkOkcSeW> param_00008825, bool param_00008826) {} // 0x0000000185820BD0-0x0000000185820EA0
		private void jdgXxQHlYgOTDPrZOCVnfSFXUtzk(hwJtYWPMGvWQzlewoWRSkOkcSeW param_00008827, bool param_00008828) {} // 0x0000000185822B80-0x0000000185822C40
		private void SfHMDdlcsbsFEPyvTjkIDMcxypA(hwJtYWPMGvWQzlewoWRSkOkcSeW param_00008829, bool param_0000882a) {} // 0x0000000185821C70-0x0000000185821D90
	}
}
