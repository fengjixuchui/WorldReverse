/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace PigeonCoopToolkit.Effects.Trails
{
	public class PCTrailPoint // TypeDefIndex: 9457
	{
		// Fields
		public Vector3 Forward; // 0x10
		public Vector3 Position; // 0x1C
		public Vector3 TemporyPosition; // 0x28
		public int PointNumber; // 0x34
		private float _timeActive; // 0x38
		private float _distance; // 0x3C
	
		// Constructors
		public PCTrailPoint() {} // 0x0000000186015EB0-0x0000000186015F20
	
		// Methods
		// [XID] // 0x000000018989F1C0-0x000000018989F1E0
		public virtual void Update(float deltaTime) {} // 0x0000000186015DF0-0x0000000186015EB0
		// [XID] // 0x0000000189A59810-0x0000000189A59830
		public float TimeActive() => default; // 0x0000000186015D40-0x0000000186015DF0
		// [XID] // 0x00000001896AC5F0-0x00000001896AC610
		public void SetTimeActive(float time) {} // 0x0000000186015C90-0x0000000186015D40
		// [XID] // 0x0000000189B66240-0x0000000189B66260
		public void SetDistanceFromStart(float distance) {} // 0x0000000186015BE0-0x0000000186015C90
		// [XID] // 0x0000000189ADE680-0x0000000189ADE6A0
		public float GetDistanceFromStart() => default; // 0x0000000186015B30-0x0000000186015BE0
	}
}
