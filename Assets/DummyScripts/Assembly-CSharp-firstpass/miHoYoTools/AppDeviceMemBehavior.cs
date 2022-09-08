/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using UnityEngine;
using UnityEngine.UI;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace miHoYoTools
{
	public class AppDeviceMemBehavior : MonoBehaviour // TypeDefIndex: 8459
	{
		// Fields
		public bool Enable; // 0x18
		public int MemNormal; // 0x1C
		public int MemWarning; // 0x20
		public int MemUrgent; // 0x24
		public int MemCritical; // 0x28
		public float UpdateInterval; // 0x2C
		private DeviceMemory _DeviceMemory; // 0x30
		private int _CurrentMemoryInMB; // 0x38
		private float _UpdateTimer; // 0x3C
		private UnityEngine.UI.Text _TextAppTotalMem; // 0x40
		private Image _ImageCritical; // 0x48
		private Color[] _MemLevelColor; // 0x50
	
		// Constructors
		public AppDeviceMemBehavior() {} // 0x00000001853EB840-0x00000001853EB9C0
	
		// Methods
		// [XID] // 0x000000018971E9E0-0x000000018971EA00
		private void Start() {} // 0x00000001853EAF30-0x00000001853EB000
		// [XID] // 0x0000000189726140-0x0000000189726160
		private void OnEnable() {} // 0x00000001853EAE50-0x00000001853EAF30
		// [XID] // 0x000000018993A8E0-0x000000018993A900
		private void OnDisable() {} // 0x00000001853EAD70-0x00000001853EAE50
		// [XID] // 0x0000000189734EF0-0x0000000189734F10
		private void Update() {} // 0x00000001853EB0E0-0x00000001853EB330
		// [XID] // 0x00000001899CF3B0-0x00000001899CF3D0
		public void SwichEnable() {} // 0x00000001853EB000-0x00000001853EB0E0
		// [XID] // 0x0000000189743F20-0x0000000189743F40
		private void _SetupUI() {} // 0x00000001853EB530-0x00000001853EB6D0
		// [XID] // 0x00000001899E5C90-0x00000001899E5CB0
		private void _SwithBtnClick() {} // 0x00000001853EB6D0-0x00000001853EB770
		// [XID] // 0x0000000189752ED0-0x0000000189752EF0
		private AppMemoryLevel _GetCurrentLevel(int memoryInMB) => default; // 0x00000001853EB450-0x00000001853EB530
		// [XID] // 0x00000001899C0370-0x00000001899C0390
		private void _UpdateCriticalImageState(AppMemoryLevel memLevel) {} // 0x00000001853EB770-0x00000001853EB840
		// [XID] // 0x0000000189761F20-0x0000000189761F40
		private Color _GetCurrentColor(AppMemoryLevel memLevel) => default; // 0x00000001853EB330-0x00000001853EB450
	}
}
