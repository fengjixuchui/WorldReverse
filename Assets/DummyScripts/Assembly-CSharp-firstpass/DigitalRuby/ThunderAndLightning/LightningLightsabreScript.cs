/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace DigitalRuby.ThunderAndLightning
{
	public class LightningLightsabreScript : LightningBoltPrefabScript // TypeDefIndex: 9680
	{
		// Fields
		// [Header] // 0x000000018978E6E0-0x000000018978E740
		// [Tooltip] // 0x000000018978E6E0-0x000000018978E740
		public float BladeHeight; // 0x218
		// [Tooltip] // 0x000000018979C710-0x000000018979C740
		public float ActivationTime; // 0x21C
		// [Tooltip] // 0x00000001897A5620-0x00000001897A5650
		public AudioSource StartSound; // 0x220
		// [Tooltip] // 0x00000001897AE370-0x00000001897AE3A0
		public AudioSource StopSound; // 0x228
		// [Tooltip] // 0x00000001897B7AC0-0x00000001897B7AF0
		public AudioSource ConstantSound; // 0x230
		private int state; // 0x238
		private Vector3 bladeStart; // 0x23C
		private Vector3 bladeDir; // 0x248
		private float bladeTime; // 0x254
		private float bladeIntensity; // 0x258
	
		// Constructors
		public LightningLightsabreScript() {} // 0x0000000186046800-0x00000001860468C0
	
		// Methods
		// [XID] // 0x00000001897C1010-0x00000001897C1030
		protected override void Start() {} // 0x0000000186045FA0-0x0000000186046040
		// [XID] // 0x0000000189725EE0-0x0000000189725F00
		protected override void Update() {} // 0x0000000186046510-0x0000000186046800
		// [XID] // 0x000000018990C380-0x000000018990C3A0
		public bool TurnOn(bool value) => default; // 0x0000000186046100-0x0000000186046450
		// [XID] // 0x000000018991B5B0-0x000000018991B5D0
		public void TurnOnGUI(bool value) {} // 0x0000000186046040-0x0000000186046100
	}
}
