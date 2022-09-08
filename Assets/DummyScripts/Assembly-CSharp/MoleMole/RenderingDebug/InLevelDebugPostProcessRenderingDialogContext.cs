/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;
using UnityEngine.UI;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole.RenderingDebug
{
	public sealed class InLevelDebugPostProcessRenderingDialogContext : BaseDialogContext // TypeDefIndex: 28654
	{
		// Fields
		private InLevelDebugDropdown _screenResolutionWidget; // 0x178
		private InLevelDebugDropdown _innerResolutionWidget; // 0x180
		private InLevelDebugDropdown _innerResolutionScaleRatioWidget; // 0x188
		private InLevelDebugDropdown _bloomWidget; // 0x190
		private InLevelDebugDropdown _antiAliasingWidget; // 0x198
		private InLevelDebugDropdown _motionBlurDOFLevelWidget; // 0x1A0
		private InLevelDebugDropdown _secResScaleWidget; // 0x1A8
		private InLevelDebugDropdown _autoExposureWidget; // 0x1B0
		private static bool _prePostProcessOn; // 0x00
		private static int _preBloomVal; // 0x04
		private static int _preAAVal; // 0x08
		private static int _preMBDOFVal; // 0x0C
		private static int _preAutoExposureOn; // 0x10
		private List<Func<bool>> _postFXNeededFuncs; // 0x1B8
		private static Resolution originalScreenResolution; // 0x14
	
		// Properties
		private PostProcessLayer postFXLayer { /* [XID] */ /* 0x00000001896C1450-0x00000001896C1470 */ get => default; } // 0x0000000184FE1E20-0x0000000184FE1F00 
		private PostProcessProfile postFXProfile { /* [XID] */ /* 0x00000001896C8B10-0x00000001896C8B30 */ get => default; } // 0x0000000184FE1F00-0x0000000184FE2020 
	
		// Constructors
		public InLevelDebugPostProcessRenderingDialogContext() {} // 0x0000000184FE1CF0-0x0000000184FE1E20
		static InLevelDebugPostProcessRenderingDialogContext() {} // 0x0000000184FE1BE0-0x0000000184FE1CF0
	
		// Methods
		// [XID] // 0x00000001896D0540-0x00000001896D0560
		public override void SetupView() {} // 0x0000000184FE1570-0x0000000184FE1610
		// [XID] // 0x00000001896D7A00-0x00000001896D7A20
		public override void ClearView() {} // 0x0000000184FDD060-0x0000000184FDD160
		// [XID] // 0x00000001896DF2A0-0x00000001896DF2C0
		private void InitControl() {} // 0x0000000184FDD780-0x0000000184FDE300
		// [XID] // 0x00000001896E6690-0x00000001896E66B0
		private void OnReturn() {} // 0x0000000184FE0E40-0x0000000184FE0FD0
		// [XID] // 0x00000001896EDBE0-0x00000001896EDC00
		private void InitPostProcess(Dropdown widget) {} // 0x0000000184FDEAC0-0x0000000184FDEBC0
		// [XID] // 0x00000001896F5450-0x00000001896F5470
		public void OnPostProcess(int value) {} // 0x0000000184FE0440-0x0000000184FE0980
		// [XID] // 0x00000001896FCC50-0x00000001896FCC70
		private void InitScreenScaleUI(Dropdown widget) {} // 0x0000000184FDF1A0-0x0000000184FDF560
		// [XID] // 0x0000000189704130-0x0000000189704150
		private void OnScreenScale(int value) {} // 0x0000000184FE0FD0-0x0000000184FE12D0
		// [XID] // 0x000000018970B9E0-0x000000018970BA00
		private void InitResolutionScaleUI(Dropdown widget) {} // 0x0000000184FDEEF0-0x0000000184FDF1A0
		// [XID] // 0x00000001897132B0-0x00000001897132D0
		private void OnResolutionScale(int value) {} // 0x0000000184FE0C20-0x0000000184FE0E40
		// [XID] // 0x000000018971AAB0-0x000000018971AAD0
		private void InitResolutionScaleRatioUI(Dropdown widget) {} // 0x0000000184FDECA0-0x0000000184FDEEF0
		// [XID] // 0x0000000189721DF0-0x0000000189721E10
		private void OnResolutionScaleRatio(int value) {} // 0x0000000184FE0A70-0x0000000184FE0C20
		// [XID] // 0x0000000189729500-0x0000000189729520
		private void InitAntiAliasing(Dropdown widget) {} // 0x0000000184FDD160-0x0000000184FDD360
		// [XID] // 0x0000000189730CA0-0x0000000189730CC0
		private void OnAntiAliasing(int value) {} // 0x0000000184FDFA40-0x0000000184FDFC30
		// [XID] // 0x00000001897385F0-0x0000000189738610
		private void InitOutlineScale(InputField widget) {} // 0x0000000184FDE9E0-0x0000000184FDEAC0
		// [XID] // 0x0000000189740390-0x00000001897403B0
		private void OnOutlineScale(string text) {} // 0x0000000184FE0350-0x0000000184FE0440
		// [XID] // 0x0000000189747700-0x0000000189747720
		private void InitResOutlineScale(InputField widget) {} // 0x0000000184FDEBC0-0x0000000184FDECA0
		// [XID] // 0x000000018974EE70-0x000000018974EE90
		private void OnResOutlineScale(string text) {} // 0x0000000184FE0980-0x0000000184FE0A70
		// [XID] // 0x0000000189756540-0x0000000189756560
		private bool IsPostFXNeedOn() => default; // 0x0000000184FDF9A0-0x0000000184FDFA40
		// [XID] // 0x000000018975D9C0-0x000000018975D9E0
		private bool IsPostFXNeedOnExceptScreenScale() => default; // 0x0000000184FDF7E0-0x0000000184FDF9A0
		// [XID] // 0x0000000189764F50-0x0000000189764F70
		private void SwitchPostFX() {} // 0x0000000184FE1610-0x0000000184FE1720
		// [XID] // 0x000000018976C9D0-0x000000018976C9F0
		public void InitBloomSettings(out MHYBloom mhyBloom) {
			mhyBloom = default;
		} // 0x0000000184FDD490-0x0000000184FDD5F0
		// [XID] // 0x0000000189773E70-0x0000000189773E90
		private void InitBloom(Dropdown widget) {} // 0x0000000184FDD5F0-0x0000000184FDD780
		// [XID] // 0x000000018977B560-0x000000018977B580
		private void OnBloom(int value) {} // 0x0000000184FDFC30-0x0000000184FDFDC0
		// [XID] // 0x00000001897830A0-0x00000001897830C0
		public void InitMotionBlurSettings(out MotionBlur motionBlur) {
			motionBlur = default;
		} // 0x0000000184FDE880-0x0000000184FDE9E0
		// [XID] // 0x000000018978A590-0x000000018978A5B0
		private void InitMotionBlurDOF(Dropdown widget) {} // 0x0000000184FDE5C0-0x0000000184FDE880
		// [XID] // 0x0000000189791D10-0x0000000189791D30
		private void OnMotionBlurDOF(int value) {} // 0x0000000184FE0050-0x0000000184FE0350
		// [XID] // 0x0000000189799390-0x00000001897993B0
		private void InitSecondResScale(Dropdown widget) {} // 0x0000000184FDF560-0x0000000184FDF7E0
		// [XID] // 0x00000001897A12F0-0x00000001897A1310
		private void OnSecondResScale(int value) {} // 0x0000000184FE12D0-0x0000000184FE1570
		// [XID] // 0x00000001897A88A0-0x00000001897A88C0
		private void InitEnableDistortion(Dropdown widget) {} // 0x0000000184FDE490-0x0000000184FDE5C0
		// [XID] // 0x00000001897B0320-0x00000001897B0340
		private void OnEnableDistortion(int value) {} // 0x0000000184FDFF30-0x0000000184FE0050
		// [XID] // 0x00000001897B8010-0x00000001897B8030
		public void InitAutoExposureSettings(out AutoExposure autoExposure) {
			autoExposure = default;
		} // 0x0000000184FDD360-0x0000000184FDD490
		// [XID] // 0x00000001897C0170-0x00000001897C0190
		private void InitEnableAutoExposure(Dropdown widget) {} // 0x0000000184FDE300-0x0000000184FDE490
		// [XID] // 0x00000001897C7960-0x00000001897C7980
		private void OnEnableAutoExposure(int value) {} // 0x0000000184FDFDC0-0x0000000184FDFF30
	}
}
