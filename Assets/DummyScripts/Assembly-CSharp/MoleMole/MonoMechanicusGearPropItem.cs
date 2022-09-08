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
	public class MonoMechanicusGearPropItem : MonoBehaviour // TypeDefIndex: 30392
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _propName; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _preNum; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _nextNum; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _up; // 0x30
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _max; // 0x38
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MECHANICUS_ATTR _type; // 0x40
	
		// Properties
		public string propName { /* [XID] */ /* 0x00000001896DA8F0-0x00000001896DA910 */ set {} } // 0x000000018493BC50-0x000000018493BD30
	
		// Constructors
		public MonoMechanicusGearPropItem() {} // 0x000000018493BBD0-0x000000018493BC50
	
		// Methods
		// [XID] // 0x00000001896D2D90-0x00000001896D2DB0
		public void SetPropItem(uint gearID, uint preLevel, uint nextLevel = 0 /* Metadata: 0x00B10A2C */, bool isMax = false /* Metadata: 0x00B10A30 */) {} // 0x000000018493B4F0-0x000000018493BBD0
	}
}
