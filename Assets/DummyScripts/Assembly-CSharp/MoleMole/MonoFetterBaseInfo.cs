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
	public class MonoFetterBaseInfo : MonoBehaviour // TypeDefIndex: 30469
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _name; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _cv; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _birth; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _native; // 0x30
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _vision; // 0x38
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _constellation; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _desc; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _rightPartFocus; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoScrollRectExtention _rightPartScroll; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _exitButton; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _heartOrEye; // 0x68
	
		// Properties
		public GameObject rightPartFocus { /* [XID] */ /* 0x00000001898CC9C0-0x00000001898CC9E0 */ get => default; } // 0x0000000185630170-0x0000000185630210 
		public MonoScrollRectExtention rightPartScroll { /* [XID] */ /* 0x00000001898D43E0-0x00000001898D4400 */ get => default; } // 0x0000000185630210-0x00000001856302B0 
		public MonoUIContainer exitButtonPS4 { /* [XID] */ /* 0x00000001898DBBC0-0x00000001898DBBE0 */ get => default; } // 0x00000001856300D0-0x0000000185630170 
	
		// Constructors
		public MonoFetterBaseInfo() {} // 0x0000000185630070-0x00000001856300D0
	
		// Methods
		// [XID] // 0x00000001898E37A0-0x00000001898E37C0
		public void Init(AvatarDataItem configItem) {} // 0x000000018562F550-0x000000018562FE80
		// [XID] // 0x00000001898EB420-0x00000001898EB440
		private string GetLocalizedBirthString(uint month, uint day) => default; // 0x000000018562FE80-0x0000000185630070
	}
}
