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
	public class MonoEventTargetProgress : MonoBehaviour // TypeDefIndex: 31288
	{
		// Fields
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private Animator _animator; // 0x18
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private UnityEngine.UI.Text _title; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Color _ongoingTitle; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Color _completeTitle; // 0x38
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _subTitle; // 0x48
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private Image _hightlight; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Color _ongoingHighlight; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Color _completeHighlight; // 0x68
	
		// Properties
		public string title { /* [XID] */ /* 0x000000018975F1B0-0x000000018975F1D0 */ set {} } // 0x000000018561DE90-0x000000018561DF60
		public string subTitle { /* [XID] */ /* 0x00000001897665D0-0x00000001897665F0 */ set {} } // 0x000000018561DDC0-0x000000018561DE90
	
		// Constructors
		public MonoEventTargetProgress() {} // 0x000000018561DD40-0x000000018561DDC0
	
		// Methods
		// [XID] // 0x000000018976DC90-0x000000018976DCB0
		public void OnComplete() {} // 0x000000018561D850-0x000000018561D960
		// [XID] // 0x00000001897753C0-0x00000001897753E0
		public void OnUpdate() {} // 0x000000018561DB90-0x000000018561DC50
		// [XID] // 0x000000018977CC30-0x000000018977CC50
		public void OnShow() {} // 0x000000018561DA50-0x000000018561DB90
		// [XID] // 0x0000000189784670-0x0000000189784690
		public void OnHide() {} // 0x000000018561D960-0x000000018561DA50
		// [XID] // 0x000000018978BC60-0x000000018978BC80
		public bool IsEnd() => default; // 0x000000018561D790-0x000000018561D850
		// [XID] // 0x0000000189793110-0x0000000189793130
		public void ToOngoingColor() {} // 0x000000018561DC50-0x000000018561DD40
	}
}
