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

[fiInspectorOnly] // 0x0000000189A06FC0-0x0000000189A07000
[RecycleType] // 0x0000000189A06FC0-0x0000000189A07000
public class BaseScenePropObject : IAutoAllocRecycle, ISceneProp // TypeDefIndex: 20026
{
	// Fields
	private static int scenePropID; // 0x00
	[ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
	protected string patternName; // 0x10
	[ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
	protected string effectPatternName; // 0x18
	[ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
	protected GameObject mainObj; // 0x20
	[ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
	protected int instanceId; // 0x28
	[ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
	protected ScenePropType sceneType; // 0x2C

	// Constructors
	public BaseScenePropObject() {} // 0x00000001821EF7A0-0x00000001821EF820
	static BaseScenePropObject() {} // 0x00000001821EF740-0x00000001821EF7A0

	// Methods
	[BlackList] // 0x000000018994FED0-0x000000018994FF10
	// [XID] // 0x000000018994FED0-0x000000018994FF10
	public virtual void AutoAllocTypeFields() {} // 0x00000001821EED50-0x00000001821EEDF0
	[BlackList] // 0x000000018995A5B0-0x000000018995A5F0
	// [XID] // 0x000000018995A5B0-0x000000018995A5F0
	public virtual void AutoRecycleTypeFields() {} // 0x00000001821EEDF0-0x00000001821EEEA0
	[BlackList] // 0x0000000189964F30-0x0000000189964F70
	// [XID] // 0x0000000189964F30-0x0000000189964F70
	public virtual void ReturnToObjectPool() {} // 0x00000001821EF6A0-0x00000001821EF740
	// [XID] // 0x000000018996F220-0x000000018996F240
	public virtual void OnPoolAllocated() {} // 0x00000001821EF550-0x00000001821EF5F0
	// [XID] // 0x0000000189976E10-0x0000000189976E30
	public virtual void OnBeforePoolRecycled() {} // 0x00000001821EF4B0-0x00000001821EF550
	// [XID] // 0x000000018997E200-0x000000018997E220
	public ScenePropType GetScenePropType() => default; // 0x00000001821EF2B0-0x00000001821EF350
	// [XID] // 0x0000000189985CF0-0x0000000189985D10
	public virtual void InitSceneProp(string name, GameObject obj, ScenePropType type, string effectPattern = null) {} // 0x00000001821EF0C0-0x00000001821EF210
	// [XID] // 0x000000018998D900-0x000000018998D920
	protected virtual void AddScenePropToManager() {} // 0x00000001821EEEA0-0x00000001821EEFB0
	// [XID] // 0x00000001899953D0-0x00000001899953F0
	protected virtual void RemoveScenePropFromManager() {} // 0x00000001821EEFB0-0x00000001821EF0C0
	// [XID] // 0x000000018999CE90-0x000000018999CEB0
	public virtual void RefreshSceneProp(GameObject obj) {} // 0x00000001821EF5F0-0x00000001821EF6A0
	// [XID] // 0x00000001899A47F0-0x00000001899A4810
	public virtual void LodLevelUpdate(int lodLevel) {} // 0x00000001821EF350-0x00000001821EF400
	// [XID] // 0x00000001899AC130-0x00000001899AC150
	public virtual void ReleaseSceneProp() {} // 0x00000001821EF400-0x00000001821EF4B0
	// [XID] // 0x00000001899B3960-0x00000001899B3980
	public int GetGameObjectID() => default; // 0x00000001821EF210-0x00000001821EF2B0
}

