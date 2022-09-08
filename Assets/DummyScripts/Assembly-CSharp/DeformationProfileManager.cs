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

public sealed class DeformationProfileManager : GlobalManager // TypeDefIndex: 20716
{
	// Fields
	private GameObject _configObj; // 0x10
	private DeformationConfig _config; // 0x18
	private uint _configHandle; // 0x20
	private Dictionary<string, DeformationMapProfile> _profileLookupTable; // 0x28

	// Constructors
	public DeformationProfileManager() {} // 0x0000000182F7D850-0x0000000182F7D8C0

	// Methods
	// [XID] // 0x00000001897B5630-0x00000001897B5650
	public override void Init() {} // 0x0000000182F7D160-0x0000000182F7D360
	// [XID] // 0x00000001897BD270-0x00000001897BD290
	private void BuildProfileLookupTable() {} // 0x0000000182F7D580-0x0000000182F7D790
	// [XID] // 0x00000001897C45E0-0x00000001897C4600
	private void UpdateDeformationSettings() {} // 0x0000000182F7CEA0-0x0000000182F7CFA0
	// [XID] // 0x00000001897CBDF0-0x00000001897CBE10
	public override void ReloadRes() {} // 0x0000000182F7D790-0x0000000182F7D850
	// [XID] // 0x00000001897D37E0-0x00000001897D3800
	public override void ClearOnLevelDestroy() {} // 0x0000000182F7CC20-0x0000000182F7CCC0
	// [XID] // 0x00000001897DB270-0x00000001897DB290
	public override void Destroy() {} // 0x0000000182F7D000-0x0000000182F7D160
	// [XID] // 0x00000001897E2900-0x00000001897E2920
	public override void LateTick() {} // 0x0000000182F7D360-0x0000000182F7D490
	// [XID] // 0x00000001897EA0A0-0x00000001897EA0C0
	public DeformationMapProfile GetProfile(string name) => default; // 0x0000000182F7D490-0x0000000182F7D580
	// [XID] // 0x00000001897F1D10-0x00000001897F1D30
	public void ApplyDeformationProfile(string profileName, Vector3 pos, Quaternion rotation) {} // 0x0000000182F7CCC0-0x0000000182F7CEA0
}

