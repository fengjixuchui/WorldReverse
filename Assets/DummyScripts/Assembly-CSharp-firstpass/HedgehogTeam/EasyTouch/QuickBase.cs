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

namespace HedgehogTeam.EasyTouch
{
	public class QuickBase : MonoBehaviour // TypeDefIndex: 7255
	{
		// Fields
		public string quickActionName; // 0x18
		public bool isMultiTouch; // 0x20
		public bool is2Finger; // 0x21
		public bool isOnTouch; // 0x22
		public bool enablePickOverUI; // 0x23
		public bool resetPhysic; // 0x24
		public DirectAction directAction; // 0x28
		public AffectedAxesAction axesAction; // 0x2C
		public float sensibility; // 0x30
		public CharacterController directCharacterController; // 0x38
		public bool inverseAxisValue; // 0x40
		protected Rigidbody cachedRigidBody; // 0x48
		protected bool isKinematic; // 0x50
		protected Rigidbody2D cachedRigidBody2D; // 0x58
		protected bool isKinematic2D; // 0x60
		protected GameObjectType realType; // 0x64
		protected int fingerIndex; // 0x68
	
		// Nested types
		protected enum GameObjectType // TypeDefIndex: 7256
		{
			Auto = 0,
			Obj_3D = 1,
			Obj_2D = 2,
			UI = 3
		}
	
		public enum DirectAction // TypeDefIndex: 7257
		{
			None = 0,
			Rotate = 1,
			RotateLocal = 2,
			Translate = 3,
			TranslateLocal = 4,
			Scale = 5
		}
	
		public enum AffectedAxesAction // TypeDefIndex: 7258
		{
			X = 0,
			Y = 1,
			Z = 2,
			XY = 3,
			XZ = 4,
			YZ = 5,
			XYZ = 6
		}
	
		// Constructors
		public QuickBase() {} // 0x0000000180C9D070-0x0000000180C9D0F0
	
		// Methods
		// [XID] // 0x0000000189965E50-0x0000000189965E70
		private void Awake() {} // 0x0000000180C9BE20-0x0000000180C9BF90
		// [XID] // 0x000000018996D3F0-0x000000018996D410
		public virtual void Start() {} // 0x0000000180C9CD20-0x0000000180C9D070
		// [XID] // 0x0000000189974D10-0x0000000189974D30
		public virtual void OnEnable() {} // 0x0000000180C9CC80-0x0000000180C9CD20
		// [XID] // 0x000000018997C1B0-0x000000018997C1D0
		public virtual void OnDisable() {} // 0x0000000180C9CBE0-0x0000000180C9CC80
		// [XID] // 0x000000018967E380-0x000000018967E3A0
		protected Vector3 GetInfluencedAxis() => default; // 0x0000000180C9CA00-0x0000000180C9CBE0
		// [XID] // 0x0000000189685AF0-0x0000000189685B10
		protected void DoDirectAction(float value) {} // 0x0000000180C9C340-0x0000000180C9C8A0
		// [XID] // 0x0000000189993410-0x0000000189993430
		public void EnabledQuickComponent(string quickActionName) {} // 0x0000000180C9C8A0-0x0000000180C9CA00
		// [XID] // 0x000000018999AE10-0x000000018999AE30
		public void DisabledQuickComponent(string quickActionName) {} // 0x0000000180C9C1E0-0x0000000180C9C340
		// [XID] // 0x00000001899A2610-0x00000001899A2630
		public void DisabledAllSwipeExcepted(string quickActionName) {} // 0x0000000180C9BF90-0x0000000180C9C1E0
	}
}
