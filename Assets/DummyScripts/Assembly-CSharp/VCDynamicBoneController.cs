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
using VerletEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class VCDynamicBoneController : VCBase // TypeDefIndex: 11851
{
	// Fields
	private Type _type; // 0x108
	private List<DynamicBoneArray> _dynamicBoneArrayList; // 0x110
	private Dictionary<Transform, Matrix4x4> _bindPoseMap; // 0x118

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x0000000189B46AA0-0x0000000189B46AC0 */ get => default; } // 0x000000018247A940-0x000000018247A9E0 

	// Nested types
	public enum Type // TypeDefIndex: 11852
	{
		Normal = 0,
		Special = 1
	}

	// Constructors
	public VCDynamicBoneController() {} // 0x000000018247A880-0x000000018247A940

	// Methods
	// [XID] // 0x0000000189B4E270-0x0000000189B4E290
	public void SetType(Type type) {} // 0x0000000182479E60-0x0000000182479F10
	// [XID] // 0x0000000189873690-0x00000001898736B0
	public override void Init() {} // 0x0000000182479F10-0x000000018247A010
	// [XID] // 0x00000001898821A0-0x00000001898821C0
	public override void OnEntityReady() {} // 0x000000018247A2D0-0x000000018247A700
	// [XID] // 0x0000000189B64AB0-0x0000000189B64AD0
	public override void Destroy() {} // 0x0000000182479B70-0x0000000182479CB0
	// [XID] // 0x0000000189898320-0x0000000189898340
	public void ResetBindPose(Transform[] trans) {} // 0x0000000182479CB0-0x0000000182479E60
	// [XID] // 0x0000000189901880-0x00000001899018A0
	public void SetMovementInfluence(bool shouldInfluence) {} // 0x0000000182479A30-0x0000000182479B70
	// [XID] // 0x00000001898A70E0-0x00000001898A7100
	private void ResetTransPose(Transform boneTrans) {} // 0x0000000182479370-0x0000000182479910
	// [XID] // 0x0000000189B824F0-0x0000000189B82510
	private void OnAnimatorStateChanged(EvtAnimatorStateChanged evt) {} // 0x000000018247A010-0x000000018247A1A0
	// [XID] // 0x00000001898AEA40-0x00000001898AEA60
	public override bool ShiftWorld(Vector3 newShift, Vector3 oldShift) => default; // 0x000000018247A700-0x000000018247A880
}

