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
	public sealed class SelectActiveClip : PlayableAsset, ITimelineClipAsset // TypeDefIndex: 26237
	{
		// Fields
		public SelectActiveBehaviour template; // 0x18
		private TimelineClip _clip; // 0x20
	
		// Properties
		public ClipCaps clipCaps { /* [XID] */ /* 0x0000000189934E70-0x0000000189934E90 */ get => default; } // 0x0000000184EF08E0-0x0000000184EF0980 
	
		// Constructors
		public SelectActiveClip() {} // 0x0000000184EF0800-0x0000000184EF08E0
	
		// Methods
		// [XID] // 0x000000018993C9C0-0x000000018993C9E0
		public void RefreshClip(TimelineClip clip) {} // 0x0000000184EF0750-0x0000000184EF0800
		// [XID] // 0x0000000189943F70-0x0000000189943F90
		public override Playable CreatePlayable(PlayableGraph graph, GameObject owner) => default; // 0x0000000184EF05A0-0x0000000184EF0750
	}
}
