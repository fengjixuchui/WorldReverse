/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace MoleMole
{
	public struct Matrix4x4d // TypeDefIndex: 10593
	{
		// Fields
		public double m00; // 0x00
		public double m01; // 0x08
		public double m02; // 0x10
		public double m03; // 0x18
		public double m10; // 0x20
		public double m11; // 0x28
		public double m12; // 0x30
		public double m13; // 0x38
		public double m20; // 0x40
		public double m21; // 0x48
		public double m22; // 0x50
		public double m23; // 0x58
		public double m30; // 0x60
		public double m31; // 0x68
		public double m32; // 0x70
		public double m33; // 0x78
	
		// Properties
		public double this[int index] { /* [IDTag] */ /* 0x0000000189A1F650-0x0000000189A1F690 */ /* [XID] */ /* 0x0000000189A1F650-0x0000000189A1F690 */ get => default; /* [IDTag] */ /* 0x0000000189A29AE0-0x0000000189A29B20 */ /* [XID] */ /* 0x0000000189A29AE0-0x0000000189A29B20 */ set {} } // 0x0000000186C27650-0x0000000186C27740 0x0000000186C298B0-0x0000000186C299A0
		public double this[int row, int column] { /* [IDTag] */ /* 0x0000000189A340A0-0x0000000189A340E0 */ /* [XID] */ /* 0x0000000189A340A0-0x0000000189A340E0 */ get => default; /* [XID] */ /* 0x0000000189A3EA70-0x0000000189A3EAB0 */ /* [IDTag] */ /* 0x0000000189A3EA70-0x0000000189A3EAB0 */ set {} } // 0x0000000186C27740-0x0000000186C27BA0 0x0000000186C299A0-0x0000000186C299B0
		public static Matrix4x4d identity { /* [XID] */ /* 0x0000000189A490B0-0x0000000189A490D0 */ get => default; } // 0x0000000186C27BB0-0x0000000186C28200 
		public static Matrix4x4d zero { /* [XID] */ /* 0x0000000189A509C0-0x0000000189A509E0 */ get => default; } // 0x0000000186C286F0-0x0000000186C288C0 
		public double determinant { /* [XID] */ /* 0x0000000189A57E60-0x0000000189A57E80 */ get => default; } // 0x0000000186C27BA0-0x0000000186C27BB0 
		public Matrix4x4d inverse { /* [XID] */ /* 0x0000000189A5FAF0-0x0000000189A5FB10 */ get => default; } // 0x0000000186C28200-0x0000000186C283D0 
		public bool isIdentity { /* [XID] */ /* 0x0000000189A67410-0x0000000189A67430 */ get => default; } // 0x0000000186C283D0-0x0000000186C28680 
		public Matrix4x4d transpose { /* [XID] */ /* 0x0000000189A6EAC0-0x0000000189A6EAE0 */ get => default; } // 0x0000000186C28680-0x0000000186C286F0 
	
		// Methods
		// [XID] // 0x0000000189A76390-0x0000000189A763B0
		public static double Determinant(Matrix4x4d m) => default; // 0x0000000186C22E90-0x0000000186C23170
		// [XID] // 0x000000018994DB20-0x000000018994DB40
		public static Matrix4x4d Inverse(Matrix4x4d m) => default; // 0x0000000186C23760-0x0000000186C239E0
		// [XID] // 0x0000000189A85530-0x0000000189A85550
		public static Matrix4x4d LookAt(Vector3d from, Vector3d to, Vector3d up) => default; // 0x0000000186C239E0-0x0000000186C23D30
		// [XID] // 0x0000000189A8CEE0-0x0000000189A8CF00
		public static Matrix4x4d Ortho(double left, double right, double bottom, double top, double zNear, double zFar) => default; // 0x0000000186C241B0-0x0000000186C24540
		// [XID] // 0x0000000189A94290-0x0000000189A942B0
		public static Matrix4x4d Perspective(double fov, double aspect, double zNear, double zFar) => default; // 0x0000000186C24540-0x0000000186C24920
		// [XID] // 0x0000000189A9BC00-0x0000000189A9BC20
		public static Matrix4x4d Scale(Vector3d v) => default; // 0x0000000186C24920-0x0000000186C24C60
		// [XID] // 0x0000000189AA3160-0x0000000189AA3180
		public static Matrix4x4d Translate(Vector3d v) => default; // 0x0000000186C26D20-0x0000000186C26F10
		// [XID] // 0x0000000189AAA650-0x0000000189AAA670
		public static Matrix4x4d Transpose(Matrix4x4d m) => default; // 0x0000000186C26F10-0x0000000186C27290
		// [XID] // 0x0000000189AB24D0-0x0000000189AB24F0
		public static Matrix4x4d TRS(Vector3d pos, Quaterniond q, Vector3d s) => default; // 0x0000000186C25060-0x0000000186C26680
		// [XID] // 0x00000001898FC010-0x00000001898FC030
		public Vector4d GetColumn(int i) => default; // 0x0000000186C23350-0x0000000186C23550
		// [XID] // 0x0000000189AC1510-0x0000000189AC1530
		public Vector4d GetRow(int i) => default; // 0x0000000186C23730-0x0000000186C23760
		// [XID] // 0x0000000189AC8D60-0x0000000189AC8D80
		public Vector3d MultiplyPoint(Vector3d v) => default; // 0x0000000186C23F70-0x0000000186C24160
		// [XID] // 0x0000000189AD0520-0x0000000189AD0540
		public Vector3d MultiplyPoint3x4(Vector3d v) => default; // 0x0000000186C23D30-0x0000000186C23F70
		// [XID] // 0x0000000189AD8250-0x0000000189AD8270
		public Vector3d MultiplyVector(Vector3d v) => default; // 0x0000000186C24160-0x0000000186C241B0
		// [XID] // 0x0000000189ADFF20-0x0000000189ADFF40
		public void SetColumn(int i, Vector4d v) {} // 0x0000000186C24C60-0x0000000186C24DD0
		// [XID] // 0x0000000189AE7520-0x0000000189AE7540
		public void SetRow(int i, Vector4d v) {} // 0x0000000186C24DD0-0x0000000186C24FF0
		// [XID] // 0x000000018987EC60-0x000000018987EC80
		public void SetTRS(Vector3d pos, Quaterniond q, Vector3d s) {} // 0x0000000186C24FF0-0x0000000186C25060
		// [IDTag] // 0x0000000189AF6600-0x0000000189AF6640
		// [XID] // 0x0000000189AF6600-0x0000000189AF6640
		public override string ToString() => default; // 0x0000000186C26680-0x0000000186C26D10
		// [XID] // 0x0000000189A108A0-0x0000000189A108C0
		public override int GetHashCode() => default; // 0x0000000186C23550-0x0000000186C23730
		// [XID] // 0x0000000189B082F0-0x0000000189B08310
		public override bool Equals(object other) => default; // 0x0000000186C23170-0x0000000186C23350
		// [IDTag] // 0x0000000189B0FB70-0x0000000189B0FBB0
		// [XID] // 0x0000000189B0FB70-0x0000000189B0FBB0
		public string ToString(string format) => default; // 0x0000000186C26D10-0x0000000186C26D20
		// [IDTag] // 0x0000000189B19F20-0x0000000189B19F60
		// [XID] // 0x0000000189B19F20-0x0000000189B19F60
		public static Vector4d operator *(Matrix4x4d lhs, Vector4d v) => default; // 0x0000000186C29490-0x0000000186C298B0
		// [IDTag] // 0x0000000189B24640-0x0000000189B24680
		// [XID] // 0x0000000189B24640-0x0000000189B24680
		public static Matrix4x4d operator *(Matrix4x4d lhs, Matrix4x4d rhs) => default; // 0x0000000186C28DF0-0x0000000186C29490
		// [XID] // 0x0000000189893010-0x0000000189893030
		public static bool operator ==(Matrix4x4d lhs, Matrix4x4d rhs) => default; // 0x0000000186C288C0-0x0000000186C28C00
		// [XID] // 0x0000000189B360B0-0x0000000189B360D0
		public static bool operator !=(Matrix4x4d lhs, Matrix4x4d rhs) => default; // 0x0000000186C28C00-0x0000000186C28DF0
	}
}
