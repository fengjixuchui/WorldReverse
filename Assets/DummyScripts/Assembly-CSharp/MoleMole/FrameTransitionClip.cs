/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	[Serializable]
	public sealed class FrameTransitionClip : PlayableAsset, ITimelineClipAsset // TypeDefIndex: 26178
	{
		// Fields
		public FrameTransitionBehaviour template; // 0x18
		private TimelineClip _clip; // 0x20
	
		// Properties
		public ClipCaps clipCaps { /* [XID] */ /* 0x0000000189A46910-0x0000000189A46930 */ get => default; } // 0x0000000181F7DB00-0x0000000181F7DBA0 
	
		// Constructors
		public FrameTransitionClip() {} // 0x0000000181F7DA20-0x0000000181F7DB00
	
		// Methods
		// [XID] // 0x0000000189A4E140-0x0000000189A4E160
		public void RefreshClip(TimelineClip clip) {} // 0x0000000181F7D970-0x0000000181F7DA20
		// [XID] // 0x0000000189A559B0-0x0000000189A559D0
		public override Playable CreatePlayable(PlayableGraph graph, GameObject owner) => default; // 0x0000000181F7D7C0-0x0000000181F7D970
	}
}
