/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using UnityEngine;
using UnityEngine.UI;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace EffectChecker
{
	public class ParticleEffectWindow : MonoBehaviour // TypeDefIndex: 19801
	{
		// Fields
		private const string FMT_FLOAT = "f2"; // Metadata: 0x00AFCEE2
		public UnityEngine.UI.Text particleLevel; // 0x18
		public UnityEngine.UI.Text previewSpeed; // 0x20
		public UnityEngine.UI.Text playbackTime; // 0x28
		public UnityEngine.UI.Text particles; // 0x30
		public UnityEngine.UI.Text particleSpeeds; // 0x38
		public EffectChecker effectChecker; // 0x40
		public Button playButton; // 0x48
		public InputField inputSpeed; // 0x50
		public InputField inputTime; // 0x58
		private Vector3 _scale; // 0x60
		private bool _active; // 0x6C
		private string[] _levelChar; // 0x70
		private int _particleEmitLevel; // 0x78
		private int _particleCount; // 0x7C
		private float _playbackTime; // 0x80
		private float _previewSpeed; // 0x84
		private float _fastestParticle; // 0x88
		private float _slowestParticle; // 0x8C
		private System.Type _particleSystemEditorUtilsType; // 0x90
		private MethodInfo _calculateEffectUIDataInfo; // 0x98
	
		// Properties
		public bool Active { get => default; set {} } // 0x0000000182BE6EB0-0x0000000182BE6F10 0x0000000182BE7040-0x0000000182BE7190
		private System.Type particleSystemEditorUtilsType { get => default; } // 0x0000000182BE6FE0-0x0000000182BE7040 
		private MethodInfo calculateEffectUIDataInfo { get => default; } // 0x0000000182BE6F10-0x0000000182BE6FE0 
	
		// Constructors
		public ParticleEffectWindow() {} // 0x0000000182BE6CA0-0x0000000182BE6EB0
	
		// Methods
		public void PrevEmitLevel() {} // 0x0000000182BE5CD0-0x0000000182BE5D50
		public void NextEmitLevel() {} // 0x0000000182BE59C0-0x0000000182BE5A40
		public static ParticleSystem GetRoot(ParticleSystem ps) => default; // 0x0000000182BE57F0-0x0000000182BE59C0
		private void Start() {} // 0x0000000182BE5F20-0x0000000182BE63C0
		private void OnEffectStop() {} // 0x0000000182BE5AE0-0x0000000182BE5B80
		private void OnEffectPlay() {} // 0x0000000182BE5A40-0x0000000182BE5AE0
		public void SimulateOrPause() {} // 0x0000000182BE5DC0-0x0000000182BE5F20
		public void Restart() {} // 0x0000000182BE5D50-0x0000000182BE5DC0
		public void Stop() {} // 0x0000000182BE63C0-0x0000000182BE6430
		public void OnSpeedEndEdit(string input) {} // 0x0000000182BE5B80-0x0000000182BE5C20
		public void OnTimeEndEdit(string input) {} // 0x0000000182BE5C20-0x0000000182BE5CD0
		private void Update() {} // 0x0000000182BE6430-0x0000000182BE6CA0
	}
}
