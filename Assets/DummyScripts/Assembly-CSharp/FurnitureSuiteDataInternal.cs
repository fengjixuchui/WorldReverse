/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class FurnitureSuiteDataInternal // TypeDefIndex: 20826
{
	// Fields
	public uint furnitureSetID; // 0x10
	public int roomID; // 0x14
	public float suiteRadius; // 0x18
	public float suiteHeight; // 0x1C
	public FurnitureDataInternal rootFurniture; // 0x20
	public List<FurnitureDataInternal> setFurnitureList; // 0x28
	public Action<FurnitureSuiteDataInternal> allFurnitureLoadedCallback; // 0x30
	public HashSet<GadgetEntity> furnituresOnLoading; // 0x38

	// Properties
	public Vector3 suiteCenter { /* [XID] */ /* 0x0000000189ADD830-0x0000000189ADD850 */ get => default; } // 0x0000000182723AA0-0x0000000182723BF0 
	public GadgetEntity rootEntity { /* [XID] */ /* 0x0000000189AE4FE0-0x0000000189AE5000 */ get => default; } // 0x0000000182723930-0x00000001827239E0 

	// Constructors
	public FurnitureSuiteDataInternal() {} // Dummy constructor
	public FurnitureSuiteDataInternal(uint setID, ConfigHomeworldFurnitureSet jsonConfig, FurnitureDataInternal rootFurniture) {} // 0x0000000182724050-0x0000000182724170

	// Methods
	// [XID] // 0x0000000189AEC660-0x0000000189AEC680
	public bool IsFurnitureSuiteReady() => default; // 0x00000001827239E0-0x0000000182723AA0
	// [XID] // 0x0000000189AF40F0-0x0000000189AF4110
	public void AddFurniture(FurnitureDataInternal furniture) {} // 0x0000000182723F60-0x0000000182724050
	// [XID] // 0x0000000189AFB8A0-0x0000000189AFB8C0
	public void FurnitureLoaded(GadgetEntity furniture) {} // 0x0000000182723BF0-0x0000000182723F60
	// [XID] // 0x0000000189B02F30-0x0000000189B02F50
	public bool IsFurnitureInRange(GadgetEntity furniture) => default; // 0x0000000182723760-0x0000000182723930
}

