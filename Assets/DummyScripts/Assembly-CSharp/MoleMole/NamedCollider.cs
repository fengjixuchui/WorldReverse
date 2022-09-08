/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	[Serializable]
	public class NamedCollider // TypeDefIndex: 31760
	{
		// Fields
		[NonSerialized]
		public uint index; // 0x10
		public string name; // 0x18
		public Collider collider; // 0x20
		public bool lockable; // 0x28
		public HitBoxType hitBoxType; // 0x2C
		public Transform[] hitObjects; // 0x30
		public float[] hitObjectsRadius; // 0x38
		public Renderer[] renderers; // 0x40
	
		// Constructors
		public NamedCollider() {} // 0x00000001824B0E70-0x00000001824B0EE0
	}
}
