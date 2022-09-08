/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;
using UnityEngine.Serialization;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public class MonoAmbientAudio : MonoAudioTriggerHandler, IMonoAudioDispositioned, ISerializationCallbackReceiver // TypeDefIndex: 31651
	{
		// Fields
		private const float POSITION_CHECK_INTERVAL = 1f; // Metadata: 0x00B134BD
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Vector3[] _multiPositionArray; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private AkMultiPositionTypeLabel _multiPositionTypeLabel; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private AkMultiPositionType _multiPositionType; // 0x24
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private bool _static; // 0x28
		// [FormerlySerializedAs] // 0x00000001898E0760-0x00000001898E07A0
		[SerializeField] // 0x00000001898E0760-0x00000001898E07A0
		private string _startEventName; // 0x30
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private string _stopEventName; // 0x38
		[HideInInspector] // 0x00000001898EE050-0x00000001898EE080
		[SerializeField] // 0x00000001898EE050-0x00000001898EE080
		private Bounds _encapsulator; // 0x40
		private SyncId _syncId; // 0x58
		private Transform _cachedTransform; // 0x70
		private bool _hasConvertedStartEvent; // 0x78
		private bool _hasConvertedStopEvent; // 0x79
		private uint _startEventId; // 0x7C
		private uint _stopEventId; // 0x80
	
		// Properties
		public bool triggerToggle { /* [XID] */ /* 0x0000000189909330-0x0000000189909370 */ get; /* [XID] */ /* 0x0000000189913B90-0x0000000189913BD0 */ set; } // 0x0000000184C8A420-0x0000000184C8A480 0x0000000184C8A480-0x0000000184C8A4F0
		public Bounds encapsulator { /* [XID] */ /* 0x000000018991E630-0x000000018991E650 */ get => default; } // 0x0000000184C8A330-0x0000000184C8A420 
		private uint startEventId { /* [XID] */ /* 0x0000000189925E30-0x0000000189925E50 */ get => default; } // 0x0000000184C89780-0x0000000184C898A0 
		private uint stopEventId { /* [XID] */ /* 0x000000018992D3C0-0x000000018992D3E0 */ get => default; } // 0x0000000184C89440-0x0000000184C89570 
	
		// Constructors
		public MonoAmbientAudio() {} // 0x0000000184C8A2D0-0x0000000184C8A330
	
		// Methods
		// [XID] // 0x00000001899348F0-0x0000000189934910
		public override void HandleTrigger() {} // 0x0000000184C89570-0x0000000184C89780
		// [XID] // 0x000000018993C3C0-0x000000018993C3E0
		public void OnBeforeSerialize() {} // 0x0000000184C89970-0x0000000184C89A10
		// [XID] // 0x0000000189943A10-0x0000000189943A30
		public void OnAfterDeserialize() {} // 0x0000000184C898A0-0x0000000184C89970
		// [XID] // 0x000000018994AF70-0x000000018994AF90
		public void UpdateSync() {} // 0x0000000184C89F20-0x0000000184C8A2D0
		// [XID] // 0x00000001899528F0-0x0000000189952910
		protected virtual void Awake() {} // 0x0000000184C89310-0x0000000184C89440
		// [XID] // 0x0000000189959ED0-0x0000000189959EF0
		private void OnEnable() {} // 0x0000000184C89D90-0x0000000184C89F20
		// [XID] // 0x0000000189961900-0x0000000189961920
		private void OnDisable() {} // 0x0000000184C89A10-0x0000000184C89D90
	}
}
