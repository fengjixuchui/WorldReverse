/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using UnityEngine;
using UnityEngine.Rendering;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace UnityEngine.Rendering.PostProcessing
{
	[Serializable]
	public class PostProcessEffectSettings : ScriptableObject // TypeDefIndex: 9577
	{
		// Fields
		public bool active; // 0x18
		public BoolParameter enabled; // 0x20
		internal ReadOnlyCollection<ParameterOverride> parameters; // 0x28
	
		// Constructors
		public PostProcessEffectSettings() {} // 0x0000000185C02D50-0x0000000185C02EC0
	
		// Methods
		// [XID] // 0x0000000189924530-0x0000000189924550
		private void OnEnable() {} // 0x0000000185C026C0-0x0000000185C02900
		// [XID] // 0x0000000189AB8A80-0x0000000189AB8AA0
		public void SetAllOverridesTo(bool state, bool excludeEnabled = true /* Metadata: 0x00AE5BFD */) {} // 0x0000000185C02900-0x0000000185C02B10
		// [XID] // 0x00000001899330E0-0x0000000189933100
		public virtual bool IsEnabledAndSupported(PostProcessRenderContext context) => default; // 0x0000000185C02600-0x0000000185C026C0
		// [XID] // 0x000000018993AA10-0x000000018993AA30
		public int GetHash() => default; // 0x0000000185C023F0-0x0000000185C02600
		// [XID] // 0x0000000189941B10-0x0000000189941B30
		public virtual CameraEvent CommandBufferEvent() => default; // 0x0000000185C02350-0x0000000185C023F0
	}
}
