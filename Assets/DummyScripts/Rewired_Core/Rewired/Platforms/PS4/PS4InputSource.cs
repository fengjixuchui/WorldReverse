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
using Rewired.Interfaces;
using Rewired.Platforms.Custom;
using Rewired.Platforms.PS4.Internal;
using Rewired.Utils.Interfaces;
using UnityEngine;

// Image 39: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3466-4436

namespace Rewired.Platforms.PS4
{
	[CustomClassObfuscation] // 0x0000000189699A10-0x0000000189699A60
	[CustomObfuscation] // 0x0000000189699A10-0x0000000189699A60
	internal sealed class PS4InputSource : CustomInputSource, IControllerAssigner // TypeDefIndex: 4232
	{
		// Fields
		private zvesZeCaQvmkYtvPNcZyJeBmHKwE CbxlGMZjJrdGjfGtzzlHbyjPDNh; // 0x48
		private bool sbRtkHgZnrrRKmrchailqtebcOh; // 0x50
		private bool vsurYtRlepcrpAzAENwjqjJEZPT; // 0x51
	
		// Properties
		public override bool isReady { get => default; } // 0x0000000185306140-0x0000000185306190 
	
		// Nested types
		private class zvesZeCaQvmkYtvPNcZyJeBmHKwE // TypeDefIndex: 4233
		{
			// Fields
			private readonly int befEovCmOfwVvbQLFeeQKXSCVbVe; // 0x10
			private readonly bool ogxHnjWMGGZmewkIwGMJmyKxrVS; // 0x14
			private readonly int[] MumHAbnVWMksDVtXZHuwGhYEedR; // 0x18
			private readonly IExternalTools hpLdyFVMkPBycwhCIbjEeQSvAcHD; // 0x20
			private readonly MtZQKSsxTZmMxsNMTwHOSWsIdQW[] UFjksljhPIwjzmgHhRsGNTjeNWB; // 0x28
			private readonly MtZQKSsxTZmMxsNMTwHOSWsIdQW[] cdvvrsHpWgwZKFBEdhWDLHWfiCH; // 0x30
			private readonly List<HNifjfBuGUdHbAzCWVPgtnsZsLm> eBBPOKJgLkqjhZFqxAXgECYzbQgT; // 0x38
			private readonly List<bEHqublOVrHdIYBAXVlZOGoUVQt> ThETfTsmIwvtHJBYTcFEAjxksXzo; // 0x40
			private Action<HNifjfBuGUdHbAzCWVPgtnsZsLm> ebBYuizGJXicSfLqAqgKYUJATVC; // 0x48
			private Action<bEHqublOVrHdIYBAXVlZOGoUVQt> PVVDIOHFhgYDLgDWNEqaaxtebvcc; // 0x50
	
			// Events
			public event Action<HNifjfBuGUdHbAzCWVPgtnsZsLm> ebBYuizGJXicSfLqAqgKYUJATVC;
			public event Action<bEHqublOVrHdIYBAXVlZOGoUVQt> PVVDIOHFhgYDLgDWNEqaaxtebvcc;
	
			// Nested types
			public struct HNifjfBuGUdHbAzCWVPgtnsZsLm // TypeDefIndex: 4234
			{
				// Fields
				public int scFBAQRnQdoAeLFwpCuSpDlJaTC; // 0x00
				public int YxCclPfBxKigbbzkHHVaRVAeXLZD; // 0x04
				public int rTnZbrPKYDIxXNkXGcEHEoLSAfGD; // 0x08
				public bool EDtNwfAOjJMyZDIVChTvgLQxfAi; // 0x0C
	
				// Constructors
				public HNifjfBuGUdHbAzCWVPgtnsZsLm(int playerId, int handle, int deviceClass, bool isSpecialController) {
					scFBAQRnQdoAeLFwpCuSpDlJaTC = default;
					YxCclPfBxKigbbzkHHVaRVAeXLZD = default;
					rTnZbrPKYDIxXNkXGcEHEoLSAfGD = default;
					EDtNwfAOjJMyZDIVChTvgLQxfAi = default;
				} // 0x0000000185BD4D60-0x0000000185BD4DA0
			}
	
			public struct bEHqublOVrHdIYBAXVlZOGoUVQt // TypeDefIndex: 4235
			{
				// Fields
				public int scFBAQRnQdoAeLFwpCuSpDlJaTC; // 0x00
				public int YxCclPfBxKigbbzkHHVaRVAeXLZD; // 0x04
				public bool EDtNwfAOjJMyZDIVChTvgLQxfAi; // 0x08
	
				// Constructors
				public bEHqublOVrHdIYBAXVlZOGoUVQt(int playerId, int handle, bool isSpecialController) {
					scFBAQRnQdoAeLFwpCuSpDlJaTC = default;
					YxCclPfBxKigbbzkHHVaRVAeXLZD = default;
					EDtNwfAOjJMyZDIVChTvgLQxfAi = default;
				} // 0x0000000185BED0D0-0x0000000185BED0E0
			}
	
