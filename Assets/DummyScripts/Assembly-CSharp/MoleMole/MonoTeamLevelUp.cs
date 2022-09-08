/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;
using UnityEngine.UI;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	// [RequireComponent] // 0x0000000189913C80-0x0000000189913CD0
	public class MonoTeamLevelUp : MonoBehaviour // TypeDefIndex: 31090
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _fadeOutDuration; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		public Animator _animator; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		public GameObject levelExpUpGO; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		public UnityEngine.UI.Text levelExpUpText; // 0x30
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		public GameObject levelUpgradeGO; // 0x38
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		public UnityEngine.UI.Text levelUpgradeBefore; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		public UnityEngine.UI.Text levelUpgradeAfter; // 0x48
	
		// Constructors
		public MonoTeamLevelUp() {} // 0x0000000183B5FAD0-0x0000000183B5FB50
	
		// Methods
		// [XID] // 0x0000000189953EC0-0x0000000189953EE0
		public void Init(uint lvBefore, uint lvAfter, int iconSlot, bool showPrefixString) {} // 0x0000000183B5F540-0x0000000183B5FA10
		// [XID] // 0x000000018995B6E0-0x000000018995B700
		public void CheckIconSlot(int iconSlot) {} // 0x0000000183B5F250-0x0000000183B5F400
		// [XID] // 0x00000001899632C0-0x00000001899632E0
		private string GetLevelPrefixString(bool showPrefix) => default; // 0x0000000183B5FA10-0x0000000183B5FAD0
		// [XID] // 0x000000018996A660-0x000000018996A680
		public float FadeOut() => default; // 0x0000000183B5F400-0x0000000183B5F540
	}
}
