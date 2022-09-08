/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using PigeonCoopToolkit.Utillities;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace PigeonCoopToolkit.Effects.Trails
{
	public class PCTrail : IDisposable // TypeDefIndex: 9456
	{
		// Fields
		public CircularBuffer<PCTrailPoint> Points; // 0x10
		public Mesh Mesh; // 0x18
		public Vector3[] verticies; // 0x20
		public Vector3[] normals; // 0x28
		public Vector2[] uvs; // 0x30
		public Color[] colors; // 0x38
		public int[] indicies; // 0x40
		public int activePointCount; // 0x48
		public bool IsActiveTrail; // 0x4C
	
		// Constructors
		public PCTrail() {} // Dummy constructor
		public PCTrail(int numPoints) {} // 0x00000001860162A0-0x0000000186016410
	
		// Methods
		// [XID] // 0x0000000189912C80-0x0000000189912CA0
		public void Dispose() {} // 0x0000000186016130-0x00000001860162A0
	}
}
