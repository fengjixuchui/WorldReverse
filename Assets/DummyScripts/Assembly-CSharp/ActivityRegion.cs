/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class ActivityRegion // TypeDefIndex: 20646
{
	// Fields
	public uint searchId; // 0x10
	public uint regionId; // 0x14
	public RegionSearchState regionState; // 0x18
	public uint regionProgress; // 0x1C
	public bool hasEntered; // 0x20
	public List<ActivitySearchArea> areaList; // 0x28

	// Constructors
	public ActivityRegion() {} // Dummy constructor
	public ActivityRegion(uint _searchId, uint _regionId, RegionSearchState state, uint progress, bool entered) {} // 0x000000018128F160-0x000000018128F420

	// Methods
	// [XID] // 0x000000018976E1C0-0x000000018976E1E0
	public static bool IsRegionComplete(RegionSearchState state) => default; // 0x000000018128F0B0-0x000000018128F160
}