			private class MtZQKSsxTZmMxsNMTwHOSWsIdQW // TypeDefIndex: 4236
			{
				// Fields
				public readonly bool EDtNwfAOjJMyZDIVChTvgLQxfAi; // 0x10
				public bool zuOjyqcFKUCzNlZjSJNYzCMoAHG; // 0x11
				public int YxCclPfBxKigbbzkHHVaRVAeXLZD; // 0x14
				public int rTnZbrPKYDIxXNkXGcEHEoLSAfGD; // 0x18
	
				// Constructors
				public MtZQKSsxTZmMxsNMTwHOSWsIdQW() {} // Dummy constructor
				public MtZQKSsxTZmMxsNMTwHOSWsIdQW(bool isSpecialController) {} // 0x0000000185BDE500-0x0000000185BDE5C0
	
				// Methods
				public jVyWYRMsaAhxXaPKXBprZqmmDmM IkEBDednVVXhKzTAAiBanMvrVip(bool param_00008d10, int param_00008d11, int param_00008d12) => default; // 0x0000000185BDE3E0-0x0000000185BDE500
				private void nympziBLtYDUiPlWNRoEGqbSPfa() {} // 0x0000000185BDE5C0-0x0000000185BDE620
			}
	
			[Flags] // 0x000000018990A800-0x000000018990A810
			private enum jVyWYRMsaAhxXaPKXBprZqmmDmM // TypeDefIndex: 4237
			{
				TCGihQKDgeeGtvEXifcuojmabzj = 0,
				AVgeqanjsLChqjEayGcDNCMqTxtI = 1,
				dUltDdkivNhBBHvDthniWYpgMnZ = 2,
				uvXCbsBnPfRSSonxhmUFPMkpny = 4
			}
	
			// Constructors
			public zvesZeCaQvmkYtvPNcZyJeBmHKwE() {} // Dummy constructor
			public zvesZeCaQvmkYtvPNcZyJeBmHKwE(int maxPlayers, bool supportSpecialControllers) {} // 0x00000001853193A0-0x0000000185319600
	
			// Methods
			public void UZSQFwoMfSAzsmmSKmseCCiJWWD() {} // 0x0000000185318E80-0x00000001853193A0
			private void GxDBCKmFHBuejoXLQueHFFCdDIHb(int param_00008d04, MtZQKSsxTZmMxsNMTwHOSWsIdQW param_00008d05, int param_00008d06, bool param_00008d07) {} // 0x0000000185318BA0-0x0000000185318E80
		}
	
		private abstract class gmxKuWvehhjyGxbrPSVaHzquCvx : CustomInputSource.Joystick, IPS4ControllerExtensionSource // TypeDefIndex: 4238
		{
			// Fields
			private static int crqoDCfQnUQSFLrNkhSrkcSduMX; // 0x00
			protected readonly int iueDnAHVXVmEMnNCzSowjkddzOFv; // 0x70
			protected readonly int UzBZSIQMHRDrYTcHWhDjxwBwnMg; // 0x74
			protected readonly bool IUKhVvfOOzbCHepuFOEFeZALmnd; // 0x78
			protected readonly lKNlqJxafShcjyFxIuOgbYvpgoq QdhsebCRgJZofRWdmUYiXIOYTpk; // 0x80
			protected readonly int NwgZCoPcMAFocejfaTMgksjuPEtb; // 0x88
			protected readonly float[] qyibqHFecCGFAWtgKwpILOswFqvh; // 0x90
			private readonly LoggedInUser ZACIbUAVuGKNZRSufwUSAhmyuxyJ; // 0x98
			protected readonly ControllerType iaFziOmGetWMviBsUmpNhLnTJKt; // 0xA0
			private readonly Func<int, bool> UhCfIBCMHoKYrEGmCOOyERYbiRvD; // 0xA8
			private readonly Action<int, int, int> tWslsRuqkCpPFnsDkkPXVODfEepc; // 0xB0
			private readonly Action<int, int, int, int> kWEAKBDlhqLeYCUGxFjXDcxAPGaj; // 0xB8
			private readonly Action<int> qJYxbirBJazSSYBwkcYqCNheIJph; // 0xC0
			private Action<int, bool> VOdcSKJqeUJumyeLxVrECeNkjRo; // 0xC8
			private Action<int, bool> XjgJXDTlOnJFWJfNfLzQPCvLYtZ; // 0xD0
			private Action<int, bool> hKbTeyEWTTqpOUxRmbJAJSUDnfF; // 0xD8
			private Action<int> quhThkNWRAcpNwrbBsSIKdFAVFu; // 0xE0
			private Func<int, Vector3> SGUoQgFyPQRRrhUqytNyUXJCiRe; // 0xE8
			private Func<int, Vector3> AeFADGEEYeOCqfoTKZtGpHgUaDoD; // 0xF0
			private Func<int, Vector4> ahWchJbiPNsEmiLLQZBnGroIXqw; // 0xF8
	
