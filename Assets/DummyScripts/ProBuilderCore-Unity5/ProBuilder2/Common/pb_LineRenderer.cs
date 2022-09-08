/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 38: ProBuilderCore-Unity5.dll - Assembly: ProBuilderCore-Unity5, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3356-3465

namespace ProBuilder2.Common
{
	// [AddComponentMenu] // 0x0000000189612560-0x00000001896125A0
	[ExecuteInEditMode] // 0x0000000189612560-0x00000001896125A0
	public class pb_LineRenderer : pb_MonoBehaviourSingleton<ProBuilder2.Common.pb_LineRenderer> // TypeDefIndex: 3404
	{
		// Fields
		private HideFlags SceneCameraHideFlags; // 0x18
		private pb_ObjectPool<Mesh> pool; // 0x20
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public List<Mesh> gizmos; // 0x28
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public UnityEngine.Material mat; // 0x30
	
		// Constructors
		public pb_LineRenderer() {} // 0x0000000186BA52D0-0x0000000186BA5370
	
		// Methods
		private static Mesh MeshConstructor() => default; // 0x0000000186BA4B80-0x0000000186BA4C50
		public override void OnEnable() {} // 0x0000000186BA4E90-0x0000000186BA4FC0
		private void OnDisable() {} // 0x0000000186BA4E10-0x0000000186BA4E90
		public override void Awake() {} // 0x0000000186BA48E0-0x0000000186BA4A70
		private void OnDestroy() {} // 0x0000000186BA4C50-0x0000000186BA4E10
		public void AddLineSegments(Vector3[] segments, Color[] colors) {} // 0x0000000186BA44F0-0x0000000186BA48E0
		public void Clear() {} // 0x0000000186BA4A70-0x0000000186BA4B80
		private void OnRenderObject() {} // 0x0000000186BA4FC0-0x0000000186BA52D0
	}
}
