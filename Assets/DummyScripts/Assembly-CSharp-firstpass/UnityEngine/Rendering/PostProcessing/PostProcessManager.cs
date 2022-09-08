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
	public sealed class PostProcessManager // TypeDefIndex: 9592
	{
		// Fields
		private static PostProcessManager s_Instance; // 0x00
		private const int k_MaxLayerCount = 32; // Metadata: 0x00AE5C49
		private readonly List<PostProcessVolume>[] m_Volumes; // 0x10
		private readonly bool[] m_SortNeeded; // 0x18
		private readonly List<PostProcessEffectSettings> m_BaseSettings; // 0x20
		private readonly List<Collider> m_TempColliders; // 0x28
		public readonly Dictionary<System.Type, PostProcessAttribute> settingsTypes; // 0x30
	
		// Properties
		public static PostProcessManager instance { /* [XID] */ /* 0x0000000189878CD0-0x0000000189878CF0 */ get => default; } // 0x0000000185E04400-0x0000000185E044E0 
	
		// Constructors
		private PostProcessManager() {} // 0x0000000185E042E0-0x0000000185E04400
	
		// Methods
		// [XID] // 0x00000001897162A0-0x00000001897162C0
		private void CleanBaseTypes() {} // 0x0000000185E01F40-0x0000000185E02100
		// [XID] // 0x00000001897EE1E0-0x00000001897EE200
		private void ReloadBaseTypes() {} // 0x0000000185E02FF0-0x0000000185E03350
		// [XID] // 0x00000001897F5980-0x00000001897F59A0
		public void GetActiveVolumes(PostProcessLayer layer, List<PostProcessVolume> results) {} // 0x0000000185E02100-0x0000000185E027C0
		// [IDTag] // 0x00000001897FD1E0-0x00000001897FD220
		// [XID] // 0x00000001897FD1E0-0x00000001897FD220
		public PostProcessVolume GetHighestPriorityVolume(PostProcessLayer layer) => default; // 0x0000000185E02A10-0x0000000185E02B50
		// [IDTag] // 0x00000001898078E0-0x0000000189807920
		// [XID] // 0x00000001898078E0-0x0000000189807920
		public PostProcessVolume GetHighestPriorityVolume(LayerMask mask) => default; // 0x0000000185E027C0-0x0000000185E02A10
		// [XID] // 0x000000018981D260-0x000000018981D280
		public PostProcessVolume QuickVolume(int layer, float priority, params /* 0x000000018989F6F0-0x000000018989F700 */ PostProcessEffectSettings[] settings) => default; // 0x0000000185E02B50-0x0000000185E02D40
		// [XID] // 0x0000000189A981B0-0x0000000189A981D0
		internal void SetLayerDirty(int layer) {} // 0x0000000185E03350-0x0000000185E03440
		// [XID] // 0x0000000189828810-0x0000000189828830
		internal void UpdateVolumeLayer(PostProcessVolume volume, int prevLayer, int newLayer) {} // 0x0000000185E041D0-0x0000000185E042E0
		// [IDTag] // 0x000000018982FB70-0x000000018982FBB0
		// [XID] // 0x000000018982FB70-0x000000018982FBB0
		private void Register(PostProcessVolume volume, int layer) {} // 0x0000000185E02E20-0x0000000185E02FF0
		// [IDTag] // 0x000000018983A110-0x000000018983A150
		// [XID] // 0x000000018983A110-0x000000018983A150
		internal void Register(PostProcessVolume volume) {} // 0x0000000185E02D40-0x0000000185E02E20
		// [IDTag] // 0x0000000189844AD0-0x0000000189844B10
		// [XID] // 0x0000000189844AD0-0x0000000189844B10
		private void Unregister(PostProcessVolume volume, int layer) {} // 0x0000000185E038F0-0x0000000185E03A20
		// [IDTag] // 0x000000018984EE80-0x000000018984EEC0
		// [XID] // 0x000000018984EE80-0x000000018984EEC0
		internal void Unregister(PostProcessVolume volume) {} // 0x0000000185E03810-0x0000000185E038F0
		// [XID] // 0x000000018996B890-0x000000018996B8B0
		internal void UpdateSettings(PostProcessLayer postProcessLayer) {} // 0x0000000185E03A20-0x0000000185E041D0
		// [XID] // 0x0000000189860450-0x0000000189860470
		private static void SortByPriority(List<PostProcessVolume> volumes) {} // 0x0000000185E03440-0x0000000185E035E0
	}
}
