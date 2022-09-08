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
	public class MonoQuestChapterRow : MonoBehaviour // TypeDefIndex: 31292
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _titleText; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _descText; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoSimpleReusableList _questSelectContent; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _imgSign; // 0x30
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _selectMark; // 0x38
		private bool _isFold; // 0x40
		private bool _isSelected; // 0x41
	
		// Properties
		public UnityEngine.UI.Text titleText { /* [XID] */ /* 0x0000000189627470-0x0000000189627490 */ get => default; } // 0x000000018372B270-0x000000018372B310 
		public UnityEngine.UI.Text descText { /* [XID] */ /* 0x000000018962EF70-0x000000018962EF90 */ get => default; } // 0x000000018372AF50-0x000000018372AFF0 
		public MonoSimpleReusableList questSelectContent { /* [XID] */ /* 0x0000000189636930-0x0000000189636950 */ get => default; } // 0x000000018372B1D0-0x000000018372B270 
		public Image imgSign { /* [XID] */ /* 0x000000018963DE00-0x000000018963DE20 */ get => default; } // 0x000000018372AFF0-0x000000018372B090 
		public bool isFold { /* [XID] */ /* 0x000000018964CF30-0x000000018964CF50 */ get => default; /* [XID] */ /* 0x00000001896457B0-0x00000001896457D0 */ set {} } // 0x000000018372B090-0x000000018372B130 0x000000018372B430-0x000000018372B4E0
		public bool isSelected { /* [XID] */ /* 0x00000001896546C0-0x00000001896546E0 */ get => default; /* [XID] */ /* 0x000000018965BDF0-0x000000018965BE10 */ set {} } // 0x000000018372B130-0x000000018372B1D0 0x000000018372B4E0-0x000000018372B5D0
		public bool isChapterSelected { /* [XID] */ /* 0x00000001896633A0-0x00000001896633C0 */ set {} } // 0x000000018372B310-0x000000018372B430
	
		// Constructors
		public MonoQuestChapterRow() {} // 0x000000018372AED0-0x000000018372AF50
	}
}
