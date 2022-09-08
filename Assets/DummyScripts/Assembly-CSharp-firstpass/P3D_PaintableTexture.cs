/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

[Serializable]
public class P3D_PaintableTexture // TypeDefIndex: 9434
{
	// Fields
	// [Tooltip] // 0x00000001897E06A0-0x00000001897E06D0
	public P3D_Group Group; // 0x10
	// [Tooltip] // 0x00000001897E97A0-0x00000001897E97D0
	public int MaterialIndex; // 0x14
	// [Tooltip] // 0x00000001897F2C40-0x00000001897F2C70
	public string TextureName; // 0x18
	// [Tooltip] // 0x00000001897FBE60-0x00000001897FBE90
	public P3D_CoordType Coord; // 0x20
	// [Tooltip] // 0x0000000189804840-0x0000000189804870
	public bool DuplicateOnAwake; // 0x24
	// [Tooltip] // 0x000000018980D5C0-0x000000018980D5F0
	public bool CreateOnAwake; // 0x25
	// [Tooltip] // 0x00000001898166D0-0x0000000189816700
	public int CreateWidth; // 0x28
	// [Tooltip] // 0x000000018981F820-0x000000018981F850
	public int CreateHeight; // 0x2C
	// [Tooltip] // 0x0000000189828830-0x0000000189828860
	public P3D_Format CreateFormat; // 0x30
	// [Tooltip] // 0x0000000189831280-0x00000001898312B0
	public Color CreateColor; // 0x34
	// [Tooltip] // 0x000000018983A190-0x000000018983A1C0
	public bool CreateMipMaps; // 0x44
	// [Tooltip] // 0x00000001898432B0-0x00000001898432E0
	public string CreateKeyword; // 0x48
	[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
	private P3D_Painter painter; // 0x50

	// Properties
	public P3D_Painter Painter { get => default; } // 0x0000000187237360-0x00000001872373C0 

	// Constructors
	public P3D_PaintableTexture() {} // 0x00000001872372C0-0x0000000187237360

	// Methods
	public void Paint(P3D_Brush brush, Vector2 uv) {} // 0x0000000187237170-0x0000000187237200
	public void UpdateTexture(GameObject gameObject) {} // 0x0000000187237200-0x00000001872372C0
	public void Awake(GameObject gameObject) {} // 0x0000000187236E80-0x0000000187237170
}

