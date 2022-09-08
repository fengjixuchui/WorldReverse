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

namespace miHoYoEmotion
{
	[Serializable]
	public class BoneShape // TypeDefIndex: 8498
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		public Transform bone; // 0x10
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		public Vector3 endPosition; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		public Vector3 endRotation; // 0x24
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		public Vector3 endScale; // 0x30
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		public bool lockPosition; // 0x3C
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		public bool lockRotation; // 0x3D
		public Vector3 neutralPosition; // 0x40
		public Vector3 neutralRotation; // 0x4C
		public Vector3 neutralScale; // 0x58
	
		// Constructors
		public BoneShape(Transform bone, Vector3 endPosition, Vector3 endRotation, Vector3 endScale) {} // 0x0000000187318D10-0x0000000187318E20
		public BoneShape(Transform bone, Vector3 endPosition, Vector3 endRotation) {} // 0x0000000187318BF0-0x0000000187318D10
		public BoneShape() {} // 0x0000000187318E20-0x0000000187318EE0
	
		// Methods
		// [XID] // 0x0000000189B2BC60-0x0000000189B2BC80
		public void SetNeutral() {} // 0x0000000187318A90-0x0000000187318BF0
	}
}
