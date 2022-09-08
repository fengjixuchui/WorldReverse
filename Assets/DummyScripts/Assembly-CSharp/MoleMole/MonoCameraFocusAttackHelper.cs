/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Cinemachine;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public class MonoCameraFocusAttackHelper : MonoBehaviour // TypeDefIndex: 14640
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _minDegreeX; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _maxDegreeX; // 0x1C
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _minLerpDegreeX; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _maxLerpDegreeX; // 0x24
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _targetAnchor; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _target; // 0x30
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		public CinemachineMixingCamera _mixingCamera; // 0x38
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		public Transform _cameraFollowLower; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		public Transform _cameraFollowUpper; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private bool _isTest; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _testDegree; // 0x54
	
		// Properties
		public float minDegreeX { /* [XID] */ /* 0x0000000189B57320-0x0000000189B57340 */ get => default; } // 0x0000000184805510-0x00000001848055C0 
		public float maxDegreeX { /* [XID] */ /* 0x0000000189647EE0-0x0000000189647F00 */ get => default; } // 0x00000001848053B0-0x0000000184805460 
		public float minLerpDegreeX { /* [XID] */ /* 0x000000018998CCC0-0x000000018998CCE0 */ get => default; } // 0x00000001848055C0-0x0000000184805670 
		public float maxLerpDegreeX { /* [XID] */ /* 0x0000000189656F60-0x0000000189656F80 */ get => default; } // 0x0000000184805460-0x0000000184805510 
		public Transform targetAnchor { /* [XID] */ /* 0x0000000189BDD2B0-0x0000000189BDD2D0 */ get => default; } // 0x0000000184805710-0x00000001848057B0 
		public Transform target { /* [XID] */ /* 0x0000000189665C80-0x0000000189665CA0 */ get => default; } // 0x00000001848057B0-0x0000000184805850 
		public CinemachineMixingCamera mixingCamera { /* [XID] */ /* 0x0000000189848A60-0x0000000189848A80 */ get => default; } // 0x0000000184805670-0x0000000184805710 
		public Transform cameraFollowLower { /* [XID] */ /* 0x0000000189675410-0x0000000189675430 */ get => default; } // 0x0000000184805270-0x0000000184805310 
		public Transform cameraFollowUpper { /* [XID] */ /* 0x00000001898107F0-0x0000000189810810 */ get => default; } // 0x0000000184805310-0x00000001848053B0 
	
		// Constructors
		public MonoCameraFocusAttackHelper() {} // 0x00000001848051D0-0x0000000184805270
	}
}
