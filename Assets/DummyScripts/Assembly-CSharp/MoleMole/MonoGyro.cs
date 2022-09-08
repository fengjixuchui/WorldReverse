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
	public class MonoGyro : MonoBehaviour // TypeDefIndex: 30799
	{
		// Fields
		public GyroMoveType type; // 0x18
		public float GYRO_ROTATE_SPD_X; // 0x1C
		public float GYRO_ROTATE_SPD_Y; // 0x20
		private Quaternion _lastGyroAttitude; // 0x24
		private Quaternion _orignQuaternion; // 0x34
		private bool _initialized; // 0x44
	
		// Nested types
		public enum GyroMoveType // TypeDefIndex: 30800
		{
			Forward = 0,
			Reverse = 1
		}
	
		// Constructors
		public MonoGyro() {} // 0x0000000184083B90-0x0000000184083C60
	
		// Methods
		// [XID] // 0x0000000189B05990-0x0000000189B059B0
		public void OnEnable() {} // 0x00000001840839A0-0x0000000184083AF0
		// [XID] // 0x0000000189B0D0E0-0x0000000189B0D100
		public void Update() {} // 0x0000000184083AF0-0x0000000184083B90
		// [XID] // 0x0000000189B14690-0x0000000189B146B0
		private void UpdateGyro() {} // 0x0000000184083500-0x00000001840839A0
	}
}
