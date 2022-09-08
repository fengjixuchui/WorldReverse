/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public class MonoUIEffect : MonoBehaviour // TypeDefIndex: 30965
	{
		// Fields
		public GameObject effectObj; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _effectInstance; // 0x20
		private bool isActive; // 0x28
		private ParticleSystem[] _particles; // 0x30
	
		// Properties
		public bool isPlaying { /* [XID] */ /* 0x000000018996EB90-0x000000018996EBB0 */ get => default; } // 0x0000000184895820-0x0000000184895960 
	
		// Constructors
		public MonoUIEffect() {} // 0x00000001848957B0-0x0000000184895820
	
		// Methods
		// [XID] // 0x000000018993ADC0-0x000000018993ADE0
		private void Awake() {} // 0x0000000184894C60-0x0000000184894E30
		// [XID] // 0x0000000189941E10-0x0000000189941E30
		private void OnDestory() {} // 0x0000000184894E30-0x0000000184894F40
		// [XID] // 0x00000001899498D0-0x00000001899498F0
		private void OnEnable() {} // 0x00000001848950F0-0x0000000184895200
		// [XID] // 0x0000000189951300-0x0000000189951320
		private void OnDisable() {} // 0x0000000184895020-0x00000001848950F0
		// [XID] // 0x00000001899588F0-0x0000000189958910
		private void OnDestroy() {} // 0x0000000184894F40-0x0000000184895020
		// [XID] // 0x000000018995FF70-0x000000018995FF90
		public void SetActive(bool enable) {} // 0x0000000184895340-0x0000000184895460
		// [XID] // 0x0000000189967A10-0x0000000189967A30
		public void Play(bool enable = true /* Metadata: 0x00B11B1F */) {} // 0x0000000184895200-0x0000000184895340
		// [XID] // 0x0000000189976770-0x0000000189976790
		public void Stop(bool enable = true /* Metadata: 0x00B11B20 */, ParticleSystemStopBehavior behavior = ParticleSystemStopBehavior.StopEmitting /* Metadata: 0x00B11B21 */) {} // 0x0000000184895650-0x00000001848957B0
		// [XID] // 0x000000018997DBB0-0x000000018997DBD0
		public void SetColor(Color color) {} // 0x0000000184895460-0x0000000184895650
	}
}
