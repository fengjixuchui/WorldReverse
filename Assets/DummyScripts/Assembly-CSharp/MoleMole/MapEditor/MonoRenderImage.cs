/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole.MapEditor
{
	[ExecuteInEditMode] // 0x00000001897B1BA0-0x00000001897B1BB0
	public class MonoRenderImage : MonoBehaviour // TypeDefIndex: 31726
	{
		// Fields
		private Camera _camera; // 0x18
	
		// Properties
		public RenderImage renderImageDelegate { /* [XID] */ /* 0x0000000189A9AAD0-0x0000000189A9AB10 */ get; set; } // 0x0000000184F1CF90-0x0000000184F1CFF0 0x0000000184F1D050-0x0000000184F1D0B0
		public WillBeDestroyed onDestroyDelegate { /* [XID] */ /* 0x0000000189AAC580-0x0000000189AAC5C0 */ get; set; } // 0x0000000184F1CF30-0x0000000184F1CF90 0x0000000184F1CFF0-0x0000000184F1D050
	
		// Nested types
		public delegate void RenderImage(Camera camera, RenderTexture source, RenderTexture destination); // TypeDefIndex: 31727; 0x0000000184F1D1C0-0x0000000184F1D4B0
	
		public delegate void WillBeDestroyed(MonoRenderImage sender); // TypeDefIndex: 31728; 0x0000000184F1F7D0-0x0000000184F1FA30
	
		// Constructors
		public MonoRenderImage() {} // 0x0000000184F1CED0-0x0000000184F1CF30
	
		// Methods
		// [XID] // 0x0000000189ABE890-0x0000000189ABE8B0
		private void Awake() {} // 0x0000000184F1CB40-0x0000000184F1CBF0
		// [XID] // 0x0000000189AC6460-0x0000000189AC6480
		private void OnRenderImage(RenderTexture source, RenderTexture destination) {} // 0x0000000184F1CD30-0x0000000184F1CED0
		// [XID] // 0x0000000189ACDB60-0x0000000189ACDB80
		private void OnDestroy() {} // 0x0000000184F1CBF0-0x0000000184F1CD30
	}
}
