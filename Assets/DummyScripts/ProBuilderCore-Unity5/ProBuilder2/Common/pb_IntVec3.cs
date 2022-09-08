/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 38: ProBuilderCore-Unity5.dll - Assembly: ProBuilderCore-Unity5, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3356-3465

namespace ProBuilder2.Common
{
	public struct pb_IntVec3 : IEquatable<ProBuilder2.Common.pb_IntVec3> // TypeDefIndex: 3445
	{
		// Fields
		public Vector3 vec; // 0x00
		public const float RESOLUTION = 1000f; // Metadata: 0x00AC3D8E
	
		// Properties
		public float x { get => default; } // 0x0000000186BA3FE0-0x0000000186BA4050 
		public float y { get => default; } // 0x0000000186BA4050-0x0000000186BA4130 
		public float z { get => default; } // 0x0000000186BA4130-0x0000000186BA41A0 
	
		// Constructors
		public pb_IntVec3(Vector3 vector) : this() {
			vec = default;
		} // 0x0000000186BA3F60-0x0000000186BA3FE0
	
		// Methods
		public override string ToString() => default; // 0x0000000186BA3F50-0x0000000186BA3F60
		public static bool operator ==(pb_IntVec3 a, pb_IntVec3 b) => default; // 0x0000000186BA41A0-0x0000000186BA4230
		public static bool operator !=(pb_IntVec3 a, pb_IntVec3 b) => default; // 0x0000000186BA4360-0x0000000186BA4450
		public bool Equals(pb_IntVec3 p) => default; // 0x0000000186BA3CD0-0x0000000186BA3D80
		public bool Equals(Vector3 p) => default; // 0x0000000186BA3970-0x0000000186BA3AE0
		public override bool Equals(object b) => default; // 0x0000000186BA3AE0-0x0000000186BA3CD0
		public override int GetHashCode() => default; // 0x0000000186BA3D80-0x0000000186BA3F50
		private static int round(float v) => default; // 0x0000000186BA4450-0x0000000186BA44F0
		public static implicit operator Vector3(pb_IntVec3 p) => default; // 0x0000000186BA42F0-0x0000000186BA4360
		public static implicit operator pb_IntVec3(Vector3 p) => default; // 0x0000000186BA4230-0x0000000186BA42F0
	}
}