			// Properties
			private static int gcGavsQychaxEkWbJyMquPiSMMc { get; } // 0x00000001853119D0-0x0000000185311A60 
			public int scFBAQRnQdoAeLFwpCuSpDlJaTC { get; } // 0x0000000185311B20-0x0000000185311B80 
			public int YxCclPfBxKigbbzkHHVaRVAeXLZD { get; } // 0x0000000185311A60-0x0000000185311AC0 
			public bool EDtNwfAOjJMyZDIVChTvgLQxfAi { get; } // 0x0000000185311AC0-0x0000000185311B20 
			private bool DBXmSEaIcIcVtoKakjDQKTgfFxLq { get; } // 0x0000000185311950-0x00000001853119D0 
			public int dFeMnzRTSNcMYNGuAWZUeFGTLNj { get; } // 0x0000000185311B80-0x0000000185311BF0 
	
			// Nested types
			[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
			public enum ControllerType // TypeDefIndex: 4239
			{
				Unknown = 0,
				Gamepad = 1,
				Move = 2,
				Guitar = 3,
				Drum = 4,
				DjTurntable = 5,
				DanceMat = 6,
				Navigation = 7,
				SteeringWheel = 8,
				Stick = 9,
				FlightStick = 10,
				Gun = 11
			}
	
			protected enum BjhebJnWLAAQxFGXvaQIgVwiFspI // TypeDefIndex: 4240
			{
				UMtjEaOogDDwQiplOLpTuwxTdbQ = 0,
				XaFUPxxCceGTABxzGrOIRyeKOen = 1,
				zWnsnIIDCeFcLAnplFouhWdNXPS = 2
			}
	
			public class lKNlqJxafShcjyFxIuOgbYvpgoq // TypeDefIndex: 4241
			{
				// Fields
				public readonly int TwhUkSEboxGPsJgqbpmupSCMcvva; // 0x10
				public readonly int SgYwVaEgtCZiUkgVDcTwJWbyDTtb; // 0x14
				public readonly float ZpNkmGdIMOGNFcdylebfiGiHPIp; // 0x18
				public readonly int dFeMnzRTSNcMYNGuAWZUeFGTLNj; // 0x1C
				public readonly int FZbyKZphKDpuBpoBVcVmPaNVhUHh; // 0x20
	
				// Constructors
				public lKNlqJxafShcjyFxIuOgbYvpgoq() {} // Dummy constructor
				public lKNlqJxafShcjyFxIuOgbYvpgoq(int axisCount, int buttonCount, float dpadDeadzone, int vibrationMotorCount, int maxTouches) {} // 0x00000001853126E0-0x0000000185312780
			}
	
			// Constructors
			protected gmxKuWvehhjyGxbrPSVaHzquCvx() {} // Dummy constructor
			protected gmxKuWvehhjyGxbrPSVaHzquCvx(ControllerType type, string name, int playerId, int unityJoystickId, int handle, lKNlqJxafShcjyFxIuOgbYvpgoq capabilities) {} // 0x0000000185310E10-0x0000000185311950
			static gmxKuWvehhjyGxbrPSVaHzquCvx() {} // 0x0000000185310DC0-0x0000000185310E10
	
			// Methods
			public static gmxKuWvehhjyGxbrPSVaHzquCvx MdLShCgeucAqBomYFlMaHVWokJC(ControllerType param_00008d13, int param_00008d14, int param_00008d15) => default; // 0x000000018530F910-0x000000018530FA20
			public override void Update() {} // 0x0000000185310D50-0x0000000185310DC0
			public void StopVibration() {} // 0x000000018530FDA0-0x000000018530FE30
			public void SetVibration(int param_00008d1c, float param_00008d1d) {} // 0x000000018530FCB0-0x000000018530FDA0
			public void ResetOrientation() {} // 0x000000018530FB80-0x000000018530FC00
			public Vector3 GetLastAcceleration() => default; // 0x000000018530F5E0-0x000000018530F7A0
			public Quaternion GetLastOrientation() => default; // 0x000000018530F7A0-0x000000018530F910
			public void SetLightColor(int param_00008d1e, int param_00008d1f, int param_00008d20) {} // 0x000000018530FC00-0x000000018530FCB0
			protected virtual void UpdateElementValues() {} // 0x000000018530FE30-0x0000000185310D50
			protected void OEMCPvgbhfiSKihdAdCuwZyGDXks() {} // 0x000000018530FA20-0x000000018530FB80
			protected static int CnCIYKORzEggIUzMNrthVKHjFMk(float param_00008d21) => default; // 0x000000018530F550-0x000000018530F5E0
			protected static void gfIksWBUPneTPwaSnJsaSgelRIB(ref Vector3 param_00008d22) {} // 0x0000000185311BF0-0x0000000185311C70
		}
	
