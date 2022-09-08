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
	public class MonoLanternRiteTaskPoint : MonoBehaviour // TypeDefIndex: 31241
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image[] _iconNoReceived; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image[] _iconReceive; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image[] _iconLock; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _lockTime; // 0x30
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _lockTimeRoot; // 0x38
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _button; // 0x40
	
		// Properties
		public Button button { /* [XID] */ /* 0x0000000189A02060-0x0000000189A02080 */ get => default; } // 0x0000000183F96A40-0x0000000183F96AE0 
		public UnityEngine.UI.Text lockTime { /* [XID] */ /* 0x0000000189A09850-0x0000000189A09870 */ get => default; } // 0x0000000183F96AE0-0x0000000183F96B80 
	
		// Constructors
		public MonoLanternRiteTaskPoint() {} // 0x0000000183F969C0-0x0000000183F96A40
	
		// Methods
		// [XID] // 0x0000000189A10FB0-0x0000000189A10FD0
		public void ShowNoReceived(bool show, int index) {} // 0x0000000183F966E0-0x0000000183F96850
		// [XID] // 0x0000000189A18360-0x0000000189A18380
		public void ShowReceive(bool show, int index) {} // 0x0000000183F96850-0x0000000183F969C0
		// [XID] // 0x0000000189A1FA10-0x0000000189A1FA30
		public void ShowLock(bool show, int index) {} // 0x0000000183F96560-0x0000000183F966E0
	}
}
