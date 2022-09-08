/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class PipelineCameraModule // TypeDefIndex: 32158
{
	// Fields
	public const int MODULE_NUMBER = 36; // Metadata: 0x00B14190
	public CameraDataAndFlags data; // 0x10
	public CameraModuleType type; // 0x18
	public PipelineCameraModuleConfig config; // 0x20
	public PipelineCameraGlobalConfig globalConfig; // 0x28

	// Constructors
	public PipelineCameraModule() {} // Dummy constructor
	protected PipelineCameraModule(PipelineCameraModuleConfig config, PipelineCameraGlobalConfig globalConfig, CameraDataAndFlags data, CameraModuleType type) {} // 0x0000000183D9D530-0x0000000183D9D5C0

	// Methods
	// [XID] // 0x00000001896BCE00-0x00000001896BCE20
	public virtual void Clear() {} // 0x0000000183D9C780-0x0000000183D9C820
	// [XID] // 0x00000001896C4260-0x00000001896C4280
	protected void CopyLast() {} // 0x0000000183D9C600-0x0000000183D9C780
	// [XID] // 0x00000001896CB990-0x00000001896CB9B0
	protected virtual void CopyOutput() {} // 0x0000000183D9C820-0x0000000183D9C930
	// [XID] // 0x00000001896D2C70-0x00000001896D2C90
	public virtual bool CheckFlags() => default; // 0x0000000183D9CB40-0x0000000183D9CC10
	// [XID] // 0x00000001896DA780-0x00000001896DA7A0
	public virtual void CalculateModule() {} // 0x0000000183D9C330-0x0000000183D9C3D0
	// [IDTag] // 0x00000001896E1F10-0x00000001896E1F50
	// [XID] // 0x00000001896E1F10-0x00000001896E1F50
	public static Vector3 Spherial2Cartesian(Vector3 sPos) => default; // 0x0000000183D9D090-0x0000000183D9D1A0
	// [IDTag] // 0x00000001896EC140-0x00000001896EC180
	// [XID] // 0x00000001896EC140-0x00000001896EC180
	public static Vector3 Cartesian2Spherial(Vector3 cPos) => default; // 0x0000000183D9D420-0x0000000183D9D530
	// [IDTag] // 0x00000001896F6A10-0x00000001896F6A50
	// [XID] // 0x00000001896F6A10-0x00000001896F6A50
	public static Vector3d Spherial2Cartesian(Vector3d sPos) => default; // 0x0000000183D9D1A0-0x0000000183D9D2E0
	// [IDTag] // 0x0000000189700EE0-0x0000000189700F20
	// [XID] // 0x0000000189700EE0-0x0000000189700F20
	public static Vector3d Cartesian2Spherial(Vector3d cPos) => default; // 0x0000000183D9D2E0-0x0000000183D9D420
	// [XID] // 0x000000018970B630-0x000000018970B650
	public float SpringSystem1D_Accurate(float kd, float fromP, float toP, float deltaT, float minChange, float maxChange, ref float curVelocity) => default; // 0x0000000183D9C930-0x0000000183D9CB40
	// [XID] // 0x0000000189712E50-0x0000000189712E70
	public Vector3 SpringSystem3D_Accurate(float kd, Vector3 fromP, Vector3 toP, float deltaT, float minChange, float maxChange, ref Vector3 curVelocity) => default; // 0x0000000183D9BE90-0x0000000183D9C330
	// [XID] // 0x000000018971A730-0x000000018971A750
	public static void DebugDrawBox(Vector3 center, Quaternion rot, Vector3 HalfSize, Color curColor) {} // 0x0000000183D9CC10-0x0000000183D9D090
	// [IDTag] // 0x0000000189721A90-0x0000000189721AD0
	// [XID] // 0x0000000189721A90-0x0000000189721AD0
	public static Vector2 GetCamHalfSize(float nearPlaneDist, float halfFov, float aspect) => default; // 0x0000000183D9C3D0-0x0000000183D9C4E0
	// [IDTag] // 0x000000018972C1A0-0x000000018972C1E0
	// [XID] // 0x000000018972C1A0-0x000000018972C1E0
	public static Vector2d GetCamHalfSize(double nearPlaneDist, double halfFov, double aspect) => default; // 0x0000000183D9C4E0-0x0000000183D9C600
}

