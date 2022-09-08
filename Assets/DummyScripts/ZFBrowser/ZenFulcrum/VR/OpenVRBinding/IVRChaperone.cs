/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Image 52: ZFBrowser.dll - Assembly: ZFBrowser, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5943-6607

namespace ZenFulcrum.VR.OpenVRBinding
{
	public struct IVRChaperone // TypeDefIndex: 6253
	{
		// Fields
		internal _GetCalibrationState GetCalibrationState; // 0x00
		internal _GetPlayAreaSize GetPlayAreaSize; // 0x08
		internal _GetPlayAreaRect GetPlayAreaRect; // 0x10
		internal _ReloadInfo ReloadInfo; // 0x18
		internal _SetSceneColor SetSceneColor; // 0x20
		internal _GetBoundsColor GetBoundsColor; // 0x28
		internal _AreBoundsVisible AreBoundsVisible; // 0x30
		internal _ForceBoundsVisible ForceBoundsVisible; // 0x38
	
		// Nested types
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate ChaperoneCalibrationState _GetCalibrationState(); // TypeDefIndex: 6254; 0x000000018647BE40-0x000000018647BFB0
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate bool _GetPlayAreaSize(ref float pSizeX, ref float pSizeZ); // TypeDefIndex: 6255; 0x000000018647ECC0-0x000000018647EE80
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate bool _GetPlayAreaRect(ref HmdQuad_t rect); // TypeDefIndex: 6256; 0x000000018647E920-0x000000018647EAB0
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate void _ReloadInfo(); // TypeDefIndex: 6257; 0x0000000186483DE0-0x0000000186483F40
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate void _SetSceneColor(HmdColor_t color); // TypeDefIndex: 6258; 0x00000001864850A0-0x00000001864852A0
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate void _GetBoundsColor(ref HmdColor_t pOutputColorArray, int nNumOutputColors, float flCollisionBoundsFadeDistance, ref HmdColor_t pOutputCameraColor); // TypeDefIndex: 6259; 0x000000018647BA80-0x000000018647BCA0
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate bool _AreBoundsVisible(); // TypeDefIndex: 6260; 0x00000001864755A0-0x0000000186475710
	
		// [UnmanagedFunctionPointer] // 0x0000000189AD3980-0x0000000189AD39A0
		internal delegate void _ForceBoundsVisible(bool bForce); // TypeDefIndex: 6261; 0x00000001864780F0-0x0000000186478280
	}
}
