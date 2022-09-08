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

namespace InControl
{
	public class TwoAxisInputControl : IInputControl // TypeDefIndex: 7629
	{
		// Fields
		public static readonly TwoAxisInputControl Null; // 0x00
		public DeadZoneFunc DeadZoneFunc; // 0x40
		private float sensitivity; // 0x48
		private float lowerDeadZone; // 0x4C
		private float upperDeadZone; // 0x50
		private float stateThreshold; // 0x54
		public bool Raw; // 0x58
		private bool thisState; // 0x59
		private bool lastState; // 0x5A
		private Vector2 thisValue; // 0x5C
		private Vector2 lastValue; // 0x64
		private bool clearInputState; // 0x6C
	
		// Properties
		public float X { /* [XID] */ /* 0x0000000189AF5000-0x0000000189AF5040 */ get; /* [XID] */ /* 0x0000000189AFF730-0x0000000189AFF770 */ protected set; } // 0x00000001877EB9F0-0x00000001877EBA60 0x00000001877EC8D0-0x00000001877EC940
		public float Y { /* [XID] */ /* 0x0000000189B09E70-0x0000000189B09EB0 */ get; /* [XID] */ /* 0x0000000189B14250-0x0000000189B14290 */ protected set; } // 0x00000001877EBA60-0x00000001877EBAD0 0x00000001877EC940-0x00000001877EC9B0
		public OneAxisInputControl Left { /* [XID] */ /* 0x0000000189B1E7B0-0x0000000189B1E7F0 */ get; protected set; } // 0x00000001877EB250-0x00000001877EB2B0 0x00000001877EBE10-0x00000001877EBE70
		public OneAxisInputControl Right { /* [XID] */ /* 0x0000000189B30290-0x0000000189B302D0 */ get; protected set; } // 0x00000001877EB360-0x00000001877EB3C0 0x00000001877EC0C0-0x00000001877EC120
		public OneAxisInputControl Up { /* [XID] */ /* 0x0000000189B42490-0x0000000189B424D0 */ get; protected set; } // 0x00000001877EB5C0-0x00000001877EB620 0x00000001877EC5C0-0x00000001877EC620
		public OneAxisInputControl Down { /* [XID] */ /* 0x0000000189B54300-0x0000000189B54340 */ get; protected set; } // 0x00000001877EAFA0-0x00000001877EB000 0x00000001877EBD50-0x00000001877EBDB0
		public ulong UpdateTick { /* [XID] */ /* 0x0000000189B66430-0x0000000189B66470 */ get; /* [XID] */ /* 0x0000000189B70AC0-0x0000000189B70B00 */ protected set; } // 0x00000001877EB620-0x00000001877EB680 0x00000001877EC620-0x00000001877EC680
		public float Sensitivity { /* [XID] */ /* 0x0000000189AAA570-0x0000000189AAA590 */ get => default; /* [XID] */ /* 0x0000000189B988F0-0x0000000189B98910 */ set {} } // 0x00000001877EB3C0-0x00000001877EB470 0x00000001877EC120-0x00000001877EC370
		public float StateThreshold { /* [XID] */ /* 0x0000000189B9FD80-0x0000000189B9FDA0 */ get => default; /* [XID] */ /* 0x0000000189B40A70-0x0000000189B40A90 */ set {} } // 0x00000001877EB470-0x00000001877EB520 0x00000001877EC370-0x00000001877EC5C0
		public float LowerDeadZone { /* [XID] */ /* 0x0000000189BAE800-0x0000000189BAE820 */ get => default; /* [XID] */ /* 0x0000000189BB5F70-0x0000000189BB5F90 */ set {} } // 0x00000001877EB2B0-0x00000001877EB360 0x00000001877EBE70-0x00000001877EC0C0
		public float UpperDeadZone { /* [XID] */ /* 0x0000000189BBD620-0x0000000189BBD640 */ get => default; /* [XID] */ /* 0x00000001899F77C0-0x00000001899F77E0 */ set {} } // 0x00000001877EB680-0x00000001877EB730 0x00000001877EC680-0x00000001877EC8D0
		public bool State { /* [XID] */ /* 0x0000000189BCCD40-0x0000000189BCCD60 */ get => default; } // 0x00000001877EB520-0x00000001877EB5C0 
		public bool LastState { /* [XID] */ /* 0x0000000189BD4400-0x0000000189BD4420 */ get => default; } // 0x00000001877EB100-0x00000001877EB1A0 
		public Vector2 Value { /* [XID] */ /* 0x0000000189A0DC60-0x0000000189A0DC80 */ get => default; } // 0x00000001877EB730-0x00000001877EB7E0 
		public Vector2 LastValue { /* [XID] */ /* 0x0000000189A1C4F0-0x0000000189A1C510 */ get => default; } // 0x00000001877EB1A0-0x00000001877EB250 
		public Vector2 Vector { /* [XID] */ /* 0x0000000189A2B160-0x0000000189A2B180 */ get => default; } // 0x00000001877EB7E0-0x00000001877EB890 
		public bool HasChanged { get; /* [XID] */ /* 0x00000001895FEB30-0x00000001895FEB70 */ protected set; } // 0x00000001877EB000-0x00000001877EB060 0x00000001877EBDB0-0x00000001877EBE10
		public bool IsPressed { /* [XID] */ /* 0x0000000189A49030-0x0000000189A49050 */ get => default; } // 0x00000001877EB060-0x00000001877EB100 
		public bool WasPressed { /* [XID] */ /* 0x0000000189A50920-0x0000000189A50940 */ get => default; } // 0x00000001877EB890-0x00000001877EB940 
		public bool WasReleased { /* [XID] */ /* 0x0000000189618370-0x0000000189618390 */ get => default; } // 0x00000001877EB940-0x00000001877EB9F0 
		public float Angle { /* [XID] */ /* 0x0000000189A5FAB0-0x0000000189A5FAD0 */ get => default; } // 0x00000001877EAEC0-0x00000001877EAFA0 
	
		// Constructors
		public TwoAxisInputControl() {} // 0x00000001877EAC20-0x00000001877EAEC0
		static TwoAxisInputControl() {} // 0x00000001877EABA0-0x00000001877EAC20
	
		// Methods
		// [XID] // 0x0000000189AE4620-0x0000000189AE4640
		public void ClearInputState() {} // 0x00000001877E9FB0-0x00000001877EA260
		// [XID] // 0x000000018966BDB0-0x000000018966BDD0
		public void Filter(TwoAxisInputControl twoAxisInputControl, float deltaTime) {} // 0x00000001877EA260-0x00000001877EA410
		// [XID] // 0x000000018967B260-0x000000018967B280
		internal void UpdateWithAxes(float x, float y, ulong updateTick, float deltaTime) {} // 0x00000001877EA410-0x00000001877EABA0
		// [IDTag] // 0x0000000189627170-0x00000001896271B0
		// [XID] // 0x0000000189627170-0x00000001896271B0
		public static implicit operator bool(TwoAxisInputControl instance) => default; // 0x00000001877EBCA0-0x00000001877EBD50
		// [IDTag] // 0x0000000189631A40-0x0000000189631A80
		// [XID] // 0x0000000189631A40-0x0000000189631A80
		public static implicit operator Vector2(TwoAxisInputControl instance) => default; // 0x00000001877EBBE0-0x00000001877EBCA0
		// [IDTag] // 0x000000018963C380-0x000000018963C3C0
		// [XID] // 0x000000018963C380-0x000000018963C3C0
		public static implicit operator Vector3(TwoAxisInputControl instance) => default; // 0x00000001877EBAD0-0x00000001877EBBE0
	}
}
