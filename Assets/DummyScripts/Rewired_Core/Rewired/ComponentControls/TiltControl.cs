/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired;
using Rewired.ComponentControls.Data;
using Rewired.Internal;
using UnityEngine;

// Image 39: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3466-4436

namespace Rewired.ComponentControls
{
	[Serializable]
	[DisallowMultipleComponent] // 0x00000001898F1200-0x00000001898F1210
	public sealed class TiltControl : CustomControllerControl // TypeDefIndex: 3543
	{
		// Fields
		private const float maxFullTiltAngle = 180f; // Metadata: 0x00AC3F8D
		private const float maxAngleOffset = 90f; // Metadata: 0x00AC3F91
		[CustomObfuscation] // 0x0000000189AB83C0-0x0000000189AB8420
		[SerializeField] // 0x0000000189AB83C0-0x0000000189AB8420
		// [Tooltip] // 0x0000000189AB83C0-0x0000000189AB8420
		private TiltDirection _allowedTiltDirections; // 0x28
		[CustomObfuscation] // 0x0000000189AC7AD0-0x0000000189AC7B30
		[SerializeField] // 0x0000000189AC7AD0-0x0000000189AC7B30
		// [Tooltip] // 0x0000000189AC7AD0-0x0000000189AC7B30
		private CustomControllerElementTargetSetForFloat _horizontalTiltCustomControllerElement; // 0x30
		[CustomObfuscation] // 0x0000000189AD6EA0-0x0000000189AD6F20
		// [Range] // 0x0000000189AD6EA0-0x0000000189AD6F20
		[SerializeField] // 0x0000000189AD6EA0-0x0000000189AD6F20
		// [Tooltip] // 0x0000000189AD6EA0-0x0000000189AD6F20
		private float _horizontalTiltLimit; // 0x38
		[CustomObfuscation] // 0x0000000189AE8CE0-0x0000000189AE8D60
		// [Range] // 0x0000000189AE8CE0-0x0000000189AE8D60
		[SerializeField] // 0x0000000189AE8CE0-0x0000000189AE8D60
		// [Tooltip] // 0x0000000189AE8CE0-0x0000000189AE8D60
		private float _horizontalRestAngle; // 0x3C
		[CustomObfuscation] // 0x0000000189AFB240-0x0000000189AFB2A0
		[SerializeField] // 0x0000000189AFB240-0x0000000189AFB2A0
		// [Tooltip] // 0x0000000189AFB240-0x0000000189AFB2A0
		private CustomControllerElementTargetSetForFloat _forwardTiltCustomControllerElement; // 0x40
		[CustomObfuscation] // 0x0000000189B09F80-0x0000000189B0A000
		// [Range] // 0x0000000189B09F80-0x0000000189B0A000
		[SerializeField] // 0x0000000189B09F80-0x0000000189B0A000
		// [Tooltip] // 0x0000000189B09F80-0x0000000189B0A000
		private float _forwardTiltLimit; // 0x48
		[CustomObfuscation] // 0x0000000189B1BB80-0x0000000189B1BC00
		// [Range] // 0x0000000189B1BB80-0x0000000189B1BC00
		[SerializeField] // 0x0000000189B1BB80-0x0000000189B1BC00
		// [Tooltip] // 0x0000000189B1BB80-0x0000000189B1BC00
		private float _forwardRestAngle; // 0x4C
		[CustomObfuscation] // 0x0000000189B2D3C0-0x0000000189B2D420
		[SerializeField] // 0x0000000189B2D3C0-0x0000000189B2D420
		// [Tooltip] // 0x0000000189B2D3C0-0x0000000189B2D420
		private StandaloneAxis2D _axis2D; // 0x50
		private bool _useHAxis; // 0x58
		private bool _useFAxis; // 0x59
		private Func<Vector3> _getAccelerationValue; // 0x60
	
		// Properties
		public TiltDirection axesToUse { get => default; set {} } // 0x00000001869F9660-0x00000001869F96C0 0x00000001869FA170-0x00000001869FA220
		public CustomControllerElementTargetSetForFloat horizontalTiltCustomControllerElement { get => default; } // 0x00000001869F9A60-0x00000001869F9AC0 
		public float horizontalTiltLimit { get => default; set {} } // 0x00000001869F9AC0-0x00000001869F9B30 0x00000001869FA450-0x00000001869FA500
		public float horizontalRestAngle { get => default; set {} } // 0x00000001869F99F0-0x00000001869F9A60 0x00000001869FA3A0-0x00000001869FA450
		public CustomControllerElementTargetSetForFloat forwardTiltCustomControllerElement { get => default; } // 0x00000001869F9890-0x00000001869F98F0 
		public float forwardTiltLimit { get => default; set {} } // 0x00000001869F98F0-0x00000001869F9960 0x00000001869FA2D0-0x00000001869FA3A0
		public float forwardRestAngle { get => default; set {} } // 0x00000001869F9820-0x00000001869F9890 0x00000001869FA220-0x00000001869FA2D0
		public AxisCalibration horizontalAxisCalibration { get => default; } // 0x00000001869F9960-0x00000001869F99F0 
		public AxisCalibration verticalAxisCalibration { get => default; } // 0x00000001869F9B30-0x00000001869F9BC0 
		[Obsolete] // 0x0000000189B4B420-0x0000000189B4B450
		public Axis2DCalibration deadZoneType { get => default; } // 0x00000001869F97A0-0x00000001869F9820 
		public Axis2DCalibration axis2DCalibration { get => default; } // 0x00000001869F96C0-0x00000001869F9740 
		internal StandaloneAxis2D axis2D { get => default; } // 0x00000001869F9740-0x00000001869F97A0 
		private Vector3 acceleration { get => default; } // 0x00000001869F9580-0x00000001869F9660 
	
		// Nested types
		public enum TiltDirection // TypeDefIndex: 3544
		{
			Both = 0,
			Horizontal = 1,
			Forward = 2
		}
	
		// Constructors
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		internal TiltControl() {} // 0x00000001869F94A0-0x00000001869F9580
	
		// Methods
		public void SetAccelerationSourceCallback(Func<Vector3> callback) {} // 0x00000001869F9320-0x00000001869F9380
		public void SetRestOrientation() {} // 0x00000001869F9380-0x00000001869F94A0
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		internal override void OnValidate() {} // 0x00000001869F9280-0x00000001869F9320
		internal override bool OnInitialize() => default; // 0x00000001869F9180-0x00000001869F9200
		internal override void OnUpdate() {} // 0x00000001869F9200-0x00000001869F9280
		internal override void OnCustomControllerUpdate() {} // 0x00000001869F8F60-0x00000001869F9180
		public override void ClearValue() {} // 0x00000001869F8CB0-0x00000001869F8E10
		private void kkNtqoBQUYwvhEbXKGKeVpYNbCJH() {} // 0x00000001869F9BC0-0x00000001869F9FD0
		private void GLLpRqMUycWVjUBpMRnWmbEUcQO() {} // 0x00000001869F8E10-0x00000001869F8F60
		private void nyzmpEWTMknZYhaJEGiQjqKBXpbI(TiltDirection param_00007da1) {} // 0x00000001869F9FD0-0x00000001869FA170
	}
}
