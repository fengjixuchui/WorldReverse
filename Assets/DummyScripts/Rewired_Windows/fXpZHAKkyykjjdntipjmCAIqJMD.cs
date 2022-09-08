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
using Rewired.Config;
using Rewired.Data.Mapping;
using Rewired.Interfaces;
using Rewired.Libraries.SharpDX.DirectInput;
using Rewired.Platforms;
using Rewired.Utils.Classes.Data;
using Rewired.Utils.Classes.Utility;

// Image 49: Rewired_Windows.dll - Assembly: Rewired_Windows, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5537-5827

internal class fXpZHAKkyykjjdntipjmCAIqJMD : PlatformInputManager, kxzXTdiJorHKVUHhoBvSNMIscik // TypeDefIndex: 5551
{
	// Fields
	private IntPtr kBhJxALdxxcEFwejpLfeqaTmQiT; // 0x38
	private DirectInput fTUmdlBklWTlvmAQYJjrEkdriSN; // 0x40
	private List<dIYfxShIDrIIjihOcmVToKsXwFAE> SECqOtxIJCMtDAXMpkZHtbqiXBU; // 0x48
	private int lTHFykxDvdBXxFWZTYErzFFjdVX; // 0x50
	private SNRBnIgKAMRWqTrKMMmcCoNDyKKd BhZbSIqTJUuvrHhjvLiLwhtaXiV; // 0x58
	private bool FHTzXxeconPJZctSzyqbRpvkXVQ; // 0x60
	private bool ydtjoUaZMACQbAJqHjVabQJcAHgE; // 0x61
	private UpdateLoopSetting ZIxZgRHVxCjXhlcarovUBuZCOqL; // 0x64
	private Action<int, ControllerDataUpdater> OtrNTBJIBbQldvImDmKCAqMRnke; // 0x68
	private PlatformInputManager KbZxDysFPLnvPkdChDFikEdaiLpJ; // 0x70
	private TimerRealTime BAQCuUxBdKKwqZqjVZdkRBTPwCh; // 0x78
	private LLwWBrlwrzAzBgxVkRCTkMClAyJ<bool> VoIiwUWpoGaVvQsOVAciVQBmthy; // 0x80
	private int OwMjmoZZHJWflbLcoFaXqkXbfGXF; // 0x88
	private int YTrkqMmqoBacvniXMdDSHcGseeHl; // 0x8C
	private LLwWBrlwrzAzBgxVkRCTkMClAyJ<List<yEHdWYdkyWyGSJOAPHTXOhczDmY>> aigQAbLwpFCjkyEbDcZhCTMWhkgb; // 0x90
	private AfFMTnVPQxUPOqejxvzYqfCgiwU mAbSqZKATNFUhWPMtuukNHRYGVi; // 0x98
	private readonly object OwdBRVkoLEeNZyygHCLZABIQljTX; // 0xA0
	private Func<BridgedControllerHWInfo, HardwareJoystickMap_InputManager> lvntcpgdZsSbabccpIcfMpTzYYr; // 0xA8
	private Func<int> osCAPAIYOEZodlsEwtiFRgmwudTL; // 0xB0

