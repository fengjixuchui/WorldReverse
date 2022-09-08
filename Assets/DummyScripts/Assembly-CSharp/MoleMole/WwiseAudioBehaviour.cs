/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine.Playables;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	[Serializable]
	public sealed class WwiseAudioBehaviour : PlayableBehaviour // TypeDefIndex: 26263
	{
		// Fields
		public string soundName; // 0x10
		private bool _hasConverted; // 0x18
		private uint _soundHashId; // 0x1C
		private bool _needPlay; // 0x20
		private bool _isPlaying; // 0x21
	
		// Properties
		private uint soundHashId { /* [XID] */ /* 0x0000000189B238D0-0x0000000189B238F0 */ get => default; } // 0x0000000181D90240-0x0000000181D90360 
	
		// Constructors
		public WwiseAudioBehaviour() {} // 0x0000000181D901C0-0x0000000181D90240
	
		// Methods
		// [XID] // 0x0000000189B2ABB0-0x0000000189B2ABD0
		public override void OnGraphStart(Playable playable) {} // 0x0000000181D8FD80-0x0000000181D8FE30
		// [XID] // 0x0000000189B320E0-0x0000000189B32100
		public override void OnGraphStop(Playable playable) {} // 0x0000000181D8FE30-0x0000000181D8FEE0
		// [XID] // 0x0000000189B39990-0x0000000189B399B0
		public override void OnBehaviourPlay(Playable playable, FrameData info) {} // 0x0000000181D8FC20-0x0000000181D8FD80
		// [XID] // 0x0000000189B41310-0x0000000189B41330
		public override void OnBehaviourPause(Playable playable, FrameData info) {} // 0x0000000181D8FAC0-0x0000000181D8FC20
		// [XID] // 0x0000000189B48BE0-0x0000000189B48C00
		public override void ProcessFrame(Playable playable, FrameData info, object playerData) {} // 0x0000000181D8FFD0-0x0000000181D901C0
		// [XID] // 0x0000000189B50370-0x0000000189B50390
		public override void OnPlayableDestroy(Playable playable) {} // 0x0000000181D8FEE0-0x0000000181D8FFD0
	}
}
