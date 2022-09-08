/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using MoleMole;
using UnityEngine;
using UnityEngine.Profiling;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

public class GPUAnimationInstManager : InLevelManager // TypeDefIndex: 8559
{
	// Fields
	private CustomSampler profilerTick; // 0x10
	private CustomSampler profilerSpawn; // 0x18
	public const uint InvalidInstanceHandle = 65535; // Metadata: 0x00ADFB47
	private const int MAX_INSTANCE_NUM = 1024; // Metadata: 0x00ADFB4B
	private static string GPU_INST_ROOT_GO_NAME; // 0x00
	private static readonly int _UnityTime; // 0x08
	private static readonly int _LastUnityTimeID; // 0x0C
	private GPUAnimInstance[] animInstances; // 0x20
	private uint nInstanceNumber; // 0x28
	private List<AnimInstProto> loadedPrototypes; // 0x30
	private Dictionary<string, int> prefabPathToPrototypeId; // 0x38
	private GPUAnimInstance[] activeInstances; // 0x40
	private uint nActiveInstance; // 0x48
	private uint nextFreeIndex; // 0x4C
	private float _lastTime; // 0x50
	public GameObject rootGO; // 0x58
	private const int INDEX_BITS = 24; // Metadata: 0x00ADFB4F
	private const int VERSION_BITS = 8; // Metadata: 0x00ADFB53
	private const int VERSION_SHIFT = 24; // Metadata: 0x00ADFB57
	private const uint INDEX_MASK = 16777215; // Metadata: 0x00ADFB5B
	private const uint VERSION_MASK = 255; // Metadata: 0x00ADFB5F
	private const uint InvalidHandle = 4294967295; // Metadata: 0x00ADFB63

	// Nested types
	private class AnimInstProto // TypeDefIndex: 8560
	{
		// Fields
		public uint resourceHandle; // 0x10
		public uint refcount; // 0x14
		public string prefabPath; // 0x18
		public RuntimeAnimAssetData animData; // 0x20
		public RuntimeAnimAssetData itemAnimData; // 0x28
		public int materialIDCache; // 0x30

		// Constructors
		public AnimInstProto() {} // 0x0000000185A1E680-0x0000000185A1E700

		// Methods
		public void AddRef() {} // 0x0000000185A1DF60-0x0000000185A1E130
		public void DecRef() {} // 0x0000000185A1E310-0x0000000185A1E500
		public void DecRefOnAbort() {} // 0x0000000185A1E2B0-0x0000000185A1E310
		public bool AssignNewResHandleIfEmpty(uint newhandle) => default; // 0x0000000185A1E130-0x0000000185A1E2B0
		private void ReleaseResoure() {} // 0x0000000185A1E500-0x0000000185A1E680
	}

	// Constructors
	public GPUAnimationInstManager() {} // 0x0000000185A3B800-0x0000000185A3B870
	static GPUAnimationInstManager() {} // 0x0000000185A3B750-0x0000000185A3B800

	// Methods
	public GPUAnimInstance[] GetActiveInstances() => default; // 0x0000000185A3A300-0x0000000185A3A360
	public uint GetActiveInstanceCount() => default; // 0x0000000185A3A2A0-0x0000000185A3A300
	public override void Init() {} // 0x0000000185A3A8F0-0x0000000185A3AAB0
	public override void Destroy() {} // 0x0000000185A39F90-0x0000000185A3A080
	public override void InitOnConnect() {} // 0x0000000185A3A830-0x0000000185A3A8F0
	public override void ClearOnDisconnect() {} // 0x0000000185A387D0-0x0000000185A38820
	public override void Tick() {} // 0x0000000185A3B290-0x0000000185A3B600
	public int GetOrRegisterPrototypeId(string prefabPath) => default; // 0x0000000185A3A430-0x0000000185A3A580
	private void CheckInstances(GPUAnimInstance[] insts, uint num) {} // 0x0000000185A38420-0x0000000185A387D0
	public int RegisterPrototype(string prefabPath) => default; // 0x0000000185A3AB60-0x0000000185A3ACC0
	public void UnregisterAllPrototypes() {} // 0x0000000185A3B600-0x0000000185A3B750
	public uint SpawnInstance(int protoTypeId, uint gameplayID, Vector3 pos, Quaternion quat, int animIndex = 0 /* Metadata: 0x00ADFB43 */) => default; // 0x0000000185A3AE60-0x0000000185A3B290
	private void OnLoadAssetFailed(int protoTypeId, uint handle) {} // 0x0000000185A3AAB0-0x0000000185A3AB60
	private void InitInstance(GameObject loadedGo, uint handle, int protoTypeId, uint gameplayID, Vector3 pos, Quaternion quat, int animIndex) {} // 0x0000000185A3A580-0x0000000185A3A830
	public void EnableInstance(uint handle, bool bEnable) {} // 0x0000000185A3A080-0x0000000185A3A130
	public void DestroyInstance(uint instHld) {} // 0x0000000185A39480-0x0000000185A39F90
	public GPUAnimInstance GetAnimInstance(uint handle) => default; // 0x0000000185A3A360-0x0000000185A3A430
	public void DestroyAllInstances() {} // 0x0000000185A39300-0x0000000185A39480
	private bool CreateAnimInstDataInternal(GameObject go, RuntimeAnimAssetData asset, RuntimeAnimAssetData itemasset, int protoId, uint handle, uint gameplayID, int animIndex) => default; // 0x0000000185A38820-0x0000000185A39140
	public uint EncodeHandle(uint index, uint version) => default; // 0x0000000185A3A130-0x0000000185A3A1A0
	public bool DecodeHandleFast(uint handle, out uint index, out uint version) {
		index = default;
		version = default;
		return default;
	} // 0x0000000185A39140-0x0000000185A391D0
	private int FindNextFreeIndex() => default; // 0x0000000185A3A1A0-0x0000000185A3A2A0
	private uint AllocHandle() => default; // 0x0000000185A38100-0x0000000185A38420
	private void ReturnHandle(uint handle) {} // 0x0000000185A3ACC0-0x0000000185A3AE60
	private bool DecodeHandleValidate(uint handle, out uint index, out uint version) {
		index = default;
		version = default;
		return default;
	} // 0x0000000185A391D0-0x0000000185A39300
}

