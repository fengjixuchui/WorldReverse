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
	public struct HomeworldCustomBoundData // TypeDefIndex: 20392
	{
		// Fields
		public Vector3 localRotation; // 0x00
		public Vector3 localDirection; // 0x0C
		public Bounds localBound; // 0x18
		public HomeworldSurfaceAxis boundAxis; // 0x30
		public Collider customCollider; // 0x38
	
		// Constructors
		public HomeworldCustomBoundData(HomeworldSurfaceAxis boundAxis) {
			localRotation = default;
			localDirection = default;
			localBound = default;
			this.boundAxis = default;
			customCollider = default;
		} // 0x0000000182BAF200-0x0000000182BAF230
	}
}
