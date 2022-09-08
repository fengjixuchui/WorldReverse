/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public interface IBakeSurfaceTile // TypeDefIndex: 21000
{
	// Methods
	Vector3 GetPos();
	float GetBakeTileHeight(Vector3 pos, float hitRayLengthAdded, EBakeTileType type);
	EBakeLocationType GetLocationType();
	Bounds GetBounds();
	int GetTileObjID();
}

