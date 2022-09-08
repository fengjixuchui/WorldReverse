/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	[Serializable]
	public class RatioChangerByDistance // TypeDefIndex: 19699
	{
		// Fields
		public float minDistance; // 0x10
		public float maxDistance; // 0x14
		public float minDistanceRatio; // 0x18
		public float maxDistanceRatio; // 0x1C
		private float? _ratio; // 0x20
	
		// Constructors
		public RatioChangerByDistance() {} // 0x0000000183BBDDB0-0x0000000183BBDE10
	
		// Methods
		// [XID] // 0x00000001899AA8A0-0x00000001899AA8C0
		public void Tick(float distance) {} // 0x0000000183BBDB40-0x0000000183BBDD00
		// [XID] // 0x00000001899B2200-0x00000001899B2220
		public virtual void Init() {} // 0x0000000183BBDAA0-0x0000000183BBDB40
		// [XID] // 0x00000001899B95C0-0x00000001899B95E0
		public virtual void Destroy() {} // 0x0000000183BBDA00-0x0000000183BBDAA0
		// [XID] // 0x00000001899C0FB0-0x00000001899C0FD0
		protected virtual void OnRatioChanged(float ratio) {} // 0x0000000183BBDD00-0x0000000183BBDDB0
	}
}
