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
	[ExecuteInEditMode] // 0x00000001897B1BA0-0x00000001897B1BB0
	public class MonoHomeworldPlaceCol : MonoBehaviour // TypeDefIndex: 20393
	{
		// Fields
		public FurnitureDeploySurfaceType furnitureSurfaceType; // 0x18
		// [Header] // 0x00000001899424C0-0x00000001899424F0
		public ColliderType colliderType; // 0x1C
		public Collider[] placeCols; // 0x20
		public bool useAllColliderForVerify; // 0x28
		// [Header] // 0x000000018994B6B0-0x000000018994B6E0
		public Collider deployVerifyCollider; // 0x30
		public Vector3[] deployVerifySpots; // 0x38
		// [Header] // 0x0000000189954430-0x0000000189954460
		public HomeworldCustomSurfaceType delpoySurfaceType; // 0x40
		public HomeworldCustomBoundData[] deploySurfaces; // 0x48
		// [Header] // 0x000000018995D800-0x000000018995D830
		public HomeworldCustomSurfaceType magnetSurfaceType; // 0x50
		public HomeworldCustomBoundData[] magnetSurfaces; // 0x58
		public HomeworldMagnetSpot[] magnetSpots; // 0x60
	
		// Properties
		public Collider attachCollider { /* [XID] */ /* 0x0000000189966730-0x0000000189966750 */ get => default; } // 0x00000001846F9630-0x00000001846F9710 
	
		// Constructors
		public MonoHomeworldPlaceCol() {} // 0x00000001846F95B0-0x00000001846F9630
	
		// Methods
		// [XID] // 0x000000018996DAB0-0x000000018996DAD0
		public void SetupPlaceColRuntime() {} // 0x00000001846F8650-0x00000001846F8B70
		// [XID] // 0x0000000189975630-0x0000000189975650
		public void UpdateDeployableSpots(Bounds deployBound, int index) {} // 0x00000001846F8B70-0x00000001846F95B0
		// [XID] // 0x000000018997C7F0-0x000000018997C810
		public Vector3 GetVerifySpotInWorld(int index) => default; // 0x00000001846F7CE0-0x00000001846F8010
		// [XID] // 0x0000000189984550-0x0000000189984570
		public bool IsSpotInDeployableSurface(Vector3 spotInWorld) => default; // 0x00000001846F8010-0x00000001846F82A0
		// [XID] // 0x000000018998BFD0-0x000000018998BFF0
		public bool IsTargetInDeployableSurface(MonoHomeworldPlaceCol targetPlaceCol) => default; // 0x00000001846F82A0-0x00000001846F85B0
		// [XID] // 0x0000000189993CF0-0x0000000189993D10
		private void OnEnable() {} // 0x00000001846F85B0-0x00000001846F8650
	}
}
