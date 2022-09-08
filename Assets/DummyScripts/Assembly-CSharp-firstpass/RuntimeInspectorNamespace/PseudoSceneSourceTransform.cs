/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace RuntimeInspectorNamespace
{
	public class PseudoSceneSourceTransform : MonoBehaviour // TypeDefIndex: 9963
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RuntimeHierarchy m_hierarchy; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private string m_sceneName; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private bool m_hideOnDisable; // 0x28
		private HashSet<Transform> childrenCurrent; // 0x30
		private HashSet<Transform> childrenNew; // 0x38
		private bool updateChildren; // 0x40
		private bool isEnabled; // 0x41
		private bool isQuitting; // 0x42
	
		// Properties
		public RuntimeHierarchy Hierarchy { /* [XID] */ /* 0x000000018975F930-0x000000018975F950 */ get => default; /* [XID] */ /* 0x000000018976E3C0-0x000000018976E3E0 */ set {} } // 0x0000000186800B00-0x0000000186800BA0 0x0000000186800E40-0x0000000186800F40
		public string SceneName { /* [XID] */ /* 0x0000000189AAB630-0x0000000189AAB650 */ get => default; /* [XID] */ /* 0x0000000189B9B5D0-0x0000000189B9B5F0 */ set {} } // 0x0000000186800BA0-0x0000000186800C40 0x0000000186800F40-0x0000000186801040
		public bool HideOnDisable { /* [XID] */ /* 0x0000000189AD6C90-0x0000000189AD6CB0 */ get => default; /* [XID] */ /* 0x0000000189ADE5C0-0x0000000189ADE5E0 */ set {} } // 0x0000000186800A60-0x0000000186800B00 0x0000000186800D70-0x0000000186800E40
		private bool ShouldUpdateChildren { /* [XID] */ /* 0x0000000189AE5FC0-0x0000000189AE5FE0 */ get => default; } // 0x0000000186800C40-0x0000000186800D70 
	
		// Constructors
		public PseudoSceneSourceTransform() {} // 0x00000001868009A0-0x0000000186800A60
	
		// Methods
		// [XID] // 0x0000000189AED510-0x0000000189AED530
		private void OnEnable() {} // 0x0000000186800440-0x00000001868004E0
		// [XID] // 0x0000000189AF4F20-0x0000000189AF4F40
		private void OnDisable() {} // 0x0000000186800390-0x0000000186800440
		// [XID] // 0x0000000189AD91F0-0x0000000189AD9210
		private void OnApplicationQuit() {} // 0x00000001868002F0-0x0000000186800390
		// [XID] // 0x0000000189B03D30-0x0000000189B03D50
		private void OnTransformChildrenChanged() {} // 0x00000001868004E0-0x0000000186800580
		// [XID] // 0x0000000189B0B3A0-0x0000000189B0B3C0
		private void Update() {} // 0x00000001868007F0-0x00000001868009A0
		// [XID] // 0x0000000189B12BB0-0x0000000189B12BD0
		private void AddChildrenToScene() {} // 0x0000000186800180-0x00000001868002F0
		// [XID] // 0x0000000189B6EE70-0x0000000189B6EE90
		private void RemoveChildrenFromScene() {} // 0x0000000186800580-0x00000001868007F0
	}
}
