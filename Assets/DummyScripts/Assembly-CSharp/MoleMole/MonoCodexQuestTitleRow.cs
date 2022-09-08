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
	public class MonoCodexQuestTitleRow : MonoBehaviour, INavSelectable // TypeDefIndex: 30504
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _titleText; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoSimpleReusableList _questSelectContent; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _navSelectMark; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Toggle _foldToggle; // 0x30
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _redpointMark; // 0x38
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Animator _animator; // 0x40
	
		// Properties
		public UnityEngine.UI.Text titleText { /* [XID] */ /* 0x0000000189918560-0x0000000189918580 */ get => default; } // 0x0000000184BA8E20-0x0000000184BA8EC0 
		public Toggle foldToggle { /* [XID] */ /* 0x000000018991FD60-0x000000018991FD80 */ get => default; } // 0x0000000184BA8C20-0x0000000184BA8CC0 
		public MonoSimpleReusableList questSelectContent { /* [XID] */ /* 0x0000000189927600-0x0000000189927620 */ get => default; } // 0x0000000184BA8D80-0x0000000184BA8E20 
		public bool isFold { /* [XID] */ /* 0x000000018992ED60-0x000000018992ED80 */ get => default; } // 0x0000000184BA8CC0-0x0000000184BA8D80 
		public bool isClickSelected { /* [XID] */ /* 0x000000018993DBB0-0x000000018993DBD0 */ set {} } // 0x0000000184BA8EC0-0x0000000184BA8FD0
	
		// Constructors
		public MonoCodexQuestTitleRow() {} // 0x0000000184BA8BA0-0x0000000184BA8C20
	
		// Methods
		// [XID] // 0x0000000189936190-0x00000001899361B0
		public void SetNavSelected(bool selected) {} // 0x0000000184BA89C0-0x0000000184BA8AB0
		// [XID] // 0x0000000189945340-0x0000000189945360
		public void SetRedPoint(bool show) {} // 0x0000000184BA8AB0-0x0000000184BA8BA0
	}
}
