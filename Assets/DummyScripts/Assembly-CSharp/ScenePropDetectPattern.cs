/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Dest.Math;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public static class ScenePropDetectPattern // TypeDefIndex: 31807
{
	// Fields
	private const uint MAX_TREE_IN_ONE_FRAME = 4; // Metadata: 0x00B13713
	private const uint TREE_BUFF = 64; // Metadata: 0x00B13717
	private static ScenePropBoxInfo[] checkTreeInfos; // 0x00
	private const uint MAX_BUSH_IN_ONE_FRAME = 12; // Metadata: 0x00B1371B
	private const uint BUSH_BUFF = 128; // Metadata: 0x00B1371F
	private static ScenePropBoxInfo[] checkBushInfos; // 0x08
	private const uint MAX_WATER_IN_ONE_FRAME = 200; // Metadata: 0x00B13723
	private const uint WATER_BUFF = 256; // Metadata: 0x00B13727
	private static ScenePropBoundsInfo[] checkWaterInfos; // 0x10
	private const uint MAX_GRASS_IN_ONE_FRAME = 200; // Metadata: 0x00B1372B

	// Constructors
	static ScenePropDetectPattern() {} // 0x000000018323D350-0x000000018323D430

	// Methods
	// [XID] // 0x0000000189675650-0x0000000189675670
	public static List<CollisionResult> FanCylinderCollisionDetectBySphere(ref AttackResultContext resultContext, Vector3 centerPoint, float radius, Vector3 direction, float fanAngle, float height, List<CollisionResult> results, ElementType type, bool forceCreate, EntityAttackFilter entityAttackFilter) => default; // 0x000000018323B2E0-0x000000018323B5F0
	// [IDTag] // 0x0000000189B8FE20-0x0000000189B8FE60
	// [XID] // 0x0000000189B8FE20-0x0000000189B8FE60
	public static List<CollisionResult> BoxCollisionDetectByBox(ref AttackResultContext resultContext, Vector3 centerPoint, Vector3 size, Quaternion rot, List<CollisionResult> results, ElementType type, bool forceCreate, EntityAttackFilter entityAttackFilter) => default; // 0x0000000183236A40-0x0000000183236E00
	// [XID] // 0x0000000189B99FC0-0x0000000189B99FE0
	public static List<CollisionResult> SphereCollisionDetectBySphere(ref AttackResultContext resultContext, Vector3 centerPoint, float radius, List<CollisionResult> results, ElementType type, bool forceCreate, EntityAttackFilter entityAttackFilter) => default; // 0x000000018323CA90-0x000000018323CDA0
	// [IDTag] // 0x0000000189BA16C0-0x0000000189BA1700
	// [XID] // 0x0000000189BA16C0-0x0000000189BA1700
	private static List<CollisionResult> BoxCollisionDetectByBox(ref AttackResultContext resultContext, Box3 box, List<CollisionResult> results, ElementType type, bool forceCreate, EntityAttackFilter entityAttackFilter) => default; // 0x0000000183236630-0x0000000183236A40
	// [XID] // 0x0000000189BABAD0-0x0000000189BABAF0
	public static List<CollisionResult> BoxCollisionDetectMassiveByBox(Box3 box, List<CollisionResult> results, ElementType type, bool forceCreate) => default; // 0x0000000183236370-0x0000000183236560
	// [XID] // 0x0000000189BB31C0-0x0000000189BB31E0
	public static List<CollisionResult> SphereCollisionDetectMassiveBySphere(Vector3 centerPoint, float radius, List<CollisionResult> results, ElementType type, bool forceCreate) => default; // 0x0000000183237B20-0x0000000183237CD0
	// [XID] // 0x0000000189BBA7C0-0x0000000189BBA7E0
	private static bool IsTreeCreateType(ElementType type, bool forceCreate) => default; // 0x00000001832358B0-0x0000000183235960
	// [XID] // 0x0000000189BC27E0-0x0000000189BC2800
	private static bool IsTreeReactionType(ElementType type) => default; // 0x000000018323C530-0x000000018323C5E0
	// [XID] // 0x0000000189BC9F40-0x0000000189BC9F60
	public static List<CollisionResult> TreeCollisionDetectBySphere(Vector3 centerPoint, float radius, List<CollisionResult> results, ElementType type, bool forceCreate) => default; // 0x0000000183234F40-0x00000001832357E0
	// [XID] // 0x0000000189B515C0-0x0000000189B515E0
	public static List<CollisionResult> TreeCollisionDetectByBox(Box3 box, List<CollisionResult> results, ElementType type, bool forceCreate) => default; // 0x000000018323A1F0-0x000000018323AA60
	// [XID] // 0x0000000189BD8B80-0x0000000189BD8BA0
	public static bool HasTreeInSphere(Vector3 centerPoint, float radius) => default; // 0x0000000183237E30-0x0000000183238240
	// [XID] // 0x00000001895E5740-0x00000001895E5760
	public static bool HasTreeInBox(Vector3 centerPoint, Vector3 size, Quaternion rot) => default; // 0x000000018323CDA0-0x000000018323D350
	// [XID] // 0x00000001895ED030-0x00000001895ED050
	private static bool IsBushCreateType(ElementType type, bool forceCreate) => default; // 0x000000018323B5F0-0x000000018323B6B0
	// [XID] // 0x00000001895F46F0-0x00000001895F4710
	private static bool IsBushReactionType(ElementType type) => default; // 0x0000000183237CD0-0x0000000183237D80
	// [XID] // 0x00000001895FBEE0-0x00000001895FBF00
	public static List<CollisionResult> BushCollisionDetectBySphere(Vector3 centerPoint, float radius, List<CollisionResult> results, ElementType type, bool forceCreate) => default; // 0x000000018323B6B0-0x000000018323BF50
	// [XID] // 0x0000000189603900-0x0000000189603920
	public static List<CollisionResult> BushCollisionDetectByBox(Box3 box, List<CollisionResult> results, ElementType type, bool forceCreate) => default; // 0x000000018323AA60-0x000000018323B2E0
	// [XID] // 0x000000018960B260-0x000000018960B280
	public static bool HasBushInSphere(Vector3 centerPoint, float radius) => default; // 0x000000018323C5E0-0x000000018323C9F0
	// [XID] // 0x0000000189612610-0x0000000189612630
	public static bool HasBushInBox(Vector3 centerPoint, Vector3 size, Quaternion rot) => default; // 0x0000000183235DC0-0x0000000183236370
	// [XID] // 0x0000000189619F80-0x0000000189619FA0
	private static bool IsWaterCreateType(ElementType type, bool forceCreate) => default; // 0x00000001832357E0-0x00000001832358B0
	// [XID] // 0x0000000189940670-0x0000000189940690
	private static bool IsWaterReactionType(ElementType type) => default; // 0x000000018323C9F0-0x000000018323CA90
	// [XID] // 0x00000001896F4E80-0x00000001896F4EA0
	public static List<CollisionResult> WaterCollisionDetectBySphere(Vector3 centerPoint, float radius, List<CollisionResult> results, ElementType type, bool forceCreate) => default; // 0x0000000183239960-0x000000018323A1F0
	// [XID] // 0x0000000189931780-0x00000001899317A0
	public static List<CollisionResult> WaterCollisionDetectByBox(Box3 box, List<CollisionResult> results, ElementType type, bool forceCreate) => default; // 0x00000001832390E0-0x0000000183239960
	// [XID] // 0x00000001896381C0-0x00000001896381E0
	public static bool HasWaterInSphere(Vector3 centerPoint, float radius) => default; // 0x0000000183236E00-0x0000000183237260
	// [XID] // 0x000000018963F5A0-0x000000018963F5C0
	public static bool HasWaterInBox(Vector3 centerPoint, Vector3 size, Quaternion rot) => default; // 0x000000018323BF50-0x000000018323C530
	// [XID] // 0x0000000189646D30-0x0000000189646D50
	private static bool IsGrassCreateType(ElementType type, bool forceCreate) => default; // 0x0000000183236560-0x0000000183236630
	// [XID] // 0x00000001895F1380-0x00000001895F13A0
	private static bool IsGrassReactionType(ElementType type) => default; // 0x0000000183237D80-0x0000000183237E30
	// [XID] // 0x00000001896ED600-0x00000001896ED620
	public static List<CollisionResult> GrassCollisionDetectBySphere(Vector3 centerPoint, float radius, List<CollisionResult> results, ElementType type, bool forceCreate) => default; // 0x0000000183238810-0x00000001832390E0
	// [XID] // 0x0000000189BA74D0-0x0000000189BA74F0
	public static List<CollisionResult> GrassCollisionDetectByBox(Box3 box, List<CollisionResult> results, ElementType type, bool forceCreate) => default; // 0x0000000183237260-0x0000000183237B20
	// [XID] // 0x0000000189664BC0-0x0000000189664BE0
	public static bool HasGrassInSphere(Vector3 centerPoint, float radius) => default; // 0x0000000183235960-0x0000000183235DC0
	// [XID] // 0x000000018966C130-0x000000018966C150
	public static bool HasGrassInBox(Vector3 centerPoint, Vector3 size, Quaternion rot) => default; // 0x0000000183238240-0x0000000183238810
}

