/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace motion4hi
{
	public class TiltController : MonoBehaviour // TypeDefIndex: 9393
	{
		// Fields
		public float _tiltAxisHeight; // 0x18
		public float _maxTilt; // 0x1C
		public float _tiltSpeedCoeff; // 0x20
		public float _recoverSpeed; // 0x24
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public float _currTilt; // 0x28
		private GameObject _bipRootGo; // 0x30
		private Animator _animator; // 0x38
	
		// Constructors
		public TiltController() {} // 0x00000001853E30B0-0x00000001853E3130
	
		// Methods
		// [XID] // 0x0000000189901780-0x00000001899017A0
		public float CalcTiltByYawDelta(float yawSpeed, float toDesiredYaw, float tiltCoeff) => default; // 0x00000001853E2A80-0x00000001853E2C40
		// [XID] // 0x000000018975E0D0-0x000000018975E0F0
		private void Start() {} // 0x00000001853E2FA0-0x00000001853E30B0
		// [XID] // 0x0000000189A610F0-0x0000000189A61110
		private void LateUpdate() {} // 0x00000001853E2C40-0x00000001853E2FA0
	}
}
