/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;
using UnityEngine;
using UnityEngine.UI;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class MapItem // TypeDefIndex: 31140
{
	// Fields
	public static readonly string _terrainCellPrefabPath; // 0x00
	public static uint _terrainCellPrefabHandle; // 0x08
	public static readonly string _interiorCellPrefabPath; // 0x10
	public static uint _interiorCellPrefabHandle; // 0x18
	public MonoLevelMap _monoLevelMap; // 0x10
	public string name; // 0x18
	public Image image; // 0x20
	public Animator anim; // 0x28
	public AsyncJob asyncJob; // 0x30
	private int id; // 0x40
	private uint _matHandle; // 0x44
	private const string _pathPrefix = "UI_MapBack_"; // Metadata: 0x00B11FC7
	private bool _isRoom; // 0x48
	private bool _isRoomBlock; // 0x49

	// Constructors
	public MapItem() {} // 0x0000000181344960-0x00000001813449D0
	static MapItem() {} // 0x00000001813448C0-0x0000000181344960

	// Methods
	// [XID] // 0x00000001897CD480-0x00000001897CD4A0
	public bool IsActived() => default; // 0x0000000181343980-0x0000000181343B10
	// [XID] // 0x00000001897D4AA0-0x00000001897D4AC0
	private string GenerateMapPath(int i, int j) => default; // 0x0000000181344760-0x00000001813448C0
	// [XID] // 0x00000001897DC120-0x00000001897DC140
	public void InitForInterior(MonoLevelMap monoLevelMap, int floor = 1 /* Metadata: 0x00B11FBD */) {} // 0x0000000181343780-0x0000000181343980
	// [XID] // 0x00000001897E3A10-0x00000001897E3A30
	public void Init(MonoLevelMap monoLevelMap, int i, int j, Color _tarColor, bool force, bool isInRoom = false /* Metadata: 0x00B11FC1 */, int floor = 0 /* Metadata: 0x00B11FC2 */, bool isBigWorld = false /* Metadata: 0x00B11FC6 */) {} // 0x0000000181343B10-0x0000000181343FD0
	// [XID] // 0x00000001897EB6C0-0x00000001897EB6E0
	private string GetMatFullPath() => default; // 0x0000000181344670-0x0000000181344760
	// [XID] // 0x00000001897F2FC0-0x00000001897F2FE0
	public UnityEngine.Material GetTerrainMaterial(int id) => default; // 0x0000000181343FD0-0x0000000181344130
	// [XID] // 0x00000001897FA830-0x00000001897FA850
	private void OnLoad(int id, ulong hash, bool loadSucceeded, uint handle, UnityEngine.Material currMat) {} // 0x0000000181343620-0x0000000181343780
	// [XID] // 0x0000000189801EA0-0x0000000189801EC0
	public void Release() {} // 0x0000000181344270-0x0000000181344670
	// [XID] // 0x00000001898092D0-0x00000001898092F0
	public static void Dismiss() {} // 0x0000000181344130-0x0000000181344270
}

