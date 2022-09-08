/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	[Serializable]
	public class MonoEffectElectricChain // TypeDefIndex: 19671
	{
		// Fields
		// [Header] // 0x0000000189694550-0x0000000189694580
		public LineRenderer lrComp; // 0x10
		public Transform endPoint; // 0x18
		// [Header] // 0x000000018969D560-0x000000018969D590
		public float detail; // 0x20
		// [Tooltip] // 0x00000001896A5E20-0x00000001896A5E50
		public DisplacType displacType; // 0x24
		// [Header] // 0x00000001896AEB60-0x00000001896AEB90
		public float displacement; // 0x28
		// [Header] // 0x00000001896B7920-0x00000001896B7950
		public float updateInterval; // 0x2C
		private float _nextUpdateTime; // 0x30
		private List<Vector3> _linePosList; // 0x38
		private Vector3 _startPos; // 0x40
		private Vector3 _endPos; // 0x4C
		public RandomType startRandomType; // 0x58
		// [Tooltip] // 0x00000001896C0350-0x00000001896C0380
		public Vector3 randomInStart; // 0x5C
		public RandomType endRandomType; // 0x68
		// [Tooltip] // 0x00000001896C8FA0-0x00000001896C8FD0
		public Vector3 randomInEnd; // 0x6C
	
		// Nested types
		public enum DisplacType // TypeDefIndex: 19672
		{
			ScaledFromStart2End = 0,
			DirectlyValue = 1
		}
	
		public enum RandomType // TypeDefIndex: 19673
		{
			Sphere = 0,
			Box = 1
		}
	
		// Constructors
		public MonoEffectElectricChain() {} // 0x000000018469CDB0-0x000000018469CEA0
	
		// Methods
		// [XID] // 0x00000001896D1EC0-0x00000001896D1EE0
		public Vector3 DoRandomPos(Transform center, Vector3 scale, RandomType randomType) => default; // 0x000000018469C3F0-0x000000018469C700
		// [XID] // 0x00000001896D9710-0x00000001896D9730
		public void Awake() {} // 0x000000018469BD40-0x000000018469C040
		// [XID] // 0x00000001896E0EB0-0x00000001896E0ED0
		public void Setup() {} // 0x000000018469C040-0x000000018469C0E0
		// [XID] // 0x00000001896E80E0-0x00000001896E8100
		public void SetDestroy() {} // 0x000000018469CCC0-0x000000018469CDB0
		// [XID] // 0x00000001896EF7A0-0x00000001896EF7C0
		public void OnDisabled() {} // 0x000000018469CC20-0x000000018469CCC0
		// [XID] // 0x00000001896F70B0-0x00000001896F70D0
		public void UpdateLine(float deltaTime) {} // 0x000000018469C700-0x000000018469CC20
		// [XID] // 0x00000001896FEA90-0x00000001896FEAB0
		private void Points(Vector3 startPos, Vector3 destPos, float displace) {} // 0x000000018469C0E0-0x000000018469C3F0
	}
}
