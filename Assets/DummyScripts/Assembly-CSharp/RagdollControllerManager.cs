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

public sealed class RagdollControllerManager : InLevelManager // TypeDefIndex: 20987
{
	// Fields
	private int _currentActivedRagdolls; // 0x10
	private RecycledLinkedList<RagdollLoadInfo> _poolList; // 0x18
	private Dictionary<ulong, RecycledLinkedList<RecycledLinkedList<RagdollLoadInfo>>> _poolDic; // 0x20
	private Dictionary<ulong, PreloadResourceData> _preloadResourceDic; // 0x28
	private GameObject _poolParent; // 0x30

	// Properties
	public Transform poolParent { /* [XID] */ /* 0x00000001899734B0-0x00000001899734D0 */ get => default; } // 0x00000001820AEF80-0x00000001820AF080 

	// Nested types
	private class RagdollLoadInfo // TypeDefIndex: 20988
	{
		// Fields
		public ulong resourcePath; // 0x10
		public GameObject ragdollPrefab; // 0x18
		public uint resourceHandle; // 0x20
		public AsyncJob job; // 0x28

		// Constructors
		public RagdollLoadInfo() {} // 0x00000001820A1900-0x00000001820A1960

		// Methods
		// [XID] // 0x00000001898BF8C0-0x00000001898BF8E0
		public void UseResource() {} // 0x00000001820A12E0-0x00000001820A1380
		// [XID] // 0x00000001898C7160-0x00000001898C7180
		private void Clear() {} // 0x00000001820A1380-0x00000001820A1520
		// [XID] // 0x000000018996BA70-0x000000018996BA90
		public void OnLoadFinish(ulong path, bool isSuccess, uint handle, GameObject prefab) {} // 0x00000001820A1670-0x00000001820A1900
		// [XID] // 0x00000001898D60D0-0x00000001898D60F0
		public void StartLoad(ulong path) {} // 0x00000001820A10F0-0x00000001820A1230
		// [XID] // 0x00000001898DDD20-0x00000001898DDD40
		public bool IsLoading() => default; // 0x00000001820A1230-0x00000001820A12E0
		// [XID] // 0x00000001898E5620-0x00000001898E5640
		public static RagdollLoadInfo Get() => default; // 0x00000001820A1520-0x00000001820A15C0
		// [XID] // 0x00000001898ECE80-0x00000001898ECEA0
		public void Release() {} // 0x00000001820A15C0-0x00000001820A1670
	}

	private class PreloadResourceData // TypeDefIndex: 20989
	{
		// Fields
		public HashSet<VCRagdollController> registerDic; // 0x10
		public RecycledLinkedList<RagdollLoadInfo> preloadObjectList; // 0x18

		// Constructors
		public PreloadResourceData() {} // 0x00000001820C2150-0x00000001820C2200

		// Methods
		// [XID] // 0x00000001898F4740-0x00000001898F4760
		public static PreloadResourceData Get() => default; // 0x00000001820C1ED0-0x00000001820C1F70
		// [XID] // 0x00000001898FC010-0x00000001898FC030
		public void Release() {} // 0x00000001820C1F70-0x00000001820C2150
	}

	// Constructors
	public RagdollControllerManager() {} // 0x00000001820B0550-0x00000001820B0630

	// Methods
	// [XID] // 0x0000000189858180-0x00000001898581A0
	public override void Init() {} // 0x00000001820AF080-0x00000001820AF120
	// [XID] // 0x000000018985F210-0x000000018985F230
	public override void Destroy() {} // 0x00000001820AEB80-0x00000001820AEC30
	// [XID] // 0x0000000189866A30-0x0000000189866A50
	private void CreatePoolParentObject() {} // 0x00000001820AFA10-0x00000001820AFB10
	// [XID] // 0x000000018986E310-0x000000018986E330
	private void DestroyPoolParentObject() {} // 0x00000001820AEE70-0x00000001820AEF80
	// [XID] // 0x00000001898757C0-0x00000001898757E0
	public bool TryActivate(VCRagdollController vc) => default; // 0x00000001820B02E0-0x00000001820B0430
	// [XID] // 0x000000018987D310-0x000000018987D330
	public void Deactivate(VCRagdollController vc) {} // 0x00000001820AF120-0x00000001820AF210
	// [XID] // 0x00000001899A85A0-0x00000001899A85C0
	public bool IsUseRagdollPool(VCRagdollController vc) => default; // 0x00000001820B0430-0x00000001820B0550
	// [XID] // 0x000000018988B9A0-0x000000018988B9C0
	private RagdollLoadInfo GetLoadInfoFromPool(ulong pathHash) => default; // 0x00000001820AFB10-0x00000001820AFD20
	// [XID] // 0x0000000189893010-0x0000000189893030
	private void PushLoadInfoToPool(ulong pathHash, RagdollLoadInfo info) {} // 0x00000001820AF6E0-0x00000001820AFA10
	// [XID] // 0x00000001899AFD30-0x00000001899AFD50
	public void TryPreloadRagdoll(VCRagdollController controller, ulong pathHash) {} // 0x00000001820AEC30-0x00000001820AEE70
	// [XID] // 0x0000000189A67410-0x0000000189A67430
	public void RemovePreloadRagdoll(VCRagdollController controller, ulong pathHash) {} // 0x00000001820AFD20-0x00000001820B0070
	// [XID] // 0x00000001898A9270-0x00000001898A9290
	public bool TryUseRagdollPrefab(VCRagdollController controller, ulong pathHash, out uint handle, out GameObject prefab) {
		handle = default;
		prefab = default;
		return default;
	} // 0x00000001820B0070-0x00000001820B02E0
	// [XID] // 0x000000018995CA40-0x000000018995CA60
	public bool ReturnRagdollPrefab(VCRagdollController controller, ulong pathHash, uint handle, GameObject prefab) => default; // 0x00000001820AF210-0x00000001820AF3E0
	// [XID] // 0x00000001898B81C0-0x00000001898B81E0
	private void ClearRagdollPrefabPool() {} // 0x00000001820AF3E0-0x00000001820AF6E0
}

