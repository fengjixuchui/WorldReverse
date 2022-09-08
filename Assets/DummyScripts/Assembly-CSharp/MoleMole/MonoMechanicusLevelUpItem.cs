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
	public class MonoMechanicusLevelUpItem : MonoBehaviour // TypeDefIndex: 31252
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _background; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Color _bgColor1; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Color _bgColor2; // 0x30
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _propName; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _preNum; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _nextNum; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _up; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _arrow; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MECHANICUS_ATTR _type; // 0x68
	
		// Properties
		public string propName { /* [XID] */ /* 0x0000000189922BE0-0x0000000189922C00 */ set {} } // 0x000000018493E1F0-0x000000018493E2D0
	
		// Constructors
		public MonoMechanicusLevelUpItem() {} // 0x000000018493E0D0-0x000000018493E1F0
	
		// Methods
		// [XID] // 0x0000000189913C10-0x0000000189913C30
		public void SetBgColor(int index) {} // 0x000000018493D8E0-0x000000018493DA00
		// [XID] // 0x000000018991B5F0-0x000000018991B610
		public void SetPropItem(uint gearID, uint preLevel, uint nextLevel = 0 /* Metadata: 0x00B1211D */) {} // 0x000000018493DA00-0x000000018493E0D0
	}
}
