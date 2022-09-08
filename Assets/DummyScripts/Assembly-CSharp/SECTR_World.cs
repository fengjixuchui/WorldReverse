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

public class SECTR_World // TypeDefIndex: 31925
{
	// Fields
	public string name; // 0x10
	public List<SECTR_SectorProxy> sectorList; // 0x18
	public SECTR_StreamerRoot streamRoot; // 0x20
	public Dictionary<ulong, SectorBinItem> sectorBinDict; // 0x28
	public Dictionary<ulong, ulong> sectrHashDict; // 0x30
	public SECTR_LinkedList<ISECTR_LODLoader>[] allLODLoaderList; // 0x38
	public SECTR_LinkedListNode<ISECTR_LODLoader>[] curLODLinkNodes; // 0x40
	public SECTR_LinkedListNode<ISECTR_LODLoader>[] lastLODLinkNodes; // 0x48
	public SECTR_LinkedList<ISECTR_ColliderLoader>[] allColliderLoaderList; // 0x50
	public SECTR_LinkedListNode<ISECTR_ColliderLoader>[] curColliderNodes; // 0x58
	public SECTR_LinkedListNode<ISECTR_ColliderLoader>[] lastColliderNodes; // 0x60
	public List<SECTR_BaseLayerProxy> allLayers; // 0x68
	public List<ISECTR_LayerLoader> allLayerLoaders; // 0x70
	private Dictionary<string, SECTR_LayerConfig> _layer2Config; // 0x78
	private Dictionary<string, int> _layer2Level; // 0x80
	private Dictionary<int, float> _level2SectorSize; // 0x88
	private Dictionary<int, float> _level2LoadSize; // 0x90
	private Dictionary<int, float> _level2SectorHeight; // 0x98
	private Dictionary<int, float> _level2LoadHeight; // 0xA0
	private List<SECTR_LayerTree> _roots; // 0xA8
	private List<int> _rootNames; // 0xB0
	public List<int> sectorHashSet; // 0xB8
	public List<int> groupHashSet; // 0xC0

	// Constructors
	public SECTR_World() {} // 0x00000001839342E0-0x00000001839346C0

	// Methods
	// [XID] // 0x0000000189AAAC50-0x0000000189AAAC70
	public void Init() {} // 0x00000001839325D0-0x0000000183932670
	// [XID] // 0x0000000189AB2660-0x0000000189AB2680
	public void InitInLevel() {} // 0x0000000183932740-0x00000001839327E0
	// [XID] // 0x0000000189ABA130-0x0000000189ABA150
	public void ClearAllSectors() {} // 0x0000000183932A80-0x0000000183932BA0
	// [XID] // 0x0000000189AC19D0-0x0000000189AC19F0
	public void ReleaseAllSectors() {} // 0x00000001839330A0-0x00000001839331E0
	// [XID] // 0x0000000189AC8FD0-0x0000000189AC8FF0
	public void GetContainingLayers(ref List<SECTR_BaseLayerProxy> layers, Vector3 position, Dictionary<SECTR_BaseLayerProxy, bool> loadDict, bool forceLoad = false /* Metadata: 0x00B13A34 */) {} // 0x00000001839331E0-0x0000000183933390
	// [XID] // 0x0000000189AD0A20-0x0000000189AD0A40
	private void FindContainingLayers(SECTR_LayerTree parent, ref List<SECTR_BaseLayerProxy> layers, Vector3 position, Dictionary<SECTR_BaseLayerProxy, bool> loadDict, bool forceLoad) {} // 0x0000000183933E60-0x00000001839341E0
	// [XID] // 0x0000000189AD8640-0x0000000189AD8660
	private void InitListNodes() {} // 0x0000000183933A20-0x0000000183933E60
	// [IDTag] // 0x0000000189AE02C0-0x0000000189AE0300
	// [XID] // 0x0000000189AE02C0-0x0000000189AE0300
	public bool CreateQuateTree(SECTR_Manager.TreeType type, SECTR_BaseLayerProxy layer, ref int treeLevel) => default; // 0x0000000183931F10-0x0000000183932080
	// [XID] // 0x0000000189AEA970-0x0000000189AEA990
	public void RemoveQuateTree(SECTR_BaseLayerProxy layer) {} // 0x0000000183932670-0x0000000183932740
	// [XID] // 0x0000000189AF2260-0x0000000189AF2280
	public SECTR_LayerConfig Layer2Config(string layerName) => default; // 0x0000000183932FB0-0x00000001839330A0
	// [XID] // 0x0000000189AF9B80-0x0000000189AF9BA0
	protected SECTR_LayerTree GetRoot(int name) => default; // 0x0000000183932D90-0x0000000183932FB0
	// [IDTag] // 0x0000000189B01070-0x0000000189B010B0
	// [XID] // 0x0000000189B01070-0x0000000189B010B0
	private bool CreateQuateTree(SECTR_LayerTree parent, SECTR_BaseLayerProxy layer, ref int treeLevel) => default; // 0x0000000183931590-0x0000000183931F10
	// [XID] // 0x0000000189B0B7D0-0x0000000189B0B7F0
	private SECTR_LayerTree CreateTreeNode(Vector3 layerCenter, Vector3 layerSize, Vector3 loadSize, long nodeID, SECTR_LayerTree parent) => default; // 0x0000000183932280-0x00000001839324D0
	// [XID] // 0x0000000189B12D60-0x0000000189B12D80
	public void RegisterLayerLoader(ISECTR_LayerLoader inLayerLoader) {} // 0x0000000183932BA0-0x0000000183932C70
	// [XID] // 0x0000000189B1A3D0-0x0000000189B1A3F0
	public void UnRegisterLayerLoader(ISECTR_LayerLoader inLayerLoader) {} // 0x0000000183932C70-0x0000000183932D90
	// [XID] // 0x0000000189B218B0-0x0000000189B218D0
	private void InitLayerConfig() {} // 0x0000000183933390-0x0000000183933A20
	// [XID] // 0x0000000189B29020-0x0000000189B29040
	private int Layer2Level(string layerName) => default; // 0x00000001839324D0-0x00000001839325D0
	// [XID] // 0x0000000189B30440-0x0000000189B30460
	private float Level2SectorSize(int level) => default; // 0x0000000183931490-0x0000000183931590
	// [XID] // 0x0000000189B37D50-0x0000000189B37D70
	private float Level2LoadSize(int level) => default; // 0x00000001839341E0-0x00000001839342E0
	// [XID] // 0x0000000189B3F660-0x0000000189B3F680
	private float Level2SectorHeight(int level) => default; // 0x0000000183932080-0x0000000183932180
	// [XID] // 0x0000000189B47040-0x0000000189B47060
	private float Level2LoadHeight(int level) => default; // 0x0000000183932180-0x0000000183932280
	// [XID] // 0x0000000189B4E720-0x0000000189B4E740
	private void ClearTree() {} // 0x00000001839327E0-0x0000000183932A80
}

