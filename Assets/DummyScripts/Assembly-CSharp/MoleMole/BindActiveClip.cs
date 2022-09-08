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
	public sealed class BindActiveClip : PlayableAsset, ITimelineClipAsset // TypeDefIndex: 26126
	{
		// Fields
		public BindActiveBehaviour template; // 0x18
		public ExposedReference<Transform> parentNode; // 0x20
	
		// Properties
		public ClipCaps clipCaps { /* [XID] */ /* 0x000000018968E210-0x000000018968E230 */ get => default; } // 0x0000000181AD5D30-0x0000000181AD5DD0 
	
		// Constructors
		public BindActiveClip() {} // 0x0000000181AD5C60-0x0000000181AD5D30
	
		// Methods
		// [XID] // 0x0000000189695AC0-0x0000000189695AE0
		public override Playable CreatePlayable(PlayableGraph graph, GameObject owner) => default; // 0x0000000181AD5AA0-0x0000000181AD5C60
	}
}
