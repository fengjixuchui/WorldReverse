/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using miHoYoCamera;
using miHoYoThread;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class CameraStatePostTask : ThreadTask<CameraMoveData> // TypeDefIndex: 26578
{
	// Fields
	private const string CAMERA_POST_TASK_NAME = "CameraMovePost"; // Metadata: 0x00B0C55F
	private float _deltaTime; // 0x40
	private CameraStatePostProcesser _postProcesser; // 0x48

	// Properties
	public override string taskName { /* [XID] */ /* 0x0000000189903850-0x0000000189903870 */ get => default; } // 0x0000000181FA3CB0-0x0000000181FA3D60 

	// Constructors
	public CameraStatePostTask() {} // 0x0000000181FA3C30-0x0000000181FA3CB0

	// Methods
	// [XID] // 0x000000018990ADE0-0x000000018990AE00
	public override void BindTarget(object target) {} // 0x0000000181FA3870-0x0000000181FA3930
	// [XID] // 0x0000000189912A50-0x0000000189912A70
	public override void Collect() {} // 0x0000000181FA3930-0x0000000181FA3A00
	// [XID] // 0x000000018991A2C0-0x000000018991A2E0
	public override void Execute() {} // 0x0000000181FA3AD0-0x0000000181FA3BB0
}