		private sealed class lIoaADrjBSGqvtbbtJGuTnBKAVSd : gmxKuWvehhjyGxbrPSVaHzquCvx, IPS4GamepadExtensionSource // TypeDefIndex: 4242
		{
			// Fields
			private int QMnDnsCRjJEmZExktpVVgYKJahK; // 0x100
			private int rPEWdfYFQpesAMJJMDNQFoUrQiWj; // 0x104
			private Vector2 BxgwWqJorIUJiiBvYPshoStNtmU; // 0x108
			private int kGkaLKQPuvEDEdUhoOsCxbiCcmVi; // 0x110
			private Vector2 PLiipqNOoBdeFFqoufzfpfeDgirW; // 0x114
			private BjhebJnWLAAQxFGXvaQIgVwiFspI QVgNxriCustqvbDrikBBBmNiYhB; // 0x11C
			private int cGlhdzfzHYDZUSyaMnzWDmahQyy; // 0x120
			private int uUbJbdaGEcffjIHHXZNorTMkGJns; // 0x124
			private int ojdcBcGveyOHAUbuZtlmTNEbXHev; // 0x128
			private int VcoscxOiIadXIRHsHvrvUswmigE; // 0x12C
			private float NnQrwQTThDbSrTHmHNlrWxWIQdt; // 0x130
	
			// Properties
			public int FZbyKZphKDpuBpoBVcVmPaNVhUHh { get => default; } // 0x00000001853124D0-0x0000000185312540 
	
			// Constructors
			public lIoaADrjBSGqvtbbtJGuTnBKAVSd() {} // Dummy constructor
			public lIoaADrjBSGqvtbbtJGuTnBKAVSd(string name, int playerId, int unityJoystickId, int handle) {} // 0x00000001853122D0-0x00000001853124D0
	
			// Methods
			public int GetTouchId(int param_00008d2c) => default; // 0x0000000185311D30-0x0000000185311DD0
			public bool GetTouchPositionByIndex(int param_00008d2d, out Vector2 param_00008d2e) {
				param_00008d2e = default;
				return default;
			} // 0x0000000185311DD0-0x0000000185311FD0
			public bool IsTouchingByIndex(int param_00008d2f) => default; // 0x0000000185311FD0-0x0000000185312060
			public bool IsTouchingByTouchId(int param_00008d30) => default; // 0x0000000185312060-0x00000001853120E0
			protected override void UpdateElementValues() {} // 0x00000001853120E0-0x00000001853122D0
			private void vrtROXlgaeUcHBHqSIqBsWVBhQv() {} // 0x0000000185312540-0x00000001853126E0
			private int ABSuBgFBKYWAyRgQXCDIKzRosoP(int param_00008d31) => default; // 0x0000000185311C70-0x0000000185311D30
		}
	
		// Constructors
		public PS4InputSource() {} // 0x0000000185305FE0-0x0000000185306140
	
		// Methods
		public override void Update() {} // 0x0000000185305E30-0x0000000185305FE0
		private static int pLQqcTWZsEhjTLsPieFqpmPhbNmc(int param_00008cf5) => default; // 0x0000000185306270-0x00000001853062D0
		private void CZWDtBDGjmAVgvhkbqohckLIkBLy(zvesZeCaQvmkYtvPNcZyJeBmHKwE.HNifjfBuGUdHbAzCWVPgtnsZsLm param_00008cf6) {} // 0x0000000185305540-0x0000000185305600
		private void nStyutKLhVUOhnUsJaSFWeHufACh(gmxKuWvehhjyGxbrPSVaHzquCvx param_00008cf7) {} // 0x0000000185306190-0x0000000185306270
		private void NyRmbmAXviMtNQzvWNLUuTuBmpV(zvesZeCaQvmkYtvPNcZyJeBmHKwE.bEHqublOVrHdIYBAXVlZOGoUVQt param_00008cf8) {} // 0x0000000185305740-0x00000001853059D0
		bool IControllerAssigner.CanHandleAssignment(ControllerType param_00008cf9, Controller param_00008cfa) => default; // 0x0000000185305D80-0x0000000185305E30
		void IControllerAssigner.AssignController(ControllerType param_00008cfb, Controller param_00008cfc) {} // 0x00000001853059D0-0x0000000185305D80
		~PS4InputSource() {} // 0x0000000185305690-0x0000000185305740
		protected override void Dispose(bool disposing) {} // 0x0000000185305600-0x0000000185305690
	}
}
