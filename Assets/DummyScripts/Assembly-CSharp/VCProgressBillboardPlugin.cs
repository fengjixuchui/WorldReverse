/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class VCProgressBillboardPlugin : VCBaseBillboardPlugin // TypeDefIndex: 12167
{
	// Fields
	private MonoProgressBillboard _monoProgress; // 0x88
	private ActorAbilityPlugin _actorAbilityPlugin; // 0x90
	private float _lastProgress; // 0x98
	private ConfigProgressBillboard _config; // 0xA0
	private bool _showProgressBar; // 0xA8
	private string _progressStr; // 0xB0

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x0000000189A597D0-0x0000000189A597F0 */ get => default; } // 0x0000000183ABA430-0x0000000183ABA4D0 

	// Constructors
	public VCProgressBillboardPlugin() {} // 0x0000000183ABA3A0-0x0000000183ABA430

	// Methods
	// [XID] // 0x0000000189A61010-0x0000000189A61030
	public override void Init() {} // 0x0000000183AB9DD0-0x0000000183AB9FB0
	// [XID] // 0x0000000189A68E50-0x0000000189A68E70
	private void OnBillboardRequired() {} // 0x0000000183ABA270-0x0000000183ABA3A0
	// [XID] // 0x0000000189A700E0-0x0000000189A70100
	private void OnProgressCreated() {} // 0x0000000183AB9FB0-0x0000000183ABA0B0
	// [XID] // 0x0000000189A778C0-0x0000000189A778E0
	public void ShowProgressBar(bool show) {} // 0x0000000183ABA110-0x0000000183ABA200
	// [XID] // 0x0000000189A7EFC0-0x0000000189A7EFE0
	public override void Destroy() {} // 0x0000000183AB9960-0x0000000183AB9AC0
	// [XID] // 0x0000000189A86960-0x0000000189A86980
	public override void LateUpdateView(Vector3 cameraPosition, Vector3 billboardPosition) {} // 0x0000000183AB9AC0-0x0000000183AB9DD0
}

