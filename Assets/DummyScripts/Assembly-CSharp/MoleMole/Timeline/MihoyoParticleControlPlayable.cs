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

namespace MoleMole.Timeline
{
	public sealed class MihoyoParticleControlPlayable : PlayableBehaviour // TypeDefIndex: 26216
	{
		// Fields
		private const float kUnsetTime = -1f; // Metadata: 0x00B0BDA4
	
		// Properties
		public ParticleSystem particleSystem { /* [XID] */ /* 0x00000001896D30B0-0x00000001896D30F0 */ get; /* [XID] */ /* 0x00000001896DDAB0-0x00000001896DDAF0 */ private set; } // 0x0000000182B14E80-0x0000000182B14EE0 0x0000000182B14EE0-0x0000000182B14F40
	
		// Constructors
		public MihoyoParticleControlPlayable() {} // 0x0000000182B14E20-0x0000000182B14E80
	
		// Methods
		// [XID] // 0x00000001896CBD80-0x00000001896CBDA0
		public static ScriptPlayable<MihoyoParticleControlPlayable> Create(PlayableGraph graph, ParticleSystem component, uint randomSeed) => default; // 0x0000000182B14310-0x0000000182B14510
		// [XID] // 0x00000001896E7E90-0x00000001896E7EB0
		public void Initialize(ParticleSystem ps, uint randomSeed) {} // 0x0000000182B14510-0x0000000182B14610
		// [XID] // 0x00000001896EF5F0-0x00000001896EF610
		private void SetRandomSeed() {} // 0x0000000182B14A20-0x0000000182B14BE0
		// [XID] // 0x00000001896F6F20-0x00000001896F6F40
		public override void PrepareFrame(Playable playable, FrameData data) {} // 0x0000000182B14930-0x0000000182B14A20
		// [XID] // 0x00000001896FE7F0-0x00000001896FE810
		public override void OnBehaviourPlay(Playable playable, FrameData info) {} // 0x0000000182B14700-0x0000000182B14930
		// [XID] // 0x00000001897059F0-0x0000000189705A10
		public override void OnBehaviourPause(Playable playable, FrameData info) {} // 0x0000000182B14610-0x0000000182B14700
	}
}
