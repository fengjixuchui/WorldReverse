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
	public class MonoAudioEmitter : MonoBehaviour // TypeDefIndex: 31653
	{
		// Fields
		private const float MIN_INTERVAL = 0.05f; // Metadata: 0x00B134C1
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private string _startEvent; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private string _endEvent; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _interval; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _duration; // 0x2C
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private AkMultiPositionType _multiPositionType; // 0x30
		private GameObject _cachedGameObject; // 0x38
		private Transform _cachedTransform; // 0x40
		private uint _startEventId; // 0x48
		private uint _endEventId; // 0x4C
		private float _emitTimer; // 0x50
	
		// Constructors
		public MonoAudioEmitter() {} // 0x0000000184C9D0B0-0x0000000184C9D110
	
		// Methods
		// [XID] // 0x00000001899C7F40-0x00000001899C7F60
		private void Awake() {} // 0x0000000184C9CAF0-0x0000000184C9CC00
		// [XID] // 0x00000001899CF8E0-0x00000001899CF900
		private void OnEnable() {} // 0x0000000184C9CF20-0x0000000184C9CFC0
		// [XID] // 0x00000001899D6C80-0x00000001899D6CA0
		private void Update() {} // 0x0000000184C9CFC0-0x0000000184C9D0B0
		// [XID] // 0x00000001899DE300-0x00000001899DE320
		private void ValidateInterval() {} // 0x0000000184C9CC00-0x0000000184C9CD50
		// [XID] // 0x00000001899E6000-0x00000001899E6020
		private void SpawnEmitter() {} // 0x0000000184C9CD50-0x0000000184C9CF20
	}
}
