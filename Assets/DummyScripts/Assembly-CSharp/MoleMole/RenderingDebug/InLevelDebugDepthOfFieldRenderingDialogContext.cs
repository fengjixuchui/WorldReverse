/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine.Events;
using UnityEngine.Rendering.PostProcessing;
using UnityEngine.UI;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole.RenderingDebug
{
	public sealed class InLevelDebugDepthOfFieldRenderingDialogContext : BaseDialogContext // TypeDefIndex: 28642
	{
		// Properties
		private PostProcessLayer postFXLayer { /* [XID] */ /* 0x0000000189B78670-0x0000000189B78690 */ get => default; } // 0x0000000183BA2EA0-0x0000000183BA2F80 
		private PostProcessProfile postFXProfile { /* [XID] */ /* 0x0000000189B7FC30-0x0000000189B7FC50 */ get => default; } // 0x0000000183BA2F80-0x0000000183BA30A0 
	
		// Constructors
		public InLevelDebugDepthOfFieldRenderingDialogContext() {} // 0x0000000183BA2DF0-0x0000000183BA2EA0
	
		// Methods
		// [XID] // 0x0000000189B876A0-0x0000000189B876C0
		public override void SetupView() {} // 0x0000000183BA2A30-0x0000000183BA2AD0
		// [XID] // 0x0000000189B8E810-0x0000000189B8E830
		public override void ClearView() {} // 0x0000000183BA01A0-0x0000000183BA02A0
		// [XID] // 0x0000000189B95CF0-0x0000000189B95D10
		private void InitControl() {} // 0x0000000183BA02A0-0x0000000183BA0D70
		// [XID] // 0x0000000189B9D230-0x0000000189B9D250
		private void OnReturn() {} // 0x0000000183BA2310-0x0000000183BA24A0
		// [XID] // 0x0000000189BA4BF0-0x0000000189BA4C10
		private void BindSliderAndInputField(Slider slider, InputField inputField) {} // 0x0000000183B9FEF0-0x0000000183BA01A0
		// [XID] // 0x0000000189BABF10-0x0000000189BABF30
		private void InitDOFSettings(out MHYDepthOfField dof) {
			dof = default;
		} // 0x0000000183BA0D70-0x0000000183BA0EA0
		// [XID] // 0x0000000189BB35C0-0x0000000189BB35E0
		private void InitMBSettings(out MotionBlur mb) {
			mb = default;
		} // 0x0000000183BA1330-0x0000000183BA1490
		// [XID] // 0x0000000189BBABE0-0x0000000189BBAC00
		private void InitEnableDOF(Dropdown widget) {} // 0x0000000183BA0EA0-0x0000000183BA1010
		// [XID] // 0x0000000189BC2BB0-0x0000000189BC2BD0
		private void OnEnableDOF(int value) {} // 0x0000000183BA1B30-0x0000000183BA1C80
		// [XID] // 0x0000000189BCA2C0-0x0000000189BCA2E0
		private void InitQuality(Dropdown widget) {} // 0x0000000183BA17B0-0x0000000183BA1910
		// [XID] // 0x0000000189BD1950-0x0000000189BD1970
		private void OnQuality(int value) {} // 0x0000000183BA21C0-0x0000000183BA2310
		// [XID] // 0x0000000189BD8F40-0x0000000189BD8F60
		private void InitFocusDistance(Slider widget) {} // 0x0000000183BA11A0-0x0000000183BA1330
		// [XID] // 0x00000001895E5AC0-0x00000001895E5AE0
		private void OnFocusDistance(float value) {} // 0x0000000183BA1DD0-0x0000000183BA1F20
		// [XID] // 0x00000001895ED430-0x00000001895ED450
		private void InitFStop(Slider widget) {} // 0x0000000183BA1010-0x0000000183BA11A0
		// [XID] // 0x00000001895F4B30-0x00000001895F4B50
		private void OnFStop(float value) {} // 0x0000000183BA1C80-0x0000000183BA1DD0
		// [XID] // 0x00000001895FC240-0x00000001895FC260
		private void InitMaxFgdRadius(Slider widget) {} // 0x0000000183BA1620-0x0000000183BA17B0
		// [XID] // 0x0000000189603C40-0x0000000189603C60
		private void OnMaxFgdRadius(float value) {} // 0x0000000183BA2070-0x0000000183BA21C0
		// [XID] // 0x000000018960B580-0x000000018960B5A0
		private void InitMaxBgdRadius(Slider widget) {} // 0x0000000183BA1490-0x0000000183BA1620
		// [XID] // 0x00000001896129B0-0x00000001896129D0
		private void OnMaxBgdRadius(float value) {} // 0x0000000183BA1F20-0x0000000183BA2070
		// [XID] // 0x000000018961A2E0-0x000000018961A300
		private void InitTestSomething(Dropdown widget) {} // 0x0000000183BA1910-0x0000000183BA1A70
		// [XID] // 0x0000000189621830-0x0000000189621850
		private void OnTestSomething(int value) {} // 0x0000000183BA24A0-0x0000000183BA2620
		// [XID] // 0x0000000189629100-0x0000000189629120
		private void InitUseSwitchMBDOF(Dropdown widget) {} // 0x0000000183BA1A70-0x0000000183BA1B30
		// [XID] // 0x0000000189630AA0-0x0000000189630AC0
		private void OnUseSwitchMBDOF(int value) {} // 0x0000000183BA2620-0x0000000183BA2A30
	}
}
