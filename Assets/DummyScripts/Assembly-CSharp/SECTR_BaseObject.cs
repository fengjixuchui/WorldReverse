/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using FullInspector;
using IFix.Core;
using MihoyoOptimization;
using MoleMole;
using UnityEngine;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[fiInspectorOnly] // 0x00000001896865F0-0x0000000189686630
[RecycleType] // 0x00000001896865F0-0x0000000189686630
public class SECTR_BaseObject : SECTR_Base, IAutoAllocRecycleJobThread // TypeDefIndex: 20241
{
	// Fields
	[ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
	protected State _baseState; // 0x48
	[ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
	protected bool _isActive; // 0x4C
	[ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
	protected float _boundRadius; // 0x50
	[InspectorCollapsedFoldout] // 0x0000000189BC1460-0x0000000189BC14A0
	[InspectorCollectionShowItemDropdown] // 0x0000000189BC1460-0x0000000189BC14A0
	[ShowInInspector] // 0x0000000189BC1460-0x0000000189BC14A0
	protected BaseScenePropObject _sceneProp; // 0x58
	[NonSerialized]
	[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
	protected SECTR_BaseLayerProxy _layer; // 0x60

	// Properties
	public BaseScenePropObject sceneProp { /* [XID] */ /* 0x00000001896DAE40-0x00000001896DAE60 */ get => default; } // 0x00000001811EB3D0-0x00000001811EB470 

	// Nested types
	public enum State // TypeDefIndex: 20242
	{
		Load = 0,
		UnLoad = 1
	}

	// Constructors
	public SECTR_BaseObject() {} // 0x00000001811EC0C0-0x00000001811EC140

	// Methods
	[BlackList] // 0x00000001896BBD00-0x00000001896BBD40
	// [XID] // 0x00000001896BBD00-0x00000001896BBD40
	public virtual void AutoAllocTypeFields(IObjectPoolCluster inObjPoolCluster) {} // 0x00000001811EB010-0x00000001811EB0C0
	[BlackList] // 0x00000001896C6330-0x00000001896C6370
	// [XID] // 0x00000001896C6330-0x00000001896C6370
	public virtual void AutoRecycleTypeFields(IObjectPoolCluster inObjPoolCluster) {} // 0x00000001811EB0C0-0x00000001811EB180
	[BlackList] // 0x00000001896D0880-0x00000001896D08C0
	// [XID] // 0x00000001896D0880-0x00000001896D08C0
	public virtual void ReturnToObjectPool(IObjectPoolCluster inObjPoolCluster) {} // 0x00000001811EC010-0x00000001811EC0C0
	// [XID] // 0x00000001896E2640-0x00000001896E2660
	public SECTR_StreamObjectType GetObjectType() => default; // 0x00000001811EB320-0x00000001811EB3D0
	// [XID] // 0x00000001896E9B20-0x00000001896E9B40
	public virtual void OnPoolAllocated(IObjectPoolCluster inObjPoolCluster) {} // 0x00000001811EBF60-0x00000001811EC010
	// [XID] // 0x00000001896F0D20-0x00000001896F0D40
	public virtual void OnBeforePoolRecycled(IObjectPoolCluster inObjPoolCluster) {} // 0x00000001811EBEB0-0x00000001811EBF60
	// [XID] // 0x00000001896F8580-0x00000001896F85A0
	public override void Load(SECTR_StreamObject info, ISECTR_BaseProxy layer, bool isActive, Transform trans, int cellIndex, AssetJobPriority priority, SECTR_ThreadContext context, bool bFromUnityThread) {} // 0x00000001811EB180-0x00000001811EB320
	// [XID] // 0x00000001896FFEC0-0x00000001896FFEE0
	public override void UnLoad(SECTR_ThreadContext context, bool bFromUnityThread) {} // 0x00000001811EB640-0x00000001811EB720
	// [XID] // 0x00000001897075A0-0x00000001897075C0
	public virtual void SetActive(bool isActive) {} // 0x00000001811EBC00-0x00000001811EBCB0
	// [XID] // 0x000000018970EE80-0x000000018970EEA0
	protected virtual void PostInitObjLoad(SECTR_ScenePropInfo info, GameObject obj) {} // 0x00000001811EB470-0x00000001811EB560
	// [XID] // 0x0000000189716300-0x0000000189716320
	protected void ReleaseSceneProp(SECTR_ThreadContext tool, bool bFromUnityThread) {} // 0x00000001811EBAD0-0x00000001811EBC00
	// [XID] // 0x000000018971DD40-0x000000018971DD60
	protected bool LoadObjectDefaultCB(SECTR_GUID guid, GameObject obj) => default; // 0x00000001811EB720-0x00000001811EBA40
	// [XID] // 0x0000000189725280-0x00000001897252A0
	protected virtual void SetStreamObjectActive(GameObject obj, bool active) {} // 0x00000001811EBDE0-0x00000001811EBEB0
	// [XID] // 0x000000018972C900-0x000000018972C920
	protected void SetActiveByGuid(bool isActive, SECTR_GUID guid) {} // 0x00000001811EBCB0-0x00000001811EBDE0
}

