/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class FollowServerRouteInfo : MoveInfoBase, IAutoAllocRecycle // TypeDefIndex: 20199
{
	// Fields
	public FollowServerRouteStatus status; // 0x10
	public int currentIndex; // 0x14
	public bool movingForward; // 0x18
	public float waitFinishTick; // 0x1C
	private MonsterRoute _route; // 0x20

	// Nested types
	public enum FollowServerRouteStatus // TypeDefIndex: 20200
	{
		ResumePath = 0,
		MoveToNextPoint = 1,
		RotateToTarget = 2,
		WaitPoint = 3,
		Done = 4
	}

	// Constructors
	public FollowServerRouteInfo() {} // 0x0000000182659160-0x00000001826591D0

	// Methods
	[BlackList] // 0x0000000189850E90-0x0000000189850ED0
	// [XID] // 0x0000000189850E90-0x0000000189850ED0
	public override void AutoAllocTypeFields() {} // 0x00000001826574E0-0x0000000182657580
	[BlackList] // 0x000000018985B310-0x000000018985B350
	// [XID] // 0x000000018985B310-0x000000018985B350
	public override void AutoRecycleTypeFields() {} // 0x0000000182657580-0x0000000182657630
	[BlackList] // 0x0000000189865570-0x00000001898655B0
	// [XID] // 0x0000000189865570-0x00000001898655B0
	public override void ReturnToObjectPool() {} // 0x00000001826590C0-0x0000000182659160
	// [XID] // 0x000000018986F920-0x000000018986F940
	public override void Clear() {} // 0x00000001826580C0-0x00000001826581B0
	// [XID] // 0x0000000189876FB0-0x0000000189876FD0
	private bool OnArrivedPoint(AILocomotionHandler taskHandler, AIKnowledge aiKnowledge) => default; // 0x0000000182657A80-0x0000000182657D10
	// [XID] // 0x000000018987E9E0-0x000000018987EA00
	private bool CheckWaitPoint(RoutePoint routePoint, AIKnowledge aiKnowledge) => default; // 0x0000000182658F40-0x0000000182659060
	// [XID] // 0x0000000189885E80-0x0000000189885EA0
	public override void UpdateInternal(AILocomotionHandler taskHandler, AIKnowledge aiKnowledge, LCAIBeta lcai, LCAIManager aiManager) {} // 0x0000000182658410-0x0000000182658860
	// [XID] // 0x000000018988D1A0-0x000000018988D1C0
	private void RequestUpcomingPath(uint runtimeID) {} // 0x0000000182658860-0x0000000182658DD0
	// [XID] // 0x0000000189894790-0x00000001898947B0
	public RoutePoint GetCurrentPoint() => default; // 0x0000000182657920-0x0000000182657A80
	// [XID] // 0x000000018989BDE0-0x000000018989BE00
	private bool IsArrive(AILocomotionHandler taskHandler, AIKnowledge aiKnowledge, ConfigAIFollowServerRouteData followSetting) => default; // 0x0000000182657690-0x0000000182657920
	// [XID] // 0x00000001898A3340-0x00000001898A3360
	public void RefreshRouteStartPoint(AIKnowledge aiKnowledge) {} // 0x00000001826581B0-0x0000000182658410
	// [XID] // 0x00000001898AA740-0x00000001898AA760
	public void SetRoute(MonsterRoute route, AIKnowledge aiKnowledge) {} // 0x0000000182657D10-0x00000001826580C0
	// [XID] // 0x00000001895EFD60-0x00000001895EFD80
	public bool CanFollow() => default; // 0x0000000182658E30-0x0000000182658EE0
}

