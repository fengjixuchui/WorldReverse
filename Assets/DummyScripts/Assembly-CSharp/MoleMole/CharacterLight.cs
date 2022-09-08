/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	[ExecuteInEditMode] // 0x00000001896DF3A0-0x00000001896DF410
	// [RequireComponent] // 0x00000001896DF3A0-0x00000001896DF410
	public class CharacterLight : MonoBehaviour // TypeDefIndex: 26485
	{
		// Fields
		public static int lightDirShaderId; // 0x00
		public static int MainLightBrightness; // 0x04
		private Light _light; // 0x18
		private bool _isControlled; // 0x20
		public Vector3 overrideEulerAngles; // 0x24
		public static CharacterLight Instance; // 0x08
		public bool useEnviro; // 0x30
	
		// Constructors
		public CharacterLight() {} // 0x0000000181ADC520-0x0000000181ADC5D0
		static CharacterLight() {} // 0x0000000181ADC470-0x0000000181ADC520
	
		// Methods
		// [XID] // 0x00000001896EDCC0-0x00000001896EDCE0
		private void Start() {} // 0x0000000181ADBF30-0x0000000181ADC090
		// [XID] // 0x00000001896F54F0-0x00000001896F5510
		private void InitParams() {} // 0x0000000181ADBDA0-0x0000000181ADBE80
		// [XID] // 0x00000001896FCD60-0x00000001896FCD80
		public void SetControl(bool isControlled) {} // 0x0000000181ADBE80-0x0000000181ADBF30
		// [XID] // 0x0000000189704210-0x0000000189704230
		public bool IsControlled() => default; // 0x0000000181ADBD00-0x0000000181ADBDA0
		// [XID] // 0x000000018970BAC0-0x000000018970BAE0
		private void Update() {} // 0x0000000181ADC090-0x0000000181ADC470
	}
}
