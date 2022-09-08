/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class VCPartController : VCBase // TypeDefIndex: 11928
{
	// Fields
	private List<ControlPart> parts; // 0x110
	private List<PartTargetInfo> targetInfos; // 0x118
	public bool enableTransformSync; // 0x120
	public Vector3 lastSyncRot; // 0x124
	public uint lastSyncTime; // 0x130

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x0000000189664610-0x0000000189664630 */ get => default; } // 0x0000000181977500-0x00000001819775A0 
	public ConfigPartController config { /* [XID] */ /* 0x000000018966BC30-0x000000018966BC70 */ get; private set; } // 0x0000000181976A50-0x0000000181976AB0 0x0000000181975770-0x00000001819757E0

	// Nested types
	private class PartTargetInfo // TypeDefIndex: 11929
	{
		// Fields
		public ControlPart part; // 0x10
		public BaseEntityHandle targetEntity; // 0x18
		public Transform lockPoint; // 0x28

		// Constructors
		public PartTargetInfo() {} // 0x00000001819587E0-0x0000000181958840

		// Methods
		// [XID] // 0x00000001896D7240-0x00000001896D7260
		public Vector3? GetLookAtPoint() => default; // 0x00000001819582E0-0x00000001819587E0
	}

	// Constructors
	public VCPartController() {} // Dummy constructor
	public VCPartController(ConfigPartController config) {} // 0x0000000181977440-0x0000000181977500

	// Methods
	// [XID] // 0x00000001898D56D0-0x00000001898D56F0
	public override void Init() {} // 0x0000000181976070-0x0000000181976580
	// [XID] // 0x0000000189A46180-0x0000000189A461A0
	public override void OnDisable() {} // 0x0000000181976AB0-0x0000000181976B50
	// [XID] // 0x0000000189A4D8F0-0x0000000189A4D910
	public override void OnEnable() {} // 0x0000000181976B50-0x0000000181976BF0
	// [XID] // 0x0000000189A55110-0x0000000189A55130
	protected override void Tick(float inDeltaTime) {} // 0x0000000181976DF0-0x0000000181977440
	// [XID] // 0x000000018969C730-0x000000018969C750
	public void RemoteSyncTransform(Vector3 eulerAngle) {} // 0x0000000181975EF0-0x0000000181976070
	// [XID] // 0x0000000189A89DE0-0x0000000189A89E00
	public override void ReInit(BaseEntity.ReInitReason reason) {} // 0x0000000181976BF0-0x0000000181976DF0
	// [XID] // 0x00000001896AB000-0x00000001896AB020
	protected override void LateTick(float inDeltaTime) {} // 0x0000000181976840-0x0000000181976970
	// [XID] // 0x00000001896B2130-0x00000001896B2150
	public void SetTargetEntity(string partName, BaseEntity entity, ControlPartTargetType targetType) {} // 0x00000001819765E0-0x0000000181976840
	// [XID] // 0x0000000189AAF290-0x0000000189AAF2B0
	public ControlPart GetControlPartByName(string rootName) => default; // 0x0000000181975890-0x0000000181975A40
	// [XID] // 0x00000001896C0F40-0x00000001896C0F60
	public void EnablePartsAll(bool setEnabled) {} // 0x0000000181975AC0-0x0000000181975C10
	// [XID] // 0x0000000189AC6150-0x0000000189AC6170
	public override void Clear(BaseEntity.ClearReason clearReason) {} // 0x00000001819757E0-0x0000000181975890
	// [XID] // 0x00000001896CFEB0-0x00000001896CFED0
	public override void Destroy() {} // 0x0000000181975C70-0x0000000181975E10
}

