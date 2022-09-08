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

public sealed class VCMonsterBeingHitAfterImage : VCBase // TypeDefIndex: 11901
{
	// Fields
	private const int MAX_ALLOWED_IMAGE_NUMBER = 5; // Metadata: 0x00AEAE64
	private const int MAX_ALLOWED_RENDERER_NUMBER = 8; // Metadata: 0x00AEAE68
	private const int LOD_LEVEL = 3; // Metadata: 0x00AEAE6C
	private int _rendererCount; // 0x108
	private SkinnedMeshRenderer[] _renderers; // 0x110
	private Transform[] _rendererTrans; // 0x118
	public static MeshPool meshPool; // 0x00
	public static SimpleObjectPool<MonsterBeingHitAfterImageEntry> imageEntryPool; // 0x08
	private MonsterBeingHitAfterImageEntry[] _imageEntrys; // 0x120
	private int _imageEntryCount; // 0x128

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x0000000189AD8270-0x0000000189AD8290 */ get => default; } // 0x000000018329FBF0-0x000000018329FC90 

	// Constructors
	public VCMonsterBeingHitAfterImage() {} // 0x000000018329FB10-0x000000018329FBF0
	static VCMonsterBeingHitAfterImage() {} // 0x000000018329FA70-0x000000018329FB10

	// Methods
	// [XID] // 0x00000001898CAF10-0x00000001898CAF30
	public override void Init() {} // 0x000000018329E940-0x000000018329F180
	// [XID] // 0x00000001898D25D0-0x00000001898D25F0
	public void Fire(Vector3 dir, uint index) {} // 0x000000018329E6D0-0x000000018329E940
	// [XID] // 0x00000001898D9F10-0x00000001898D9F30
	private void StartEffect(MonsterBeingHitAfterImageEntry entry, Vector3 dir, uint index) {} // 0x000000018329F410-0x000000018329F8D0
	// [XID] // 0x00000001898E1AA0-0x00000001898E1AC0
	protected override void LateTick(float inDeltaTime) {} // 0x000000018329F180-0x000000018329F3A0
	// [XID] // 0x00000001898E9830-0x00000001898E9850
	public override void OnDisable() {} // 0x000000018329F8D0-0x000000018329FA70
}

