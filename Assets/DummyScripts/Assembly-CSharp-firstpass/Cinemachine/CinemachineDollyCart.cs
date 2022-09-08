/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using UnityEngine;
using UnityEngine.Serialization;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace Cinemachine
{
	// [DocumentationSorting] // 0x000000018975BC90-0x000000018975BCD0
	[ExecuteInEditMode] // 0x000000018975BC90-0x000000018975BCD0
	public class CinemachineDollyCart : MonoBehaviour // TypeDefIndex: 6768
	{
		// Fields
		// [Tooltip] // 0x00000001897663D0-0x0000000189766400
		public CinemachinePathBase m_Path; // 0x18
		// [Tooltip] // 0x000000018976F140-0x000000018976F170
		public UpdateMethod m_UpdateMethod; // 0x20
		// [Tooltip] // 0x00000001897783F0-0x0000000189778420
		public CinemachinePathBase.PositionUnits m_PositionUnits; // 0x24
		// [FormerlySerializedAs] // 0x0000000189781550-0x00000001897815B0
		// [Tooltip] // 0x0000000189781550-0x00000001897815B0
		public float m_Speed; // 0x28
		// [FormerlySerializedAs] // 0x000000018978E8A0-0x000000018978E900
		// [Tooltip] // 0x000000018978E8A0-0x000000018978E900
		public float m_Position; // 0x2C
	
		// Nested types
		public enum UpdateMethod // TypeDefIndex: 6769
		{
			Update = 0,
			FixedUpdate = 1
		}
	
		// Constructors
		public CinemachineDollyCart() {} // 0x0000000186CB4AA0-0x0000000186CB4B10
	
		// Methods
		// [XID] // 0x0000000189B209D0-0x0000000189B209F0
		private void FixedUpdate() {} // 0x0000000186CB46D0-0x0000000186CB47B0
		// [XID] // 0x0000000189B30170-0x0000000189B30190
		private void Update() {} // 0x0000000186CB49A0-0x0000000186CB4AA0
		// [XID] // 0x0000000189799810-0x0000000189799830
		private void SetCartPosition(float distanceAlongPath) {} // 0x0000000186CB47B0-0x0000000186CB49A0
	}
}
