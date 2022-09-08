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

public class FurnitureDataInternal // TypeDefIndex: 20825
{
	// Fields
	public uint itemID; // 0x10
	public GadgetEntity entity; // 0x18
	public HomeWorldFurnitureExcelConfig excelConfig; // 0x20
	public int roomID; // 0x28
	public MonoHomeworldPlaceCol placeCol; // 0x30
	public MonoPatternSceneProp scenePropPattern; // 0x38
	public uint furnitureHeight; // 0x40
	private GadgetEntity _parentEntity; // 0x48
	private FurnitureDataInternal _parentData; // 0x50
	public bool applyLocalTransform; // 0x58
	public Vector3 localPosition; // 0x5C
	public Vector3 localRotation; // 0x68
	private HashSet<FurnitureDataInternal> _childFurnitureSet; // 0x78
	public FurnitureSuiteDataInternal suiteData; // 0x80

	// Properties
	public FurnitureDeploySurfaceType surfaceType { /* [XID] */ /* 0x0000000189A7B6A0-0x0000000189A7B6C0 */ get => default; } // 0x00000001848CAC50-0x00000001848CAD00 
	public GadgetEntity parentEntity { /* [XID] */ /* 0x0000000189A8A740-0x0000000189A8A760 */ get => default; } // 0x00000001848CAAD0-0x00000001848CAB70 
	public FurnitureDataInternal parentData { /* [XID] */ /* 0x0000000189A91F80-0x0000000189A91FA0 */ get => default; } // 0x00000001848CA790-0x00000001848CA830 
	public HashSet<FurnitureDataInternal> childFurnitureSet { /* [XID] */ /* 0x0000000189A999E0-0x0000000189A99A00 */ get => default; } // 0x00000001848CA6F0-0x00000001848CA790 
	public bool isSuiteFurnitureUnit { /* [XID] */ /* 0x0000000189AC6990-0x0000000189AC69B0 */ get => default; } // 0x00000001848CAB70-0x00000001848CAC50 

	// Constructors
	public FurnitureDataInternal() {} // 0x00000001848CB2D0-0x00000001848CB330

	// Methods
	// [XID] // 0x0000000189A82D60-0x0000000189A82D80
	public void HandleFurnitureDestroy() {} // 0x00000001848CB110-0x00000001848CB1C0
	// [XID] // 0x0000000189AA0A40-0x0000000189AA0A60
	public void ApplyLocalTransformOnUpdateParentship(Vector3 localPostion, Vector3 localRotation) {} // 0x00000001848CB1C0-0x00000001848CB2D0
	// [XID] // 0x0000000189AA80C0-0x0000000189AA80E0
	public void UpdateParent(GadgetEntity newParentEntity, bool updateTransform = true /* Metadata: 0x00AFE5A5 */) {} // 0x00000001848CAD00-0x00000001848CB060
	// [XID] // 0x0000000189AAFCB0-0x0000000189AAFCD0
	public void AddChildFurniture(FurnitureDataInternal childFurniture) {} // 0x00000001848CA830-0x00000001848CA930
	// [XID] // 0x0000000189AB7410-0x0000000189AB7430
	public void RemoveChildFurniture(FurnitureDataInternal revFurniture) {} // 0x00000001848CA620-0x00000001848CA6F0
	// [XID] // 0x0000000189ABEE70-0x0000000189ABEE90
	public void ClearChildFurniture() {} // 0x00000001848CA930-0x00000001848CA9E0
	// [XID] // 0x0000000189ACE130-0x0000000189ACE150
	public void AttachToSuite(FurnitureSuiteDataInternal suiteData) {} // 0x00000001848CB060-0x00000001848CB110
	// [XID] // 0x0000000189AD5EE0-0x0000000189AD5F00
	public void DetachFromSuite(GadgetEntity replaceParent) {} // 0x00000001848CA9E0-0x00000001848CAAD0
}

