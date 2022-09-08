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

namespace Dest.Math
{
	public class EigenData // TypeDefIndex: 8131
	{
		// Fields
		private int _size; // 0x10
		private float[] _diagonal; // 0x18
		private float[,] _matrix; // 0x20
	
		// Properties
		public int Size { /* [XID] */ /* 0x000000018965D140-0x000000018965D160 */ get => default; } // 0x00000001872C8770-0x00000001872C8810 
	
		// Constructors
		public EigenData() {} // Dummy constructor
		internal EigenData(float[] diagonal, float[,] matrix) {} // 0x00000001872C86D0-0x00000001872C8770
	
		// Methods
		// [XID] // 0x00000001896BCC40-0x00000001896BCC60
		public float GetEigenvalue(int index) => default; // 0x00000001872C7FD0-0x00000001872C80B0
		// [XID] // 0x00000001896C41A0-0x00000001896C41C0
		public Vector2 GetEigenvector2(int index) => default; // 0x00000001872C80B0-0x00000001872C8240
		// [XID] // 0x0000000189B35F90-0x0000000189B35FB0
		public Vector3 GetEigenvector3(int index) => default; // 0x00000001872C8240-0x00000001872C8410
		// [IDTag] // 0x00000001896D2B70-0x00000001896D2BB0
		// [XID] // 0x00000001896D2B70-0x00000001896D2BB0
		public float[] GetEigenvector(int index) => default; // 0x00000001872C8410-0x00000001872C8580
		// [IDTag] // 0x00000001896DD290-0x00000001896DD2D0
		// [XID] // 0x00000001896DD290-0x00000001896DD2D0
		public void GetEigenvector(int index, float[] out_eigenvector) {} // 0x00000001872C8580-0x00000001872C86D0
	}
}
