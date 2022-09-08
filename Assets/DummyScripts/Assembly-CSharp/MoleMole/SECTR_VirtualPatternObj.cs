/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using FullInspector;
using IFix.Core;
using MoleMole.Config;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	[fiInspectorOnly] // 0x0000000189ABD060-0x0000000189ABD070
	public sealed class SECTR_VirtualPatternObj : MonoLightActiveBase, ISECTR_BaseProxy // TypeDefIndex: 31913
	{
		// Fields
		[ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
		private State _state; // 0x18
		public const int VirtualPatternIndex = 0; // Metadata: 0x00B13A00
		[SerializeField] // 0x00000001898034C0-0x00000001898034F0
		[ShowInInspector] // 0x00000001898034C0-0x00000001898034F0
		public Type type; // 0x1C
		[SerializeField] // 0x00000001898A44F0-0x00000001898A4520
		[ShowInInspector] // 0x00000001898A44F0-0x00000001898A4520
		public SECTR_StreamObjectSerialize _streamInfo; // 0x20
		public float magnitude; // 0x28
		[InspectorCollapsedFoldout] // 0x0000000189B32380-0x0000000189B323C0
		[InspectorCollectionShowItemDropdown] // 0x0000000189B32380-0x0000000189B323C0
		[ShowInInspector] // 0x0000000189B32380-0x0000000189B323C0
		private SECTR_BaseObject _object; // 0x30
		private Coroutine coroutine; // 0x38
	
		// Nested types
		public enum Type // TypeDefIndex: 31914
		{
			Normal = 0,
			MoveRotOrScale = 1
		}
	
		private enum State // TypeDefIndex: 31915
		{
			Invalid = 0,
			Init = 1,
			Loading = 2,
			Loaded = 3
		}
	
		// Constructors
		public SECTR_VirtualPatternObj() {} // 0x0000000184EE7E90-0x0000000184EE7F00
	
		// Methods
		// [XID] // 0x00000001898BC500-0x00000001898BC520
		public void OnTransformParentChanged() {} // 0x0000000184EE73E0-0x0000000184EE7960
		// [XID] // 0x00000001898C3B00-0x00000001898C3B20
		public void Load() {} // 0x0000000184EE6BE0-0x0000000184EE6DB0
		// [XID] // 0x00000001898CB380-0x00000001898CB3A0
		private void OnEnable() {} // 0x0000000184EE7130-0x0000000184EE72A0
		// [XID] // 0x00000001898D2A80-0x00000001898D2AA0
		private void Update() {} // 0x0000000184EE7C80-0x0000000184EE7E90
		// [XID] // 0x00000001898DA440-0x00000001898DA460
		private void OnDisable() {} // 0x0000000184EE6FE0-0x0000000184EE7130
		// [XID] // 0x00000001898E2110-0x00000001898E2130
		private void ClearCoroutine() {} // 0x0000000184EE6E50-0x0000000184EE6F40
		// [XID] // 0x00000001898E9CB0-0x00000001898E9CD0
		public void OnDestroy() {} // 0x0000000184EE6F40-0x0000000184EE6FE0
		// [XID] // 0x00000001898F1410-0x00000001898F1430
		public string ReportLog() => default; // 0x0000000184EE7960-0x0000000184EE7C80
		// [XID] // 0x00000001898F8B40-0x00000001898F8B60
		uint MoleMole.ISECTR_BaseProxy.GetRuntimeID() => default; // 0x0000000184EE6DB0-0x0000000184EE6E50
		// [XID] // 0x0000000189900510-0x0000000189900530
		public override void OnRegisterGameObjectLightweightActivate() {} // 0x0000000184EE72A0-0x0000000184EE7340
		// [XID] // 0x0000000189907C50-0x0000000189907C70
		public override void OnRegisterGameObjectLightweightDeactivate() {} // 0x0000000184EE7340-0x0000000184EE73E0
	}
}
