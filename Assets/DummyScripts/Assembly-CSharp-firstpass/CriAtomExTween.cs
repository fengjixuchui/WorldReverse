/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

public class CriAtomExTween : CriDisposable // TypeDefIndex: 7092
{
	// Fields
	private IntPtr handle; // 0x20

	// Properties
	internal IntPtr nativeHandle { get => default; } // 0x00000001877BBCF0-0x00000001877BBD50 
	public float Value { get => default; } // 0x00000001877BBC70-0x00000001877BBCF0 
	public bool IsActive { get => default; } // 0x00000001877BBC00-0x00000001877BBC70 

	// Nested types
	public enum ParameterType // TypeDefIndex: 7093
	{
		Basic = 0,
		Aisac = 1
	}

	private struct Config // TypeDefIndex: 7094
	{
		// Fields
		public Target target; // 0x00
		public ParameterType parameterType; // 0x04

		// Nested types
		public struct Target // TypeDefIndex: 7095
		{
			// Fields
			public CriAtomEx.Parameter parameterId; // 0x00
			public uint aisacIds; // 0x00
		}
	}

	// Constructors
	public CriAtomExTween() {} // 0x00000001877BB370-0x00000001877BB420
	public CriAtomExTween(CriAtomEx.Parameter parameterId) {} // 0x00000001877BB130-0x00000001877BB1B0
	public CriAtomExTween(uint aisacId) {} // 0x00000001877BB2F0-0x00000001877BB370
	public CriAtomExTween(ParameterType parameterType, uint targetId) {} // 0x00000001877BB1B0-0x00000001877BB2F0

	// Methods
	public override void Dispose() {} // 0x00000001877BADD0-0x00000001877BAE80
	public void MoveTo(ushort durationMs, float value) {} // 0x00000001877BAFC0-0x00000001877BB050
	public void MoveFrom(ushort durationMs, float value) {} // 0x00000001877BAF30-0x00000001877BAFC0
	public void Stop() {} // 0x00000001877BB0C0-0x00000001877BB130
	public void Reset() {} // 0x00000001877BB050-0x00000001877BB0C0
	~CriAtomExTween() {} // 0x00000001877BAE80-0x00000001877BAF30
	private static extern IntPtr criAtomExTween_Create(ref Config config, IntPtr work, int work_size); // 0x00000001877BB420-0x00000001877BB530
	private static extern void criAtomExTween_Destroy(IntPtr tween); // 0x00000001877BB530-0x00000001877BB620
	private static extern float criAtomExTween_GetValue(IntPtr tween); // 0x00000001877BB620-0x00000001877BB710
	private static extern void criAtomExTween_MoveTo(IntPtr tween, ushort time_ms, float value); // 0x00000001877BB910-0x00000001877BBA20
	private static extern void criAtomExTween_MoveFrom(IntPtr tween, ushort time_ms, float value); // 0x00000001877BB800-0x00000001877BB910
	private static extern void criAtomExTween_Stop(IntPtr tween); // 0x00000001877BBB10-0x00000001877BBC00
	private static extern void criAtomExTween_Reset(IntPtr tween); // 0x00000001877BBA20-0x00000001877BBB10
	private static extern bool criAtomExTween_IsActive(IntPtr tween); // 0x00000001877BB710-0x00000001877BB800
}

