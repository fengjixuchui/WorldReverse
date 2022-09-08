/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using FullInspector;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public class MonoPatternSceneProp : MonoBehaviour // TypeDefIndex: 31781
	{
		// Fields
		[SerializeField] // 0x00000001898034C0-0x00000001898034F0
		[ShowInInspector] // 0x00000001898034C0-0x00000001898034F0
		public SECTR_ScenePropInfo _info; // 0x18
		[InspectorCollapsedFoldout] // 0x000000018979CFE0-0x000000018979D020
		[InspectorCollectionShowItemDropdown] // 0x000000018979CFE0-0x000000018979D020
		[ShowInInspector] // 0x000000018979CFE0-0x000000018979D020
		protected BaseScenePropObject _sceneProp; // 0x20
		public bool ignoreInBigWorld; // 0x28
	
		// Properties
		public BaseScenePropObject sceneProp { /* [XID] */ /* 0x000000018981B330-0x000000018981B350 */ get => default; } // 0x000000018371BA20-0x000000018371BAC0 
	
		// Constructors
		public MonoPatternSceneProp() {} // 0x000000018371B9B0-0x000000018371BA20
	
		// Methods
		// [XID] // 0x00000001898228E0-0x0000000189822900
		public void OnEnable() {} // 0x000000018371B8F0-0x000000018371B9B0
		// [XID] // 0x000000018982A250-0x000000018982A270
		public void OnDisable() {} // 0x000000018371B850-0x000000018371B8F0
		// [XID] // 0x00000001898315D0-0x00000001898315F0
		protected void Load(SECTR_ScenePropInfo info, GameObject obj) {} // 0x000000018371B360-0x000000018371B7A0
		// [XID] // 0x0000000189838CA0-0x0000000189838CC0
		protected void ReleaseSceneProp() {} // 0x000000018371B7A0-0x000000018371B850
	}
}
