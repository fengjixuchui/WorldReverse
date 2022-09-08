/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace UnityEngine.Rendering.PostProcessing
{
	// [AddComponentMenu] // 0x00000001896E1C80-0x00000001896E1CD0
	[ExecuteInEditMode] // 0x00000001896E1C80-0x00000001896E1CD0
	public sealed class PostProcessVolume : MonoBehaviour // TypeDefIndex: 9601
	{
		// Fields
		public PostProcessProfile sharedProfile; // 0x18
		// [Tooltip] // 0x00000001896ED620-0x00000001896ED650
		public bool isGlobal; // 0x20
		// [Min] // 0x00000001896F67E0-0x00000001896F6830
		// [Tooltip] // 0x00000001896F67E0-0x00000001896F6830
		public float blendDistance; // 0x24
		// [Range] // 0x00000001897023E0-0x0000000189702430
		// [Tooltip] // 0x00000001897023E0-0x0000000189702430
		public float weight; // 0x28
		// [Tooltip] // 0x000000018970E330-0x000000018970E360
		public float priority; // 0x2C
		private int m_PreviousLayer; // 0x30
		private float m_PreviousPriority; // 0x34
		private List<Collider> m_TempColliders; // 0x38
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private PostProcessProfile m_InternalProfile; // 0x40
	
		// Properties
		public PostProcessProfile profile { /* [XID] */ /* 0x000000018971E960-0x000000018971E980 */ get => default; /* [XID] */ /* 0x0000000189726100-0x0000000189726120 */ set {} } // 0x0000000185E0B840-0x0000000185E0BAC0 0x0000000185E0BAC0-0x0000000185E0BB70
		public PostProcessProfile profileRef { /* [XID] */ /* 0x000000018972D610-0x000000018972D630 */ get => default; } // 0x0000000185E0B750-0x0000000185E0B840 
	
		// Constructors
		public PostProcessVolume() {} // 0x0000000185E0B6D0-0x0000000185E0B750
	
		// Methods
		// [XID] // 0x0000000189734DF0-0x0000000189734E10
		private void OnEnable() {} // 0x0000000185E0B480-0x0000000185E0B590
		// [XID] // 0x00000001899A1590-0x00000001899A15B0
		private void OnDisable() {} // 0x0000000185E0AA80-0x0000000185E0AB40
		// [XID] // 0x00000001899A8F80-0x00000001899A8FA0
		private void Update() {} // 0x0000000185E0B590-0x0000000185E0B6D0
		// [XID] // 0x00000001899B0A30-0x00000001899B0A50
		private void OnDrawGizmos() {} // 0x0000000185E0AB40-0x0000000185E0B480
	}
}
