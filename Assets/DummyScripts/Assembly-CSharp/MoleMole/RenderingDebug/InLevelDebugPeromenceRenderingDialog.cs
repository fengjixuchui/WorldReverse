/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;
using UnityEngine.UI;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole.RenderingDebug
{
	public sealed class InLevelDebugPeromenceRenderingDialog : BaseDialogContext // TypeDefIndex: 28651
	{
		// Fields
		private static bool _mihoyoBuildConsoleShow; // 0x00
		private static int VerDensZTestModePropID; // 0x04
		private static bool _haveCacheCameraInfo; // 0x08
		private static bool _initialHalfPaticle; // 0x09
		private static UnityEngine.ShadowQuality _initialShadowQuality; // 0x0C
		private static TexelDensityScreenSizeType PrevTexelDensityScreenSize; // 0x10
		private static int TexelDensityScreenSizePropID; // 0x14
		private static int TexelDensityViewModePropID; // 0x18
		private static Vector4 TexelDensitDebugMode; // 0x1C
		private static TexelDensityViewModeType PrevTexelDensityViewMode; // 0x2C
		private static readonly string[] ShaderQualityStrs; // 0x30
	
		// Nested types
		private enum TexelDensityScreenSizeType // TypeDefIndex: 28652
		{
			Low = 1080,
			Middle = 1920,
			High = 3840
		}
	
		private enum TexelDensityViewModeType // TypeDefIndex: 28653
		{
			Diffuse = 0,
			Normal = 1,
			All = 2
		}
	
		// Constructors
		public InLevelDebugPeromenceRenderingDialog() {} // 0x0000000184FDCFB0-0x0000000184FDD060
		static InLevelDebugPeromenceRenderingDialog() {} // 0x0000000184FDCD00-0x0000000184FDCFB0
	
		// Methods
		// [XID] // 0x0000000189612990-0x00000001896129B0
		public override void SetupView() {} // 0x0000000184FDCB40-0x0000000184FDCBE0
		// [XID] // 0x000000018961A2C0-0x000000018961A2E0
		private void OnReturn() {} // 0x0000000184FDBA30-0x0000000184FDBBC0
		// [XID] // 0x0000000189621810-0x0000000189621830
		public override void ClearView() {} // 0x0000000184FDA390-0x0000000184FDA490
		// [XID] // 0x00000001896290E0-0x0000000189629100
		private void InitControl() {} // 0x0000000184FDA490-0x0000000184FDABD0
		// [XID] // 0x0000000189630A80-0x0000000189630AA0
		private void OnMiHoYoStatus(int value) {} // 0x0000000184FDB930-0x0000000184FDBA30
		// [XID] // 0x0000000189638520-0x0000000189638540
		private void InitMiHoYoStatus(Dropdown widget) {} // 0x0000000184FDACF0-0x0000000184FDAE10
		// [XID] // 0x000000018963F980-0x000000018963F9A0
		private void OnVertDens(int value) {} // 0x0000000184FDC560-0x0000000184FDCB40
		// [XID] // 0x0000000189647180-0x00000001896471A0
		private void InitVertDens(Dropdown widget) {} // 0x0000000184FDB5C0-0x0000000184FDB850
		// [XID] // 0x000000018964E850-0x000000018964E870
		private void OnTexDensScreen(int value) {} // 0x0000000184FDBD90-0x0000000184FDBF40
		// [XID] // 0x0000000189656040-0x0000000189656060
		private void InitTexDensScreen(Dropdown widget) {} // 0x0000000184FDAF90-0x0000000184FDB150
		// [XID] // 0x000000018965D840-0x000000018965D860
		private void OnTexDens(int value) {} // 0x0000000184FDBF40-0x0000000184FDC290
		// [XID] // 0x0000000189664F20-0x0000000189664F40
		private void InitTexDens(Dropdown widget) {} // 0x0000000184FDB150-0x0000000184FDB330
		// [XID] // 0x000000018966C560-0x000000018966C580
		private void OnVSync(int value) {} // 0x0000000184FDC4B0-0x0000000184FDC560
		// [XID] // 0x0000000189674400-0x0000000189674420
		private void InitVSync(Dropdown widget) {} // 0x0000000184FDB4F0-0x0000000184FDB5C0
		// [XID] // 0x000000018967BBE0-0x000000018967BC00
		private void OnShaderquality(int value) {} // 0x0000000184FDBBC0-0x0000000184FDBD90
		// [XID] // 0x00000001896832F0-0x0000000189683310
		private void InitShaderquality(Dropdown widget) {} // 0x0000000184FDAE10-0x0000000184FDAF90
		// [XID] // 0x000000018968AE60-0x000000018968AE80
		private void OnToggleEnableCrowd(int value) {} // 0x0000000184FDC290-0x0000000184FDC3C0
		// [XID] // 0x0000000189692B50-0x0000000189692B70
		private void InitToggleCrowd(Dropdown widget) {} // 0x0000000184FDB330-0x0000000184FDB3F0
		// [XID] // 0x0000000189699E40-0x0000000189699E60
		private void OnDynamicScaling(int value) {} // 0x0000000184FDB850-0x0000000184FDB930
		// [XID] // 0x00000001896A15A0-0x00000001896A15C0
		private void InitDynamicScaling(Dropdown widget) {} // 0x0000000184FDABD0-0x0000000184FDACF0
		// [XID] // 0x00000001896A8A80-0x00000001896A8AA0
		private void OnTreeLeavesStats(int value) {} // 0x0000000184FDC3C0-0x0000000184FDC4B0
		// [XID] // 0x00000001896AFBE0-0x00000001896AFC00
		private void InitTreeLeavesStats(Dropdown widget) {} // 0x0000000184FDB3F0-0x0000000184FDB4F0
	}
}
