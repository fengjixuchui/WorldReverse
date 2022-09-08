/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MihoyoOptimization;
using MoleMole;
using MoleMole.Config;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class AIWaypointRoute : IAutoAllocRecycle // TypeDefIndex: 20006
{
	// Fields
	public List<AIWaypoint> waypoints; // 0x10
	public RouteType type; // 0x18
	public float arriveRange; // 0x1C
	private bool _isSet; // 0x20

	// Properties
	public bool IsSet { /* [XID] */ /* 0x000000018999C2F0-0x000000018999C310 */ get => default; /* [XID] */ /* 0x0000000189962170-0x0000000189962190 */ private set {} } // 0x00000001833BFBF0-0x00000001833BFC90 0x00000001833BFB40-0x00000001833BFBF0

	// Constructors
	public AIWaypointRoute() {} // 0x00000001833BFE70-0x00000001833BFED0

	// Methods
	[BlackList] // 0x00000001899264E0-0x0000000189926520
	// [XID] // 0x00000001899264E0-0x0000000189926520
	public virtual void AutoAllocTypeFields() {} // 0x00000001833BF6E0-0x00000001833BF780
	[BlackList] // 0x0000000189930C00-0x0000000189930C40
	// [XID] // 0x0000000189930C00-0x0000000189930C40
	public virtual void AutoRecycleTypeFields() {} // 0x00000001833BF780-0x00000001833BF830
	[BlackList] // 0x000000018993B430-0x000000018993B470
	// [XID] // 0x000000018993B430-0x000000018993B470
	public virtual void ReturnToObjectPool() {} // 0x00000001833BFDD0-0x00000001833BFE70
	[BlackList] // 0x0000000189945880-0x00000001899458C0
	// [XID] // 0x0000000189945880-0x00000001899458C0
	public virtual void OnPoolAllocated() {} // 0x00000001833BFD30-0x00000001833BFDD0
	[BlackList] // 0x000000018994FF10-0x000000018994FF50
	// [XID] // 0x000000018994FF10-0x000000018994FF50
	public virtual void OnBeforePoolRecycled() {} // 0x00000001833BFC90-0x00000001833BFD30
	// [XID] // 0x000000018976F060-0x000000018976F080
	public void InitRoute(ConfigRoute configRoute) {} // 0x00000001833BF830-0x00000001833BFA90
	// [XID] // 0x0000000189971280-0x00000001899712A0
	public void InitRouteLeader(int leaderId) {} // 0x00000001833BFA90-0x00000001833BFB40
}

