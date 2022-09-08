/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class SceneTileManager : InLevelManager // TypeDefIndex: 21002
{
	// Fields
	public const int Bake_Tile_Size = 128; // Metadata: 0x00AFEC4D
	private Dictionary<int, IBakeSurfaceTile> _staticBakeTileDict; // 0x10
	private Dictionary<int, IBakeSurfaceTile> _dynamicBakeTileDict; // 0x18
	private Dictionary<int, List<int>> _pos2dynamicBakeTileDict; // 0x20

	// Constructors
	public SceneTileManager() {} // 0x00000001830F6790-0x00000001830F6860

	// Methods
	// [XID] // 0x00000001899BAC80-0x00000001899BACA0
	public override void Init() {} // 0x00000001830F5910-0x00000001830F59B0
	// [XID] // 0x00000001899C26D0-0x00000001899C26F0
	public override void Destroy() {} // 0x00000001830F5150-0x00000001830F51F0
	// [XID] // 0x00000001898FB390-0x00000001898FB3B0
	public void EnableMovingTile(int id, uint routeId, int index, bool enable) {} // 0x00000001830F54B0-0x00000001830F5610
	// [XID] // 0x0000000189913980-0x00000001899139A0
	public float GetOccluderHeight(Vector3 pos, float hitRayLengthAdded) => default; // 0x00000001830F59B0-0x00000001830F5BC0
	// [XID] // 0x00000001899A2460-0x00000001899A2480
	public float GetWaterSurfaceHeight(Vector3 pos, float hitRayLengthAdded) => default; // 0x00000001830F63E0-0x00000001830F6520
	// [XID] // 0x00000001899E0180-0x00000001899E01A0
	public float GetWaterSurfaceHeightByStaticTile(Vector3 pos, float hitRayLengthAdded) => default; // 0x00000001830F5700-0x00000001830F5910
	// [XID] // 0x00000001899E7CA0-0x00000001899E7CC0
	private float GetWaterSurfaceHeightByDynamicTile(Vector3 pos, float hitRayLengthAdded) => default; // 0x00000001830F6520-0x00000001830F6790
	// [XID] // 0x00000001899EF0A0-0x00000001899EF0C0
	public float GetWaterSurfaceByPlugin(Vector3 pos, float hitRayLengthAdded) => default; // 0x00000001830F4F80-0x00000001830F5150
	// [XID] // 0x00000001899F6A70-0x00000001899F6A90
	public void AddBakeTile(IBakeSurfaceTile tile) {} // 0x00000001830F5BC0-0x00000001830F5CB0
	// [XID] // 0x00000001899FE050-0x00000001899FE070
	public void RemoveBakeTile(IBakeSurfaceTile tile) {} // 0x00000001830F5610-0x00000001830F5700
	// [XID] // 0x0000000189A05970-0x0000000189A05990
	private void AddStaticBakeTIle(IBakeSurfaceTile tile) {} // 0x00000001830F5340-0x00000001830F54B0
	// [XID] // 0x0000000189A0CC40-0x0000000189A0CC60
	private void RemoveStaticBakeTIle(IBakeSurfaceTile tile) {} // 0x00000001830F5CB0-0x00000001830F5E10
	// [XID] // 0x0000000189A14580-0x0000000189A145A0
	private void AddDynamicBakeTIle(IBakeSurfaceTile tile) {} // 0x00000001830F6030-0x00000001830F63E0
	// [XID] // 0x0000000189A1B830-0x0000000189A1B850
	private void RemoveDynamicBakeTIle(IBakeSurfaceTile tile) {} // 0x00000001830F5E10-0x00000001830F6030
	// [XID] // 0x000000018994F370-0x000000018994F390
	private int GetCurrentTileID(Vector3 pos) => default; // 0x00000001830F51F0-0x00000001830F5340
}

