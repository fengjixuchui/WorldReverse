/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired;
using UnityEngine;

// Image 39: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3466-4436

namespace Rewired.ComponentControls.Effects
{
	public class RotateAroundAxis : MonoBehaviour // TypeDefIndex: 3545
	{
		// Fields
		[CustomObfuscation] // 0x0000000189B543F0-0x0000000189B54450
		[SerializeField] // 0x0000000189B543F0-0x0000000189B54450
		// [Tooltip] // 0x0000000189B543F0-0x0000000189B54450
		private Speed _speed; // 0x18
		[CustomObfuscation] // 0x0000000189B63510-0x0000000189B63570
		[SerializeField] // 0x0000000189B63510-0x0000000189B63570
		// [Tooltip] // 0x0000000189B63510-0x0000000189B63570
		private float _slowRotationSpeed; // 0x1C
		[CustomObfuscation] // 0x0000000189B724E0-0x0000000189B72540
		[SerializeField] // 0x0000000189B724E0-0x0000000189B72540
		// [Tooltip] // 0x0000000189B724E0-0x0000000189B72540
		private float _fastRotationSpeed; // 0x20
		[CustomObfuscation] // 0x0000000189B80D10-0x0000000189B80D70
		[SerializeField] // 0x0000000189B80D10-0x0000000189B80D70
		// [Tooltip] // 0x0000000189B80D10-0x0000000189B80D70
		private RotationAxis _rotateAroundAxis; // 0x24
		[CustomObfuscation] // 0x0000000189B8FBB0-0x0000000189B8FC10
		[SerializeField] // 0x0000000189B8FBB0-0x0000000189B8FC10
		// [Tooltip] // 0x0000000189B8FBB0-0x0000000189B8FC10
		private Space _relativeTo; // 0x28
		[CustomObfuscation] // 0x0000000189B9E540-0x0000000189B9E5A0
		[SerializeField] // 0x0000000189B9E540-0x0000000189B9E5A0
		// [Tooltip] // 0x0000000189B9E540-0x0000000189B9E5A0
		private bool _reverse; // 0x2C
	
		// Properties
		public Speed speed { get => default; set {} } // 0x0000000185AA88A0-0x0000000185AA8900 0x0000000185AA8B00-0x0000000185AA8B60
		public float slowRotationSpeed { get => default; set {} } // 0x0000000185AA8830-0x0000000185AA88A0 0x0000000185AA8A90-0x0000000185AA8B00
		public float fastRotationSpeed { get => default; set {} } // 0x0000000185AA86A0-0x0000000185AA8710 0x0000000185AA8900-0x0000000185AA8970
		public RotationAxis rotateAroundAxis { get => default; set {} } // 0x0000000185AA87D0-0x0000000185AA8830 0x0000000185AA8A30-0x0000000185AA8A90
		public Space relativeTo { get => default; set {} } // 0x0000000185AA8710-0x0000000185AA8770 0x0000000185AA8970-0x0000000185AA89D0
		public bool reverse { get => default; set {} } // 0x0000000185AA8770-0x0000000185AA87D0 0x0000000185AA89D0-0x0000000185AA8A30
	
		// Nested types
		public enum Speed // TypeDefIndex: 3546
		{
			Stopped = 0,
			Slow = 1,
			Fast = 2
		}
	
		public enum RotationAxis // TypeDefIndex: 3547
		{
			X = 0,
			Y = 1,
			Z = 2
		}
	
		// Constructors
		public RotateAroundAxis() {} // 0x0000000185AA8620-0x0000000185AA86A0
	
		// Methods
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		private void Update() {} // 0x0000000185AA83D0-0x0000000185AA8620
		private static Vector3 zJvhqntnnnvGRcdbSnXecZdmqBX(RotationAxis param_00007da8) => default; // 0x0000000185AA8B60-0x0000000185AA8CC0
		public void SetSpeed(Speed speed) {} // 0x0000000185AA8370-0x0000000185AA83D0
		public void SetSpeed(int speed) {} // 0x0000000185AA8280-0x0000000185AA8370
	}
}
