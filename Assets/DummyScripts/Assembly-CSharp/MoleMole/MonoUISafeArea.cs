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
	public class MonoUISafeArea : MonoBehaviour // TypeDefIndex: 30971
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private ForceAlign _horForceAlign; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private ForceAlign _verForceAlign; // 0x1C
		private RectTransform _rectTrans; // 0x20
		private bool _isLandscape; // 0x28
	
		// Properties
		public bool isLeftAlign { /* [XID] */ /* 0x0000000189A8EB00-0x0000000189A8EB20 */ get => default; } // 0x000000018489ABC0-0x000000018489ACD0 
		public bool isRightAlign { /* [XID] */ /* 0x0000000189A96130-0x0000000189A96150 */ get => default; } // 0x000000018489ACD0-0x000000018489ADD0 
		public bool isTopAlign { /* [XID] */ /* 0x0000000189A9D640-0x0000000189A9D660 */ get => default; } // 0x000000018489ADD0-0x000000018489AED0 
		public bool isBottomAlign { /* [XID] */ /* 0x0000000189AA4E80-0x0000000189AA4EA0 */ get => default; } // 0x000000018489AAB0-0x000000018489ABC0 
		public float LeftMargin { /* [XID] */ /* 0x0000000189AAC710-0x0000000189AAC730 */ get => default; } // 0x000000018489A840-0x000000018489A910 
		public float RightMargin { /* [XID] */ /* 0x0000000189AB3F30-0x0000000189AB3F50 */ get => default; } // 0x000000018489A910-0x000000018489A9E0 
		public float TopMargin { /* [XID] */ /* 0x0000000189ABBC90-0x0000000189ABBCB0 */ get => default; } // 0x000000018489A9E0-0x000000018489AAB0 
		public float BottomMargin { /* [XID] */ /* 0x0000000189AC3400-0x0000000189AC3420 */ get => default; } // 0x000000018489A780-0x000000018489A840 
	
		// Nested types
		public enum ForceAlign // TypeDefIndex: 30972
		{
			NONE = 0,
			LEFT = 1,
			RIGHT = 2,
			TOP = 3,
			BOTTOM = 4
		}
	
		// Constructors
		public MonoUISafeArea() {} // 0x000000018489A710-0x000000018489A780
	
		// Methods
		// [XID] // 0x0000000189A7F5A0-0x0000000189A7F5C0
		private void Awake() {} // 0x000000018489A440-0x000000018489A5E0
		// [XID] // 0x0000000189A872E0-0x0000000189A87300
		private void Start() {} // 0x000000018489A5E0-0x000000018489A710
	}
}
