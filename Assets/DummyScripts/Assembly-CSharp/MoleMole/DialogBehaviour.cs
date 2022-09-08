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
	public sealed class DialogBehaviour : PlayableBehaviour // TypeDefIndex: 26145
	{
		// Fields
		public uint dialogID; // 0x10
		public float audioDelay; // 0x14
		public float subtitleDelay; // 0x18
		private bool _needPlay; // 0x1C
		private bool _isPlaying; // 0x1D
		private float _currTimer; // 0x20
	
		// Properties
		public bool canPlayAudio { /* [XID] */ /* 0x00000001897D4E20-0x00000001897D4E40 */ get => default; } // 0x0000000184D86440-0x0000000184D864F0 
		public bool canPlaySubtitle { /* [XID] */ /* 0x00000001897DC560-0x00000001897DC580 */ get => default; } // 0x0000000184D864F0-0x0000000184D865A0 
	
		// Constructors
		public DialogBehaviour() {} // 0x0000000184D863D0-0x0000000184D86440
	
		// Methods
		// [XID] // 0x00000001897E3F90-0x00000001897E3FB0
		public override void OnGraphStart(Playable playable) {} // 0x0000000184D85FD0-0x0000000184D86080
		// [XID] // 0x00000001897EBB00-0x00000001897EBB20
		public override void OnGraphStop(Playable playable) {} // 0x0000000184D86080-0x0000000184D86130
		// [XID] // 0x00000001897F3400-0x00000001897F3420
		public override void OnBehaviourPlay(Playable playable, FrameData info) {} // 0x0000000184D85E70-0x0000000184D85FD0
		// [XID] // 0x00000001897FADA0-0x00000001897FADC0
		public override void OnBehaviourPause(Playable playable, FrameData info) {} // 0x0000000184D85D10-0x0000000184D85E70
		// [XID] // 0x0000000189802300-0x0000000189802320
		public override void ProcessFrame(Playable playable, FrameData info, object playerData) {} // 0x0000000184D86220-0x0000000184D863D0
		// [XID] // 0x00000001898096E0-0x0000000189809700
		public override void OnPlayableDestroy(Playable playable) {} // 0x0000000184D86130-0x0000000184D86220
		// [XID] // 0x0000000189810EC0-0x0000000189810EE0
		private void PlayVoiceEvent() {} // 0x0000000184D85900-0x0000000184D85D10
	}
}
