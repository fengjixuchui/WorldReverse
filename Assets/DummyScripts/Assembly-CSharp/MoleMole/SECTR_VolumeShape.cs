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
	[Serializable]
	public class SECTR_VolumeShape // TypeDefIndex: 31867
	{
		// Fields
		public AreaType type; // 0x10
		public BakeSet clusterSet; // 0x18
		public int tileSize; // 0x20
		public Bounds bounds; // 0x24
		public string shapeName; // 0x40
		private BaseShape shape; // 0x48
	
		// Nested types
		public enum AreaType // TypeDefIndex: 31868
		{
			Cluster = 0,
			Shape = 1
		}
	
		// Constructors
		public SECTR_VolumeShape() {} // 0x0000000184EEDE40-0x0000000184EEDEA0
	
		// Methods
		// [XID] // 0x0000000189A35F40-0x0000000189A35F60
		public void Init(Vector3 pos, Vector3 forward) {} // 0x0000000184EED4F0-0x0000000184EED8B0
		// [XID] // 0x0000000189A3D4C0-0x0000000189A3D4E0
		public BaseShape GetShap() => default; // 0x0000000184EED450-0x0000000184EED4F0
		// [XID] // 0x0000000189A44BF0-0x0000000189A44C10
		public bool ContainsPos(Vector3 pos) => default; // 0x0000000184EED8B0-0x0000000184EED9D0
		// [XID] // 0x0000000189A4C420-0x0000000189A4C440
		public bool Intersects(Bounds ibounds) => default; // 0x0000000184EEDD60-0x0000000184EEDE40
		// [XID] // 0x0000000189A53BC0-0x0000000189A53BE0
		private bool ClusterContainsPos(Vector3 pos) => default; // 0x0000000184EEDB70-0x0000000184EEDD60
		// [XID] // 0x0000000189A5B5A0-0x0000000189A5B5C0
		private bool ShapeContainsPos(Vector3 pos) => default; // 0x0000000184EED9D0-0x0000000184EEDB70
	}
}
