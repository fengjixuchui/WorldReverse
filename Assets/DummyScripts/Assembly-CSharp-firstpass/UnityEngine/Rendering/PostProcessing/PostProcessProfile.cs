/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace UnityEngine.Rendering.PostProcessing
{
	public sealed class PostProcessProfile : ScriptableObject // TypeDefIndex: 9593
	{
		// Fields
		// [Tooltip] // 0x000000018987C7B0-0x000000018987C7E0
		public List<PostProcessEffectSettings> settings; // 0x18
		[NonSerialized]
		public bool isDirty; // 0x20
	
		// Constructors
		public PostProcessProfile() {} // 0x0000000185E04DA0-0x0000000185E04E30
	
		// Methods
		// [XID] // 0x0000000189B0DE70-0x0000000189B0DE90
		private void OnEnable() {} // 0x0000000185E049A0-0x0000000185E04AD0
		// [XID] // 0x00000001899D5CF0-0x00000001899D5D10
		public void Reset() {} // 0x0000000185E04C70-0x0000000185E04D10
		public T AddSettings<T>()
			where T : PostProcessEffectSettings => default;
		// [IDTag] // 0x000000018989B510-0x000000018989B550
		// [XID] // 0x000000018989B510-0x000000018989B550
		public PostProcessEffectSettings AddSettings(System.Type type) => default; // 0x0000000185E044E0-0x0000000185E04680
		// [IDTag] // 0x00000001898A5B30-0x00000001898A5B70
		// [XID] // 0x00000001898A5B30-0x00000001898A5B70
		public PostProcessEffectSettings AddSettings(PostProcessEffectSettings effect) => default; // 0x0000000185E04680-0x0000000185E047C0
		public void RemoveSettings<T>()
			where T : PostProcessEffectSettings {}
		// [XID] // 0x0000000189673020-0x0000000189673040
		public void RemoveSettings(System.Type type) {} // 0x0000000185E04AD0-0x0000000185E04C70
		public bool HasSettings<T>()
			where T : PostProcessEffectSettings => default;
		// [XID] // 0x00000001897CF290-0x00000001897CF2B0
		public bool HasSettings(System.Type type) => default; // 0x0000000185E047C0-0x0000000185E049A0
		public T GetSettings<T>()
			where T : PostProcessEffectSettings => default;
		public bool TryGetSettings<T>(out T outSetting)
			where T : PostProcessEffectSettings {
			outSetting = default;
			return default;
		}
	}
}
