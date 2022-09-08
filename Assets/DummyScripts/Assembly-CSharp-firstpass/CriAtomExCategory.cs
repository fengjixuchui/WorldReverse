/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

public static class CriAtomExCategory // TypeDefIndex: 7013
{
	// Nested types
	public enum ReactType // TypeDefIndex: 7014
	{
		Ducker = 0,
		AisacModulationTrigger = 1
	}

	public enum ReactDuckerTargetType // TypeDefIndex: 7015
	{
		Volume = 0,
		AisacControlValue = 1
	}

	public enum ReactDuckerCurveType // TypeDefIndex: 7016
	{
		Linear = 0,
		Square = 1,
		SquareReverse = 2,
		SCurve = 3,
		FlatAtHalf = 4
	}

	public struct ReactFadeParameter // TypeDefIndex: 7017
	{
		// Fields
		public ReactDuckerCurveType curveType; // 0x00
		public float curveStrength; // 0x04
		public ushort fadeTimeMs; // 0x08
	}

	public enum ReactHoldType // TypeDefIndex: 7018
	{
		WhilePlaying = 0,
		FixedTime = 1
	}

	public struct ReactDuckerParameter // TypeDefIndex: 7019
	{
		// Fields
		public Target target; // 0x00
		public ReactDuckerTargetType targetType; // 0x08
		public ReactFadeParameter entry; // 0x0C
		public ReactFadeParameter exit; // 0x18
		public ReactHoldType holdType; // 0x24
		public ushort holdTimeMs; // 0x28

		// Nested types
		public struct Volume // TypeDefIndex: 7020
		{
			// Fields
			public float level; // 0x00
		}

		public struct AisacControl // TypeDefIndex: 7021
		{
			// Fields
			public ushort id; // 0x00
			public float value; // 0x04
		}

		public struct Target // TypeDefIndex: 7022
		{
			// Fields
			public Volume volume; // 0x00
			public AisacControl aisacControl; // 0x00
		}
	}

	public struct ReactAisacModulationParameter // TypeDefIndex: 7023
	{
		// Fields
		private int _enableDecrementAisacModulationKey; // 0x00
		public uint decrementAisacModulationKey; // 0x04
		private int _enableIncrementAisacModulationKey; // 0x08
		public uint incrementAisacModulationKey; // 0x0C

		// Properties
		public bool enableDecrementAisacModulationKey { get => default; } // 0x00000001877C8990-0x00000001877C89F0 
		public bool enableIncrementAisacModulationKey { get => default; } // 0x00000001877C89F0-0x00000001877C8BC0 
	}

	public struct ReactParameter // TypeDefIndex: 7024
	{
		// Fields
		public Parameter parameter; // 0x00
		public ReactType type; // 0x2C
		public bool enablePausingCue; // 0x30

		// Nested types
		public struct Parameter // TypeDefIndex: 7025
		{
			// Fields
			public ReactDuckerParameter ducker; // 0x00
			public ReactAisacModulationParameter aisacModulation; // 0x00
		}
	}

