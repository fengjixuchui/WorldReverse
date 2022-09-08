/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 38: ProBuilderCore-Unity5.dll - Assembly: ProBuilderCore-Unity5, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3356-3465

namespace ProBuilder2.Common
{
	// [AddComponentMenu] // 0x0000000189612560-0x00000001896125A0
	[ExecuteInEditMode] // 0x0000000189612560-0x00000001896125A0
	public class pb_MeshRenderer : pb_MonoBehaviourSingleton<ProBuilder2.Common.pb_MeshRenderer> // TypeDefIndex: 3410
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private HashSet<pb_Renderable> m_Renderables; // 0x18
		private readonly HideFlags SceneCameraHideFlags; // 0x20
	
		// Constructors
		public pb_MeshRenderer() {} // 0x0000000186BAF830-0x0000000186BAF8D0
	
		// Methods
		private int clamp(int val, int min, int max) => default; // 0x0000000186BAF8D0-0x0000000186BAF950
		public static void Add(pb_Renderable renderable) {} // 0x0000000186BAF040-0x0000000186BAF0D0
		public static void Remove(pb_Renderable renderable) {} // 0x0000000186BAF760-0x0000000186BAF830
		private void OnRenderObject() {} // 0x0000000186BAF230-0x0000000186BAF760
		private void OnDestroy() {} // 0x0000000186BAF0D0-0x0000000186BAF230
	}
}
