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

namespace RootMotion
{
	public class SolverManager : MonoBehaviour // TypeDefIndex: 9952
	{
		// Fields
		// [Tooltip] // 0x0000000189700BB0-0x0000000189700BE0
		public bool fixTransforms; // 0x18
		private Animator animator; // 0x20
		private Animation legacy; // 0x28
		private bool updateFrame; // 0x30
		private bool componentInitiated; // 0x31
		private bool skipSolverUpdate; // 0x32
	
		// Properties
		private bool animatePhysics { /* [XID] */ /* 0x0000000189736670-0x0000000189736690 */ get => default; } // 0x00000001868E2870-0x00000001868E29C0 
		private bool isAnimated { /* [XID] */ /* 0x00000001898FC090-0x00000001898FC0B0 */ get => default; } // 0x00000001868E29C0-0x00000001868E2AE0 
	
		// Constructors
		public SolverManager() {} // 0x00000001868E2800-0x00000001868E2870
	
		// Methods
		// [XID] // 0x0000000189709BE0-0x0000000189709C00
		public void Disable() {} // 0x00000001868E1D70-0x00000001868E1E60
		// [XID] // 0x00000001897115E0-0x0000000189711600
		protected virtual void InitiateSolver() {} // 0x00000001868E2200-0x00000001868E22A0
		// [XID] // 0x0000000189BB3AD0-0x0000000189BB3AF0
		protected virtual void UpdateSolver() {} // 0x00000001868E26A0-0x00000001868E2740
		// [XID] // 0x000000018979F030-0x000000018979F050
		protected virtual void FixTransforms() {} // 0x00000001868E2090-0x00000001868E2130
		// [XID] // 0x0000000189727940-0x0000000189727960
		private void OnDisable() {} // 0x00000001868E2440-0x00000001868E24F0
		// [XID] // 0x00000001898BA620-0x00000001898BA640
		private void Start() {} // 0x00000001868E24F0-0x00000001868E25E0
		// [XID] // 0x000000018973E420-0x000000018973E440
		private void Initiate() {} // 0x00000001868E22A0-0x00000001868E2370
		// [XID] // 0x00000001897EA900-0x00000001897EA920
		private void Update() {} // 0x00000001868E2740-0x00000001868E2800
		// [XID] // 0x00000001897CC7D0-0x00000001897CC7F0
		private void FindAnimatorRecursive(Transform t, bool findInChildren) {} // 0x00000001868E1E60-0x00000001868E2090
		// [XID] // 0x00000001897F9EC0-0x00000001897F9EE0
		private void FixedUpdate() {} // 0x00000001868E2130-0x00000001868E2200
		// [XID] // 0x0000000189763480-0x00000001897634A0
		private void LateUpdate() {} // 0x00000001868E2370-0x00000001868E2440
		// [XID] // 0x000000018976ABF0-0x000000018976AC10
		public void UpdateSolverExternal() {} // 0x00000001868E25E0-0x00000001868E26A0
	}
}
