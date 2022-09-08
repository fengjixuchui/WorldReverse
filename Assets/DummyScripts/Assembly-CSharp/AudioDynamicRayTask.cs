/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using miHoYoThread;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class AudioDynamicRayTask : ThreadTask<AudioDynamicRayData> // TypeDefIndex: 26569
{
	// Fields
	private const string _taskName = "AudioDynamicRay"; // Metadata: 0x00B0C512
	private float _deltaTime; // 0x40
	private DynamicRayTask _dynamicRayTask; // 0x48
	private bool _isRunning; // 0x50

	// Properties
	public override string taskName { /* [XID] */ /* 0x0000000189762460-0x0000000189762480 */ get => default; } // 0x00000001836B2060-0x00000001836B2110 

	// Constructors
	public AudioDynamicRayTask() {} // 0x00000001836B1FF0-0x00000001836B2060

	// Methods
	// [XID] // 0x0000000189769B10-0x0000000189769B30
	protected override void InitInternal() {} // 0x00000001836B1DD0-0x00000001836B1EB0
	// [XID] // 0x0000000189771130-0x0000000189771150
	public void StartRaycheckTask() {} // 0x00000001836B1EB0-0x00000001836B1F50
	// [XID] // 0x0000000189778990-0x00000001897789B0
	public void StopRaycheckTask() {} // 0x00000001836B18B0-0x00000001836B1950
	// [XID] // 0x000000018977FF30-0x000000018977FF50
	public override void Collect() {} // 0x00000001836B19B0-0x00000001836B1AD0
	// [XID] // 0x00000001897877A0-0x00000001897877C0
	public override void Execute() {} // 0x00000001836B1C00-0x00000001836B1CC0
	// [XID] // 0x000000018978EE70-0x000000018978EE90
	protected override void OnDestroy() {} // 0x00000001836B1F50-0x00000001836B1FF0
	// [XID] // 0x0000000189796670-0x0000000189796690
	public override void Flush() {} // 0x00000001836B1CC0-0x00000001836B1D70
}

