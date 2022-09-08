/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public class SkeletonBindings : MonoBehaviour // TypeDefIndex: 14436
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private uint[] _BoneHashes; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform[] _Bones; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private LodMeshSelector[] _NotifyLodSelectors; // 0x28
	
		// Properties
		public uint[] sortedHashIndex { /* [XID] */ /* 0x0000000189A92B00-0x0000000189A92B20 */ get => default; } // 0x0000000184EF9BE0-0x0000000184EF9C80 
		public Transform[] sortedTransforms { /* [XID] */ /* 0x0000000189A9A5E0-0x0000000189A9A600 */ get => default; } // 0x0000000184EF9C80-0x0000000184EF9D20 
		public LodMeshSelector[] notifyLodSelectors { /* [XID] */ /* 0x0000000189AA1640-0x0000000189AA1660 */ get => default; /* [XID] */ /* 0x0000000189AA8CF0-0x0000000189AA8D10 */ set {} } // 0x0000000184EF9B40-0x0000000184EF9BE0 0x0000000184EF9D20-0x0000000184EF9DD0
	
		// Nested types
		private class HashArrayElement // TypeDefIndex: 14437
		{
			// Fields
			public uint hash; // 0x10
			public int idx; // 0x14
	
			// Constructors
			public HashArrayElement() {} // 0x0000000184EDC5D0-0x0000000184EDC6C0
		}
	
		private class HashArrayElementSorter : IComparer // TypeDefIndex: 14438
		{
			// Constructors
			public HashArrayElementSorter() {} // 0x0000000184EE3F70-0x0000000184EE3FD0
	
			// Methods
			// [XID] // 0x0000000189AB7F00-0x0000000189AB7F20
			public int Compare(object x, object y) => default; // 0x0000000184EE3E50-0x0000000184EE3F70
		}
	
		// Constructors
		public SkeletonBindings() {} // 0x0000000184EF9AE0-0x0000000184EF9B40
	
		// Methods
		// [XID] // 0x0000000189A83BC0-0x0000000189A83BE0
		public void SetBones(uint[] bonehashes, Transform[] bones) {} // 0x0000000184EF9650-0x0000000184EF9AE0
		// [XID] // 0x0000000189A8B530-0x0000000189A8B550
		public Transform FindBone(uint hash) => default; // 0x0000000184EF93E0-0x0000000184EF94F0
		// [XID] // 0x0000000189AB0970-0x0000000189AB0990
		public void SelectLod(float[] lodconfig) {} // 0x0000000184EF94F0-0x0000000184EF9650
	}
}
