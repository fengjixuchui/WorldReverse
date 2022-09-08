/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 38: ProBuilderCore-Unity5.dll - Assembly: ProBuilderCore-Unity5, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3356-3465

namespace ProBuilder2.Common
{
	[Serializable]
	public class pb_Renderable : ScriptableObject // TypeDefIndex: 3447
	{
		// Fields
		public Mesh mesh; // 0x18
		public UnityEngine.Material[] materials; // 0x20
		public Transform transform; // 0x28
	
		// Constructors
		public pb_Renderable() {} // 0x0000000186BB9390-0x0000000186BB93F0
	
		// Methods
		public static pb_Renderable CreateInstance(Mesh InMesh, UnityEngine.Material[] InMaterials, Transform transform = null) => default; // 0x0000000186BB9080-0x0000000186BB9130
		public static pb_Renderable CreateInstance(Mesh InMesh, UnityEngine.Material InMaterial, Transform transform = null) => default; // 0x0000000186BB8F60-0x0000000186BB9080
		public static pb_Renderable CreateInstance() => default; // 0x0000000186BB9130-0x0000000186BB9230
		public static void DestroyInstance(UnityEngine.Object ren) {} // 0x0000000186BB9230-0x0000000186BB92C0
		private void OnDestroy() {} // 0x0000000186BB92C0-0x0000000186BB9390
	}
}
