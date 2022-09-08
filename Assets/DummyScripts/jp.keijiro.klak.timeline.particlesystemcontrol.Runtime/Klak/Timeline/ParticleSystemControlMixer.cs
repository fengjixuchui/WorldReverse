/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Playables;

// Image 58: jp.keijiro.klak.timeline.particlesystemcontrol.Runtime.dll - Assembly: jp.keijiro.klak.timeline.particlesystemcontrol.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6700-6704

namespace Klak.Timeline
{
	[Serializable]
	public class ParticleSystemControlMixer : PlayableBehaviour // TypeDefIndex: 6702
	{
		// Fields
		public Transform snapTarget; // 0x10
		public uint randomSeed; // 0x18
		private bool _needRestart; // 0x28
	
		// Properties
		public ParticleSystem particleSystem { get; set; } // 0x0000000189556DC0-0x0000000189556E20 0x0000000189556E20-0x0000000189556E80
	
		// Constructors
		public ParticleSystemControlMixer() {} // 0x0000000189556D50-0x0000000189556DC0
	
		// Methods
		private void PrepareParticleSystem(Playable playable) {} // 0x00000001895560B0-0x0000000189556360
		private void ResetSimulation(float time) {} // 0x0000000189556B90-0x0000000189556D50
		public override void OnGraphStart(Playable playable) {} // 0x0000000189555F60-0x00000001895560B0
		public override void ProcessFrame(Playable playable, FrameData info, object playerData) {} // 0x0000000189556360-0x0000000189556B90
	}
}
