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

namespace MoleMole
{
	public sealed class MonoEffectPluginForEmojiBubble : BaseMonoEffectPlugin // TypeDefIndex: 19718
	{
		// Fields
		// [Header] // 0x00000001897627B0-0x00000001897627E0
		public EmojiBubbleAlignmentHorizental AlignmentHorizental; // 0x28
		// [Header] // 0x000000018976B600-0x000000018976B630
		public EmojiBubbleAlignmentVertical AlignmentVertical; // 0x2C
		// [Header] // 0x00000001897741C0-0x00000001897741F0
		public bool UseEntityRotation; // 0x30
		// [Header] // 0x000000018977D340-0x000000018977D370
		public float BILLBOARD_DEPTH_OFFSET; // 0x34
		private Transform _followTarget; // 0x38
		private float _radiusOffset; // 0x40
	
		// Nested types
		public enum EmojiBubbleAlignmentHorizental // TypeDefIndex: 19719
		{
			Left = -1,
			Center = 0,
			Right = 1
		}
	
		public enum EmojiBubbleAlignmentVertical // TypeDefIndex: 19720
		{
			Buttom = -1,
			Center = 0,
			Top = 1
		}
	
		// Constructors
		public MonoEffectPluginForEmojiBubble() {} // 0x0000000184E45B90-0x0000000184E45C30
	
		// Methods
		// [XID] // 0x00000001897863A0-0x00000001897863C0
		public override void Awaked() {} // 0x0000000184E44EE0-0x0000000184E44F80
		// [XID] // 0x000000018978D9F0-0x000000018978DA10
		public override void Init() {} // 0x0000000184E459B0-0x0000000184E45A60
		// [XID] // 0x0000000189794F60-0x0000000189794F80
		public override void Clear() {} // 0x0000000184E44F80-0x0000000184E45080
		// [XID] // 0x000000018979D3F0-0x000000018979D410
		private void SetLayout() {} // 0x0000000184E45100-0x0000000184E45330
		// [XID] // 0x00000001897A46B0-0x00000001897A46D0
		private void FixPos() {} // 0x0000000184E45390-0x0000000184E459B0
		// [XID] // 0x00000001897ABB80-0x00000001897ABBA0
		public override void LateTick(float inDeltaTime) {} // 0x0000000184E45A60-0x0000000184E45B30
	}
}
