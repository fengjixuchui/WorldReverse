/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

[Serializable]
public struct P3D_Rect // TypeDefIndex: 9436
{
	// Fields
	public int XMin; // 0x00
	public int XMax; // 0x04
	public int YMin; // 0x08
	public int YMax; // 0x0C

	// Properties
	public bool IsSet { get => default; } // 0x000000018723AC30-0x000000018723ACA0 
	public int Width { get => default; } // 0x000000018723ACA0-0x000000018723AD10 
	public int Height { get => default; } // 0x000000018723ABC0-0x000000018723AC30 

	// Constructors
	public P3D_Rect(int newXMin, int newXMax, int newYMin, int newYMax) : this() {
		XMin = default;
		XMax = default;
		YMin = default;
		YMax = default;
	} // 0x000000018723ABB0-0x000000018723ABC0

	// Methods
	public void Set(int newXMin, int newXMax, int newYMin, int newYMax) {} // 0x000000018723AB10-0x000000018723ABB0
	public void Add(int newX, int newY) {} // 0x000000018723A760-0x000000018723A8B0
	public void Add(P3D_Rect rect) {} // 0x000000018723A640-0x000000018723A760
	public void Add(int newXMin, int newXMax, int newYMin, int newYMax) {} // 0x000000018723A8B0-0x000000018723A8C0
	public bool Overlaps(P3D_Rect other) => default; // 0x000000018723AA60-0x000000018723AB10
	public void Clear() {} // 0x000000018723A8C0-0x000000018723AA60
}

