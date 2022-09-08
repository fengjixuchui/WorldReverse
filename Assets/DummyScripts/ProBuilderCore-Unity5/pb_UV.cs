/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 38: ProBuilderCore-Unity5.dll - Assembly: ProBuilderCore-Unity5, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3356-3465

[Serializable]
public class pb_UV // TypeDefIndex: 3429
{
	// Fields
	public bool useWorldSpace; // 0x10
	public bool flipU; // 0x11
	public bool flipV; // 0x12
	public bool swapUV; // 0x13
	public Fill fill; // 0x14
	public Vector2 scale; // 0x18
	public Vector2 offset; // 0x20
	public float rotation; // 0x28
	[Obsolete] // 0x0000000189A91880-0x0000000189A918B0
	public Justify justify; // 0x2C
	public Vector2 localPivot; // 0x30
	[Obsolete] // 0x0000000189A9AA60-0x0000000189A9AA90
	public Vector2 localSize; // 0x38
	public Anchor anchor; // 0x40

	// Nested types
	[Obsolete] // 0x0000000189AA34C0-0x0000000189AA34F0
	public enum Justify // TypeDefIndex: 3430
	{
		Right = 0,
		Left = 1,
		Top = 2,
		Center = 3,
		Bottom = 4,
		None = 5
	}

	public enum Anchor // TypeDefIndex: 3431
	{
		UpperLeft = 0,
		UpperCenter = 1,
		UpperRight = 2,
		MiddleLeft = 3,
		MiddleCenter = 4,
		MiddleRight = 5,
		LowerLeft = 6,
		LowerCenter = 7,
		LowerRight = 8,
		None = 9
	}

	public enum Fill // TypeDefIndex: 3432
	{
		Fit = 0,
		Tile = 1,
		Stretch = 2
	}

	// Constructors
	public pb_UV() {} // 0x000000018773BC10-0x000000018773BE70
	public pb_UV(pb_UV uvs) {} // 0x000000018773BB50-0x000000018773BC10

	// Methods
	public void Reset() {} // 0x000000018773B260-0x000000018773B320
	public override string ToString() => default; // 0x000000018773B320-0x000000018773BB50
}