	// Properties
	public bool zNuiUQNevHIfHsLnzwvAmMNDBUC { set {} } // 0x0000000183F2BDA0-0x0000000183F2BE00
	[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
	public override PlatformInputManager primaryInputManager { get => default; } // 0x0000000183F2AD30-0x0000000183F2AD90 
	[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
	public override IInputSource inputSource { get => default; } // 0x0000000183F2ACA0-0x0000000183F2AD30 
	[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
	public override InputSource inputSourceType { get => default; } // 0x0000000183F2AC50-0x0000000183F2ACA0 

	// Nested types
	private class dIYfxShIDrIIjihOcmVToKsXwFAE : IInputManagerJoystick // TypeDefIndex: 5552
	{
		// Fields
		private int LHBzfOUukEAojNhzqhOUdcqBelx; // 0x10
		private int QSgOYisLlLVufpwxLNKaoIEBiyFd; // 0x14
		public Guid FHAzoTozCrisunLDoLyimqNbdex; // 0x18
		public string DHGYnLayswGyOaWIxJecDoLngmm; // 0x28
		public readonly JEiBJdqVetCaYhzGImdkvLHTeQyH kYVEkOHTXBhxnrAeWMuOTcRgNeH; // 0x30
		public rrkiWNHnEkzBYEXAvbDAWsEtjKd eMSAOLjJyVqyGYNCqvthQlWRDYcs; // 0x38
		public ofeqpRsjofXSwYwacxFrGdeWwcg ocqEYLgpYeVchwgaiKyLlHKhmSeI; // 0x40
		public string aQyubnFZjhaxoHtWxfehAEYaFOR; // 0x48
		public string SgtdGZiZKfxrYfEaONXeCdMIqIsz; // 0x50
		public int rFChCpBSHUoiIZbKWfsTCHUdRna; // 0x58
		public Guid mtlDBDFXTzxHqeXjvCJbhGtTMUCC; // 0x5C
		public Guid eTlTTlBmuxCORrngMaNsxFSpDyMi; // 0x6C
		public Guid AIefUprvkNeEvLSsrampirFfHMzU; // 0x7C
		public int iERVPkhRheIKptTuTmWgWiTZGxm; // 0x8C
		public bool HUFFKhqkxcIVKhtrxspNbGBrTdG; // 0x90
		public string ZYtBoPNuCmSlSLPglVVYiiIepKT; // 0x98
		public string ofHFJIxpUZEkaCUKTOBHGzIRSqW; // 0xA0
		public int gwfrHmNqxmYlnzynBGWAgujDDrf; // 0xA8
		public int rqeFUUCoNDfDgMOxuCDGnyLQlXi; // 0xAC
		public int dhEQLHuCYYGQwdehmJKXAJgttVWs; // 0xB0
		public int aCdTArmyUaJIYSBpkbuJpDufgNGc; // 0xB4
		public int JwvOuylcUYNAjPLMAAlyukWmToj; // 0xB8
		public bool IEIpySejupFvUUEVIERJEkDtdcvv; // 0xBC
		private float[] HwRqYBlbrIoKtVDOMNmmVOGCrNt; // 0xC0
		private bool[] xrmDwADRXdFsenTurfwlUsqsAvb; // 0xC8
		private HardwareJoystickMap_InputManager XCAyIFRJbEWUeBcnVweevmqWqtw; // 0xD0
		private Func<BridgedControllerHWInfo, HardwareJoystickMap_InputManager> lvntcpgdZsSbabccpIcfMpTzYYr; // 0xD8
		private bool cbEqXqyoXBYbIYeDgNacVLXtacu; // 0xE0
		private bool RZErYKzcoEvfMnhtHeFDeTWjAxp; // 0xE1
		private bool nYnvJCdSwCjafdvZoFKnjAkIRCs; // 0xE2

		// Properties
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		public int rewiredId { get => default; set {} } // 0x0000000183F1EEC0-0x0000000183F1EF20 0x0000000183F1FB90-0x0000000183F1FBF0
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		public int inputManagerId { get => default; set {} } // 0x0000000183F1EC50-0x0000000183F1ECB0 0x0000000183F1FB30-0x0000000183F1FB90
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		public string name { get => default; } // 0x0000000183F1ED20-0x0000000183F1EE10 
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		public long? systemId { get => default; } // 0x0000000183F1EF20-0x0000000183F1EFE0 
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		public int unityId { get => default; } // 0x0000000183F1EFE0-0x0000000183F1F030 
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		public Controller.Extension extension { get => default; } // 0x0000000183F1EC00-0x0000000183F1EC50 
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		public Guid instanceGuid { get => default; } // 0x0000000183F1ECB0-0x0000000183F1ED20 
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		public Guid persistentGuid { get => default; } // 0x0000000183F1EE10-0x0000000183F1EEC0 

		// Constructors
		public dIYfxShIDrIIjihOcmVToKsXwFAE() {} // Dummy constructor
		public dIYfxShIDrIIjihOcmVToKsXwFAE(JEiBJdqVetCaYhzGImdkvLHTeQyH sourceJoystick, Func<BridgedControllerHWInfo, HardwareJoystickMap_InputManager> getHardwareJoystickMap_InputManager) {} // 0x0000000183F1DEB0-0x0000000183F1DF40

		// Methods
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		public void SetVibration(float amount, int motorIndex) {} // 0x0000000183F1DA60-0x0000000183F1DAB0
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		public void StopVibration() {} // 0x0000000183F1DAB0-0x0000000183F1DB00
		public void qdrCNHHBSjMYElMPgHUagWNZcjH() {} // 0x0000000183F1F550-0x0000000183F1F7B0
		public void sHFWIJnFHmHJYIoFEDYPzPHrHZM(dIYfxShIDrIIjihOcmVToKsXwFAE param_0000af7b) {} // 0x0000000183F1F880-0x0000000183F1FB30
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		public void Update() {} // 0x0000000183F1DC20-0x0000000183F1DD30
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		public void FillData(ControllerDataUpdater dataUpdater) {} // 0x0000000183F1B340-0x0000000183F1B5A0
		public int QJuTPVbZPhckxeVMgmaDORJltri(dIYfxShIDrIIjihOcmVToKsXwFAE param_0000af7d) => default; // 0x0000000183F1C6A0-0x0000000183F1C8B0
		private BridgedControllerHWInfo PJFgAzlnjXDIFtIVMtyxcOgBHLL() => default; // 0x0000000183F1C2D0-0x0000000183F1C360
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		public BridgedController ToBridgedController() => default; // 0x0000000183F1DB00-0x0000000183F1DB90
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		public ControllerDisconnectedEventArgs ToControllerDisconnectedEventArgs() => default; // 0x0000000183F1DB90-0x0000000183F1DC20
		public bool IMlLKEcEdbfJWCtAPwVjQExfFyg() => default; // 0x0000000183F1BC60-0x0000000183F1BCF0
		public void ZrHcJGgwwvDxGfSwHIvyriZRodVX() {} // 0x0000000183F1DE00-0x0000000183F1DEB0
		private void IsHEPGDcapJjIIIwabNlagrgYHK(bool[] param_0000af7e, int[] param_0000af7f) {} // 0x0000000183F1BCF0-0x0000000183F1C010
		private void xEfKEFgwOpPyjRLoWJIEfoNdBYF(bool[] param_0000af80, int[] param_0000af81) {} // 0x0000000183F1FDB0-0x0000000183F200D0
		private void BnNUDmgtuAMaGYlEmQtjNSKwmsB(HardwareJoystickMap.Platform_RawOrDirectInput.Axis_Base param_0000af82, int param_0000af83, bool[] param_0000af84, int[] param_0000af85) {} // 0x0000000183F1B0D0-0x0000000183F1B280
		private void JQUOJFbbxdoZvdDiXaJFJTBTwATd(HardwareJoystickMap.Platform_RawOrDirectInput.Button_Base param_0000af86, int param_0000af87, bool[] param_0000af88, int[] param_0000af89) {} // 0x0000000183F1C140-0x0000000183F1C2D0
		private float QkOJeQjNoGuvJJcCjzkxhFnepjH(HardwareJoystickMap.Platform_RawOrDirectInput.Axis_Base param_0000af8a, bool[] param_0000af8b, int[] param_0000af8c) => default; // 0x0000000183F1C8B0-0x0000000183F1D090
		private float QkOJeQjNoGuvJJcCjzkxhFnepjH(DirectInputAxis param_0000af8d) => default; // 0x0000000183F1D090-0x0000000183F1DA60
		private bool eRRRbnNJkvBkNLMFRFRiaMhIthSB(HardwareJoystickMap.Platform_RawOrDirectInput.Button_Base param_0000af8e, bool[] param_0000af8f, int[] param_0000af90) => default; // 0x0000000183F1E130-0x0000000183F1EC00
		private float dmOmXokuwYPeqkLCCIorsBnvJVN(int param_0000af91) => default; // 0x0000000183F1E060-0x0000000183F1E130
		private bool uKCWXtJstxLBivpUoCOlAaKlIhZ(int param_0000af92, int param_0000af93, HatType param_0000af94) => default; // 0x0000000183F1FBF0-0x0000000183F1FDB0
		private float lsSCStiAfbFyneyGtxVQJHRkdst(int param_0000af95, AxisDirection param_0000af96) => default; // 0x0000000183F1F030-0x0000000183F1F120
		private bool dIGEjeJuOmivVcCLDIiTEFopnzx(HardwareJoystickMap.Platform_RawOrDirectInput.CustomCalculationSourceData param_0000af97, bool[] param_0000af98, out bool param_0000af99) {
			param_0000af99 = default;
			return default;
		} // 0x0000000183F1DF40-0x0000000183F1E060
		private bool GcXMSpyoZSbgVbAoeISEDqCbryIv(HardwareJoystickMap.Platform_RawOrDirectInput.CustomCalculationSourceData param_0000af9a, out float param_0000af9b) {
			param_0000af9b = default;
			return default;
		} // 0x0000000183F1B970-0x0000000183F1BC60
		private ControlDeviceType rJpjxFYmbdvFMSEGrDkWGiROwzK(ofeqpRsjofXSwYwacxFrGdeWwcg param_0000af9c) => default; // 0x0000000183F1F7B0-0x0000000183F1F880
		private void XCEcogOtFbmhupWduawPDMqkEjv() {} // 0x0000000183F1DD30-0x0000000183F1DE00
		private string PZXxsZWHUlpVhHySZrybyKpWWCD() => default; // 0x0000000183F1C360-0x0000000183F1C6A0
		private void qLdgPikrSeiPWSEbkkdRitWDfeYu(BridgedControllerHWInfo param_0000af9d) {} // 0x0000000183F1F350-0x0000000183F1F550
		private void qLdgPikrSeiPWSEbkkdRitWDfeYu(BridgedController param_0000af9e) {} // 0x0000000183F1F1D0-0x0000000183F1F350
		private UnknownControllerHat[] FsPEePPVDusMDfXPvWAmjGinMkk() => default; // 0x0000000183F1B650-0x0000000183F1B970
		public void JGfOaxGMMubjxaprhTWpWgtvAPZ() {} // 0x0000000183F1C010-0x0000000183F1C090
		~dIYfxShIDrIIjihOcmVToKsXwFAE() {} // 0x0000000183F1B5A0-0x0000000183F1B650
		protected virtual void JGfOaxGMMubjxaprhTWpWgtvAPZ(bool param_0000af9f) {} // 0x0000000183F1C090-0x0000000183F1C140
		public static int mHubPKenGxeOoCUpuEdJbdHQxjT(dIYfxShIDrIIjihOcmVToKsXwFAE param_0000afa0, dIYfxShIDrIIjihOcmVToKsXwFAE param_0000afa1) => default; // 0x0000000183F1F120-0x0000000183F1F1D0
		public static int BpwtCqMMoIuSANtUfTmfAKeytHL(dIYfxShIDrIIjihOcmVToKsXwFAE param_0000afa2, dIYfxShIDrIIjihOcmVToKsXwFAE param_0000afa3) => default; // 0x0000000183F1B280-0x0000000183F1B340
	}

	private class JEiBJdqVetCaYhzGImdkvLHTeQyH : IDisposable // TypeDefIndex: 5553
	{
		// Fields
		private readonly int nzQPtryKaFyOknbFWLAdBHgWTek; // 0x10
		private readonly ButtonLoopSet lOmtwKWetNmUEsKoXlYsIGMqOSm; // 0x18
		private readonly DualRingReportBuffer cEYnsvdZEgpKUOcsxEpoXmVeOaF; // 0x20
		public readonly hCkwWPjbZHHQuLPwssAiovZoKVX GopNkYanAGUkOmQwUJuTJxkowKA; // 0x28
		private readonly POJetljaOyAGVgWkwdAAfDSJZTf uusEcgeppnkfxZzSaLjQJXqkcop; // 0x30
		private eYQAacJaiYXVekhMtyuASsXijDU drjuHMWcKdKlbemNoyjAmboUjNJK; // 0x38
		private readonly POJetljaOyAGVgWkwdAAfDSJZTf CdNBOUzjNQHkoHsKxSFkQpBNaIxm; // 0x40
		private readonly object jkLokmyNuOlUdpUyyeSnDVevISp; // 0x48
		private byte[] rXYbyQgsCXdWzmrqPlgwHHWWNvN; // 0x50
		private byte[] siQVDcvmheIRNToTkUevWkMUmhZ; // 0x58
		private bool tNTCfSzrXJZuOnbCfNhelnFFgApE; // 0x60
		private POJetljaOyAGVgWkwdAAfDSJZTf klbCRyuWDYuOnexJoneNOUyWWSB; // 0x68
		private bool nYnvJCdSwCjafdvZoFKnjAkIRCs; // 0x70

		// Properties
		public bool[] RcmYlFLQWfhFSPuiyOlOkrEqCdq { get => default; } // 0x0000000184E15830-0x0000000184E158C0 
		public POJetljaOyAGVgWkwdAAfDSJZTf sxbzfBEFbDakzBpzzUxafldjvLD { get => default; } // 0x0000000184E158C0-0x0000000184E15920 

		// Constructors
		public JEiBJdqVetCaYhzGImdkvLHTeQyH() {} // Dummy constructor
		public JEiBJdqVetCaYhzGImdkvLHTeQyH(hCkwWPjbZHHQuLPwssAiovZoKVX source, UpdateLoopSetting updateLoops) {} // 0x0000000184E152A0-0x0000000184E15500

		// Methods
		public void WRFQiHBTiHTxzhBXcGRzCalCNF() {} // 0x0000000184E15170-0x0000000184E152A0
		public void aqqkTdOMGLHPIIcYrYTpjUXAOZk() {} // 0x0000000184E15500-0x0000000184E15590
		public void OPrDnVhLcontoTptCznHaDrwNsAh() {} // 0x0000000184E14EF0-0x0000000184E14F50
		public void xqyuuQSofyjoJulEXgAcFSYaDtu() {} // 0x0000000184E16540-0x0000000184E165B0
		public void sHFWIJnFHmHJYIoFEDYPzPHrHZM(JEiBJdqVetCaYhzGImdkvLHTeQyH param_0000afa6) {} // 0x0000000184E16150-0x0000000184E16540
		public void FADRItgConDiBPwOnuWeUubpqrE(int param_0000afa7, int param_0000afa8, int param_0000afa9, float param_0000afaa) {} // 0x0000000184E14950-0x0000000184E14A70
		private void JSZvpcfgZVssNtfXMVqTmNXDSqR() {} // 0x0000000184E14D70-0x0000000184E14EF0
		private void VjUBIeINpBMTOJuGDDvIKPqADtPr(POJetljaOyAGVgWkwdAAfDSJZTf param_0000afab) {} // 0x0000000184E14F50-0x0000000184E15170
		private void rqoXbSKhYdYHKMCJaGaXwTaoFLI(byte[] param_0000afac, POJetljaOyAGVgWkwdAAfDSJZTf param_0000afad) {} // 0x0000000184E15D30-0x0000000184E16150
		private void hmAIFTqyJhtHhQObXTFjgSWZcpk(POJetljaOyAGVgWkwdAAfDSJZTf param_0000afae, float param_0000afaf, byte[] param_0000afb0) {} // 0x0000000184E15920-0x0000000184E15D30
		private void IbWidGCHJzvyGGwvigfCOXYPcWYT() {} // 0x0000000184E14B20-0x0000000184E14C30
		private void fWzuAFjFXxdRoqxypOAIFkBEHOX(POJetljaOyAGVgWkwdAAfDSJZTf param_0000afb1) {} // 0x0000000184E15590-0x0000000184E15830
		public void Dispose() {} // 0x0000000184E148D0-0x0000000184E14950
		~JEiBJdqVetCaYhzGImdkvLHTeQyH() {} // 0x0000000184E14A70-0x0000000184E14B20
		protected virtual void JGfOaxGMMubjxaprhTWpWgtvAPZ(bool param_0000afb2) {} // 0x0000000184E14C30-0x0000000184E14D70
	}

	private class eYQAacJaiYXVekhMtyuASsXijDU // TypeDefIndex: 5554
	{
		// Fields
		private POJetljaOyAGVgWkwdAAfDSJZTf AQQBuhPBkvEbnDpgCTiKqhsmVHn; // 0x10
		private plIFIZcuOyAqDofRywyemFIDYuz aNxuOwNkMnMrcfIRbzZqikbRpVP; // 0x18
		private int UFMyvZuOvGRLlrHRlTyYGrnFbXG; // 0x20
		private int XXRwDByKoXBzHsHZofTwQeEjpsq; // 0x24
		private int FHKvoADmYLeloiYqNWlLablZoCLb; // 0x28
		private float NBxnxSmHhZCLsrJycOsQspCTAJU; // 0x2C

		// Properties
		public POJetljaOyAGVgWkwdAAfDSJZTf btlePRpiLIUfpxsQCTidJPkejeiF { get => default; } // 0x0000000184E24F40-0x0000000184E24FA0 

		// Constructors
		public eYQAacJaiYXVekhMtyuASsXijDU() {} // Dummy constructor
		public eYQAacJaiYXVekhMtyuASsXijDU(POJetljaOyAGVgWkwdAAfDSJZTf state, int axisMin, int axisMax, int axisZero, float eventTimeout) {} // 0x0000000184E24E60-0x0000000184E24F40
		private eYQAacJaiYXVekhMtyuASsXijDU(eYQAacJaiYXVekhMtyuASsXijDU source, POJetljaOyAGVgWkwdAAfDSJZTf state) {} // 0x0000000184E24D00-0x0000000184E24DC0
		private eYQAacJaiYXVekhMtyuASsXijDU(int axisMin, int axisMax, int axisZero, float axisTimeout) {} // 0x0000000184E24DC0-0x0000000184E24E60

		// Methods
		public static eYQAacJaiYXVekhMtyuASsXijDU FpyjssVeaQmrgiExuuKkNEPyEXF(eYQAacJaiYXVekhMtyuASsXijDU param_0000afb3, POJetljaOyAGVgWkwdAAfDSJZTf param_0000afb4) => default; // 0x0000000184E23C70-0x0000000184E23D10
		public void OKHZGFMfxtklwLbZuCziRQFTDNac(float param_0000afc0) {} // 0x0000000184E23D10-0x0000000184E24BA0
		public void RtgGaDkSVkhbZAgNmFrINPvRAMMC(eYQAacJaiYXVekhMtyuASsXijDU param_0000afc1) {} // 0x0000000184E24BA0-0x0000000184E24C70
		private int TUCCQSywVkXQVAClWcyYbUoTjhxJ(int param_0000afc2) => default; // 0x0000000184E24C70-0x0000000184E24D00
	}

	private class plIFIZcuOyAqDofRywyemFIDYuz // TypeDefIndex: 5555
	{
		// Fields
		private float urtBfQOEFguSLmTeSeGezKZCroD; // 0x10
		private POJetljaOyAGVgWkwdAAfDSJZTf DBtESFXFPndrqQDwpUqahmiVcmV; // 0x18
		private POJetljaOyAGVgWkwdAAfDSJZTf CmtOqmLgqCbTNcgkiXHsCdWMWFxq; // 0x20
		private POJetljaOyAGVgWkwdAAfDSJZTf ACTvGfPFinWFLpjsDMUKrJQNEtJK; // 0x28
		private bool ntMqOTmXAUudDwvbMpLZPfaqGmx; // 0x30
		private float rCNSTRKkChqiiwcZhJJYzbaaPhD; // 0x34

		// Properties
		public POJetljaOyAGVgWkwdAAfDSJZTf fnGeXMfTydPlDhXKEDrPJOVjsDaf { get => default; } // 0x0000000184E35510-0x0000000184E35570 
		public POJetljaOyAGVgWkwdAAfDSJZTf PdUVuRLOzxxszJpPqwALkeZYtLI { get => default; } // 0x0000000184E35440-0x0000000184E354A0 
		public bool aatAisilMcvMQfCsxBkQUYdXDSKh { get => default; } // 0x0000000184E35570-0x0000000184E355D0 
		public float AhFvYgZsSslBjCGUEscKxXOrRCC { get => default; } // 0x0000000184E354A0-0x0000000184E35510 

		// Constructors
		public plIFIZcuOyAqDofRywyemFIDYuz() {} // Dummy constructor
		public plIFIZcuOyAqDofRywyemFIDYuz(POJetljaOyAGVgWkwdAAfDSJZTf sourceState) {} // 0x0000000184E35390-0x0000000184E35440

		// Methods
		public void OKHZGFMfxtklwLbZuCziRQFTDNac(float param_0000afc4) {} // 0x0000000184E34110-0x0000000184E352B0
		public void RtgGaDkSVkhbZAgNmFrINPvRAMMC(plIFIZcuOyAqDofRywyemFIDYuz param_0000afc5) {} // 0x0000000184E352B0-0x0000000184E35390
		private bool LMgFGQGbhkQGddPcTcZCmevcMnre() => default; // 0x0000000184E33790-0x0000000184E34110
	}

	private class SNRBnIgKAMRWqTrKMMmcCoNDyKKd // TypeDefIndex: 5556
	{
		// Fields
		private List<AnjAepQmDzjzNYGnHJNnxdhxpUp> hdvnYESDqWrpDISRbrulIlAPAqTj; // 0x10

		// Nested types
		public enum DIWJVETWaPFFkudLyHFYfVbJqns // TypeDefIndex: 5557
		{
			pcWfOxYbvNCAItRmLAyYfYdvnxE = 0,
			JgYTOGxxNXCOjMYfJlJOWIFnveY = 1
		}

		public class AnjAepQmDzjzNYGnHJNnxdhxpUp // TypeDefIndex: 5558
		{
			// Fields
			public int OHBcezjWhuCjOisuXXaxDLGlnPLC; // 0x10
			public Guid AptpRPzwmRXfndEyzaGRSilWIbv; // 0x14
			public Guid AIefUprvkNeEvLSsrampirFfHMzU; // 0x24
			public int WppCCSIJiYbWggCDNrMGswGEsUzA; // 0x34
			public int dhEQLHuCYYGQwdehmJKXAJgttVWs; // 0x38
			public int aCdTArmyUaJIYSBpkbuJpDufgNGc; // 0x3C
			public int JwvOuylcUYNAjPLMAAlyukWmToj; // 0x40

			// Constructors
			public AnjAepQmDzjzNYGnHJNnxdhxpUp() {} // 0x0000000184E13320-0x0000000184E133A0

			// Methods
			public bool QJuTPVbZPhckxeVMgmaDORJltri(dIYfxShIDrIIjihOcmVToKsXwFAE param_0000afcc, DIWJVETWaPFFkudLyHFYfVbJqns param_0000afcd) => default; // 0x0000000184E121F0-0x0000000184E123F0
			public override string ToString() => default; // 0x0000000184E123F0-0x0000000184E13320
		}

		// Constructors
		public SNRBnIgKAMRWqTrKMMmcCoNDyKKd() {} // 0x0000000184E20E80-0x0000000184E20F30

		// Methods
		public void xdxZeKjdcofLtxWSQEJXMnutFBg(dIYfxShIDrIIjihOcmVToKsXwFAE param_0000afc6) {} // 0x0000000184E20F30-0x0000000184E213E0
		public AnjAepQmDzjzNYGnHJNnxdhxpUp GAYuJaWQWiVlljmcwLCVJqAlvzZ(dIYfxShIDrIIjihOcmVToKsXwFAE param_0000afc7, DIWJVETWaPFFkudLyHFYfVbJqns param_0000afc8) => default; // 0x0000000184E205D0-0x0000000184E20720
		private void TxZIpUDzPauiBdjCLSiYGapVtMo(int param_0000afc9, Guid param_0000afca, int param_0000afcb) {} // 0x0000000184E20C80-0x0000000184E20E80
		public override string ToString() => default; // 0x0000000184E20720-0x0000000184E20C80
	}

	private class yEHdWYdkyWyGSJOAPHTXOhczDmY // TypeDefIndex: 5559
	{
		// Fields
		public dIYfxShIDrIIjihOcmVToKsXwFAE PSZKcVVfVmWuwyrmRaPnqSTTRBB; // 0x10
		public rrkiWNHnEkzBYEXAvbDAWsEtjKd eMSAOLjJyVqyGYNCqvthQlWRDYcs; // 0x18

		// Properties
		public bool dVqgpUEVoGqAkyEaepBNdkHiJiHI { get => default; } // 0x0000000184E35F90-0x0000000184E36060 

		// Constructors
		public yEHdWYdkyWyGSJOAPHTXOhczDmY() {} // Dummy constructor
		public yEHdWYdkyWyGSJOAPHTXOhczDmY(dIYfxShIDrIIjihOcmVToKsXwFAE joystick, rrkiWNHnEkzBYEXAvbDAWsEtjKd deviceInstance) {} // 0x0000000184E35F00-0x0000000184E35F90

		// Methods
		public static List<rrkiWNHnEkzBYEXAvbDAWsEtjKd> UieSsnNFHvINJjksbsFwJrDIsvpy(List<yEHdWYdkyWyGSJOAPHTXOhczDmY> param_0000afd0) => default; // 0x0000000184E35D90-0x0000000184E35F00
	}

	private class AfFMTnVPQxUPOqejxvzYqfCgiwU // TypeDefIndex: 5560
	{
		// Fields
		private SbNYhPrwpuilnaawmyzrqxOYOrb.ijmFMIGSvWXIvotifQvkDuUFLNiP cPErUQMyQQeOcFpoAaqqgcGDnYp; // 0x10
		private SbNYhPrwpuilnaawmyzrqxOYOrb.xPIZmsiJWcOKbvMDvhnNNsuhCYqg gPxtLMVNCvmeZGPesEFNaOrOfDgS; // 0x28
		private NativeBuffer KrkhvmMqkwmcpCzJkDiQzmIldHfC; // 0x68
		private int ZxdeZYTjmFLtKTfBipmShpqvEFO; // 0x70

		// Constructors
		public AfFMTnVPQxUPOqejxvzYqfCgiwU() {} // 0x0000000183F09D70-0x0000000183F09F00

		// Methods
		public bool GdUSUoYPOUWZsVmDJtYnJAXVmkD() => default; // 0x0000000183F09D00-0x0000000183F09D70
		public void iAQSIxHcqRRCHTNIEjSyHMLdVpTN(int param_0000afd1) {} // 0x0000000183F09F00-0x0000000183F09F60
		private int EgEjAUhxDiCIDqLRLKYENeXGoQHA() => default; // 0x0000000183F09C60-0x0000000183F09D00
	}

	private enum ofeqpRsjofXSwYwacxFrGdeWwcg // TypeDefIndex: 5561
	{
		JAPGXbnGLEVcKvOepfYKLDmQrgU = 17,
		UQBduDQfcpFVodDJGKokyQOHOEHN = 18,
		xASCPheTPZjjySaqzxbejdrWIOZ = 19,
		kwXecDUdPYUlNuDiMAoCcCImDZIb = 20,
		dhUtEzDFvpZQnDBlTeAFXyELNJz = 21,
		zYVdxJRhImBRPsxZlpigKIKyrqQ = 22,
		RSYxVUzovUaewdHaxOMnFaSnBhsn = 23,
		hRBNKMrZXnQBptDVtzuNwekIOCP = 24,
		SlnIqwRSRMUekRDlrBdtRtqdwSe = 25,
		aEssYEUSwmmnnJRGohZDlUogiil = 26,
		RRuAazCBOBmPmDtLyBqsTtgxRGXK = 27,
		ewucqLuFeGJENdbcYnPoncBlEqq = 28
	}

	// Constructors
	public fXpZHAKkyykjjdntipjmCAIqJMD() {} // Dummy constructor
	public fXpZHAKkyykjjdntipjmCAIqJMD(UpdateLoopSetting updateLoopSetting, bool useXInput, IntPtr windowHandle, Func<BridgedControllerHWInfo, HardwareJoystickMap_InputManager> getHardwareJoystickMap_InputManager, Func<int> getNewJoystickId) {} // 0x0000000183F296D0-0x0000000183F29950

	// Methods
	[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
	public override void Initialize() {} // 0x0000000183F28250-0x0000000183F28360
	[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
	public override void Update(UpdateLoopType updateLoop) {} // 0x0000000183F29370-0x0000000183F293F0
	[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
	public override void OnDestroy() {} // 0x0000000183F28CE0-0x0000000183F28F80
	[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
	public override Action<int, ControllerDataUpdater> GetInputDataUpdateDelegate() => default; // 0x0000000183F27B80-0x0000000183F27BE0
	[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
	public override void UpdateControllerData(int inputManagerId, ControllerDataUpdater data) {} // 0x0000000183F290F0-0x0000000183F29370
	[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
	public override void SystemDeviceConnected() {} // 0x0000000183F28FD0-0x0000000183F29060
	[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
	public override void SystemDeviceDisconnected() {} // 0x0000000183F29060-0x0000000183F290F0
	[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
	public override void SetUnityJoystickId(int joystickId, int unityJoystickId) {} // 0x0000000183F28F80-0x0000000183F28FD0
	[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
	public override IUnifiedMouseSource GetUnifiedMouseSource() => default; // 0x0000000183F27C30-0x0000000183F27C80
	[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
	public override IUnifiedKeyboardSource GetUnifiedKeyboardSource() => default; // 0x0000000183F27BE0-0x0000000183F27C30
	private void MbgVcSUpAefjsjvjwChdFUxHumx() {} // 0x0000000183F28AB0-0x0000000183F28CE0
	private List<yEHdWYdkyWyGSJOAPHTXOhczDmY> eVRylQBEybhXtQcVaaakESJbHKit() => default; // 0x0000000183F29AB0-0x0000000183F2AAD0
	private void yBcyHxAYdtaJQoCdFYuoptIcyZW() {} // 0x0000000183F2BE70-0x0000000183F2BEE0
	private void BSVqdeFFmRGquKzRRwdJkQkTOaWA(List<yEHdWYdkyWyGSJOAPHTXOhczDmY> param_0000af54) {} // 0x0000000183F27480-0x0000000183F279A0
	private void mqaZvKDcjQCLobGwMsCVHdhbuqt(dIYfxShIDrIIjihOcmVToKsXwFAE param_0000af55, YmFSmFunbrgipweqkyRyrjKlaog param_0000af56, out string param_0000af57) {
		param_0000af57 = default;
	} // 0x0000000183F2B1D0-0x0000000183F2B400
	private void nVcSLNPamegvZJFhMFHMKCYMWxY() {} // 0x0000000183F2B400-0x0000000183F2B600
	private IList<rrkiWNHnEkzBYEXAvbDAWsEtjKd> jjmBbKffkMRTPIHqYsiZAxmRfyJ() => default; // 0x0000000183F2B0F0-0x0000000183F2B1D0
	private void pVVycpDwxIAWedBpvsQuZHVXNEq() {} // 0x0000000183F2B600-0x0000000183F2B670
	private void KlUGOAHUqlIJiIxVnahEcgteyqda(int param_0000af58, int param_0000af59, List<dIYfxShIDrIIjihOcmVToKsXwFAE> param_0000af5a, List<dIYfxShIDrIIjihOcmVToKsXwFAE> param_0000af5b) {} // 0x0000000183F28700-0x0000000183F28AB0
	private bool bxYRVPNBMeqzOlxWcuXPWWCIBKj(List<dIYfxShIDrIIjihOcmVToKsXwFAE> param_0000af5c, int param_0000af5d) => default; // 0x0000000183F29950-0x0000000183F29AB0
	private int jjcAdWSwmMiSHrtrbjSXvfBZBAz(List<dIYfxShIDrIIjihOcmVToKsXwFAE> param_0000af5e) => default; // 0x0000000183F2AEE0-0x0000000183F2B0F0
	private bool hnPTilELGLdIFJbfnUgVEfTUyAY(List<dIYfxShIDrIIjihOcmVToKsXwFAE> param_0000af5f, int param_0000af60) => default; // 0x0000000183F2AD90-0x0000000183F2AEE0
	private void ISWzZRbBIprIMKhUiHLkZfQuBhZ(int param_0000af61, List<dIYfxShIDrIIjihOcmVToKsXwFAE> param_0000af62, int param_0000af63, List<dIYfxShIDrIIjihOcmVToKsXwFAE> param_0000af64, SNRBnIgKAMRWqTrKMMmcCoNDyKKd.DIWJVETWaPFFkudLyHFYfVbJqns param_0000af65) {} // 0x0000000183F27EB0-0x0000000183F281C0
	private void ILQRLaTXmQpdVwAsNdOarwOhzkQ(int param_0000af66, List<dIYfxShIDrIIjihOcmVToKsXwFAE> param_0000af67, SNRBnIgKAMRWqTrKMMmcCoNDyKKd.DIWJVETWaPFFkudLyHFYfVbJqns param_0000af68) {} // 0x0000000183F27C80-0x0000000183F27EB0
	private void fVTyjljPVNAOvCXNsxUbCrhFbJoi() {} // 0x0000000183F2AAD0-0x0000000183F2AC50
	private void DOhDLCjrEVGqRuZllaswidbgatW() {} // 0x0000000183F279A0-0x0000000183F27A40
	private void IVZQXBEcnUfnrWypyWboQvGXMjb(List<yEHdWYdkyWyGSJOAPHTXOhczDmY> param_0000af69) {} // 0x0000000183F281C0-0x0000000183F28250
	private bool pmAEuyuEmCBiquTqaFnfwdiCMuU(IList<rrkiWNHnEkzBYEXAvbDAWsEtjKd> param_0000af6a) => default; // 0x0000000183F2B670-0x0000000183F2B940
	private bool saptnzWhriuFUwfptyJbkFjzymv(Guid param_0000af6b) => default; // 0x0000000183F2BB10-0x0000000183F2BDA0
	private bool XrfbUEUpNCHSwbQMOmbXqaVXDkCt(IList<rrkiWNHnEkzBYEXAvbDAWsEtjKd> param_0000af6c, Guid param_0000af6d) => default; // 0x0000000183F29570-0x0000000183F296D0
	private void JtDrBjjubFXiGBlgRbdsfJusBoA(List<dIYfxShIDrIIjihOcmVToKsXwFAE> param_0000af6e, List<dIYfxShIDrIIjihOcmVToKsXwFAE> param_0000af6f, bool param_0000af70) {} // 0x0000000183F28360-0x0000000183F28700
	private void rXhRyzhbQTbXDGmMixSdjNyJMsQm(dIYfxShIDrIIjihOcmVToKsXwFAE param_0000af71, bool param_0000af72) {} // 0x0000000183F2B940-0x0000000183F2BB10
	private bool DlwKaKQxnSCpqwNoIFLrdIXSUNzJ() => default; // 0x0000000183F27A40-0x0000000183F27B80
	private void XLSyFvAyvgtnnwkEJGaHASCppOBm(List<dIYfxShIDrIIjihOcmVToKsXwFAE> param_0000af73, List<dIYfxShIDrIIjihOcmVToKsXwFAE> param_0000af74) {} // 0x0000000183F293F0-0x0000000183F29570
}

