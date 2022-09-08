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
using UnityEngine.Playables;
using UnityEngine.Timeline;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole.Timeline
{
	[Serializable]
	[NotKeyable] // 0x00000001899ABA00-0x00000001899ABA10
	public sealed class MihoyoControlPlayableAsset : ControlPlayableAsset // TypeDefIndex: 26214
	{
		// Fields
		public MihoyoControlBehavior template; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		public ExposedReference<Transform> bindingTransform; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		public bool controlScale; // 0x70
	
		// Constructors
		public MihoyoControlPlayableAsset() {} // 0x0000000182B13D60-0x0000000182B13E50
	
		// Methods
		// [XID] // 0x0000000189683410-0x0000000189683430
		public override Playable CreatePlayable(PlayableGraph graph, GameObject go) => default; // 0x0000000182B12D30-0x0000000182B13CB0
		// [XID] // 0x000000018968AFA0-0x000000018968AFC0
		private static Playable ConnectPlayablesToMixer(Playable playable, PlayableGraph graph, List<Playable> playables) => default; // 0x0000000182B128D0-0x0000000182B12B90
		// [XID] // 0x0000000189692D30-0x0000000189692D50
		private static new void ConnectMixerAndPlayable(PlayableGraph graph, Playable mixer, Playable playable, int portIndex) {} // 0x0000000182B12780-0x0000000182B128D0
		// [XID] // 0x0000000189699F60-0x0000000189699F80
		private new void CreateActivationPlayable(GameObject root, PlayableGraph graph, List<Playable> outplayables) {} // 0x0000000182B12B90-0x0000000182B12D30
	}
}
