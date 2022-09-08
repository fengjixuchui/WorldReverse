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

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	[Serializable]
	public sealed class RadialBlurBehaviour : PlayableBehaviour // TypeDefIndex: 26232
	{
		// Fields
		public bool radialBlurEnable; // 0x10
		public Vector2 radialCenter; // 0x14
		public float radialRadius; // 0x1C
		public bool amountUseCurve; // 0x20
		public float radialAmount; // 0x24
		public AnimationCurve radialAmountCurve; // 0x28
		internal float normalizedTime; // 0x30
		private float _duration; // 0x34
	
		// Constructors
		public RadialBlurBehaviour() {} // 0x0000000183BBD380-0x0000000183BBD3E0
	
		// Methods
		// [XID] // 0x00000001898B9D30-0x00000001898B9D50
		public override void OnGraphStart(Playable playable) {} // 0x0000000183BBD170-0x0000000183BBD250
		// [XID] // 0x00000001898C0FF0-0x00000001898C1010
		public override void PrepareFrame(Playable playable, FrameData info) {} // 0x0000000183BBD250-0x0000000183BBD380
	}
}
