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

namespace RootMotion.Dynamics
{
	[Serializable]
	public class SubBehaviourBalancer : SubBehaviourBase // TypeDefIndex: 9881
	{
		// Fields
		private Settings settings; // 0x60
		private Rigidbody[] rigidbodies; // 0x68
		private Transform[] copPoints; // 0x70
		private PressureSensor pressureSensor; // 0x78
		private Rigidbody Ibody; // 0x80
		private Vector3 I; // 0x88
		private Quaternion toJointSpace; // 0x94
	
		// Properties
		public ConfigurableJoint joint { /* [XID] */ /* 0x00000001898592E0-0x0000000189859320 */ get; /* [XID] */ /* 0x00000001898637F0-0x0000000189863830 */ private set; } // 0x000000018779C360-0x000000018779C3C0 0x000000018779C5F0-0x000000018779C650
		public Vector3 dir { get; /* [XID] */ /* 0x0000000189874BF0-0x0000000189874C30 */ private set; } // 0x000000018779C2F0-0x000000018779C360 0x000000018779C580-0x000000018779C5F0
		public Vector3 dirVel { /* [XID] */ /* 0x000000018987F550-0x000000018987F590 */ get; /* [XID] */ /* 0x0000000189889850-0x0000000189889890 */ private set; } // 0x000000018779C280-0x000000018779C2F0 0x000000018779C510-0x000000018779C580
		public Vector3 cop { /* [XID] */ /* 0x0000000189893D80-0x0000000189893DC0 */ get; /* [XID] */ /* 0x000000018989E070-0x000000018989E0B0 */ private set; } // 0x000000018779C210-0x000000018779C280 0x000000018779C4A0-0x000000018779C510
		public Vector3 com { /* [XID] */ /* 0x00000001898A8540-0x00000001898A8580 */ get; /* [XID] */ /* 0x00000001898B2DA0-0x00000001898B2DE0 */ private set; } // 0x000000018779C1A0-0x000000018779C210 0x000000018779C430-0x000000018779C4A0
		public Vector3 comV { /* [XID] */ /* 0x00000001898BD6C0-0x00000001898BD700 */ get; /* [XID] */ /* 0x00000001898C7FA0-0x00000001898C7FE0 */ private set; } // 0x000000018779C130-0x000000018779C1A0 0x000000018779C3C0-0x000000018779C430
	
		// Nested types
		[Serializable]
		public class Settings // TypeDefIndex: 9882
		{
			// Fields
			// [Tooltip] // 0x00000001898E1D20-0x00000001898E1D50
			public float damperForSpring; // 0x10
			// [Tooltip] // 0x00000001898EAEB0-0x00000001898EAEE0
			public float maxForceMlp; // 0x14
			// [Tooltip] // 0x00000001898F3FC0-0x00000001898F3FF0
			public float IMlp; // 0x18
			// [Tooltip] // 0x00000001898FCE20-0x00000001898FCE50
			public float velocityF; // 0x1C
			// [Tooltip] // 0x0000000189905EE0-0x0000000189905F10
			public Vector3 copOffset; // 0x20
			// [Tooltip] // 0x000000018990F0F0-0x000000018990F120
			public float torqueMlp; // 0x2C
			// [Tooltip] // 0x00000001899180E0-0x0000000189918110
			public float maxTorqueMag; // 0x30
	
			// Constructors
			public Settings() {} // 0x000000018779ACE0-0x000000018779AE30
		}
	
		// Constructors
		public SubBehaviourBalancer() {} // 0x000000018779C010-0x000000018779C130
	
		// Methods
		// [XID] // 0x0000000189711FB0-0x0000000189711FD0
		public void Initiate(BehaviourBase behaviour, Settings settings, Rigidbody Ibody, Rigidbody[] rigidbodies, ConfigurableJoint joint, Transform[] copPoints, PressureSensor pressureSensor) {} // 0x000000018779AFF0-0x000000018779B210
		// [XID] // 0x00000001898DA050-0x00000001898DA070
		private void Solve() {} // 0x000000018779B210-0x000000018779C010
	}
}
