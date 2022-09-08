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
	public class MonoAsterScene : MonoBehaviour // TypeDefIndex: 29699
	{
		// Fields
		private float _rotateVelocity; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _rotationObjRoot; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _rotationObjInnerRoot; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _targetRoot; // 0x30
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Animator _animator; // 0x38
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _autoCloseTime; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _rotaRatio; // 0x44
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _successDelt; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _rotateReduceRatio; // 0x4C
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _rotateRatioForJoypad; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _joypadCheckRotationMin; // 0x54
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _joypadCheckRotationMax; // 0x58
		public Camera _asterCamera; // 0x60
		public Action CheckRotationFuc; // 0x68
		private Vector2 _startPos; // 0x70
	
		// Properties
		public Transform rotationObjRoot { /* [XID] */ /* 0x000000018991A0E0-0x000000018991A100 */ get => default; } // 0x0000000184C98090-0x0000000184C98130 
		public float autoCloseTime { /* [XID] */ /* 0x00000001899218E0-0x0000000189921900 */ get => default; } // 0x0000000184C97DD0-0x0000000184C97E80 
		public Animator animator { /* [XID] */ /* 0x0000000189929000-0x0000000189929020 */ get => default; } // 0x0000000184C97D30-0x0000000184C97DD0 
		public float rotateRatioForJoypad { /* [XID] */ /* 0x0000000189930550-0x0000000189930570 */ get => default; } // 0x0000000184C97FE0-0x0000000184C98090 
		public float joypadCheckRotationMin { /* [XID] */ /* 0x0000000189937AA0-0x0000000189937AC0 */ get => default; } // 0x0000000184C97F30-0x0000000184C97FE0 
		public float joypadCheckRotationMax { /* [XID] */ /* 0x000000018993F570-0x000000018993F590 */ get => default; } // 0x0000000184C97E80-0x0000000184C97F30 
	
		// Constructors
		public MonoAsterScene() {} // 0x0000000184C97C50-0x0000000184C97D30
	
		// Methods
		// [XID] // 0x0000000189946B40-0x0000000189946B60
		public void OnEnable() {} // 0x0000000184C972F0-0x0000000184C97440
		// [XID] // 0x000000018994E200-0x000000018994E220
		public void OnDisable() {} // 0x0000000184C97220-0x0000000184C972F0
		// [XID] // 0x00000001899557E0-0x0000000189955800
		public void RotateModelByDelta(float xDeltaDegree, float yDeltaDegree) {} // 0x0000000184C97440-0x0000000184C975E0
		// [XID] // 0x000000018995D300-0x000000018995D320
		public void RotationByAngle(float angle) {} // 0x0000000184C975E0-0x0000000184C97790
		// [XID] // 0x00000001899649B0-0x00000001899649D0
		private void Update() {} // 0x0000000184C979C0-0x0000000184C97C50
		// [XID] // 0x000000018996C090-0x000000018996C0B0
		public void TouchStart(Vector2 pos) {} // 0x0000000184C97850-0x0000000184C97910
		// [XID] // 0x0000000189973B20-0x0000000189973B40
		public void TouchUpdatePosition(Vector2 pos) {} // 0x0000000184C97910-0x0000000184C979C0
		// [XID] // 0x000000018997B170-0x000000018997B190
		public void TouchEnd() {} // 0x0000000184C97790-0x0000000184C97850
		// [XID] // 0x0000000189982C80-0x0000000189982CA0
		public bool isSucess() => default; // 0x0000000184C98130-0x0000000184C98370
	}
}
