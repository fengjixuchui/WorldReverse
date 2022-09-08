/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace VerletEngine
{
	public struct ComputeThreadTransform // TypeDefIndex: 31416
	{
		// Fields
		public Vector3 position; // 0x00
		public Quaternion rotation; // 0x0C
		public Matrix4x4 localToWorldMatrix; // 0x1C
		public Vector3 right; // 0x5C
		public Vector3 up; // 0x68
		public Vector3 forward; // 0x74
		public Vector3 localPosition; // 0x80
	
		// Methods
		public static Vector3 GetMatrixTranslation(Matrix4x4 m) => default; // 0x0000000185221B60-0x0000000185221F10
		public void RefreshByMatrix(Matrix4x4 mat) {} // 0x0000000185221F10-0x0000000185221F50
	}
}
