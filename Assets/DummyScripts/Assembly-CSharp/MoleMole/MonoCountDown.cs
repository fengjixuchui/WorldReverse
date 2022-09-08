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
	public class MonoCountDown : MonoBehaviour // TypeDefIndex: 31194
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _txtReadyCount; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private SimpleText _txtCount; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Animator _anim; // 0x28
		private int PARAM_STATE; // 0x30
		private int PARAM_FLASH; // 0x34
		private int PARAM_READY; // 0x38
		private int PARAM_VALUE_STATE_START; // 0x3C
		private int PARAM_VALUE_STATE_END; // 0x40
		private int PARAM_VALUE_STATE_EARLY_END; // 0x44
		private int PARAM_VALUE_FLASH_NORMAL; // 0x48
		private int PARAM_VALUE_FLASH_FLASH; // 0x4C
		private int _readyCnt; // 0x50
		private bool _isStarted; // 0x54
	
		// Constructors
		public MonoCountDown() {} // 0x0000000183F389B0-0x0000000183F38A90
	
		// Methods
		// [XID] // 0x00000001896F9770-0x00000001896F9790
		public void StartReady(float duration, float readyDuration) {} // 0x0000000183F383D0-0x0000000183F385E0
		// [XID] // 0x0000000189700F80-0x0000000189700FA0
		public void UpdateReadyText(int readyCnt) {} // 0x0000000183F38860-0x0000000183F389B0
		// [XID] // 0x00000001897086C0-0x00000001897086E0
		public void EndReady() {} // 0x0000000183F37E30-0x0000000183F38010
		// [XID] // 0x0000000189710030-0x0000000189710050
		public void StartCount(float duration) {} // 0x0000000183F381F0-0x0000000183F38300
		// [XID] // 0x00000001897173B0-0x00000001897173D0
		public void UpdateCountText(float duration) {} // 0x0000000183F386C0-0x0000000183F38860
		// [XID] // 0x000000018971EE30-0x000000018971EE50
		public void EndCount() {} // 0x0000000183F37D50-0x0000000183F37E30
		// [XID] // 0x00000001897263D0-0x00000001897263F0
		public void TerminateCount() {} // 0x0000000183F385E0-0x0000000183F386C0
		// [XID] // 0x000000018972D9D0-0x000000018972D9F0
		public void StartFlash() {} // 0x0000000183F38300-0x0000000183F383D0
		// [XID] // 0x0000000189735150-0x0000000189735170
		public void Clear() {} // 0x0000000183F37C50-0x0000000183F37D50
		// [XID] // 0x000000018973CBF0-0x000000018973CC10
		private void ResetAlpha() {} // 0x0000000183F38010-0x0000000183F38110
		// [XID] // 0x0000000189744150-0x0000000189744170
		private void OnEnable() {} // 0x0000000183F38110-0x0000000183F381F0
	}
}
