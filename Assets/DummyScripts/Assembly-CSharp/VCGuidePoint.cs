/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class VCGuidePoint : BaseComponentPlugin // TypeDefIndex: 12163
{
	// Fields
	private TargetIndicatorType _type; // 0x58
	private bool isUIPoint; // 0x5C
	private VCBillboard billboard; // 0x60
	private VCMarkBillboardPlugin markBillBoard; // 0x68

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x000000018986C030-0x000000018986C050 */ get => default; } // 0x000000018184C8B0-0x000000018184C950 

	// Constructors
	public VCGuidePoint() {} // Dummy constructor
	public VCGuidePoint(TargetIndicatorType type = TargetIndicatorType.DEFAULT /* Metadata: 0x00AEB5F9 */, bool _isUIPoint = false /* Metadata: 0x00AEB5FD */) {} // 0x000000018184C820-0x000000018184C8B0

	// Methods
	// [XID] // 0x00000001898734D0-0x00000001898734F0
	public override void OnEnable() {} // 0x000000018184C5A0-0x000000018184C820
	// [XID] // 0x000000018987B040-0x000000018987B060
	public override void OnDisable() {} // 0x000000018184C490-0x000000018184C5A0
}

