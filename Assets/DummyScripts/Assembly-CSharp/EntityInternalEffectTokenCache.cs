/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class EntityInternalEffectTokenCache : BaseActionTokenCache // TypeDefIndex: 32033
{
	// Fields
	private EffectOp _op; // 0x38
	private Vector3? _pos; // 0x3C
	private Quaternion? _rot; // 0x4C
	private float _scale; // 0x60
	private int _index; // 0x64
	private MonoEffectProxy _proxy; // 0x68
	private uint _effectRuntimeID; // 0x70
	private string _effectName; // 0x78
	private Vector3? _effectTargetPos; // 0x80
	private BaseEntity _effectTargetEntity; // 0x90
	private Transform _effectTargetTransform; // 0x98
	private bool _async; // 0xA0
	private Vector3? _effectTargetDir; // 0xA4

	// Nested types
	public enum EffectOp // TypeDefIndex: 32034
	{
		INVALID = -1,
		ATTACH = 0,
		DEATTACH = 1,
		FIRE = 2
	}

	// Constructors
	public EntityInternalEffectTokenCache() {} // 0x000000018336C9D0-0x000000018336CA80

	// Methods
	// [XID] // 0x0000000189A59BA0-0x0000000189A59BC0
	public static EntityInternalEffectTokenCache CreateAttachTokenCache(int index, uint effectRuntimeID, EntityInternalBaseConfig actionConfig, BaseEntity owner, string effectName, Vector3? pos, Quaternion? rot, float scale, bool isHitEffect) => default; // 0x000000018336B080-0x000000018336B2A0
	// [XID] // 0x0000000189A61380-0x0000000189A613A0
	public static EntityInternalEffectTokenCache CreateDetachTokenCache(int index, EntityInternalBaseConfig actionConfig, BaseEntity owner) => default; // 0x000000018336C2E0-0x000000018336C3F0
	// [XID] // 0x00000001897606B0-0x00000001897606D0
	public static EntityInternalEffectTokenCache CreateFireTokenCache(MonoEffectProxy proxy, EntityInternalBaseConfig actionConfig, BaseEntity owner, string effectName, Vector3? pos, Quaternion? rot, float scale, bool isHitEffect, Vector3? targetPos = default, BaseEntity targetEntity = null, Transform targetTransform = null, Vector3? targetDir = default, bool indexed = false /* Metadata: 0x00B13BA8 */, bool async = false /* Metadata: 0x00B13BA9 */) => default; // 0x000000018336C770-0x000000018336C9D0
	// [XID] // 0x0000000189A70600-0x0000000189A70620
	public static void Release(EntityInternalEffectTokenCache cache) {} // 0x000000018336C210-0x000000018336C2E0
	// [XID] // 0x0000000189A77E70-0x0000000189A77E90
	public override bool NeverEnqueue() => default; // 0x000000018336C0B0-0x000000018336C1B0
	// [IDTag] // 0x0000000189A7F470-0x0000000189A7F4B0
	// [XID] // 0x0000000189A7F470-0x0000000189A7F4B0
	public void Init(EffectOp op, int index, uint effectRuntimeID, EntityInternalBaseConfig actionConfig, BaseEntity owner, string effectName, Vector3? pos, Quaternion? rot, float scale, bool isHitEffect) {} // 0x000000018336BD60-0x000000018336BF40
	// [IDTag] // 0x0000000189A8A230-0x0000000189A8A270
	// [XID] // 0x0000000189A8A230-0x0000000189A8A270
	public void Init(EffectOp op, int index, uint effectRuntimeID, EntityInternalBaseConfig actionConfig, BaseEntity owner) {} // 0x000000018336BC40-0x000000018336BD60
	// [IDTag] // 0x0000000189A94670-0x0000000189A946B0
	// [XID] // 0x0000000189A94670-0x0000000189A946B0
	private void Init(EffectOp op, MonoEffectProxy proxy, EntityInternalBaseConfig actionConfig, BaseEntity owner, string effectName, Vector3? pos, Quaternion? rot, float scale, bool isHitEffect, Vector3? targetPos = default, BaseEntity targetEntity = null, Transform targetTransform = null, Vector3? targetDir = default, bool indexed = false /* Metadata: 0x00B13BAA */, bool async = false /* Metadata: 0x00B13BAB */) {} // 0x000000018336B980-0x000000018336BC40
	// [XID] // 0x0000000189A9ECE0-0x0000000189A9ED00
	private void InitActionTokenSourceType(string effectName, bool isHitEffect) {} // 0x000000018336B7C0-0x000000018336B8B0
	// [XID] // 0x0000000189776B60-0x0000000189776B80
	private bool IsElementReactionEffect(string effectName) => default; // 0x000000018336B6D0-0x000000018336B7C0
	// [XID] // 0x0000000189AADCA0-0x0000000189AADCC0
	public override bool HandleTokenCache() => default; // 0x000000018336B8B0-0x000000018336B980
	// [XID] // 0x0000000189AB55B0-0x0000000189AB55D0
	private bool HandleAttachTokenCache() => default; // 0x000000018336B2A0-0x000000018336B5C0
	// [XID] // 0x0000000189ABD040-0x0000000189ABD060
	private bool HandleFireTokenCache() => default; // 0x000000018336C460-0x000000018336C710
	// [XID] // 0x0000000189AC4AC0-0x0000000189AC4AE0
	public override void Clear() {} // 0x000000018336BF40-0x000000018336C0B0
	// [XID] // 0x0000000189ACC100-0x0000000189ACC120
	public override void Destroy() {} // 0x000000018336B5C0-0x000000018336B660
}

