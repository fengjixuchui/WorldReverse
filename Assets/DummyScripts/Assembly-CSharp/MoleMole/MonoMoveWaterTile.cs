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

namespace MoleMole
{
	public class MonoMoveWaterTile : MonoBaseBakeTile, IBakeMoveSurfaceTile // TypeDefIndex: 31792
	{
		// Fields
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public BakeTile waterRegion; // 0x40
	
		// Constructors
		public MonoMoveWaterTile() {} // 0x0000000182F22050-0x0000000182F220B0
	
		// Methods
		// [XID] // 0x0000000189979AC0-0x0000000189979AE0
		protected override BakeTile GetBakeTile(EBakeTileType type) => default; // 0x0000000182F214D0-0x0000000182F21580
		// [XID] // 0x00000001899812D0-0x00000001899812F0
		public override Vector3 GetPos() => default; // 0x0000000182F21B10-0x0000000182F21C60
		// [XID] // 0x0000000189988A60-0x0000000189988A80
		public override Bounds GetBounds() => default; // 0x0000000182F217A0-0x0000000182F21B10
		// [XID] // 0x0000000189990260-0x0000000189990280
		public void EnableMovingTile(uint routeId, int index, bool enable) {} // 0x0000000182F216D0-0x0000000182F217A0
		// [XID] // 0x0000000189997D70-0x0000000189997D90
		protected override float GetRegionHeight(Vector3 worldPos, float hitRayLength, BakeTile bakeTile) => default; // 0x0000000182F21CF0-0x0000000182F22050
	}
}
