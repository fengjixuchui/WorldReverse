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
	public class MonoInLevelSimpleCombo : MonoBehaviour // TypeDefIndex: 31228
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Animator _animator; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private SmoothMask _fillBar; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _textCombo; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private uint _showComboCnt; // 0x30
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private ulong _comboBufferMsTime; // 0x38
		private uint _curCombo; // 0x40
		private ulong _comboEndTime; // 0x48
		private ulong _comboStartTime; // 0x50
	
		// Constructors
		public MonoInLevelSimpleCombo() {} // 0x000000018431A860-0x000000018431A8F0
	
		// Methods
		// [XID] // 0x0000000189986EC0-0x0000000189986EE0
		public void Init() {} // 0x000000018431A2D0-0x000000018431A3C0
		// [XID] // 0x000000018998E950-0x000000018998E970
		public void Tick() {} // 0x000000018431A720-0x000000018431A860
		// [XID] // 0x0000000189996590-0x00000001899965B0
		public void SetCombo(uint combo, ulong comboEndTime) {} // 0x000000018431A5B0-0x000000018431A720
		// [XID] // 0x000000018999E030-0x000000018999E050
		private void OnEnable() {} // 0x000000018431A3C0-0x000000018431A4A0
		// [XID] // 0x00000001899A5A90-0x00000001899A5AB0
		private void Reset() {} // 0x000000018431A4A0-0x000000018431A5B0
		// [XID] // 0x00000001899AD0F0-0x00000001899AD110
		private void OnComboInc(uint newCombo) {} // 0x000000018431A100-0x000000018431A2D0
		// [XID] // 0x00000001899B4930-0x00000001899B4950
		private void OnReset() {} // 0x0000000184319FD0-0x000000018431A100
	}
}
