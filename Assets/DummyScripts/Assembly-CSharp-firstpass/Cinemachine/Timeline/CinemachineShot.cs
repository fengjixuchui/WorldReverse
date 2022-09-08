/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cinemachine;
using IFix.Core;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace Cinemachine.Timeline
{
	public sealed class CinemachineShot : PlayableAsset, IPropertyPreview // TypeDefIndex: 6869
	{
		// Fields
		public ExposedReference<CinemachineVirtualCameraBase> VirtualCamera; // 0x18
	
		// Constructors
		public CinemachineShot() {} // 0x0000000186697F30-0x0000000186697F90
	
		// Methods
		// [XID] // 0x00000001899C9100-0x00000001899C9120
		public override Playable CreatePlayable(PlayableGraph graph, GameObject owner) => default; // 0x0000000186697BE0-0x0000000186697D90
		// [XID] // 0x0000000189A47B10-0x0000000189A47B30
		public void GatherProperties(PlayableDirector director, IPropertyCollector driver) {} // 0x0000000186697D90-0x0000000186697F30
	}
}
