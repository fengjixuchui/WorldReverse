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

public sealed class VCPlatformAudio : VCGadgetAudio // TypeDefIndex: 11931
{
	// Fields
	private const float AVG_LINEAR_SPEED_THRESHOLD = 0.01f; // Metadata: 0x00AEAF61
	private const float AVG_ANGULAR_SPEED_THRESHOLD = 0.01f; // Metadata: 0x00AEAF65
	private readonly MovingAverageSpeed _movingAverage; // 0x148
	private AudioPlatformMoveSettings _moveSettings; // 0x150
	private Transform _transform; // 0x180
	private Vector3 _lastPosition; // 0x188
	private Quaternion _lastRotation; // 0x194
	private bool _trackLinear; // 0x1A4
	private bool _trackAngular; // 0x1A5
	private float _linearVelocityThreshold; // 0x1A8
	private float _angularVelocityThreashold; // 0x1AC
	private bool _virgin; // 0x1B0

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x00000001896F4D00-0x00000001896F4D20 */ get => default; } // 0x00000001838F5E60-0x00000001838F5F00 

	// Nested types
	private class MovingAverageSpeed // TypeDefIndex: 11932
	{
		// Fields
		private const int WINDOWS_SIZE = 4; // Metadata: 0x00AEAF69
		private readonly Record[] _records; // 0x10
		private float _sumDistance; // 0x18
		private float _sumAngle; // 0x1C
		private float _sumDeltaTime; // 0x20
		private int _workingIndex; // 0x24

		// Properties
		public float averageLinearSpeed { /* [XID] */ /* 0x00000001897545D0-0x0000000189754610 */ get; /* [XID] */ /* 0x000000018975EBD0-0x000000018975EC10 */ private set; } // 0x00000001838FB6C0-0x00000001838FB730 0x00000001838FB650-0x00000001838FB6C0
		public float averageAngularSpeed { /* [XID] */ /* 0x0000000189768FF0-0x0000000189769030 */ get; /* [XID] */ /* 0x00000001897736C0-0x0000000189773700 */ private set; } // 0x00000001838FB7A0-0x00000001838FB810 0x00000001838FB730-0x00000001838FB7A0

		// Nested types
		private struct Record // TypeDefIndex: 11933
		{
			// Fields
			public float movedDistance; // 0x00
			public float rotatedAngle; // 0x04
			public float timeElapsed; // 0x08

			// Methods
			// [XID] // 0x000000018978CCC0-0x000000018978CCE0
			public void Clear() {} // 0x00000001838FB1A0-0x00000001838FB1B0
		}

		// Constructors
		public MovingAverageSpeed() {} // 0x00000001838FB810-0x00000001838FB930

		// Methods
		// [XID] // 0x000000018977DE30-0x000000018977DE50
		public void TakeSample(float distance, float angle, float deltaTime) {} // 0x00000001838FB1B0-0x00000001838FB4F0
		// [XID] // 0x00000001897857A0-0x00000001897857C0
		public void Reset() {} // 0x00000001838FB4F0-0x00000001838FB650
	}

	// Constructors
	public VCPlatformAudio() {} // 0x00000001838F5DD0-0x00000001838F5E60

	// Methods
	// [XID] // 0x00000001896FC430-0x00000001896FC450
	protected override void InitInternal() {} // 0x00000001838F5360-0x00000001838F54A0
	// [XID] // 0x00000001897039E0-0x0000000189703A00
	protected override void ClearInternal() {} // 0x00000001838F5090-0x00000001838F5190
	// [XID] // 0x000000018970B1B0-0x000000018970B1D0
	protected override void Tick(float inDeltaTime) {} // 0x00000001838F5D10-0x00000001838F5DD0
	// [XID] // 0x00000001897129F0-0x0000000189712A10
	private void TickWhetherMoving(float inDeltaTime) {} // 0x00000001838F5830-0x00000001838F5D10
	// [XID] // 0x000000018971A2F0-0x000000018971A310
	private void PostMoveStatusEvent(bool isMoving) {} // 0x00000001838F4E90-0x00000001838F4F80
	// [XID] // 0x00000001897215E0-0x0000000189721600
	private void PostRotateStatusEvent(bool isRotating) {} // 0x00000001838F5190-0x00000001838F5280
	// [XID] // 0x0000000189728C20-0x0000000189728C40
	private Transform GetTransformFromEntity(BaseEntity entity) => default; // 0x00000001838F4F80-0x00000001838F5090
	// [XID] // 0x0000000189730650-0x0000000189730670
	private AudioPlatformMoveSettings GetMoveSettingsFromEntity(BaseEntity entity) => default; // 0x00000001838F5600-0x00000001838F57C0
	// [XID] // 0x0000000189737E30-0x0000000189737E50
	private void SetFieldsAccodingToSettings() {} // 0x00000001838F54A0-0x00000001838F5600
}

