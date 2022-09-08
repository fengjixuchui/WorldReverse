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

namespace RootMotion.FinalIK
{
	// [AddComponentMenu] // 0x00000001899345F0-0x0000000189934650
	// [HelpURL] // 0x00000001899345F0-0x0000000189934650
	public class RotationLimitHinge : RotationLimit // TypeDefIndex: 9849
	{
		// Fields
		public bool useLimits; // 0x50
		public float min; // 0x54
		public float max; // 0x58
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public float zeroAxisDisplayOffset; // 0x5C
		private Quaternion lastRotation; // 0x60
		private float lastAngle; // 0x70
	
		// Constructors
		public RotationLimitHinge() {} // 0x00000001868DC200-0x00000001868DC2B0
	
		// Methods
		// [ContextMenu] // 0x0000000189947D70-0x0000000189947DC0
		// [XID] // 0x0000000189947D70-0x0000000189947DC0
		private void OpenUserManual() {} // 0x00000001868DC0A0-0x00000001868DC150
		// [ContextMenu] // 0x0000000189952630-0x0000000189952680
		// [XID] // 0x0000000189952630-0x0000000189952680
		private void OpenScriptReference() {} // 0x00000001868DBFF0-0x00000001868DC0A0
		// [ContextMenu] // 0x000000018995CB30-0x000000018995CB80
		// [XID] // 0x000000018995CB30-0x000000018995CB80
		private void SupportGroup() {} // 0x00000001868DC150-0x00000001868DC200
		// [ContextMenu] // 0x00000001899675B0-0x0000000189967600
		// [XID] // 0x00000001899675B0-0x0000000189967600
		private void ASThread() {} // 0x00000001868DBA10-0x00000001868DBAC0
		// [XID] // 0x0000000189ABEE50-0x0000000189ABEE70
		protected override Quaternion LimitRotation(Quaternion rotation) => default; // 0x00000001868DBE90-0x00000001868DBFF0
		// [XID] // 0x0000000189AC6970-0x0000000189AC6990
		private Quaternion LimitHinge(Quaternion rotation) => default; // 0x00000001868DBAC0-0x00000001868DBE90
	}
}
