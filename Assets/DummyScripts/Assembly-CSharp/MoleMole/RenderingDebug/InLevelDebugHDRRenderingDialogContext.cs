/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine.UI;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole.RenderingDebug
{
	public sealed class InLevelDebugHDRRenderingDialogContext : BaseDialogContext // TypeDefIndex: 28644
	{
		// Fields
		private InputField m_MinLuminosityInput; // 0x178
		private InputField m_MaxLuminosityInput; // 0x180
		private InputField m_UIPaperWhiteInput; // 0x188
		private InputField m_ScenePaperWhiteInput; // 0x190
		private Slider m_ExpandGamutSlider; // 0x198
		private UnityEngine.UI.Text m_ExpandGamutText; // 0x1A0
		private Slider m_ContrastSlider; // 0x1A8
		private UnityEngine.UI.Text m_ContrastText; // 0x1B0
		private Dropdown m_ModeDropdown; // 0x1B8
	
		// Constructors
		public InLevelDebugHDRRenderingDialogContext() {} // 0x0000000183BA48E0-0x0000000183BA49D0
	
		// Methods
		// [XID] // 0x000000018968AE80-0x000000018968AEA0
		public override void SetupView() {} // 0x0000000183BA4330-0x0000000183BA43D0
		// [XID] // 0x0000000189692B70-0x0000000189692B90
		public override void ClearView() {} // 0x0000000183BA32C0-0x0000000183BA33C0
		// [XID] // 0x0000000189699E60-0x0000000189699E80
		private void InitControl() {} // 0x0000000183BA33C0-0x0000000183BA3C30
		// [XID] // 0x00000001896A15C0-0x00000001896A15E0
		private void OnReturn() {} // 0x0000000183BA4040-0x0000000183BA41D0
		// [XID] // 0x00000001896A8AA0-0x00000001896A8AC0
		private void OnModeChanged(bool hdr) {} // 0x0000000183BA3F90-0x0000000183BA4040
		// [XID] // 0x00000001896AFC00-0x00000001896AFC20
		private void OnExpanedGamutChanged(float value) {} // 0x0000000183BA3D30-0x0000000183BA3E30
		// [XID] // 0x00000001896B7590-0x00000001896B75B0
		private void OnMinLuminosityChanged(float value) {} // 0x0000000183BA3EE0-0x0000000183BA3F90
		// [XID] // 0x00000001896BE6A0-0x00000001896BE6C0
		private void OnMaxLuminosityChanged(float value) {} // 0x0000000183BA3E30-0x0000000183BA3EE0
		// [XID] // 0x00000001896C5F30-0x00000001896C5F50
		private void OnUIPaperWhiteChanged(float value) {} // 0x0000000183BA4280-0x0000000183BA4330
		// [XID] // 0x00000001896CD600-0x00000001896CD620
		private void OnSceneWhiteChanged(float value) {} // 0x0000000183BA41D0-0x0000000183BA4280
		// [XID] // 0x00000001896D4A90-0x00000001896D4AB0
		private void OnContrastChanged(float value) {} // 0x0000000183BA3C30-0x0000000183BA3D30
	}
}
