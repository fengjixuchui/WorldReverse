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

public abstract class ActivityRegionSearchImplementBase // TypeDefIndex: 20647
{
	// Fields
	private ActivityLogicRegionController _controller; // 0x10
	private BaseEntity _teamEntity; // 0x18

	// Properties
	protected ActivityLogicRegionController controller { /* [XID] */ /* 0x0000000189775A60-0x0000000189775A80 */ get; } // 0x0000000183AE8A10-0x0000000183AE8AB0 
	protected Vector3? localAvatarPosition { /* [XID] */ /* 0x000000018977D260-0x000000018977D280 */ get; } // 0x0000000183AE8890-0x0000000183AE8A10 

	// Constructors
	protected ActivityRegionSearchImplementBase() {} // Dummy constructor
	public ActivityRegionSearchImplementBase(ActivityLogicRegionController c) {} // 0x0000000183AE8E40-0x0000000183AE8EC0

	// Methods
	// [XID] // 0x0000000189784CE0-0x0000000189784D00
	public virtual void AreaInOutChange(ActivitySearchArea area, bool inOut) {} // 0x0000000183AE8C20-0x0000000183AE8CE0
	// [XID] // 0x000000018978C1B0-0x000000018978C1D0
	public virtual void RegionStateChange(ActivityRegion region, RegionSearchState state) {} // 0x0000000183AE8AB0-0x0000000183AE8B70
	// [XID] // 0x0000000189793700-0x0000000189793720
	public virtual void RegionProgressChange(ActivityRegion region) {} // 0x0000000183AE8CE0-0x0000000183AE8D90
	// [XID] // 0x000000018979B930-0x000000018979B950
	public virtual void AreaAppear(ActivitySearchArea area) {} // 0x0000000183AE8B70-0x0000000183AE8C20
	// [XID] // 0x00000001897A2D60-0x00000001897A2D80
	public virtual void AreaDisappear(ActivitySearchArea area) {} // 0x0000000183AE8D90-0x0000000183AE8E40
}

