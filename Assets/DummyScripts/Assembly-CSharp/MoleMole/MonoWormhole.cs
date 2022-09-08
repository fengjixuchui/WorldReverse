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
	public class MonoWormhole : MonoBehaviour // TypeDefIndex: 30976
	{
		// Fields
		public Renderer skyboxRenderer; // 0x18
		public Animator animator; // 0x20
		public Vector3 offsetPos; // 0x28
		public Vector3 scale; // 0x34
		public string triggerFadeOut; // 0x40
		public float maxFadeInTime; // 0x48
		public float maxFadeOutTime; // 0x4C
		private float _maxFadeTime; // 0x50
		private float _wormholeFadeLerpTime; // 0x54
		private static int _skyBoxZtestMode; // 0x00
		private static int _skyBoxZwriteMode; // 0x04
		private static int _ZtestMode_Always; // 0x08
		private static int _ZtestMode_LessEqual; // 0x0C
		private bool isFadeIn; // 0x58
		public float shakeValue; // 0x5C
	
		// Constructors
		public MonoWormhole() {} // 0x00000001824ACE10-0x00000001824ACEB0
		static MonoWormhole() {} // 0x00000001824ACD50-0x00000001824ACE10
	
		// Methods
		// [XID] // 0x0000000189B01210-0x0000000189B01230
		public void FadeIn() {} // 0x00000001824AC6D0-0x00000001824AC7E0
		// [XID] // 0x0000000189B08760-0x0000000189B08780
		public void FadeOut() {} // 0x00000001824AC7E0-0x00000001824ACA20
		// [XID] // 0x0000000189B100A0-0x0000000189B100C0
		private void Update() {} // 0x00000001824ACCB0-0x00000001824ACD50
		// [XID] // 0x0000000189B17200-0x0000000189B17220
		public bool IsLerpFinish() => default; // 0x00000001824ACA20-0x00000001824ACAD0
		// [XID] // 0x0000000189B1EB80-0x0000000189B1EBA0
		private void UpdateSkyboxGalaxyFadeValue() {} // 0x00000001824ACAD0-0x00000001824ACCB0
	}
}
