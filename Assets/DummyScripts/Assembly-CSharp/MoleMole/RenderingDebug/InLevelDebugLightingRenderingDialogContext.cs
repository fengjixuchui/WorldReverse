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
using UnityEngine.Events;
using UnityEngine.UI;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole.RenderingDebug
{
	public sealed class InLevelDebugLightingRenderingDialogContext : BaseDialogContext // TypeDefIndex: 28645
	{
		// Fields
		private UnityEngine.UI.Text _pointLightNumberText; // 0x178
		private Button _pointLightAddButton; // 0x180
		private Button _pointLightDeleteButton; // 0x188
		private static int _pointLightStatus; // 0x00
	
		// Constructors
		public InLevelDebugLightingRenderingDialogContext() {} // 0x0000000183BAAE50-0x0000000183BAAF20
		static InLevelDebugLightingRenderingDialogContext() {} // 0x0000000183BAADF0-0x0000000183BAAE50
	
		// Methods
		// [XID] // 0x0000000189763A50-0x0000000189763A70
		public override void SetupView() {} // 0x0000000183BAA660-0x0000000183BAA700
		// [XID] // 0x000000018976B210-0x000000018976B230
		private void OnReturn() {} // 0x0000000183BAA260-0x0000000183BAA3F0
		// [XID] // 0x0000000189772860-0x0000000189772880
		public override void ClearView() {} // 0x0000000183BA71A0-0x0000000183BA72A0
		// [XID] // 0x0000000189779ED0-0x0000000189779EF0
		private void InitControl() {} // 0x0000000183BA75F0-0x0000000183BA87E0
		// [XID] // 0x0000000189781AF0-0x0000000189781B10
		public override void UpdateView() {} // 0x0000000183BAAD50-0x0000000183BAADF0
		// [XID] // 0x0000000189788FF0-0x0000000189789010
		private void OnRenderingPath(int value) {} // 0x0000000183BAA130-0x0000000183BAA260
		// [XID] // 0x00000001897905E0-0x0000000189790600
		private void InitRenderingPath(Dropdown widget) {} // 0x0000000183BA8C50-0x0000000183BA8DB0
		// [XID] // 0x0000000189797FD0-0x0000000189797FF0
		private List<Light> GetPointLights() => default; // 0x0000000183BA72A0-0x0000000183BA73F0
		// [XID] // 0x000000018979FD30-0x000000018979FD50
		private void OnPointLightAdd() {} // 0x0000000183BA9640-0x0000000183BA9B50
		// [XID] // 0x00000001897A7250-0x00000001897A7270
		private void OnPointLightDelete() {} // 0x0000000183BA9B50-0x0000000183BA9D80
		// [XID] // 0x00000001897AEC20-0x00000001897AEC40
		private void OnEdgeLightOff(bool enable) {} // 0x0000000183BA93B0-0x0000000183BA9460
		// [XID] // 0x00000001897B6AB0-0x00000001897B6AD0
		private void InitEdgeLightOff(Toggle widgit) {} // 0x0000000183BA88E0-0x0000000183BA8990
		// [XID] // 0x00000001897BE8D0-0x00000001897BE8F0
		private void OnSobelEdgeTest(bool enable) {} // 0x0000000183BAA3F0-0x0000000183BAA4B0
		// [XID] // 0x00000001897C5FE0-0x00000001897C6000
		private void InitSolbelEdgeTest(Toggle widgit) {} // 0x0000000183BA8DB0-0x0000000183BA8E80
		// [XID] // 0x00000001897CD7E0-0x00000001897CD800
		private void OnPointLightStatus(int value) {} // 0x0000000183BA9D80-0x0000000183BAA130
		// [XID] // 0x00000001897D4D40-0x00000001897D4D60
		private void InitPointLightStatus(Dropdown widget) {} // 0x0000000183BA8B60-0x0000000183BA8C50
		// [XID] // 0x00000001897DC4A0-0x00000001897DC4C0
		private void OnTimeScale(float value) {} // 0x0000000183BAA4B0-0x0000000183BAA5A0
		// [XID] // 0x00000001897E3E50-0x00000001897E3E70
		private void InitTimeScale(Slider widget) {} // 0x0000000183BA8E80-0x0000000183BA8FA0
		// [XID] // 0x00000001897EB9E0-0x00000001897EBA00
		private void OnAOMode(int value) {} // 0x0000000183BA9070-0x0000000183BA9180
		// [XID] // 0x00000001897F32E0-0x00000001897F3300
		private void InitAOMode(Dropdown widget) {} // 0x0000000183BA73F0-0x0000000183BA74F0
		// [XID] // 0x00000001897FAB50-0x00000001897FAB70
		public static void OnDynamicAOEnable(bool enable) {} // 0x0000000183BA92A0-0x0000000183BA93B0
		// [XID] // 0x0000000189802100-0x0000000189802120
		private void InitDynamicAOEnable(Toggle widget) {} // 0x0000000183BA87E0-0x0000000183BA88E0
		// [XID] // 0x00000001898095D0-0x00000001898095F0
		private void OnHQDynamicAOEnable(bool enable) {} // 0x0000000183BA9520-0x0000000183BA9640
		// [XID] // 0x0000000189810D80-0x0000000189810DA0
		private void InitHQDynamicAOEnable(Toggle widget) {} // 0x0000000183BA8A60-0x0000000183BA8B60
		// [XID] // 0x0000000189818830-0x0000000189818850
		private void OnBakedAOEnable(bool enable) {} // 0x0000000183BA9180-0x0000000183BA92A0
		// [XID] // 0x0000000189820140-0x0000000189820160
		private void InitBakedAOEnable(Toggle widget) {} // 0x0000000183BA74F0-0x0000000183BA75F0
		// [XID] // 0x00000001898276E0-0x0000000189827700
		private void OnVolumetricFog(int value) {} // 0x0000000183BAA5A0-0x0000000183BAA660
		// [XID] // 0x000000018982E920-0x000000018982E940
		private void InitVolumetricFog(Dropdown widget) {} // 0x0000000183BA8FA0-0x0000000183BA9070
		// [XID] // 0x00000001898362C0-0x00000001898362E0
		private void OnGodRay(int value) {} // 0x0000000183BA9460-0x0000000183BA9520
		// [XID] // 0x000000018983D710-0x000000018983D730
		private void InitGodRay(Dropdown widget) {} // 0x0000000183BA8990-0x0000000183BA8A60
	}
}