	// Methods
	public static void SetVolume(string name, float volume) {} // 0x00000001877A5960-0x00000001877A59E0
	public static void SetVolume(int id, float volume) {} // 0x00000001877A59E0-0x00000001877A5A60
	public static float GetVolume(string name) => default; // 0x00000001877A5110-0x00000001877A5190
	public static float GetVolume(int id) => default; // 0x00000001877A5190-0x00000001877A5200
	public static void Mute(string name, bool mute) {} // 0x00000001877A54A0-0x00000001877A5520
	public static void Mute(int id, bool mute) {} // 0x00000001877A5520-0x00000001877A55A0
	public static bool IsMuted(string name) => default; // 0x00000001877A5270-0x00000001877A52E0
	public static bool IsMuted(int id) => default; // 0x00000001877A5200-0x00000001877A5270
	public static void Solo(string name, bool solo, float muteVolume) {} // 0x00000001877A5A60-0x00000001877A5AF0
	public static void Solo(int id, bool solo, float muteVolume) {} // 0x00000001877A5AF0-0x00000001877A5B80
	public static bool IsSoloed(string name) => default; // 0x00000001877A5430-0x00000001877A54A0
	public static bool IsSoloed(int id) => default; // 0x00000001877A53C0-0x00000001877A5430
	public static void Pause(string name, bool pause) {} // 0x00000001877A55A0-0x00000001877A5620
	public static void Pause(int id, bool pause) {} // 0x00000001877A5620-0x00000001877A56A0
	public static bool IsPaused(string name) => default; // 0x00000001877A5350-0x00000001877A53C0
	public static bool IsPaused(int id) => default; // 0x00000001877A52E0-0x00000001877A5350
	public static void SetAisacControl(string name, string controlName, float value) {} // 0x00000001877A5730-0x00000001877A57C0
	[Obsolete] // 0x00000001898C51A0-0x00000001898C51D0
	public static void SetAisac(string name, string controlName, float value) {} // 0x00000001877A5850-0x00000001877A58E0
	public static void SetAisacControl(int id, int controlId, float value) {} // 0x00000001877A56A0-0x00000001877A5730
	[Obsolete] // 0x00000001898C51A0-0x00000001898C51D0
	public static void SetAisac(int id, int controlId, float value) {} // 0x00000001877A57C0-0x00000001877A5850
	public static void SetReactParameter(string name, ReactParameter parameter) {} // 0x00000001877A58E0-0x00000001877A5960
	public static bool GetReactParameter(string name, out ReactParameter parameter) {
		parameter = default;
		return default;
	} // 0x00000001877A5090-0x00000001877A5110
	public static bool GetAttachedAisacInfoById(uint id, int aisacAttachedIndex, out CriAtomEx.AisacInfo aisacInfo) {
		aisacInfo = default;
		return default;
	} // 0x00000001877A4D90-0x00000001877A4F10
	public static bool GetAttachedAisacInfoByName(string name, int aisacAttachedIndex, out CriAtomEx.AisacInfo aisacInfo) {
		aisacInfo = default;
		return default;
	} // 0x00000001877A4F10-0x00000001877A5090
	private static extern void criAtomExCategory_SetVolumeByName(string name, float volume); // 0x00000001877A6FD0-0x00000001877A70E0
	private static extern float criAtomExCategory_GetVolumeByName(string name); // 0x00000001877A6010-0x00000001877A6120
	private static extern void criAtomExCategory_SetVolumeById(int id, float volume); // 0x00000001877A6EE0-0x00000001877A6FD0
	private static extern float criAtomExCategory_GetVolumeById(int id); // 0x00000001877A5F20-0x00000001877A6010
	private static extern void criAtomExCategory_MuteById(int id, bool mute); // 0x00000001877A6720-0x00000001877A6810
	private static extern bool criAtomExCategory_IsMutedById(int id); // 0x00000001877A6120-0x00000001877A6210
	private static extern void criAtomExCategory_MuteByName(string name, bool mute); // 0x00000001877A6810-0x00000001877A6920
	private static extern bool criAtomExCategory_IsMutedByName(string name); // 0x00000001877A6210-0x00000001877A6320
	private static extern void criAtomExCategory_SoloById(int id, bool solo, float volume); // 0x00000001877A70E0-0x00000001877A71F0
	private static extern bool criAtomExCategory_IsSoloedById(int id); // 0x00000001877A6520-0x00000001877A6610
	private static extern void criAtomExCategory_SoloByName(string name, bool solo, float volume); // 0x00000001877A71F0-0x00000001877A7310
	private static extern bool criAtomExCategory_IsSoloedByName(string name); // 0x00000001877A6610-0x00000001877A6720
	private static extern void criAtomExCategory_PauseById(int id, bool pause); // 0x00000001877A6920-0x00000001877A6A10
	private static extern bool criAtomExCategory_IsPausedById(int id); // 0x00000001877A6320-0x00000001877A6410
	private static extern void criAtomExCategory_PauseByName(string name, bool pause); // 0x00000001877A6A10-0x00000001877A6B20
	private static extern bool criAtomExCategory_IsPausedByName(string name); // 0x00000001877A6410-0x00000001877A6520
	private static extern void criAtomExCategory_SetAisacControlById(int id, ushort controlId, float value); // 0x00000001877A6B20-0x00000001877A6C30
	private static extern void criAtomExCategory_SetAisacControlByName(string name, string controlName, float value); // 0x00000001877A6C30-0x00000001877A6D60
	private static extern void criAtomExCategory_SetReactParameter(string react_name, ref ReactParameter parameter); // 0x00000001877A6D60-0x00000001877A6EE0
	private static extern bool criAtomExCategory_GetReactParameter(string react_name, out ReactParameter parameter); // 0x00000001877A5DA0-0x00000001877A5F20
	private static extern bool criAtomExCategory_GetAttachedAisacInfoById(uint id, int aisacAttachedIndex, IntPtr aisacInfo); // 0x00000001877A5B80-0x00000001877A5C80
	private static extern bool criAtomExCategory_GetAttachedAisacInfoByName(string name, int aisacAttachedIndex, IntPtr aisacInfo); // 0x00000001877A5C80-0x00000001877A5DA0
}

