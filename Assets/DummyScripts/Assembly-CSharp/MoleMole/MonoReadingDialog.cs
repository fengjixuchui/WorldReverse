/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;
using UnityEngine.UI;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public class MonoReadingDialog : MonoUIProxy // TypeDefIndex: 30574
	{
		// Fields
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private MonoElementSwitch _elementSwitch; // 0x40
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private UnityEngine.UI.Text _title; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _preview; // 0x50
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private ScrollRect _scrollRect; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _content; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _textTemplate; // 0x68
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _imageTemplate; // 0x70
		private Stack<UnityEngine.UI.Text> _textActive; // 0x78
		private Stack<UnityEngine.UI.Text> _textInactive; // 0x80
		private Stack<Image> _imageActive; // 0x88
		private Stack<Image> _imageInactive; // 0x90
	
		// Properties
		public Button closeButton { /* [XID] */ /* 0x0000000189782E60-0x0000000189782E80 */ get => default; } // 0x000000018442F0B0-0x000000018442F170 
		public string title { /* [XID] */ /* 0x00000001897A0FF0-0x00000001897A1010 */ set {} } // 0x000000018442F3B0-0x000000018442F480
		public Sprite preview { /* [XID] */ /* 0x00000001897A8660-0x00000001897A8680 */ set {} } // 0x000000018442F2F0-0x000000018442F3B0
		public bool SetItemIconShow { /* [XID] */ /* 0x00000001897B0060-0x00000001897B0080 */ set {} } // 0x000000018442F210-0x000000018442F2F0
		public ScrollRect scrollRect { /* [XID] */ /* 0x00000001897B7DB0-0x00000001897B7DD0 */ get => default; } // 0x000000018442F170-0x000000018442F210 
		public Button btnTabPrev { /* [XID] */ /* 0x00000001897BFE00-0x00000001897BFE20 */ get => default; } // 0x000000018442EFF0-0x000000018442F0B0 
		public Button btnTabNext { /* [XID] */ /* 0x00000001897C7720-0x00000001897C7740 */ get => default; } // 0x000000018442EF30-0x000000018442EFF0 
	
		// Constructors
		public MonoReadingDialog() {} // 0x000000018442EE10-0x000000018442EF30
	
		// Methods
		// [XID] // 0x000000018978A2D0-0x000000018978A2F0
		public UnityEngine.UI.Text AddText() => default; // 0x000000018442E9E0-0x000000018442EBB0
		// [XID] // 0x0000000189791B50-0x0000000189791B70
		public Image AddImage() => default; // 0x000000018442E810-0x000000018442E9E0
		// [XID] // 0x0000000189799130-0x0000000189799150
		public void Clear() {} // 0x000000018442EBB0-0x000000018442EE10
	}
}
