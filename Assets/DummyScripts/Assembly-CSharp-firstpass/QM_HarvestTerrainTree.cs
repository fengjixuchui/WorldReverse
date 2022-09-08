/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

public class QM_HarvestTerrainTree : MonoBehaviour // TypeDefIndex: 9146
{
	// Fields
	public int harvestTreeDistance; // 0x18
	public bool rotatePlayer; // 0x1C
	private Transform _myTransform; // 0x20
	private Terrain _terrain; // 0x28
	private RaycastHit _hit; // 0x30
	private string _lastTerrain; // 0x70
	public GameObject felledTree; // 0x78
	private QM_ResourceManager _rMgr; // 0x80
	public float respawnTimer; // 0x88
	public Transform explosionCenter; // 0x90
	private TerrainData _terrainData; // 0x98
	private TreeInstance[] _origTreeInstances; // 0xA0

	// Constructors
	public QM_HarvestTerrainTree() {} // 0x0000000186017DA0-0x0000000186017E10

	// Methods
	private void Start() {} // 0x00000001860178A0-0x0000000186017A10
	private void OnApplicationQuit() {} // 0x0000000186017820-0x00000001860178A0
	private void Update() {} // 0x0000000186017A10-0x0000000186017DA0
	private void Explode() {} // 0x0000000186016BA0-0x00000001860171E0
	private bool CheckProximity() => default; // 0x0000000186016840-0x0000000186016990
	private bool CheckRecentUsage(string _terrainName, int _treeINDEX) => default; // 0x0000000186016990-0x0000000186016BA0
	private void HarvestWood() {} // 0x00000001860171E0-0x0000000186017820
}

