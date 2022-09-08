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

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	// [RequireComponent] // 0x00000001896FCD10-0x00000001896FCD60
	public class ChangeEntityToShadowLayer : MonoBehaviour // TypeDefIndex: 26527
	{
		// Fields
		private Light _sceneLight; // 0x18
		private DirectionLightShadowLayerShadowMap _dirLightShadowMap; // 0x20
		private List<int> _initialLayer; // 0x28
		private List<Renderer> _shadowLayerRenderers; // 0x30
	
		// Constructors
		public ChangeEntityToShadowLayer() {} // 0x0000000181ADBCA0-0x0000000181ADBD00
	
		// Methods
		// [XID] // 0x0000000189708A80-0x0000000189708AA0
		public void Awake() {} // 0x0000000181ADB5E0-0x0000000181ADB7F0
		// [XID] // 0x0000000189710330-0x0000000189710350
		private void OnPreCull() {} // 0x0000000181ADB9F0-0x0000000181ADBCA0
		// [XID] // 0x00000001897176F0-0x0000000189717710
		private void OnPostRender() {} // 0x0000000181ADB7F0-0x0000000181ADB9F0
	}
}
