/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using FullInspector;
using IFix.Core;
using MoleMole;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[fiInspectorOnly] // 0x0000000189ABD060-0x0000000189ABD070
public abstract class SECTR_Base : ISECTR_Base // TypeDefIndex: 31939
{
	// Fields
	[ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
	protected Transform _cachedTransform; // 0x10
	[InspectorCollapsedFoldout] // 0x000000018979CFE0-0x000000018979D020
	[InspectorCollectionShowItemDropdown] // 0x000000018979CFE0-0x000000018979D020
	[ShowInInspector] // 0x000000018979CFE0-0x000000018979D020
	protected SECTR_StreamObject _streamInfo; // 0x18
	[ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
	protected int _cellIndex; // 0x20
	[ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
	protected Vector3 _position; // 0x24
	[ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
	protected Vector3 _rotation; // 0x30
	[ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
	protected Vector3 _scale; // 0x3C

	// Constructors
	protected SECTR_Base() {} // 0x0000000183D276C0-0x0000000183D27720

	// Methods
	// [XID] // 0x00000001895F6160-0x00000001895F6180
	public virtual string ReportLog() => default; // 0x0000000183D273A0-0x0000000183D276C0
	// [XID] // 0x00000001895FD460-0x00000001895FD480
	public Vector3 GetObjectPos() => default; // 0x0000000183D27040-0x0000000183D27120
	// [XID] // 0x0000000189604E20-0x0000000189604E40
	public virtual void SetObjectPos(Vector3 pos, bool force = false /* Metadata: 0x00B13A4D */) {} // 0x0000000183D27120-0x0000000183D27200
	// [XID] // 0x000000018960C7F0-0x000000018960C810
	public Vector3 GetObjectRot() => default; // 0x0000000183D26C80-0x0000000183D26D60
	// [XID] // 0x0000000189613D70-0x0000000189613D90
	public void SetObjectRot(Vector3 rot) {} // 0x0000000183D26740-0x0000000183D26810
	// [XID] // 0x000000018961B700-0x000000018961B720
	public Vector3 GetObjectScale() => default; // 0x0000000183D26BA0-0x0000000183D26C80
	// [XID] // 0x0000000189622C70-0x0000000189622C90
	public void SetObjectScale(Vector3 scale) {} // 0x0000000183D272D0-0x0000000183D273A0
	// [XID] // 0x000000018962A450-0x000000018962A470
	public virtual void Load(SECTR_StreamObject info, ISECTR_BaseProxy layer, bool isActive, Transform trans, int cellIndex, AssetJobPriority priority, SECTR_ThreadContext context, bool bFromUnityThread) {} // 0x0000000183D26810-0x0000000183D26A50
	// [XID] // 0x0000000189631C10-0x0000000189631C30
	public virtual void UnLoad(SECTR_ThreadContext context, bool bFromUnityThread) {} // 0x0000000183D27200-0x0000000183D272D0
	// [XID] // 0x0000000189639780-0x00000001896397A0
	protected void LoadByGuid(SECTR_GUID guid, AssetJobPriority priority, SECTR_Manager.LoadGameObjectCallBack cb, SECTR_ThreadContext context, bool bFromUnityThread) {} // 0x0000000183D26D60-0x0000000183D26EF0
	// [XID] // 0x0000000189640C40-0x0000000189640C60
	protected void UnloadByGuid(SECTR_GUID guid, SECTR_ThreadContext context, bool bFromUnityThread) {} // 0x0000000183D26A50-0x0000000183D26BA0
	// [XID] // 0x0000000189648590-0x00000001896485B0
	protected void UnloadObjByGuid(SECTR_GUID guid, SECTR_ThreadContext context, bool bFromUnityThread) {} // 0x0000000183D26EF0-0x0000000183D27040
}

