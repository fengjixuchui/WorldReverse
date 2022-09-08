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

public class AmbientSpawns : IWorldShiftAgent // TypeDefIndex: 11231
{
	// Fields
	private const string FOLD_GO_NAME = "Audio Dynamic Ambient GameObjects"; // Metadata: 0x00AE94AD
	private readonly Dictionary<int, AmbientSpawn> _instances; // 0x10
	private readonly AVLTreeOnArray<AmbientSpawnRequest, AudioDynamicAmbientObject> _waitingSpawns; // 0x18
	private readonly UniHandlerAssetReceiver<GameObject> _callback; // 0x20
	private GameObject _foldGameObject; // 0x28

	// Nested types
	private class RequestComparer : IComparer<AmbientSpawnRequest> // TypeDefIndex: 11232
	{
		// Constructors
		public RequestComparer() {} // 0x00000001839E43F0-0x00000001839E4450

		// Methods
		// [XID] // 0x00000001898165A0-0x00000001898165C0
		public int Compare(AmbientSpawnRequest x, AmbientSpawnRequest y) => default; // 0x00000001839E42F0-0x00000001839E43F0
	}

	// Constructors
	public AmbientSpawns() {} // 0x00000001839E7E30-0x00000001839E7F70

	// Methods
	// [XID] // 0x0000000189B37A40-0x0000000189B37A60
	bool IWorldShiftAgent.ShiftWorld(Vector3 newShift, Vector3 oldShift) => default; // 0x00000001839E7C60-0x00000001839E7E30
	// [XID] // 0x00000001897D2CC0-0x00000001897D2CE0
	public void Start() {} // 0x00000001839E7110-0x00000001839E71B0
	// [XID] // 0x000000018986D9E0-0x000000018986DA00
	public void Instantiate(AudioDynamicAmbientObject dynamicObject) {} // 0x00000001839E6AF0-0x00000001839E6E40
	// [XID] // 0x00000001897E1E20-0x00000001897E1E40
	public void AdjustDynamicObject(AudioDynamicAmbientObject dynamicObject) {} // 0x00000001839E6E40-0x00000001839E7110
	// [XID] // 0x00000001897E95B0-0x00000001897E95D0
	public void RecycleDynamicObject(AudioDynamicAmbientObject dynamicObject) {} // 0x00000001839E67D0-0x00000001839E6AF0
	// [XID] // 0x0000000189B91610-0x0000000189B91630
	public void Clear() {} // 0x00000001839E7800-0x00000001839E7910
	// [XID] // 0x00000001897F8A20-0x00000001897F8A40
	private void RegisterWorldShiftCallback() {} // 0x00000001839E7720-0x00000001839E7800
	// [XID] // 0x0000000189800140-0x0000000189800160
	private void UnregisterWorldShiftCallback() {} // 0x00000001839E7910-0x00000001839E79F0
	// [XID] // 0x00000001898077E0-0x0000000189807800
	private void DestroyInstantiatedDynamicObjects() {} // 0x00000001839E79F0-0x00000001839E7C60
	// [XID] // 0x0000000189666080-0x00000001896660A0
	private void LoadPrefabResultCallback(ulong pathHash, bool success, uint handle, GameObject go) {} // 0x00000001839E71B0-0x00000001839E7720
}

