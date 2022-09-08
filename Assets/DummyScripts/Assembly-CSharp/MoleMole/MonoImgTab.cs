/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public class MonoImgTab : MonoBehaviour, IPointerClickHandler // TypeDefIndex: 30807
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _container; // 0x18
		private bool _selected; // 0x20
		private int _index; // 0x24
		private Animator _animator; // 0x28
		private Action<int> _clickHandler; // 0x30
		private Image _icon; // 0x38
	
		// Properties
		public bool selected { /* [XID] */ /* 0x000000018966C340-0x000000018966C360 */ get => default; /* [XID] */ /* 0x00000001896741C0-0x00000001896741E0 */ set {} } // 0x00000001846FDA90-0x00000001846FDB30 0x00000001846FDF60-0x00000001846FE180
		public int index { /* [XID] */ /* 0x000000018967B9E0-0x000000018967BA00 */ set {} } // 0x00000001846FDD10-0x00000001846FDDC0
		public Action<int> onClick { /* [XID] */ /* 0x000000018968AB80-0x000000018968ABA0 */ set {} } // 0x00000001846FDDC0-0x00000001846FDF60
		public MonoUIContainer container { /* [XID] */ /* 0x00000001896928A0-0x00000001896928C0 */ get => default; } // 0x00000001846FD9F0-0x00000001846FDA90 
		public Sprite icon { /* [XID] */ /* 0x00000001896A87B0-0x00000001896A87D0 */ set {} } // 0x00000001846FDB30-0x00000001846FDD10
	
		// Constructors
		public MonoImgTab() {} // 0x00000001846FD970-0x00000001846FD9F0
	
		// Methods
		// [XID] // 0x00000001896830F0-0x0000000189683110
		public Button GetButton() => default; // 0x00000001846FD730-0x00000001846FD7E0
		// [XID] // 0x0000000189699C20-0x0000000189699C40
		private void OnEnable() {} // 0x00000001846FD7E0-0x00000001846FD8B0
		// [XID] // 0x00000001896A1340-0x00000001896A1360
		public void OnPointerClick(PointerEventData data) {} // 0x00000001846FD8B0-0x00000001846FD970
	}
}
