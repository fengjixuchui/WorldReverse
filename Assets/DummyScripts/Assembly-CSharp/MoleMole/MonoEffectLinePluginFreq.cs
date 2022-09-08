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
	public sealed class MonoEffectLinePluginFreq : MonoEffectPluginLineWave // TypeDefIndex: 19675
	{
		// Fields
		public float freq; // 0xD8
		public bool ampByFreq; // 0xDC
		public bool centered; // 0xDD
		public bool centCrest; // 0xDE
		public bool warp; // 0xDF
		public bool warpInvert; // 0xE0
		public float warpRandom; // 0xE4
		public float walkManual; // 0xE8
		public float walkAuto; // 0xEC
		public bool spiral; // 0xF0
		private float _warpT; // 0xF4
		private float _angle; // 0xF8
		private float _sinAngle; // 0xFC
		private float _sinAngleZ; // 0x100
		private double _walkShift; // 0x108
		private Vector3 _posVtx2; // 0x110
		private Vector3 _posVtxSizeMinusOne; // 0x11C
	
		// Constructors
		public MonoEffectLinePluginFreq() {} // 0x000000018469D700-0x000000018469D790
	
		// Methods
		// [XID] // 0x000000018972B0F0-0x000000018972B110
		protected override void Points() {} // 0x000000018469CEA0-0x000000018469D6A0
	}
}
