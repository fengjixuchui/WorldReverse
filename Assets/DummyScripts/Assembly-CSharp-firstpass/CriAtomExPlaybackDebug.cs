/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

public static class CriAtomExPlaybackDebug // TypeDefIndex: 7238
{
	// Methods
	public static bool GetParameter(CriAtomExPlayback playback, CriAtomEx.Parameter parameterId, out float value) {
		value = default;
		return default;
	} // 0x00000001877AD7D0-0x00000001877AD8A0
	public static bool GetParameter(CriAtomExPlayback playback, CriAtomEx.Parameter parameterId, out uint value) {
		value = default;
		return default;
	} // 0x00000001877AD700-0x00000001877AD7D0
	public static bool GetParameter(CriAtomExPlayback playback, CriAtomEx.Parameter parameterId, out int value) {
		value = default;
		return default;
	} // 0x00000001877AD8A0-0x00000001877AD970
	public static bool GetAisacControl(CriAtomExPlayback playback, uint controlId, out float value) {
		value = default;
		return default;
	} // 0x00000001877AD570-0x00000001877AD640
	public static bool GetAisacControl(CriAtomExPlayback playback, string controlName, out float value) {
		value = default;
		return default;
	} // 0x00000001877AD640-0x00000001877AD700
	private static extern int criAtomExPlayback_GetParameterFloat32(uint id, int parameterId, out float value); // 0x00000001877ADBC0-0x00000001877ADCE0
	private static extern int criAtomExPlayback_GetParameterUint32(uint id, int parameterId, out uint value); // 0x00000001877ADDF0-0x00000001877ADFB0
	private static extern int criAtomExPlayback_GetParameterSint32(uint id, int parameterId, out int value); // 0x00000001877ADCE0-0x00000001877ADDF0
	private static extern int criAtomExPlayback_GetAisacControlById(uint id, uint controlId, out float value); // 0x00000001877AD970-0x00000001877ADA90
	private static extern int criAtomExPlayback_GetAisacControlByName(uint id, string controlName, out float value); // 0x00000001877ADA90-0x00000001877ADBC0
}

