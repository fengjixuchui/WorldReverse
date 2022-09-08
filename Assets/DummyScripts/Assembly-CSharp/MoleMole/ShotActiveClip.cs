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
	public sealed class ShotActiveClip : PlayableAsset, ITimelineClipAsset // TypeDefIndex: 26241
	{
		// Fields
		public ShotActiveBehaviour template; // 0x18
		private TimelineClip _clip; // 0x20
	
		// Properties
		public ClipCaps clipCaps { /* [XID] */ /* 0x0000000189999CE0-0x0000000189999D00 */ get => default; } // 0x0000000184EF7F70-0x0000000184EF8010 
	
		// Constructors
		public ShotActiveClip() {} // 0x0000000184EF7E90-0x0000000184EF7F70
	
		// Methods
		// [XID] // 0x00000001899A1380-0x00000001899A13A0
		public void RefreshClip(TimelineClip clip) {} // 0x0000000184EF7DE0-0x0000000184EF7E90
		// [XID] // 0x00000001899A8DE0-0x00000001899A8E00
		public override Playable CreatePlayable(PlayableGraph graph, GameObject owner) => default; // 0x0000000184EF7C30-0x0000000184EF7DE0
	}
}
